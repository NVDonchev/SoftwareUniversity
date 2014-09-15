// In most Poker games, the "full house" hand is defined
// as three cards of the same face + two cards of the same face,
// other than the first, regardless of the card's suits.
// The cards faces are "2", "3", "4", "5", "6", "7", "8",
// "9", "10", "J", "Q", "K" and "A". The card suits are
// "♣", "♦", "♥" and "♠". Write a program to generate and
// print all full houses and print their number.

public class _3_FullHouse {
	public static void main(String[] args) {
		// Initializing card arrays and a counter
		String[] faces = new String[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
		String[] suits = new String[] { "♣", "♦", "♥", "♠" };
		int combinationsCount = 0;
		
		// Iterating through the faces
		for (int firstFaceCounter = 0; firstFaceCounter < faces.length; firstFaceCounter++) {
			for (int secondFaceCounter = firstFaceCounter + 1; secondFaceCounter < faces.length; secondFaceCounter++) {
				String firstFace = faces[firstFaceCounter];
				String secondFace = faces[secondFaceCounter];
				
				// Iterating through the suits
				for (int suit1 = 0; suit1 < suits.length; suit1++) {
					for (int suit2 = suit1 + 1; suit2 < suits.length; suit2++) {
						for (int suit3 = suit2 + 1; suit3 < suits.length; suit3++) {
							for (int suit4 = 0; suit4 < suits.length; suit4++) {
								for (int suit5 = suit4 + 1; suit5 < suits.length; suit5++) {
									// Printing current combination
									System.out.println(firstFace + suits[suit1] + " " + firstFace + suits[suit2] + " " + firstFace + suits[suit3] + " " + secondFace + suits[suit4] + " " + secondFace + suits[suit5]);
									
									// Printing current combination with reversed faces
									System.out.println(secondFace + suits[suit1] + " " + secondFace + suits[suit2] + " " + secondFace + suits[suit3] + " " + firstFace + suits[suit4] + " " + firstFace + suits[suit5]);
									
									// Counting the number of full houses
									combinationsCount += 2;
								}
							}
						}
					}
				}
			}
		}
		
		// Printing the number of full houses
		System.out.print("\n" + combinationsCount + " full houses");
	}
}