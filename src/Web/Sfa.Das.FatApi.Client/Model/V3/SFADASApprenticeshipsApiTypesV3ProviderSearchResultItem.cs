/* 
 * Apprenticeship Programmes API
 *
 * Provides details about apprenticeship programmes, training providers and assessment organisations.
 *
 * The version of the OpenAPI document: v3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Sfa.Das.FatApi.Client.Model
{
    /// <summary>
    /// SFADASApprenticeshipsApiTypesV3ProviderSearchResultItem
    /// </summary>
    [DataContract]
    public partial class SFADASApprenticeshipsApiTypesV3ProviderSearchResultItem :  IEquatable<SFADASApprenticeshipsApiTypesV3ProviderSearchResultItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SFADASApprenticeshipsApiTypesV3ProviderSearchResultItem" /> class.
        /// </summary>
        /// <param name="ukprn">ukprn.</param>
        /// <param name="location">location.</param>
        /// <param name="providerName">providerName.</param>
        /// <param name="overallAchievementRate">overallAchievementRate.</param>
        /// <param name="nationalProvider">nationalProvider.</param>
        /// <param name="deliveryModes">deliveryModes.</param>
        /// <param name="distance">distance.</param>
        /// <param name="employerSatisfaction">employerSatisfaction.</param>
        /// <param name="learnerSatisfaction">learnerSatisfaction.</param>
        /// <param name="nationalOverallAchievementRate">nationalOverallAchievementRate.</param>
        /// <param name="overallCohort">overallCohort.</param>
        /// <param name="hasNonLevyContract">hasNonLevyContract.</param>
        /// <param name="isLevyPayerOnly">isLevyPayerOnly.</param>
        /// <param name="currentlyNotStartingNewApprentices">currentlyNotStartingNewApprentices.</param>
        public SFADASApprenticeshipsApiTypesV3ProviderSearchResultItem(int ukprn = default(int), SFADASApprenticeshipsApiTypesV3TrainingLocation location = default(SFADASApprenticeshipsApiTypesV3TrainingLocation), string providerName = default(string), double? overallAchievementRate = null, bool nationalProvider = default(bool), List<string> deliveryModes = default(List<string>), double? distance = default(double), double employerSatisfaction = default(double), double learnerSatisfaction = default(double), double nationalOverallAchievementRate = default(double), string overallCohort = default(string), bool hasNonLevyContract = default(bool), bool isLevyPayerOnly = default(bool), bool currentlyNotStartingNewApprentices = default(bool))
        {
            this.Ukprn = ukprn;
            this.Location = location;
            this.ProviderName = providerName;
            this.OverallAchievementRate = overallAchievementRate;
            this.NationalProvider = nationalProvider;
            this.DeliveryModes = deliveryModes;
            if (distance.HasValue) { this.Distance = distance;  };
            this.EmployerSatisfaction = employerSatisfaction;
            this.LearnerSatisfaction = learnerSatisfaction;
            this.NationalOverallAchievementRate = nationalOverallAchievementRate;
            this.OverallCohort = overallCohort;
            this.HasNonLevyContract = hasNonLevyContract;
            this.IsLevyPayerOnly = isLevyPayerOnly;
            this.CurrentlyNotStartingNewApprentices = currentlyNotStartingNewApprentices;
        }
        
        /// <summary>
        /// Gets or Sets Ukprn
        /// </summary>
        [DataMember(Name="Ukprn", EmitDefaultValue=false)]
        public int Ukprn { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public SFADASApprenticeshipsApiTypesV3TrainingLocation Location { get; set; }

        /// <summary>
        /// Gets or Sets ProviderName
        /// </summary>
        [DataMember(Name="ProviderName", EmitDefaultValue=false)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Gets or Sets OverallAchievementRate
        /// </summary>
        [DataMember(Name="OverallAchievementRate", EmitDefaultValue=false)]
        public double? OverallAchievementRate { get; set; }

        /// <summary>
        /// Gets or Sets NationalProvider
        /// </summary>
        [DataMember(Name="NationalProvider", EmitDefaultValue=false)]
        public bool NationalProvider { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryModes
        /// </summary>
        [DataMember(Name="DeliveryModes", EmitDefaultValue=false)]
        public List<string> DeliveryModes { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="Distance", EmitDefaultValue=false)]
        public double? Distance { get; set; }

        /// <summary>
        /// Gets or Sets EmployerSatisfaction
        /// </summary>
        [DataMember(Name="EmployerSatisfaction", EmitDefaultValue=false)]
        public double EmployerSatisfaction { get; set; }

        /// <summary>
        /// Gets or Sets LearnerSatisfaction
        /// </summary>
        [DataMember(Name="LearnerSatisfaction", EmitDefaultValue=false)]
        public double LearnerSatisfaction { get; set; }

        /// <summary>
        /// Gets or Sets NationalOverallAchievementRate
        /// </summary>
        [DataMember(Name="NationalOverallAchievementRate", EmitDefaultValue=false)]
        public double NationalOverallAchievementRate { get; set; }

        /// <summary>
        /// Gets or Sets OverallCohort
        /// </summary>
        [DataMember(Name="OverallCohort", EmitDefaultValue=false)]
        public string OverallCohort { get; set; }

        /// <summary>
        /// Gets or Sets HasNonLevyContract
        /// </summary>
        [DataMember(Name="HasNonLevyContract", EmitDefaultValue=false)]
        public bool HasNonLevyContract { get; set; }

        /// <summary>
        /// Gets or Sets IsLevyPayerOnly
        /// </summary>
        [DataMember(Name="IsLevyPayerOnly", EmitDefaultValue=false)]
        public bool IsLevyPayerOnly { get; set; }

        /// <summary>
        /// Gets or Sets CurrentlyNotStartingNewApprentices
        /// </summary>
        [DataMember(Name="CurrentlyNotStartingNewApprentices", EmitDefaultValue=false)]
        public bool CurrentlyNotStartingNewApprentices { get; set; }

        [DataMember(Name = "IsHigherEducationInstitute", EmitDefaultValue = false)]
        public bool IsHigherEducationInstitute { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SFADASApprenticeshipsApiTypesV3ProviderSearchResultItem {\n");
            sb.Append("  Ukprn: ").Append(Ukprn).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  OverallAchievementRate: ").Append(OverallAchievementRate).Append("\n");
            sb.Append("  NationalProvider: ").Append(NationalProvider).Append("\n");
            sb.Append("  DeliveryModes: ").Append(DeliveryModes).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  EmployerSatisfaction: ").Append(EmployerSatisfaction).Append("\n");
            sb.Append("  LearnerSatisfaction: ").Append(LearnerSatisfaction).Append("\n");
            sb.Append("  NationalOverallAchievementRate: ").Append(NationalOverallAchievementRate).Append("\n");
            sb.Append("  OverallCohort: ").Append(OverallCohort).Append("\n");
            sb.Append("  HasNonLevyContract: ").Append(HasNonLevyContract).Append("\n");
            sb.Append("  IsLevyPayerOnly: ").Append(IsLevyPayerOnly).Append("\n");
            sb.Append("  CurrentlyNotStartingNewApprentices: ").Append(CurrentlyNotStartingNewApprentices).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SFADASApprenticeshipsApiTypesV3ProviderSearchResultItem);
        }

        /// <summary>
        /// Returns true if SFADASApprenticeshipsApiTypesV3ProviderSearchResultItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SFADASApprenticeshipsApiTypesV3ProviderSearchResultItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SFADASApprenticeshipsApiTypesV3ProviderSearchResultItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ukprn == input.Ukprn ||
                    (this.Ukprn != null &&
                    this.Ukprn.Equals(input.Ukprn))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.ProviderName == input.ProviderName ||
                    (this.ProviderName != null &&
                    this.ProviderName.Equals(input.ProviderName))
                ) && 
                (
                    this.OverallAchievementRate == input.OverallAchievementRate ||
                    (this.OverallAchievementRate != null &&
                    this.OverallAchievementRate.Equals(input.OverallAchievementRate))
                ) && 
                (
                    this.NationalProvider == input.NationalProvider ||
                    (this.NationalProvider != null &&
                    this.NationalProvider.Equals(input.NationalProvider))
                ) && 
                (
                    this.DeliveryModes == input.DeliveryModes ||
                    this.DeliveryModes != null &&
                    input.DeliveryModes != null &&
                    this.DeliveryModes.SequenceEqual(input.DeliveryModes)
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.EmployerSatisfaction == input.EmployerSatisfaction ||
                    (this.EmployerSatisfaction != null &&
                    this.EmployerSatisfaction.Equals(input.EmployerSatisfaction))
                ) && 
                (
                    this.LearnerSatisfaction == input.LearnerSatisfaction ||
                    (this.LearnerSatisfaction != null &&
                    this.LearnerSatisfaction.Equals(input.LearnerSatisfaction))
                ) && 
                (
                    this.NationalOverallAchievementRate == input.NationalOverallAchievementRate ||
                    (this.NationalOverallAchievementRate != null &&
                    this.NationalOverallAchievementRate.Equals(input.NationalOverallAchievementRate))
                ) && 
                (
                    this.OverallCohort == input.OverallCohort ||
                    (this.OverallCohort != null &&
                    this.OverallCohort.Equals(input.OverallCohort))
                ) && 
                (
                    this.HasNonLevyContract == input.HasNonLevyContract ||
                    (this.HasNonLevyContract != null &&
                    this.HasNonLevyContract.Equals(input.HasNonLevyContract))
                ) && 
                (
                    this.IsLevyPayerOnly == input.IsLevyPayerOnly ||
                    (this.IsLevyPayerOnly != null &&
                    this.IsLevyPayerOnly.Equals(input.IsLevyPayerOnly))
                ) && 
                (
                    this.CurrentlyNotStartingNewApprentices == input.CurrentlyNotStartingNewApprentices ||
                    (this.CurrentlyNotStartingNewApprentices != null &&
                    this.CurrentlyNotStartingNewApprentices.Equals(input.CurrentlyNotStartingNewApprentices))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Ukprn != null)
                    hashCode = hashCode * 59 + this.Ukprn.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.ProviderName != null)
                    hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                if (this.OverallAchievementRate != null)
                    hashCode = hashCode * 59 + this.OverallAchievementRate.GetHashCode();
                if (this.NationalProvider != null)
                    hashCode = hashCode * 59 + this.NationalProvider.GetHashCode();
                if (this.DeliveryModes != null)
                    hashCode = hashCode * 59 + this.DeliveryModes.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.EmployerSatisfaction != null)
                    hashCode = hashCode * 59 + this.EmployerSatisfaction.GetHashCode();
                if (this.LearnerSatisfaction != null)
                    hashCode = hashCode * 59 + this.LearnerSatisfaction.GetHashCode();
                if (this.NationalOverallAchievementRate != null)
                    hashCode = hashCode * 59 + this.NationalOverallAchievementRate.GetHashCode();
                if (this.OverallCohort != null)
                    hashCode = hashCode * 59 + this.OverallCohort.GetHashCode();
                if (this.HasNonLevyContract != null)
                    hashCode = hashCode * 59 + this.HasNonLevyContract.GetHashCode();
                if (this.IsLevyPayerOnly != null)
                    hashCode = hashCode * 59 + this.IsLevyPayerOnly.GetHashCode();
                if (this.CurrentlyNotStartingNewApprentices != null)
                    hashCode = hashCode * 59 + this.CurrentlyNotStartingNewApprentices.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
