using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readingIO
{
    enum AccountType
    {
        Checking,MasterCard,Saving
    }
    class Customer
    {
        private int accountNumber;
        private string firstName;
        private string lastName;
        private double balance;
        private AccountType acountType;

        public Customer( int _accountNumber,
                         string _firstName,
                         string _lastName,
                         double _balance,
                         AccountType _acountType)
        {
            this.accountNumber = _accountNumber;
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.balance = _balance;
            this.acountType = _acountType;
                
        }

        public override string ToString()
        {
            return string.Format($"# {accountNumber,-10},Name : {firstName,-10} {lastName,-10} ,Balance :{balance.ToString("c"),-10},Account {acountType,-15}");

        }
    }
}
