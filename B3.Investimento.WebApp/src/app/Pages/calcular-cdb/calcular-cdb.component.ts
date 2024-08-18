import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CdbService } from './../../Services/cdb.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-calcular-cdb',
  templateUrl: './calcular-cdb.component.html',
  styleUrls: ['./calcular-cdb.component.scss']
})
export class CalcularCdbComponent {
  investmentForm: FormGroup;
  result: { gross: number, net: number } | null = null;

  constructor(private fb: FormBuilder, private cdbService: CdbService) {
    this.investmentForm = this.fb.group({
      amount: [null, [Validators.required, Validators.min(0.01)]],
      months: [null, [Validators.required, Validators.min(2)]]
    });
  }

  onSubmit() {
    if (this.investmentForm.valid) {
      // const { amount, months } = this.investmentForm.value;
      // this.investmentService.calculateInvestment(amount, months).subscribe(result => {
      //   this.result = result;
      // });
    }
  }
}
