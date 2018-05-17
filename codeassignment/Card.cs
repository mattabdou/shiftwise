public class Card{

    public int value;
    public string suit;

    public Card(int newValue, string newSuit){
        value = newValue;
        suit = newSuit;
    }

    public int CompareCards(Card secondCard){
        // Use built-in string compare to get alphabetical comparison of suit
        int suitComparison = suit.CompareTo(secondCard.suit);
        if(suitComparison == 1){
            return 1;
        }
        else if (suitComparison == -1){
            return -1;
        }
        else
            // Suits are the same, so compare card values numerically
            if(value > secondCard.value){
                return 1;
            }
            else if(value < secondCard.value){
                return -1;
            }
            else
                // If suit and value are the same, then the cards are the same
                return 0;
    }

    public string Show(){

        string showValue = "0";

        // First determine the face value of the card
        if(value < 11){
            showValue = value.ToString();
        }
        else{
            switch (value){
                case 11:
                    showValue = "J";
                    break;

                case 12:
                    showValue = "Q";
                    break;

                case 13:
                    showValue = "K";
                    break;

                case 14:
                    showValue = "A";
                    break;
            }
        }

        // Concatenate the value and the suit to get string-representation of card
        string returnValue = showValue + suit;
        return returnValue;
    }
}
