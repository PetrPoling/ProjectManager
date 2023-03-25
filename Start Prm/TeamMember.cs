namespace Project_Manager;

public class TeamMember
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public TaskStatus Status { get; set; }

    public void CreateTeamMember(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void ChangeStatus(TaskStatus status)
    {
        Status = status;
    }
}