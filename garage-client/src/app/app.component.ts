import { Component } from '@angular/core';
import { GovGaragesComponent } from "./components/gov-garages/gov-garages.component";
import { GaragesComponent } from "./components/garages/garages.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [GovGaragesComponent, GaragesComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'garage-client';
}
