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

namespace Corvus.Json.JsonSchema.Draft202012;
/// <summary>
/// A type generated from a JsonSchema specification.
/// </summary>
public readonly partial struct Schema
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

        ValidationContext allOfResult0 = this.As<Corvus.Json.JsonSchema.Draft202012.Core>().Validate(childContext0.CreateChildContext(), level);
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

        ValidationContext allOfResult1 = this.As<Corvus.Json.JsonSchema.Draft202012.Applicator>().Validate(childContext1.CreateChildContext(), level);
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

        ValidationContext childContext2 = childContextBase;
        if (level > ValidationLevel.Basic)
        {
            childContext2 = childContext2.PushValidationLocationArrayIndex(2);
        }

        ValidationContext allOfResult2 = this.As<Corvus.Json.JsonSchema.Draft202012.Unevaluated>().Validate(childContext2.CreateChildContext(), level);
        if (!allOfResult2.IsValid)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.MergeChildContext(allOfResult2, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.MergeChildContext(allOfResult2, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else
            {
                result = result.MergeChildContext(allOfResult2, false).WithResult(isValid: false);
                return result;
            }
        }
        else
        {
            result = result.MergeChildContext(allOfResult2, level >= ValidationLevel.Detailed);
        }

        ValidationContext childContext3 = childContextBase;
        if (level > ValidationLevel.Basic)
        {
            childContext3 = childContext3.PushValidationLocationArrayIndex(3);
        }

        ValidationContext allOfResult3 = this.As<Corvus.Json.JsonSchema.Draft202012.Validation>().Validate(childContext3.CreateChildContext(), level);
        if (!allOfResult3.IsValid)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.MergeChildContext(allOfResult3, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.MergeChildContext(allOfResult3, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else
            {
                result = result.MergeChildContext(allOfResult3, false).WithResult(isValid: false);
                return result;
            }
        }
        else
        {
            result = result.MergeChildContext(allOfResult3, level >= ValidationLevel.Detailed);
        }

        ValidationContext childContext4 = childContextBase;
        if (level > ValidationLevel.Basic)
        {
            childContext4 = childContext4.PushValidationLocationArrayIndex(4);
        }

        ValidationContext allOfResult4 = this.As<Corvus.Json.JsonSchema.Draft202012.MetaData>().Validate(childContext4.CreateChildContext(), level);
        if (!allOfResult4.IsValid)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.MergeChildContext(allOfResult4, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.MergeChildContext(allOfResult4, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else
            {
                result = result.MergeChildContext(allOfResult4, false).WithResult(isValid: false);
                return result;
            }
        }
        else
        {
            result = result.MergeChildContext(allOfResult4, level >= ValidationLevel.Detailed);
        }

        ValidationContext childContext5 = childContextBase;
        if (level > ValidationLevel.Basic)
        {
            childContext5 = childContext5.PushValidationLocationArrayIndex(5);
        }

        ValidationContext allOfResult5 = this.As<Corvus.Json.JsonSchema.Draft202012.FormatAnnotation>().Validate(childContext5.CreateChildContext(), level);
        if (!allOfResult5.IsValid)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.MergeChildContext(allOfResult5, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.MergeChildContext(allOfResult5, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else
            {
                result = result.MergeChildContext(allOfResult5, false).WithResult(isValid: false);
                return result;
            }
        }
        else
        {
            result = result.MergeChildContext(allOfResult5, level >= ValidationLevel.Detailed);
        }

        ValidationContext childContext6 = childContextBase;
        if (level > ValidationLevel.Basic)
        {
            childContext6 = childContext6.PushValidationLocationArrayIndex(6);
        }

        ValidationContext allOfResult6 = this.As<Corvus.Json.JsonSchema.Draft202012.Content>().Validate(childContext6.CreateChildContext(), level);
        if (!allOfResult6.IsValid)
        {
            if (level >= ValidationLevel.Detailed)
            {
                result = result.MergeChildContext(allOfResult6, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.MergeChildContext(allOfResult6, true).WithResult(isValid: false, "Validation 10.2.1.1. allOf - failed to validate against the allOf schema.");
            }
            else
            {
                result = result.MergeChildContext(allOfResult6, false).WithResult(isValid: false);
                return result;
            }
        }
        else
        {
            result = result.MergeChildContext(allOfResult6, level >= ValidationLevel.Detailed);
        }

        if (level > ValidationLevel.Basic)
        {
            result = result.PopLocation(); // allOf
        }

        return result;
    }
}