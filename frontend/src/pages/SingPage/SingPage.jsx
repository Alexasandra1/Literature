import React, { useState } from "react"
import './SingPage.scss'
import { useNavigate } from "react-router-dom";
import { Button } from "../../shared/components/Button/Button";
import { Input } from "../../shared/components/Input/Input";
import { login } from "../../shared/api/authApi";
import { Form } from "../../shared/components/Form/Form";
import toast from "react-hot-toast";

export function SingPage() {
    const [userLogin, setUserLogin] = useState("");
    const [password, setPassword] = useState("");
    const navigate = useNavigate();

    async function handleSingClick(event) {
        event.preventDefault();
        // navigate("/sing");
        if (userLogin === "" || password === "") {
            toast.error("Поля не должны быть пустымии", {
                duration: 1000,
            });
        } else {
            const user = {
                login: userLogin,
                password: password
            }
    
            console.log(user);
            await login(user);
        }
    }

    async function handleRegistrationClick() {
        navigate("/registration");
    }

    return (
        <>
            <div className="SingPage__section">
                <div className="SingPage__section__header">
                    <div className="SingPage__section__header__container">
                        <div className="SingPage__section__header__container__logo">какой-то логотип</div>
                        <div className="SingPage__section__header__container__aboutUs">о нас</div>
                    </div>

                    <div className="SingPage__section__header__button">
                        <Button size="redButNormal" back="hover" word="Регистрация" onClick={handleRegistrationClick} />
                    </div>
                </div>

                {/* <Form className="SingPage__section__form" onSubmit={handleSingClick}>
                    <div className="SingPage__section__form__div">
                        <Input
                            label="Логин"
                            margin="bottom"
                            onChange={(event) => setUserLogin(event.target.value)}
                            rules = {{required: "Обязательное поле"}}/>

                        <Input
                            label="Пароль"
                            margin="bottom"
                            onChange={(event) => setPassword(event.target.value)}
                            rules = {{required: "Обязательное поле"}}/>
                    </div>
                    <div className="SingPage__section__form__button" >
                        <Button size="normal" back="hover" word="Войти" type="onSubmit" />
                    </div>
                </Form> */}

                <form className="SingPage__section__form" onSubmit={handleSingClick}>
                    <div className="SingPage__section__form__div">
                        <Input label="Логин" margin="bottom" onChange={(event) => setUserLogin(event.target.value)}/>
                        <Input label="Пароль" margin="bottom" onChange={(event) => setPassword(event.target.value)}/>
                    </div>
                    <div  className="SingPage__section__form__button" >
                        <Button size="normal" back="hover" word="Войти" type="onSubmit" />
                    </div>
                </form>
            </div>
        </>
    )
}