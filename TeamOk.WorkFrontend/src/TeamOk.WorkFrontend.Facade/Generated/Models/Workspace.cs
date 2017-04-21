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

    public partial class Workspace
    {
        /// <summary>
        /// Initializes a new instance of the Workspace class.
        /// </summary>
        public Workspace() { }

        /// <summary>
        /// Initializes a new instance of the Workspace class.
        /// </summary>
        public Workspace(long? id = default(long?), long? floorId = default(long?), string name = default(string), bool? claimed = default(bool?), IList<Facility> facilities = default(IList<Facility>), DateTime? created = default(DateTime?), DateTime? modified = default(DateTime?))
        {
            Id = id;
            FloorId = floorId;
            Name = name;
            Claimed = claimed;
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
        [JsonProperty(PropertyName = "floorId")]
        public long? FloorId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "claimed")]
        public bool? Claimed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "facilities")]
        public IList<Facility> Facilities { get; set; }

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
