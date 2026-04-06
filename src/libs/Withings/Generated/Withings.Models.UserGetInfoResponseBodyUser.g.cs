
#nullable enable

namespace Withings
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserGetInfoResponseBodyUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userid")]
        public int? Userid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstname")]
        public string? Firstname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastname")]
        public string? Lastname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shortname")]
        public string? Shortname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 0=male, 1=female
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public int? Gender { get; set; }

        /// <summary>
        /// Date of birth in YYYY-MM-DD format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("birthdate")]
        public string? Birthdate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_pref")]
        public global::Withings.UserGetInfoResponseBodyUserUnitPref? UnitPref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetInfoResponseBodyUser" /> class.
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="shortname"></param>
        /// <param name="email"></param>
        /// <param name="gender">
        /// 0=male, 1=female
        /// </param>
        /// <param name="birthdate">
        /// Date of birth in YYYY-MM-DD format
        /// </param>
        /// <param name="timezone"></param>
        /// <param name="unitPref"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetInfoResponseBodyUser(
            int? userid,
            string? firstname,
            string? lastname,
            string? shortname,
            string? email,
            int? gender,
            string? birthdate,
            string? timezone,
            global::Withings.UserGetInfoResponseBodyUserUnitPref? unitPref)
        {
            this.Userid = userid;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Shortname = shortname;
            this.Email = email;
            this.Gender = gender;
            this.Birthdate = birthdate;
            this.Timezone = timezone;
            this.UnitPref = unitPref;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetInfoResponseBodyUser" /> class.
        /// </summary>
        public UserGetInfoResponseBodyUser()
        {
        }
    }
}