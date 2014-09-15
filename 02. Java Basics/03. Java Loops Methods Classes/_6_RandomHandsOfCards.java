import java.util.Random;
import java.util.Scanner;

// Write a program to generate n random hands of
// 5 different cards form a standard suit of 52 cards. 

// I'm using external code for this one
public class _6_RandomHandsOfCards {
	public static void main(String[] args) {
		// Instantiating a deck of cards and shuffles it
		Deck playingCards = new Deck();
		playingCards.shuffle();
		
		// Getting user input
		System.out.print("Please enter the number of hands: ");
		Scanner input = new Scanner(System.in);
		int numberOfHands = input.nextInt();

		// Printing the result
		System.out.println("The random hands are:");
		Card[] hand = new Card[5];
		
		// Iterating trough hands
		for (int handCounter = 0; handCounter < numberOfHands; handCounter++) {
			// Iterating trough cards
			for (int card = 0; card < 5; card++) {
				// Taking a card
				hand[card] = playingCards.deal();
				
				// Printing it
				System.out.print(hand[card] + " ");
			}
			
			// Printing a new line after each hand
			System.out.println();
		}
	}
}

final class Deck {

	// //////////////////////////////////////
	// Data Members
	// //////////////////////////////////////

	private Card[] cards; // array holding all 52 cards
	private int cardsInDeck; // the current number of cards in the deck

	public static final int DECK_SIZE = 52;

	// size of standard deck of cards

	// //////////////////////////////////////
	// Constructors
	// //////////////////////////////////////

	/**
	 * Constructs a new Deck object containing 52 cards.
	 */
	public Deck() {
		cards = new Card[DECK_SIZE];
		cardsInDeck = DECK_SIZE;
		for (int i = 0; i < 13; i++) {
			cards[i] = new Card(i + 1, Card.HEARTS);
			cards[i + 13] = new Card(i + 1, Card.DIAMONDS);
			cards[i + 26] = new Card(i + 1, Card.CLUBS);
			cards[i + 39] = new Card(i + 1, Card.SPADES);
		}
	}

	// //////////////////////////////////////
	// Public Methods
	// //////////////////////////////////////

	/**
	 * Returns the number of cards in the deck.
	 * 
	 * @return number of cards in the deck
	 */
	public int cardsInDeck() {
		return cardsInDeck;
	}

	/**
	 * Deals one card from the deck, decreasing the number of cards in the deck
	 * by one.
	 * 
	 * @return the next Card object in the deck
	 * @throws EmptyDeckException
	 */
	public Card deal() {
		cardsInDeck--;
		return cards[cardsInDeck];
		// NOTE: the dealt card is still being referenced in the cards
		// array. In general, when an item is removed from an array,
		// its place in the array should be set to null. However, in
		// this specific case we are choosing not to remove the card
		// so that if we want to start over with a full deck of cards,
		// we can just reset the cardsInDeck data member and not have
		// to create each of the Card objects again.
	}

	/**
	 * Shuffles the deck (i.e. randomly reorders the cards in the deck).
	 */
	public void shuffle() {
		int newI;
		Card temp;
		Random randIndex = new Random();

		for (int i = 0; i < cardsInDeck; i++) {

			// pick a random index between 0 and cardsInDeck - 1
			newI = randIndex.nextInt(cardsInDeck);

			// swap cards[i] and cards[newI]
			temp = cards[i];
			cards[i] = cards[newI];
			cards[newI] = temp;
		}
	}

	/**
	 * Resets the deck so that it has all its cards. Note that the order of the
	 * cards may be random.
	 */
	public void reset() {
		cardsInDeck = DECK_SIZE;
	}

	/**
	 * Returns a String representation of the Deck object. The cards currently
	 * in the deck are printed out 13 to a row.
	 * 
	 * @return a String representation of the deck
	 */
	public String toString() {

		// check for an empty deck
		if (cardsInDeck == 0)
			return "<empty>";

		String s = cards[0].toString() + ' ';
		for (int i = 1; i < cardsInDeck; i++) {
			if (i % 13 == 0)
				s += '\n';
			s += cards[i].toString() + ' ';
		}
		return s;
	}

} // end class Deck

/**
 * Represents a playing card.
 * 
 * Bugs: none known
 * 
 * @author Beck Hasti (hasti@cs.wisc.edu), copyright 2005, all rights reserved
 */
final class Card {

	// //////////////////////////////////////
	// Data Members
	// //////////////////////////////////////

	private int face; // the card's face value, between 1 and 13 inclusive
	private int suit; // the card's suit; one of the class constants

	// class constants for the suits
	public static final int HEARTS = 1;
	public static final int DIAMONDS = 2;
	public static final int CLUBS = 3;
	public static final int SPADES = 4;

	// //////////////////////////////////////
	// Constructors
	// //////////////////////////////////////

	/**
	 * Constructs a Card object with the given face value and suit value. The
	 * face value of the card is set to 1 if an invalid face value is given; the
	 * suit of the card is set to HEARTS if an invalid suit is given.
	 * 
	 * @param face
	 *            the face value of the card
	 * @param suit
	 *            the suit of the card
	 */
	public Card(int face, int suit) {
		this.face = face;
		if (face < 1 || face > 13) {
			System.out.println("ERROR: invalid face value");
			this.face = 1;
		}

		this.suit = suit;
		if (suit != HEARTS && suit != DIAMONDS && suit != CLUBS
				&& suit != SPADES) {
			System.out.println("ERROR: invalid suit value");
			this.suit = HEARTS;
		}
	}

	// //////////////////////////////////////
	// Public Methods
	// //////////////////////////////////////

	/**
	 * Returns the face value of the card.
	 * 
	 * @return face value of the card (between 1 and 13, inclusive)
	 */
	public int getFace() {
		return face;
	}

	/**
	 * Returns the suit of the card.
	 * 
	 * @return suit of the card (HEARTS, DIAMONDS, CLUBS, or SPADES)
	 */
	public int getSuit() {
		return suit;
	}

	/**
	 * Returns a String representation of a Card object. The string has the
	 * format "ffs" where ff is the face value (padded with a space, if
	 * necessary) and s is the suit.
	 * 
	 * @return a String representation of a Card object
	 */
	public String toString() {
		String s = "";
		switch (face) {
		case 1:
			s += " A";
			break;
		case 11:
			s += " J";
			break;
		case 12:
			s += " Q";
			break;
		case 13:
			s += " K";
			break;
		case 10:
			s += "10";
			break;
		default:
			s += " " + face;
			break;
		}

		switch (suit) {
		case HEARTS:
			s += '♥';
			break;
		case DIAMONDS:
			s += '♦';
			break;
		case CLUBS:
			s += '♠';
			break;
		case SPADES:
			s += '♣';
			break;
		}

		return s;
	}
}