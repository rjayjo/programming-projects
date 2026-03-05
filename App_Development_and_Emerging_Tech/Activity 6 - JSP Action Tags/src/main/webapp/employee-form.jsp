<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<style>
pre {

 	font-family: monospace;
 	font-size: 20px;
}
</style>
<title>Employee Form</title>
</head>
<body>

	<form action="saveinfo.jsp" method="get">
	<pre>
		First Name :  <input type="text" name="firstName" />
		<br/>
		Last Name :   <input type="text" name="lastName" />
		<br/>
		Department :  <select name="department" id="department">
		<option > Marketing</option>
		<option > Information Technology</option>
    	<option > Human Resource</option>
    	<option > Accounting</option>
    	<option > Sales</option>
    	</select>
		<br/>
		Status :      <select name="status" id="status">
		<option > Regular</option>
    	<option > Probationary</option>
    	</select>
		<br/>
		Salary :      <input type="number" name="salary" />
		<br/>
		<input type="submit" value="Submit" />
	</pre>
	</form>

</body>
</html>