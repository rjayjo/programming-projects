<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
</head>

<body>
      <h1>Input grades for the following categories.</h1>
      <hr>
      <p>Fill out the information below</p>
      <div>
      <form action="midterm-grade-output.jsp">
	      <label>Class Participation: </label>
	      <input type="number" name="participationValue">
	      </div>
	       <br>
	       <div>
	      <label>Exercises: </label>
	      <input type="number" name="exerciseValue">
	      </div>
	       <br>
	       <div>
	      <label>Quizzes: </label>
	      <input type="number" name="quizValue">
	      </div>
	       <br>
	       <div>
	      <label>Special Project: </label>
	      <input type="number" name="specialValue">
	      </div> 
	       <br>
	       <div>
	      <label>Midterm Exam: </label>
	      <input type="number" name="midtermValue">
	      </div>
	      <br>
	      <hr/>
	      <input type="submit" value="Compute Grade">
	   </form>
</body>
</html>