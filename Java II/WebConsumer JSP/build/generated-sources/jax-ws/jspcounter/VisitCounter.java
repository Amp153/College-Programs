
package jspcounter;

import javax.jws.WebMethod;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.Action;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.10-b140803.1500
 * Generated source version: 2.2
 * 
 */
@WebService(name = "VisitCounter", targetNamespace = "http://chapter39/")
@XmlSeeAlso({
    ObjectFactory.class
})
public interface VisitCounter {


    /**
     * 
     * @return
     *     returns int
     */
    @WebMethod
    @WebResult(targetNamespace = "")
    @RequestWrapper(localName = "getCount", targetNamespace = "http://chapter39/", className = "jspcounter.GetCount")
    @ResponseWrapper(localName = "getCountResponse", targetNamespace = "http://chapter39/", className = "jspcounter.GetCountResponse")
    @Action(input = "http://chapter39/VisitCounter/getCountRequest", output = "http://chapter39/VisitCounter/getCountResponse")
    public int getCount();

}
