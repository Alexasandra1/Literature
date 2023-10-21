import React, { useState } from "react"

import './Input.scss'

export function Input(props) {
    const {onChange, ...registerProps} = props.register?.(props.name, props.rules) || {};


    function handleChange(event) {
        if (onChange) {
            onChange(event);
        }

        props.onChange(event);
    }

    return (
        <div className="input">
            <div className="input__label">
                {props.label}
            </div>

            <input
                className={`input__input ${props.car} ${props.margin}`}
                onChange={handleChange}
                autoComplete={props.autoComplete}
                {...registerProps}/>
            
            <span className="input__erroe">
                {props.error?.message}
            </span>
        </div>
    )
}