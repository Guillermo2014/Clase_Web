using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Domain.Models
{
    public enum EUnitOfMeasurement : byte
    {
        [Description("Un")]
        Unity = 1,
        [Description("Mg")]
        Miligram = 2,
        [Description("G")]
        Gram = 3,
        [Description("Kg")]
        Kilogram = 4,
        [Description("Lt")]
        Liter = 5
    }
}
