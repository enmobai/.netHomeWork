using Timer = System.Windows.Forms.Timer;

namespace HomeWork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeTimer();
            InitializeComponent();
            GenerateQuestion();
            

            button1.Click += new EventHandler(this.submitButton_Click); // 绑定按钮事件
        }


        private Random random = new Random();
        private int num1, num2, correctAnswer;
        private int score = 0;
        private int totalQuestions = 10;
        private int currentQuestion = 0;
        private int timePerQuestion = 10; // 每道题限时10秒
        private Timer timer;



        private void GenerateQuestion()
        {
            
            num1 = random.Next(1, 101);
            num2 = random.Next(1, 101);
            int operation = random.Next(0, 2); // 0加，1减

            switch (operation)
            {
                case 0:
                    correctAnswer = num1 + num2;
                    label2.Text = $"{num1} + {num2}";
                    break;
                case 1:
                    correctAnswer = num1 - num2;
                    label2.Text = $"{num1} - {num2}";
                    break;
            }

            textBox1.Text = "";
            label3.Text = "";

            timePerQuestion = 10;
            timer.Start();
            currentQuestion++;
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // 1秒
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = "本题剩余时间：" + timePerQuestion+"s";
            timePerQuestion--;
            if (timePerQuestion <= 0)
            {
                timer.Stop();
                label3.Text = "超时！进入下一题";
                ProceedToNextQuestion();
            }
        }

        // 提交答案
        private async void submitButton_Click(object sender, EventArgs e)
        {
            int userAnswer;
            if (int.TryParse(textBox1.Text, out userAnswer))
            {
                if (userAnswer == correctAnswer)
                {
                    score++;
                    label3.Text = "回答正确!";
                    label3.ForeColor = System.Drawing.Color.Green;
                   
                }
                else
                {
                    label3.Text = "回答错误!";
                    label3.ForeColor = System.Drawing.Color.Red;
                   
                }
                timer.Stop();
                await Task.Delay(1000);
                ProceedToNextQuestion();
            }
            else
            {
                label3.Text = "请输入有效的数字!";
            }
        }

        // 处理进入下一题
        private void ProceedToNextQuestion()
        {
            
            if (currentQuestion < totalQuestions)
            {
                GenerateQuestion();
            }
            else
            {
                timer.Stop();
                MessageBox.Show($"测验结束！你的得分是：{score}/{totalQuestions}");
                this.Close();
            }
        }
    }
}