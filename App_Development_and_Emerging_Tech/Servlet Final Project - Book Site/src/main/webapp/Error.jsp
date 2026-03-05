<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Error Page</title>
<link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.1.3/assets/owl.carousel.min.css" />
<link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
<link rel ="shortcut icon" href ="images/book-icon.png" type="image/icon">
<link href="https://fonts.googleapis.com/css?family=Poppins:400,700&display=swap" rel="stylesheet" />
<link href="css/style.css" rel="stylesheet" />
<link href="css/responsive.css" rel="stylesheet" />
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

          
        </nav>
      </div>
    </header>
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
                          <h1>Error <br />Page</h1>
                          <p>
                            Our apologies! There is an error within the system. Please click the button back to the index page of the site. Thank you!</p>
                          <div class="d-flex">
                            <a href="Index.jsp" class="text-uppercase custom_orange-btn mr-3 ">
                              Return
                            </a>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="col-md-6">
                      <div class="slider_img-box">
                        <div>
                          <img src="images/repair.gif" alt="" style="width:500px" class="" />
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
  </div>
      <section class="info_section layout_padding" style="background: black; color: white;">
    <div class="container">
      <div class="row">
        <div class="col-md-3">
          <h5>
            Mission
          </h5>
          <ul>
            <p style="text-align: justify; text-justify: inter-word;">From literary classics to works of fiction, Digi-Book strives to find the appropriate and affordable reading materials for book-readers alike. Interested in buying?</p>
          </ul>
        </div>
        <div class="col-md-3">
          <h5>
            Our Partners
          </h5>
          <ul>
           	<li>Lampara Books</li>
             <li>International Publishers</li>
           	 <li>Adarna Publishing House</li>
          </ul>
        </div>
        <div class="col-md-3">
          <div class="social_container">
            <h5>
              Follow Us
            </h5>
            <div class="social-box">
              <a href="">
                <img src="images/facebook.png" alt="">
              </a>
              <a href="">
                <img src="images/twitter.png" alt="">
              </a>
              <a href="">
                <img src="images/instagram.png" alt="">
              </a>
            </div>
          </div>
        </div>
        <div class="col-md-3">
          <div class="social_container">
            <h5>Contact Us</h5>
            <div class="social-box">
              <img src="images/telephone.png">
              <spam>+0123 456 7801</span>
            </div>
            <div class="social-box">
              <img src="images/email.png">
              <span>Digi-book@gmail.com</span>
            </div>
            <div class="social-box">
              <img src="images/tag.png">
              <span>Manila City</span>
            </div>
        </div>
      </div>
    </div>
  </section>
<%            session.invalidate();  
 %>
 
  <section class="container-fluid footer_section"  style="background: black; color: white;">
    <p style="color: white;">
      Copyright &copy; 2019 All Rights Reserved By
      <span style="color: white;">Digi-Book.com</span>
    </p>
  </section>
</body>
</html>