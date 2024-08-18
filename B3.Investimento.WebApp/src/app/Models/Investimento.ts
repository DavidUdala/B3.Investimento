export interface InvestimentoRequest{
  valorMonetario: number,
  prazoEmMeses: number
}

export interface InvestimentoResponse {
   valorTotalBruto: number,
   valorTotalLiquido: number
}
