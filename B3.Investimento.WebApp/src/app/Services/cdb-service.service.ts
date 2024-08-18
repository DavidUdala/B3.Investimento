import { InvestimentoRequest } from './../Models/Investimento';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { InvestimentoResponse } from '../Models/Investimento';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})
export class CdbServiceService {

  private apiUrl: string = environment.apiUrl;

  constructor(private httpClient: HttpClient) { }

  SimulacaoResgateAplicacao(investimentoRequest : InvestimentoRequest): Observable<InvestimentoResponse> {
    return this.httpClient.post<any>(this.apiUrl + "/api/Cdb", investimentoRequest)
  }
}
