
public class Recursion {

	public static void main(String[] args) {
		System.out.println("first "+first(3));
		System.out.println("second "+second(3));
		System.out.println("third "+third(3));
		System.out.println("fourth "+fourth(3));
		System.out.println("fifth "+fifth(3));

	}

	public static double first(int i) {
		if(i==0)
			return 0;
		return i+2+first(i-1);
	}
	
	public static double second(int i) {
		if(i==0)
			return 0;
		return Math.pow(i,2)+1+second(i-1);
	}
	
	public static double third(int i) {
		if(i==0)
			return 0;
		return Math.pow(i,2)+4+third(i-1);
	}
	
	public static double fourth(int i) {
		if(i==0)
			return 0;
		return i+10+fourth(i-1);
	}
	
	public static double fifth(int i) {
		if(i==0)
			return 0;
		return Math.pow(i,2)+24+fifth(i-1);
	}
}
