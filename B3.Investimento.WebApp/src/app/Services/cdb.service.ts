import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { InvestimentoRequest, InvestimentoResponse } from '../Models/Investimento';

@Injectable({
  providedIn: 'root'
})
export class CdbService {

  private apiUrl: string = environment.apiUrl;

  constructor(private httpClient: HttpClient) { }

  SimulacaoResgateAplicacao(investimentoRequest : InvestimentoRequest): Observable<InvestimentoResponse> {
    return this.httpClient.post<any>(this.apiUrl + "/api/Cdb/SimulacaoResgateAplicacao", investimentoRequest)
  }
}
