<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1" errorPage = "Error.jsp" %>
<%@ page import ="java.util.ArrayList"%>
<%@ page import ="java.util.List"%>

<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Login</title>
<link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.1.3/assets/owl.carousel.min.css" />
<link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
<link rel ="shortcut icon" href ="images/book-icon.png" type="image/icon">
<link href="https://fonts.googleapis.com/css?family=Poppins:400,700&display=swap" rel="stylesheet" />
<link href="css/style.css" rel="stylesheet" />
<link href="css/responsive.css" rel="stylesheet" />
<script src="js/showpassword.js"></script>

</head>
<body>
<div class="hero_area">
    <!-- header section strats -->
    <header class="header_section">
      <div class="container">
        <nav class="navbar navbar-expand-lg custom_nav-container pt-3">
          <a class="navbar-brand" href="Index.jsp">
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
              <ul class="navbar-nav  ">
                <li class="nav-item">
                  <a class="nav-link" href="Login.jsp">Login</a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="Registration.jsp">Registration</a>
                </li>
              </ul>
            </div>
          </div>
        </nav>
      </div>
    </header>
    <section>
    
     <div class="container rounded mt-5 w-25 shadow-lg" styles ="height:60vh;">
 		<div class="container my-4">
			   <form action="Login.jsp" method="post">
     			 <h1 class="custom_heading">Login</h1>
				  <div class="form-group">
					    <label for="email">Email address:</label>
					    <input type="email" class="form-control" placeholder="Enter email" id="email" name=name required style="height:50px;">
				  </div>
				  <div class="form-group">
					    <label for="pwd">Password:</label>
					    <input type="password" class="form-control" placeholder="Enter password" id="pwd" name=value required style="height:50px;">
				  </div>
				  <div class="form-group">
				  		<input type="checkbox" onclick="myFunction()"> Show Password:
				  		
				  </div>
				  <div class="d-flex justify-content-center my-4">
				     <button type="submit" class="btn btn-primary center btn-default w-100" style="height:50px;">Submit</button>
				  </div>
				  <div class="text-center pb-4">
				  	<label class="text-center">Don't have an account? <a href="Registration.jsp" class="text-primary text-center">Register Now!</a></label>
				  </div>
			</form>
     </div>
     </div>
  </section>
  </div>
  
    <%
 	Cookie[] cookies = request.getCookies();
	HttpSession retrieve=request.getSession();
 	Cookie cookie2;

 
 	
 		for(int x=0; x< cookies.length;x++)
 		{
 			cookie2= cookies[x];
 			if(cookie2.getValue().equals(request.getParameter("name"))  && cookie2.getName().equals(request.getParameter("value")))
 			{
 			    response.sendRedirect("Catalog.jsp");
 			    String uname = request.getParameter("name");
 				retrieve.getAttribute("sessionscore");
 				retrieve.setAttribute("sessionscore", uname);
 			    break;

 			}
 		}
 	
	

 %>
 

  <%@include file="Footer.jsp"  %>

  <script>
  function myFunction() {
	  var x = document.getElementById("pwd");
	  if (x.type === "password") {
	    x.type = "text";
	  } else {
	    x.type = "password";
	  }
	}
  </script>  
</body>
</html>