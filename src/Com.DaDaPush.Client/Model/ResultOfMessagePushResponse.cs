/* 
 * DaDaPush Public API
 *
 * DaDaPush: Real-time Notifications App Send real-time notifications through our API without coding and maintaining your own app for iOS or Android devices.
 *
 * The version of the OpenAPI document: v1
 * Contact: contacts@dadapush.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Com.DaDaPush.Client.Client.OpenAPIDateConverter;

namespace Com.DaDaPush.Client.Model
{
    /// <summary>
    /// ResultOfMessagePushResponse
    /// </summary>
    [DataContract]
    public partial class ResultOfMessagePushResponse :  IEquatable<ResultOfMessagePushResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultOfMessagePushResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResultOfMessagePushResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultOfMessagePushResponse" /> class.
        /// </summary>
        /// <param name="code">code (required).</param>
        /// <param name="data">data.</param>
        /// <param name="errmsg">errmsg (required).</param>
        public ResultOfMessagePushResponse(int? code = default(int?), MessagePushResponse data = default(MessagePushResponse), string errmsg = default(string))
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for ResultOfMessagePushResponse and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            
            // to ensure "errmsg" is required (not null)
            if (errmsg == null)
            {
                throw new InvalidDataException("errmsg is a required property for ResultOfMessagePushResponse and cannot be null");
            }
            else
            {
                this.Errmsg = errmsg;
            }
            
            this.Data = data;
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public int? Code { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public MessagePushResponse Data { get; set; }

        /// <summary>
        /// Gets or Sets Errmsg
        /// </summary>
        [DataMember(Name="errmsg", EmitDefaultValue=false)]
        public string Errmsg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResultOfMessagePushResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Errmsg: ").Append(Errmsg).Append("\n");
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
            return this.Equals(input as ResultOfMessagePushResponse);
        }

        /// <summary>
        /// Returns true if ResultOfMessagePushResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ResultOfMessagePushResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultOfMessagePushResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Errmsg == input.Errmsg ||
                    (this.Errmsg != null &&
                    this.Errmsg.Equals(input.Errmsg))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Errmsg != null)
                    hashCode = hashCode * 59 + this.Errmsg.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
