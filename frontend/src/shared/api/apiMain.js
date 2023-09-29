import { api } from "./Api";

export async function getsmth(){
    const response = await api.get(`/WeatherForecast`)
    return response;
}