//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:6.0.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft202012 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorValidateAllOf : CodeGeneratorValidateAllOfBase {
        
        
        #line 92 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasAllOf;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"

    // This is only emitted if HasAllOf is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.Validate.AllOf should not be emitted if HasAllOf is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(@"//------------------------------------------------------------------------------
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

namespace ");
            
            #line default
            #line hidden
            
            #line 27 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 27 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 29 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 30 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write("/// <summary>\r\n/// A type generated from a JsonSchema specification.\r\n/// </summa" +
                    "ry>\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 33 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 33 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(@"
{
    private ValidationContext ValidateAllOf(in ValidationContext validationContext, ValidationLevel level)
    {
        ValidationContext result = validationContext;

        if (level > ValidationLevel.Flag)
        {
            result = result.PushValidationLocationProperty(""allOf"");
        }

");
            
            #line default
            #line hidden
            
            #line 44 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
  int allOfIndex = 0;
    foreach (var allOf in AllOf)
    { 
            
            #line default
            #line hidden
            
            #line 47 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write("\r\n        if (level > ValidationLevel.Flag)\r\n        {\r\n            result = resu" +
                    "lt.PushValidationLocationArrayIndex(");
            
            #line default
            #line hidden
            
            #line 50 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( allOfIndex ));
            
            #line default
            #line hidden
            
            #line 50 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(");\r\n        }\r\n\r\n        ValidationContext allOfResult");
            
            #line default
            #line hidden
            
            #line 53 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( allOfIndex ));
            
            #line default
            #line hidden
            
            #line 53 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(" = this.As<");
            
            #line default
            #line hidden
            
            #line 53 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( allOf ));
            
            #line default
            #line hidden
            
            #line 53 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(">().Validate(validationContext.CreateChildContext(), level);\r\n\r\n        if (!allO" +
                    "fResult");
            
            #line default
            #line hidden
            
            #line 55 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( allOfIndex ));
            
            #line default
            #line hidden
            
            #line 55 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(".IsValid)\r\n        {\r\n            if (level >= ValidationLevel.Detailed)\r\n       " +
                    "     {\r\n                result = result.MergeChildContext(allOfResult");
            
            #line default
            #line hidden
            
            #line 59 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( allOfIndex ));
            
            #line default
            #line hidden
            
            #line 59 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(@", true).WithResult(isValid: false, ""Validation 10.2.1.1. allOf - failed to validate against the allOf schema."");
            }
            else if (level >= ValidationLevel.Basic)
            {
                result = result.MergeChildContext(allOfResult");
            
            #line default
            #line hidden
            
            #line 63 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( allOfIndex ));
            
            #line default
            #line hidden
            
            #line 63 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(", true).WithResult(isValid: false, \"Validation 10.2.1.1. allOf - failed to valida" +
                    "te against the allOf schema.\");\r\n            }\r\n            else\r\n            {\r" +
                    "\n                result = result.MergeChildContext(allOfResult");
            
            #line default
            #line hidden
            
            #line 67 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( allOfIndex ));
            
            #line default
            #line hidden
            
            #line 67 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(", false).WithResult(isValid: false);\r\n                return result;\r\n           " +
                    " }\r\n        }\r\n        else\r\n        {\r\n            result = result.MergeChildCo" +
                    "ntext(allOfResult");
            
            #line default
            #line hidden
            
            #line 73 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( allOfIndex ));
            
            #line default
            #line hidden
            
            #line 73 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write(", level >= ValidationLevel.Detailed);\r\n        }\r\n\r\n        if (level > Validatio" +
                    "nLevel.Flag)\r\n        {\r\n            result = result.PopLocation(); // Index\r\n  " +
                    "      }\r\n");
            
            #line default
            #line hidden
            
            #line 80 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
      allOfIndex++;
    } 
            
            #line default
            #line hidden
            
            #line 82 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
            this.Write("\r\n        if (level > ValidationLevel.Flag)\r\n        {\r\n            result = resu" +
                    "lt.PopLocation(); // allOf\r\n        }\r\n\r\n        return result;\r\n    }\r\n}\r\n");
            
            #line default
            #line hidden
            
            #line 91 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Validate.AllOf.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorValidateAllOfBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((value != null)) {
                        this.formatProvider = value;
                    }
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
