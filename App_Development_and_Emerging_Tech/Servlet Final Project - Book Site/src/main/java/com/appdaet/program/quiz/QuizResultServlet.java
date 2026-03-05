package com.appdaet.program.quiz;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;


@WebServlet("/QuizResultServlet")
public class QuizResultServlet extends HttpServlet{


	private static final long serialVersionUID = -2966865269990397260L;

	protected void doGet(HttpServletRequest request, HttpServletResponse response)  throws ServletException, IOException
	{
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		
		//initialize session object
		
		HttpSession session=request.getSession();
		String choice = request.getParameter("choice");
		int score= (int)session.getAttribute("sessionscore");

		if(choice.equals("a"))
		{
		    score= score+1;
		}
		else
		{
		
		    score= score;
			//session.setAttribute("sessionscore", score);
		}

		out.println("<html><head><link rel=stylesheet href=Style.css></head><body>");
		out.println("<div class='quiz-container'  id='quiz'>");
				out.println("<div class='quiz-header'>");
					out.println("<h1 id='question' style='text-align:center'>Below is your score</h1>");
					out.println("<h2 id='question' style='text-align:center; font-weight: light;'>Your Score: "+score+"</h2>");
		  out.println("</div>");
		out.println("</div>");
		out.println("</body></html>");
		

	}
}
