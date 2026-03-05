<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
 pageEncoding="ISO-8859-1" errorPage = "Error.jsp"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" 
"http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Registration</title>
<link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.1.3/assets/owl.carousel.min.css" />
<link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
 <link rel ="shortcut icon" href ="images/book-icon.png" type="image/icon">
<link href="https://fonts.googleapis.com/css?family=Poppins:400,700&display=swap" rel="stylesheet" />
<link href="css/style.css" rel="stylesheet" />
<link href="css/responsive.css" rel="stylesheet" />
<link href="mystyle.css" rel="stylesheet" type="text/css">
</head>
<body>
  <div class="hero_area">
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
	    
	    <div class="container rounded mt-5 w-25 shadow-lg" styles ="height:60vh;">
	    	 <div class="container my-4">
	    	 	    <form method="post" action="Registration.jsp">
	    	 	    	  <h1 class="custom_heading">Registration</h1>
	    	 	    	  <div class="form-group">
	    	 	    	 	 <label for="email">Email address:</label>
	    	 	    	     <input name=name size=20  type="email" class="form-control" placeholder="Enter email" style="height:50px;"/>
	    	 	    	  </div>
	    	 	    	  <div class="form-group">
	    	 	    	     <label for="email">Password:</label>
	    	 	    	  	 <input name=value size=20 type="password" class="form-control" placeholder="Enter password" id="pwd" style="height:50px;">
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
	    
 

 <%
 // Checks for the value of name that it is null or not
  String name = request.getParameter("name");
		
  if (name != null && name.length() > 0) {
   String value = request.getParameter("value");
 
   Cookie retrieveCookies = new Cookie(value, name);
  // add cookies to response object of jsp 
   response.addCookie(retrieveCookies);
  // redirects control to same page for new request
   response.sendRedirect("Registration.jsp");
  }
  
  %>

 
  </div>
 
 
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
