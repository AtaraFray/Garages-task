import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Garage } from '../classes/garage';

@Injectable({
  providedIn: 'root'
})
export class GovApiService {

  govApiUrl: string = 'https://localhost:7010/api/Garage/gov';

  constructor(private httpClient: HttpClient) { }

  getGovGarages(): Observable<Array<Garage>> {
    return this.httpClient.get<Array<Garage>>(this.govApiUrl);
  }
  
}
