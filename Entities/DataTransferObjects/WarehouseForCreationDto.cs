using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class WarehouseForCreationDto
    {
        public string GoodName { get; set; }
        public string Count { get; set; }
        public string Price { get; set; }
        public IEnumerable<OrderForCreationDto> Order { get; set; }

    }
}
