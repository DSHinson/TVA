using System.ComponentModel.DataAnnotations;

namespace TVA.DAL.Model.dbo
{
    public class Person
    {
        public int Code { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Surname { get; set; }

        [MaxLength(50)]
        public string IdNumber { get; set; }
    }
}
