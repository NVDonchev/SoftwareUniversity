import java.util.Arrays;
import java.util.Scanner;

public class _08_SortArrayOfStrings {
	public static void main(String[] args) {
		// Initializing a Scanner
		Scanner in = new Scanner(System.in);
		
		// Initializing the array of towns
		System.out.println("How many towns:");
		int size = in.nextInt();
		String[] towns = new String[size];
		
		// Getting the town names from the user
		for (int index = 0; index < towns.length; index++) {
			System.out.println("Enter a town:");
			towns[index] = in.next();
		}
		
		// Sorting the array
		Arrays.sort(towns);
		
		// Printing the sorted town names on the console
		System.out.println("The sorted towns are:");
		for (int index = 0; index < towns.length; index++) {
			System.out.println(towns[index]);
		}
		
		// Closing the Scanner
		in.close();
	}
}