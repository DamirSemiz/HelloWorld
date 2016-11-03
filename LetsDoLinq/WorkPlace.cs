using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsDoLinq
{
    class WorkPlace
    {
        public string CompanyName { get; set; }
        public int WorkPlaceID { get; set; }

        public WorkPlace(string companyName, int workPlaceID)
        {
            CompanyName = companyName;
            WorkPlaceID = workPlaceID;
        }

        public override string ToString()
        {
            return $"Company: {CompanyName}";
        }
    }
}
