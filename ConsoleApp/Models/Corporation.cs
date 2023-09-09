using System.Text;

namespace ConsoleApp.Models;

[Serializable]
public class Corporation
{
    public string? Name { get; set; }
    public DateTime AdmissionDate { get; set; }
    public DateTime TerminatedDate { get; set; }

    public UserProfile? UserProfile { get; set; }

    public Corporation(string name,
                       string admissionDate,
                       string? terminatedDate)
    {
        Name = name;
        AdmissionDate = DateTime.Parse(admissionDate);
        TerminatedDate = DateTime.Parse(terminatedDate!);
    }

    public override string ToString()
    {
        return new StringBuilder()
            .Append("Corporation ")
            .Append("{ ")
            .Append($"Name: {Name}, ")
            .Append($"Admission: {AdmissionDate.Date}, ")
            .Append($"Terminated: {TerminatedDate.Date}")
            .Append(" }")
            .ToString();
    }
}