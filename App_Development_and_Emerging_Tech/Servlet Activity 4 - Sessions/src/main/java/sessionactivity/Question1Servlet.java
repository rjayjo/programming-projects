package sessionactivity;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.List;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 * Servlet implementation class Question1Servlet
 */
@WebServlet("/Question1Servlet")
public class Question1Servlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Question1Servlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		
		out.println("<center>");
		out.println("<html><body bgcolor='lightpink'>");
		out.println("<h2>Question 1:</h2>");
		out.println("<br><h1>What is JSP?</h1>");
		out.println("<br><h1 style='color:green'><i>a. Java Server Pages</i></h1>");
		out.println("<h1>b. Java System Pages</h1>");
		out.println("<h1>c. Java Short Paces</h1>");
		out.println("<h1>d. None of the above</h1>");
		
		out.println("<form action='Question2Servlet'>");
		out.println("Answer: <input type='text' name='q1Ans'/>");
		out.println("<input type='submit' value='Submit'/>");
		out.println("</form>");
		out.println("</body></html>");
		out.println("</center>");
			
	}

	
}
