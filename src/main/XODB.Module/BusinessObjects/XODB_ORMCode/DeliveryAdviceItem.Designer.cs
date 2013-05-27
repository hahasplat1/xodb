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

    [Persistent(@"Q_DeliveryAdviceItem")]
    public partial class DeliveryAdviceItem : XPLiteObject
    {
        Guid fDeliveryAdviceItemID;
        [Key(true)]
        public Guid DeliveryAdviceItemID
        {
            get { return fDeliveryAdviceItemID; }
            set { SetPropertyValue<Guid>("DeliveryAdviceItemID", ref fDeliveryAdviceItemID, value); }
        }
        DeliveryAdvice fDeliveryAdviceID;
        [Association(@"DeliveryAdviceItemReferencesQ_DeliveryAdvice")]
        public DeliveryAdvice DeliveryAdviceID
        {
            get { return fDeliveryAdviceID; }
            set { SetPropertyValue<DeliveryAdvice>("DeliveryAdviceID", ref fDeliveryAdviceID, value); }
        }
        Asset fAssetID;
        [Association(@"DeliveryAdviceItemReferencesQ_Asset")]
        public Asset AssetID
        {
            get { return fAssetID; }
            set { SetPropertyValue<Asset>("AssetID", ref fAssetID, value); }
        }
        string fItemDescription;
        public string ItemDescription
        {
            get { return fItemDescription; }
            set { SetPropertyValue<string>("ItemDescription", ref fItemDescription, value); }
        }
        DictionaryPart fPartID;
        [Association(@"DeliveryAdviceItemReferencesQ_DictionaryPart")]
        public DictionaryPart PartID
        {
            get { return fPartID; }
            set { SetPropertyValue<DictionaryPart>("PartID", ref fPartID, value); }
        }
        decimal fQuantitySent;
        public decimal QuantitySent
        {
            get { return fQuantitySent; }
            set { SetPropertyValue<decimal>("QuantitySent", ref fQuantitySent, value); }
        }
        decimal fQuantityReceived;
        public decimal QuantityReceived
        {
            get { return fQuantityReceived; }
            set { SetPropertyValue<decimal>("QuantityReceived", ref fQuantityReceived, value); }
        }
        string fReturnReferenceNumber;
        [Size(60)]
        public string ReturnReferenceNumber
        {
            get { return fReturnReferenceNumber; }
            set { SetPropertyValue<string>("ReturnReferenceNumber", ref fReturnReferenceNumber, value); }
        }
        string fItemInstruction;
        [Size(SizeAttribute.Unlimited)]
        public string ItemInstruction
        {
            get { return fItemInstruction; }
            set { SetPropertyValue<string>("ItemInstruction", ref fItemInstruction, value); }
        }
        DictionaryDecontaminationStatus fDecontaminationStatusID;
        [Association(@"DeliveryAdviceItemReferencesQ_DictionaryDecontaminationStatus")]
        public DictionaryDecontaminationStatus DecontaminationStatusID
        {
            get { return fDecontaminationStatusID; }
            set { SetPropertyValue<DictionaryDecontaminationStatus>("DecontaminationStatusID", ref fDecontaminationStatusID, value); }
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
