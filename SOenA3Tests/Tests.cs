using Xunit;
using Domain;
using System;

namespace SOenA3Tests
{
    public class Tests
    {
        [Fact]
        public void Second_Ticket_Should_Be_Free()
        {
            // Arrange
            Movie movie = new Movie("TestMovie");
            MovieScreening movieScreening = new MovieScreening(movie, new DateTime(2022, 02, 01), 100);
            MovieTicket movieTicket1 = new MovieTicket(movieScreening, false, 1, 1);
            MovieTicket movieTicket2 = new MovieTicket(movieScreening, false, 1, 1);
            MovieTicket movieTicket3 = new MovieTicket(movieScreening, false, 1, 1);
            MovieTicket movieTicket4 = new MovieTicket(movieScreening, false, 1, 1);
            Order order = new Order(1, false);
            order.AddSeatReservation(movieTicket1);
            order.AddSeatReservation(movieTicket2);
            order.AddSeatReservation(movieTicket3);
            order.AddSeatReservation(movieTicket4);

            // Act
            double result = order.CalculatePrice();

            // Assert
            Assert.Equal(200, result);
        }

        [Fact]
        public void Second_Ticket_Should_Not_Be_Free()
        {
            // Arrange
            Movie movie = new Movie("TestMovie");
            MovieScreening movieScreening = new MovieScreening(movie, new DateTime(2022, 02, 05), 100);
            MovieTicket movieTicket1 = new MovieTicket(movieScreening, false, 1, 1);
            MovieTicket movieTicket2 = new MovieTicket(movieScreening, false, 1, 1);
            MovieTicket movieTicket3 = new MovieTicket(movieScreening, false, 1, 1);
            MovieTicket movieTicket4 = new MovieTicket(movieScreening, false, 1, 1);
            Order order = new Order(1, false);
            order.AddSeatReservation(movieTicket1);
            order.AddSeatReservation(movieTicket2);
            order.AddSeatReservation(movieTicket3);
            order.AddSeatReservation(movieTicket4);

            // Act
            double result = order.CalculatePrice();

            // Assert
            Assert.Equal(200, result);
        }
    }
}