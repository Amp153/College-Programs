package dictionary;

import java.util.HashMap;
import java.util.Map;

public class MapDictionary implements Dictionary{
	//private Map<String,DictionaryEntry> map;
	private Map<Integer,DictionaryEntry> map;
	
	//Using a hashmap instead of a linkedhashmap because I don't care about the order
	public MapDictionary(){
		map = new HashMap<>();
	}

	@Override
	public DictionaryEntry lookupWord(String word) {
		//return entries.get(word);
		DictionaryEntry entry = null;
		for(int i = 0; i < map.size(); i++){
			if(map.get(i).getWord().equals(word)){
				entry = map.get(i);
				break;
			}
		}
		return entry;
	}

	@Override
	public DictionaryEntry lookupWord(DictionaryEntry dictionaryEntry) {
		return lookupWord(dictionaryEntry.getWord());
	}

	//Assigning the key to the current size of the map (basically an array)
	@Override
	public void addWord(DictionaryEntry entry) {
		int i = map.size();
		map.put(i, entry);
		
	}

}
