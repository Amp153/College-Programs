/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package chapter39;

import com.sun.xml.ws.developer.servlet.HttpSessionScope;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

//added to prevent visitor from counting every refresh (every client accessing it)
@HttpSessionScope
@WebService(serviceName = "VisitCounter")
public class VisitCounter {

    
    /**
     * This is a sample web service operation
     */
    /*@WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }
    */
    
    private int count;
    
    public VisitCounter(){
        count = 0;
    }
    
    @WebMethod(operationName = "getCount")
    public int getCount(){
        count++;
        return count;
    }
}
