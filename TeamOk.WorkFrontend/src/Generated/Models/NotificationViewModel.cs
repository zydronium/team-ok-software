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

    public partial class NotificationViewModel
    {
        /// <summary>
        /// Initializes a new instance of the NotificationViewModel class.
        /// </summary>
        public NotificationViewModel() { }

        /// <summary>
        /// Initializes a new instance of the NotificationViewModel class.
        /// </summary>
        public NotificationViewModel(bool? claimed = default(bool?))
        {
            Claimed = claimed;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "claimed")]
        public bool? Claimed { get; set; }

    }
}
