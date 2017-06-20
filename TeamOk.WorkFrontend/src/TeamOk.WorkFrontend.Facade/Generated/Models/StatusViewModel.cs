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

    public partial class StatusViewModel
    {
        /// <summary>
        /// Initializes a new instance of the StatusViewModel class.
        /// </summary>
        public StatusViewModel() { }

        /// <summary>
        /// Initializes a new instance of the StatusViewModel class.
        /// </summary>
        public StatusViewModel(bool? claimed = default(bool?), DateTime? claimedUntill = default(DateTime?))
        {
            Claimed = claimed;
            ClaimedUntill = claimedUntill;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "claimed")]
        public bool? Claimed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "claimedUntill")]
        public DateTime? ClaimedUntill { get; set; }

    }
}