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

namespace Corvus.Json.JsonSchema.Draft201909;
public readonly partial struct Validation
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct UniqueItemsEntity
    {
        private ValidationContext ValidateType(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            bool isValid = false;
            ValidationContext localResultBoolean = Corvus.Json.Validate.TypeBoolean(valueKind, result.CreateChildContext(), level);
            if (level == ValidationLevel.Flag && localResultBoolean.IsValid)
            {
                return validationContext;
            }

            if (localResultBoolean.IsValid)
            {
                isValid = true;
            }

            result = result.MergeResults(isValid, level, localResultBoolean);
            return result;
        }
    }
}