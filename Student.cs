class Student
{
    private string fullname = string.Empty;
    private int age;
    private int grade;

    public string FullName
    {
        get => fullname;
        private set => fullname = value;
    }

    public int Age
    {
        get => age;
        private set => age = value;
    }

    public int Grade
    {
        get => grade;
        private set => grade = value;
    }

    public Student()
    {
    }

    public Student(string fullname, int age)
    {
        FullName = fullname;
        Age = age;
    }

    public Student(string fullname, int age, int grade)
        : this(fullname, age)
    {
        Grade = grade;
    }

    public void Study()
    {
        Console.WriteLine($"{FullName} is studying.");
    }

    public void SetGrade(int newGrade)
    {
        Grade = newGrade;
    }

    public int GetGrade()
    {
        return Grade;
    }
}
