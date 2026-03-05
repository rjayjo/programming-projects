<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Index</title>
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

          <div class="collapse navbar-collapse" id="navbarSupportedContent">
            <div class="d-flex ml-auto flex-column flex-lg-row align-items-center">
              <ul class="navbar-nav  ">
                <li class="nav-item active">
                  <a class="nav-link" href="#about">About Us <span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="#bestsellers"> Bestsellers</a>
                </li>
                <li class="nav-item">
                  <a class="nav-link" href="#partners"> Our Partners </a>
                </li>
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
                          <h1>Welcome to <br />Digi-Book</h1>
                          <p>
                            Digi-book provides a wide selection of reading materials that readers can choose from in order to satisfy their reading cravings at an affordable price.</p>
                          <div class="d-flex">
                            <a href="Registration.jsp" class="text-uppercase custom_orange-btn mr-3">
                              Sign Up
                            </a>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="col-md-6">
                      <div class="slider_img-box">
                        <div>
                          <img src="images/slider image.png" alt="" class="" />
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
  
  
    <section class="service_section layout_padding " id="about">
    <div class="container">
      <h1 class="custom_heading">About Us</h1>
      <p class="custom_heading-text">
        Wanna know more about our team? Well here ya go!
      </p>
      <div class=" layout_padding2">
        <div class="card-deck">
          <div class="card">
            <img class="card-img-top" src="images/Miguel.png" style = "width: 180px"  alt="Card image cap" />
            <div class="card-body">
              <h5 class="card-title">Miguel Rivadenera</h5>
              <p class="card-text">
               		Miguel is the lead project manager of the entire project manager He is responsible for overseeing the
               		progress of tasks and coordinates with clients in integrating their books into the site.
              </p>
            </div>
          </div>
          <div class="card">
            <img class="card-img-top" src="images/Russell.png" style = "width: 180px"  alt="Card image cap" />
            <div class="card-body">
              <h5 class="card-title">Russell Bernardo</h5>
              <p class="card-text">
                	Russell is one of our developers. As a programmer, he is fluent in creating applications using Java and
                	is responsible for ensuring the functionality of our project.
              </p>
            </div>
          </div>
          <div class="card">
            <img class="card-img-top" src="images/Gerard.png" style = "width: 180px"  alt="Card image cap" />
            <div class="card-body">
              <h5 class="card-title">Gerard Kutsukawa</h5>
              <p class="card-text">
                Gerard is responsible for testing the project and ensures quality control in the development process. As an initiator,
                he is reponsible for creating the layout of the web project...such as this one!
              </p>
            </div>
          </div>
           <div class="card">
            <img class="card-img-top" src="images/SidneyL.png" style = "width:180px" alt="Card image cap" />
            <div class="card-body">
              <h5 class="card-title">Sidney Lopez</h5>
              <p class="card-text">Sidney is a creative. He knows how to blend colors and buttons together. He believes in a minimalistic and easy-catching design when creating websites.</p>
            </div>
          </div>
        </div>
      </div>
    </div>
    
  </section>
  
      <section style="margin-bottom:50px">
       <div class="carousel-inner">
          <div class="carousel-item active">
            <div class="slider_item-box">
              <div class="slider_item-container">
                <div class="container">
                  <div class="row">
                    <div class="col-md-6">
                      <div class="slider_item-detail">
                        <div>
                          <h1 style="font-size: 50px;">Digi-Book</h1>
                          <p>Digi-book was founded on Oct 29, 2022, with the express purpose of promoting literary works within the streets of Metro Manila. As an organization, we strive to ensure that people are interested in reading once again. Our wide selection also provides opportunity to allow authors both local and foreign alike to find their works within our catalog. Lastly, our store provides both a physical and digital copy with each purchase.</p>

                        </div>
                      </div>
                    </div>
                    <div class="col-md-6">
                      <div class="slider_img-box">
                        <div>
                          <img src="images/about-book.png" alt="" class="" />
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
    
  <section class="fruit_section" id="bestsellers">
    <div class="container">
      <h1 class="custom_heading">Bestsellers</h1>
      <p class="custom_heading-text">
        Here are some of the best selling books that we have in our possession.
      </p>
      <div class="row layout_padding2">
        <div class="col-md-8">
          <div class="fruit_detail-box">
            <h3>
               The Chronicles Of Narnia
            </h3>
            <p class="mt-4 mb-5">
             The Chronicles of Narnia is a series of seven fantasy novels by British author C. S. Lewis. Illustrated by Pauline Baynes and originally published between 1950 and 1956.
              It narrates the adventures of various children who play central roles in the unfolding history of the Narnian world. Except in The Horse and His Boy, the protagonists are all children from the real world who are magically transported to Narnia, where they are sometimes called upon by the lion Aslan to protect Narnia from evil. 
            </p>
          </div>
        </div>
        <div class="col-md-4 d-flex justify-content-center align-items-center">
          <div class="fruit_img-box d-flex justify-content-center align-items-center">
            <img src="images/Narnia.png" alt="" class="" width="450px" />
          </div>
        </div>
      </div>
      <div class="row layout_padding2">
        <div class="col-md-8">
          <div class="fruit_detail-box">
            <h3>
              A Song of Ice and Fire
            </h3>
            <p class="mt-4 mb-5">
         		A Song of Ice and Fire is a series of epic fantasy novels by the American novelist and screenwriter George R. R. Martin.A Song of Ice and Fire takes place on the fictional continents Westeros and Essos. The point of view of each chapter in the story is a limited perspective of a range of characters growing from nine in the first novel, to 31 characters by the fifth novel. Three main stories interweave: a dynastic war among several families for control of Westeros, the rising threat of the supernatural Others in northernmost Westeros, and the ambition of the deposed king's exiled daughter to assume the Iron Throne.
            </p>
          </div>
        </div>
        <div class="col-md-4 d-flex justify-content-center align-items-center">
          <div class="fruit_img-box d-flex justify-content-center ">
            <img src="images/ASOIAF.png" alt="" class="" width="410px" />
          </div>
        </div>
      </div>
      <div class="row layout_padding2-top layout_padding-bottom">
        <div class="col-md-8">
          <div class="fruit_detail-box">
           		<h3>Harry Potter</h3>
	            <p class="mt-4 mb-5">
				Harry Potter is a series of seven fantasy novels written by British author J. K. Rowling. The novels chronicle the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are students at Hogwarts School of Witchcraft and Wizardry. The main story arc concerns Harry's struggle against Lord Voldemort, a dark wizard who intends to become immortal, overthrow the wizard governing body known as the Ministry of Magic and subjugate all wizards and Muggles (non-magical people).
	            </p>
            <div>

            </div>
          </div>
        </div>
        <div class="col-md-4 d-flex justify-content-center align-items-center">
          <div class="fruit_img-box d-flex justify-content-center align-items-center">
            <img src="images/Harry potter.png" alt="" class="" width="420px" />
          </div>
        </div>
      </div>
    </div>
  </section>
  
  
   <section class="service_section layout_padding " id="partners">
    <div class="container">
      <h1 class="custom_heading">Our Partners</h1>
      <p class="custom_heading-text mb-4">
        Here are some of Digi-book's most notable partners!
      </p>
       <div class="row layout_padding2-top layout_padding-bottom">
        <div class="col-md-8">
          <div class="fruit_detail-box">
           		<h3>Lampara Books</h3>
	            <p class="mt-4 mb-5">
				Lampara Books brings to children, parents and teachers the brightest stories from the current harvest of children literature in the Philippines, likewise from the literature of different countries from all over the world. Each story is carefully written or retold by budding and award-winning Filipino writers and illustrated by illustrators of childrens' books. Featured here are unique and exciting characters, places, themes and experiences that will kindle the imagination, emotion and mind of the young readers. Each book is written in two languages, Filipino and English to reach a greater number of readers here in the country and in other parts of the world.
	            </p>
            <div>

            </div>
          </div>
        </div>
        <div class="col-md-4 d-flex justify-content-center align-items-center">
          <div class="fruit_img-box d-flex justify-content-center align-items-center">
            <img src="images/Lampara.jpg" alt="" class="" width="320px" />
          </div>
        </div>
      </div> 
      
      
        <div class="row layout_padding2-top layout_padding-bottom">
        <div class="col-md-8">
          <div class="fruit_detail-box">
				<h3>International Publishers</h3>	            
				<p class="mt-4 mb-5">International Publishers was founded by Alexander L. Trachtenberg (1885-1966) in 1924. Trachtenberg, a personal acquaintance of V.I. Lenin – leader of the Bolshevik Revolution – was a Marxist writer, educator, and publisher, as well as a founding member of the Communist Party, USA. Under his stewardship International Publishers became a leading publisher of Marxist, Communist, labor, African American, and other literature.Like other Communists, during the 1950s McCarthy era Red Scare Trachtenberg was hounded, harassed, called before the House Un-American Activities Committee, and eventually jailed for advocating Marxism-Leninism.</p>
            <div>

            </div>
          </div>
        </div>
        <div class="col-md-4 d-flex justify-content-center align-items-center">
          <div class="fruit_img-box d-flex justify-content-center align-items-center">
            <img src="images/IPLogo.jpg" alt="" class="" width="320px" />
          </div>
        </div>
      </div>       
      
      
       <div class="row layout_padding2-top layout_padding-bottom">
        <div class="col-md-8">
          <div class="fruit_detail-box">
				<h3>Adarna Publishing House</h3>	            
				<p class="mt-4 mb-5">Adarna House is a conversation that began in 1980, when it was founded to respond to the need of Filipino children to develop their minds through enjoyable learning opportunities and memorable literary experiences. Today, this conversation includes a multitude of treasured partners who share our enthusiasm for children, our commitment to education, and our passion for reading. The best Filipino writers, illustrators, and researchers help us create products that feature Filipino values, culture, history, and experiences. Readability and systems experts were invaluable to the development of WiKAHON, the very first leveled tool for independent use to improve reading skills in Filipino. A new generation of readers, beyond the Philippines, have pushed us towards engaging with them on a different platform through the work of Adarna House Digital.</p>
            <div>

            </div>
          </div>
        </div>
        <div class="col-md-4 d-flex justify-content-center align-items-center">
          <div class="fruit_img-box d-flex justify-content-center align-items-center">
            <img src="images/AdarnaHouse.png" alt="" class="" width="320px" />
          </div>
        </div>
      </div> 

     </div>
  </section>
  
     <%@include file="Footer.jsp"  %>

  
  <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
  <script type="text/javascript" src="js/bootstrap.js"></script>
</body>
</html>