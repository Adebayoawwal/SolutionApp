using Microsoft.EntityFrameworkCore;
using sampleAPI.Solution.Enitities.dbSet;

namespace Solution.DataService.Data;

public class AppdbContext: DbContext{
public virtual DbSet <Driver> Drivers{get; set;}

}