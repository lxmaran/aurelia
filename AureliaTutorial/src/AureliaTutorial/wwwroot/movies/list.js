import {inject} from 'aurelia-framework';
import {MovieData} from './movieData'

@inject(MovieData)
export class List{
    constructor(movieData) {
        this.movieData = movieData;
    }
    //executes first after constructor
    activate() {
        return this.movieData
            .getAll()
            .then(movies => this.movies = movies );
    }

   
}
