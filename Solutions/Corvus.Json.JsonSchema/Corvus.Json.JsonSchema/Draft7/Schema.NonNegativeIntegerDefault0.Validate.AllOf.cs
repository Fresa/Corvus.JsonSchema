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
public readonly partial struct Schema
{
    /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly partial struct NonNegativeIntegerDefault0
    {
        private ValidationContext ValidateAllOf(in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;
            if (level > ValidationLevel.Basic)
            {
                result = result.PushValidationLocationProperty("allOf");
            }

            ValidationContext childContextBase = result;
            ValidationContext childContext0 = childContextBase;
            if (level > ValidationLevel.Basic)
            {
                childContext0 = childContext0.PushValidationLocationArrayIndex(0);
            }

            ValidationContext allOfResult0 = this.As<Corvus.Json.JsonSchema.Draft7.Schema.NonNegativeInteger>().Validate(childContext0.CreateChildContext(), level);
            if (!allOfResult0.IsValid)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.MergeChildContext(allOfResult0, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeChildContext(allOfResult0, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
                }
                else
                {
                    result = result.MergeChildContext(allOfResult0, false).WithResult(isValid: false);
                    return result;
                }
            }
            else
            {
                result = result.MergeChildContext(allOfResult0, level >= ValidationLevel.Detailed);
            }

            ValidationContext childContext1 = childContextBase;
            if (level > ValidationLevel.Basic)
            {
                childContext1 = childContext1.PushValidationLocationArrayIndex(1);
            }

            ValidationContext allOfResult1 = this.As<Corvus.Json.JsonSchema.Draft7.Schema.NonNegativeIntegerDefault0.AllOf1Entity>().Validate(childContext1.CreateChildContext(), level);
            if (!allOfResult1.IsValid)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = result.MergeChildContext(allOfResult1, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeChildContext(allOfResult1, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
                }
                else
                {
                    result = result.MergeChildContext(allOfResult1, false).WithResult(isValid: false);
                    return result;
                }
            }
            else
            {
                result = result.MergeChildContext(allOfResult1, level >= ValidationLevel.Detailed);
            }

            if (level > ValidationLevel.Basic)
            {
                result = result.PopLocation(); // allOf
            }

            return result;
        }
    }
}