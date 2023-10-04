import React from 'react';
import { MainPage } from "./pages/MainPage/MainPage";
import { BrowserRouter, Routes, Route, Navigate} from "react-router-dom";
import './../src/App.scss';
import { RegistrationPage } from './pages/RegistrationPage/RegistrationPage';

export class App extends React.Component{
  render() {
    return(
      <>
        <div className="app__pages">
          <BrowserRouter>
            <Routes>
              <Route path="/main" element={<MainPage/>}/>
              <Route path="/registration" element={<RegistrationPage/>}/>
              <Route path="*" element={<Navigate to="/main"/>}/>
            </Routes>
          </BrowserRouter>
        </div>
      </>
    )
  }
}