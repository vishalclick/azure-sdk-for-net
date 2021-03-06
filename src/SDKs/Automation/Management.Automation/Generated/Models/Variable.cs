// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of the varible.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Variable
    {
        /// <summary>
        /// Initializes a new instance of the Variable class.
        /// </summary>
        public Variable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Variable class.
        /// </summary>
        /// <param name="id">Gets or sets the id of the resource.</param>
        /// <param name="name">Gets or sets the name of the variable.</param>
        /// <param name="value">Gets or sets the value of the variable.</param>
        /// <param name="isEncrypted">Gets or sets the encrypted flag of the
        /// variable.</param>
        /// <param name="creationTime">Gets or sets the creation time.</param>
        /// <param name="lastModifiedTime">Gets or sets the last modified
        /// time.</param>
        /// <param name="description">Gets or sets the description.</param>
        public Variable(string id = default(string), string name = default(string), string value = default(string), bool? isEncrypted = default(bool?), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?), string description = default(string))
        {
            Id = id;
            Name = name;
            Value = value;
            IsEncrypted = isEncrypted;
            CreationTime = creationTime;
            LastModifiedTime = lastModifiedTime;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the variable.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the variable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the encrypted flag of the variable.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isEncrypted")]
        public bool? IsEncrypted { get; set; }

        /// <summary>
        /// Gets or sets the creation time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the last modified time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

    }
}
