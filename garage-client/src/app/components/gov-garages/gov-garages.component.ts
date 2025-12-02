import { Component , OnInit } from '@angular/core';
import { GovApiService } from '../../services/gov-api.service';
import { Garage } from '../../classes/garage';
import { GarageService } from '../../services/garage.service';

// Angular materials imports
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatButtonModule } from '@angular/material/button';
import { FormControl, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';

@Component({
  selector: 'app-gov-garages',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule, MatSelectModule, MatFormFieldModule, MatProgressSpinnerModule, MatButtonModule],
  templateUrl: './gov-garages.component.html',
  styleUrl: './gov-garages.component.scss'
})
export class GovGaragesComponent  {
  isLoading: boolean = true;
  selectedGarages = new FormControl<Garage[]>([]);
  garagersList: Array<Garage> = [];

  constructor(private govApiService: GovApiService, private garageService: GarageService) { }

  ngOnInit(): void {
    this.govApiService.getGovGarages().subscribe(data => {
      this.garagersList = data;
      this.isLoading = false;
    })
  }

  addGarages(): void {
    this.garageService.addGarages(this.selectedGarages.value).subscribe(
      data => {
        console.log(data)
      }
    )
  }
}

