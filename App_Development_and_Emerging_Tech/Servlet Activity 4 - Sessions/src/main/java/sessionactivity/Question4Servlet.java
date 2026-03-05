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
 * Servlet implementation class Question4Servlet
 */
@WebServlet("/Question4Servlet")
public class Question4Servlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Question4Servlet() {
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
		out.println("<h2>Question 4:</h2>");
		out.println("<br><h1>JDBC stands for:</h1>");
		out.println("<br><h1 style='color:green'><i>a. Java Database Connectivity </i></h1>");
		out.println("<h1>b. Java Database Connection</h1>");
		out.println("<h1>c. Java Data Business Continuity</h1>");
		out.println("<h1>d. None of the above</h1>");
		
		out.println("<form action='QuizResultServlet'>");
		out.println("Answer: <input type='text' name='q4Ans'/>");
		out.println("<input type='submit' value='Submit'/>");
		out.println("</form>");
		
		String q3Ans = request.getParameter("q3Ans");
		 if(q3Ans == null)
			{
				q3Ans = "";
			}
		
		HttpSession session = request.getSession();
		session.setAttribute("sessionQ3Ans", q3Ans);
		session.getAttribute("q3Ans");
		
		out.println("</body></html>");
		out.println("</center>");

	}

}
