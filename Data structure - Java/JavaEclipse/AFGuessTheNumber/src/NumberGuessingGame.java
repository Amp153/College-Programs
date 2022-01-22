import java.util.Scanner;

//Anthony Fuller
//Java review assignment
public class NumberGuessingGame {

	public static void main(String[] args) {
		//Ask the user
		System.out.println("Please enter a number greater than 10 and less than 20");
		int num = 0;	
		Scanner in = new Scanner(System.in);

		//User enters the number
		do {
			try {
				num = in.nextInt();
				while(num < 10 || num > 20){
					System.out.print("Invalid entry, try again: ");

					num = in.nextInt();
				}
				System.out.println("You entered " + num);
			} catch (Exception e) {
				System.out.print("Invalid entry, try again: ");
				in.next();
			}
		} while (num < 10 || num > 20);


		//Guess the number
		int guess = -1;
		do {
			while(guess == -1) {
				String answer = "";

				//Label is here to break out of a loop
				outerLoop: if(guess == -1){ 
					for(int loop = 10; loop <= 20; loop++) {
						System.out.print("Is your number " + loop +
								"?(Yes/No): ");
						answer = in.next();

						//Label is here to break out of a loop
						innerLoop: if(!answer.toLowerCase().startsWith("no")){
							while(!answer.toLowerCase().startsWith("yes")){
								System.out.print("Invalid entry, try again(yes/no) :");
								answer = in.next();
								if(answer.toLowerCase().startsWith("no"))
									break innerLoop;
							}
						}

						//Break out of loop for some reason?
						if(answer.toLowerCase().startsWith("yes")){
							guess = loop;
							break outerLoop;
						}

					}
				}

				//This is if the user said no to all of the guesses
				if(guess == -1)
					System.out.print("It has to be a number between 10 and 20, I'll guess again\n");
			}
			//If the user said incorrectly said yes to one of the guesses
			if(guess != num){
				System.out.print("That is not the number you said earlier, I'll guess again\n");
				guess = -1;
			}

		}while(guess != num);
		System.out.print("Your number was "+ num +" and my guess was "+ guess);

		//Closing the scanner input
		in.close();

	}

}
