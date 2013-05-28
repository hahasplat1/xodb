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

    [Persistent(@"Q_WarehousePartSupplier")]
    public partial class WarehousePartSupplier : XPLiteObject
    {
        Guid fWarehousePartSupplierID;
        [Key(true)]
        public Guid WarehousePartSupplierID
        {
            get { return fWarehousePartSupplierID; }
            set { SetPropertyValue<Guid>("WarehousePartSupplierID", ref fWarehousePartSupplierID, value); }
        }
        WarehousePart fWarehousePartID;
        [Association(@"WarehousePartSupplierReferencesQ_WarehousePart")]
        public WarehousePart WarehousePartID
        {
            get { return fWarehousePartID; }
            set { SetPropertyValue<WarehousePart>("WarehousePartID", ref fWarehousePartID, value); }
        }
        SupplierPart fSupplierPartID;
        [Association(@"WarehousePartSupplierReferencesSupplierPart")]
        public SupplierPart SupplierPartID
        {
            get { return fSupplierPartID; }
            set { SetPropertyValue<SupplierPart>("SupplierPartID", ref fSupplierPartID, value); }
        }
        DictionaryUnit fQuantityUnitID;
        [Association(@"WarehousePartSupplierReferencesDictionaryUnit")]
        public DictionaryUnit QuantityUnitID
        {
            get { return fQuantityUnitID; }
            set { SetPropertyValue<DictionaryUnit>("QuantityUnitID", ref fQuantityUnitID, value); }
        }
        decimal fQuantityOrdered;
        public decimal QuantityOrdered
        {
            get { return fQuantityOrdered; }
            set { SetPropertyValue<decimal>("QuantityOrdered", ref fQuantityOrdered, value); }
        }
        DateTime fOrdered;
        public DateTime Ordered
        {
            get { return fOrdered; }
            set { SetPropertyValue<DateTime>("Ordered", ref fOrdered, value); }
        }
        DateTime fReceived;
        public DateTime Received
        {
            get { return fReceived; }
            set { SetPropertyValue<DateTime>("Received", ref fReceived, value); }
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