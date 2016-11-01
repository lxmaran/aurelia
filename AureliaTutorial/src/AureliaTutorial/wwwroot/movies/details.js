import {MovieData} from "./movieData";
import {inject} from "aurelia-framework";

@inject(MovieData)
export class Details {
    constructor(movieData) {
        this.movieData = movieData;
    }

    activate(params) {
        console.log(params.id);
        return this.movieData.getById(params.id)
            .then(movie => this.movie = movie);
    }
}