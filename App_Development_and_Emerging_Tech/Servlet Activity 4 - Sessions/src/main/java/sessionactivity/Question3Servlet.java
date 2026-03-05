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
 * Servlet implementation class Question3Servlet
 */
@WebServlet("/Question3Servlet")
public class Question3Servlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public Question3Servlet() {
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
		out.println("<h2>Question 3:</h2>");
		out.println("<br><h1>JSP scripting element use for multiple lines.</h1>");
		out.println("<br><h1>a. documentation</h1>");
		out.println("<h1>b. directive</h1>");
		out.println("<h1 style='color:green'><i>c. declaration </i></h1>");
		out.println("<h1>d. expression</h1>");
		
		out.println("<form action='Question4Servlet'>");
		out.println("Answer: <input type='text' name='q3Ans'/>");
		out.println("<input type='submit' value='Submit'/>");
		out.println("</form>");
		
		 String q2Ans = request.getParameter("q2Ans");
		 if(q2Ans == null)
			{
				q2Ans = "";
			}
		
		HttpSession session = request.getSession();
		session.setAttribute("sessionQ2Ans", q2Ans);
		session.getAttribute("q2Ans");
		out.println("</body></html>");
		out.println("</center>");

	}

}
