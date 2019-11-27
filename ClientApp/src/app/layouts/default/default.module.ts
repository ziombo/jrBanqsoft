import {NgModule} from '@angular/core';
import {DefaultComponent} from './default.component';
import {SharedModule} from '../../shared/shared.module';
import {RouterModule} from '@angular/router';
import {BrowserModule} from '@angular/platform-browser';
import {LoanComponent} from '../../modules/loan/loan.component';
import {DigitOnlyDirective} from '../../modules/digit-only.directive';
import {MatButtonModule, MatDividerModule, MatFormFieldModule, MatInputModule, MatTableModule} from '@angular/material';
import {FormsModule} from '@angular/forms';
import {FlexModule} from '@angular/flex-layout';

@NgModule({
  declarations: [
    DefaultComponent,
    LoanComponent,
    DigitOnlyDirective,
  ],
  exports: [
    DefaultComponent,
  ],
  imports: [
    SharedModule,
    RouterModule,
    BrowserModule,
    MatTableModule,
    FormsModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatDividerModule,
    FlexModule
  ]
})
export class DefaultModule {
}
