import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Comparator;

// Create a class Product to hold products, which have name
// (string) and price (decimal number). Read from a text file
// named "Input.txt" a list of products. Each product will be
// in format name + space + price. You should hold the products
// in objects of class Product. Sort the products by price and
// write them in format price + space + name in a file named
// "Output.txt". Ensure you close correctly all used resources.

public class _9_ListOfProducts {
	public static void main(String[] args) throws IOException {
		// Initializing
		BufferedReader reader = null;
		ArrayList<String> lines = new ArrayList<String>();

		try {
			// Preparing the file reader
			reader = new BufferedReader(new FileReader("src/inputProducts.txt")); // May need to change file path

			// Reading the file line by line
			String line = reader.readLine();
			while (line != null) {
				// Add line content to an array list
				lines.add(line);
				
				// Read next line
				line = reader.readLine();
			}
		} catch (Exception ex) {
			// Printing error message
			System.out.println("Error");

			// Closing the reader
			reader.close();
		}
		
		// Converting lines array list to array
		String[] linesAsArray = lines.toArray(new String[lines.size()]);
		
		// Initializing new array of products
		Product[] products = new Product[lines.size()];
		
		// Populating the array of products
		for (int line = 0; line < linesAsArray.length; line++) {
			products[line] = new Product(linesAsArray[line]);
		}
		
		// Sorting the array of products
		Arrays.sort(products, new CustomComparator());
		
		// Printing the result
		for (Product product : products) {
			System.out.printf("%.2f %s\n", product.price, product.name);
		}
	}
}

final class Product {
	// Fields
	public String name;
	public double price;

	// Constructor
	public Product(String line) {
		String[] lineTokens = line.split("\\s+");
		this.name = lineTokens[0];
		this.price = Double.parseDouble(lineTokens[1]);
	}
}

// Custom comparator
final class CustomComparator implements Comparator<Product> {
    @Override
    public int compare(Product o1, Product o2) {
        return Double.compare(o1.price, o2.price);
    }
}