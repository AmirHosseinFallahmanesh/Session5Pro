using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Dal
{
    [Table("Student",Schema ="HR")]
    public class StudentModel
    {
        public StudentModel()
        {
            //StudentId = Guid.NewGuid();
        }
      
   
        public int SId1 { get; set; }

     
      //  public int SId2 { get; set; }
        //[Column(TypeName ="CHAR(20)")]
        //[MaxLength(200)]
        public string Name { get; set; }

        [Required]
        public double Average { get; set; }

        [Column("B.D")]
        public DateTime BirthDate { get; set; }

        [NotMapped]
        public string GetInformation { get { return Name + " " + Average.ToString(); } set { } }
    }

}
