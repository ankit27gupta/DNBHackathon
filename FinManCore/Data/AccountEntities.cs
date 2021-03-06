﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FinMan.Data
{
    public class AccountCustomer
    {
        public string customerID { get; set; }
        public Account[] accounts { get; set; }
    }

    public class Account
    {
        public long accountNumber { get; set; }
        public string accountType { get; set; }
        public double availableBalance { get; set; }
    }

    public class AccountResponse
    {
        public long accountNumber { get; set; }
        public string customerID { get; set; }
        public string accountStatus { get; set; }
    }

    public class CreateAccountRequest
    {
        public string customerID { get; set; }
        public string accountName { get; set; }
        public string accountType { get; set; }
        public string accountCurrency { get; set; }
    }


    public class CloseAccountRequest
    {
        public string customerID { get; set; }
        public string accountNumber { get; set; }
    }


    public class CustomerAccount
    {
        public long accountNumber { get; set; }
        public string iban { get; set; }
        public string customerID { get; set; }
        public string accountName { get; set; }
        public string accountType { get; set; }
        public double availableBalance { get; set; }
        public double bookBalance { get; set; }
        public string accountStatus { get; set; }
        public string created { get; set; }
        public string currency { get; set; }
    }


    public class AccountTransaction
    {
        public long accountNumber { get; set; }
        public Transaction[] transactions { get; set; }
    }

    public class Transaction
    {
        public string transactionID { get; set; }
        public string date { get; set; }
        public double amount { get; set; }
        [JsonProperty(PropertyName = "message/KID")]
        public string messageKID { get; set; }
        public string transactionAccountNumber { get; set; }
        public string transactionAccountName { get; set; }
    }

    public class UpdateAccountNameRequest
    {
        public string customerID { get; set; }
        public string accountNumber { get; set; }
        public string accountName { get; set; }
    }


    public class UpdateAccountNameResponse
    {
        public long accountNumber { get; set; }
        public string accountName { get; set; }
    }


    public class AddDisponentRequestResponse
    {
        public string accountNumber { get; set; }
        public string disponentCustomerID { get; set; }
    }

    public class GetBalanceResponse
    {
        public long accountNumber { get; set; }
        public int availableBalance { get; set; }
        public int bookBalance { get; set; }
        public string currency { get; set; }
    }



}


