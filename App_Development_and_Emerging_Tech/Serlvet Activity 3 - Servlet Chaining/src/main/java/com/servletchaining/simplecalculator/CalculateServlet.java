package com.servletchaining.simplecalculator;

import java.io.IOException;
import java.io.PrintWriter;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletContext;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class CalculateServlet extends HttpServlet{
	
	@SuppressWarnings("unlikely-arg-type")
	public void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException
	
	{
		Double num1 = Double.parseDouble(request.getParameter("num1"));
		Double num2 = Double.parseDouble(request.getParameter("num2"));
		Integer operation = Integer.parseInt(request.getParameter("operation"));
		double result = 0;
		String blank = "";
		boolean isDouble = true;
		
		if (num1.equals(blank) || num2.equals(blank)) {
			
			isDouble = false;
		
		} else {
			
			isDouble = true;
			
			if (operation == 1) {
				result = num1 + num2;
			}
			if (operation == 2) {
				result = num1 - num2;	
			}
			if (operation == 3) {
				result = num1 * num2;
			}
			if (operation == 4) {
				result = num1 / num2;
			}		

		}
				 		
		request.setAttribute("num1", num1);
		request.setAttribute("num2", num2);
		request.setAttribute("result", result);
		request.setAttribute("operation", operation);
		request.setAttribute("isDouble", isDouble);
		

		RequestDispatcher rd = request.getRequestDispatcher("ComputationResult");
		rd.forward(request, response);
	}

}
