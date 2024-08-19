import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Component, Inject } from '@angular/core';

@Component({
  selector: 'app-resultado-investimento',
  templateUrl: './resultado-investimento.component.html',
  styleUrls: ['./resultado-investimento.component.scss']
})
export class ResultadoInvestimentoComponent {
  constructor(@Inject(MAT_DIALOG_DATA) public data: { valorTotalBruto: number, valorTotalLiquido: number }) {
  }
}
