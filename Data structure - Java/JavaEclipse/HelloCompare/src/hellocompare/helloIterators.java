package hellocompare;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.Collections;
import java.util.Comparator;

public class helloIterators {
    public static void main(String args[]){
        ArrayList<String> nameList = new ArrayList<>();
        
        nameList.add("Jane");
        nameList.add("Susan");
        nameList.add("Austin");
        nameList.add("Bill");        
        
        //don't do this (depends too much on size to be accurate)
        for(int i=0;i<nameList.size();i++){
            System.out.println(nameList.get(i));
        }
        
        Collections.sort(nameList, new NameComparator());
        
        Iterator<String> stringIterator = nameList.iterator();
        while(stringIterator.hasNext()){
            String name = stringIterator.next();
            System.out.println(name);
        }
    }
}
class NameComparator implements Comparator<String>{

    @Override
    public int compare(String nameA, String nameB){
        return nameA.length() - nameB.length();
    }
}