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
        public void Adding_Negative_Funds_Throws()
        {
            //ARRANGE
            var account = new BankAccount(1000);

            //ACT +ASSERT
            
            Assert.Throws<ArgumentOutOfRangeException>(()=> account.Add(-100));
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
        public void WithDrawing_Negative_Funds_Throws()
        {
            //ARRANGE

            var account = new BankAccount(1000);
            //ACT +ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(()=> account.withDraw(-100));
        }

        [Fact]
        public void WithDrawing_More_Than_Funds_Throws()
        {
            //ARRANGE

            var account = new BankAccount(1000);
            //ACT +ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => account.withDraw(2000));
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

        [Fact]
        public void TranserFundsTo_Non_Existing_Accounts_Throws()
        {
            //ARRANGE

            var account = new BankAccount(1000);
            //ACT +ASSERT
            Assert.Throws<ArgumentNullException>(() => account.TranserFundsTo(null ,2000));
        }
    }
}