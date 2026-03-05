package com.employee.salary;
import java.io.Serializable;

public class Employee implements Serializable{

	private static final long serialVersionUID = 1L;
	
	private String firstName;
	private String lastName;
	private String department;
	private double salary;
	private String status;
	
	public String getFirstName() {
		return firstName;
	}
	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}
	public String getLastName() {
		return lastName;
	}
	public void setLastName(String lastName) {
		this.lastName = lastName;
	}
	public String getDepartment() {
		return department;
	}
	public void setDepartment(String department) {
		this.department = department;
	}
	public double getSalary() {
		return salary;
	}
	public void setSalary(double salary) {
		this.salary = salary;
	}
	public String getStatus() {
		return status;
	}
	public void setStatus(String status) {
		this.status = status;
	}
			
	
	// Total Allowance = 750 + 3500 + 750; 4500
	// Total Deductions = 500 + 400	+ 100; 1000
	// Bimonthly Pay = Salary / 2;
	// Tax = Bimonthly Pay * 30%;
	//Net Pay = (Bimonthly Pay - Tax) - Total Deductions + Total Allowances;
	// ScriptElement>JavaMethod
	
}
