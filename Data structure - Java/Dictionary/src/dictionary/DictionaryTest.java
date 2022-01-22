/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dictionary;

/**
 *
 * @author Student-5
 */
public class DictionaryTest {
    public static void main(String[] args){
        DictionaryEntry apple = new SimpleDictionaryEntry("Apple","A fruit");
        DictionaryEntry car = new SimpleDictionaryEntry("Car", "A vehicle");
        //more entries here
        
        ArrayDictionary arrayDictionary = new ArrayDictionary();
        arrayDictionary.addWord(apple);
        arrayDictionary.addWord(car);
        
        MapDictionary mapDictionary = new MapDictionary();
        mapDictionary.addWord(apple);
        mapDictionary.addWord(car);
        
        StackDictionary stackDictionary = new StackDictionary();
        stackDictionary.addWord(apple);
        stackDictionary.addWord(car);
        
        //Timing Algorithm from https://stackoverflow.com/questions/180158/how-do-i-time-a-methods-execution-in-java
        long startTime = System.nanoTime();
        System.out.println(stackDictionary.lookupWord("Apple").getDefinition());
        System.out.println(stackDictionary.lookupWord("Car").getDefinition());
        long endTime = System.nanoTime();
        long duration = (endTime - startTime);
        System.out.println("It took " + duration + " nano seconds for the stack dictionary");
        
        startTime = System.nanoTime();
        System.out.println(arrayDictionary.lookupWord("Apple").getDefinition());
        System.out.println(arrayDictionary.lookupWord("Car").getDefinition());
        endTime = System.nanoTime();
        duration = (endTime - startTime);
        System.out.println("It took " + duration + " nano seconds for the array dictionary");

        startTime = System.nanoTime();
        System.out.println(mapDictionary.lookupWord("Apple").getDefinition());
        System.out.println(mapDictionary.lookupWord("Car").getDefinition());
        endTime = System.nanoTime();
        duration = (endTime - startTime);
        System.out.println("It took " + duration + " nano seconds for the map dictionary");

        /* 
        
        public static void timeDicitonary(String dictionaryName,Dictionary dictionary){
            DictionaryEntry apple = new SimpleDictionaryEntry("Apple","A fruit");
        DictionaryEntry car = new SimpleDictionaryEntry("Car", "A vehicle");
         startTime = System.nanoTime();
        System.out.println(dictionary.lookupWord("Apple").getDefinition());
        System.out.println(dictionary.lookupWord("Car").getDefinition());
        endTime = System.nanoTime();
        duration = (endTime - startTime);
        System.out.println("It took " + duration + " nano seconds for the map dictionary");}*/
    }
    
}
