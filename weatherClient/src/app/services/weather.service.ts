import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Weather } from '../classes/weather';
import { Places } from '../classes/places';

@Injectable({
  providedIn: 'root'
})
export class WeatherService {
  url: string = "https://localhost:44352/api/Weather/";
  weather: Weather = new Weather();
  currentPlace: Places = new Places();

  constructor(private http: HttpClient) { }

  getCurrentLocation(locationKey: Number): Observable<Weather> {
    return this.http.get<Weather>(this.url + "GetWeather/" + locationKey )
  }
}
