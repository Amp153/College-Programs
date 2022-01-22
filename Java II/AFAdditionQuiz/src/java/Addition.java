/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import java.io.Serializable;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.SessionScoped;
import javax.inject.Named;

/**
 *
 * @author Administrator
 */
@ManagedBean
@Named(value = "addition")
@SessionScoped
public class Addition implements Serializable{

    private int[] first = new int[10];
    private int[] second = new int[10];
    private String[] userAnswer = new String[10];
    private String[] eval = new String[10];
    private int correctCount = 0;
    private String results = "";
    /**
     * Creates a new instance of Addition
     */
    public Addition() {
        generateNumbers();
    }
    
    public void generateNumbers(){
    for (int x = 0; x < first.length; x++){
        first[x] = (int)(Math.random() * 51);
        second[x] = (int)(Math.random() * 51);
        userAnswer[x] = "";
    }
    results = "";
    
    }
    
    public String getQuestion(int q){
            return first[q] + " + " + second[q] + " = ";
        }
    
    public String[] getUserAnswer(){
        return userAnswer;
    }
    
    public String getResults(){
        return results;
    }
    
    public void getEval(){
    correctCount = 0;
    for (int x = 0; x < first.length; x++)
        if (first[x] + second[x] == Integer.parseInt(userAnswer[x])){
            correctCount++;
            userAnswer[x] += " Correct";
        }
        else
            userAnswer[x] += " Incorrect";
    results = "You got " + correctCount + " questions correct";
    }
    
}
