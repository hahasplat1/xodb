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

    [Persistent(@"X_DictionaryWeathering")]
    public partial class DictionaryWeathering : XPLiteObject
    {
        Guid fWeatheringID;
        [Key(true)]
        public Guid WeatheringID
        {
            get { return fWeatheringID; }
            set { SetPropertyValue<Guid>("WeatheringID", ref fWeatheringID, value); }
        }
        string fStandardWeatheringName;
        [Indexed(Name = @"IDictionaryWeathering", Unique = true)]
        [Size(16)]
        public string StandardWeatheringName
        {
            get { return fStandardWeatheringName; }
            set { SetPropertyValue<string>("StandardWeatheringName", ref fStandardWeatheringName, value); }
        }
        string fCoalWeatheringName;
        [Size(16)]
        public string CoalWeatheringName
        {
            get { return fCoalWeatheringName; }
            set { SetPropertyValue<string>("CoalWeatheringName", ref fCoalWeatheringName, value); }
        }
        string fGoldWeatheringName;
        [Size(16)]
        public string GoldWeatheringName
        {
            get { return fGoldWeatheringName; }
            set { SetPropertyValue<string>("GoldWeatheringName", ref fGoldWeatheringName, value); }
        }
        string fCustomWeatheringName;
        [Size(16)]
        public string CustomWeatheringName
        {
            get { return fCustomWeatheringName; }
            set { SetPropertyValue<string>("CustomWeatheringName", ref fCustomWeatheringName, value); }
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
        System.Drawing.Image fThumbnail;
        [Size(SizeAttribute.Unlimited)]
        [ValueConverter(typeof(DevExpress.Xpo.Metadata.ImageValueConverter))]
        public System.Drawing.Image Thumbnail
        {
            get { return fThumbnail; }
            set { SetPropertyValue<System.Drawing.Image>("Thumbnail", ref fThumbnail, value); }
        }
        FileData fOriginalFileDataID;
        [Association(@"DictionaryWeatheringReferencesFileData")]
        public FileData OriginalFileDataID
        {
            get { return fOriginalFileDataID; }
            set { SetPropertyValue<FileData>("OriginalFileDataID", ref fOriginalFileDataID, value); }
        }
        [Association(@"LithologyReferencesDictionaryWeathering", typeof(Lithology))]
        public XPCollection<Lithology> Lithologies { get { return GetCollection<Lithology>("Lithologies"); } }
        [Association(@"DefectReferencesDictionaryWeathering", typeof(Defect))]
        public XPCollection<Defect> Defects { get { return GetCollection<Defect>("Defects"); } }
    }

}
