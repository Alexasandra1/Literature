import React, {useState} from "react"
import './Input.scss'

export function Input(props) {
    function handleChange(event) {
        if (props.onChange) {
            props.onChange(event);
        }
    }

    return (
        <div className="input">

        <div className="input__label">
            {props.label}
        </div>
        
            <input className={`input__input ${props.car} ${props.margin}`} onChange={handleChange}/>
        </div>
    )
}