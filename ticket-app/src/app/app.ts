import { Component } from '@angular/core';
import { TicketListComponent } from './components/ticket-list/ticket-list';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [TicketListComponent],
  templateUrl: './app.html',
})
export class App {}