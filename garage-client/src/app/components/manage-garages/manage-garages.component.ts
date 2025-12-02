import { Component , OnInit } from '@angular/core';
import { GovGaragesComponent } from "../gov-garages/gov-garages.component";
import { GaragesComponent } from "../garages/garages.component";
import { GovApiService } from '../../services/gov-api.service';
import { GarageService } from '../../services/garage.service';
import { Garage } from '../../classes/garage';

@Component({
  selector: 'app-manage-garages',
  standalone: true,
  imports: [GovGaragesComponent, GaragesComponent],
  templateUrl: './manage-garages.component.html',
  styleUrl: './manage-garages.component.scss'
})
export class ManageGaragesComponent implements OnInit {

  garagersGovList : Array<Garage> =[];
  garagersList : Array<Garage> =[];
  isLoading: boolean = true;
  
  constructor(private govApiService: GovApiService, private garageService: GarageService) { }

  ngOnInit(): void {
    this.govApiService.getGovGarages().subscribe(data => {
      this.garagersGovList = data;
      this.isLoading = false;
    });

    this.getGarages();
  }

  addGarages(selectedGarages : Garage[]): void {
    this.garageService.addGarages(selectedGarages).subscribe(
      data => {
        this.getGarages();
      }
    )
  }

  getGarages(){
    this.garageService.getGarages().subscribe(data => {
      this.garagersList = data;
    });
  }
}
