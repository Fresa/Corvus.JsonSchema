//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:7.0.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corvus.Json.CodeGeneration.Generators.Draft201909 {
    using System.Collections.Generic;
    using Corvus.Json;
    using System;
    
    
    public partial class CodeGeneratorIfThenElse : CodeGeneratorIfThenElseBase {
        
        
        #line 106 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"

    public bool ShouldGenerate
    {
        get
        {
            return HasIfThenElse;
        }
    }

        #line default
        #line hidden
        
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 4 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"

    // This is only emitted if HasIfThenElse is true
    if(!ShouldGenerate)
    {
        throw new InvalidOperationException("CodeGenerator.IfThenElse should not be emitted if HasIfThenElse is false.");
    } 
            
            #line default
            #line hidden
            
            #line 10 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
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
            
            #line 27 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Namespace ));
            
            #line default
            #line hidden
            
            #line 27 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(";\r\n\r\n");
            
            #line default
            #line hidden
            
            #line 29 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
 BeginNesting(); 
            
            #line default
            #line hidden
            
            #line 30 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write("/// <summary>\r\n/// A type generated from a JsonSchema specification.\r\n/// </summa" +
                    "ry>\r\npublic readonly partial struct ");
            
            #line default
            #line hidden
            
            #line 33 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeDeclaration.DotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 33 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write("\r\n{\r\n");
            
            #line default
            #line hidden
            
            #line 35 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
  if (HasThen)
    { 
            
            #line default
            #line hidden
            
            #line 37 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write("    /// <summary>\r\n    /// Gets this value cast to the \'then\' type for the If/The" +
                    "n/Else clause.\r\n    /// </summary>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 40 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ThenFullyQualifiedDotnetTypeName));
            
            #line default
            #line hidden
            
            #line 40 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 40 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( IfDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 40 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write("Matched\r\n    {\r\n        get\r\n        {\r\n            return this.As<");
            
            #line default
            #line hidden
            
            #line 44 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ThenFullyQualifiedDotnetTypeName));
            
            #line default
            #line hidden
            
            #line 44 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(">();\r\n        }\r\n    }\r\n");
            
            #line default
            #line hidden
            
            #line 47 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
  }

    if (HasElse)
    { 
            
            #line default
            #line hidden
            
            #line 51 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write("\r\n    /// <summary>\r\n    /// Gets this value cast to the \'else\' type for the If/T" +
                    "hen/Else clause.\r\n    /// </summary>\r\n    public ");
            
            #line default
            #line hidden
            
            #line 55 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ElseFullyQualifiedDotnetTypeName));
            
            #line default
            #line hidden
            
            #line 55 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 55 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( IfDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 55 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write("NotMatched\r\n    {\r\n        get\r\n        {\r\n            return this.As<");
            
            #line default
            #line hidden
            
            #line 59 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ElseFullyQualifiedDotnetTypeName));
            
            #line default
            #line hidden
            
            #line 59 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(">();\r\n        }\r\n    }\r\n");
            
            #line default
            #line hidden
            
            #line 62 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
  }

    if (HasThen)
    { 
            
            #line default
            #line hidden
            
            #line 66 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(@"
    /// <summary>
    /// Gets a value indicating whether this matches an If/Then case, return the value as the type defined for the then case.
    /// </summary>
    /// <param name=""result"">This value cast to the 'then' type, when the 'if' schema matches, otherwise an Undefined instance of the 'then' type.</param>
    /// <returns><c>True</c> if the 'if' case matched, and the 'else' instance was provided.</returns>
    public bool TryMatch");
            
            #line default
            #line hidden
            
            #line 72 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( IfDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 72 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write("(out ");
            
            #line default
            #line hidden
            
            #line 72 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ThenFullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 72 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(" result)\r\n    {\r\n        if (this.As<");
            
            #line default
            #line hidden
            
            #line 74 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( IfFullyQualifiedDotnetTypeName));
            
            #line default
            #line hidden
            
            #line 74 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(">().IsValid())\r\n        {\r\n            result = this.As<");
            
            #line default
            #line hidden
            
            #line 76 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ThenFullyQualifiedDotnetTypeName));
            
            #line default
            #line hidden
            
            #line 76 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(">();\r\n            return true;\r\n        }\r\n\r\n        result = ");
            
            #line default
            #line hidden
            
            #line 80 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ThenFullyQualifiedDotnetTypeName));
            
            #line default
            #line hidden
            
            #line 80 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(".Undefined;\r\n        return false;\r\n    }\r\n");
            
            #line default
            #line hidden
            
            #line 83 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
  }
    if (HasElse)
    { 
            
            #line default
            #line hidden
            
            #line 86 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(@"
    /// <summary>
    /// Gets a value indicating whether this matches an If/Then/Else case, providing the 'else' type when the 'if' schema does not match.
    /// </summary>
    /// <param name=""result"">This value cast to the 'else' type, when the 'if' schema does not match, otherwise an Undefined instance of the else type.</param>
    /// <returns><c>True</c> if the if case did not match, and the else instance was provided.</returns>
    public bool TryNotMatched");
            
            #line default
            #line hidden
            
            #line 92 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( IfDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 92 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write("(out ");
            
            #line default
            #line hidden
            
            #line 92 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( ElseFullyQualifiedDotnetTypeName ));
            
            #line default
            #line hidden
            
            #line 92 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(" result)\r\n    {\r\n        if (!this.As<");
            
            #line default
            #line hidden
            
            #line 94 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( IfFullyQualifiedDotnetTypeName));
            
            #line default
            #line hidden
            
            #line 94 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(">().IsValid())\r\n        {\r\n            result = this.As<");
            
            #line default
            #line hidden
            
            #line 96 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ElseFullyQualifiedDotnetTypeName));
            
            #line default
            #line hidden
            
            #line 96 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(">();\r\n            return true;\r\n        }\r\n\r\n        result = ");
            
            #line default
            #line hidden
            
            #line 100 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ElseFullyQualifiedDotnetTypeName));
            
            #line default
            #line hidden
            
            #line 100 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write(".Undefined;\r\n        return false;\r\n    }\r\n");
            
            #line default
            #line hidden
            
            #line 103 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
  } 
            
            #line default
            #line hidden
            
            #line 104 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
            this.Write("}\r\n");
            
            #line default
            #line hidden
            
            #line 105 "../../Corvus.Json.CodeGeneration.Abstractions/SharedTemplates/CodeGenerator.IfThenElse.tt"
 EndNesting(); 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class CodeGeneratorIfThenElseBase {
        
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
