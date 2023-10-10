namespace Celilcavus.Model;
public class User
{
    
    public Guid id { get; set; } = Guid.NewGuid();
    public int Number { get; set; }
    public string Name { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;

    public DateTime CreatedDate { get; init; }
    public DateTime UpdateDate { get; set; }


    public User()
    {
        CreatedDate = DateTime.Now;
        UpdateDate = DateTime.Now;
    }
}