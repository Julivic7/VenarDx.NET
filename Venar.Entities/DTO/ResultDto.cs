using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venar.DTO;

namespace Venar.DTO
{
    public class ResultDto
    {
        public List<string> Errors { get; set; } = new List<string>();
        public MedicDto MedicDto { get; set; }

        public bool IsSuccess
        {
            get
            {
                return Errors.Count == 0;
            }
        }
    }

}
