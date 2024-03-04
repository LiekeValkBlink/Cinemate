using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemate.Models.Dto
{
    public class BarcodeDto
    {
        public int Id { get; set; }
        public string? MovieName { get; set; }
        public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public TimeOnly Time { get; set; }
        public int Room { get; set; }

        public string? QrCode { get; set; }
    }
}
