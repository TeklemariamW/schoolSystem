namespace school_5.Models;

public class TestResult
{
	public int TestResultId { get; set; }

	public int StudentId { get; set; }

	public int TestId { get; set; }

	
	public int Grade { get; set; }

	public Student Student { get; set; }
	public Test Test { get; set; }
}