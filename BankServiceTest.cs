using UTProject.lab2.domain;
using Moq;

namespace TestUTProject.lab2
{
    [TestFixture]
    public class BankServiceTest
    {
        private Mock<IRepository> repositoryMock;
        private Mock<Account> accountMock;
        private BankService bankService;



        [SetUp]
        public void SetUp()
        {
            repositoryMock = new Mock<IRepository>();
            accountMock = new Mock<Account>("user1",500);
            bankService = new BankService(repositoryMock.Object);
        }
        [Test]
        public void TestProcessWithdrawalSuccess()

        {
            var user = "user1";
            repositoryMock.Setup(repo => repo.FindByUsername(user)).Returns(accountMock.Object);
            accountMock.Setup(acc => acc.Withdraw(It.IsAny<double>())).Verifiable();

            // Act
            bankService.ProcessWithdrawal(user, 500.0);

            // Assert
            accountMock.Verify(acc => acc.Withdraw(500.0), Times.Once);
            repositoryMock.Verify(repo => repo.Save(accountMock.Object), Times.Once);

        }




    }
}
