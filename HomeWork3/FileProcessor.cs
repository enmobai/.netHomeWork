using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HomeWork3
{
    public static class FileProcessor
    {
        public static void ProcessFile(string filePath, TextBox txtOriginalStats, TextBox txtFormattedStats, ListBox lstWordCount)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                int originalLineCount = lines.Length;
                int originalWordCount = CountWords(lines);

                // 过滤空行和注释
                var filteredLines = lines
                    .Where(line => !string.IsNullOrWhiteSpace(line) && !line.TrimStart().StartsWith("//"))
                    .ToArray();

                int formattedLineCount = filteredLines.Length;
                int formattedWordCount = CountWords(filteredLines);

                // 统计单词出现次数
                var wordCount = CountWordOccurrences(filteredLines);

                // 显示结果
                txtOriginalStats.Text = $"原始行数: {originalLineCount}\r\n原始单词数: {originalWordCount}";
                txtFormattedStats.Text = $"格式化后行数: {formattedLineCount}\r\n格式化后单词数: {formattedWordCount}";

                // 更新单词出现次数列表
                lstWordCount.Items.Clear();
                foreach (var entry in wordCount)
                {
                    lstWordCount.Items.Add($"{entry.Key}: {entry.Value}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"处理文件时发生错误: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static int CountWords(string[] lines)
        {
            return lines.SelectMany(line => Regex.Split(line, @"\W+"))
                        .Count(word => !string.IsNullOrEmpty(word));
        }

        private static Dictionary<string, int> CountWordOccurrences(string[] lines)
        {
            var wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (var line in lines)
            {
                foreach (var word in Regex.Split(line, @"\W+"))
                {
                    if (!string.IsNullOrEmpty(word))
                    {
                        if (wordCount.ContainsKey(word))
                        {
                            wordCount[word]++;
                        }
                        else
                        {
                            wordCount[word] = 1;
                        }
                    }
                }
            }

            return wordCount;
        }
    }
}
