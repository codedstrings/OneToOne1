using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne1.Models
{
    public class TestStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //navigation prop
        public StudentAdress? StudentAdressObj { get; set; }
    }
}
