package dictionary;

public interface DictionaryEntry {
    public String getWord();
    public void setWord(String word);
    public String getDefinition();
    public void setDefinition(String definition);
    @SuppressWarnings("rawtypes")
	public java.util.List getSynonyms();
    public void addSynonym(String word, Dictionary dictionary) throws IllegalArgumentException;
}

