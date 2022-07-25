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
using System.Text.Json;
using System.Text.RegularExpressions;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.JsonSchema.Draft201909;
public readonly partial struct Core
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct DefsValue
    {
        private ValidationContext ValidateObject(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            if (valueKind != JsonValueKind.Object)
            {
                return result;
            }

            int propertyCount = 0;
            foreach (JsonObjectProperty property in this.EnumerateObject())
            {
                JsonPropertyName propertyName = property.Name;
                if (!result.HasEvaluatedLocalProperty(propertyCount))
                {
                    result = property.ValueAs<Corvus.Json.JsonSchema.Draft201909.Schema>().Validate(result, level);
                    if (level == ValidationLevel.Flag && !result.IsValid)
                    {
                        return result;
                    }

                    result = result.WithLocalProperty(propertyCount);
                }

                propertyCount++;
            }

            return result;
        }
    }
}