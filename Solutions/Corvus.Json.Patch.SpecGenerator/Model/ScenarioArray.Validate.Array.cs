//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Text.Json;
using Corvus.Json;

namespace Corvus.Json.Patch.SpecGenerator;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct ScenarioArray
{
    private ValidationContext ValidateArray(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
    {
        ValidationContext result = validationContext;
        if (valueKind != JsonValueKind.Array)
        {
            return result;
        }

        int arrayLength = 0;
        using JsonArrayEnumerator<Corvus.Json.Patch.SpecGenerator.Scenario> arrayEnumerator = this.EnumerateArray();
        while (arrayEnumerator.MoveNext())
        {
            result = arrayEnumerator.Current.Validate(result, level);
            if (level == ValidationLevel.Flag && !result.IsValid)
            {
                return result;
            }

            result = result.WithLocalItemIndex(arrayLength);
            arrayLength++;
        }

        return result;
    }
}