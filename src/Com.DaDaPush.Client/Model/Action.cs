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
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Com.DaDaPush.Client.Model
{
    /// <summary>
    ///     Action
    /// </summary>
    [DataContract]
    public class Action : IEquatable<Action>, IValidatableObject
    {
        /// <summary>
        ///     fix value: link
        /// </summary>
        /// <value>fix value: link</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            ///     Enum Link for value: link
            /// </summary>
            [EnumMember(Value = "link")] Link = 1
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Action" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Action()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Action" /> class.
        /// </summary>
        /// <param name="name">action button name (required).</param>
        /// <param name="type">fix value: link (required).</param>
        /// <param name="url">action url (required).</param>
        public Action(string name = default(string), TypeEnum type = default(TypeEnum), string url = default(string))
        {
            // to ensure "name" is required (not null)
            Name = name ?? throw new InvalidDataException("name is a required property for Action and cannot be null");

            // to ensure "type" is required (not null)
            Type = type;

            // to ensure "url" is required (not null)
            Url = url ?? throw new InvalidDataException("url is a required property for Action and cannot be null");
        }

        /// <summary>
        ///     fix value: link
        /// </summary>
        /// <value>fix value: link</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }

        /// <summary>
        ///     action button name
        /// </summary>
        /// <value>action button name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }


        /// <summary>
        ///     action url
        /// </summary>
        /// <value>action url</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        ///     Returns true if Action instances are equal
        /// </summary>
        /// <param name="input">Instance of Action to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Action input)
        {
            if (input == null)
                return false;

            return
                (
                    Name == input.Name ||
                    Name != null &&
                    Name.Equals(input.Name)
                ) &&
                (
                    Type == input.Type ||
                    Type.Equals(input.Type)
                ) &&
                (
                    Url == input.Url ||
                    Url != null &&
                    Url.Equals(input.Url)
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            // Name (string) maxLength
            if (Name != null && Name.Length > 20)
                yield return new ValidationResult(
                    "Invalid value for Name, length must be less than 20.", new[] {"Name"});

            // Name (string) minLength
            if (Name != null && Name.Length < 1)
                yield return new ValidationResult(
                    "Invalid value for Name, length must be greater than 1.", new[] {"Name"});

            // Type (string) pattern
            var regexType = new Regex(@"link", RegexOptions.CultureInvariant);
            if (Type != TypeEnum.Link)
                yield return new ValidationResult(
                    "Invalid value for Type, must match a pattern of " + regexType, new[] {"Type"});

            // Url (string) maxLength
            if (Url != null && Url.Length > 500)
                yield return new ValidationResult(
                    "Invalid value for Url, length must be less than 500.", new[] {"Url"});

            // Url (string) minLength
            if (Url != null && Url.Length < 1)
                yield return new ValidationResult(
                    "Invalid value for Url, length must be greater than 1.", new[] {"Url"});
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Action {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return Equals(input as Action);
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                return hashCode;
            }
        }
    }
}