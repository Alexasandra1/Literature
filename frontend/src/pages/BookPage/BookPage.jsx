import React, { useState } from "react"
import { useNavigate } from "react-router-dom";
import './BookPage.scss';
// import {UsePApi.js} from './src/shared/api/userApi.js';
import picture from "../../image/basicBook.png";
import { Header } from "../../shared/components/Header/Header";
import { Text } from "../../shared/components/Text/Text";
import { Footer } from "../../shared/components/Footer/Footer";

export function BookPage() {
    // const [unicorn, setUnicorn] = useState(null);
    // const navigate = useNavigate();

    // async function handleRegistrationClick(){
    //     navigate("/registration");
    // }

    // async function handleSingClick(){
    //     navigate("/sing");
    // }

    return (
        <>
            <div className="bookPage">
                <Header></Header>
                <div className="bookPage__firstSection">
                    {/* <div className="bookPage__firstSection__behindPic"><svg className="bookPage__firstSection__behindPic__svg"
                        xmlns="http://www.w3.org/2000/svg" width="462" height="323" viewBox="0 0 462 323" fill="none">
                        <path d="M386.282 3.16648L386.524 3.22806C409.191 9.01705 428.905 22.5787 442.413 39.7957L442.418 39.802C455.96 56.9959 463.358 77.8306 461.407 98.2546C459.447 118.767 448.428 134.973 432.205 144.581L432.203 144.582L135.599 321.248L0.00180977 302.822L29.1003 186.494L326.089 10.2946C342.201 0.574847 363.544 -2.56483 386.267 3.16212L386.282 3.16648ZM124.077 292.121L412.922 120.085C423.221 114.02 430.222 103.767 431.479 90.7792L431.479 90.7766L431.483 90.731C432.728 77.7011 428.027 64.4083 419.409 53.4224L419.413 53.4265C410.826 42.4694 398.291 33.8416 383.877 30.1604C369.414 26.4667 355.824 28.4596 345.594 34.66L345.479 34.7286L56.2675 206.322L37.7262 280.398L124.077 292.121ZM370.603 163.229L283.812 53.4138L306.781 39.7608L393.57 149.576L370.603 163.229ZM7.10053e-05 302.84L31.6767 176.214L47.7584 184.354C73.3617 197.447 94.6935 215.274 110.985 236.066L110.996 236.08C127.916 256.968 139.69 280.951 144.5 305.724L144.651 306.712L147.644 322.667L7.10053e-05 302.84ZM53.402 217.707L37.7288 280.362L110.775 290.161C105.643 275.451 98.0312 262.089 88.2722 250.041L88.2475 250.01L88.0287 249.733C78.6443 237.741 67.1677 226.996 54.1248 218.162L53.402 217.707ZM110.009 255.402L90.6818 230.947L329.028 89.2667L348.355 113.722L110.009 255.402Z" fill="#232020" fill-opacity="0.31" />
                    </svg></div> */}
                    <div className="bookPage__firstSection__textManhva">Manhva</div>
                </div>
                <div className="bookPage__secondSection">
                    <div className="bookPage__secondSection__leftArea">
                        <img src={picture} className="bookPage_secondSection__leftArea__pictuture" alt="pictureImg" />
                    </div>
                    <div className="bookPage__secondSection__rightarea">
                        {/* <Text color="red" word="Завораживающая красота"></Text> */}
                        <div className="bookPage__secondSection__rightarea__textFirst">
                            <div className="bookPage__secondSection__rightarea__textFirst__beauty">Завораживающая красота</div>
                            <div className="bookPage__secondSection__rightarea__textFirst__text">Окунитесь в удивительный мир манхвы с нашим разнообразием картинок!</div>
                        </div>
                        <div className="bookPage__secondSection__rightarea__textSecond">
                            <div className="bookPage__secondSection__rightarea__textSecond__choise">Широкий выбор</div>
                            <div className="bookPage__secondSection__rightarea__textSecond__text">Эксклюзивная подборка манхва-картинок для ваших друзей и знакомых.</div>
                        </div>
                        <div className="bookPage__secondSection__rightarea__textThird">
                            <div className="bookPage__secondSection__rightarea__textThird__character">Любимые герои</div>
                            <div className="bookPage__secondSection__rightarea__textThird__text">Найдите своих любимых персонажей среди впечатляющего множества манхв!</div>

                        </div>
                        <div></div>
                    </div>
                </div>
            </div >
            <Footer></Footer>
            {/* <div className="mainPage__footer">
                <div className="mainPage__footer__container">
                    <div className="mainPage__footer__container__text">
                        <div className="mainPage__footer__container__text__aboutUs">о нас</div>
                        <div className="mainPage__footer__container__text__contact"> контакты</div>
                        <div className="mainPage__footer__container__text__support">поддержка</div>
                    </div>
                    <div className="mainPage__footer__container__social">
                        <svg xmlns="http://www.w3.org/2000/svg" width="20" height="20" viewBox="0 0 20 20" fill="none">
                            <path d="M13.745 19.9959C10.9578 19.9959 7.47156 18.224 4.64819 15.3726C2.76515 13.5421 1.3077 11.2844 0.431808 8.75539L0.395853 8.63618C-0.337544 6.21167 -0.0454045 4.184 1.21847 2.92543L4.13895 0L9.81577 5.67276L7.58369 7.90238C7.36237 8.13015 7.22589 8.44133 7.22589 8.78435C7.22589 9.12737 7.36237 9.43855 7.584 9.66663L7.58371 9.66632L10.3198 12.4004C10.5477 12.6259 10.8614 12.7653 11.2076 12.7653C11.5539 12.7653 11.8676 12.6259 12.0956 12.4003L14.3267 10.1708L20 15.8436L17.0574 18.7629C16.2451 19.5291 15.1467 20 13.9382 20C13.8703 20 13.8027 19.9985 13.7355 19.9956L13.7451 19.9959L13.745 19.9959ZM4.14069 1.87325L2.15486 3.86386C1.25199 4.76254 1.07811 6.32185 1.66327 8.25602C2.50907 10.6882 3.85422 12.7609 5.58581 14.4373L5.58991 14.4412C8.17324 17.051 11.2985 18.6747 13.745 18.6747C13.8046 18.6786 13.8741 18.6808 13.9442 18.6808C14.7878 18.6808 15.5557 18.3569 16.1302 17.8269L16.128 17.8288L18.1306 15.8418L14.3249 12.0414L13.0275 13.337C12.5602 13.8005 11.9165 14.087 11.2058 14.087C10.4952 14.087 9.85145 13.8005 9.38403 13.3369L6.64285 10.5994C6.18539 10.132 5.9031 9.49176 5.9031 8.78562C5.9031 8.07948 6.18537 7.43925 6.64331 6.9714L7.94026 5.67538L4.14069 1.87325Z" fill="#FFFBFB" />
                        </svg>
                        <svg xmlns="http://www.w3.org/2000/svg" width="20" height="20" viewBox="0 0 20 20" fill="none">
                            <path d="M13.3336 20L8.48916 11.5108L0 6.66633L20 0L13.3336 20ZM4.43305 7.10321L9.82152 10.1785L12.8968 15.567L17.1291 2.8709L4.43305 7.10321ZM10.124 11.1602L8.83973 9.87601L13.3809 5.33489L14.6651 6.61913L10.124 11.1602Z" fill="#FFFBFB" />
                        </svg>
                        <svg xmlns="http://www.w3.org/2000/svg" width="20" height="20" viewBox="0 0 20 20" fill="none">
                            <path d="M10.0818 0C15.5597 0.000683594 20 4.44395 20 9.92487C20 15.4062 15.559 19.8497 10.0806 19.8497C8.43161 19.8497 6.87655 19.4471 5.50836 18.7348L5.56333 18.7608L0 20L1.2385 14.4326C0.556392 13.1218 0.156339 11.5701 0.156339 9.92489C0.156339 4.44571 4.59387 0.00353514 10.0692 3.90411e-05H10.0696L10.0818 0ZM10.0818 18.9045C15.0384 18.9045 19.0565 14.8842 19.0565 9.92487C19.0565 4.96555 15.0384 0.945255 10.0818 0.945255H10.0696C5.11557 0.948653 1.10088 4.96766 1.10088 9.92487C1.10088 11.4697 1.49074 12.9233 2.17739 14.1928L2.15391 14.1453L2.23609 14.2994L1.24509 18.7542L5.69748 17.7627L5.85145 17.8449C7.07529 18.5109 8.53122 18.903 10.0786 18.9045H10.079H10.0818ZM11.5811 15.8061C9.5814 15.7006 7.81509 14.7814 6.59282 13.376L6.58548 13.3674C4.1179 10.8701 3.98094 8.62046 4.30686 7.17616C4.53505 6.17274 5.00325 5.30161 5.6485 4.5951L5.64456 4.59946L5.97898 4.26485L9.25522 7.54292L9.05591 7.9418C8.90951 8.22462 8.82366 8.55919 8.82366 8.91388C8.82366 9.51388 9.06936 10.0565 9.46559 10.4464L9.46588 10.4467C9.85449 10.8429 10.3953 11.0885 10.9935 11.0885H11.0004H11.0001C11.3533 11.0879 11.6864 11.0027 11.9806 10.8522L11.9684 10.8578L12.0525 10.8153L12.4946 10.7841L15.683 13.9743L15.3485 14.3089C14.3576 15.2191 13.0358 15.7827 11.5828 15.8004L11.5792 15.8004L11.5811 15.8061ZM6.01396 5.63829C5.64659 6.14493 5.37014 6.74348 5.22287 7.39118L5.21663 7.4238C4.83877 9.17722 5.52841 10.9533 7.25909 12.7029C8.32007 13.9389 9.84628 14.7492 11.5629 14.8599L11.5811 14.8609C12.613 14.8459 13.5623 14.5046 14.3339 13.9357L14.3208 13.9449L12.1848 11.8078C11.8371 11.9542 11.4329 12.0396 11.0089 12.0403H11.0086C9.28456 12.033 7.88972 10.6329 7.88972 8.90688C7.88972 8.48559 7.97282 8.0837 8.12352 7.71675L8.1159 7.7376L6.01396 5.63829Z" fill="#FFFBFB" />
                        </svg>
                        <svg xmlns="http://www.w3.org/2000/svg" width="25" height="20" viewBox="0 0 25 20" fill="none">
                            <path d="M8.20792 15.6804C5.01877 15.1283 2.94444 13.9532 2.04096 12.1887L3.99564 11.3609C4.58861 12.5213 6.14113 13.3226 8.61008 13.7541L8.20792 15.6804ZM9.22029 19.9999C8.89039 19.9999 8.5594 19.9891 8.22735 19.9676C4.91754 19.8498 1.99122 18.4502 0.0143843 16.3026L0 16.2866L1.72504 15.1096C3.34774 16.8318 5.71452 17.9373 8.36672 18.0106L8.3804 18.0108C8.63996 18.0298 8.94238 18.0406 9.24754 18.0406C12.4085 18.0406 15.2717 16.881 17.3513 15.004L17.3505 15.0046L17.3602 14.9959C19.8678 12.7825 21.4241 9.68822 21.4241 6.26327C21.4241 5.82089 21.3981 5.38398 21.3475 4.95383L21.3526 5.00729L21.3289 4.79833L22.0081 2.94757H19.881L19.5823 2.72297C18.9579 2.24993 18.1473 1.96282 17.2631 1.96282C17.2009 1.96282 17.1392 1.96427 17.0778 1.96706L17.0864 1.96675H17.0347C17.0103 1.96606 16.9816 1.96567 16.9528 1.96567C15.6843 1.96567 14.6126 2.73217 14.2668 3.78381L14.2617 3.80186C13.9959 4.419 13.8291 5.13297 13.8006 5.87894L13.8002 5.88999V6.84037L12.7555 6.8708C10.0537 6.9473 7.11037 5.92237 3.79617 3.74299C3.82204 3.97838 3.8641 4.24713 3.92771 4.54923C4.14118 5.60097 4.52169 6.53959 5.04818 7.39368L5.02203 7.34747L3.17193 8.35574C2.49173 7.26855 1.99235 6.00104 1.75497 4.65394L1.74559 4.58942C1.44266 2.90439 1.63024 1.77548 2.30406 1.23211L2.9865 0.682861L3.69593 1.20365C6.76867 3.45956 9.41014 4.66792 11.74 4.87977C11.8472 4.20381 12.0292 3.59536 12.2818 3.01955L12.2607 3.07408C12.9376 1.27508 14.7802 0.00478507 16.949 0.00478507C16.97 0.00478507 16.991 0.00490224 17.012 0.00513662H17.0088C17.085 0.00185541 17.1743 0 17.2641 0C18.5296 0 19.7002 0.369565 20.6526 0.996528L20.6357 0.985943H25L23.5197 5.02393C23.556 5.38685 23.5766 5.80894 23.5766 6.2354C23.5766 10.2173 21.774 13.8162 18.8707 16.3936L18.8675 16.3965C16.4038 18.6235 13.0086 20 9.2599 20C9.24599 20 9.23206 20 9.21817 19.9999H9.22031L9.22029 19.9999ZM4.5358 12.5644C2.59954 11.2506 1.25489 9.29982 0.876605 7.05923L0.870057 7.01205L3.0037 6.72859C3.29712 8.4813 4.32542 9.9764 5.78824 10.9722L5.80686 10.9843L4.5358 12.5644Z" fill="#FFFBFB" />
                        </svg>
                        <svg xmlns="http://www.w3.org/2000/svg" width="20" height="20" viewBox="0 0 20 20" fill="none">
                            <path d="M3.92729 0H16.0727C18.2407 0.00257812 19.9974 1.75934 20 3.92703V16.0727C19.9974 18.2407 18.2407 19.9974 16.073 20H3.92727C1.75934 19.9974 0.00257812 18.2407 0 16.073V3.92729C0.00257812 1.75932 1.75934 0.00257812 3.92703 0H3.92729ZM16.0728 19.0909C17.7388 19.0888 19.0889 17.7388 19.0909 16.0729V3.92729C19.0889 2.26123 17.7388 0.911172 16.0729 0.909121H3.9273C2.26125 0.911172 0.911191 2.26121 0.909141 3.92709V16.0727C0.911191 17.7388 2.26123 19.0888 3.92711 19.0909H3.9273L16.0728 19.0909ZM10 5.20908C12.646 5.20908 14.7909 7.35404 14.7909 10C14.7909 12.646 12.646 14.7909 10 14.7909C7.3541 14.7909 5.2091 12.646 5.2091 10C5.21223 7.35531 7.35531 5.21219 9.99973 5.20908H10ZM10 13.8818C12.1439 13.8818 13.8818 12.1439 13.8818 9.99998C13.8818 7.85609 12.1439 6.1182 10 6.1182C7.85615 6.1182 6.1182 7.85615 6.1182 10C6.12078 12.1429 7.85719 13.8793 9.99979 13.8818H9.99998L10 13.8818ZM16.9364 4.36365C16.9364 5.08162 16.3544 5.66365 15.6364 5.66365C14.9184 5.66365 14.3364 5.08162 14.3364 4.36365C14.3364 3.64568 14.9184 3.06365 15.6364 3.06365C16.3544 3.06365 16.9364 3.64568 16.9364 4.36365Z" fill="#FFFBFB" />
                        </svg>
                    </div>
                </div>
                <div className="mainPage__footer__container__tag">
                    <div className="mainPage__footer__container__tag__text">© 2023 МангаМира. Все права принадлежат волшебникам в круглых очках.</div>
                </div>

            </div> */}

        </>
    )
}