import java.util.Arrays;
import java.util.Scanner;

// Write a program to enter a number n and n integer numbers
// and sort and print them. Keep the numbers in array of integers: int[].

public class _01_SortArrayOfNumbers {
	public static void main(String[] args) {
		// Getting user input
		Scanner input = new Scanner(System.in);
		System.out.print("Please enter a number for the length of the array: ");
		int arrayLen = input.nextInt();
		int[] numbers = new int[arrayLen];
		System.out.print("Please enter numbers for the array: ");
		for (int num = 0; num < arrayLen; num++) {
			numbers[num] = input.nextInt();
		}
		
		// Sorting the array
		Arrays.sort(numbers);
		
		// Printing the result
		System.out.print("\nThe sorted numbers are: ");
		for (int num : numbers) {
			System.out.print(num + " ");
		}
	}
}