<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
</head>
<body>
  <h1>Midterm Grade Result</h1>
  <hr>
  <p>Fill out the information below</p>
  <label>Class Participation:</label><%out.println(request.getParameter("participationValue")); %>
  <br>
   <label>Exercises:</label><%out.println(request.getParameter("exerciseValue")); %>
   <br>
   <label>Quizzes:</label><%out.println(request.getParameter("quizValue")); %>
   <br>
   <label>Special Project:</label><%out.println(request.getParameter("specialValue")); %>
   <br>
   <label>Midterm Exam:</label><%out.println(request.getParameter("midtermValue")); %>
   <br>
   <%
   		double participation = Double.parseDouble(request.getParameter("participationValue"))* 0.10;
   		double exercises = Double.parseDouble(request.getParameter("exerciseValue")) * 0.20;
   		double quizzes = Double.parseDouble(request.getParameter("quizValue")) * 0.25;
   		double specialproject = Double.parseDouble(request.getParameter("specialValue")) * 0.20;
   		double midterm = Double.parseDouble(request.getParameter("midtermValue")) * 0.25;
   		double sum = participation+exercises+quizzes+specialproject+midterm;
   		out.println("<hr/>");
   		out.println("<b>Midterm grade is "+String.format("%.2f",(sum))+"</b>");
   %>
  
</body>
</html>