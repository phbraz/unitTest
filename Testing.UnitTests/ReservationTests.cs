using NUnit.Framework;
using UnitTesting.Fundamentals;
using Assert = NUnit.Framework.Assert;

namespace UnitTestProject;

[TestFixture]
public class ReservationTests
{
    [Test]
    public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
    {
        //Arrange
        var reservation = new Reservation();
        //Act 
        var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });
        //Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
    {
        //Arrange
        var user = new User();
        var reservation = new Reservation() { MadeBy = user };
        //Act
        var result = reservation.CanBeCancelledBy(user);
        //Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsFalse()
    {
        //Arrange
        var reservation = new Reservation() { MadeBy = new User() };
        //Act 
        var result = reservation.CanBeCancelledBy(new User());
        //Assert
        Assert.That(result, Is.False);
    }
}