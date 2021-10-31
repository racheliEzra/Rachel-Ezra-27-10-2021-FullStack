import { Component, OnInit } from '@angular/core';
import { PlacesService } from 'src/app/services/places.service';
import { Router } from '@angular/router';
import { WeatherService } from 'src/app/services/weather.service';
import { Places } from 'src/app/classes/places';

@Component({
  selector: 'app-places',
  templateUrl: './places.component.html',
  styleUrls: ['./places.component.css']
})
export class PlacesComponent implements OnInit {

  constructor(
    protected route: Router,
    public PlacesService: PlacesService,
    public WeatherService: WeatherService
  ) { }

  ngOnInit(): void {
  }

  getCurrentWeather(place: Places) {
      this.WeatherService.getCurrentLocation(Number(place.key)).subscribe(data => {
        this.WeatherService.weather = data;
        this.WeatherService.currentPlace = place;
      },
        err => { })
  }

}
