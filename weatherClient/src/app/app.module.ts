import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { WeatherComponent } from './components/weather/weather.component';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { PlacesComponent } from './components/places/places.component';

@NgModule({
  declarations: [
    AppComponent,
    WeatherComponent,
    PlacesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [AppComponent, PlacesComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
