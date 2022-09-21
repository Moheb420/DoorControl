using System.Security.Claims;
using Moq;

namespace DoorControl.Test.Unit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void DoorOpenTest()
        {
            IFakeDoor iDoor = new FakeDoor();
            
            var uut = new DoorControl(iDoor);
            bool faketest = false;
            faketest = uut.FakeDoorOpened();
            Assert.That(faketest, Is.True);
        }
        [Test]
        public void mockeOpenTest()
        {
            // arranging
            var mockeDoorOPenTest = new Mock<IfakeDoorControl>();
            mockeDoorOPenTest.Setup(x => x.FakeDoorOpened()).Returns(true);

            // acting
            bool tst = mockeDoorOPenTest.Object.FakeDoorOpened();
            //assert
            Assert.That(tst,Is.True);

        }
    }
}