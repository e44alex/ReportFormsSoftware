using System;
using System.Collections.Generic;
using System.Text;

namespace Diplom.Shared.Model
{
    enum FormType
    {
       PERIODIC,
       NON_PERIODIC
    }

    enum PeriodicFormType
    {
        MOUNTH,
        QUARTER,
        HALF_YEAR,
        YEAR
    }

    class ReportFormHead
    {
        public Guid Id { get; set; }
        public int Cls { get; set; } // классификатор
        public int Code { get; set; }//код
        public int Chapter { get; set; }//глава
        public int Paragraph { get; set; }//параграф
        public int SubPragraph { get; set; }//ПодПараграф
        public int Program { get; set; }//Программа
        public int SubProgram { get; set; }//Под Программа
        public FormType Type { get; set; }
        public PeriodicFormType PeriodicType { get; set; }
    }

    class ReportFormData
    {


        public ReportFormHead FormHead { get; set; }
        public Organisation Organisation { get; set; }
        public int MyProperty { get; set; }
    }
}
