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
<title>MIDTERM GRADES INPUT</title>
</head>

<body>

	<h2> Midterm Grades Calculator </h2>
	<hr>
	
	<form action="midterm-grade-output.jsp">
	<pre>
	Class Participation (10%) -  <input type="number" name="participation" /> <br>
	Exercises (20%) -            <input type="number" name="exercise" /> <br>
	Quizzes (25%) -              <input type="number" name="quiz" /> <br>
	Special Project (20%) -      <input type="number" name="project" /> <br>
	Mid-term Examination (25%) - <input type="number" name="exam" /> <br>
	<input type="submit" value="Calculate">
	</pre>
	</form>

</body>
</html>

