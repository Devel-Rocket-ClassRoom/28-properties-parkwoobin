using System;
using System.Reflection.Metadata.Ecma335;

// README.md를 읽고 아래에 코드를 작성하세요.

Student student1 = new Student("김철수") { KoreanScore = 85, EnglishScore = 90, MathScore = 95 };
Console.WriteLine($"=== 성적표: {student1.Name} ===");
student1.Print();


Student student2 = new Student("이영희") { KoreanScore = 70, EnglishScore = 75, MathScore = 80 };
Console.WriteLine($"=== 성적표: {student2.Name} ===");
student2.Print();

Student student3 = new Student("박민수") { KoreanScore = 100, EnglishScore = 100, MathScore = 0 };
Console.WriteLine($"=== 성적표: {student3.Name} ===");
student3.Print();


class Student
{
    public string Name { get; private set; }
    public int KoreanScore { get; set; }
    public int EnglishScore { get; set; }
    public int MathScore { get; set; }
    public int TotalScore => KoreanScore + EnglishScore + MathScore;
    public double Average => (double)TotalScore / 3;
    public string Grade => Average >= 90 ? "A" : Average >= 80 ? "B" : Average >= 70 ? "C" : Average >= 60 ? "D" : "F";
    public Student(string name)
    {
        Name = name;
    }

    public void Print()
    {
        Console.WriteLine($"국어: {KoreanScore}, 영어: {EnglishScore}, 수학: {MathScore}");
        Console.WriteLine($"총점: {TotalScore}");
        Console.WriteLine($"평균: {Average:F2}");
        Console.WriteLine($"학점: {Grade}\n");
    }

}


