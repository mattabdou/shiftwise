using System;

public class Deck{

    Card[] deck = new Card[52];

    public Deck(){

        int currentDeckIndex = 0;

        // Organize the new deck first by suit according to Bicycle NDO (New Deck Order)
        string currentSuit = "N";
        for(int i = 1; i < 5; i++){
            // Define current suit based on iterator
            switch (i){
                case 1:
                    currentSuit = "H";
                    break;
                case 2:
                    currentSuit = "C";
                    break;
                case 3:
                    currentSuit = "D";
                    break;
                case 4:
                    currentSuit = "S";
                    break;
            }

            // Build out cards for current suit
            for(int j = 2; j < 15; j++){
                deck[currentDeckIndex] = new Card(j, currentSuit);
                currentDeckIndex++;
            }
        }
    }

    public void Shuffle(){
        // Shuffle using Knuth algorithm
        for (int t = 0; t < deck.Length; t++ )
        {
            Random r = new Random();
            Card tmp = deck[t];
            int n = r.Next(t, deck.Length);
            deck[t] = deck[n];
            deck[n] = tmp;
        }
    }

    public void Sort(){
        // Sort the deck of cards according to suit first, then value
        Array.Sort(deck, delegate(Card x, Card y) { return x.CompareCards(y); });
    }

    public string Show(){
        // Return a simple string-based representation of the deck in its current state
        string returnValue = "";
        foreach (Card currentCard in deck){
            returnValue = returnValue + currentCard.Show() + " ";
        };

        return returnValue;
    }

}
