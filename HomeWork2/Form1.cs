using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HomeWork2
{
    public partial class Form1 : Form
    {
        private ATM atm;
        private Bank bank;

        public Form1()
        {
            InitializeComponent();

            // 初始化账户
            bank = new Bank();
            bank.AddAccount(new Account("123456", 50000));
            bank.AddAccount(new CreditAccount("654321", 20000, 5000));

            
            atm = new ATM(bank);
            atm.BigMoneyFetched += Atm_BigMoneyFetched;

            btnWithdraw.Click += btnWithdraw_Click;
            btnDeposit.Click += btnDeposit_Click;
        }

        // 大笔金额取款事件处理
        private void Atm_BigMoneyFetched(object sender, BigMoneyArgs e)
        {
            MessageBox.Show($"警告：账号 {e.AccountNumber} 取走了大笔金额：{e.Amount} 元", "大笔金额提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // 存取款按钮点击
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber.Text.Trim();
            try
            {
                
                decimal amount = decimal.Parse(txtAmount.Text);
                atm.Withdraw(accountNumber, amount);
            }
            catch (BadCashException ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                if (string.IsNullOrEmpty(accountNumber))
                {
                    MessageBox.Show("请输入有效的账号。", "账号错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount))
                {
                    MessageBox.Show("请输入有效的取款金额。", "金额错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

  
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber.Text.Trim();
            try
            {
                
                decimal amount = decimal.Parse(txtAmount.Text);
                
                atm.Deposit(accountNumber, amount);
            }
            catch (Exception ex)
            {
                if (string.IsNullOrEmpty(accountNumber))
                {
                    MessageBox.Show("请输入有效的账号。", "账号错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount))
                {
                    MessageBox.Show("请输入有效的取款金额。", "金额错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

    }

    public class BigMoneyArgs : EventArgs
    {
        public string AccountNumber { get; }
        public decimal Amount { get; }

        public BigMoneyArgs(string accountNumber, decimal amount)
        {
            AccountNumber = accountNumber;
            Amount = amount;
        }
    }

    // 自定义异常类
    public class BadCashException : Exception
    {
        public BadCashException(string message) : base(message)
        {
        }
    }

    // 账号类
    public class Account
    {
        private string accountNumber;
        private decimal balance;

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public decimal Balance
        {
            get { return balance; }
            protected set { balance = value; }
        }

        public Account(string accountNumber, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            balance = initialBalance;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("取款金额必须大于0");
            }
            if (amount > Balance)
            {
                throw new InvalidOperationException("余额不足");
            }
            Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("存款金额必须大于0");
            }
            Balance += amount;
        }
    }

    // 信用账号类
    public class CreditAccount : Account
    {
        public decimal CreditLimit { get; set; }

        public CreditAccount(string accountNumber, decimal initialBalance, decimal creditLimit)
            : base(accountNumber, initialBalance)
        {
            CreditLimit = creditLimit;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > Balance + CreditLimit)
            {
                throw new InvalidOperationException("超出信用额度");
            }
            Balance -= amount;
        }
    }

    // 银行类
    public class Bank
    {
        private List<Account> accounts = new List<Account>();

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public Account this[string accountNumber]
        {
            get
            {
                foreach (var account in accounts)
                {
                    if (account.AccountNumber == accountNumber)
                    {
                        return account;
                    }
                }
                throw new KeyNotFoundException("未找到该账号");
            }
        }
    }

    // ATM 
    public class ATM
    {
        public event EventHandler<BigMoneyArgs> BigMoneyFetched;

        private Bank bank;
        private Random random = new Random();

        public ATM(Bank bank)
        {
            this.bank = bank;
        }

        public void Deposit(string accountNumber, decimal amount)
        {
            Account account = bank[accountNumber];
            if (account == null)
            {
                MessageBox.Show($"账号 {accountNumber} 不存在，请检查输入的账号。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            account.Deposit(amount);
            MessageBox.Show($"存款成功，账号 {accountNumber} 现在的余额为: {account.Balance}");
        }

        public void Withdraw(string accountNumber, decimal amount)
        {
            // 30%坏钞率
            if (random.Next(0, 10) < 3)
            {
                throw new BadCashException("检测到坏钞");
            }

            Account account = bank[accountNumber];
            if (account == null)
            {
                MessageBox.Show($"账号 {accountNumber} 不存在，请检查输入的账号。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            account.Withdraw(amount);
            if (amount > 10000)
            {
                OnBigMoneyFetched(new BigMoneyArgs(accountNumber, amount));
            }

            MessageBox.Show($"取款成功，账号 {accountNumber} 现在的余额为: {account.Balance}");
        }

        protected virtual void OnBigMoneyFetched(BigMoneyArgs e)
        {
            BigMoneyFetched?.Invoke(this, e);
        }
    }


    
}
