import java.util.ArrayList;
import java.util.Scanner;
import java.util.TreeMap;

public class _4_ActivityTracker {
	public static void main(String[] args) {
		TreeMap<Integer, TreeMap<String, ArrayList<Integer>>> months = new TreeMap<>();
		
		Scanner scan = new Scanner(System.in);
		scan.nextLine();
		
		while (true) {
			String line = scan.nextLine();
			if (line.length() < 1) {
				break;
			}
			
			String[] inputData = parseInput(line);
			
			
			int month = Integer.parseInt(inputData[0]);
			String name = inputData[1];
			int distance = Integer.parseInt(inputData[2]);
			
			if (!months.containsKey(month)) {
				months.put(month, new TreeMap<>());
			}
			if (!months.get(month).containsKey(name)) {
				months.get(month).put(name, new ArrayList<Integer>());
			}
			
			months.get(month).get(name).add(distance);
						
		}
		
		// Print the output
		for (Integer month : months.keySet()) {
			System.out.print(month + ": "); // Loop by key and print it
		

			boolean firstTime = true;
			for (String name : months.get(month).keySet()) {
				
				int sum = 0;
				
				if (!firstTime) {
					System.out.print(", ");
				}
				firstTime = false;
				
				// Loop through the values of the inner map and calculate the average
				TreeMap<String, ArrayList<Integer>> nameAndDistance = months.get(month);
				
				for (int dist : nameAndDistance.get(name)) {
					sum += dist;
				}
				
				System.out.print(name);
				System.out.printf("(%d)", sum);
			}
			
			System.out.println();
		}
	}
	
	public static String[] parseInput(String input) {
		String[] tokens = input.split("\\s+");
		String[] dateTokens = tokens[0].split("/");
		
		if (dateTokens[1].charAt(0) == '0') {
			tokens[0] = dateTokens[1].substring(1);
		}
		else {
			tokens[0] = dateTokens[1];
		}
		
		return tokens;
	}
}