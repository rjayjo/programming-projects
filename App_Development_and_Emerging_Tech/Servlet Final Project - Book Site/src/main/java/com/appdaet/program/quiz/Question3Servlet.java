package com.appdaet.program.quiz;

import java.io.IOException;

import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

@WebServlet("/Question3Servlet")
public class Question3Servlet extends HttpServlet {
	
	protected void doGet(HttpServletRequest request, HttpServletResponse response)  throws ServletException, IOException
	{
		
	
		//HTML Writer
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();

		//Make the form
				out.println("<html><head><link rel=stylesheet href=Style.css></head><body>");
				out.println("<div class='quiz-container'  id='quiz'>");
						out.println("<div class='quiz-header'>");
							out.println("<form action='Question4Servlet'>");
							out.println("<h2 id='question'>JSP scripting element use for multiple lines?</h2>");
							out.println("<ul>");
								out.println("<li>");
									out.println("<input type='radio' name='choice' value='a' required>");
									out.println("<label id='a-text' >documentation</label>");
								out.println("</li>");
								out.println("<li>");
									out.println("<input type='radio' name='choice' value='b' required>");
									out.println("<label id='a-text'>directive</label>");
								out.println("</li>");
								out.println("<li>");
									out.println("<input type='radio' name='choice' value='c' required>");
									out.println("<label id='a-text' style='font-weight: bold'>declaration</label>");
								out.println("</li>");
								out.println("<li>");
									out.println("<input type='radio' name='choice' value='d' required>");
									out.println("<label id='a-text'>expression</label>");
								out.println("</li>");
							out.println("</ul>");
							out.println("<input type='submit' value='Submit'>");
					out.println("</form>");
				  out.println("</div>");
				out.println("</div>");
				out.println("</body></html>");
				
		

				HttpSession session=request.getSession();
				String choice = request.getParameter("choice");

				if(choice.equals("b"))
				{
					int score= (int)session.getAttribute("sessionscore");
					session.setAttribute("sessionscore", score+1);

				}
				else
				{
					int score= (int)session.getAttribute("sessionscore");
					session.setAttribute("sessionscore", score);
				}
				
		

	}
}
