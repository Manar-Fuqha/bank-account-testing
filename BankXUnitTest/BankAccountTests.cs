using Bank;

namespace BankXUnitTest
{
    public class BankAccountTests
    {
        [Fact]
        public void Adding_Funds_Update_Balance()
        {
            //ARRANGE
            var account = new BankAccount(1000);

            //ACT
            account.Add(100);

            //ASSERT

            Assert.Equal(1100 ,account.Balance());
        }

        [Fact]
        public void WithDrawing_Funds_Update_Balance()
        {
            //ARRANGE

            var account = new BankAccount(1000);
            //ACT

            account.withDraw(100);
            //ASSERT

            Assert.Equal(900, account.Balance());
        }

        [Fact]
        public void Transfering_Funds_Updates_Both_Accounts()
        {
            //ARRANGE

            var FirstAccount = new BankAccount(1000);
            var SecondAccount = new BankAccount();
            //ACT

            FirstAccount.TranserFundsTo(SecondAccount, 100);
            //ASSERT

            Assert.Equal(900, FirstAccount.Balance());
            Assert.Equal(100, SecondAccount.Balance());

        }
    }
}