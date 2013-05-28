//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace XODB.Module.BusinessObjects.XODB
{

    [Persistent(@"Q_ModelProcedureTaskPart")]
    public partial class ModelProcedureTaskPart : XPLiteObject
    {
        Guid fModelProcedureTaskPartID;
        [Key(true)]
        public Guid ModelProcedureTaskPartID
        {
            get { return fModelProcedureTaskPartID; }
            set { SetPropertyValue<Guid>("ModelProcedureTaskPartID", ref fModelProcedureTaskPartID, value); }
        }
        ModelProcedureTask fModelProcedureTaskID;
        [Association(@"ModelProcedureTaskPartReferencesQ_ModelProcedureTask")]
        public ModelProcedureTask ModelProcedureTaskID
        {
            get { return fModelProcedureTaskID; }
            set { SetPropertyValue<ModelProcedureTask>("ModelProcedureTaskID", ref fModelProcedureTaskID, value); }
        }
        DictionaryPart fPartID;
        [Association(@"ModelProcedureTaskPartReferencesQ_DictionaryPart")]
        public DictionaryPart PartID
        {
            get { return fPartID; }
            set { SetPropertyValue<DictionaryPart>("PartID", ref fPartID, value); }
        }
        decimal fPartQuantity;
        public decimal PartQuantity
        {
            get { return fPartQuantity; }
            set { SetPropertyValue<decimal>("PartQuantity", ref fPartQuantity, value); }
        }
        int fVersion;
        public int Version
        {
            get { return fVersion; }
            set { SetPropertyValue<int>("Version", ref fVersion, value); }
        }
        Guid fVersionAntecedentID;
        public Guid VersionAntecedentID
        {
            get { return fVersionAntecedentID; }
            set { SetPropertyValue<Guid>("VersionAntecedentID", ref fVersionAntecedentID, value); }
        }
        int fVersionCertainty;
        public int VersionCertainty
        {
            get { return fVersionCertainty; }
            set { SetPropertyValue<int>("VersionCertainty", ref fVersionCertainty, value); }
        }
        Guid fVersionWorkflowInstanceID;
        public Guid VersionWorkflowInstanceID
        {
            get { return fVersionWorkflowInstanceID; }
            set { SetPropertyValue<Guid>("VersionWorkflowInstanceID", ref fVersionWorkflowInstanceID, value); }
        }
        Guid fVersionUpdatedBy;
        public Guid VersionUpdatedBy
        {
            get { return fVersionUpdatedBy; }
            set { SetPropertyValue<Guid>("VersionUpdatedBy", ref fVersionUpdatedBy, value); }
        }
        Guid fVersionDeletedBy;
        public Guid VersionDeletedBy
        {
            get { return fVersionDeletedBy; }
            set { SetPropertyValue<Guid>("VersionDeletedBy", ref fVersionDeletedBy, value); }
        }
        Guid fVersionOwnerContactID;
        public Guid VersionOwnerContactID
        {
            get { return fVersionOwnerContactID; }
            set { SetPropertyValue<Guid>("VersionOwnerContactID", ref fVersionOwnerContactID, value); }
        }
        Guid fVersionOwnerCompanyID;
        public Guid VersionOwnerCompanyID
        {
            get { return fVersionOwnerCompanyID; }
            set { SetPropertyValue<Guid>("VersionOwnerCompanyID", ref fVersionOwnerCompanyID, value); }
        }
        DateTime fVersionUpdated;
        public DateTime VersionUpdated
        {
            get { return fVersionUpdated; }
            set { SetPropertyValue<DateTime>("VersionUpdated", ref fVersionUpdated, value); }
        }
    }

}