using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne1.Models
{
    public class StudentAdress
    {
        public int Id { get; set; }
        public string City { get; set; }
        public int Pin { get; set; }

        //navigation property
        public int TestStudentId { get; set; } //fk
        public TestStudent? TestStudObj { get; set; }
    }
}
