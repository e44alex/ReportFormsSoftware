﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Diplom.Shared.Model
{
    class ReportPeriod
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
