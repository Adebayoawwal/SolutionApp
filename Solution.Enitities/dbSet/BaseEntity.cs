namespace Solution.Enitities.dbSet;

public class BaseEntity{
    public Guid id { get; set; }= Guid.NewGuid();
    public DateTime AddedDate{get; set;}=DateTime.UtcNow;
    public DateTime UpdatedDate{get; set;}=DateTime.UtcNow;
public int status { get; set; }
}