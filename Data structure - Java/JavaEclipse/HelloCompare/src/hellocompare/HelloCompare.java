package hellocompare;

import java.util.Comparator;
//import java.lang.Comparable; java.lang auto imports if you need it

public class HelloCompare {

    public static void main(String[] args) {
        FastFoodRestaurant tacobell = new FastFoodRestaurant("TacoBell");
        FastFoodRestaurant other = new FastFoodRestaurant("else");
        System.out.println(tacobell.compareTo(other));
    }

}

class FastFoodRestaurant implements Comparable<FastFoodRestaurant> {

    private String name;

    public FastFoodRestaurant(String name) {
        this.name = name;
    }

    @Override
    public int compareTo(FastFoodRestaurant otherFastFoodRestaurant) {
        if (this.getName().equals("TacoBell") && this.getName().equals(otherFastFoodRestaurant)) {
            return 0;
        } else if (this.getName().equals("TacoBell") && !otherFastFoodRestaurant.getName().equals("tacobell")) {
            return 9000;
        } else if (!this.getName().equals("TacoBell")) {
            return -6;
        } else {
            return -5000;
        }
    }

    public String getName() {
        return name;
    }
}

class FastFoodCritic implements Comparator<FastFoodRestaurant> {

    @Override
    public int compare(FastFoodRestaurant restaurantA, FastFoodRestaurant restaurantB) {
        if (restaurantA.getName().equals("TacoBell") && restaurantB.getName().equals("TacoBell")) {
            return 0;
        } else if (restaurantA.getName().equals("TacoBell") && !restaurantB.getName().equals("tacobell")) {
            return 9000;
        } else if (restaurantA.getName().equals("TacoBell")) {
            return -6;
        } else {
            return -5000;
        }
    }
}
