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

    [Persistent(@"X_DictionaryModel")]
    public partial class DictionaryModel : XPLiteObject
    {
        Guid fModelID;
        [Key(true)]
        public Guid ModelID
        {
            get { return fModelID; }
            set { SetPropertyValue<Guid>("ModelID", ref fModelID, value); }
        }
        DictionaryModel fParentModelID;
        [Association(@"DictionaryModelReferencesX_DictionaryModel")]
        public DictionaryModel ParentModelID
        {
            get { return fParentModelID; }
            set { SetPropertyValue<DictionaryModel>("ParentModelID", ref fParentModelID, value); }
        }
        string fStandardModelName;
        [Size(60)]
        public string StandardModelName
        {
            get { return fStandardModelName; }
            set { SetPropertyValue<string>("StandardModelName", ref fStandardModelName, value); }
        }
        string fEcriModelName;
        [Size(60)]
        public string EcriModelName
        {
            get { return fEcriModelName; }
            set { SetPropertyValue<string>("EcriModelName", ref fEcriModelName, value); }
        }
        string fCustomModelName;
        [Size(60)]
        public string CustomModelName
        {
            get { return fCustomModelName; }
            set { SetPropertyValue<string>("CustomModelName", ref fCustomModelName, value); }
        }
        Company fCompanyID;
        [Association(@"DictionaryModelReferencesCompany")]
        public Company CompanyID
        {
            get { return fCompanyID; }
            set { SetPropertyValue<Company>("CompanyID", ref fCompanyID, value); }
        }
        string fOriginalManufacturerName;
        [Size(255)]
        public string OriginalManufacturerName
        {
            get { return fOriginalManufacturerName; }
            set { SetPropertyValue<string>("OriginalManufacturerName", ref fOriginalManufacturerName, value); }
        }
        DictionaryModelStatus fModelStatusID;
        [Association(@"DictionaryModelReferencesDictionaryModelStatus")]
        public DictionaryModelStatus ModelStatusID
        {
            get { return fModelStatusID; }
            set { SetPropertyValue<DictionaryModelStatus>("ModelStatusID", ref fModelStatusID, value); }
        }
        DictionaryDeviceType fDeviceTypeID;
        [Association(@"DictionaryModelReferencesDictionaryDeviceType")]
        public DictionaryDeviceType DeviceTypeID
        {
            get { return fDeviceTypeID; }
            set { SetPropertyValue<DictionaryDeviceType>("DeviceTypeID", ref fDeviceTypeID, value); }
        }
        bool fIsMake;
        public bool IsMake
        {
            get { return fIsMake; }
            set { SetPropertyValue<bool>("IsMake", ref fIsMake, value); }
        }
        DateTime fManufacturedFrom;
        public DateTime ManufacturedFrom
        {
            get { return fManufacturedFrom; }
            set { SetPropertyValue<DateTime>("ManufacturedFrom", ref fManufacturedFrom, value); }
        }
        DateTime fManufacturedUntil;
        public DateTime ManufacturedUntil
        {
            get { return fManufacturedUntil; }
            set { SetPropertyValue<DateTime>("ManufacturedUntil", ref fManufacturedUntil, value); }
        }
        DateTime fSupportedUntil;
        public DateTime SupportedUntil
        {
            get { return fSupportedUntil; }
            set { SetPropertyValue<DateTime>("SupportedUntil", ref fSupportedUntil, value); }
        }
        DictionaryUnit fEstimatedLifetimeUnitID;
        [Association(@"DictionaryModelReferencesDictionaryUnit")]
        public DictionaryUnit EstimatedLifetimeUnitID
        {
            get { return fEstimatedLifetimeUnitID; }
            set { SetPropertyValue<DictionaryUnit>("EstimatedLifetimeUnitID", ref fEstimatedLifetimeUnitID, value); }
        }
        decimal fEstimatedLifetime;
        public decimal EstimatedLifetime
        {
            get { return fEstimatedLifetime; }
            set { SetPropertyValue<decimal>("EstimatedLifetime", ref fEstimatedLifetime, value); }
        }
        string fDescription;
        [Size(255)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        string fFullDescription;
        [Size(SizeAttribute.Unlimited)]
        public string FullDescription
        {
            get { return fFullDescription; }
            set { SetPropertyValue<string>("FullDescription", ref fFullDescription, value); }
        }
        byte[] fThumbnail;
        [Size(SizeAttribute.Unlimited)]
        public byte[] Thumbnail
        {
            get { return fThumbnail; }
            set { SetPropertyValue<byte[]>("Thumbnail", ref fThumbnail, value); }
        }
        FileData fOriginalFileDataID;
        [Association(@"DictionaryModelReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
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
        [Association(@"SurveyReferencesX_DictionaryModel", typeof(Survey))]
        public XPCollection<Survey> Surveys { get { return GetCollection<Survey>("Surveys"); } }
        [Association(@"RecallModelReferencesX_DictionaryModel", typeof(RecallModel))]
        public XPCollection<RecallModel> RecallModels { get { return GetCollection<RecallModel>("RecallModels"); } }
        [Association(@"ModelScheduleCycleReferencesX_DictionaryModel", typeof(ModelScheduleCycle))]
        public XPCollection<ModelScheduleCycle> ModelScheduleCycles { get { return GetCollection<ModelScheduleCycle>("ModelScheduleCycles"); } }
        [Association(@"ModelPartReferencesX_DictionaryModel", typeof(ModelPart))]
        public XPCollection<ModelPart> ModelParts { get { return GetCollection<ModelPart>("ModelParts"); } }
        [Association(@"ModelWarrantyReferencesX_DictionaryModel", typeof(ModelWarranty))]
        public XPCollection<ModelWarranty> ModelWarranties { get { return GetCollection<ModelWarranty>("ModelWarranties"); } }
        [Association(@"AssetReferencesX_DictionaryModel", typeof(Asset))]
        public XPCollection<Asset> Assets { get { return GetCollection<Asset>("Assets"); } }
        [Association(@"ModelProcedureReferencesX_DictionaryModel", typeof(ModelProcedure))]
        public XPCollection<ModelProcedure> ModelProcedures { get { return GetCollection<ModelProcedure>("ModelProcedures"); } }
        [Association(@"WarehouseModelReferencesX_DictionaryModel", typeof(WarehouseModel))]
        public XPCollection<WarehouseModel> WarehouseModels { get { return GetCollection<WarehouseModel>("WarehouseModels"); } }
        [Association(@"CostEstimateModelReferencesX_DictionaryModel", typeof(CostEstimateModel))]
        public XPCollection<CostEstimateModel> CostEstimateModels { get { return GetCollection<CostEstimateModel>("CostEstimateModels"); } }
        [Association(@"DictionaryModelCategoryReferencesX_DictionaryModel", typeof(DictionaryModelCategory))]
        public XPCollection<DictionaryModelCategory> DictionaryModelCategories { get { return GetCollection<DictionaryModelCategory>("DictionaryModelCategories"); } }
        [Association(@"ModelCharacteristicReferencesX_DictionaryModel", typeof(ModelCharacteristic))]
        public XPCollection<ModelCharacteristic> ModelCharacteristics { get { return GetCollection<ModelCharacteristic>("ModelCharacteristics"); } }
        [Association(@"ProjectPlanTaskModelReferencesX_DictionaryModel", typeof(ProjectPlanTaskModel))]
        public XPCollection<ProjectPlanTaskModel> ProjectPlanTaskModels { get { return GetCollection<ProjectPlanTaskModel>("ProjectPlanTaskModels"); } }
        [Association(@"ContractConditionModelReferencesX_DictionaryModel", typeof(ContractConditionModel))]
        public XPCollection<ContractConditionModel> ContractConditionModels { get { return GetCollection<ContractConditionModel>("ContractConditionModels"); } }
        [Association(@"SupplierModelReferencesX_DictionaryModel", typeof(SupplierModel))]
        public XPCollection<SupplierModel> SupplierModels { get { return GetCollection<SupplierModel>("SupplierModels"); } }
        [Association(@"DictionaryModelReferencesX_DictionaryModel", typeof(DictionaryModel))]
        public XPCollection<DictionaryModel> DictionaryModelCollection { get { return GetCollection<DictionaryModel>("DictionaryModelCollection"); } }
    }

}