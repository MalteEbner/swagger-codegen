/* 
 * Swagger Petstore
 *
 * This is a sample Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/). 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Business Term: Scheme Member Definition: Information about a Member of the Scheme. Purpose: To have enough information to be able to produce a Statement of Account indicating premium due.
    /// </summary>
    [DataContract]
        public partial class ValMemberChoice1 :  IEquatable<ValMemberChoice1>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValMemberChoice1" /> class.
        /// </summary>
        /// <param name="valDateOfBirth">Business Term: Date Of Birth Definition: The date of birth of the member. Purpose: To be able to uniquely identify a member within a scheme. (required).</param>
        /// <param name="valLeavingDate">Business Term: Leaving Date Definition: The date the member left/is due to leave the scheme. Purpose: To identify those members that have left or are due to leave the scheme. To be able to calculate the benefit insured/premium payable in respect of the member/category..</param>
        public ValMemberChoice1(DateTime? valDateOfBirth = default(DateTime?), DateTime? valLeavingDate = default(DateTime?))
        {
            // to ensure "valDateOfBirth" is required (not null)
            if (valDateOfBirth == null)
            {
                throw new InvalidDataException("valDateOfBirth is a required property for ValMemberChoice1 and cannot be null");
            }
            else
            {
                this.ValDateOfBirth = valDateOfBirth;
            }
            this.ValLeavingDate = valLeavingDate;
        }
        
        /// <summary>
        /// Business Term: Date Of Birth Definition: The date of birth of the member. Purpose: To be able to uniquely identify a member within a scheme.
        /// </summary>
        /// <value>Business Term: Date Of Birth Definition: The date of birth of the member. Purpose: To be able to uniquely identify a member within a scheme.</value>
        [DataMember(Name="val_date_of_birth", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ValDateOfBirth { get; set; }

        /// <summary>
        /// Business Term: Leaving Date Definition: The date the member left/is due to leave the scheme. Purpose: To identify those members that have left or are due to leave the scheme. To be able to calculate the benefit insured/premium payable in respect of the member/category.
        /// </summary>
        /// <value>Business Term: Leaving Date Definition: The date the member left/is due to leave the scheme. Purpose: To identify those members that have left or are due to leave the scheme. To be able to calculate the benefit insured/premium payable in respect of the member/category.</value>
        [DataMember(Name="val_leaving_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? ValLeavingDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValMemberChoice1 {\n");
            sb.Append("  ValDateOfBirth: ").Append(ValDateOfBirth).Append("\n");
            sb.Append("  ValLeavingDate: ").Append(ValLeavingDate).Append("\n");
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
            return this.Equals(input as ValMemberChoice1);
        }

        /// <summary>
        /// Returns true if ValMemberChoice1 instances are equal
        /// </summary>
        /// <param name="input">Instance of ValMemberChoice1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValMemberChoice1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValDateOfBirth == input.ValDateOfBirth ||
                    (this.ValDateOfBirth != null &&
                    this.ValDateOfBirth.Equals(input.ValDateOfBirth))
                ) && 
                (
                    this.ValLeavingDate == input.ValLeavingDate ||
                    (this.ValLeavingDate != null &&
                    this.ValLeavingDate.Equals(input.ValLeavingDate))
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
                if (this.ValDateOfBirth != null)
                    hashCode = hashCode * 59 + this.ValDateOfBirth.GetHashCode();
                if (this.ValLeavingDate != null)
                    hashCode = hashCode * 59 + this.ValLeavingDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
