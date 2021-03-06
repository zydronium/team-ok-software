// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TeamOk.WorkFrontend.Facade.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class LocationViewModel
    {
        /// <summary>
        /// Initializes a new instance of the LocationViewModel class.
        /// </summary>
        public LocationViewModel() { }

        /// <summary>
        /// Initializes a new instance of the LocationViewModel class.
        /// </summary>
        public LocationViewModel(long? id = default(long?), string name = default(string), string address = default(string), string postcode = default(string), string city = default(string), string phonenumber = default(string), string openingHours = default(string), double? latitude = default(double?), double? longitude = default(double?), IList<FacilityViewModel> facilities = default(IList<FacilityViewModel>), DateTime? created = default(DateTime?), DateTime? modified = default(DateTime?))
        {
            Id = id;
            Name = name;
            Address = address;
            Postcode = postcode;
            City = city;
            Phonenumber = phonenumber;
            OpeningHours = openingHours;
            Latitude = latitude;
            Longitude = longitude;
            Facilities = facilities;
            Created = created;
            Modified = modified;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phonenumber")]
        public string Phonenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "openingHours")]
        public string OpeningHours { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "facilities")]
        public IList<FacilityViewModel> Facilities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public DateTime? Created { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modified")]
        public DateTime? Modified { get; set; }

    }
}
