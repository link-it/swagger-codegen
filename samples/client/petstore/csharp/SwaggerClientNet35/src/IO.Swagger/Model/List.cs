/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// List
    /// </summary>
    [DataContract]
        public partial class List :  IEquatable<List>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="List" /> class.
        /// </summary>
        /// <param name="">.</param>
        public List(string  = default(string))
        {
            this._123List = ;
        }
        
        /// <summary>
        /// Gets or Sets _123List
        /// </summary>
        [DataMember(Name="123-list", EmitDefaultValue=false)]
        public string _123List { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class List {\n");
            sb.Append("  _123List: ").Append(_123List).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as List);
        }

        /// <summary>
        /// Returns true if List instances are equal
        /// </summary>
        /// <param name="input">Instance of List to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(List input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._123List == input._123List ||
                    (this._123List != null &&
                    this._123List.Equals(input._123List))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this._123List != null)
                    hashCode = hashCode * 59 + this._123List.GetHashCode();
                return hashCode;
            }
        }

    }
}
