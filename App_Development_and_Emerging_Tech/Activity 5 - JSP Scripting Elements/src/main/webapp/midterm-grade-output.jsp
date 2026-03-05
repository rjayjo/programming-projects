<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<style>
pre {

 	font-family: monospace;
 	font-size: 18px;

}
</style>
<title>MIDTERM GRADE RESULT</title>
</head>
<body>

	<h2> Midterm Grade Result </h2>
	<hr>
	
	<h3>Student's Grade Information </h3>
	<pre>
	Class Participation: <%= request.getParameter("participation") %> <br>
	Exercises:           <%= request.getParameter("exercise") %> <br>
	Quizzes:             <%= request.getParameter("quiz") %> <br>
	Special Project:     <%= request.getParameter("project") %> <br>
	Midterm Exam:        <%= request.getParameter("exam") %> 
	</pre>
	
	<%
	int participation = Integer.parseInt(request.getParameter("participation"));
	int exercise = Integer.parseInt(request.getParameter("exercise"));
	int quiz = Integer.parseInt(request.getParameter("quiz"));
	int project = Integer.parseInt(request.getParameter("project"));
	int exam = Integer.parseInt(request.getParameter("exam"));
	
	double par = participation * 0.1;
	double exe = exercise * 0.2;
	double q = quiz * 0.25;
	double proj = project * 0.2;
	double exa = exam * 0.25;
	
	double total = par + exe + q + proj + exa;
	
	out.println("<h3>Total Midterm Grade: "); out.println(String.format("%.2f", total));
	%>
			
</body>
</html>