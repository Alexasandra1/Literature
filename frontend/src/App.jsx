import React from 'react';
import { MainPage } from "./pages/MainPage/MainPage";
import { BrowserRouter, Routes, Route, Navigate} from "react-router-dom";
import './../src/App.scss';
import { RegistrationPage } from './pages/RegistrationPage/RegistrationPage';
import { SingPage } from './pages/SingPage/SingPage';
import { BookPage } from './pages/BookPage/BookPage';
import{Toaster} from "react-hot-toast";

export class App extends React.Component{
  render() {
    return(
      <>
      <Toaster/>
        <div className="app__pages">
          <BrowserRouter>
            <Routes>
              <Route path="/main" element={<MainPage/>}/>
              <Route path="/registration" element={<RegistrationPage/>}/>
              <Route path="/sing" element={<SingPage/>}/>
              <Route path="/book" element={<BookPage/>}/>
              <Route path="*" element={<Navigate to="/main"/>}/>
            </Routes>
          </BrowserRouter>
        </div>
      </>
    )
  }
}