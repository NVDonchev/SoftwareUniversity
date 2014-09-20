import java.util.ArrayList;
import java.util.Scanner;

public class _2_AddingAngles {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
		scan.nextLine();
		
		int[] inputAngles = new int[n];
		for (int i = 0; i < inputAngles.length; i++) {
			inputAngles[i] = scan.nextInt();
		}
		
		ArrayList<String> validSeqences = new ArrayList<String>();
		int currentSum = 0;
		
		for (int i = 0; i < inputAngles.length; i++) {
			for (int j = i + 1; j < inputAngles.length; j++) {
				for (int k = j + 1; k < inputAngles.length; k++) {
					currentSum = inputAngles[i] + inputAngles[j] + inputAngles[k];
					if (currentSum % 360 == 0) {
						validSeqences.add(inputAngles[i] + " + " + inputAngles[j] + " + " + inputAngles[k] + " = " + currentSum + " degrees");
					}
					currentSum = 0;
				}
			}
		}
		
		if (validSeqences.size() > 0) {
			for (String seq : validSeqences) {
				System.out.println(seq);
			}
		}
		else {
			System.out.println("No");
		}
	}
}