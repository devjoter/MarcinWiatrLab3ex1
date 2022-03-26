using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinWiatrLab3ex1
{
    public class Transactions : ITransaction, ITransactionDetails
    {
        private string value;
        private string transactionname;
        private int transactionqty;

        
        
        public string TransactionName
        {
            get { return transactionname; }
            set 
            {
                if (value == null)
                    transactionname = "tranakcja bez nazwy";
                transactionname = value;
            }
        }
        public int TransactionQty
        {
            get { return transactionqty; }
            set
            {
                if (value == null)
                    transactionqty = 0;
                else if (value < 0)
                {
                    transactionqty = 0;
                    Console.WriteLine("Nie mozna wpisac ujemnej wartosci");
                }
                else
                    transactionqty = value;
            }
        }

        public string Value { get => value; set => this.value = value; }

        public Transactions(string transactionname, int tranactionqty)
        {
            this.transactionname = transactionname;
            this.transactionqty = tranactionqty; 
        }
        public int CalcTransactions()
        {
            throw new NotImplementedException();
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Transakcje: {TransactionName}, ilosc: {TransactionQty}");
        }

        public int ShowQty()
        {
            Console.WriteLine("Ilosc transakcji:" + TransactionQty);    
            return TransactionQty;
        }
    }
}
