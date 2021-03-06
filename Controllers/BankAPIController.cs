﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone_VV.Models;
using Capstone_VV.Models.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Capstone_VV.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BankAPIController : ControllerBase
    {
        [HttpGet("LandingPage")]   
        public ActionResult<IEnumerable<Account>> Client_GET()
        {
            return new AccountController().GetAccount();
        }
        [HttpPost("Login")]
        public ActionResult<Client> Login_POST(string email, string password)
        {
            ActionResult<Client> result;
            try
            {
                result = new ClientController().ClientAuthorization(email, password);                    
            }
            catch (ValidationException e)
            {
                string error = "Error: " +
                    e.ValidationExceptions.Select(x => x.Message)
                    .Aggregate((x, y) => x + ", " + y);

                result = BadRequest(error);
            }
            catch (Exception)
            {
                result = StatusCode(500, "Unknown error occurred, please try again later.");
            }
            return result;

        }
        [HttpPost("CreateClient")]
        public ActionResult<Client> CreateClient_POST(string email, string password, string phone, string fname, string lname, string dateOfBirth, string address, string city, string province, string postalCode)
        {
            ActionResult<Client> result;
            try
            {
                result = new ClientController().CreateClient(email, password, phone, fname, lname, dateOfBirth, address, city, province, postalCode);
            }
            catch (ValidationException e)
            {
                string error = "Error: " +
                    e.ValidationExceptions.Select(x => x.Message)
                    .Aggregate((x, y) => x + ", " + y);

                result = BadRequest(error);
            }
            catch (Exception)
            {
                result = StatusCode(500, "Unknown error occurred, please try again later.");
            }
            return result;

        }

        [HttpPost("CreateAccount")]
        public ActionResult<Account> CreateAccount_POST(string accountType)
        {
            ActionResult<Account> result;
            try
            {
                result = new AccountController().CreateAccount(accountType);
            }
            catch (ValidationException e)
            {
                string error = "Error: " +
                    e.ValidationExceptions.Select(x => x.Message)
                    .Aggregate((x, y) => x + ", " + y);

                result = BadRequest(error);
            }
            catch (Exception)
            {
                result = StatusCode(500, "Unknown error occurred, please try again later.");
            }
            return result;

        }
        // Add Account
        [HttpPost("AddAccount")]
        public ActionResult<Account> AddAccount_POST(string accountType)
        {
            ActionResult<Account> result;
            try
            {
                result = new AccountController().AddAccount(accountType);
            }
            catch (ValidationException e)
            {
                string error = "Error: " +
                    e.ValidationExceptions.Select(x => x.Message)
                    .Aggregate((x, y) => x + ", " + y);

                result = BadRequest(error);
            }
            catch (Exception)
            {
                result = StatusCode(500, "Unknown error occurred, please try again later.");
            }
            return result;

        }
        [HttpGet("ViewTransactions")]
        public ActionResult<IEnumerable<Transaction>> ViewTransaction_GET(string id)
        {
            return new TransactionController().GetTransactions(id);
        }

        // Create Deposit
        [HttpPost("CreateDeposit")]
        public ActionResult<Transaction> CreateDeposit_POST(string accountID, string transactionSource, string transactionValue)
        {
            ActionResult<Transaction> result;
            try
            {
                result = new TransactionController().CreateDeposit(accountID, transactionSource, transactionValue);
            }
            catch (ValidationException e)
            {
                string error = "Error(s): " +
                    e.ValidationExceptions.Select(x => x.Message)
                    .Aggregate((x, y) => x + ", " + y);

                result = BadRequest(error);
            }
            catch (Exception)
            {
                result = StatusCode(500, "Unknown error occurred, please try again later.");
            }
            return result;

        }

        // Create Withdraw
        [HttpPost("CreateWithdraw")]
        public ActionResult<Transaction> CreateWithdraw_POST(string accountID, string transactionValue, string transactionDate, string transactionSource = "Bill Payment", string transactionCategory = "Withdraw")
        {
            ActionResult<Transaction> result;
            try
            {
                result = new TransactionController().CreateWithdraw(accountID, transactionValue, transactionDate, transactionSource, transactionCategory);
            }
            catch (ValidationException e)
            {
                string error = "Error: " +
                    e.ValidationExceptions.Select(x => x.Message)
                    .Aggregate((x, y) => x + ", " + y);

                result = BadRequest(error);
            }
            catch (Exception)
            {
                result = StatusCode(500, "Unknown error occurred, please try again later.");
            }
            return result;

        }

       
        [HttpPatch("CloseAccount")]
        public ActionResult<Account> CloseAccount_PATCH(string accountID)
        {
            ActionResult<Account> result;
            try
            {
                result = new AccountController().CloseAccount(accountID);
            }
            catch (ValidationException e)
            {
                string error = "Error: " +
                    e.ValidationExceptions.Select(x => x.Message)
                    .Aggregate((x, y) => x + ", " + y);

                result = BadRequest(error);
            }
            catch (Exception)
            {
                result = StatusCode(500, "Unknown error occurred, please try again later.");
            }
            return result;

        }


    }
}
