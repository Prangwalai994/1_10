using System;
using NUnit.Framework;
using UsingNUitinVisualStudio1_10.Fundamentals;

namespace UsingNUnitTests1_10
{

    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrage
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.That(result, Is.True);
        }
        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_Return()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }
        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_RetureFalse()
        {
            var reservation = new Reservation { MadeBy = new User() };

            var result = reservation.CanBeCancelledBy(new User());

            Assert.IsFalse(result);
        }

        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {

        }


        [Test]
        public void CanBeCancelledBy_SameUseCancelling_ReturnTrue()
        {

        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnFalse()
        {

        }

    }
}
