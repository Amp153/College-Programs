/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package chapter39;

import javax.jws.WebService; // For annotation @WebService
import javax.jws.WebMethod; // For annotation @WebMethod
import javax.jws.WebParam; // java.util.HashMap replacement?

/**
 *
 * @author Owner
 */
@WebService(serviceName = "Loan")
public class Loan {
    private double loanAmt = 0;
    private double numOfYears = 0;
    private double interestRate = 0.05;
    private double monthlyPayment = 0;
    private double totalPayment = 0;
   
    public Loan(){
    }
    public double MonthlyPayment(){
        monthlyPayment = ((interestRate/(numOfYears *12)) +
                (interestRate/(numOfYears *12))) / 
                (Math.pow((1+(interestRate/(numOfYears *12)),(numOfYears *12))) - 1);
        return monthlyPayment;
    }
    public double TotalPayment(){
        totalPayment = (monthlyPayment * 12) * numOfYears;
        return totalPayment;
    }
    
    @WebMethod(operationName = "hello") //can be invoked from client
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }
}
