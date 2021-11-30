using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScannergicMobile.Models
{
    /// <summary>
    /// Class used to serialize a list of allergens in JSON
    /// </summary>
    public class AllergensContainer
    {
        /// <summary>
        /// List of allergens
        /// </summary>
        [JsonProperty("allergens")]
        public List<Allergen> Allergens { get; set; }
    }
}
