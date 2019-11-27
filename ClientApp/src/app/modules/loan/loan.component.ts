import {Component, OnInit, ViewChild} from '@angular/core';
import {LoanService} from '../../services/loan.service';
import {LoanSpecReq} from '../../models/LoanSpecReq';
import {LoanDetails} from '../../models/LoanDetails';
import {MatTable} from '@angular/material';

@Component({
  selector: 'app-loan',
  templateUrl: './loan.component.html',
  styleUrls: ['./loan.component.css']
})
export class LoanComponent implements OnInit {

  request: LoanSpecReq ;
  loanDetails: LoanDetails;
  columnsToDisplay = ['orderNo', 'amount'];
  @ViewChild(MatTable, {static: true}) table: MatTable<Element>;

  constructor(private loanService: LoanService) {
  }

  ngOnInit() {
    this.request = new LoanSpecReq();
  }

  getLoanDetails() {
    console.log(this.request);
    this.loanService.getLoanDetails(this.request).subscribe(
      (val: LoanDetails) => {
        this.loanDetails = val;
      }, err => {
        alert('An error occurred');
      }
    );

  }
}

