<%-- 
    comment
--%>
<%@ page import="jspcounter.VisitCounter_Service;" %>
<%@ page import="jspcounter.VisitCounter;" %>
<jsp:useBean id="webs" scope="session"
             class="jspcounter.VisitCounter_Service">
    
</jsp:useBean>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <% VisitCounter proxy = webs.getVisitCounterPort(); %>
        You invoked the method <%= proxy.getCount() %> times
    </body>
</html>
