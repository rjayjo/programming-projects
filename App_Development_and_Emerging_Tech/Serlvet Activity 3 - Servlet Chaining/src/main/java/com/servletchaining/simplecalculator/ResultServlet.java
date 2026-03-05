package com.servletchaining.simplecalculator;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class ResultServlet extends HttpServlet {

	public void doPost(HttpServletRequest request, HttpServletResponse response) throws IOException
	{
		Double num1 = (Double) request.getAttribute("num1");
		Double num2 = (Double) request.getAttribute("num2");
		Double result = (Double) request.getAttribute("result");
		Integer operation = (Integer) request.getAttribute("operation");
		boolean isDouble = (boolean) request.getAttribute("isDouble");
		
		PrintWriter out = response.getWriter();
		out.println("<html style=\"background-color:Violet;\"><body>");
		
		if (isDouble = true) {
			
			if (operation == 1) {
				
				out.println("<h1 style=\"background-color:Orange;\">Adding [" + num2 + "] to [" + num1 + "] is equal to [" + result + "]</h1>");
				out.println("<br><a href='calculate.html'> <== Select Operation</a>");
			}
			
			if (operation == 2) {
				
				out.println("<h1 style=\"background-color:Gray;\">Subtracting [" + num2 + "] from [" + num1 + "] is equal to [" + result + "]</h1>");
				out.println("<br><a href='calculate.html'> <== Select Operation</a>");
			}
			
			if (operation ==3) {
				
				out.println("<h1 style=\"background-color:Tomato;\">Multiplying [" + num2 + "] to [" + num1 + "] is equal to [" + result + "]</h1>");
				out.println("<br><a href='calculate.html'> <== Select Operation</a>");
			}
			
			if (operation == 4) {
				
				out.println("<h1 style=\"background-color:MediumSeaGreen;\">Dividing [" + num1 + "] by [" + num2 + "] is equal to [" + result + "]</h1>");
				out.println("<br><a href='calculate.html'> <== Select Operation</a>");
			}
			
		} else {
			
			out.println("<h1> Number Fields Cannot be Left Blank! </h1>");
			out.println("<br><a href='calculate.html'> <== Select Operation</a>");
		}
		

		out.println("</html></body>");
	}
}
