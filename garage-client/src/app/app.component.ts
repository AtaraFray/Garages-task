import { Component } from '@angular/core';
import { ManageGaragesComponent } from './components/manage-garages/manage-garages.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ManageGaragesComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'garage-client';
}
