import java.util.Scanner;

public class _03_PointsInsideFigure {
	public static void main(String[] args) {
		// Initializing structure border variables
		float upperStructUpWall = 6f;
		float upperStructRightWall = 22.5f;
		float upperStructDownWall = 8.5f;
		float upperStructLeftWall = 12.5f;
		
		float leftStructUpWall = 8.5f;
		float leftStructRightWall = 17.5f;
		float leftStructDownWall = 13.5f;
		float leftStructLeftWall = 12.5f;
		
		float rightStructUpWall = 8.5f;
		float rightStructRightWall = 22.5f;
		float rightStructDownWall = 13.5f;
		float rightStructLeftWall = 20f;
		
		// Getting user input
		System.out.print("Please enter the coords to check: ");
		Scanner input = new Scanner(System.in);
		float x = input.nextFloat();
		float y = input.nextFloat();
		
		// Initializing boolean variables
		boolean inUpperStruct = false;
		boolean inLeftStruct = false;
		boolean inRightStruct = false;
		
		// Checking point location on each structure
		if (x >= upperStructLeftWall && x <= upperStructRightWall && y >= upperStructUpWall && y <= upperStructDownWall) {
			inUpperStruct = true;
		}
		if (x >= leftStructLeftWall && x <= leftStructRightWall && y >= leftStructUpWall && y <= leftStructDownWall) {
			inLeftStruct = true;
		}
		if (x >= rightStructLeftWall && x <= rightStructRightWall && y >= rightStructUpWall && y <= rightStructDownWall) {
			inRightStruct = true;
		}
		
		// Print the result
		if (inUpperStruct || inLeftStruct || inRightStruct) {
			System.out.println("Inside");
		}
		else {
			System.out.println("Outside");
		}
	}
}