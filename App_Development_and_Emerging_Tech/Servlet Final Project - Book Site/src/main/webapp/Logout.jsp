<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1" errorPage = "Error.jsp"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Logout</title>
<link rel ="shortcut icon" href ="images/book-icon.png" type="image/icon">

</head>
<body>
  <div class="hero_area">
   <%@include file="Header.jsp"  %>
   
	   <section class=" slider_section position-relative">
	    	 <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
	        <div class="carousel-inner">
	          <div class="carousel-item active">
	            <div class="slider_item-box">
	              <div class="slider_item-container">
	                <div class="container">
	                  <div class="row">
	                    <div class="col-md-6">
	                      <div class="slider_item-detail">
	                        <div>
	                          <h1>Account Successfully <br />Logged Out!</h1>
	                          <p>
	                            We hope you enjoy your shopping experience. Thank you!</p>
	                          <div class="d-flex">
	                            <a href="Login.jsp" class="text-uppercase custom_orange-btn mr-3 ">
	                              Login
	                            </a>
	                          </div>
	                        </div>
	                      </div>
	                    </div>
	                    <div class="col-md-6">
	                      <div class="slider_img-box">
	                        <div>
	                          <img src="images/bye.gif" alt="" style="width:500px;" class="mb-2" />
	                        </div>
	                      </div>
	                    </div>
	                  </div>
	                </div>
	              </div>
	            </div>
	          </div>
	        </div>
	      </div>
	    </section>
	    <%@include file="Footer.jsp"  %>
	     
	</div>
<%    
	session.invalidate(); 
	Cookie cookie = null;
	Cookie[] cookies = null;
	cookies = request.getCookies();
	
	

    if( cookies != null ) {
       for (int i = 0; i < cookies.length; i++) 
       {
          cookie = cookies[i];
          if(cookie.getName().equals("THT")|| cookie.getName().equals("IT")||cookie.getName().equals("LOTR")||cookie.getName().equals("HP") ||cookie.getName().equals("TCOF")|| cookie.getName().equals("ASOIAF"))
          {
             cookie.setMaxAge(0);
             response.addCookie(cookie);
          }
     	}
    }
 %>
 

 
</body>
</html>