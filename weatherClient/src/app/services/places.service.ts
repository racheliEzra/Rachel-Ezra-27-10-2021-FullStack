import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Places } from '../classes/places';

@Injectable({
  providedIn: 'root'
})
export class PlacesService {

  url: string = "https://localhost:44352/api/Places/";
  places: Array<Places> = new Array<Places>();
  // placesString: String = "";

  constructor(private http: HttpClient) { }
  
  GetAllPlacesBySearch(searchWord: String): Observable<Array<Places>> {
    return this.http.get<Array<Places>>(this.url + "GetPlacesBySearch/" + searchWord)
  }
}
