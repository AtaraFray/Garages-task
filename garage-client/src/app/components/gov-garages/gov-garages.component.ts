import { Component, OnInit } from '@angular/core';
import { GovApiService } from '../../services/gov-api.service';
import { Garage } from '../../classes/garage';

@Component({
  selector: 'app-gov-garages',
  standalone: true,
  imports: [],
  templateUrl: './gov-garages.component.html',
  styleUrl: './gov-garages.component.scss'
})
export class GovGaragesComponent implements OnInit {

  govGarages: Array<Garage> = [];
  constructor(private govApiService: GovApiService) { }

  ngOnInit(): void {
    this.govApiService.getGovGarages().subscribe(data => {
      this.govGarages = data
    })
  }
}
