package com.benilde.appintr.bernardo_midtermcasestudy;

import jakarta.enterprise.context.SessionScoped;
import jakarta.inject.Named;

import java.io.Serializable;
import java.util.ArrayList;

@Named
@SessionScoped
public class MidtermBean implements Serializable {

    private String courseCode;

    private ArrayList<String> courseCodeArray = new ArrayList<String>();

    private  String numberOfUnits;

    private ArrayList<String> numberOfUnitsArray = new ArrayList<String>();

    private String termGrade;

    private ArrayList<String> termGradeArray = new ArrayList<String>();

    private ArrayList<Double> gradePointArray = new ArrayList<Double>();

    private String totalUnits;

    private String totalGrade;

    private String totalUnitsResult;

    private String totalGradeResult;

    private String TGPAResult;


    public String getCourseCode() {
        return courseCode;
    }

    public void setCourseCode(String courseCode) {
        this.courseCode = courseCode;
    }

    public ArrayList<String> getCourseCodeArray() {
        return courseCodeArray;
    }

    public void setCourseCodeArray(ArrayList<String> courseCodeArray) {
        this.courseCodeArray = courseCodeArray;
    }

    public String getNumberOfUnits() {
        return numberOfUnits;
    }

    public void setNumberOfUnits(String numberOfUnits) {
        this.numberOfUnits = numberOfUnits;
    }

    public ArrayList<String> getNumberOfUnitsArray() {
        return numberOfUnitsArray;
    }

    public void setNumberOfUnitsArray(ArrayList<String> numberOfUnitsArray) {
        this.numberOfUnitsArray = numberOfUnitsArray;
    }

    public String getTermGrade() {
        return termGrade;
    }

    public void setTermGrade(String termGrade) {
        this.termGrade = termGrade;
    }

    public ArrayList<String> getTermGradeArray() {
        return termGradeArray;
    }

    public void setTermGradeArray(ArrayList<String> termGradeArray) {
        this.termGradeArray = termGradeArray;
    }

    public ArrayList<Double> getGradePointArray() {
        return gradePointArray;
    }

    public void setGradePointArray(ArrayList<Double> gradePointArray) {
        this.gradePointArray = gradePointArray;
    }

    public String getTotalUnits() {
        if(numberOfUnitsArray.size()>0)
        {
            double sum=0;
            for(int x=0; x< numberOfUnitsArray.size();x++)
            {
                sum+= Double.parseDouble(numberOfUnitsArray.get(x));
            }
            return Double.toString(sum);
        }
        return "0.0";
    }

    public void setTotalUnits(String totalUnits) {
        this.totalUnits = totalUnits;
    }

    public String getTotalGrade() {
        if(gradePointArray.size()>0)
        {
            double sum=0;
            for(int x=0; x< gradePointArray.size();x++)
            {
                sum+= gradePointArray.get(x);
            }
            return Double.toString(sum);
        }
        return "0.0";
    }

    public void setTotalGrade(String totalGrade) {
        this.totalGrade = totalGrade;
    }

    public String getTotalUnitsResult() {
        if(this.totalUnits!=null)
        {
            return "OVERALL UNITS: "+ this.totalUnits;
        }
        return "OVERALL UNITS: ";
    }

    public void setTotalUnitsResult(String totalUnitsResult) {
        this.totalUnitsResult = totalUnitsResult;
    }

    public String getTotalGradeResult() {
        if(this.totalGrade!=null)
        {
            return "GRADE POINTS SUM: "+ this.totalGrade;
        }
        return "GRADE POINTS SUM: ";
    }

    public void setTotalGradeResult(String totalGradeResult) {
        this.totalGradeResult = totalGradeResult;
    }

    public String getTGPAResult() {
        if(this.totalGrade!=null && this.numberOfUnits!=null)
        {
            return "TERM GRADE POINT AVERAGE: " + Double.parseDouble(this.totalGrade)/Double.parseDouble(this.totalUnits);
        }
        return "TERM GRADE POINT AVERAGE: ";
    }

    public void setTGPAResult(String TGPAResult) {
        this.TGPAResult = TGPAResult;
    }

    public String addCourse()
    {
        if(courseCodeArray.size()<8 && this.courseCode!=null && this.numberOfUnits!= null && this.termGrade!=null)
        {

            if(!this.courseCodeArray.contains(this.courseCode.toUpperCase()))
            {
                this.courseCodeArray.add(this.courseCode.toUpperCase());
                this.numberOfUnitsArray.add(this.numberOfUnits);
                this.termGradeArray.add(this.termGrade);
                this.gradePointArray.add(Double.parseDouble(numberOfUnits)*Double.parseDouble(termGrade));
            }

        } return null;
    }

    public String displayResult()
    {
        return null;
    }


}
