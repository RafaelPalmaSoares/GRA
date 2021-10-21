using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRA.Service.DTO
{
    public class IntervalDTO
    {
        public IntervalDTO()
        {
            Min = new List<ProducerDTO>();
            Max = new List<ProducerDTO>();
        }

        public List<ProducerDTO> Min { get; set; }
        public List<ProducerDTO> Max { get; set; }
    }
}
