<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Grade Computation</title>
<link rel ="shortcut icon" href ="url(https://cdn-icons-png.flaticon.com/512/2374/2374322.png)" type="image/icon">
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>
<body>
		   <!-- Navbar-->
			<nav class="navbar navbar-expand-lg navbar-dark bg-dark">
                <div class="container px-5">
                    <a class="navbar-brand" href="midterm-grade-input.jsp">Grade Computation</a>
                    
                    <button class="navbar-toggler collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation"><span class="navbar-toggler-icon"></span></button>
                    <div class="navbar-collapse collapse" id="navbarSupportedContent" style="">
                        <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
                        </ul>
                    </div>
                </div>
            </nav>
            
             <!-- Header-->
            <header class="py-5 bg-image-full" style="background-image: url('https://assets-global.website-files.com/600faaecb03ce57f6fa98050/60466d901bfdda8f31bbcdc1_DDM-Jan-21-Marketing%20Trends-p-1600.jpeg');">
                <div class="container px-5">
                    <div class="row gx-5 align-items-center justify-content-center">
                        <div class="col-lg-8 col-xl-7 col-xxl-6">
                            <div class="my-5 text-center text-xl-start">
                                 <h1 class="display-5 fw-bolder text-dark mb-2 text-center">Grade Computer</h1>
                                <p class="lead fw-bolder text-dark mb-4 text-center">With Grade Computer, compute your student's grades with accuracy and ease! Simply provide the details and our software will do the rest!</p>
                                <div class="d-grid gap-3 d-sm-flex justify-content-sm-center justify-content-xl-start">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </header>
            
            <section class="py-5">
	             <div class="container px-5">
					   <form action="midterm-grade-output.jsp" method="post">
					   	  <h5 class="display-5 fw-bolder text-dark mb-2 text-center">Grade Computer</h5> 
						  <div class="form-group py-2">
						    <label class="py-2 fw-bolder">Class Participation</label>
						    <input type="number" name="classP" onchange="handleChange(this);" class="form-control form-control-lg  h-25 d-inline-block" min="0" value="0" maxlength="3" max="100" required style="height:100px;">
						  </div>
						  <div class="form-group py-2">
						    <label class="py-2 fw-bolder">Exercises</label>
						    <input type="number" name="exercises" onchange="handleChange(this);" class="form-control form-control-lg  h-25 d-inline-block" min="0" value="0" max="100" required style="height:100px;">
						  </div>
						  <div class="form-group py-2">
						    <label class="py-2 fw-bolder">Quizzes</label>
						    <input type="number" name="quizzes" onchange="handleChange(this);" class="form-control form-control-lg  h-25 d-inline-block" min="0" value="0" max="100" required style="height:100px;">
						  </div>
						    <div class="form-group py-2">
						    <label class="py-2 fw-bolder">Special Project</label>
						    <input type="number" name="special" onchange="handleChange(this);" class="form-control form-control-lg  h-25 d-inline-block" min="0" value="0" max="100" required style="height:100px;">
						  </div>
						  <div class="form-group py-2">
						    <label class="py-2 fw-bolder">Mid-term Examination</label>
						    <input type="number" name="mtexam" onchange="handleChange(this);" class="form-control form-control-lg  h-25 d-inline-block" min="0" value="0" max="100" required style="height:100px;">
						  </div>
						  <div class="py-2 align-items-center justify-content-center">
						    <button type="submit" class="btn btn-primary px-2 w-25 d-inline-block" style="height:55px;">Submit</button>
						 	<button type="reset" class="btn btn-danger  px-2 w-25 d-inline-block" style="height:55px;">Reset</button>
						  </div>
					</form>
	             </div>
            </section>
            
            
           <footer class="bg-dark py-4 mt-auto">
            <div class="container px-5">
                <div class="row align-items-center justify-content-between flex-column flex-sm-row">
                    <div class="col-auto"><div class="small m-0 text-white">Copyright &copy; Your Website 2022</div></div>
                    <div class="col-auto">
                        <a class="link-light small" href="#!">Privacy</a>
                        <span class="text-white mx-1">&middot;</span>
                        <a class="link-light small" href="#!">Terms</a>
                        <span class="text-white mx-1">&middot;</span>
                        <a class="link-light small" href="#!">Contact</a>
                    </div>
                </div>
            </div>
        </footer>
        
        <script>
		  function handleChange(input) {
			let number = parseFloat(input.value);
		    if (input.value < 0 || isNan(number)) input.value = 0;
		    if (input.value > 100 || isNan(number)) input.value = 100;
		  }
		</script>
        
</body>
</html>