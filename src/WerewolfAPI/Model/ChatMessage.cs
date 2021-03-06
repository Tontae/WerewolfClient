/* 
 * Werewolf Engine
 *
 * This is a werewolf game engine for REST access. It is primarily developed for CPE200 class at Computer Engineering, Chiang Mai University.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: pruetboonma@gmail.com
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
using SwaggerDateConverter = WerewolfAPI.Client.SwaggerDateConverter;

namespace WerewolfAPI.Model
{
    /// <summary>
    /// ChatMessage
    /// </summary>
    [DataContract]
    public partial class ChatMessage :  IEquatable<ChatMessage>, IValidatableObject
    {
        /// <summary>
        /// Chat channel
        /// </summary>
        /// <value>Chat channel</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChannelEnum
        {
            
            /// <summary>
            /// Enum Nighttime for value: nighttime
            /// </summary>
            [EnumMember(Value = "nighttime")]
            Nighttime = 1,
            
            /// <summary>
            /// Enum Daytime for value: daytime
            /// </summary>
            [EnumMember(Value = "daytime")]
            Daytime = 2
        }

        /// <summary>
        /// Chat channel
        /// </summary>
        /// <value>Chat channel</value>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public ChannelEnum? Channel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChatMessage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessage" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Player">Player.</param>
        /// <param name="Message">Message (required).</param>
        /// <param name="Channel">Chat channel.</param>
        public ChatMessage(long? Id = default(long?), Player Player = default(Player), string Message = default(string), ChannelEnum? Channel = default(ChannelEnum?))
        {
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for ChatMessage and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            this.Id = Id;
            this.Player = Player;
            this.Channel = Channel;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name="player", EmitDefaultValue=false)]
        public Player Player { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatMessage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as ChatMessage);
        }

        /// <summary>
        /// Returns true if ChatMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ChatMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Player == input.Player ||
                    (this.Player != null &&
                    this.Player.Equals(input.Player))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Player != null)
                    hashCode = hashCode * 59 + this.Player.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
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
