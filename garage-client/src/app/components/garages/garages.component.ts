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

    if (this.dataSource != null ){
      this.dataSource.filterPredicate = (data: any, filter: string) => {
        const text = filter.trim().toLowerCase();
        return (
          data.garageName?.toLowerCase().includes(text) ||
          data.profession?.toLowerCase().includes(text) ||
          data.garageAddress?.toLowerCase().includes(text) ||
          data.garageCity?.toLowerCase().includes(text)
        );
      };
    }

  }

  search(event: any){
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
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
