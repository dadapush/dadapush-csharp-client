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
    /// MessagePushRequest
    /// </summary>
    [DataContract]
    public partial class MessagePushRequest :  IEquatable<MessagePushRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagePushRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessagePushRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagePushRequest" /> class.
        /// </summary>
        /// <param name="actions">action size range is 0,3.</param>
        /// <param name="content">message content (required).</param>
        /// <param name="needPush">when value is false, will not send client push (required).</param>
        /// <param name="title">message title (required).</param>
        public MessagePushRequest(List<Action> actions = default(List<Action>), string content = default(string), bool? needPush = default(bool?), string title = default(string))
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for MessagePushRequest and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            
            // to ensure "needPush" is required (not null)
            if (needPush == null)
            {
                throw new InvalidDataException("needPush is a required property for MessagePushRequest and cannot be null");
            }
            else
            {
                this.NeedPush = needPush;
            }
            
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for MessagePushRequest and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            
            this.Actions = actions;
        }
        
        /// <summary>
        /// action size range is 0,3
        /// </summary>
        /// <value>action size range is 0,3</value>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<Action> Actions { get; set; }

        /// <summary>
        /// message content
        /// </summary>
        /// <value>message content</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// when value is false, will not send client push
        /// </summary>
        /// <value>when value is false, will not send client push</value>
        [DataMember(Name="needPush", EmitDefaultValue=false)]
        public bool? NeedPush { get; set; }

        /// <summary>
        /// message title
        /// </summary>
        /// <value>message title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessagePushRequest {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  NeedPush: ").Append(NeedPush).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as MessagePushRequest);
        }

        /// <summary>
        /// Returns true if MessagePushRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MessagePushRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessagePushRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.NeedPush == input.NeedPush ||
                    (this.NeedPush != null &&
                    this.NeedPush.Equals(input.NeedPush))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.NeedPush != null)
                    hashCode = hashCode * 59 + this.NeedPush.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
            // Content (string) maxLength
            if(this.Content != null && this.Content.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Content, length must be less than 500.", new [] { "Content" });
            }

            // Content (string) minLength
            if(this.Content != null && this.Content.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Content, length must be greater than 1.", new [] { "Content" });
            }

            // Title (string) maxLength
            if(this.Title != null && this.Title.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 50.", new [] { "Title" });
            }

            // Title (string) minLength
            if(this.Title != null && this.Title.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 1.", new [] { "Title" });
            }

            yield break;
        }
    }

}
