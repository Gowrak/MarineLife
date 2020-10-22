using System;
using Newtonsoft.Json;

namespace MarineLife.Services.Models
{
    
    public partial class FishApi
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("returned")]
        public long Returned { get; set; }

        [JsonProperty("data")]
        public Datum[] Data { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }
    }

    public partial class Datum
    {
        [JsonProperty("SpecCode")]
        public long SpecCode { get; set; }

        [JsonProperty("Genus")]
        public string Genus { get; set; }

        [JsonProperty("Species")]
        public string Species { get; set; }

        [JsonProperty("SpeciesRefNo")]
        public long SpeciesRefNo { get; set; }

        [JsonProperty("Author")]
        public string Author { get; set; }

        [JsonProperty("FBname")]
        public string FBname { get; set; }

        [JsonProperty("PicPreferredName")]
        public string PicPreferredName { get; set; }

        [JsonProperty("PicPreferredNameM")]
        public object PicPreferredNameM { get; set; }

        [JsonProperty("PicPreferredNameF")]
        public object PicPreferredNameF { get; set; }

        [JsonProperty("PicPreferredNameJ")]
        public object PicPreferredNameJ { get; set; }

        [JsonProperty("FamCode")]
        public long FamCode { get; set; }

        [JsonProperty("Subfamily")]
        public object Subfamily { get; set; }

        [JsonProperty("GenCode")]
        public long GenCode { get; set; }

        [JsonProperty("SubGenCode")]
        public object SubGenCode { get; set; }

        [JsonProperty("BodyShapeI")]
        public string BodyShapeI { get; set; }

        [JsonProperty("Source")]
        public string Source { get; set; }

        [JsonProperty("AuthorRef")]
        public object AuthorRef { get; set; }

        [JsonProperty("Remark")]
        public object Remark { get; set; }

        [JsonProperty("TaxIssue")]
        public long TaxIssue { get; set; }

        [JsonProperty("Fresh")]
        public long Fresh { get; set; }

        [JsonProperty("Brack")]
        public long Brack { get; set; }

        [JsonProperty("Saltwater")]
        public long Saltwater { get; set; }

        [JsonProperty("DemersPelag")]
        public string DemersPelag { get; set; }

        [JsonProperty("Amphibious")]
        public object Amphibious { get; set; }

        [JsonProperty("AmphibiousRef")]
        public object AmphibiousRef { get; set; }

        [JsonProperty("AnaCat")]
        public string AnaCat { get; set; }

        [JsonProperty("MigratRef")]
        public long MigratRef { get; set; }

        [JsonProperty("DepthRangeShallow")]
        public long DepthRangeShallow { get; set; }

        [JsonProperty("DepthRangeDeep")]
        public long DepthRangeDeep { get; set; }

        [JsonProperty("DepthRangeRef")]
        public long DepthRangeRef { get; set; }

        [JsonProperty("DepthRangeComShallow")]
        public long DepthRangeComShallow { get; set; }

        [JsonProperty("DepthRangeComDeep")]
        public long DepthRangeComDeep { get; set; }

        [JsonProperty("DepthComRef")]
        public long DepthComRef { get; set; }

        [JsonProperty("LongevityWild")]
        public object LongevityWild { get; set; }

        [JsonProperty("LongevityWildRef")]
        public object LongevityWildRef { get; set; }

        [JsonProperty("LongevityCaptive")]
        public object LongevityCaptive { get; set; }

        [JsonProperty("LongevityCapRef")]
        public object LongevityCapRef { get; set; }

        [JsonProperty("Vulnerability")]
        public double Vulnerability { get; set; }

        [JsonProperty("Length")]
        public long Length { get; set; }

        [JsonProperty("LTypeMaxM")]
        public string LTypeMaxM { get; set; }

        [JsonProperty("LengthFemale")]
        public object LengthFemale { get; set; }

        [JsonProperty("LTypeMaxF")]
        public object LTypeMaxF { get; set; }

        [JsonProperty("MaxLengthRef")]
        public long MaxLengthRef { get; set; }

        [JsonProperty("CommonLength")]
        public long CommonLength { get; set; }

        [JsonProperty("LTypeComM")]
        public string LTypeComM { get; set; }

        [JsonProperty("CommonLengthF")]
        public object CommonLengthF { get; set; }

        [JsonProperty("LTypeComF")]
        public object LTypeComF { get; set; }

        [JsonProperty("CommonLengthRef")]
        public long CommonLengthRef { get; set; }

        [JsonProperty("Weight")]
        public long Weight { get; set; }

        [JsonProperty("WeightFemale")]
        public object WeightFemale { get; set; }

        [JsonProperty("MaxWeightRef")]
        public long MaxWeightRef { get; set; }

        [JsonProperty("Pic")]
        public string Pic { get; set; }

        [JsonProperty("PictureFemale")]
        public object PictureFemale { get; set; }

        [JsonProperty("LarvaPic")]
        public object LarvaPic { get; set; }

        [JsonProperty("EggPic")]
        public object EggPic { get; set; }

        [JsonProperty("ImportanceRef")]
        public long ImportanceRef { get; set; }

        [JsonProperty("Importance")]
        public string Importance { get; set; }

        [JsonProperty("PriceCateg")]
        public string PriceCateg { get; set; }

        [JsonProperty("PriceReliability")]
        public string PriceReliability { get; set; }

        [JsonProperty("Remarks7")]
        public object Remarks7 { get; set; }

        [JsonProperty("LandingStatistics")]
        public string LandingStatistics { get; set; }

        [JsonProperty("Landings")]
        public string Landings { get; set; }

        [JsonProperty("MainCatchingMethod")]
        public string MainCatchingMethod { get; set; }

        [JsonProperty("II")]
        public string Ii { get; set; }

        [JsonProperty("MSeines")]
        public long MSeines { get; set; }

        [JsonProperty("MGillnets")]
        public long MGillnets { get; set; }

        [JsonProperty("MCastnets")]
        public long MCastnets { get; set; }

        [JsonProperty("MTraps")]
        public long MTraps { get; set; }

        [JsonProperty("MSpears")]
        public long MSpears { get; set; }

        [JsonProperty("MTrawls")]
        public long MTrawls { get; set; }

        [JsonProperty("MDredges")]
        public long MDredges { get; set; }

        [JsonProperty("MLiftnets")]
        public long MLiftnets { get; set; }

        [JsonProperty("MHooksLines")]
        public long MHooksLines { get; set; }

        [JsonProperty("MOther")]
        public long MOther { get; set; }

        [JsonProperty("UsedforAquaculture")]
        public string UsedforAquaculture { get; set; }

        [JsonProperty("LifeCycle")]
        public object LifeCycle { get; set; }

        [JsonProperty("AquacultureRef")]
        public object AquacultureRef { get; set; }

        [JsonProperty("UsedasBait")]
        public string UsedasBait { get; set; }

        [JsonProperty("BaitRef")]
        public object BaitRef { get; set; }

        [JsonProperty("Aquarium")]
        public string Aquarium { get; set; }

        [JsonProperty("AquariumFishII")]
        public object AquariumFishIi { get; set; }

        [JsonProperty("AquariumRef")]
        public object AquariumRef { get; set; }

        [JsonProperty("GameFish")]
        public long GameFish { get; set; }

        [JsonProperty("GameRef")]
        public long GameRef { get; set; }

        [JsonProperty("Dangerous")]
        public object Dangerous { get; set; }

        [JsonProperty("DangerousRef")]
        public object DangerousRef { get; set; }

        [JsonProperty("Electrogenic")]
        public string Electrogenic { get; set; }

        [JsonProperty("ElectroRef")]
        public object ElectroRef { get; set; }

        [JsonProperty("Complete")]
        public object Complete { get; set; }

        [JsonProperty("GoogleImage")]
        public long GoogleImage { get; set; }

        [JsonProperty("Comments")]
        public string Comments { get; set; }

        [JsonProperty("Profile")]
        public object Profile { get; set; }

        [JsonProperty("PD50")]
        public double Pd50 { get; set; }

        [JsonProperty("Emblematic")]
        public long Emblematic { get; set; }

        [JsonProperty("Entered")]
        public long Entered { get; set; }

        [JsonProperty("DateEntered")]
        public DateTimeOffset DateEntered { get; set; }

        [JsonProperty("Modified")]
        public long Modified { get; set; }

        [JsonProperty("DateModified")]
        public DateTimeOffset DateModified { get; set; }

        [JsonProperty("Expert")]
        public long Expert { get; set; }

        [JsonProperty("DateChecked")]
        public DateTimeOffset DateChecked { get; set; }

        [JsonProperty("TS")]
        public object Ts { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }
    }
}