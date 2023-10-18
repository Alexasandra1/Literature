import { api } from "./Api";

export async function login(user) {
    const response = await api.post(`/auth/login`, user)
    return response;
}