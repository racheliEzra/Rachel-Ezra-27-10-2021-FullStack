import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PlacesComponent } from './components/places/places.component';
import { WeatherComponent } from './components/weather/weather.component';

const routes: Routes = [
  {
    path: 'weather',
    component: WeatherComponent
  },
  {
    path: 'places',
    component: PlacesComponent
  }
]

@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
