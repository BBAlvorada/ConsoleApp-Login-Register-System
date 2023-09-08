using System.Text;

namespace ConsoleApp.Models;

public class Corporation
{
    public string? Name { get; set; }
    public DateTime AdmissionDate { get; set; }
    public DateTime TerminatedDate { get; set; }

    public UserProfile? UserProfile { get; set; }

    public Corporation(string name,
                       string admissionDate,
                       string terminatedDate)
    {
        Name = name;
        AdmissionDate = DateTime.Parse(admissionDate).Date;
        TerminatedDate = DateTime.Parse(terminatedDate).Date;
    }

    public override string ToString()
    {
        return new StringBuilder()
            .Append("Corporation ")
            .Append("{ ")
            .Append($"Name: {Name}, ")
            .Append($"Admission: {AdmissionDate}, ")
            .Append($"Terminated: {TerminatedDate}")
            .AppendLine(" }")
            .ToString();
    }
}