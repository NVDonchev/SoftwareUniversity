import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _3_BiggestThreePrimeNumbers {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		String line = scan.nextLine();
		
		// Preparing a regular expression word matcher
		Pattern numberMatcher = Pattern.compile("\\-?\\d+");
		Matcher matcher = numberMatcher.matcher(line);
		ArrayList<Integer> numbers = new ArrayList<Integer>();

		// Finding the matches and adding them to a array list
		while (matcher.find()) {
			numbers.add(Integer.parseInt(matcher.group(0)));
		}
		
		int bestSum = 0;
		int currentSum = 0;
		
		for (int i = 0; i < numbers.size(); i++) {
			for (int j = 0; j < numbers.size(); j++) {
				for (int k = 0; k < numbers.size(); k++) {
					if (numbers.get(i) != numbers.get(j) && numbers.get(j) != numbers.get(k) && numbers.get(i) != numbers.get(k)) {
						if (isPrime(numbers.get(i)) && isPrime(numbers.get(j)) && isPrime(numbers.get(k))) {
							currentSum = numbers.get(i) + numbers.get(j) + numbers.get(k);
							if (bestSum < currentSum) {
								bestSum = currentSum;
							}
						}
					}
				}
			}
		}
		
		if (bestSum > 0) {
			System.out.println(bestSum);
		}
		else {
			System.out.println("No");
		}
	}
	
	public static boolean isPrime(int n) {
		if (n < 1) {
			return false;
		}
		
	    int i;
	    for (i = 2; i < n; i++) {
	        if (n % i == 0) {
	            return false;
	        }
	    }
	    return true;
	}
}