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
            Assert.Equal(400, result);
        }

        [Fact]
        public void TicketIsPremiumAndStudent()
        {
            //Arrange
            Movie movie = new Movie("TestMovie");
            MovieScreening movieScreening = new MovieScreening(movie, new DateTime(2022, 02, 05), 100);
            MovieTicket movieTicket1 = new MovieTicket(movieScreening, true, 1, 1);
            Order order = new Order(1, true);
            order.AddSeatReservation(movieTicket1);


            //Act
            double result = order.CalculatePrice();

            //Assert
            Assert.Equal(102, result);
        }

        [Fact]
        public void TicketIsPremiumAndNotStudent()
        {
            //Arrange
            Movie movie = new Movie("TestMovie");
            MovieScreening movieScreening = new MovieScreening(movie, new DateTime(2022, 02, 05), 100);
            MovieTicket movieTicket1 = new MovieTicket(movieScreening, true, 1, 1);
            Order order = new Order(1, false);
            order.AddSeatReservation(movieTicket1);

            //Act
            double result = order.CalculatePrice();

            //Assert
            Assert.Equal(103, result);
        }

        [Fact]
        public void OrderShouldHaveGroupDiscount()
        {
            //Arrange
            Movie movie = new Movie("TestMovie");
            MovieScreening movieScreening = new MovieScreening(movie, new DateTime(2022, 02, 05), 100);
            MovieTicket movieTicket1 = new MovieTicket(movieScreening, false, 1, 1);
            MovieTicket movieTicket2 = new MovieTicket(movieScreening, false, 1, 1);
            MovieTicket movieTicket3 = new MovieTicket(movieScreening, false, 1, 1);
            MovieTicket movieTicket4 = new MovieTicket(movieScreening, false, 1, 1);
            MovieTicket movieTicket5 = new MovieTicket(movieScreening, false, 1, 1);
            MovieTicket movieTicket6 = new MovieTicket(movieScreening, false, 1, 1);
            Order order = new Order(1, false);
            order.AddSeatReservation(movieTicket1);
            order.AddSeatReservation(movieTicket2);
            order.AddSeatReservation(movieTicket3);
            order.AddSeatReservation(movieTicket4);
            order.AddSeatReservation(movieTicket5);
            order.AddSeatReservation(movieTicket6);

            //Act
            double result = order.CalculatePrice();

            //Assert
            Assert.Equal(540, result);
        }
    }
}