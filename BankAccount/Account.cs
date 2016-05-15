using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        private string _accountNum;
        private double _balance;
        private double _interestRate;
        private double _interestEarned;
        private double _numOfTransactions;
        
        public Account()
        {
            _accountNum = "";
            _balance = 0;
            _interestRate = 0.05;
            _interestEarned = 0;
            _numOfTransactions = 0;
        }

        public string AccountNum
        {
            get { return _accountNum; }
            set { _accountNum = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public double InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }

        public double InterestEarned
        {
            get { return _interestEarned; }
            set { _interestEarned = value; }
        }

        public double NumOfTransactions
        {
            get { return _numOfTransactions; }
            set { _numOfTransactions = value; }
        }
    }
}
