﻿import React, { useState } from 'react';
import axios from 'axios';
import { useHistory } from "react-router-dom";
import { Link } from "react-router-dom";
import { FaEye } from "react-icons/fa"
import "./css/Login.css"


function Login(props) {
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [response, setResponse] = useState([]);
    const [waiting, setWaiting] = useState(false);
    const[passwordShow, setPasswordShow] = useState(false);
    const history = useHistory();

    function handleFieldChange(event) {
        switch (event.target.id) {
            case "email":
                setEmail(event.target.value);
                break;
            case "password":
                setPassword(event.target.value);
                break;
            default:
                break;
        }
    }

    function handleSubmit(event) {
        event.preventDefault();
        setWaiting(true);

        axios(
            {
                method: 'post',
                url: 'BankAPI/Login',
                params: {
                    email: email,
                    password: password,
                }
            }
        ).then((res) => {
            setWaiting(false);
            setResponse("Login Successfully");
            history.push("/landing-page");
        }
        ).catch((err) => {
            setWaiting(false);
            setResponse(err.response.data);
        });


    }

    function togglePassword(event) {
        event.preventDefault();
        setPasswordShow(passwordShow ? false : true);
    };


    return (

        <section className="login-page">
            <h1 className="login-header">Log In</h1>

            <p className="login-error alert alert-light">{waiting ? "Logging In..." : `${response}`}</p>

            <form className="login-form" onSubmit={handleSubmit}>
                <section className="input-group-prepend login-prepend">
                    <label className="input-group-text login-placeholder" htmlFor="email" >Email: </label>
                    <input className="form-control" id="email" type="text" onChange={handleFieldChange} placeholder="Email Address"/>
                </section>

                <section className="input-group-prepend login-prepend">
                    <label className="input-group-text login-placeholder" htmlFor="password">Password: </label>
                    <input className="form-control" id="password" type={passwordShow ? "text" : "password"} onChange={handleFieldChange} placeholder="Password" />
                    <span onClick={togglePassword}><FaEye /></span>
                </section>

                <section className="login-submit">
                    <input type="submit" className="btn btn-primary" value="Login" />
                </section>


            </form>
            <section className="login-submit">
                <button className="btn btn-info">
                    <Link to="/create-client" className="white-text">Become A Client!</Link>
                </button>
            </section>
        </section>


    );
}
export { Login };
