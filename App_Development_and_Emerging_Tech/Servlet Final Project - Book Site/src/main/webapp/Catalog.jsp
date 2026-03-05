<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1" errorPage = "Error.jsp" %>
<%@ page import ="java.util.ArrayList"%>
<%@ page import ="java.util.List"%> 
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Home</title>
<link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.1.3/assets/owl.carousel.min.css" />
<link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
 <link rel ="shortcut icon" href ="images/book-icon.png" type="image/icon">
<link href="https://fonts.googleapis.com/css?family=Poppins:400,700&display=swap" rel="stylesheet" />
<link href="css/style.css" rel="stylesheet" />
<link href="css/responsive.css" rel="stylesheet" />
<script src="js/showpassword.js"></script></head>
<body>
    <!-- header section strats -->
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
                  <a class="nav-link" href="List.jsp">
                  	List
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
							HttpSession retrieve= request.getSession();
							out.println("<label class='nav-link-name' name='uname' style='padding: 10px; color: #343434; text-align: center;'>"+retrieve.getAttribute("sessionscore")+"</label>");
							

						%>
                	</li>
                	
                	<li class="nav-item">
	                  <form action="Logout.jsp">
	                  	<input class="nav-link border border-light" name="logout" href="Orders.jsp" type="submit" value="Logout" />
	                  	<%
	                  		
	                  		 if(retrieve.getAttribute("sessionscore")==null)
	                  		 {
		                  		    response.sendRedirect("Login.jsp");
	                  		 }
	                  		 else
	                  		 {
	                  			 //request.getSession().invalidate();

	                  		 }
	                  	%>
	                  	
	                  	
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
      <h1 class="custom_heading">Our Products</h1>
      <p class="custom_heading-text mb-4">
        Our current list of products!
      </p>
      <div class="album py-5 bg-light">
        <div class="container">

          <div class="row">
            <div class="col-md-4">
              <div class="card mb-4 box-shadow">
                <img src="images/Narnia.png"  data-holder-rendered="true">
                <div class="card-body">
                <h5>The Chronicles of Narnia</h5>
                  <p class="card-text">The Chronicles of Narnia  narrates the adventures of various children who play central roles in the unfolding history of the Narnian world.</p>
                  <div class="d-flex justify-content-between align-items-center">
                    <div class="btn-group">
                      <form action="Catalog.jsp" method="get">
                      	  <input type ="hidden" name=new-item value="TCOF">
                      	  <input type ="hidden" name=new-price value="650">
                      	 <button type="submit" class="btn btn-success">Buy</button>
                      </form>
                    </div>
                    <label class="text-muted">PHP 650</label>
                  </div>
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="card mb-4 box-shadow">
                <img src="images/ASOIAF.png" data-holder-rendered="true">
                <div class="card-body">
                 <h5>A Song of Ice and Fire</h5>
                  <p class="card-text">From the mind of George R. R. Martin, A Song of Ice and Fire takes place on the fictional continents Westeros and Essos. </p>
                  <div class="d-flex justify-content-between align-items-center">
                    <div class="btn-group">
                       <form action="Catalog.jsp">
                      	  <input type ="hidden" name="new-item" value="ASOIAF">
                      	  <input type ="hidden" name="new-price" value="450">
                      	 <button type="submit" class="btn btn-success">Buy</button>
                      </form>
                    </div>
                    <label class="text-muted">PHP 450</label>
                  </div>
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="card mb-4 box-shadow">
                <img  src="images/Harry potter.png">
                <div class="card-body">
                  <h5>Harry Potter</h5>
                  <p class="card-text">Harry Potter chronicles of the titular characters, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts.</p>
                  <div class="d-flex justify-content-between align-items-center">
                    <div class="btn-group">
         				 <form action="Catalog.jsp" name="catalog">
                      	  <input type ="hidden" name="new-item" value="HP">
                      	  <input type ="hidden" name="new-price" value="550">
                      	 <button type="submit" class="btn btn-success">Buy</button>
                      </form>                    </div>
                    <label class="text-muted">PHP 550</label>
                  </div>
                </div>
              </div>
            </div>

            <div class="col-md-4">
              <div class="card mb-4 box-shadow">
                <img  src="images/lotr.jpg">
                <div class="card-body">
                  <h5>The Lord of the Rings</h5>
                  <p class="card-text">A young hobbit named Frodo Baggins, undertakes a quest to destroy the One Ring.</p>
                  <div class="d-flex justify-content-between align-items-center">
                    <div class="btn-group">
                       <form action="Catalog.jsp" name="catalog">
                      	  <input type ="hidden" name="new-item" value="LOTR">
                      	  <input type ="hidden" name="new-price" value="250">
                      	 <button type="submit" class="btn btn-success">Buy</button>
                      	</form>
                    </div>
                    <label class="text-muted">PHP 250</label>
                  </div>
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="card mb-4 box-shadow">
                <img  src="images/handmaidtail.png">
                <div class="card-body">
                   <h5>The Handmaid's Tale</h5>
                  <p class="card-text">In a world where women are treated as lower-class citizens, the fight for emancipation begins.</p>
                  <div class="d-flex justify-content-between align-items-center">
                    <div class="btn-group">
                     	 <form action="Catalog.jsp" name="catalog">
                      	  <input type ="hidden" name=new-item value="THT">
                      	  <input type ="hidden" name=new-price value="150">
                      	 <button type="submit" class="btn btn-success">Buy</button>
                      	</form>
                    </div>
                    <label class="text-muted">PHP 150</label>
                  </div>
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <div class="card mb-4 box-shadow">
                <img  src="images/itcover.png">
                <div class="card-body">
                  <h5>IT</h5>
                
                  <p class="card-text">In the town of Derry, Maine. A terrifying secret lurks behind the sewers.</p>
                  <div class="d-flex justify-content-between align-items-center">
                    <div class="btn-group">
                			<form action="Catalog.jsp" name="catalog">
                      	  <input type ="hidden" name="new-item" value="IT">
                      	  <input type ="hidden" name="new-price" value="200">
                      	 <button type="submit" class="btn btn-success">Buy</button>
                      	</form>
                    </div>
                    <label class="text-muted">PHP 200</label>
                  </div>
                </div>
              </div>
            </div>

     
          </div>
        </div>
      </div>

     </div>
     
     
  </section>


 <%
 // Checks for the value of name that it is null or not
  String name = request.getParameter("new-item");
		
  if (name != null) {
   String value = request.getParameter("new-price");
 
   Cookie newCookies = new Cookie(name, value);
  // add cookies to response object of jsp 
   response.addCookie(newCookies);
  // redirects control to same page for new request
   response.sendRedirect("List.jsp");
  }
  
  %>
	  
     <%@include file="Footer.jsp"  %>

</body>
</html>