import axios from 'axios';

export function createUser(email: string, password: string) {
    return axios.get(`/api/test/createUser?email=${email}&password=${password}`)
}