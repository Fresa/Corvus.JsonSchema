//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:6.0.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft201909 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorConversionsOperators : CodeGeneratorConversionsOperatorsBase {
        
        
        #line 135 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasConversions;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"

    // This is only emitted if HasConversions is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.Conversions.Operators should not be emitted if HasConversions is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
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
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace ");
            
            #line default
            #line hidden
            
            #line 26 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 26 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 28 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 29 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("/// <summary>\r\n/// A type generated from a JsonSchema specification.\r\n/// </summa" +
                    "ry>\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 32 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 32 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("\r\n{\r\n");
            
            #line default
            #line hidden
            
            #line 34 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
  foreach(Conversion conversion in Conversions)
    { 
            
            #line default
            #line hidden
            
            #line 36 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("    /// <summary>\r\n    /// Conversion from <see cref=\"");
            
            #line default
            #line hidden
            
            #line 37 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 37 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("\" />.\r\n    /// </summary>\r\n    /// <param name=\"value\">The value from which to co" +
                    "nvert.</param>\r\n    public static implicit operator ");
            
            #line default
            #line hidden
            
            #line 40 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 40 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("(");
            
            #line default
            #line hidden
            
            #line 40 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 40 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write(" value)\r\n    {\r\n        if (value.HasJsonElementBacking)\r\n        {\r\n            " +
                    "return new(value.AsJsonElement);\r\n        }\r\n\r\n        return value.ValueKind sw" +
                    "itch\r\n        {\r\n");
            
            #line default
            #line hidden
            
            #line 49 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
      // If the conversion supports the given type, we know that
        // we must also support the given type (as we derived the conversion from schema in this case)
        // so we do not need to check the IsImplicitObject etc.
        if(conversion.IsObject)
        { 
            
            #line default
            #line hidden
            
            #line 54 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("            JsonValueKind.Object => new((ImmutableDictionary<JsonPropertyName, Js" +
                    "onAny>)value),\r\n");
            
            #line default
            #line hidden
            
            #line 55 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
      }
        if(conversion.IsArray)
        { 
            
            #line default
            #line hidden
            
            #line 58 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("            JsonValueKind.Array => new((ImmutableList<JsonAny>)value),\r\n");
            
            #line default
            #line hidden
            
            #line 59 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
      }
        if(conversion.IsString)
        { 
            
            #line default
            #line hidden
            
            #line 62 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("            JsonValueKind.String => new((string)value),\r\n");
            
            #line default
            #line hidden
            
            #line 63 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
      }
        if(conversion.IsBoolean)
        { 
            
            #line default
            #line hidden
            
            #line 66 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("            JsonValueKind.True => new(true),\r\n            JsonValueKind.False => " +
                    "new(false),\r\n");
            
            #line default
            #line hidden
            
            #line 68 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
      }
        if(conversion.IsNumber)
        { 
            
            #line default
            #line hidden
            
            #line 71 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("            JsonValueKind.Number => new((double)value),\r\n");
            
            #line default
            #line hidden
            
            #line 72 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
      } 
            
            #line default
            #line hidden
            
            #line 73 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("            _ => Undefined\r\n        };\r\n    }\r\n\r\n    /// <summary>\r\n    /// Conve" +
                    "rsion to <see cref=\"");
            
            #line default
            #line hidden
            
            #line 78 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 78 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("\" />.\r\n    /// </summary>\r\n    /// <param name=\"value\">The value from which to co" +
                    "nvert.</param>\r\n    public static implicit operator ");
            
            #line default
            #line hidden
            
            #line 81 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 81 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("(");
            
            #line default
            #line hidden
            
            #line 81 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 81 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write(" value)\r\n    {\r\n        if ((value.backing & Backing.JsonElement) != 0)\r\n        " +
                    "{\r\n            return new(value.AsJsonElement);\r\n        }\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 88 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
      // If the conversion supports the given type, we know that
        // we must also support the given type (as we derived the conversion from schema)
        // so we do not need to check the IsImplicitObject etc.
        if(conversion.IsObject)
        { 
            
            #line default
            #line hidden
            
            #line 93 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("\r\n        if ((value.backing & Backing.Object) != 0)\r\n        {\r\n            retu" +
                    "rn new(value.objectBacking);\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 98 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
      }
        if(conversion.IsArray)
        { 
            
            #line default
            #line hidden
            
            #line 101 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("\r\n        if ((value.backing & Backing.Array) != 0)\r\n        {\r\n            retur" +
                    "n new(value.arrayBacking);\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 106 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
      }
        if(conversion.IsString)
        { 
            
            #line default
            #line hidden
            
            #line 109 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("\r\n        if ((value.backing & Backing.String) != 0)\r\n        {\r\n            retu" +
                    "rn new(value.stringBacking);\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 114 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
      }
        if(conversion.IsBoolean)
        { 
            
            #line default
            #line hidden
            
            #line 117 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("        if ((value.backing & Backing.Bool) != 0)\r\n        {\r\n            return n" +
                    "ew(value.boolBacking);\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 121 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
      }
        if(conversion.IsNumber)
        { 
            
            #line default
            #line hidden
            
            #line 124 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("        if ((value.backing & Backing.Number) != 0)\r\n        {\r\n            return" +
                    " new(value.numberBacking);\r\n        }\r\n");
            
            #line default
            #line hidden
            
            #line 128 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
      } 
            
            #line default
            #line hidden
            
            #line 129 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("\r\n        return ");
            
            #line default
            #line hidden
            
            #line 130 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( conversion.FullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 130 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write(".Undefined;\r\n    }\r\n");
            
            #line default
            #line hidden
            
            #line 132 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
  } 
            
            #line default
            #line hidden
            
            #line 133 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
            this.Write("}\r\n");
            
            #line default
            #line hidden
            
            #line 134 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.Conversions.Operators.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorConversionsOperatorsBase {
        
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
