<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Grade Output</title>
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
                                <p class="lead fw-bolder text-dark mb-4 text-center">With Grade Computer, compute your student's grades with accuracy and ease! Simply provide the details and our software will do the rest!</p>                                <div class="d-grid gap-3 d-sm-flex justify-content-sm-center justify-content-xl-start">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </header>
            
             <section class="py-5">
	             <div class="container px-5">
		             <h2 class=" display-6 text-dark fw-bolder mb-2 text-center">Results</h2>
		             	<div class="row py-5">
						  <div class="col-sm">
						  	<div class="card border border-dark rounded" style="width: 23rem;">
							  <div class="card-body">
							    <h5 class="card-title text-center">Class Participation</h5>
							    <% out.println("<h2 class='card-text text-center'>"+request.getParameter("classP")+"</p>"); %>
							  </div>
							</div>
				          </div>
						  <div class="col-sm">
						  	<div class="col-sm">
						  	<div class="card border border-dark rounded" style="width: 23rem;">
							  <div class="card-body">
							    <h5 class="card-title text-center">Exercises</h5>
							    <% out.println("<h2 class='card-text text-center'>"+request.getParameter("exercises")+"</p>"); %>
							  </div>
							</div>
				          </div>
						  </div>
						  <div class="col-sm">
						  	<div class="col-sm">
						  	<div class="card border border-dark rounded" style="width: 23rem;">
							  <div class="card-body">
							    <h5 class="card-title text-center">Quizzes</h5>
							    <% out.println("<h2 class='card-text text-center'>"+request.getParameter("quizzes")+"</p>"); %>
							  </div>
							</div>
				          </div>
						</div>
	            	</div>
	            	</div>
	                   	<div class="row py-1">
	                   	      <div class="col"></div>
						  <div class="col">
						  	<div class="card border border-dark rounded" style="width: 23rem;">
							  <div class="card-body">
							    <h5 class="card-title text-center">Special Project</h5>
							    <% out.println("<h2 class='card-text text-center'>"+request.getParameter("special")+"</p>"); %>
							  </div>
							</div>
				          </div>
						  <div class="col">
						  	<div class="card border border-dark rounded" style="width: 23rem;">
							  <div class="card-body">
							    <h5 class="card-title text-center">Midterm Examination</h5>
							    <% out.println("<h2 class='card-text text-center'>"+request.getParameter("mtexam")+"</p>"); %>
							  </div>
							</div>
						  </div>
						    <div class="col"></div>
	             </div>
            </section>
            
            
             <section class="py-5">
	             <div class="container px-5">
					  <table class="table table-bordered">
					  <thead>
					    <tr>
					      <th scope="col" class="text-center" style="background-color:#121212;color:white;">Midterm Grades</th>
					      <th scope="col" class="text-center" style="background-color:#121212;color:white;">Equivalent</th>
					      <th scope="col" class="text-center" style="background-color:#121212;color:white;">Grades</th>
					      <th scope="col" class="text-center" style="background-color:#121212; color:white;">Computation</th>
					    </tr>
					  </thead>
					  <tbody>
					    <tr>
					      <th scope="row" class="text-center">Class Participation</th>
					      <td class="text-center">10%</td>
					      <td class="text-center"><% out.println(request.getParameter("classP")); %></td>
					      <td class="text-center">
					      	<% String classPComputation = request.getParameter("classP");
					      		double loop[]= new double[5];
					      		out.println(String.format("%.2f",Double.parseDouble(classPComputation)*0.10));
					      		loop[0] =Double.parseDouble(classPComputation)*0.10;
					      	; %>
					      </td>
					    </tr>
					    <tr>
					      <th scope="row" class="text-center">Exercises</th>
					      <td class="text-center">20%</td>
					      <td class="text-center"><% out.println(request.getParameter("exercises")); %></td>
					      <td class="text-center">
					           	<% String exercises = request.getParameter("exercises");
					      		out.println(String.format("%.2f",Double.parseDouble(exercises)*0.20));
					      		loop[1] =Double.parseDouble(exercises)*0.20;

					      	 %>
					      </td>
					    </tr>
					    <tr>
					      <th scope="row" class="text-center">Quizzes</th>
					       <td class="text-center">25%</td>
					      <td class="text-center"><% out.println(request.getParameter("quizzes")); %></td>
					      <td class="text-center">
					       	<% String quizzes = request.getParameter("quizzes");
					      		out.println(String.format("%.2f",Double.parseDouble(quizzes)*0.25));
					      		loop[2] =Double.parseDouble(quizzes)*0.25;
					      	 %>
					      </td>
					    </tr>
					    <tr>
					      <th scope="row" class="text-center">Special Project</th>
					      <td class="text-center"> 20% </td>
					      <td class="text-center"><% out.println(request.getParameter("special")); %></td>
					      <td class="text-center">
					      	  	<% String special = request.getParameter("special");
					      		out.println(String.format("%.2f",Double.parseDouble(special)*0.20));
					      		loop[3] = Double.parseDouble(special)*0.20;
					      	 %>
					      </td>
					    </tr>
					     <tr>
					      <th scope="row" class="text-center">Midterm Examination</th>
					      <td class="text-center">25%</td>
					      <td class="text-center"><% out.println(request.getParameter("mtexam")); %></td>
					      <td class="text-center">	<% String exam = request.getParameter("mtexam");
					      		out.println(String.format("%.2f",Double.parseDouble(exam)*0.25));
					      		loop[4] = Double.parseDouble(exam)*0.25;
					      	 %></td>
					    </tr>
					        <tr>
					      <th scope="row" class="text-center">Results</th>
					      <td class="text-center"></td>
					      <td class="text-center"></td>
					      <td class="text-center">	<%
					      		double sum=0;
					      		for(int x=0;x<loop.length;x++)
					      		{
					      			sum+= loop[x];
					      		}
					      		out.println(String.format("%.2f",sum));
					      	 %></td>
					    </tr>
					  </tbody>
					</table>
					<% out.println("<label class='d-flex flex-row-reverse fw-bolder'> Midterm grade is: "+String.format("%.2f",sum)+"</label>");%>
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
</body>
</html>