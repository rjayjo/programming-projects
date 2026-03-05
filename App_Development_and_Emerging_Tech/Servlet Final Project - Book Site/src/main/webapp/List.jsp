<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1" errorPage = "Error.jsp" %>
<%@ page import ="java.util.ArrayList"%>
<%@ page import ="java.util.List"%> 
<%@ page import ="java.util.HashMap"%> 
<%@ page import ="java.util.Map"%> 

<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>List</title>
<link rel ="shortcut icon" href ="images/book-icon.png" type="image/icon">

</head>
<body>
   <header class="header_section">
      <div class="container">
        <nav class="navbar navbar-expand-lg custom_nav-container pt-3">
          <a class="navbar-brand">
            <img src="images/nav-icon.png" alt="" />
            <span class="Digi-Book-Logo">
              Digi-Book
            </span>
          </a>
          <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent"
            aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
          </button>
          
          
             <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <div class="d-flex ml-auto flex-column flex-lg-row align-items-center">
              <ul class="navbar-nav">
                <li class="nav-item">
                  <a class="nav-link" href="Catalog.jsp">
                  	Home
                  </a>
                </li>
              </ul>
            </div>
          </div>
          
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <div class="d-flex ml-auto flex-column flex-lg-row align-items-center">
              <ul class="navbar-nav">
                	<li class="nav-item">
                		<img src="images/profile-user.png" alt="" class="mx-1" width="35px" />
						<% 
							HttpSession retrieve = request.getSession();                		
							String sessionName = (String)retrieve.getAttribute("sessionscore");
							out.println("<label class='nav-link-name' style='padding: 10px; color: #343434; text-align: center;'>"+	session.getAttribute("sessionscore")+"</label>");
							if(retrieve.getAttribute("sessionscore")==null)
	                  		 {
		                  		    response.sendRedirect("Login.jsp");
	                  		 }
						%>
                	</li>
                	<li class="nav-item">
	                  <form action="Logout.jsp">
	                  	<input class="nav-link border border-light" name="logout" href="Orders.jsp" type="submit" value="Logout" />
	                 
	                  </form>
	                </li>
              </ul>
            </div>
          </div>
        </nav>
      </div>
    </header>
    
    <section class="service_section layout_padding " id="partners">
    <div class="container">
 		<div class="container my-4">
      <h1 class="custom_heading">Your List</h1>
      <p class="custom_heading-text mb-4">
        Here are the amount of items, you currently have!
      </p>

	  


 <%
 	 int bookIndex=0;
	 Cookie[] cookies = request.getCookies();
	 String[] values= {"The Chronicles of Narnia", "A Song of Ice and Fire", "Harry Potter","The Lord of the Rings", "The Handmaid Tale","IT"};
 	 String[] indexes= {"1","2","3","4","5","6"};
 	 List<Integer> qty = (List<Integer>) session.getAttribute("List");
	 	if(qty==null || qty.size()<6 )
		{
				qty = new ArrayList<Integer>();
				session.setAttribute("List", qty);
				qty.add(1);
				qty.add(1);
				qty.add(1);
				qty.add(1);
				qty.add(1);
				qty.add(1);
		}

	 int sum=0,count=0;
	 boolean check =false;
	 String id= request.getParameter("delete-id");
	 
	 for (int i = 0; i < cookies.length; i++) {
		  Cookie cookie = cookies[i];
		  if(cookie.getName().equals("THT")|| cookie.getName().equals("IT")||cookie.getName().equals("LOTR")||cookie.getName().equals("HP") ||cookie.getName().equals("TCOF")|| cookie.getName().equals("ASOIAF"))
          {
             check=true;
          }
		
	 }
	 

	 if(id!=null)
	 {
		 for (int i = 0; i < cookies.length; i++) {
			  Cookie cookie = cookies[i];
			  if(cookie.getName().equals(id))
	          {
                  cookie.setMaxAge(0);
                  response.addCookie(cookie);
                  response.setIntHeader("Refresh", 1);

	          }
		 }
	 }
 	 
	 
	 
	 
 	 if(check==false)
 	 {
 		out.println("<div  class='mx-auto d-block'>");
			out.println("<img src='images/Empty.gif'  class='mx-auto d-block' style='width:400px;'>");
			out.println("<h4 class='custom_heading'>Your cart is empty!</h4>");
			out.println("<p class='custom_heading-text mb-2'>Let's fix that!</p>");
		out.println("<div>");

 	 }
 	 else
 	 {
 		 for (int i = 0; i < cookies.length; i++) {
 		  Cookie cookie = cookies[i];
 		 	 String cookieName = cookie.getName();
 		 	 String cookieValue = cookie.getValue();

 		 	 	if(cookieName.equals("HP") )
 	 		 	{
 		 	 
 		 	 		if(request.getParameter("HPQty")!=null)
 		 	 		{
 	 		 	 		qty.set(0, Integer.parseInt(request.getParameter("HPQty")));

 		 	 		}
 		 	 		
 		 	 	    out.println("<div class='container mb-2'>");
	 					 out.println("<div class='modal-dialog'>");
	 					 out.println("<div class='modal-content'>");
	 					 out.println("<div class='modal-header'>");
	 					 out.println(" <b class='modal-title'>Harry Potter</b>");
	 	  			     out.println("</div>");
	 				     out.println("<div class='modal-body'>");
	 		  			 out.println(" <p>Price: PHP "+Integer.parseInt(cookieValue)*qty.get(0)+"</p>");
	 		  			 out.println(" <div class='row'>");
	 		  			 out.println(" <div class='col'>");
		  			     out.println(" <label for='modal-title' class='modal-title'>Qty: <label>");
		  			     out.println("<form action='List.jsp'>");
		  			     out.println(" <input type='number' name='HPQty' class='form-control mx-1 border border-dark' min='1' onchange='this.form.submit()' style='width:70px;' value='"+qty.get(0)+"'>");
		  			     out.println("</form>");
		 			     out.println("</div>");
	 		  			 out.println(" <div class='col'>");
	 		  			 out.println(" <div class='modal-footer'>");
	 		  			 out.println("<div class='d-grid gap-2 d-md-block'>");
 	 		  		  	 out.println("<form action='List.jsp'>");
 		  			     out.println(" <input type='hidden'  value='HP' name='delete-id'>");
 		  			     out.println(" <input type='submit'  class='btn btn-danger' value='Delete'>");
 		  			     out.println("</form>");  	 			  			
 		  			     out.println("</div>");
	 			  		 out.println("</div>");
	 			  		 out.println("</div>");
	 		  			 out.println("</div>");
	 	  				 out.println("</div>");
	 	  				 out.println("</div>");
	 	  				out.println("</div>");
	 					out.println("</div>");
	 					sum+= Integer.parseInt(cookies[i].getValue()) * qty.get(0);
 	 					
 	 		 	}
 	 		 	
 	 		 	if(cookieName.equals("LOTR"))
 	 		 	{
 	 		 		if(request.getParameter("LOTRQty")!=null)
 		 	 		{
 	 		 	 		qty.set(1, Integer.parseInt(request.getParameter("LOTRQty")));
 		 	 		}
 		 	 		
 		 	 	    	out.println("<div class='container mb-2'>");
	 					 out.println("<div class='modal-dialog'>");
	 					 out.println("<div class='modal-content'>");
	 					 out.println("<div class='modal-header'>");
	 					 out.println(" <b class='modal-title'>The Lord of The Rings</b>");
	 	  			     out.println("</div>");
	 				     out.println("<div class='modal-body'>");
	 		  			 out.println(" <p>Price: PHP "+Integer.parseInt(cookieValue)*qty.get(1)+"</p>");
	 		  			 out.println(" <div class='row'>");
	 		  			 out.println(" <div class='col'>");
		  			     out.println(" <label for='modal-title' class='modal-title'>Qty: <label>");
		  			     out.println("<form action='List.jsp'>");
		  			     out.println(" <input type='number' name='LOTRQty' class='form-control mx-1 border border-dark' min='1' onchange='this.form.submit()' style='width:70px;' value='"+qty.get(1)+"'>");
		  			     out.println("</form>");
		 			     out.println("</div>");
	 		  			 out.println(" <div class='col'>");
	 		  			 out.println(" <div class='modal-footer'>");
	 		  			 out.println("<div class='d-grid gap-2 d-md-block'>");
 	 		  		  	 out.println("<form action='List.jsp'>");
 		  			     out.println(" <input type='hidden'  value='LOTR' name='delete-id'>");
 		  			     out.println(" <input type='submit'  class='btn btn-danger' value='Delete'>");
 		  			     out.println("</form>");  	 			  			
 		  			     out.println("</div>");
	 			  		 out.println("</div>");
	 			  		 out.println("</div>");
	 		  			 out.println("</div>");
	 	  				 out.println("</div>");
	 	  				 out.println("</div>");
	 	  				out.println("</div>");
	 					out.println("</div>");
	 					sum+= Integer.parseInt(cookies[i].getValue()) * qty.get(1);
 	 					
 	 		 	}
 	 		 	
 	 		 	if(cookieName.equals("IT"))
 	 		 	{
 	 		 		if(request.getParameter("ITQty")!=null)
 		 	 		{
 	 		 	 		qty.set(2, Integer.parseInt(request.getParameter("ITQty")));

 		 	 		}
 		 	 		
 		 	 	    	out.println("<div class='container mb-2'>");
	 					 out.println("<div class='modal-dialog'>");
	 					 out.println("<div class='modal-content'>");
	 					 out.println("<div class='modal-header'>");
	 					 out.println(" <b class='modal-title'>IT</b>");
	 	  			     out.println("</div>");
	 				     out.println("<div class='modal-body'>");
	 		  			 out.println(" <p>Price: PHP "+Integer.parseInt(cookieValue)*qty.get(2)+"</p>");
	 		  			 out.println(" <div class='row'>");
	 		  			 out.println(" <div class='col'>");
		  			     out.println(" <label for='modal-title' class='modal-title'>Qty: <label>");
		  			     out.println("<form action='List.jsp'>");
		  			     out.println(" <input type='number' name='ITQty' class='form-control mx-1 border border-dark' min='1' onchange='this.form.submit()' style='width:70px;' value='"+qty.get(2)+"'>");
		  			     out.println("</form>");
		 			     out.println("</div>");
	 		  			 out.println(" <div class='col'>");
	 		  			 out.println(" <div class='modal-footer'>");
	 		  			 out.println("<div class='d-grid gap-2 d-md-block'>");
 	 		  		  	 out.println("<form action='List.jsp'>");
 		  			     out.println(" <input type='hidden'  value='IT' name='delete-id'>");
 		  			     out.println(" <input type='submit'  class='btn btn-danger' value='Delete'>");
 		  			     out.println("</form>");  	 			  			
 		  			     out.println("</div>");
	 			  		 out.println("</div>");
	 			  		 out.println("</div>");
	 		  			 out.println("</div>");
	 	  				 out.println("</div>");
	 	  				 out.println("</div>");
	 	  				out.println("</div>");
	 					out.println("</div>");
	 					sum+= Integer.parseInt(cookies[i].getValue()) * qty.get(2);
 	 					
 	 		 	}
 	 		 	
 	 		 	if(cookieName.equals("THT"))
 	 		 	{
 	 		 		if(request.getParameter("THTQty")!=null)
 		 	 		{
 	 		 	 		qty.set(3, Integer.parseInt(request.getParameter("THTQty")));

 		 	 		}
 		 	 		
 		 	 	    	out.println("<div class='container mb-2'>");
	 					 out.println("<div class='modal-dialog'>");
	 					 out.println("<div class='modal-content'>");
	 					 out.println("<div class='modal-header'>");
	 					 out.println(" <b class='modal-title'>The Handmaid's Tale</b>");
	 	  			     out.println("</div>");
	 				     out.println("<div class='modal-body'>");
	 		  			 out.println(" <p>Price: PHP "+Integer.parseInt(cookieValue)*qty.get(3)+"</p>");
	 		  			 out.println(" <div class='row'>");
	 		  			 out.println(" <div class='col'>");
		  			     out.println(" <label for='modal-title' class='modal-title'>Qty: <label>");
		  			     out.println("<form action='List.jsp'>");
		  			     out.println(" <input type='number' name='THTQty' class='form-control mx-1 border border-dark' min='1' onchange='this.form.submit()' style='width:70px;' value='"+qty.get(3)+"'>");
		  			     out.println("</form>");
		 			     out.println("</div>");
	 		  			 out.println(" <div class='col'>");
	 		  			 out.println(" <div class='modal-footer'>");
	 		  			 out.println("<div class='d-grid gap-2 d-md-block'>");
 	 		  		  	 out.println("<form action='List.jsp'>");
 		  			     out.println(" <input type='hidden'  value='THT' name='delete-id'>");
 		  			     out.println(" <input type='submit'  class='btn btn-danger' value='Delete'>");
 		  			     out.println("</form>");  	 			  			
 		  			     out.println("</div>");
	 			  		 out.println("</div>");
	 			  		 out.println("</div>");
	 		  			 out.println("</div>");
	 	  				 out.println("</div>");
	 	  				 out.println("</div>");
	 	  				out.println("</div>");
	 					out.println("</div>");
	 					sum+= Integer.parseInt(cookies[i].getValue()) * qty.get(3);
 	 					
 	 		 	}
 	 		 	
 	 		 	if(cookieName.equals("ASOIAF"))
 	 		 	{
 	 		 		if(request.getParameter("ASOIAFQty")!=null)
 		 	 		{
 	 		 	 		qty.set(4, Integer.parseInt(request.getParameter("ASOIAFQty")));

 		 	 		}
 		 	 		
 		 	 	    	out.println("<div class='container mb-2'>");
	 					 out.println("<div class='modal-dialog'>");
	 					 out.println("<div class='modal-content'>");
	 					 out.println("<div class='modal-header'>");
	 					 out.println(" <b class='modal-title'>A Song of Ice And Fire</b>");
	 	  			     out.println("</div>");
	 				     out.println("<div class='modal-body'>");
	 		  			 out.println(" <p>Price: PHP "+Integer.parseInt(cookieValue)*qty.get(4)+"</p>");
	 		  			 out.println(" <div class='row'>");
	 		  			 out.println(" <div class='col'>");
		  			     out.println(" <label for='modal-title' class='modal-title'>Qty: <label>");
		  			     out.println("<form action='List.jsp'>");
		  			     out.println(" <input type='number' name='ASOIAFQty' class='form-control mx-1 border border-dark' min='1' onchange='this.form.submit()' style='width:70px;' value='"+qty.get(4)+"'>");
		  			     out.println("</form>");
		 			     out.println("</div>");
	 		  			 out.println(" <div class='col'>");
	 		  			 out.println(" <div class='modal-footer'>");
	 		  			 out.println("<div class='d-grid gap-2 d-md-block'>");
 	 		  		  	 out.println("<form action='List.jsp'>");
 		  			     out.println(" <input type='hidden'  value='ASOIAF' name='delete-id'>");
 		  			     out.println(" <input type='submit'  class='btn btn-danger' value='Delete'>");
 		  			     out.println("</form>");  	 			  			
 		  			     out.println("</div>");
	 			  		 out.println("</div>");
	 			  		 out.println("</div>");
	 		  			 out.println("</div>");
	 	  				 out.println("</div>");
	 	  				 out.println("</div>");
	 	  				out.println("</div>");
	 					out.println("</div>");
	 					sum+= Integer.parseInt(cookies[i].getValue()) * qty.get(4);
 	 					
 	 		 	}
 	 		 	
 	 		 	if(cookieName.equals("TCOF"))
 	 		 	{
 	 		 		if(request.getParameter("TCOFQty")!=null)
 		 	 		{
 	 		 	 		qty.set(5, Integer.parseInt(request.getParameter("TCOFQty")));

 		 	 		}
 		 	 		
 		 	 	    	out.println("<div class='container mb-2'>");
	 					 out.println("<div class='modal-dialog'>");
	 					 out.println("<div class='modal-content'>");
	 					 out.println("<div class='modal-header'>");
	 					 out.println(" <b class='modal-title'>The Chronicles of Narnia</b>");
	 	  			     out.println("</div>");
	 				     out.println("<div class='modal-body'>");
	 		  			 out.println(" <p>Price: PHP "+Integer.parseInt(cookieValue)*qty.get(5)+"</p>");
	 		  			 out.println(" <div class='row'>");
	 		  			 out.println(" <div class='col'>");
		  			     out.println(" <label for='modal-title' class='modal-title'>Qty: <label>");
		  			     out.println("<form action='List.jsp'>");
		  			     out.println(" <input type='number' name='TCOFQty' class='form-control mx-1 border border-dark' min='1' onchange='this.form.submit()' style='width:70px;' min='1' value='"+qty.get(5)+"'>");
		  			     out.println("</form>");
		 			     out.println("</div>");
	 		  			 out.println(" <div class='col'>");
	 		  			 out.println(" <div class='modal-footer'>");
	 		  			 out.println("<div class='d-grid gap-2 d-md-block'>");
 	 		  		  	 out.println("<form action='List.jsp'>");
 		  			     out.println(" <input type='hidden'  value='TCOF' name='delete-id'>");
 		  			     out.println(" <input type='submit'  class='btn btn-danger' value='Delete'>");
 		  			     out.println("</form>");  	 			  			
 		  			     out.println("</div>");
	 			  		 out.println("</div>");
	 			  		 out.println("</div>");
	 		  			 out.println("</div>");
	 	  				 out.println("</div>");
	 	  				 out.println("</div>");
	 	  				out.println("</div>");
	 					out.println("</div>");
	 					sum+= Integer.parseInt(cookies[i].getValue()) * qty.get(5);
 	 					
 	 		 	}

 		 	
 		
 		
 		 

 		}
 		 
 		 
 		out.println("<div class='container'>");
		   out.println(" <div class='row'>");
			    out.println(" <div class='col-lg-12 text-left'>");
		       	   out.println("<h5 class='custom_heading text-right p-3'> Estimated Total: <label class='text-right'>PHP "+sum+"</label></h5>");
				 	out.println("</div>");
			 out.println("</div>");
			 
			  out.println(" <div class='row'>");
			  	  out.println(" <div class='col-lg-12 float-left'>");
			 		out.println("<form action='Orders.jsp'>");
					 for (int i = 0; i < cookies.length; i++) {
				 		  	Cookie cookie = cookies[i];
				 		 	 String cookieName = cookie.getName();
				 		 	 String cookieValue = cookie.getValue();
				 		 	  if(cookie.getName().equals("THT")|| cookie.getName().equals("IT")||cookie.getName().equals("LOTR")||cookie.getName().equals("HP") ||cookie.getName().equals("TCOF")|| cookie.getName().equals("ASOIAF"))
				 	          {
				 		 		if(cookie.getName().equals("HP")){count = 0;bookIndex=2;}
				 		 		if(cookie.getName().equals("LOTR")){count = 1; bookIndex=3;}
				 		 		if(cookie.getName().equals("IT")){count = 2;bookIndex=5;}
				 		 		if(cookie.getName().equals("THT")){count = 3;bookIndex=4;}
				 		 		if(cookie.getName().equals("ASOIAF")){count = 4;bookIndex=1;}
				 		 		if(cookie.getName().equals("TCOF")){count = 5; bookIndex=0;}

				 		 	 	out.println("<input type='hidden' name='"+cookieName+"' value='"+values[bookIndex]+"'>");
				 		 	 	out.println("<input type='hidden' name='"+cookieValue+"' value='"+Integer.parseInt(cookieValue)*qty.get(count)+"'>");
				 		 	 	out.println("<input type='hidden' name='"+indexes[count]+"' value='"+qty.get(count)+"'>");
				 	          }
					 };
					out.println("<button class='btn btn-success' style='margin-left: 960px'>Checkout</button>");
			 		out.println("</form>");
			 		out.println("</div>");
				 out.println("</div>");
       		out.println("</div>");

 	 }

	 
 %>


</div>
</div>   
  </section>
  
  
 <%@include file="Footer.jsp"  %>
 

	  
<script>
form.addEventListener('submit', (e:Event)=>{
    e.preventDefault();
});

</script>
</body>
</html>