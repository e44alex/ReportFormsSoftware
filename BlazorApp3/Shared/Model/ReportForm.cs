using System;
using System.Collections.Generic;
using System.Text;

namespace Diplom.Shared.Model
{
    public enum FormType
    {
       PERIODIC,
       NON_PERIODIC
    }

    public enum PeriodicFormType
    {
        MONTH,
        QUARTER,
        HALF_YEAR,
        YEAR
    }

    public enum FormState
    {
        CLEAR,
        IN_WORK,
        FILLED,
        CHECKED,
        SUBMITTED
    }

    public class ReportForm
    {
        public Guid FormHeadId { get; set; }
        public Guid FormDataId{ get; set; }

        public ReportFormHead FormHead { get; set; }
        public ReportFormData FormData { get; set; }
        public FormState State{ get; set; }
    }

    public class ReportFormHead
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
        public int OrganisationId { get; set; }
        public Organisation Organisation { get; set; }
        public ReportPeriod ReportPeriod { get; set; }
    }

    public class ReportFormData
    {
        //PrimaryKey
        public Guid FormHeadId { get; set; }
        public ReportFormHead FormHead { get; set; }
        public Guid ReportPeriodId { get; set; }
        public ReportPeriod ReportPeriod { get; set; }

        //fields
        public string RowCode { get; set; }

        public string C1 { get; set; }
        public string C2 { get; set; }
        public string C3 { get; set; }
        public string C4 { get; set; }
        public string C5 { get; set; }
        public string C6 { get; set; }
        public string C7 { get; set; }
        public string C8 { get; set; }
        public string C9 { get; set; }
        public string C10 { get; set; }
        public string C11 { get; set; }
        public string C12 { get; set; }
        public string C13 { get; set; }
        public string C14 { get; set; }
        public string C15 { get; set; }
        public string C16 { get; set; }
        public string C17 { get; set; }
        public string C18 { get; set; }
        public string C19 { get; set; }
        public string C20 { get; set; }
        public string C21 { get; set; }
        public string C22 { get; set; }
    }
}
