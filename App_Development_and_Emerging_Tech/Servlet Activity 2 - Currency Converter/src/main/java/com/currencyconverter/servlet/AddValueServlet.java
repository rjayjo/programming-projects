package com.currencyconverter.servlet;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class AddValueServlet extends HttpServlet{
		
	public void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException
	{		
		response.setContentType("text/html");
		
		PrintWriter out = response.getWriter();
		
		out.println("<html><body style=\"background-color:powderblue;\">");
		out.println("<form action='ConversionResult'>");
		out.println("<h1 style=\"background-color:Tomato;\">Static Currency Converter</h1>");
		out.println("<h2>PHP to USD | EURO | AUS</h2>");
		out.println("<p> Enter PHP Amount: <input type='text' name='PHP'</p>");
		out.println("<br><br> TO");
		out.println("<p>Foreign Currency");
		out.println("<select name='CUR'>");
		out.println("<option id='USD' value='42.65'>USD (United State Dollars) </option>");
		out.println("<option id='EURO' value='60.50'>EURO (European Currency) </option>");
		out.println("<option id'AUS' value='42.00'>AUD (Australian Dollar) </option>");
		out.println("</select>");
		out.println("<br><br>");
		out.println("<input type='submit' value='Convert'>");
		out.println("</form>");
		
		out.println("</html></body>");
		
	}
	
	

}
