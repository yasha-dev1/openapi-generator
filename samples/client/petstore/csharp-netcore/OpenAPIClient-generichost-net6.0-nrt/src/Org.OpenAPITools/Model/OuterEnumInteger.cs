// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

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
    /// Defines OuterEnumInteger
    /// </summary>
    public enum OuterEnumInteger
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        NUMBER_0 = 0,

        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        NUMBER_1 = 1,

        /// <summary>
        /// Enum NUMBER_2 for value: 2
        /// </summary>
        NUMBER_2 = 2
    }

    public class OuterEnumIntegerConverter : JsonConverter<OuterEnumInteger>
    {
        public static OuterEnumInteger FromString(string value)
        {
            if (value == (0).ToString())
                return OuterEnumInteger.NUMBER_0;

            if (value == (1).ToString())
                return OuterEnumInteger.NUMBER_1;

            if (value == (2).ToString())
                return OuterEnumInteger.NUMBER_2;

            throw new NotImplementedException($"Could not convert value to type OuterEnumInteger: '{value}'");
        }

        public static OuterEnumInteger? FromStringOrDefault(string value)
        {
            if (value == (0).ToString())
                return OuterEnumInteger.NUMBER_0;

            if (value == (1).ToString())
                return OuterEnumInteger.NUMBER_1;

            if (value == (2).ToString())
                return OuterEnumInteger.NUMBER_2;

            return null;
        }

        public static int ToJsonValue(OuterEnumInteger value)
        {
            return (int) value;
        }

        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override OuterEnumInteger Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            OuterEnumInteger? result = OuterEnumIntegerConverter.FromString(rawValue);
            
            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the OuterEnumInteger to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="outerEnumInteger"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, OuterEnumInteger outerEnumInteger, JsonSerializerOptions options)
        {
            writer.WriteStringValue(outerEnumInteger.ToString());
        }
    }

    public class OuterEnumIntegerNullableConverter : JsonConverter<OuterEnumInteger?>
    {
        /// <summary>
        /// Returns a OuterEnumInteger from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override OuterEnumInteger? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            if (rawValue == null)
                return null;

            OuterEnumInteger? result = OuterEnumIntegerConverter.FromString(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="outerEnumInteger"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, OuterEnumInteger? outerEnumInteger, JsonSerializerOptions options)
        {
            writer.WriteStringValue(outerEnumInteger?.ToString() ?? "null");
        }
    }

}
