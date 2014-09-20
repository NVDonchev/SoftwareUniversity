import java.util.ArrayList;
import java.util.Scanner;

public class _4_StraightFlush {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String input = scan.nextLine();
		String[] cardsRaw = input.split(",\\s");
		
		FlushChecker flushChecker = new FlushChecker(cardsRaw);
		
		String[][] cards = flushChecker.Cards;
		
		ArrayList<ArrayList<String>> hands = new ArrayList<ArrayList<String>>();
		hands.add(new ArrayList<String>());
		int currentHand = 0;
		int matchCount = 1;
		
		for (int outerIndex = 0; outerIndex < cards.length; outerIndex++) {
			
			int currentCard = outerIndex;
			int innerIndex = 0;
			
			while (innerIndex < cards.length) {
				int nextCard = innerIndex;
				if (flushChecker.checkForFlushes(cards[currentCard], cards[nextCard])) {
					hands.get(currentHand).add(cards[currentCard][0] + cards[currentCard][1]);
					currentCard = innerIndex;
					matchCount++;
					innerIndex = -1;
					currentHand = hands.size() - 1;
					
					if (matchCount == 5) {
						hands.get(currentHand).add(cards[nextCard][0] + cards[nextCard][1]);
						hands.add(new ArrayList<String>());
						matchCount = 1;
						break;
					}
				}
				innerIndex++;
			}
			
			if (hands.get(currentHand).size() > 0) {
				hands.add(new ArrayList<String>());
			}
		}
		
		for (ArrayList<String> hand : hands) {
			for (String card : hand) {
				System.out.print(card + " ");
			}
			System.out.println();
		}
	}
}

final class FlushChecker {
	public String[][] Cards;
	
	public FlushChecker(String[] unsplittedCards) {
		this.Cards = splitFaceAndSuit(unsplittedCards);
	}
	
	private String[][] splitFaceAndSuit(String[] unsplittedCards) {
		String[][] splittedCards = new String[unsplittedCards.length][2];
		
		for (int card = 0; card < unsplittedCards.length; card++) {
			splittedCards[card][1] = unsplittedCards[card].substring(unsplittedCards[card].length() - 1);
			splittedCards[card][0] = unsplittedCards[card].replace(splittedCards[card][1], "");
		}
		
		return splittedCards;
	}

	public boolean checkForFlushes(String[] firstCard, String[] secondCard) {
		int firstFace = convertFaceToInt(firstCard[0]);
		int secondFace = convertFaceToInt(secondCard[0]);
		String firstSuit = firstCard[1];
		String secondSuit = secondCard[1];
		
		if (firstFace + 1 == secondFace && firstSuit.equals(secondSuit)) {
			return true;
		}
		
		return false;
	}
	
	private int convertFaceToInt(String face) {
		switch (face) {
		case "2":
			return 2;
		case "3":
			return 3;
		case "4":
			return 4;
		case "5":
			return 5;
		case "6":
			return 6;
		case "7":
			return 7;
		case "8":
			return 8;
		case "9":
			return 9;
		case "10":
			return 10;
		case "J":
			return 11;
		case "Q":
			return 12;
		case "K":
			return 13;
		case "A":
			return 14;
		default:
			return 0;
		}
	}
}