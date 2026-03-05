<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Employee Form</title>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</head>
<body style="background-color:#202430">
<div class="container px-5 my-5" >
  <div class="row justify-content-center">
    <div class="col-lg-8">
      <div class="card border-0 rounded-3 shadow-lg" style="background-color: #242A38">
        <div class="card-body p-4">
          <div class="text-center">
            <h1 class="text-light">Employee Form</h1>
            <p class="mb-4 text-muted">Please click on the button below to proceed!</p>
            <a href="view-employee-bean.jsp" class="btn btn-success">Proceed</a>
			<jsp:useBean id="EmployeeBean" class="com.benilde.appdaet.Employee" scope="session" />
			<jsp:setProperty name="EmployeeBean" property="firstName"/>
			<jsp:setProperty name="EmployeeBean" property="lastName" />
			<jsp:setProperty name="EmployeeBean" property="department" />
			<jsp:setProperty name="EmployeeBean" property="status" />
			<jsp:setProperty name="EmployeeBean" property="salary" />			
			<jsp:setProperty name="EmployeeBean" property="*" />
			
			
	       </div>
	      
        </div>
      </div>
    </div>
  </div>
</div>
</body>
</html>