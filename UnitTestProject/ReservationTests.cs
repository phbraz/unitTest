using UnitTestTraining.Fundamentals;

namespace UnitTestProject;

[TestClass]
public class ReservationTests
{
    [TestMethod]
    public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
    {
        //Arrange
        var reservation = new Reservation();

        //Act 
        var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

        //Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
    {
        //Arrange
        var user = new User();
        var reservation = new Reservation() { MadeBy = user };
        //Act
        var result = reservation.CanBeCancelledBy(user);
        //Assert
        Assert.IsTrue(result);
    }
}