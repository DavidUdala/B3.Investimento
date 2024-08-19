export interface InvestimentoRequest{
  valorMonetario: number,
  prazoEmMeses: number
}

export interface InvestimentoResponse {
   ValorTotalBruto: number,
   ValorTotalLiquido: number
}
