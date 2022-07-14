using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOnboarding.Core.Dto
{
    public class GoldResponse
    {
        public Gold result { get; set; }
        public string errorMessage { get; set; }
        public string[] errorMessages { get; set; }
        public bool hasError { get; set; }
        public DateTime timeGenerated { get; set; }
    }

    public class Gold
    {
        public decimal gold { get; set; }
        public decimal silver { get; set; }
    }

}
