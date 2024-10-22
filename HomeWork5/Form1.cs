using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace HomeWork5
{
    public partial class Form1 : Form
    {
        private Dictionary<string, HashSet<string>> phoneNumberUrls = new Dictionary<string, HashSet<string>>();
        private const int RequiredPhoneNumbers = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtKeyword.Text;
            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("请输入关键字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstUrls.Items.Clear();
            phoneNumberUrls.Clear();
            lblCount.Text = "正在爬取，请稍候...";

            try
            {
                await PerformSearch(keyword);
                DisplayResults();

                if (phoneNumberUrls.Count >= RequiredPhoneNumbers)
                {
                    lblCount.Text = $"成功爬取到 {phoneNumberUrls.Count} 个电话号码";
                }
                else
                {
                    lblCount.Text = "未能找到足够的电话号码";
                }
            }
            catch (Exception ex)
            {
                lblCount.Text = "爬取过程中出现错误！";
                MessageBox.Show($"错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task PerformSearch(string keyword)
        {
            string urlBaidu = $"https://www.baidu.com/s?wd={keyword}";
            string urlBing = $"https://www.bing.com/search?q={keyword}";

            await Task.WhenAll(
                SearchAndExtract(urlBaidu),
                SearchAndExtract(urlBing)
            );
        }

        private async Task SearchAndExtract(string url)
        {
            using (HttpClient client = CreateHttpClient())
            {
                try
                {
                    var response = await client.GetStringAsync(url);
                    var resultLinks = ExtractResultLinks(response);
                    foreach (var link in resultLinks)
                    {
                        await ExtractPhoneNumbersFromPage(client, link);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"请求失败: {ex.Message}");
                }
            }
        }

        private HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
            return client;
        }

        private async Task ExtractPhoneNumbersFromPage(HttpClient client, string url)
        {
            try
            {
                var response = await client.GetStringAsync(url);
                ExtractPhoneNumbers(response, url);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"无法访问链接 {url}: {ex.Message}");
            }
        }

        private List<string> ExtractResultLinks(string html)
        {
            var links = new List<string>();
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            var nodes = doc.DocumentNode.SelectNodes("//a[@href]");
            if (nodes != null)
            {
                foreach (var node in nodes)
                {
                    var href = node.GetAttributeValue("href", string.Empty);
                    if (Uri.IsWellFormedUriString(href, UriKind.Absolute) &&
                        (href.StartsWith("http://") || href.StartsWith("https://")))
                    {
                        links.Add(href);
                    }
                }
            }
            return links;
        }

        private void ExtractPhoneNumbers(string html, string sourceUrl)
        {
            var matches = Regex.Matches(html, @"(?<!\d)(\d{11}|400-\d{3}-\d{4})(?!\d)");
            foreach (Match match in matches)
            {
                string number = match.Value;

                if (!phoneNumberUrls.ContainsKey(number))
                {
                    phoneNumberUrls[number] = new HashSet<string>();
                }

                phoneNumberUrls[number].Add(sourceUrl);
            }
        }

        private void DisplayResults()
        {
            foreach (var entry in phoneNumberUrls)
            {
                lstUrls.Items.Add($"{entry.Key} : ");
                foreach (var url in entry.Value)
                {
                    lstUrls.Items.Add($"  {url}");
                }
            }
        }
    }
}
