﻿using System;
using System.Collections.Generic;
using System.Text;
using static Technovert.Banking.Enums.CustomerEnum;

namespace Technovert.Banking.Model
{
    public class Customer : User
    {
        public CustomerGender Gender { get; set; }
        public string AccountNumber { get; set; }
        public int Pin { get; set; }
        public float Balance { get; set; }
        public List<Transaction> Passbook { get; set; }
        public AccountStatus Status { get; set; }


        public Customer(string accID, string name, CustomerGender gender, string accNumber, int accPin, float balance, AccountStatus status = AccountStatus.Active)
        {
            this.ID = accID;
            this.Name = name;
            this.Gender = gender;
            this.AccountNumber = accNumber;
            this.Pin = accPin;
            this.Balance = balance;
            this.Passbook = new List<Transaction>();
            this.Status = status;
        }
    }
}
