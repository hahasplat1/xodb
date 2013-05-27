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

    [Persistent(@"X_BlockModelBlock")]
    public partial class BlockModelBlock : XPLiteObject
    {
        Guid fBlockModelBlockID;
        [Key(true)]
        public Guid BlockModelBlockID
        {
            get { return fBlockModelBlockID; }
            set { SetPropertyValue<Guid>("BlockModelBlockID", ref fBlockModelBlockID, value); }
        }
        BlockModel fBlockModelID;
        [Indexed(@"CentroidX;CentroidY;CentroidZ", Name = @"NonClusteredIndex-20130213-121247")]
        [Association(@"BlockModelBlockReferencesBlockModel")]
        public BlockModel BlockModelID
        {
            get { return fBlockModelID; }
            set { SetPropertyValue<BlockModel>("BlockModelID", ref fBlockModelID, value); }
        }
        string fDomain;
        [Size(50)]
        public string Domain
        {
            get { return fDomain; }
            set { SetPropertyValue<string>("Domain", ref fDomain, value); }
        }
        int fI;
        public int I
        {
            get { return fI; }
            set { SetPropertyValue<int>("I", ref fI, value); }
        }
        int fJ;
        public int J
        {
            get { return fJ; }
            set { SetPropertyValue<int>("J", ref fJ, value); }
        }
        int fK;
        public int K
        {
            get { return fK; }
            set { SetPropertyValue<int>("K", ref fK, value); }
        }
        decimal fCentroidX;
        public decimal CentroidX
        {
            get { return fCentroidX; }
            set { SetPropertyValue<decimal>("CentroidX", ref fCentroidX, value); }
        }
        decimal fCentroidY;
        public decimal CentroidY
        {
            get { return fCentroidY; }
            set { SetPropertyValue<decimal>("CentroidY", ref fCentroidY, value); }
        }
        decimal fCentroidZ;
        public decimal CentroidZ
        {
            get { return fCentroidZ; }
            set { SetPropertyValue<decimal>("CentroidZ", ref fCentroidZ, value); }
        }
        decimal fLengthX;
        public decimal LengthX
        {
            get { return fLengthX; }
            set { SetPropertyValue<decimal>("LengthX", ref fLengthX, value); }
        }
        decimal fLengthY;
        public decimal LengthY
        {
            get { return fLengthY; }
            set { SetPropertyValue<decimal>("LengthY", ref fLengthY, value); }
        }
        decimal fLengthZ;
        public decimal LengthZ
        {
            get { return fLengthZ; }
            set { SetPropertyValue<decimal>("LengthZ", ref fLengthZ, value); }
        }
        int fMinimumSamples;
        public int MinimumSamples
        {
            get { return fMinimumSamples; }
            set { SetPropertyValue<int>("MinimumSamples", ref fMinimumSamples, value); }
        }
        int fMaximumSamples;
        public int MaximumSamples
        {
            get { return fMaximumSamples; }
            set { SetPropertyValue<int>("MaximumSamples", ref fMaximumSamples, value); }
        }
        string fEstimationTechnique;
        [Size(50)]
        public string EstimationTechnique
        {
            get { return fEstimationTechnique; }
            set { SetPropertyValue<string>("EstimationTechnique", ref fEstimationTechnique, value); }
        }
        decimal fKrigingEfficiency;
        public decimal KrigingEfficiency
        {
            get { return fKrigingEfficiency; }
            set { SetPropertyValue<decimal>("KrigingEfficiency", ref fKrigingEfficiency, value); }
        }
        decimal fKrigingError;
        public decimal KrigingError
        {
            get { return fKrigingError; }
            set { SetPropertyValue<decimal>("KrigingError", ref fKrigingError, value); }
        }
        decimal fKrigingVariance;
        public decimal KrigingVariance
        {
            get { return fKrigingVariance; }
            set { SetPropertyValue<decimal>("KrigingVariance", ref fKrigingVariance, value); }
        }
        decimal fSlopeOfRegression;
        public decimal SlopeOfRegression
        {
            get { return fSlopeOfRegression; }
            set { SetPropertyValue<decimal>("SlopeOfRegression", ref fSlopeOfRegression, value); }
        }
        decimal fDensity;
        public decimal Density
        {
            get { return fDensity; }
            set { SetPropertyValue<decimal>("Density", ref fDensity, value); }
        }
        string fResourceCategory;
        [Size(50)]
        public string ResourceCategory
        {
            get { return fResourceCategory; }
            set { SetPropertyValue<string>("ResourceCategory", ref fResourceCategory, value); }
        }
        decimal fNumeric1;
        public decimal Numeric1
        {
            get { return fNumeric1; }
            set { SetPropertyValue<decimal>("Numeric1", ref fNumeric1, value); }
        }
        decimal fNumeric2;
        public decimal Numeric2
        {
            get { return fNumeric2; }
            set { SetPropertyValue<decimal>("Numeric2", ref fNumeric2, value); }
        }
        decimal fNumeric3;
        public decimal Numeric3
        {
            get { return fNumeric3; }
            set { SetPropertyValue<decimal>("Numeric3", ref fNumeric3, value); }
        }
        decimal fNumeric4;
        public decimal Numeric4
        {
            get { return fNumeric4; }
            set { SetPropertyValue<decimal>("Numeric4", ref fNumeric4, value); }
        }
        decimal fNumeric5;
        public decimal Numeric5
        {
            get { return fNumeric5; }
            set { SetPropertyValue<decimal>("Numeric5", ref fNumeric5, value); }
        }
        decimal fNumeric6;
        public decimal Numeric6
        {
            get { return fNumeric6; }
            set { SetPropertyValue<decimal>("Numeric6", ref fNumeric6, value); }
        }
        decimal fNumeric7;
        public decimal Numeric7
        {
            get { return fNumeric7; }
            set { SetPropertyValue<decimal>("Numeric7", ref fNumeric7, value); }
        }
        decimal fNumeric8;
        public decimal Numeric8
        {
            get { return fNumeric8; }
            set { SetPropertyValue<decimal>("Numeric8", ref fNumeric8, value); }
        }
        decimal fNumeric9;
        public decimal Numeric9
        {
            get { return fNumeric9; }
            set { SetPropertyValue<decimal>("Numeric9", ref fNumeric9, value); }
        }
        decimal fNumeric10;
        public decimal Numeric10
        {
            get { return fNumeric10; }
            set { SetPropertyValue<decimal>("Numeric10", ref fNumeric10, value); }
        }
        decimal fNumeric11;
        public decimal Numeric11
        {
            get { return fNumeric11; }
            set { SetPropertyValue<decimal>("Numeric11", ref fNumeric11, value); }
        }
        decimal fNumeric12;
        public decimal Numeric12
        {
            get { return fNumeric12; }
            set { SetPropertyValue<decimal>("Numeric12", ref fNumeric12, value); }
        }
        decimal fNumeric13;
        public decimal Numeric13
        {
            get { return fNumeric13; }
            set { SetPropertyValue<decimal>("Numeric13", ref fNumeric13, value); }
        }
        decimal fNumeric14;
        public decimal Numeric14
        {
            get { return fNumeric14; }
            set { SetPropertyValue<decimal>("Numeric14", ref fNumeric14, value); }
        }
        decimal fNumeric15;
        public decimal Numeric15
        {
            get { return fNumeric15; }
            set { SetPropertyValue<decimal>("Numeric15", ref fNumeric15, value); }
        }
        decimal fNumeric16;
        public decimal Numeric16
        {
            get { return fNumeric16; }
            set { SetPropertyValue<decimal>("Numeric16", ref fNumeric16, value); }
        }
        decimal fNumeric17;
        public decimal Numeric17
        {
            get { return fNumeric17; }
            set { SetPropertyValue<decimal>("Numeric17", ref fNumeric17, value); }
        }
        decimal fNumeric18;
        public decimal Numeric18
        {
            get { return fNumeric18; }
            set { SetPropertyValue<decimal>("Numeric18", ref fNumeric18, value); }
        }
        decimal fNumeric19;
        public decimal Numeric19
        {
            get { return fNumeric19; }
            set { SetPropertyValue<decimal>("Numeric19", ref fNumeric19, value); }
        }
        decimal fNumeric20;
        public decimal Numeric20
        {
            get { return fNumeric20; }
            set { SetPropertyValue<decimal>("Numeric20", ref fNumeric20, value); }
        }
        decimal fNumeric21;
        public decimal Numeric21
        {
            get { return fNumeric21; }
            set { SetPropertyValue<decimal>("Numeric21", ref fNumeric21, value); }
        }
        decimal fNumeric22;
        public decimal Numeric22
        {
            get { return fNumeric22; }
            set { SetPropertyValue<decimal>("Numeric22", ref fNumeric22, value); }
        }
        decimal fNumeric23;
        public decimal Numeric23
        {
            get { return fNumeric23; }
            set { SetPropertyValue<decimal>("Numeric23", ref fNumeric23, value); }
        }
        decimal fNumeric24;
        public decimal Numeric24
        {
            get { return fNumeric24; }
            set { SetPropertyValue<decimal>("Numeric24", ref fNumeric24, value); }
        }
        decimal fNumeric25;
        public decimal Numeric25
        {
            get { return fNumeric25; }
            set { SetPropertyValue<decimal>("Numeric25", ref fNumeric25, value); }
        }
        decimal fNumeric26;
        public decimal Numeric26
        {
            get { return fNumeric26; }
            set { SetPropertyValue<decimal>("Numeric26", ref fNumeric26, value); }
        }
        decimal fNumeric27;
        public decimal Numeric27
        {
            get { return fNumeric27; }
            set { SetPropertyValue<decimal>("Numeric27", ref fNumeric27, value); }
        }
        decimal fNumeric28;
        public decimal Numeric28
        {
            get { return fNumeric28; }
            set { SetPropertyValue<decimal>("Numeric28", ref fNumeric28, value); }
        }
        decimal fNumeric29;
        public decimal Numeric29
        {
            get { return fNumeric29; }
            set { SetPropertyValue<decimal>("Numeric29", ref fNumeric29, value); }
        }
        decimal fNumeric30;
        public decimal Numeric30
        {
            get { return fNumeric30; }
            set { SetPropertyValue<decimal>("Numeric30", ref fNumeric30, value); }
        }
        decimal fNumeric31;
        public decimal Numeric31
        {
            get { return fNumeric31; }
            set { SetPropertyValue<decimal>("Numeric31", ref fNumeric31, value); }
        }
        string fString1;
        [Size(50)]
        public string String1
        {
            get { return fString1; }
            set { SetPropertyValue<string>("String1", ref fString1, value); }
        }
        string fString2;
        [Size(50)]
        public string String2
        {
            get { return fString2; }
            set { SetPropertyValue<string>("String2", ref fString2, value); }
        }
        string fString3;
        [Size(50)]
        public string String3
        {
            get { return fString3; }
            set { SetPropertyValue<string>("String3", ref fString3, value); }
        }
        string fString4;
        [Size(50)]
        public string String4
        {
            get { return fString4; }
            set { SetPropertyValue<string>("String4", ref fString4, value); }
        }
        string fString5;
        [Size(50)]
        public string String5
        {
            get { return fString5; }
            set { SetPropertyValue<string>("String5", ref fString5, value); }
        }
        string fString6;
        [Size(50)]
        public string String6
        {
            get { return fString6; }
            set { SetPropertyValue<string>("String6", ref fString6, value); }
        }
        string fString7;
        [Size(50)]
        public string String7
        {
            get { return fString7; }
            set { SetPropertyValue<string>("String7", ref fString7, value); }
        }
        string fString8;
        [Size(50)]
        public string String8
        {
            get { return fString8; }
            set { SetPropertyValue<string>("String8", ref fString8, value); }
        }
        string fString9;
        [Size(50)]
        public string String9
        {
            get { return fString9; }
            set { SetPropertyValue<string>("String9", ref fString9, value); }
        }
        string fString10;
        [Size(50)]
        public string String10
        {
            get { return fString10; }
            set { SetPropertyValue<string>("String10", ref fString10, value); }
        }
        string fString11;
        [Size(50)]
        public string String11
        {
            get { return fString11; }
            set { SetPropertyValue<string>("String11", ref fString11, value); }
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
        [Association(@"BlockModelBlockDataReferencesX_BlockModelBlock", typeof(BlockModelBlockData))]
        public XPCollection<BlockModelBlockData> BlockModelBlockDatas { get { return GetCollection<BlockModelBlockData>("BlockModelBlockDatas"); } }
        [Association(@"CompositeReferencesX_BlockModelBlock", typeof(Composite))]
        public XPCollection<Composite> Composites { get { return GetCollection<Composite>("Composites"); } }
    }

}
