// Teacher t1 = new Teacher();

// Teacher t2 = new Teacher("Shahrom " , "matematik");

// t2.Teach();
// t2.Years(5);
// Console.WriteLine(t2.Ago());

// Teacher t3 = new Teacher("Oisha " , "Fizik" , 10);
// t3.Teach();
// Console.WriteLine(t3.Ago());

Student student = new Student("Abdullo", 18, 10);
student.Study();
Console.WriteLine($"Grade: {student.GetGrade()}");

Doctor doctor = new Doctor("Dr. Smith", "cardiologist", 12);
Console.WriteLine(doctor.TreatPatient("Abdullo"));
Console.WriteLine(doctor.PerformMedicalExamination("Abdullo"));
Console.WriteLine(doctor.PrescribeMedication("Abdullo", "medicine"));
Console.WriteLine($"Experience: {doctor.GetExperience()} years");
