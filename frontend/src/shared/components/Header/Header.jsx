import React, { useState } from "react"
import logotip from "../../../image/logoLitlib.png"

import './Header.scss'

export function Header() {
    // const {onChange, ...registerProps} = props.register?.(props.name, props.rules) || {};


    // function handleChange(event) {
    //     if (onChange) {
    //         onChange(event);
    //     }

    //     props.onChange(event);
    // }

    return (
        <header className="header">
            <div className="header__logo"><img src={logotip} className="header__logo__logotip" alt="logoImg" />
            </div>
            <div className="header__catalog">Каталог</div>
            <div className="header__search">Поиск</div>
            <div className="header__news">Новости</div>
            <div className="heafer__contsct">Контакты</div>
            <div className="header__profile">prifileButton</div>
        </header>
    )
}