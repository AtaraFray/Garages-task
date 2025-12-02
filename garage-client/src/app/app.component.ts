import { Component } from '@angular/core';
import { GovGaragesComponent } from './components/gov-garages/gov-garages.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [GovGaragesComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'garage-client';
}
