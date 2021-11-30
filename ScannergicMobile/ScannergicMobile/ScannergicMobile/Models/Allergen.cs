using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace ScannergicMobile.Models
{
    /// <summary>
    /// An allergen is substance that causes an allergic reaction to an Allergic person
    /// </summary>
    public class Allergen
    {
        private int id;

        /// <summary>
        /// Allergen's ID
        /// </summary>
        [JsonProperty("id")]
        public int Id
        {
            get { return id; }
        }

        private string name;

        /// <summary>
        /// Allergen's Name
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Instantiate
        /// </summary>
        /// <param name="id">The ID</param>
        /// <param name="name">The name</param>
        public Allergen(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
