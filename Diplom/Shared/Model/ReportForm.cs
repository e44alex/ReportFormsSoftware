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
    
    enum FormState
    {
        CLEAR,
        IN_WORK,
        FILLED,
        CHECKED,
        SUBMITTED
    }

    class ReportForm
    {
        public ReportFormHead FormHead { get; set; }
        public ReportFormData FormData { get; set; }
        public FormState State{ get; set; }
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
        //PrimaryKey
        public ReportFormHead FormHead { get; set; }
        public Organisation Organisation { get; set; }
        public ReportPeriod ReportPeriod { get; set; }

        //fields
        public string RowCode { get; set; }

        public decimal C1 { get; set; }
        public decimal C2 { get; set; }
        public decimal C3 { get; set; }
        public decimal C4 { get; set; }
        public decimal C5 { get; set; }
        public decimal C6 { get; set; }
        public decimal C7 { get; set; }
        public decimal C8 { get; set; }
        public decimal C9 { get; set; }
        public decimal C10 { get; set; }
        public decimal C11 { get; set; }
        public decimal C12 { get; set; }
        public decimal C13 { get; set; }
        public decimal C14 { get; set; }
        public decimal C15 { get; set; }
        public decimal C16 { get; set; }
        public decimal C17 { get; set; }
        public decimal C18 { get; set; }
        public decimal C19 { get; set; }
        public decimal C20 { get; set; }
        public decimal C21 { get; set; }
        public decimal C22 { get; set; }
    }
}
