﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OperationsAlertManager.Repository.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AlertsManagerModelContainer : DbContext
    {
        public AlertsManagerModelContainer()
            : base("name=AlertsManagerModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int INSERT_ALRT(string aLRT_SS_NME, Nullable<int> aLRT_SS_ID, string aLRT_SS_KEY_TXT, Nullable<System.DateTime> aLRT_SS_CRE_DTTM, Nullable<int> fAC_ID, string aLRT_SS_DTL_TXT, Nullable<int> mGMT_PLNT_FAC_ID, ObjectParameter rETVAL)
        {
            var aLRT_SS_NMEParameter = aLRT_SS_NME != null ?
                new ObjectParameter("ALRT_SS_NME", aLRT_SS_NME) :
                new ObjectParameter("ALRT_SS_NME", typeof(string));
    
            var aLRT_SS_IDParameter = aLRT_SS_ID.HasValue ?
                new ObjectParameter("ALRT_SS_ID", aLRT_SS_ID) :
                new ObjectParameter("ALRT_SS_ID", typeof(int));
    
            var aLRT_SS_KEY_TXTParameter = aLRT_SS_KEY_TXT != null ?
                new ObjectParameter("ALRT_SS_KEY_TXT", aLRT_SS_KEY_TXT) :
                new ObjectParameter("ALRT_SS_KEY_TXT", typeof(string));
    
            var aLRT_SS_CRE_DTTMParameter = aLRT_SS_CRE_DTTM.HasValue ?
                new ObjectParameter("ALRT_SS_CRE_DTTM", aLRT_SS_CRE_DTTM) :
                new ObjectParameter("ALRT_SS_CRE_DTTM", typeof(System.DateTime));
    
            var fAC_IDParameter = fAC_ID.HasValue ?
                new ObjectParameter("FAC_ID", fAC_ID) :
                new ObjectParameter("FAC_ID", typeof(int));
    
            var aLRT_SS_DTL_TXTParameter = aLRT_SS_DTL_TXT != null ?
                new ObjectParameter("ALRT_SS_DTL_TXT", aLRT_SS_DTL_TXT) :
                new ObjectParameter("ALRT_SS_DTL_TXT", typeof(string));
    
            var mGMT_PLNT_FAC_IDParameter = mGMT_PLNT_FAC_ID.HasValue ?
                new ObjectParameter("MGMT_PLNT_FAC_ID", mGMT_PLNT_FAC_ID) :
                new ObjectParameter("MGMT_PLNT_FAC_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_ALRT", aLRT_SS_NMEParameter, aLRT_SS_IDParameter, aLRT_SS_KEY_TXTParameter, aLRT_SS_CRE_DTTMParameter, fAC_IDParameter, aLRT_SS_DTL_TXTParameter, mGMT_PLNT_FAC_IDParameter, rETVAL);
        }
    }
}
