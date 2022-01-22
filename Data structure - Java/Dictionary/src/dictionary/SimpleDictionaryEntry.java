/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dictionary;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Student-5
 */
public class SimpleDictionaryEntry implements DictionaryEntry{
	
	//ArrayList because it can't be a normal list
	List<String> wordList = new ArrayList<String>();
	List<String> defList = new ArrayList<String>();
	
    SimpleDictionaryEntry(String word, String definition){
    	this.setWord(word);
    	this.setDefinition(definition);
    }

    @Override
    public String getWord() {
    	return wordList.get(0);
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void setWord(String word) {	
		wordList.add(word);
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public String getDefinition() {
    	return defList.get(0);
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void setDefinition(String definition) {
    	defList.add(definition);
        //throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @SuppressWarnings("rawtypes")
	@Override
    public List getSynonyms() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public void addSynonym(String word, Dictionary dictionary) throws IllegalArgumentException {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}
/*

package dictionary;

import java.util.ArrayList;
import java.util.List;


public class SimpleDictionaryEntry implements DictionaryEntry{
    private String word;
    private String definition;
    private List<DictionaryEntry> synonyms;
    
    SimpleDictionaryEntry(String word, String definition){
        this.word = word;
        this.definition = definition;
        synonyms = new ArrayList<>();
    }

    @Override
    public String getWord() {
        return word;
    }

    @Override
    public void setWord(String word) {
        this.word = word;
    }

    @Override
    public String getDefinition() {
        return definition;
    }

    @Override
    public void setDefinition(String definition) {
        this.definition = definition;
    }

    @Override
    public List getSynonyms() {
        return synonyms;
    }

    @Override
    public void addSynonym(String word, Dictionary dictionary) throws IllegalArgumentException {
        synonyms.add(dictionary.lookupWord(word));
    }
    
}
*/