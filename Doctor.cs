class Doctor
{
    private string fullName = string.Empty;
    private string specialty = string.Empty;
    private int experience;

    public Doctor()
    {
    }

    public Doctor(string fullName, string specialty)
    {
        this.fullName = fullName;
        this.specialty = specialty;
    }

    public Doctor(string fullName, string specialty, int experience)
        : this(fullName, specialty)
    {
        this.experience = experience;
    }

    public string TreatPatient(string patientName)
    {
        return $"{fullName}, {specialty}, is treating a patient named {patientName}";
    }

    public string PerformMedicalExamination(string patientName)
    {
        return $"{fullName} is performing a medical examination for the patient named {patientName}";
    }

    public string PrescribeMedication(string patientName, string medication)
    {
        return $"{fullName} prescribes {medication} for the patient named {patientName}";
    }

    public void SetExperience(int years)
    {
        experience = years;
    }

    public int GetExperience()
    {
        return experience;
    }
}
