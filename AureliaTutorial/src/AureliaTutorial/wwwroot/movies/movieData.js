import {HttpClient} from 'aurelia-http-client';
import {inject} from 'aurelia-framework';

@inject(HttpClient)
export class MovieData {

    constructor(httpClient) {
        this.http = httpClient;
    }

    getAll() {
        return this.http.get("http://localhost:59482/api/movies")
        .then(response => {
            return response.content;
        });
    }

    getById(id) {
        return this.http.get('http://localhost:59482/api/movies/'+id)
            .then(response => {
                return response.content;
            });
    }
}