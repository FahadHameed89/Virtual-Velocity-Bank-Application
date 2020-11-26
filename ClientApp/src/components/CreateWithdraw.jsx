﻿import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Layout } from '../components/Layout';

function CreateWithdraw(props) {
    const [accountID, setAccountID] = useState("");
    const [transactionSource, setTransactionSource] = useState("");
    const [transactionValue, setTransactionValue] = useState("");
    const [response, setResponse] = useState([]);
    const [waiting, setWaiting] = useState(false);
    const [accountInfo, setAccountInfo] = useState([]);
    const [loading, setLoading] = useState(true);

    // Get Today's Date
    const today = new Date().toLocaleDateString().substr(0, 10);


    async function populateClientData() {
        const response = await axios.get('BankAPI/LandingPage');
        setAccountInfo(response.data);
        setLoading(false);
    }

    useEffect(() => {
        populateClientData();
    }, [loading]);

    function handleFieldChange(event) {
        switch (event.target.id) {
            case "accountID":
                setAccountID(event.target.value);
                break;
            case "transactionSource":
                setTransactionSource(event.target.value);
                break;
            case "transactionValue":
                setTransactionValue(event.target.value);
                break;
            default:
                break;
        }
    }

    function handleSubmit(event) {
        event.preventDefault();
        setWaiting(true);

        // Post Request
        axios(
            {
                method: 'post',
                url: 'BankAPI/CreateWithdraw',
                params: {
                    accountID: accountID,
                    transactionSource: transactionSource,
                    transactionValue: transactionValue,
                    transactionDate: today
                }
            }
        ).then((res) => {
            setWaiting(false);
            setResponse("Transaction Completed successfully");
        }
        ).catch((err) => {
            setWaiting(false);
            setResponse(err.response.data);
        });
    }

    return (
        <div>
            <Layout />
            <h1> Make a Withdraw </h1>

            <p>{waiting ? "Waiting..." : `${response}`}</p>

            <br />
            <form onSubmit={handleSubmit}>

                <label htmlFor="accountID">Account Type</label>
                <select id="accountID" onChange={handleFieldChange}>

                    <option value="" >Choose here</option>

                    {accountInfo.map(client => (
                        <option key={client.accountID} value={`${client.accountID}`}>
                            {`${client.accountType} Balance: $${client.accountBalance + client.cashback}`}
                        </option>
                    ))}
                </select>
                <br />
                <label htmlFor="transactionSource">Source of Deposit</label>
                <select id="transactionSource" onChange={handleFieldChange}>
                    <option value="" >Choose here</option>
                    <option value="Bank">Bank</option>
                    <option value="ATM">ATM</option>
                </select>
                <br />
                <label htmlFor="transactionValue">Value</label>
                <br />
                <input id="transactionValue" type="text" onChange={handleFieldChange} />
                <br />
                <input type="submit" className="btn btn-primary" value="Submit" />
            </form>
        </div>
    );
}
export { CreateWithdraw };