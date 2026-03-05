package com.appdaet.program.quiz;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;


@WebServlet("/Question1Servlet")
public class Question1Servlet extends HttpServlet
{
	
	private static final long serialVersionUID = 1L;

	protected void doGet(HttpServletRequest request, HttpServletResponse response)  throws ServletException, IOException
	{
		
	
		//HTML Writer
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		
		//Make the form
		out.println("<html><head><link rel=stylesheet href=Style.css></head><body>");
		out.println("<div class='quiz-container'  id='quiz'>");
				out.println("<div class='quiz-header'>");
					out.println("<form action='Question2Servlet'>");
					out.println("<h2 id='question'>What is JSP?</h2>");
					out.println("<ul>");
						out.println("<li>");
							out.println("<input type='radio' name='choice' value='a' required>");
							out.println("<label id='a-text' style='font-weight: bold'>Java Servlet Pages</label>");
						out.println("</li>");
						out.println("<li>");
							out.println("<input type='radio' name='choice' value='b' required>");
							out.println("<label id='a-text'>Java System Paces</label>");
						out.println("</li>");
						out.println("<li>");
							out.println("<input type='radio' name='choice'  value='c' required>");
							out.println("<label id='a-text'>Java Short Paces</label>");
						out.println("</li>");
						out.println("<li>");
							out.println("<input type='radio' name='choice'  value='d' required>");
							out.println("<label id='a-text'>None of the above</label>");
						out.println("</li>");
					out.println("</ul>");
			out.println("<input type='submit' value='Submit'>");
			out.println("</form>");
		  out.println("</div>");
		out.println("</div>");
		out.println("</body></html>");
	
		
	}


}
