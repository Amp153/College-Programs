//Anthony Fuller
//Creating a circle class
//The circle class

public class Circle {

	//variables
	private double circleRadius;
	final double PI = 3.14159;
	
	public Circle(double radius) {
		setRadius(radius);
	}
	private void setRadius(double newRadius) {
		circleRadius = newRadius;
	}
	public double getRadius() {
		return circleRadius;
	}
	public double getArea() {
		double area = PI * getRadius() * getRadius();
		return area;
	}
	public double getDiameter() {
		double diameter = circleRadius * 2;
		return diameter;
	}
	public double getCircumference() {
		double circumference = 2 * PI * circleRadius;
		return circumference;
	}
}