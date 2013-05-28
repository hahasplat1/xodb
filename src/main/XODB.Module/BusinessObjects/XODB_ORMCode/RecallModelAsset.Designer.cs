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

    [Persistent(@"Q_RecallModelAsset")]
    public partial class RecallModelAsset : XPLiteObject
    {
        Guid fRecallModelAssetID;
        [Key(true)]
        public Guid RecallModelAssetID
        {
            get { return fRecallModelAssetID; }
            set { SetPropertyValue<Guid>("RecallModelAssetID", ref fRecallModelAssetID, value); }
        }
        RecallModel fRecallModelID;
        [Association(@"RecallModelAssetReferencesRecallModel")]
        public RecallModel RecallModelID
        {
            get { return fRecallModelID; }
            set { SetPropertyValue<RecallModel>("RecallModelID", ref fRecallModelID, value); }
        }
        Asset fAssetID;
        [Association(@"RecallModelAssetReferencesAsset")]
        public Asset AssetID
        {
            get { return fAssetID; }
            set { SetPropertyValue<Asset>("AssetID", ref fAssetID, value); }
        }
        ProjectPlan fProjectPlanID;
        [Association(@"RecallModelAssetReferencesProjectPlan")]
        public ProjectPlan ProjectPlanID
        {
            get { return fProjectPlanID; }
            set { SetPropertyValue<ProjectPlan>("ProjectPlanID", ref fProjectPlanID, value); }
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