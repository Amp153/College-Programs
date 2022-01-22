/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dictionary;

import java.util.Stack;

/**
 *
 * @author Student-5
 */
public class StackDictionary implements Dictionary{
    private Stack<DictionaryEntry> stack;
    public StackDictionary(){
        stack = new Stack<>();
    }
    
    @Override
    public void addWord(DictionaryEntry entry) {
        stack.push(entry);
    }

    @Override
    public DictionaryEntry lookupWord(String word) {
        Stack<DictionaryEntry> tempStack = new Stack<>();
        DictionaryEntry entry = null;
        while(!stack.isEmpty()){
            if(stack.peek().getWord().equals(word)){
                entry = stack.peek();
                break;
            }
            tempStack.push(stack.pop());
        }
        while(!tempStack.empty()){
            stack.push(tempStack.pop());
        }
        return entry;
    }

    @Override
    public DictionaryEntry lookupWord(DictionaryEntry dictionaryEntry) {
        return lookupWord(dictionaryEntry.getWord());
    }

    
    
}
