import React, { useState } from "react"
import { useNavigate } from "react-router-dom";
import './RegistrationPage.scss';
// import {UserApi.js} from './src/shared/api/userApi.js';
import { Button } from "../../shared/components/Button/Button";
import { Input } from "../../shared/components/Input/Input";
import { registration } from "../../shared/api/userApi";


export function RegistrationPage() {
    const [name, setName] = useState("");
    const [login, setLogin] = useState("");
    const [password, setPassword] = useState("");

    const navigate = useNavigate();

    async function handleSingClick() {
        navigate("/sing");
    }

    async function handleRegistration(event) {
        event.preventDefault();
        const user = {
            name: name,
            login: login,
            password: password
        }

        console.log(user);
        await registration(user);
    }

    return (
        <div className="RegistrationPage__section">
            <div className="RegistrationPage__section__header">
                <div className="RegistrationPage__section__header__container">
                    <div className="RegistrationPage__section__header__container__logo">какой-то логотип</div>
                    <div className="RegistrationPage__section__header__container__aboutUs">о нас</div>
                </div>

                <div className="RegistrationPage__section__header__button">
                    <Button size="normal" back="hover" word="Войти" onClick={handleSingClick} />
                </div>
            </div>

            <form className="RegistrationPage__section__form" onSubmit={handleRegistration}>
                <div className="RegistrationPage__section__form__div">
                    {/* <label className="RegistrationPage__section__form__divLogin__text" for="name">Login </label> */}
                    <Input label="Введите имя" margin="bottom" onChange={(event) => setName(event.target.value)} />
                    <Input label="Логин" margin="bottom" onChange={(event) => setLogin(event.target.value)} />
                    <Input label="Пароль" margin="bottom" onChange={(event) => setPassword(event.target.value)} />
                </div>
                <div>
                    <Button size="redButNormal" back="hover" word="Регистрация" type="submit"/>
                </div>
            </form>
        </div>
    )
}