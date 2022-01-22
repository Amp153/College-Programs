/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package chapter39;

import javax.faces.bean.ManagedBean;
import javax.faces.bean.RequestScoped;
import javax.inject.Named;
import chapter39.VisitCounter_Service;
import chapter39.VisitCounter;

/**
 *
 * @author Administrator
 */
@ManagedBean
@Named(value = "consumer")
@RequestScoped
public class Consumer {

    private VisitCounter_Service vs = new VisitCounter_Service();
    private VisitCounter proxy = vs.getVisitCounterPort();
    
    
    private int count;
    public Consumer() {
    }
    
    public int getCount(){
        
        count = proxy.getCount();
        return count;
    }
    
    public void setCount(){        
    }
    
}
