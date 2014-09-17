import java.util.ArrayList;
import java.util.Scanner;

// Write a program that reads two lists of letters l1 and l2 and combines them:
// appends all letters c from l2 to the end of l1, but only when c does not appear in l1.
// Print the obtained combined list. All lists are given as sequence of letters separated
// by a single space, each at a separate line. Use ArrayList<Character>
// of chars to keep the input and output lists.

public class _09_CombineListsOfLetters {
	public static void main(String[] args) {
		// Getting user input
		Scanner scan = new Scanner(System.in);
		System.out.println("Please enter the first list of chars: ");
		String[] stringList1 = scan.nextLine().split("\\s+");
		System.out.println("Please enter the second list of chars: ");
		String[] stringList2 = scan.nextLine().split("\\s+");
		
		// Initializing and populating array lists of chars
		ArrayList<Character> charList1 = new ArrayList<Character>();
		ArrayList<Character> charList2 = new ArrayList<Character>();
		for (int index = 0; index < stringList1.length; index++) {
			charList1.add(stringList1[index].charAt(0));
		}
		for (int index = 0; index < stringList2.length; index++) {
			charList2.add(stringList2[index].charAt(0));
		}
		
		// Checking char by char if it's present in both lists
		boolean isPresent = false;
		ArrayList<Character> finalList = new ArrayList<Character>(charList1);
		for (int index2 = 0; index2 < charList2.size(); index2++) {
			for (int index1 = 0; index1 < charList1.size(); index1++) {
				if (charList1.get(index1).equals(charList2.get(index2))) {
					isPresent = true;
				}
			}
			
			// If the char is unique - add it to the end of the first list
			if (!isPresent) {
				finalList.add(charList2.get(index2));
			}
			
			// Reseting boolean value
			isPresent = false;
		}
		
		// Printing the result
		for (Character character : finalList) {
			System.out.print(character + " ");
		}
	}
}