namespace oop
{
    public class BankAccount
    {
        private decimal Balance { get; set; }

        public void IncreaseBalance(decimal amount)
        {
            if (amount <= 1000)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Hesap bakiyesini en fazla 1000 arttırabilirsiniz.");
            }
        }
    }
}
