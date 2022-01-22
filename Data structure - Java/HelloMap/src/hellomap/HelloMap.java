package hellomap;
import java.util.*;
public class HelloMap {

    public static void main(String[] args) {
        //unordered map
        Map<String,String> hashMap = new HashMap<>();
        hashMap.put("entryOne", "value1");
        hashMap.put("entryTwo", "value2");

        for(String s : hashMap.values()){
            System.out.println(s);
        }
        
        //ordered
        Map<String,String> linkedMap = new LinkedHashMap<>();
        linkedMap.put("entryOne", "value1");
        linkedMap.put("entryTwo", "value2");
        for(String s : linkedMap.values()){
            System.out.println(s);
        }
    }
    
}
