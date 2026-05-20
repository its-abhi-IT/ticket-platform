export interface Ticket {
  id: number;
  title: string;
  status: 'open' | 'in-progress' | 'closed'; // only these 3 values allowed
  priority: 'low' | 'medium' | 'high';
  createdAt: string; // date as a string from the API
}