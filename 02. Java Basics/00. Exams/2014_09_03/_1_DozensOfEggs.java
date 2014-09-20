import java.util.Scanner;

public class _1_DozensOfEggs {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		int totalEggs = 0;
		
		for (int weekday = 1; weekday <= 7; weekday++) {
			int dayEggs = scan.nextInt();
			String measure = scan.nextLine().trim();
			
			if (measure.equals("dozens")) {
				totalEggs += dayEggs * 12;
			}
			else {
				totalEggs += dayEggs;
			}
		}

		int dozens = totalEggs / 12;
		int eggs = totalEggs % 12;
		
		System.out.println(dozens + " dozens + " + eggs + " eggs");
	}
}