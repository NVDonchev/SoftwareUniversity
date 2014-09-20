import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.Scanner;

public class _3_ExamScore {
	public static void main(String[] args) {
		ArrayList<ExamScore> examScores = new ArrayList<ExamScore>();

		Scanner scan = new Scanner(System.in);
		scan.nextLine();
		scan.nextLine();
		scan.nextLine();

		String line;
		while (true) {
			line = scan.nextLine();
			line = line.substring(1);
			String[] lineTokens = line.split("\\|");

			for (int token = 0; token < lineTokens.length; token++) {
				lineTokens[token] = lineTokens[token].trim();
			}
			
			if (!line.contains("-")) {
				examScores.add(new ExamScore(lineTokens[0], Integer.parseInt(lineTokens[1]), Double.parseDouble(lineTokens[2])));
			}
			else {
				break;
			}
		}

		ArrayList<ExamScoreResult> examResults = new ArrayList<ExamScoreResult>();
		
		for (int score = 0; score < examScores.size(); score++) {
			
			boolean examScorePresent = false;
			
			for (int search = 0; search < examResults.size(); search++) {
				
				if (examResults.get(search).ExamScore == examScores.get(score).ExamScore) {
					
					examResults.get(search).addNameAndGrade(examScores.get(score).Name, examScores.get(score).Grade);
					examScorePresent = true;
					break;
				}
			}
			
			if (!examScorePresent) {
				examResults.add(new ExamScoreResult(examScores.get(score).ExamScore, examScores.get(score).Name, examScores.get(score).Grade));
			}
		}
		
		Collections.sort(examResults, new Comparator<ExamScoreResult>(){
		     public int compare(ExamScoreResult o1, ExamScoreResult o2){
		         if(o1.ExamScore == o2.ExamScore)
		             return 0;
		         return o1.ExamScore < o2.ExamScore ? -1 : 1;
		     }
		});
		
		for (ExamScoreResult result : examResults) {
			result.sortNames();
			System.out.printf("%d -> %s; avg=%.2f\n", result.ExamScore, result.Names, result.getAvgGrade());
		}
	}
}

final class ExamScore {
	String Name;
	int ExamScore;
	Double Grade;

	public ExamScore(String name, int examScore, Double grade) {
		this.Name = name;
		this.ExamScore = examScore;
		this.Grade = grade;
	}
}

final class ExamScoreResult {
	int ExamScore;
	ArrayList<String> Names;
	ArrayList<Double> Grades;
	
	public ExamScoreResult(int examScore, String name, Double grade) {
		Names = new ArrayList<String>();
		Grades = new ArrayList<Double>();
		
		ExamScore = examScore;
		Names.add(name);
		Grades.add(grade);
	}
	
	public void addNameAndGrade(String name, Double grade) {
		Names.add(name);
		Grades.add(grade);
	}
	
	public void sortNames() {
		Collections.sort(Names);
	}
	
	public double getAvgGrade() {
		double gradesTotal = 0;
		
		for (Double grade : Grades) {
			gradesTotal += grade;
		}
		
		return gradesTotal / Grades.size();
	}
}