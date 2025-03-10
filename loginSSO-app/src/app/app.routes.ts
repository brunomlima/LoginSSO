import { Route } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { SuccessComponent } from './components/success/success.component';

export const routes: Route[] = [
  { path: '', component: LoginComponent }, 
  { path: 'success', component: SuccessComponent }
];
