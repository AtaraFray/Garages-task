import { Component, Input, OnChanges } from '@angular/core';
import { Garage } from '../../classes/garage';

// Angular material imports
import { MatTableDataSource, MatTableModule } from '@angular/material/table';

@Component({
  selector: 'app-garages',
  standalone: true,
  imports: [MatTableModule],
  templateUrl: './garages.component.html',
  styleUrl: './garages.component.scss'
})
export class GaragesComponent implements OnChanges  {
  @Input() garages: Array<Garage> = [];

  displayedColumns = [ 'garageId', 'garageNumber', 'garageName', 'garageCodeType',
    'garageType', 'garageAddress', 'garageCity', 'garagePhone', 'garagePostalCode'
    , 'garageProfession', 'profession', 'registerCompany'];

  dataSource = new MatTableDataSource<Element>();

  ngOnChanges(): void {
    this.dataSource = new MatTableDataSource<Element>(this.garages);
  }

}


export interface Element {
  id: number,
  garageId: number,
  garageNumber: number,
  garageName: string,
  garageCodeType: number,
  garageType: string,
  garageAddress: string,
  garageCity: string,
  garagePhone: string,
  garagePostalCode: number,
  garageProfession: number,
  profession: string,
  professionManager: string,
  registerCompany: number,
  testime: string
}
