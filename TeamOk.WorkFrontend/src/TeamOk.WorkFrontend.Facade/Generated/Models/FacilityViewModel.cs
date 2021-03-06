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

    public partial class FacilityViewModel
    {
        /// <summary>
        /// Initializes a new instance of the FacilityViewModel class.
        /// </summary>
        public FacilityViewModel() { }

        /// <summary>
        /// Initializes a new instance of the FacilityViewModel class.
        /// </summary>
        public FacilityViewModel(long? id = default(long?), string name = default(string), string value = default(string), DateTime? created = default(DateTime?), DateTime? modified = default(DateTime?))
        {
            Id = id;
            Name = name;
            Value = value;
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
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

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
