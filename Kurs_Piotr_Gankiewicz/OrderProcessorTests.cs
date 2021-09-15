using FluentAssertions;
using Kurs.Models;
using Moq;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        public User User;
        public Order Order;
        public Mock<IDatabase> DatabaseMock;        //using Moq; 
        public Mock<IEmailSender> EmailSenderMock;  //Mock(ing) - naœladowanie zachowania

        public IOrderProcessor OrderProcessor; //SUT - System Under Test
                                               //(reszta to zwyk³e implementacje, by IOrderProcessor dzia³a³) 
        [SetUp]
        public void Setup()
        {
            User = new User("user1@onet.pl", "secret");
            Order = new Order(1, 10);
            DatabaseMock = new Mock<IDatabase>();
            EmailSenderMock = new Mock<IEmailSender>();                                 // By testowaæ Propertisy User'a to:
            DatabaseMock.Setup(x => x.GetUser(It.IsAny<string>())).Returns(User);       // => x.GetUer(User.Email)
            DatabaseMock.Setup(x => x.GetOrder(It.IsAny<int>())).Returns(Order);

            OrderProcessor = new OrderProcessor(DatabaseMock.Object, EmailSenderMock.Object);
            
        }

        [Test]
        public void test_process_order_should_succeed()
        {
            User.IncreaseFunds(100);
            User.Activate();
            OrderProcessor.ProcessOrder(User.Email,Order.Id);

            DatabaseMock.Verify(x => x.GetUser(It.IsAny<string>()), Times.Once);
            DatabaseMock.Verify(x => x.GetOrder(It.IsAny<int>()), Times.Once);
            Assert.IsTrue(Order.IsPurchased);

            //U¿ycie FluentAssertions

        }
        [Test]
        public void test_order_is_purchased()
        {
            User.IncreaseFunds(100);
            User.Activate();
            OrderProcessor.ProcessOrder(User.Email, Order.Id);
            Order.IsPurchased.Should().BeTrue();
        }
    }
}