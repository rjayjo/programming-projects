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
<title>Salary Details</title>
</head>
<body>

<jsp:useBean id="employeeBean" class="com.employee.salary.Employee" scope="session" />
	
	<h3>Look at the details below:</h3>
	<br/>
	<pre>
	First Name : <%= employeeBean.getFirstName() %> <br/>
	Last Name :  <%= employeeBean.getLastName() %> <br/>
	Department : <%= employeeBean.getDepartment() %> <br/>
	Status :     <%= employeeBean.getStatus() %> <br/>
	Salary :     <%= employeeBean.getSalary() %> <br/>
	</pre>

	<%
	double bipayment = (employeeBean.getSalary()/2);	
	double tax = (bipayment * 0.3);
	double netpay = (bipayment - tax) - 1000 + 4500;
	%>

	<h2>Total Bimonthly Net Pay: <%= netpay %> </h2>
	
</body>
</html>