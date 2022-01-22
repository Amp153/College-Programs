package dictionary;

import java.util.ArrayList;

public class ArrayDictionary implements Dictionary{
	private ArrayList<DictionaryEntry> arrayL;
	public ArrayDictionary(){
		arrayL = new ArrayList<>();
	}

	@Override
	public DictionaryEntry lookupWord(String word) {
		DictionaryEntry entry = null;
		for (int i = 0; i < arrayL.size(); i++){
			if(arrayL.get(i).getWord().equals(word)){
				entry = arrayL.get(i);
				break;
			}			
		}
		return entry;
	}

	@Override
	public DictionaryEntry lookupWord(DictionaryEntry dictionaryEntry) {
		return lookupWord(dictionaryEntry.getWord());
	}

	@Override
	public void addWord(DictionaryEntry entry) {
		arrayL.add(entry);
		
	}

}
