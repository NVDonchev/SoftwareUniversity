import java.util.Scanner;

// Write a method to convert from degrees to radians.
// Write a method to convert from radians to degrees.
// You are given a number n and n queries for conversion.
// Each conversion query will consist of a number + space + measure.
// Measures are "deg" and "rad". Convert all radians to degrees
// and all degrees to radians. Print the results as n lines,
// each holding a number + space + measure. Format all numbers
// with 6 digit after the decimal point.

public class _5_AngleUnitConverter {
	public static void main(String[] args) {
		// Getting user input
		System.out.print("Please enter a number for the lines count: ");
		Scanner input = new Scanner(System.in);
		int linesCount = input.nextInt();
		System.out.println("\nPlease enter [number] [measure]: ");
		for (int line = 0; line < linesCount; line++) {
			double number = input.nextDouble();
			String measure = input.next();
			
			// Printing the result
			if (measure.equals("deg")) {
				System.out.printf("%f %s", degreeToRadian(number), "rad\n");
			}
			else {
				System.out.printf("%f %s", radiantTodegree(number), "deg\n");
			}
		}
	}
	
	// Converts from degrees to radians
	public static double degreeToRadian(double degree) {
		return degree * (Math.PI / 180);
	}

	// Converts from radians to degrees
	public static double radiantTodegree(double radiant) {
		return radiant * (180 / Math.PI);
	}
}