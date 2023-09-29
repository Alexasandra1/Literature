import React, { useState } from "react"
import './Button.scss'

export function Button(props) {
    return (
        <div className="button">
            {/* <div className="hover"> */}
                <button className={`button__button ${props.size} ${props.colorWord} ${props.back} `}>{props.word}</button>
                {/* <input className={`input__input ${props.size}`}></input> */}
            {/* </div> */}
        </div>
    )
}