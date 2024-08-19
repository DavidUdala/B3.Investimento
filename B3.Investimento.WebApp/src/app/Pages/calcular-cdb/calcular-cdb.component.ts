import { InvestimentoRequest, InvestimentoResponse } from './../../Models/Investimento';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CdbService } from './../../Services/cdb.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calcular-cdb',
  templateUrl: './calcular-cdb.component.html',
  styleUrls: ['./calcular-cdb.component.scss']
})
export class CalcularCdbComponent implements OnInit {
  calcularCdbForm!: FormGroup;

  constructor(private fb: FormBuilder, private cdbService: CdbService) { }

  ngOnInit(): void {
    this.calcularCdbForm = this.fb.group({
      valorMonetario: [null, Validators.required],
      prazoEmMeses: [null, Validators.required]
    })
  }

  Simular() {
    const request: InvestimentoRequest = this.calcularCdbForm.value;
    this.cdbService.SimulacaoResgateAplicacao(request).subscribe({
      next: (value) => {
        console.log('Simulação realizada com sucesso', value);
      },
      error: (err) => {
        console.log('Erro ao realizar simulação', err)
      }
    });
  }
}
