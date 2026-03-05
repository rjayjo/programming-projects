package com.currencyconverter.servlet;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class CurrencyConverterServlet extends HttpServlet {
	
	
	public void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException
	{		
		String PHP = request.getParameter("PHP");
		double CUR = Double.parseDouble(request.getParameter("CUR"));	
		String blank = "";
          
		response.setContentType("text/html");	
		
		PrintWriter out = response.getWriter();
		
		out.println("<html><body style=\"background-color:MediumSeaGreen;\">");
		
		String regex = ".*[a-zA-Z].*";  
        Pattern pattern = Pattern.compile(regex);  
        Matcher matcherText = pattern.matcher(PHP);
        Boolean textMatches = matcherText.matches();
        
        if (textMatches == true)
        {
        	out.println("<h1 style=\"background-color:SlateBlue;\">Please input a valid integer value!</h1>");
        	out.println("<form action='SimpleCurrencyConverter'>");
			out.println("<input type='submit' value='Go Back to Converter'>");
			return;
        }
		 	
		if (PHP.equals(blank))
		{
		  out.println("<h1 style=\"background-color:Violet;\"> Field cannot be left blank! </h1>");
		  out.println("<form action='SimpleCurrencyConverter'>");
		  out.println("<input type='submit' value='Go Back to Converter'>");
		  return;
		 }
		  
		if (Double.parseDouble(PHP) <= 0) {
			out.println("<h1 style=\"background-color:Gray;\">Please input non-negative value! </h1>");
			out.println("<form action='SimpleCurrencyConverter'>");
			out.println("<input type='submit' value='Go Back to Converter'>");
			return;
		}
		
		if(isNumeric(PHP) == true)
		{
			out.println("<h1 style=\"background-color:Orange;\">Coversion Success!</h1>");
			
			out.println("<h2>The amount of " + PHP  + " PHP converted to ");
			
			if(CUR == 42.65)
			{
				out.println("US$");
			}
			else if (CUR == 60.50)
			{
				out.println("EURO");
			}
			else 
			{
				out.println("AUS$");
			}
			
			out.println("is equivalent to " + Double.parseDouble(PHP)/CUR + ".</h2>");
					
		}
		out.println("<form action='SimpleCurrencyConverter'>");
		out.println("<input type='submit' value='Go Back to Converter'>");
		out.println("</html></body>");
	}
		
	
	  boolean isNumeric(String inputString) 
	  { 
		  try {
	  Double.parseDouble(inputString); 
	  return true; } catch (NumberFormatException e) 
		  { return false; } 		  
	  }
	  
}
	
	

