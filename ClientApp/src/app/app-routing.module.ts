import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {DefaultComponent} from './layouts/default/default.component';
import {componentFactoryName} from '@angular/compiler';
import {LoanComponent} from './modules/loan/loan.component';


const routes: Routes = [
  {path: '', component: DefaultComponent, children: [{
        path: '', component: LoanComponent
      },
    ]},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
