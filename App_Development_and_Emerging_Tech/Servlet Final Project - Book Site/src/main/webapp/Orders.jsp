<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    <%@ page import ="java.util.ArrayList"%>
<%@ page import ="java.util.List"%> 
<%@ page import ="java.util.HashMap"%> 
<%@ page import ="java.util.Map"%> 
<%@ page import ="java.text.NumberFormat"%> 
<%@ page import ="java.util.Locale"%> 

<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Orders</title>
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
	      <h1 class="custom_heading">Your Orders</h1>
	      <p class="custom_heading-text mb-4">Thank you for shopping with us!</p>
		 <%
		 Cookie[] cookies = request.getCookies();
	     Locale locale = new Locale("en", "UK");      

	 	 List<String> qty = (List<String>) session.getAttribute("List");
	    		  NumberFormat formatter = NumberFormat.getCurrencyInstance(Locale.JAPAN);


		 	if(qty==null || qty.size()<6 )
			{
					qty = new ArrayList<String>();
					session.setAttribute("List", qty);
			}

		 int sum=0,count=0;
		 boolean check =false;
		 
			 for (int i = 0; i < cookies.length; i++) {
				  Cookie cookie = cookies[i];
				  if(cookie.getName().equals("THT")|| cookie.getName().equals("IT")||cookie.getName().equals("LOTR")||cookie.getName().equals("HP") ||cookie.getName().equals("TCOF")|| cookie.getName().equals("ASOIAF"))
		          {
		             check=true;
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
		 	 else if(qty!=null || check==true)
		 	 {
		 		 out.println("<div class='container rounded  shadow-lg'>");
		 		 out.println("<div class='container'>");
		 		 out.println("<table class='table'>");
		 		 out.println("<thead>");
		 		 out.println("<th scope='col'>Product Name</th>");
		 		 out.println("<th scope='col'>Quantity</th>");
		 		 out.println("<th scope='col'>Price</th>");
		 		 out.println("<tr>");
		 		 out.println("</tr>");
		 		 out.println("</thead>");
		 		 out.println("<tbody>");

		 		 if(request.getParameter("TCOF")!=null)
		 		 {
			 		 out.println("<tr>");
			 		 out.println("<td>"+request.getParameter("TCOF")+"</td>");
			 		 out.println("<td>"+request.getParameter("6")+"</td>");
			 		 out.println("<td>"+request.getParameter("650")+"</td>");
			 		 out.println("</tr>");
			 		 sum+= Integer.parseInt(request.getParameter("650"));

		 		 }
		 		 

		 		 if(request.getParameter("ASOIAF")!=null)
		 		 {
			 		 out.println("<tr>");
			 		 out.println("<td>"+request.getParameter("ASOIAF")+"</td>");
			 		 out.println("<td>"+request.getParameter("5")+"</td>");
			 		 out.println("<td>"+request.getParameter("450")+"</td>");
			 		 out.println("</tr>");
			 		 sum+= Integer.parseInt(request.getParameter("450"));


		 		 }
		 		 

		 		 if(request.getParameter("IT")!=null)
		 		 {
			 		 out.println("<tr>");
			 		 out.println("<td>"+request.getParameter("IT")+"</td>");
			 		 out.println("<td>"+request.getParameter("3")+"</td>");
			 		 out.println("<td>"+request.getParameter("200")+"</td>");
			 		 out.println("</tr>");
			 		 sum+= Integer.parseInt(request.getParameter("200"));


		 		 }
		 		 
		 		 if(request.getParameter("THT")!=null)
		 		 {
			 		 out.println("<tr>");
			 		 out.println("<td>The Handmaid's Tale</td>");
			 		 out.println("<td>"+request.getParameter("4")+"</td>");
			 		 out.println("<td>"+request.getParameter("150")+"</td>");
			 		 out.println("</tr>");
			 		 sum+= Integer.parseInt(request.getParameter("150"));


		 		 }
		 		 
		 		 if(request.getParameter("LOTR")!=null)
		 		 {
			 		 out.println("<tr>");
			 		 out.println("<td>"+request.getParameter("LOTR")+"</td>");
			 		 out.println("<td>"+request.getParameter("2")+"</td>");
			 		 out.println("<td>"+request.getParameter("250")+"</td>");
			 		 out.println("</tr>");
			 		 sum+= Integer.parseInt(request.getParameter("250"));

		 		 }
		 		 
		 		 if(request.getParameter("HP")!=null)
		 		 {
			 		 out.println("<tr>");
			 		 out.println("<td>"+request.getParameter("HP")+"</td>");
			 		 out.println("<td>"+request.getParameter("1")+"</td>");
			 		 out.println("<td>"+request.getParameter("550")+"</td>");
			 		 out.println("</tr>");
			 		 sum+= Integer.parseInt(request.getParameter("550"));


		 		 }
		 		 
		 		 
		 		 out.println("</tbody>");
		 		 out.println("</table>");
		 		 out.println("</div>");
		 		 out.println("</div>");

		 		out.println("<div class='container'>");
				   out.println(" <div class='row'>");
					    out.println(" <div class='col-lg-12 text-left'>");
				       	   out.println("<h5 class='custom_heading text-right p-3'> Estimated Total: <label class='text-right'>PHP "+sum+"</label></h5>");
						 	out.println("</div>");
					 out.println("</div>");
		 		 
		 	 }
		 %>
      </div>
      </div>
      </section>
    

	

 
  <%@include file="Footer.jsp"  %>
 
</body>
</html>