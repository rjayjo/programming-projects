package sessionactivity;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 * Servlet implementation class Question2Servlet
 */
@WebServlet("/Question2Servlet")
public class Question2Servlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Question2Servlet() {
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
		out.println("<h2>Question 2:</h2>");
		out.println("<br><h1>Used for file insertion to a JSP file. It merges page fragments at run-time.</h1>");
		out.println("<br><h1>a. JSP Directive - Page</h1>");
		out.println("<h1 style='color:green'><i>b. JSP Directive - Include</i></h1>");
		out.println("<h1>c. Java Import Command</h1>");
		out.println("<h1>d. None of the above</h1>");
		
		out.println("<form action='Question3Servlet'>");
		out.println("Answer: <input type='text' name='q2Ans'/>");
		out.println("<input type='submit' value='Submit'/>");
		out.println("</form>");
		 
		
		 String q1Ans = request.getParameter("q1Ans");
		 if(q1Ans == null)
			{
				q1Ans = "";
			}
		
		HttpSession session = request.getSession();
		session.setAttribute("sessionQ1Ans", q1Ans);
		session.getAttribute("q1Ans");
		
		out.println(q1Ans);
		out.println("</body></html>");
		out.println("</center>");
		
		
		
	}

}
