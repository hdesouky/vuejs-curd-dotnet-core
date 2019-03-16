import axios from 'axios';

class UsersService {
  API_URL = 'http://localhost:5000/api/users';

  getAll() {
    return axios.get(this.API_URL).then(response => response.data);
  }

  getById(id) {
    return axios.get(`${this.API_URL}/${id}`).then(response => response.data);
  }

  create(user) {
    return axios.post(`${this.API_URL}`, user).then(response => response);
  }

  update(id, user) {
    return axios.put(`${this.API_URL}/${id}`, user).then(response => response);
  }

  delete(id) {
    return axios.delete(`${this.API_URL}/${id}`).then(response => response);
  }
}

export { UsersService as default };
