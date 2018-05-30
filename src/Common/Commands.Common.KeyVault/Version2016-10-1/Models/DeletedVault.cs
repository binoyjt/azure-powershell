// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.KeyVault.Version2016_10_1.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Deleted vault information with extended details.
    /// </summary>
    public partial class DeletedVault
    {
        /// <summary>
        /// Initializes a new instance of the DeletedVault class.
        /// </summary>
        public DeletedVault()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeletedVault class.
        /// </summary>
        /// <param name="id">The resource ID for the deleted key vault.</param>
        /// <param name="name">The name of the key vault.</param>
        /// <param name="type">The resource type of the key vault.</param>
        /// <param name="properties">Properties of the vault</param>
        public DeletedVault(string id = default(string), string name = default(string), string type = default(string), DeletedVaultProperties properties = default(DeletedVaultProperties))
        {
            Id = id;
            Name = name;
            Type = type;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the resource ID for the deleted key vault.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the key vault.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the resource type of the key vault.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets properties of the vault
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public DeletedVaultProperties Properties { get; set; }

    }
}