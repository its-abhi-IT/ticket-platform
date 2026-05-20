import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TicketService } from '../../services/ticket.service';
import { Ticket } from '../../models/ticket.model';

@Component({
  selector: 'app-ticket-list',
  standalone: true,
  imports: [CommonModule],   // ← gives you *ngIf, *ngFor, and the date pipe
  templateUrl: './ticket-list.html',
})
export class TicketListComponent implements OnInit {
  tickets: Ticket[] = [];
  isLoading = false;
  errorMessage = '';

  constructor(private ticketService: TicketService) {}

  ngOnInit(): void {
    this.loadTickets();
  }

  loadTickets(): void {
    this.isLoading = true;
    this.errorMessage = '';

    this.ticketService.getTickets().subscribe({
      next: (data) => {
        this.tickets = data;
        this.isLoading = false;
      },
      error: (err) => {
        this.errorMessage = 'Failed to load tickets. Please try again.';
        this.isLoading = false;
        console.error(err);
      },
    });
  }
}