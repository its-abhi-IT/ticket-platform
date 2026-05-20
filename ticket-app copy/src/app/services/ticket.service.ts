import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Ticket } from '../models/ticket.model';

// @Injectable means Angular can inject this service into components
// providedIn: 'root' means it's a singleton — one instance for the whole app
@Injectable({
  providedIn: 'root',
})
export class TicketService {
  // Base URL of your .NET API — change this to your actual URL
  private apiUrl = 'https://localhost:53113/api';

  // HttpClient is injected automatically by Angular
  constructor(private http: HttpClient) {}

  // Returns an Observable<Ticket[]>
  // Observable = a stream of data that arrives asynchronously (like a Promise)
  getTickets(): Observable<Ticket[]> {
    return this.http.get<Ticket[]>(`${this.apiUrl}/tickets`);
    //            ↑ tells TypeScript the response shape is Ticket[]
  }
}