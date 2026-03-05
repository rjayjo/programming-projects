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
 * Servlet implementation class QuizResultServlet
 */
@WebServlet("/QuizResultServlet")
public class QuizResultServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public QuizResultServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		HttpSession session=request.getSession(); 
		
		String q4Ans = request.getParameter("q4Ans");
		 if(q4Ans == null)
			{
				q4Ans = "";
			}
		
		session.setAttribute("sessionQ4Ans", q4Ans);
		session.getAttribute("q4Ans");
		
		String q1Ans = (String) session.getAttribute("sessionQ1Ans");
		String q2Ans = (String) session.getAttribute("sessionQ2Ans");
		String q3Ans = (String) session.getAttribute("sessionQ3Ans");
		int totalScore = 0;

		
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		out.println("<center>");
		out.println("<html><body bgcolor='lightpink'>");
		out.println("<h2>Result</h2><br>");
		out.println("<h1>You answered [" + q1Ans + "] in question 1</h1>");
		out.println("<h1>You answered [" + q2Ans + "] in question 2</h1>");
		out.println("<h1>You answered [" + q3Ans + "] in question 3</h1>");
		out.println("<h1>You answered [" + q4Ans + "] in question 4</h1>");
	
		
		if (q1Ans.equals("a") || q1Ans.equals("A")) 
		{
			totalScore +=1;	
		}
		
		if (q2Ans.equals("b") || q2Ans.equals("B")) 
		{
			totalScore +=1;	
		}
		
		if (q3Ans.equals("c") || q3Ans.equals("C")) 
		{
			totalScore +=1;	
		}
		
		if (q4Ans.equals("a") || q4Ans.equals("A")) 
		{
			totalScore +=1;	
		}
		
		
		out.println("<h1 style='color:blue'><br>Your total score is [" + totalScore + "] out of 4!</h1>");
		out.println("</body></html>");
		out.println("</center>");
	}

}
