<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<style>
a {
	font-size: 25px; 
}
</style>
<title>Proceed</title>
</head>
<body>
	<jsp:useBean id="employeeBean" class="com.employee.salary.Employee" scope="session" />
	
	<jsp:setProperty name="employeeBean" property="firstName"/>
	<jsp:setProperty name="employeeBean" property="lastName" />
	<jsp:setProperty name="employeeBean" property="department" />
	<jsp:setProperty name="employeeBean" property="status" />
	<jsp:setProperty name="employeeBean" property="salary" />
	
	<jsp:setProperty name="employeeBean" property="*" />
	
	<a href="view-employee-bean.jsp"> Proceed to Employee Details </a>

</body>
</html>