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
public interface Dictionary {
    public DictionaryEntry lookupWord(String word);
    public DictionaryEntry lookupWord(DictionaryEntry word);
    public void addWord(DictionaryEntry dictionaryEntry);
}
