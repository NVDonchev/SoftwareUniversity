import java.util.Arrays;
import java.util.Scanner;

// Write a program that finds the smallest of three numbers.

public class _04_SmallestOfThree {
	public static void main(String[] args) {
		// Getting user input
		System.out.println("Please enter three numbers: ");
		Scanner input = new Scanner(System.in);
		
		float[] numbers = new float[3];
		for (int num = 0; num < numbers.length; num++) {
			numbers[num] = input.nextFloat();
		}
		
		// Finding smallest number
		float smallest = 0;
		if (numbers[0] <= numbers[1] && numbers[0] <= numbers[2]) {
			smallest = numbers[0];
		}
		else if (numbers[1] <= numbers[0] && numbers[1] <= numbers[2]) {
			smallest = numbers[1];
		}
		else if (numbers[2] <= numbers[0] && numbers[2] <= numbers[1]) {
			smallest = numbers[2];
		}
		
		// Printing the result without decimal zeroes if it is a whole number
		if (smallest % 1 == 0) {
			System.out.printf("The smallest number is: %d", (int)smallest);
		}
		else {
			System.out.printf("The smallest number is: %s", Float.toString(smallest));
		}
	}
}