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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Com.DaDaPush.Client.Model
{
    /// <summary>
    ///     ResultOfPageResponseOfMessageObject
    /// </summary>
    [DataContract]
    public class ResultOfPageResponseOfMessageObject : IEquatable<ResultOfPageResponseOfMessageObject>,
        IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ResultOfPageResponseOfMessageObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResultOfPageResponseOfMessageObject()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ResultOfPageResponseOfMessageObject" /> class.
        /// </summary>
        /// <param name="code">code (required).</param>
        /// <param name="data">data.</param>
        /// <param name="errmsg">errmsg (required).</param>
        public ResultOfPageResponseOfMessageObject(int? code = default(int?),
            PageResponseOfMessageObject data = default(PageResponseOfMessageObject), string errmsg = default(string))
        {
            // to ensure "code" is required (not null)
            if (code == null)
                throw new InvalidDataException(
                    "code is a required property for ResultOfPageResponseOfMessageObject and cannot be null");
            Code = code;

            // to ensure "errmsg" is required (not null)
            Errmsg = errmsg ?? throw new InvalidDataException(
                         "errmsg is a required property for ResultOfPageResponseOfMessageObject and cannot be null");

            Data = data;
        }

        /// <summary>
        ///     Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public int? Code { get; set; }

        /// <summary>
        ///     Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public PageResponseOfMessageObject Data { get; set; }

        /// <summary>
        ///     Gets or Sets Errmsg
        /// </summary>
        [DataMember(Name = "errmsg", EmitDefaultValue = false)]
        public string Errmsg { get; set; }

        /// <summary>
        ///     Returns true if ResultOfPageResponseOfMessageObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ResultOfPageResponseOfMessageObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultOfPageResponseOfMessageObject input)
        {
            if (input == null)
                return false;

            return
                (
                    Code == input.Code ||
                    Code != null &&
                    Code.Equals(input.Code)
                ) &&
                (
                    Data == input.Data ||
                    Data != null &&
                    Data.Equals(input.Data)
                ) &&
                (
                    Errmsg == input.Errmsg ||
                    Errmsg != null &&
                    Errmsg.Equals(input.Errmsg)
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResultOfPageResponseOfMessageObject {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Errmsg: ").Append(Errmsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as ResultOfPageResponseOfMessageObject);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                if (Errmsg != null)
                    hashCode = hashCode * 59 + Errmsg.GetHashCode();
                return hashCode;
            }
        }
    }
}