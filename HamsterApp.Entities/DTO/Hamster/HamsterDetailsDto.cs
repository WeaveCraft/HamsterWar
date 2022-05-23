using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterApp.Entities.DTO.Hamster
{
    public class HamsterDetailsDto : HamsterReadOnlyDto
    {
        public List<HamsterReadOnlyDto> Hamsters { get; set; }
    }
}
