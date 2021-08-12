class BankAccount
    {
        double bal;

        public BankAccount()
        {
            this.bal = 500.0;
        }

        public BankAccount(double balance)
        {
            this.bal = balance;
        }

        public double getBalance()
        {
            return bal;
        }
    }

    class OutputBankAccount
    {
        public static void Main()
        {

            BankAccount b1 = new BankAccount();
            Console.WriteLine("Account Balance default = " + b1.getBalance());
aBankAccount b2 = new BankAccount(1000);
            Console.WriteLine("Account Balance = " + b2.getBalance());

        }
    }