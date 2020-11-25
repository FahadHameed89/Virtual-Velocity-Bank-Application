﻿import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Layout } from '../components/Layout';
import { Link } from "react-router-dom";
import "./css/root.css"
import "./css/LandingPage.css"


function LandingPage(props) {

    const [accountInfo, setAccountInfo] = useState([]);
    const [loading, setLoading] = useState(true);
    const [fullName, setFullName] = useState();

    function renderClientInfoTable(accountInfo) {

        const totalHolding = accountInfo.reduce((total, client) => total = total + client.accountBalance, 0) + 
                           accountInfo.reduce((total, client) => total = total + client.accountInterest, 0);

                           
        const name = accountInfo.map(x => x.client.firstName + " " + x.client.lastName)[0];
       

        return (
            <section id="landing-page-summary">
                <h1>Account Summary</h1>  
                <h2>Total Holdings : $ {totalHolding.toFixed(2)}</h2>
                <h3>Full Name: { name }</h3>
                <table className='table table-borderless' aria-labelledby="tabelLabel">
                    <tbody>
                        {accountInfo.map(client =>
                            <tr key={client.accountID}>                                
                                <div className="flex-container account-type">
                                    <th>Account Type: </th>
                                    <td>{client.accountType}</td>
                                </div>
                                <div className="flex-container">
                                    <th>Account Balance: </th>
                                    <td>$ {client.accountBalance}</td>
                                </div>
                                <div className="flex-container">
                                    <th>Interest Earned: </th>
                                    <td>$ {client.accountInterest}</td>
                                </div>
                                <div className="flex-container total-balance">
                                    <th>Total Balance: </th>
                                    <td>$ {client.accountBalance + client.accountInterest}</td>
                                </div>
                                <div className="flex-container view-transactions">
                                    <th>View Transactions: </th>
                                    <td>
                                        <button className="btn btn-info">
                                            <Link to={`/view-transactions?id=${client.accountID}`}>
                                                {`${ client.accountType } Account`}
                                            </Link>
                                        </button>
                                    </td>
                                </div>
                            </tr>
                        )}
                    </tbody>
                </table>
            </section>
            

        );
    }
    
    async function populateClientData() {
        const response = await axios.get('BankAPI/LandingPage');
        setAccountInfo(response.data);
        setLoading(false);
    }

    useEffect(() => {
        populateClientData();
    }, [loading]);

    let contents = loading
        ? <p><em>Loading...</em></p>
        : renderClientInfoTable(accountInfo);

    return (
        <section id="landing-page">
            <Layout />                     
            {contents}
        </section>
    );
}

export { LandingPage };
