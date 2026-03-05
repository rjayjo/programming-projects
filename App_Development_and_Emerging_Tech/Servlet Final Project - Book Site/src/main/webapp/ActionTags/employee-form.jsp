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
            <p class="mb-4 text-muted">Please provide employee details for the computation to work! Thank you!</p>
	          </div>
	          <form action="saveinfo.jsp" method="get">
					  <div class="form-group mb-1">
					    <label class="text-light mb-2">First Name</label>
					    <input type="text" class="form-control" name="firstName"  placeholder="Enter first name...">
					  </div>
					  <div class="form-group mb-1">
					    <label class="text-light mb-2">Last Name</label>
					    <input type="text" class="form-control" name="lastName" placeholder="Enter last name...">
					  </div>
					  <div class="form-group mb-1">
					    <label class="text-light mb-2">Department</label>
					    <select class="form-control" name="department">
					      <option>IT</option>
					      <option>Accounting</option>
					      <option>HR</option>
					      <option>Sales</option>
					    </select>
					  </div>
					   <div class="form-group mb-1">
					    <label class="text-light mb-2">Status</label>
					    <select class="form-control" name="status">
					      <option>Regular</option>
					      <option>Probationary</option>
					    </select>
					  </div>
					    <div class="form-group mb-1">
					    <label class="text-light mb-2">Salary</label>
					    <input type="number" class="form-control" name="salary"  min="0">
					  </div>
					  <div class="d-flex mt-4">
					  		<input type="submit" class="btn btn-primary" value="Submit">
					  </div>
            
          </form>
        </div>
      </div>
    </div>
  </div>
</div>

</body>
</html>