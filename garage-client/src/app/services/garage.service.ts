import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Garage } from '../classes/garage';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GarageService {

  garageApiUrl: string = 'https://localhost:7010/api/Garage';

  constructor(private httpClient: HttpClient) { }

  getGarages(): Observable<Array<Garage>> {
    return this.httpClient.get<Array<Garage>>(this.garageApiUrl);
  }

  addGarages(garages : Array<Garage> | null):Observable<any>{
    return this.httpClient.post(this.garageApiUrl , garages , { responseType: 'text' });
  }
}
