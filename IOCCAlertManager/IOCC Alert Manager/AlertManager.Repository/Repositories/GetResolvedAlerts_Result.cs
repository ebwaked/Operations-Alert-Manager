//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OperationsAlertManager.Data.Repositories
{
    using System;
    
    public partial class GetResolvedAlerts_Result
    {
        public int ALRT_ID { get; set; }
        public System.DateTime ALRT_CRE_DTTM { get; set; }
        public Nullable<int> ALRT_CRTR_PRSN_BUS_ENTY_ID { get; set; }
        public Nullable<int> ALRT_RPTD_PRSN_BUS_ENTY_ID { get; set; }
        public string ALRT_SS_NME { get; set; }
        public string ALRT_SS_DESC { get; set; }
        public Nullable<int> ALRT_SS_ID { get; set; }
        public int ALRT_PRIO_TYPE_ID { get; set; }
        public string ALRT_PRIO_TYPE_NME { get; set; }
        public string ALRT_PRIO_TYPE_DESC { get; set; }
        public int ALRT_TYPE_ID { get; set; }
        public string ALRT_TYPE_DESC { get; set; }
        public string ALRT_TYPE_NME { get; set; }
        public Nullable<System.DateTime> ALRT_RSLN_DTTM { get; set; }
        public Nullable<int> ALRT_RSLN_TYPE_ID { get; set; }
        public Nullable<int> RSLV_BY_PRSN_BUS_ENTY_ID { get; set; }
        public string ALRT_RSLN_DESC { get; set; }
        public string ALRT_NOTE_TXT { get; set; }
        public string ALRT_SS_DTL_TXT { get; set; }
        public string ALRT_RSLN_TYPE_NME { get; set; }
        public string ALRT_RSLN_TYPE_DESC { get; set; }
    }
}
