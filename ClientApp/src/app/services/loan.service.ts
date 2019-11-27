import {Inject, Injectable} from '@angular/core';
import {LoanSpecReq} from '../models/LoanSpecReq';
import {LoanDetails} from '../models/LoanDetails';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoanService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  getLoanDetails(loanSpecRequest: LoanSpecReq): Observable<LoanDetails> {
    return this.http.post<LoanDetails>(this.baseUrl + 'loan/CalculateLoanPlay', loanSpecRequest);
  }
}
