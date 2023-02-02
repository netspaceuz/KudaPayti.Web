using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kudapoyti.Service.Common.Exceptions;

public class ModelErrorException:Exception
{
    public string Property { get; set; }=String.Empty;
    
    public ModelErrorException(string exModel, string message):base(message)
    {
        this.Property = exModel;
    }
}
