using Xunit;
using codeassignment;

namespace codeassignmenttest
{
    public class Card_CompareTest
    {
        private readonly Card _card;

        public Card_CompareTest()
        {
            _card = new Card(3, "H");
        }

        [Fact]
        public void ReturnSuitOrder()
        {
            Card testCard = new Card(4, "C");
            var result = _card.CompareCards(testCard);
            int expectedResult = 1;

            Assert.Equal(result,expectedResult);
        }

        [Fact]
        public void ReturnValueOrder()
        {
            Card testCard = new Card(2, "H");
            var result = _card.CompareCards(testCard);
            int expectedResult = 1;

            Assert.Equal(result,expectedResult);
        }

        [Fact]
        public void ReturnSameCardOrder()
        {
            Card testCard = new Card(3, "H");
            var result = _card.CompareCards(testCard);
            int expectedResult = 0;

            Assert.Equal(result,expectedResult);
        }

        [Fact]
        public void ReturnShowCard()
        {
            var result = _card.Show();
            string expectedResult = "3H";

            Assert.Equal(result,expectedResult);
        }


    }
}