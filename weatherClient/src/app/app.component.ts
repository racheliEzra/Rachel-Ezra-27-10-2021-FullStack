import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { WeatherService } from 'src/app/services/weather.service'
import { PlacesService } from './services/places.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  constructor(
    protected route: Router,
    public WeatherService: WeatherService,
    public PlacesService: PlacesService) { }
  ngOnInit() {
  }

  GetAllPlacesBySearchWord(searchWord: string) {
    debugger
    this.route.navigate(['/'])
    this.PlacesService.GetAllPlacesBySearch(searchWord).subscribe(data => {
      debugger
      this.PlacesService.places = data
      this.route.navigate(['/places']);
      console.log(data);
    }, err => { })
  }

}
