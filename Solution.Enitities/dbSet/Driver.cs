namespace sampleAPI.Solution.Enitities.dbSet;

public class Driver  : BaseEntity
{
    public Driver(){ 
         Achievement= new HashSet<Achievement>();
    }
 public string FirstName { get; set; }=string.Empty;
 public string LastName { get; set; }=string.Empty; 
 public int DriverNumber { get; set; }
 public DateTime DateOfBirth { get; set; } 
 
public virtual ICollection<Achievement> Achievement{get; set;}

}