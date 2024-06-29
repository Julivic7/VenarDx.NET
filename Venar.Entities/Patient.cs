using Venar.Entities;
using Venar.SVC;

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Dni { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public Locations Location { get; set; }
    public CoverageMedical MedicalCoverage { get; set; }


}