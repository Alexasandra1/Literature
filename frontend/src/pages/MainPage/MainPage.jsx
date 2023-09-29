import React, { useState } from "react"
import './MainPage.scss'
import { getsmth } from "../../shared/api/apiMain"
import { Input } from "../../shared/components/Input/Input";
import sun from "../../image/sun.png"
import { Button } from "../../shared/components/Button/Button";

export function MainPage() {
    const [unicorn, setUnicorn] = useState(null);

    async function handleClick() {
        const data = await getsmth();

        function name() {
            setUnicorn(data.data.unicorn);
        }
        name();
    }

    return (
        <>
            <div className="mainPage__firstSection">
                <div className="mainPage__firstSection__leftArea">
                    <div className="mainPage__firstSection__leftArea__litlib">литлиб</div>
                    <div className="mainPage__firstSection__leftArea__regis">Регистрация</div>
                    <Button size="normal" colorWord="redColor" back="hover" word="Войти"/>
                </div>
                <div className="mainPage__firstSection__rightArea">
                    <img src={sun} className="mainPage__rightArea__sun"/>
                </div>
            </div>
            
        </>
    )
}