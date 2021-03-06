﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
	class CineamaSearchService
	{
		public static IQueryable<Movie> SearchMovies(CinemaDBEntities tables, string pattern)
		{
			return tables.Movies.Where(movie => (movie.Title.Contains(pattern)) ||
													  (movie.Description.Contains(pattern)) ||
													  (movie.Director.Contains(pattern)) ||
													  (movie.Duration.ToString().Contains(pattern)) ||
													  (movie.Year.ToString().Equals(pattern)) ||
													  (movie.Id.ToString().Equals(pattern)));
			
		}

		public static IQueryable<Screening> SearchScreenings(CinemaDBEntities tables, string pattern)
		{
			return tables.Screenings.Where(screening => (screening.Id.ToString().Equals(pattern)) ||
															  (screening.Movie.ToString().Equals(pattern)) ||
															  (screening.Hall.ToString().Equals(pattern)) ||
															  (screening.Time.ToString().Contains(pattern)));
		}

		public static IQueryable<Hall> SearchHalls(CinemaDBEntities tables, string pattern)
		{
			return tables.Halls.Where(hall => (hall.Id.ToString().Equals(pattern)) ||
													(hall.NumberOfSeats.ToString().Equals(pattern)));
		}

		public static IQueryable<Ticket> SearchTickets(CinemaDBEntities tables, string pattern)
		{
			return tables.Tickets.Where(ticket => (ticket.Id.ToString().Equals(pattern)) ||
														(ticket.Hall.ToString().Equals(pattern)) ||
														(ticket.Seat.ToString().Equals(pattern)) ||
														(ticket.Price.ToString().Equals(pattern)) ||
														(ticket.Screening.ToString().Equals(pattern)));
		}

		public static IQueryable<Client> SearchClients(CinemaDBEntities tables, string pattern)
		{
			return tables.Clients.Where(client => (client.Id.ToString().Equals(pattern)) ||
														(client.DateOfBirth.ToShortDateString().Contains(pattern)) ||
														(client.FirstName.Contains(pattern)) ||
														(client.Email.Contains(pattern)) ||
														(client.LastName.Contains(pattern)));
		}
	}
}
