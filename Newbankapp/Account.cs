using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbankapp
{
    /// <summary>
    /// 
    /// </summary>
    public enum Typeofaccounts
    {
        Checking,
        Saving,
    }
    public class Account
    {
        #region Static
        private static int lastAccountNumber = 0;
        #endregion
        #region properties
        public int AccountNumber { get;
            private set; }
        public string EmailAddress { get; set; }
        public decimal Balance { get;
            private set; }
        public Typeofaccounts AccountType { get; set; }
        #endregion
        #region 
        // consturactor doesnt have any return type & parameter//
        public Account()
        {
            AccountNumber =
                ++lastAccountNumber;
        }

        #endregion
        #region Methods
        ///>
        public void Deposit(Decimal amount)
        {
            // if you write any data type other than void in your mehod it expect return type for example if write decimal return balance 
           // Balance = Balance + amount; it i same with the second line
            Balance += amount;
        }
        public decimal Withdraw (decimal amount)
        {

            if (amount <= Balance)
            {
                Balance -= amount;
            }
            return Balance;

        }
        #endregion
    }

}
