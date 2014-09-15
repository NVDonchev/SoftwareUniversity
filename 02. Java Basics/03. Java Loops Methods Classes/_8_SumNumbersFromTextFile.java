import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

// Write a program to read a text file "Input.txt" holding a sequence
// of integer numbers, each at a separate line. Print the sum of the
// numbers at the console. Ensure you close correctly the file in case
// of exception or in case of normal execution. In case of exception
// (e.g. the file is missing), print "Error" as a result.

public class _8_SumNumbersFromTextFile {
	public static void main(String[] args) throws IOException {
		// Initializing
		int num = 0;
		BufferedReader reader = null;
		
		try {
			// Preparing the file reader
			reader = new BufferedReader(new FileReader("src/input.txt")); // May need to change file path
          
			// Reading the file line by line
            String line = reader.readLine();
            while(line != null) {
            	// Sum the numbers
                num += Integer.parseInt(line);
                
                // Read next line
                line = reader.readLine();
			}
		} catch (Exception ex) {
			// Printing error message
			System.out.println("Error");
			
			// Closing the reader
			reader.close();
		}
		
		// Printing the result
		System.out.println("The sum of the numbers in the file is: " + num);
	}
}