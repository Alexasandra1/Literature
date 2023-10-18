import { api } from "./Api";

export async function registration(registration){
    await api.post(`/user`, registration);
}