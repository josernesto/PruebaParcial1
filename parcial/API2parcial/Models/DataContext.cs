using System.Data.Entity;

namespace API2parcial.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

       
    }
}