﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v11.3.0.0 (NJsonSchema v9.3.1.0) (http://NSwag.org)
// </auto-generated>
//----------------------

namespace NSwag.Integration.Console.Contracts
{
    #pragma warning disable // Disable all warnings

    
    
    
    
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.3.1.0")]
    public partial class GeoPoint 
    {
        [Newtonsoft.Json.JsonProperty("Latitude", Required = Newtonsoft.Json.Required.Always)]
        public double Latitude { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Longitude", Required = Newtonsoft.Json.Required.Always)]
        public double Longitude { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static GeoPoint FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GeoPoint>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.3.1.0")]
    public partial class GenericRequestOfAddressAndPerson 
    {
        [Newtonsoft.Json.JsonProperty("Item1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address Item1 { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Item2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Person Item2 { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static GenericRequestOfAddressAndPerson FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericRequestOfAddressAndPerson>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.3.1.0")]
    public partial class Address 
    {
        [Newtonsoft.Json.JsonProperty("IsPrimary", Required = Newtonsoft.Json.Required.Always)]
        public bool IsPrimary { get; set; }
    
        [Newtonsoft.Json.JsonProperty("City", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Address FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Address>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.3.1.0")]
    public partial class Person 
    {
        [Newtonsoft.Json.JsonProperty("Id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Guid Id { get; set; }
    
        /// <summary>Gets or sets the first name.</summary>
        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 2)]
        public string FirstName { get; set; }
    
        /// <summary>Gets or sets the last name.</summary>
        [Newtonsoft.Json.JsonProperty("LastName", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public string LastName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Gender", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Gender Gender { get; set; }
    
        [Newtonsoft.Json.JsonProperty("DateOfBirth", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.DateTime DateOfBirth { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Weight", Required = Newtonsoft.Json.Required.Always)]
        public decimal Weight { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Height", Required = Newtonsoft.Json.Required.Always)]
        public double Height { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Age", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(5.0, 99.0)]
        public int Age { get; set; }
    
        [Newtonsoft.Json.JsonProperty("AverageSleepTime", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.TimeSpan AverageSleepTime { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Address", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Address Address { get; set; } = new Address();
    
        [Newtonsoft.Json.JsonProperty("Children", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.ObservableCollection<Person> Children { get; set; } = new System.Collections.ObjectModel.ObservableCollection<Person>();
    
        [Newtonsoft.Json.JsonProperty("Skills", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, SkillLevel> Skills { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Person FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.3.1.0")]
    public enum Gender
    {
        [System.Runtime.Serialization.EnumMember(Value = "Male")]
        Male = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = "Female")]
        Female = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.3.1.0")]
    public enum SkillLevel
    {
        Low = 0,
    
        Medium = 1,
    
        Height = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.3.1.0")]
    public partial class Teacher : Person
    {
        [Newtonsoft.Json.JsonProperty("Course", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Course { get; set; }
    
        [Newtonsoft.Json.JsonProperty("SkillLevel", Required = Newtonsoft.Json.Required.Always)]
        public SkillLevel SkillLevel { get; set; } = NSwag.Integration.Console.Contracts.SkillLevel.Medium;
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static Teacher FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Teacher>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.3.1.0")]
    public partial class PersonNotFoundException : System.Exception
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Guid Id { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
        
        public static PersonNotFoundException FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PersonNotFoundException>(data, new Newtonsoft.Json.JsonConverter[] { new Newtonsoft.Json.Converters.StringEnumConverter() });
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.3.1.0")]
    internal class JsonInheritanceConverter : Newtonsoft.Json.JsonConverter
    {
        internal static readonly string DefaultDiscriminatorName = "discriminator";
    
        private readonly string _discriminator;
            
        [System.ThreadStatic]
        private static bool _isReading;
    
        [System.ThreadStatic]
        private static bool _isWriting;
    
        public JsonInheritanceConverter()
        {
            _discriminator = DefaultDiscriminatorName;
        }
    
        public JsonInheritanceConverter(string discriminator)
        {
            _discriminator = discriminator;
        }
    
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {
            try
            {
                _isWriting = true;
    
                var jObject = Newtonsoft.Json.Linq.JObject.FromObject(value, serializer);
                jObject.AddFirst(new Newtonsoft.Json.Linq.JProperty(_discriminator, value.GetType().Name));
                writer.WriteToken(jObject.CreateReader());
            }
            finally
            {
                _isWriting = false;
            }
        }
    
        public override bool CanWrite
        {
            get
            {
                if (_isWriting)
                {
                    _isWriting = false;
                    return false; 
                }
                return true;
            }
        }
    
        public override bool CanRead
        {
            get
            {
                if (_isReading)
                {
                    _isReading = false;
                    return false;
                }
                return true;
            }
        }
    
        public override bool CanConvert(System.Type objectType)
        {
            return true;
        }
    
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            var jObject = serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(reader);
            var discriminator = Newtonsoft.Json.Linq.Extensions.Value<string>(jObject.GetValue(_discriminator));
            var subtype = GetObjectSubtype(jObject, objectType, discriminator);
    
            try
            {
                _isReading = true;
                return serializer.Deserialize(jObject.CreateReader(), subtype);
            }
            finally
            {
                _isReading = false;
            }
        }
    
        private System.Type GetObjectSubtype(Newtonsoft.Json.Linq.JObject jObject, System.Type objectType, string discriminator)
        {
            var objectTypeInfo = System.Reflection.IntrospectionExtensions.GetTypeInfo(objectType);
            var customAttributes = System.Reflection.CustomAttributeExtensions.GetCustomAttributes(objectTypeInfo);
    
            var knownTypeAttributes = System.Linq.Enumerable.Where(customAttributes, a => a.GetType().Name == "KnownTypeAttribute");
            dynamic knownTypeAttribute = System.Linq.Enumerable.SingleOrDefault(knownTypeAttributes, a => IsKnwonTypeTargetType(a, discriminator));
            if (knownTypeAttribute != null)
                return knownTypeAttribute.Type;
    
            var typeName = objectType.Namespace + "." + discriminator;
            var subtype = System.Reflection.IntrospectionExtensions.GetTypeInfo(objectType).Assembly.GetType(typeName);
            if (subtype != null)
                return subtype;
    
            var typeInfo = jObject.GetValue("$type");
            if (typeInfo != null)
                return System.Type.GetType(Newtonsoft.Json.Linq.Extensions.Value<string>(typeInfo));
    
            throw new System.InvalidOperationException("Could not find subtype of '" + objectType.Name + "' with discriminator '" + discriminator + "'.");
        }
    
        private bool IsKnwonTypeTargetType(dynamic attribute, string discriminator)
        {
            return attribute?.Type.Name == discriminator;
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "11.3.0.0")]
    public class FileParameter
    {
        public FileParameter(System.IO.Stream data) 
            : this (data, null)
        {
        }

        public FileParameter(System.IO.Stream data, string fileName)
        {
            Data = data;
            FileName = fileName;
        }

        public System.IO.Stream Data { get; private set; }

        public string FileName { get; private set; }
    }

    public class FileResponse : System.IDisposable
    {
        private System.IDisposable _client; 
        private System.IDisposable _response; 

        public string StatusCode { get; private set; }

        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public System.IO.Stream Stream { get; private set; }

        public bool IsPartial
        {
            get { return StatusCode == "206"; }
        }

        public FileResponse(string statusCode, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.IO.Stream stream, System.IDisposable client, System.IDisposable response)
        {
            StatusCode = statusCode; 
            Headers = headers; 
            Stream = stream; 
            _client = client; 
            _response = response;
        }

        public void Dispose() 
        {
            if (Stream != null)
                Stream.Dispose();
            if (_response != null)
                _response.Dispose();
            if (_client != null)
                _client.Dispose();
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "11.3.0.0")]
    public class SwaggerException : System.Exception
    {
        public string StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public SwaggerException(string message, string statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException) 
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response; 
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "11.3.0.0")]
    public class SwaggerException<TResult> : SwaggerException
    {
        public TResult Result { get; private set; }

        public SwaggerException(string message, string statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException) 
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }

}