export class LoanSpecReq {
  years: number;
  amount: number;
  interestRate: number;

  constructor() {
    this.interestRate = 3.5;
  }
}
