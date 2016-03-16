﻿// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Sfa.Infrastructure.Models
{
    using Newtonsoft.Json.Linq;

    public class Address
    {
        /// <summary>
        ///     Optional.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        ///     Optional.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        ///     Optional.
        /// </summary>
        public string County { get; set; }

        /// <summary>
        ///     Optional.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///     Optional.
        /// </summary>
        public double? Latitude { get; set; }

        /// <summary>
        ///     Optional.
        /// </summary>
        public double? Longitude { get; set; }

        /// <summary>
        ///     Optional.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        ///     Optional.
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        ///     Optional.
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        ///     Optional.
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        ///     Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                var address1Value = inputObject["address1"];
                if (address1Value != null && address1Value.Type != JTokenType.Null)
                {
                    Address1 = (string)address1Value;
                }
                var address2Value = inputObject["address2"];
                if (address2Value != null && address2Value.Type != JTokenType.Null)
                {
                    Address2 = (string)address2Value;
                }
                var countryValue = inputObject["county"];
                if (countryValue != null && countryValue.Type != JTokenType.Null)
                {
                    County = (string)countryValue;
                }
                var emailValue = inputObject["email"];
                if (emailValue != null && emailValue.Type != JTokenType.Null)
                {
                    Email = (string)emailValue;
                }
                var latValue = inputObject["lat"];
                if (latValue != null && latValue.Type != JTokenType.Null)
                {
                    Latitude = (double)latValue;
                }
                var longValue = inputObject["long"];
                if (longValue != null && longValue.Type != JTokenType.Null)
                {
                    Longitude = (double)longValue;
                }
                var phoneValue = inputObject["phone"];
                if (phoneValue != null && phoneValue.Type != JTokenType.Null)
                {
                    Phone = (string)phoneValue;
                }
                var postcodeValue = inputObject["postcode"];
                if (postcodeValue != null && postcodeValue.Type != JTokenType.Null)
                {
                    Postcode = (string)postcodeValue;
                }
                var townValue = inputObject["town"];
                if (townValue != null && townValue.Type != JTokenType.Null)
                {
                    Town = (string)townValue;
                }
                var websiteValue = inputObject["website"];
                if (websiteValue != null && websiteValue.Type != JTokenType.Null)
                {
                    Website = (string)websiteValue;
                }
            }
        }
    }
}