using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Project.Database
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public string? Email { get; set; }
    }
    
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }
        public string? ProjectName { get; set; }
        public string? Location { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }

    public class Area
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AreaID { get; set; }
        public string? AreaName { get; set; }

        [ForeignKey("Project")]
        public int ProjectID { get; set; }
        public Project Project { get; set; }
    }

    public class Profile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProfileID { get; set; }

        [ForeignKey("Area")]
        public int AreaID { get; set; }
        public Area Area { get; set; }
    }

    public class ProfilePoint
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PointID { get; set; }
        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }

        [ForeignKey("Profile")]
        public int ProfileID { get; set; }
        public Profile Profile { get; set; }
    }

    public class Picket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PicketID { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        [ForeignKey("ProfilePoint")]
        public int ProfilePointID { get; set; }
        public ProfilePoint ProfilePoint { get; set; }
    }

    public class PicketValue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PicketValueID { get; set; }
        public double Amplitude { get; set; }
        public double HValue { get; set; }

        [ForeignKey("Picket")]
        public int PicketID { get; set; }
        public Picket Picket { get; set; }
    }

    public class Operator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OperatorID { get; set; }
        public string? OperatorName { get; set; }
        public string? OperatorLogin { get; set; }
        public string? OperatorPassword { get; set; }
        public Role? Role { get; set; }

        [ForeignKey("Picket")]
        public int? PicketID { get; set; }
        public Picket Picket { get; set; }
    }

    public enum Role
    {
        Administrator
    }
}
