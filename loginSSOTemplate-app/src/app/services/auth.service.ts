import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private apiBase = environment.apiBase;

  loginWithProvider(provider: string) {
    window.location.href = `${this.apiBase}/${provider}`;
  }
}
