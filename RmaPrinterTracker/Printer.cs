using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmaPrinterTracker
{
    class Printer
    {
        public int Rmaid { get; set; }
        public string Company { get; set; }
        public string Closed { get; set; }
        public DateTime Issue_date { get; set; }
        public string Faultysn { get; set; }
        public string Replacementsn { get; set; }
        public DateTime Returned_date { get; set; }
        public string Notes { get; set; }
        public string Diagnosis { get; set; }
        public bool Bulkink { get; set; }
        public string Issue_category { get; set; }
        public string Result { get; set; }
        public bool Approved { get; set; }
        public int Printertypeid;
        public int Printerstage;

        public Printer()
        {

        }

        public Printer(int rmaid, string company, string closed, DateTime issue_date, string faultysn, string replacementsn, DateTime returned_date, 
            string notes, string diagnosis, bool bulkink, string issue_category, string result, bool approved, int printertypeid, int printerstage)
        {
            Rmaid = rmaid;
            Company = company;
            Closed = closed;
            Issue_date = issue_date;
            Faultysn = faultysn;
            Replacementsn = replacementsn;
            Returned_date = returned_date;
            Notes = notes;
            Diagnosis = diagnosis;
            Bulkink = bulkink;
            Issue_category = issue_category;
            Result = result;
            Approved = approved;
            Printertypeid = printertypeid;
            Printerstage = printerstage;
        }
    }
}
