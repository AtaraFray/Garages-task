import { Component, OnInit } from '@angular/core';
import { GarageService } from '../../services/garage.service';
import { Garage } from '../../classes/garage';

@Component({
  selector: 'app-garages',
  standalone: true,
  imports: [],
  templateUrl: './garages.component.html',
  styleUrl: './garages.component.scss'
})
export class GaragesComponent implements OnInit {

  garages: Array<Garage> = [];
  newGarages: Array<Garage> = [];

  constructor(private garageService: GarageService) { }


  ngOnInit(): void {
    this.garageService.getGarages().subscribe(data => {
      this.garages = data
    })

  }
  addGarages(): void {
    this.garageService.addGarages(this.newGarages).subscribe(
      data => console.log(data)
    )
  }
}
