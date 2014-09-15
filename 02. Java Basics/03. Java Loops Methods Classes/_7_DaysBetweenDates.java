import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Scanner;
import java.util.concurrent.TimeUnit;

// Write a program to calculate the difference between
// two dates in number of days. The dates are entered
// at two consecutive lines in format day-month-year.
// Days are in range [1…31]. Months are in range [1…12].
// Years are in range [1900…2100]. 

public class _7_DaysBetweenDates {
	public static void main(String[] args) {
		// Setting the date format
		String dateFormat = "dd-MM-yyyy";
		SimpleDateFormat myFormat = new SimpleDateFormat("dd-MM-yyyy");
		
		// Getting user input
		Scanner input = new Scanner(System.in);
		System.out.print("Please enter the start date [" + dateFormat + "]: ");
		String startDate = input.next();
		System.out.print("Please enter the end date [" + dateFormat + "]: ");
		String endDate = input.next();
		
		// Calculating days count between the given dates
		try {
			Date date1 = myFormat.parse(startDate);
			Date date2 = myFormat.parse(endDate);
			long diff = date2.getTime() - date1.getTime();
			
			// Printing the result
			System.out.println("Days: " + TimeUnit.DAYS.convert(diff, TimeUnit.MILLISECONDS));
		} catch (ParseException e) {
			e.printStackTrace();
		}
	}
}