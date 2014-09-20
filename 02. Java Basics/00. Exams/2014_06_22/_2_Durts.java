import java.util.Scanner;

public class _2_Durts {
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		int centerX = scan.nextInt();
		int centerY = scan.nextInt();
		int radius = scan.nextInt();
		int dartsCount = scan.nextInt();
		int[][] dartsCoords = new int[dartsCount][2];
		for (int i = 0; i < dartsCount; i++) {
			dartsCoords[i][0] = scan.nextInt();
			dartsCoords[i][1] = scan.nextInt();
		}
		
		boolean isInHorizontalRectangle = false;
		boolean isInVerticalRectangle = false;
		
		int horRectLeftWallX = centerX - radius;
		int horRectBottomWallY = centerY - radius + 1;
		
		int horRectRightWallX = centerX + radius;
		int horRectTopWallY = centerY + radius - 1;

		int verRectLeftWallX = centerX - radius + 1;
		int verRectBottomWallY = centerY - radius;
		
		int verRectRightWallX = centerX + radius - 1;
		int verRectTopWallY = centerY + radius;
		
		for (int dart = 0; dart < dartsCoords.length; dart++) {
			int currentDartX = dartsCoords[dart][0];
			int currentDartY = dartsCoords[dart][1];
			
			if (currentDartX >= horRectLeftWallX && currentDartY >= horRectBottomWallY && 
				currentDartX <= horRectRightWallX && currentDartY <= horRectTopWallY) {
				
				isInHorizontalRectangle = true;
			}
			if (currentDartX >= verRectLeftWallX && currentDartY >= verRectBottomWallY && 
				currentDartX <= verRectRightWallX && currentDartY <= verRectTopWallY) {
				
				isInVerticalRectangle = true;
			}
			
			if (isInHorizontalRectangle || isInVerticalRectangle) {
				System.out.println("yes");
			}
			else {
				System.out.println("no");
			}
			
			isInHorizontalRectangle = false;
			isInVerticalRectangle = false;
		}
	}
}