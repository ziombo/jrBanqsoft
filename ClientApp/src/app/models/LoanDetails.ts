import {MonthlyPayment} from './MonthlyPayment';

export class LoanDetails {
  totalAmount: number;
  interestRate: number;
  totalInterestAmount: number;
  baseAmount: number;
  monthlyPayments: MonthlyPayment[];

  constructor() {
    this.monthlyPayments = [];
  }
}
