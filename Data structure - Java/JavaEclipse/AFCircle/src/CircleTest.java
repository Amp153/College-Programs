//Anthony Fuller
//Creating and demonstrating a circle class
//Class that tests the Circle class

import java.util.Scanner;

public class CircleTest {

	public static void main(String[] args) {
		//Try block is to prevent program from crashing
		try {
		System.out.print("What is the radius of the circle? ");
		Scanner in = new Scanner(System.in);
		Circle circle = new Circle((in.nextDouble()));

		System.out.print("The circles area is "+ circle.getArea()+
				"\nThe circles diameter is "+ circle.getDiameter()+
				"\nThe circles circumference is " + circle.getCircumference());
	
		//Closing the scanner input
		in.close();
		
		/*Using a general exception because otherwise there would
		be several exceptions*/
		} catch(Exception e) {
			System.out.print("An error has occured");
		}
	}

}
