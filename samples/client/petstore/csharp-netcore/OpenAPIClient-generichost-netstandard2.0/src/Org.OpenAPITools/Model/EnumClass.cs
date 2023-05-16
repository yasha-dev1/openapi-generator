// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Defines EnumClass
    /// </summary>
    public enum EnumClass
    {
        /// <summary>
        /// Enum Abc for value: _abc
        /// </summary>
        Abc = 1,

        /// <summary>
        /// Enum Efg for value: -efg
        /// </summary>
        Efg = 2,

        /// <summary>
        /// Enum Xyz for value: (xyz)
        /// </summary>
        Xyz = 3
    }

    public class EnumClassConverter : JsonConverter<EnumClass>
    {
        public static EnumClass FromString(string value)
        {
            if (value == "_abc")
                return EnumClass.Abc;

            if (value == "-efg")
                return EnumClass.Efg;

            if (value == "(xyz)")
                return EnumClass.Xyz;

            throw new NotImplementedException($"Could not convert value to type EnumClass: '{value}'");
        }

        public static EnumClass? FromStringOrDefault(string value)
        {
            if (value == "_abc")
                return EnumClass.Abc;

            if (value == "-efg")
                return EnumClass.Efg;

            if (value == "(xyz)")
                return EnumClass.Xyz;

            return null;
        }

        public static string ToJsonValue(EnumClass value)
        {
            if (value == EnumClass.Abc)
                return "_abc";

            if (value == EnumClass.Efg)
                return "-efg";

            if (value == EnumClass.Xyz)
                return "(xyz)";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override EnumClass Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawValue = reader.GetString();

            EnumClass? result = EnumClassConverter.FromString(rawValue);
            
            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the EnumClass to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="enumClass"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, EnumClass enumClass, JsonSerializerOptions options)
        {
            writer.WriteStringValue(enumClass.ToString());
        }
    }

    public class EnumClassNullableConverter : JsonConverter<EnumClass?>
    {
        /// <summary>
        /// Returns a EnumClass from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override EnumClass? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawValue = reader.GetString();

            if (rawValue == null)
                return null;

            EnumClass? result = EnumClassConverter.FromString(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="enumClass"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, EnumClass? enumClass, JsonSerializerOptions options)
        {
            writer.WriteStringValue(enumClass?.ToString() ?? "null");
        }
    }

}
