<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Salary Computation</title>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>

</head>
<body style="background-color:#202430">
	<jsp:useBean id="EmployeeBean" class="com.benilde.appdaet.Employee" scope="session" />
	<div class="container px-5 my-5" >
  <div class="row justify-content-center">
    <div class="col-lg-8">
      <div class="card border-0 rounded-3 shadow-lg" style="background-color: #242A38">
        <div class="card-body p-4">
          <div class="text-center">
            <h1 class="text-light">Employee Form</h1>
            <p class="mb-4 text-muted">Here are the details of the employee! Thank you!</p>
  	 			<% out.println("<b class='text-white mb-1'>First Name: </b><label class='text-white mb-1'>"+EmployeeBean.getFirstName()+"</label><br/>"); %>
  	 			<% out.println("<b class='text-white mb-1'>Last Name: </b><label class='text-white mb-1'>"+EmployeeBean.getLastName()+"</label><br/>"); %>
  	 			<% out.println("<b class='text-white mb-1'>Department: </b><label class='text-white mb-1'>"+EmployeeBean.getDepartment()+"</label><br/>"); %>
  	 			<% out.println("<b class='text-white mb-1'>Status: </b><label class='text-white mb-1'>"+EmployeeBean.getStatus()+"</label><br/>"); %>
  	 			<% out.println("<b class='text-white mb-1'>Salary: </b><label class='text-white mb-1'>"+EmployeeBean.getSalary()+"</label><br/>"); %>
  	 			<hr class="bg-light mx-auto" style="width:500px;"/>
  	 			<% 
  	
  	 			out.println("<b class='text-white mb-1'>Bi-Monthly Pay Net: </b><label class='text-white mb-1'>"+String.format("%.2f", EmployeeBean.Compute(EmployeeBean.getSalary()))+"</label><br/>"); %>
	       </div>
	      
        </div>
      </div>
    </div>
  </div>
</div>


	
</body>
</html>