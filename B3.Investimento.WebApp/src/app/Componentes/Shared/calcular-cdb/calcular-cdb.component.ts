import { InvestimentoRequest } from '../../../Models/Investimento';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CdbService } from '../../../Services/cdb.service';
import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ResultadoInvestimentoComponent } from 'src/app/Componentes/Shared/resultado-investimento/resultado-investimento.component';

@Component({
  selector: 'app-calcular-cdb',
  templateUrl: './calcular-cdb.component.html',
  styleUrls: ['./calcular-cdb.component.scss']
})
export class CalcularCdbComponent implements OnInit {
  calcularCdbForm!: FormGroup;

  constructor(private fb: FormBuilder, private cdbService: CdbService, public dialog: MatDialog) { }

  ngOnInit(): void {
    this.calcularCdbForm = this.fb.group({
      valorMonetario: [null, [Validators.required, Validators.min(0.01)]],
      prazoEmMeses: [null, [Validators.required, Validators.min(2)]]
    })
  }

  simular() {
    if (this.calcularCdbForm.valid) {
      const request: InvestimentoRequest = this.calcularCdbForm.value;
      this.cdbService.SimulacaoResgateAplicacao(request).subscribe({
        next: (response) => {
          this.openModal(response.ValorTotalBruto, response.ValorTotalLiquido);
        },
        error: (err) => {
          console.log('Erro ao realizar simulação', err)
        }
      });
    }
  }

  openModal(valorBruto: number, valorLiquido: number) {
    this.dialog.open(ResultadoInvestimentoComponent, {
      data: {
        valorTotalBruto: valorBruto,
        valorTotalLiquido: valorLiquido
      }
    });
  }
}
