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
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.JsonSchema.Draft202012;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct Validation
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
            if (__TryGetCorvusLocalPropertiesValidator(property, this.HasJsonElementBacking, out ObjectPropertyValidator? propertyValidator))
            {
                result = result.WithLocalProperty(propertyCount);
                if (level > ValidationLevel.Basic)
                {
                    result = result.PushDocumentProperty("properties", property.Name);
                }

                var propertyResult = propertyValidator(property, result.CreateChildContext(), level);
                result = result.MergeResults(propertyResult.IsValid, level, propertyResult);
                if (level > ValidationLevel.Basic)
                {
                    result = result.PopLocation(); // property name
                }

                if (level == ValidationLevel.Flag && !result.IsValid)
                {
                    return result;
                }
            }

            propertyCount++;
        }

        return result;
    }
}