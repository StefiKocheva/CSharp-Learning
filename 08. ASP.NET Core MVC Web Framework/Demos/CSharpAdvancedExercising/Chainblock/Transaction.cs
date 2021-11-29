namespace Chainblock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Transaction
    {
        private List<Transaction> transactions = new List<Transaction>();

        public int Id { get; set; }

        public Enum TransactionStatus { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public double Amount { get; set; }

        public int Count { get; set; }

        public void Add(Transaction transaction)
        {
            if (!transactions.Contains(transaction))
            {
                transactions.Add(transaction);
            }
        }

        public void ChangeTransactionStatus(int id, Enum status)
        {

        }
    }
}
