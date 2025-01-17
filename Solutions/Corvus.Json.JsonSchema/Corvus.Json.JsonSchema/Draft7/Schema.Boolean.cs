//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.JsonSchema.Draft7;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct Schema : IJsonBoolean<Schema>
{
    /// <summary>
    /// Initializes a new instance of the <see cref = "Schema"/> struct.
    /// </summary>
    /// <param name = "value">The value from which to construct the instance.</param>
    public Schema(bool value)
    {
        this.jsonElementBacking = default;
        this.backing = Backing.Bool;
        this.boolBacking = value;
        this.objectBacking = ImmutableDictionary<JsonPropertyName, JsonAny>.Empty;
    }

    /// <summary>
    /// Conversion from JsonBoolean.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator JsonBoolean(Schema value)
    {
        return value.AsBoolean;
    }

    /// <summary>
    /// Conversion to JsonBoolean.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator Schema(JsonBoolean value)
    {
        if (value.HasJsonElementBacking)
        {
            return new(value.AsJsonElement);
        }

        return new((bool)value);
    }

    /// <summary>
    /// Conversion from bool.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    public static implicit operator Schema(bool value)
    {
        return new(value);
    }

    /// <summary>
    /// Conversion to bool.
    /// </summary>
    /// <param name = "value">The value from which to convert.</param>
    /// <exception cref = "InvalidOperationException">The value was not a string.</exception>
    public static implicit operator bool (Schema value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return value.jsonElementBacking.GetBoolean();
        }

        if ((value.backing & Backing.Bool) != 0)
        {
            return value.boolBacking;
        }

        throw new InvalidOperationException();
    }
}