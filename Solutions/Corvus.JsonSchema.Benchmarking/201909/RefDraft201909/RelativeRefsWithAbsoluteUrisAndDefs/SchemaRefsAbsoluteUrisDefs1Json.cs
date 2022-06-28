
    //------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable

namespace RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Text.Json;
    using System.Text.RegularExpressions;
    using Corvus.Json;

        /// <summary>
    /// A type generated from a JsonSchema specification.
    /// </summary>
    public readonly struct SchemaRefsAbsoluteUrisDefs1Json :
            IJsonObject<SchemaRefsAbsoluteUrisDefs1Json>,
                    IEquatable<SchemaRefsAbsoluteUrisDefs1Json>
    {

        
    
        
        /// <summary>
        /// JSON property name for <see cref="Bar"/>.
        /// </summary>
        public static readonly ReadOnlyMemory<byte> BarUtf8JsonPropertyName = new byte[] { 98, 97, 114 };

        /// <summary>
        /// JSON property name for <see cref="Bar"/>.
        /// </summary>
        public static readonly string BarJsonPropertyName = "bar";

        
        /// <summary>
        /// JSON property name for <see cref="Foo"/>.
        /// </summary>
        public static readonly ReadOnlyMemory<byte> FooUtf8JsonPropertyName = new byte[] { 102, 111, 111 };

        /// <summary>
        /// JSON property name for <see cref="Foo"/>.
        /// </summary>
        public static readonly string FooJsonPropertyName = "foo";

        
    
    
    
    
    
            private static readonly ImmutableDictionary<string, PropertyValidator<SchemaRefsAbsoluteUrisDefs1Json>> __CorvusLocalProperties = CreateLocalPropertyValidators();
    
    

    
        private readonly JsonElement jsonElementBacking;

            private readonly ImmutableDictionary<string, JsonAny>? objectBacking;
    
    
    
    
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaRefsAbsoluteUrisDefs1Json"/> struct.
        /// </summary>
        /// <param name="value">The backing <see cref="JsonElement"/>.</param>
        public SchemaRefsAbsoluteUrisDefs1Json(JsonElement value)
        {
            this.jsonElementBacking = value;
                this.objectBacking = default;
                            }

            /// <summary>
        /// Initializes a new instance of the <see cref="SchemaRefsAbsoluteUrisDefs1Json"/> struct.
        /// </summary>
        /// <param name="value">A property dictionary.</param>
        public SchemaRefsAbsoluteUrisDefs1Json(ImmutableDictionary<string, JsonAny> value)
        {
            this.jsonElementBacking = default;
            this.objectBacking = value;
                                        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaRefsAbsoluteUrisDefs1Json"/> struct.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> from which to construct the value.</param>
        public SchemaRefsAbsoluteUrisDefs1Json(JsonObject jsonObject)
        {
            if (jsonObject.HasJsonElement)
            {
                this.jsonElementBacking = jsonObject.AsJsonElement;
                this.objectBacking = default;
            }
            else
            {
                this.jsonElementBacking = default;
                this.objectBacking = jsonObject.AsPropertyDictionary;
            }

                                        }
    
    
    
    
    
    
            /// <summary>
        /// Initializes a new instance of the <see cref="SchemaRefsAbsoluteUrisDefs1Json"/> struct.
        /// </summary>
        /// <param name="conversion">The <see cref="RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner"/> from which to construct the value.</param>
        public SchemaRefsAbsoluteUrisDefs1Json(RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner conversion)
        {
            if (conversion.HasJsonElement)
            {
                this.jsonElementBacking = conversion.AsJsonElement;
                        this.objectBacking = default;
                
                                    }
            else
            {
                this.jsonElementBacking = default;
                        if (conversion.ValueKind == JsonValueKind.Object)
                {
                    this.objectBacking = conversion;
                }
                else
                {
                    this.objectBacking = default;
                }
                
                                    }
        }
    

    
            /// <summary>
        /// Gets the value as a <see cref="RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner" />.
        /// </summary>
        public RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner AsInner
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this is a valid <see cref="RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner" />.
        /// </summary>
        public bool IsInner
        {
            get
            {
                return ((RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner)this).Validate().IsValid;
            }
        }

    
        
            
        /// <summary>
        /// Gets Bar.
        /// </summary>
        /// <remarks>
        /// {Property title}.
        /// {Property description}.
        /// </remarks>
        /// <example>
        /// {Property examples}.
        /// </example>
        public Corvus.Json.JsonString Bar
        {
            get
            {
                if (this.objectBacking is ImmutableDictionary<string, JsonAny> properties)
                {
                    if(properties.TryGetValue(BarJsonPropertyName, out JsonAny result))
                    {
                        return result;
                    }
                }

                if (this.jsonElementBacking.ValueKind == JsonValueKind.Object)
                {
                    if (this.jsonElementBacking.TryGetProperty(BarUtf8JsonPropertyName.Span, out JsonElement result))
                    {
                        return new  Corvus.Json.JsonString(result);
                    }
                }

                return default;
            }
        }

        
        /// <summary>
        /// Gets Foo.
        /// </summary>
        /// <remarks>
        /// {Property title}.
        /// {Property description}.
        /// </remarks>
        /// <example>
        /// {Property examples}.
        /// </example>
        public RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner Foo
        {
            get
            {
                if (this.objectBacking is ImmutableDictionary<string, JsonAny> properties)
                {
                    if(properties.TryGetValue(FooJsonPropertyName, out JsonAny result))
                    {
                        return result;
                    }
                }

                if (this.jsonElementBacking.ValueKind == JsonValueKind.Object)
                {
                    if (this.jsonElementBacking.TryGetProperty(FooUtf8JsonPropertyName.Span, out JsonElement result))
                    {
                        return new  RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner(result);
                    }
                }

                return default;
            }
        }

                    /// <summary>
        /// Gets a value indicating whether this is backed by a JSON element.
        /// </summary>
        public bool HasJsonElement =>
    
                this.objectBacking is null
            
    
                
                ;

        /// <summary>
        /// Gets the value as a JsonElement.
        /// </summary>
        public JsonElement AsJsonElement
        {
            get
            {
              
                if (this.objectBacking is ImmutableDictionary<string, JsonAny> objectBacking)
                {
                    return JsonObject.PropertiesToJsonElement(objectBacking);
                }

    
    
    
    
    
                return this.jsonElementBacking;
            }
        }

        /// <inheritdoc/>
        public JsonValueKind ValueKind
        {
            get
            {
                    if (this.objectBacking is ImmutableDictionary<string, JsonAny>)
                {
                    return JsonValueKind.Object;
                }

    
    
    
    
    
                return this.jsonElementBacking.ValueKind;
            }
        }

        /// <inheritdoc/>
        public JsonAny AsAny
        {
            get
            {
                    if (this.objectBacking is ImmutableDictionary<string, JsonAny> objectBacking)
                {
                    return new JsonAny(objectBacking);
                }

    
    
    
    
    
                return new JsonAny(this.jsonElementBacking);
            }
        }

            /// <summary>
        /// Conversion from <see cref="RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner" />.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator SchemaRefsAbsoluteUrisDefs1Json(RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner value)
        {
            return new SchemaRefsAbsoluteUrisDefs1Json(value);
        }

        /// <summary>
        /// Conversion to <see cref="RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner" />.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner(SchemaRefsAbsoluteUrisDefs1Json value)
        {
                    if (value.ValueKind == JsonValueKind.Object)
            {
                return new RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner(value.AsObject);
            }
                                                    return default;
        }
    
        
        /// <summary>
        /// Conversion from any.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator SchemaRefsAbsoluteUrisDefs1Json(JsonAny value)
        {
            if (value.HasJsonElement)
            {
                return new SchemaRefsAbsoluteUrisDefs1Json(value.AsJsonElement);
            }

            return value.As<SchemaRefsAbsoluteUrisDefs1Json>();
        }

        /// <summary>
        /// Conversion to any.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator JsonAny(SchemaRefsAbsoluteUrisDefs1Json value)
        {
            return value.AsAny;
        }

    
    
        /// <summary>
        /// Conversion from object.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator SchemaRefsAbsoluteUrisDefs1Json(JsonObject value)
        {
            return new SchemaRefsAbsoluteUrisDefs1Json(value);
        }

        /// <summary>
        /// Conversion to object.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator JsonObject(SchemaRefsAbsoluteUrisDefs1Json value)
        {
            return value.AsObject;
        }

                /// <summary>
        /// Implicit conversion to a property dictionary.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator ImmutableDictionary<string, JsonAny>(SchemaRefsAbsoluteUrisDefs1Json  value)
        {
            return value.AsObject.AsPropertyDictionary;
        }

        /// <summary>
        /// Implicit conversion from a property dictionary.
        /// </summary>
        /// <param name="value">The value from which to convert.</param>
        public static implicit operator SchemaRefsAbsoluteUrisDefs1Json (ImmutableDictionary<string, JsonAny> value)
        {
            return new SchemaRefsAbsoluteUrisDefs1Json (value);
        }

    
    
    
    
        /// <summary>
        /// Standard equality operator.
        /// </summary>
        /// <param name="lhs">The left hand side of the comparison.</param>
        /// <param name="rhs">The right hand side of the comparison.</param>
        /// <returns>True if they are equal.</returns>
        public static bool operator ==(SchemaRefsAbsoluteUrisDefs1Json lhs, SchemaRefsAbsoluteUrisDefs1Json rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Standard inequality operator.
        /// </summary>
        /// <param name="lhs">The left hand side of the comparison.</param>
        /// <param name="rhs">The right hand side of the comparison.</param>
        /// <returns>True if they are not equal.</returns>
        public static bool operator !=(SchemaRefsAbsoluteUrisDefs1Json lhs, SchemaRefsAbsoluteUrisDefs1Json rhs)
        {
            return !lhs.Equals(rhs);
        }

    
            /// <summary>
        /// Creates an instance of a <see cref="SchemaRefsAbsoluteUrisDefs1Json"/>.
        /// </summary>
        public static SchemaRefsAbsoluteUrisDefs1Json Create(
                            Corvus.Json.JsonString? bar = null
        ,             RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner? foo = null
        
        )
        {
            var builder = ImmutableDictionary.CreateBuilder<string, JsonAny>();
                            if (bar is Corvus.Json.JsonString bar__)
            {
                builder.Add(BarJsonPropertyName, bar__);
            }
                    if (foo is RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner foo__)
            {
                builder.Add(FooJsonPropertyName, foo__);
            }
                    return builder.ToImmutable();
        }

        
        /// <summary>
        /// Sets bar.
        /// </summary>
        /// <param name="value">The value to set.</param>
        /// <returns>The entity with the updated property.</returns>
        public SchemaRefsAbsoluteUrisDefs1Json WithBar(Corvus.Json.JsonString value)
        {
            return this.SetProperty(BarJsonPropertyName, value);
        }

        
        /// <summary>
        /// Sets foo.
        /// </summary>
        /// <param name="value">The value to set.</param>
        /// <returns>The entity with the updated property.</returns>
        public SchemaRefsAbsoluteUrisDefs1Json WithFoo(RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner value)
        {
            return this.SetProperty(FooJsonPropertyName, value);
        }

        
    
        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            if (obj is IJsonValue jv)
            {
                return this.Equals(jv.AsAny);
            }

            return obj is null && this.IsNull();
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            JsonValueKind valueKind = this.ValueKind;

            return valueKind switch
            {
                    JsonValueKind.Object => this.AsObject.GetHashCode(),
                        JsonValueKind.Array => this.AsArray().GetHashCode(),
                        JsonValueKind.Number => this.AsNumber().GetHashCode(),
                        JsonValueKind.String => this.AsString().GetHashCode(),
                        JsonValueKind.True or JsonValueKind.False => this.AsBoolean().GetHashCode(),
                    JsonValueKind.Null => JsonNull.NullHashCode,
                _ => JsonAny.UndefinedHashCode,
            };
        }

        /// <summary>
        /// Writes the object to the <see cref="Utf8JsonWriter"/>.
        /// </summary>
        /// <param name="writer">The writer to which to write the object.</param>
        public void WriteTo(Utf8JsonWriter writer)
        {
                if (this.objectBacking is ImmutableDictionary<string, JsonAny> objectBacking)
            {
                JsonObject.WriteProperties(objectBacking, writer);
                return;
            }

    
    
    
    
    
            if (this.jsonElementBacking.ValueKind != JsonValueKind.Undefined)
            {
                this.jsonElementBacking.WriteTo(writer);
                return;
            }

            writer.WriteNullValue();
        }

    
        
        
        /// <inheritdoc/>
        public JsonObjectEnumerator EnumerateObject()
        {
            return this.AsObject.EnumerateObject();
        }

    
    
    
        /// <inheritdoc/>
        public bool TryGetProperty(string name, out JsonAny value)
        {
            return this.AsObject.TryGetProperty(name, out value);
        }

        /// <inheritdoc/>
        public bool TryGetProperty(ReadOnlySpan<char> name, out JsonAny value)
        {
            return this.AsObject.TryGetProperty(name, out value);
        }

        /// <inheritdoc/>
        public bool TryGetProperty(ReadOnlySpan<byte> utf8name, out JsonAny value)
        {
            return this.AsObject.TryGetProperty(utf8name, out value);
        }

        
    
        /// <inheritdoc/>
        public bool Equals<T>(T other)
            where T : struct, IJsonValue
        {
            JsonValueKind valueKind = this.ValueKind;

            if (other.ValueKind != valueKind)
            {
                return false;
            }

            return valueKind switch
            {
                    JsonValueKind.Object => this.AsObject.Equals(other.AsObject()),
                        JsonValueKind.Array => this.AsArray().Equals(other.AsArray()),
                        JsonValueKind.Number => this.AsNumber().Equals(other.AsNumber()),
                        JsonValueKind.String => this.AsString().Equals(other.AsString()),
                        JsonValueKind.True or JsonValueKind.False => this.AsBoolean().Equals(other.AsBoolean()),
                    JsonValueKind.Null => true,
                _ => false,
            };
        }

        /// <inheritdoc/>
        public bool Equals(SchemaRefsAbsoluteUrisDefs1Json other)
        {
            JsonValueKind valueKind = this.ValueKind;

            if (other.ValueKind != valueKind)
            {
                return false;
            }

            return valueKind switch
            {
                                JsonValueKind.Object => this.AsObject.Equals(other.AsObject),
                        JsonValueKind.Array => this.AsArray().Equals(other.AsArray()),
                        JsonValueKind.Number => this.AsNumber().Equals(other.AsNumber()),
                        JsonValueKind.String => this.AsString().Equals(other.AsString()),
                        JsonValueKind.True or JsonValueKind.False => this.AsBoolean().Equals(other.AsBoolean()),
                    JsonValueKind.Null => true,
                _ => false,
            };
        }

    
        /// <inheritdoc/>
        public bool HasProperty(string name)
        {
            if (this.objectBacking is ImmutableDictionary<string, JsonAny> properties)
            {
                return properties.TryGetValue(name, out _);
            }

            if (this.jsonElementBacking.ValueKind == JsonValueKind.Object)
            {
                return this.jsonElementBacking.TryGetProperty(name.ToString(), out JsonElement _);
            }

            return false;
        }

        /// <inheritdoc/>
        public bool HasProperty(ReadOnlySpan<char> name)
        {
            if (this.objectBacking is ImmutableDictionary<string, JsonAny> properties)
            {
                return properties.TryGetValue(name.ToString(), out _);
            }

            if (this.jsonElementBacking.ValueKind == JsonValueKind.Object)
            {
                return this.jsonElementBacking.TryGetProperty(name, out JsonElement _);
            }

            return false;        }

        /// <inheritdoc/>
        public bool HasProperty(ReadOnlySpan<byte> utf8name)
        {
            if (this.objectBacking is ImmutableDictionary<string, JsonAny> properties)
            {
                return properties.TryGetValue(System.Text.Encoding.UTF8.GetString(utf8name), out _);
            }

            if (this.jsonElementBacking.ValueKind == JsonValueKind.Object)
            {
                return this.jsonElementBacking.TryGetProperty(utf8name, out JsonElement _);
            }

            return false;        }

        /// <inheritdoc/>
        public SchemaRefsAbsoluteUrisDefs1Json SetProperty<TValue>(string name, TValue value)
            where TValue : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Object || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsObject.SetProperty(name, value);
            }

            return this;
        }

        /// <inheritdoc/>
        public SchemaRefsAbsoluteUrisDefs1Json SetProperty<TValue>(ReadOnlySpan<char> name, TValue value)
            where TValue : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Object || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsObject.SetProperty(name, value);
            }

            return this;
        }

        /// <inheritdoc/>
        public SchemaRefsAbsoluteUrisDefs1Json SetProperty<TValue>(ReadOnlySpan<byte> utf8name, TValue value)
            where TValue : struct, IJsonValue
        {
            if (this.ValueKind == JsonValueKind.Object || this.ValueKind == JsonValueKind.Undefined)
            {
                return this.AsObject.SetProperty(utf8name, value);
            }

            return this;
        }

        /// <inheritdoc/>
        public SchemaRefsAbsoluteUrisDefs1Json RemoveProperty(string name)
        {
            if (this.ValueKind == JsonValueKind.Object)
            {
                return this.AsObject.RemoveProperty(name);
            }

            return this;
        }

        /// <inheritdoc/>
        public SchemaRefsAbsoluteUrisDefs1Json RemoveProperty(ReadOnlySpan<char> name)
        {
            if (this.ValueKind == JsonValueKind.Object)
            {
                return this.AsObject.RemoveProperty(name);
            }

            return this;
        }

        /// <inheritdoc/>
        public SchemaRefsAbsoluteUrisDefs1Json RemoveProperty(ReadOnlySpan<byte> utf8Name)
        {
            if (this.ValueKind == JsonValueKind.Object)
            {
                return this.AsObject.RemoveProperty(utf8Name);
            }

            return this;
        }

    
    
        /// <inheritdoc/>
        public T As<T>()
            where T : struct, IJsonValue
        {
            return this.As<SchemaRefsAbsoluteUrisDefs1Json, T>();
        }

    
        /// <inheritdoc/>
        public ValidationContext Validate(in ValidationContext? validationContext = null, ValidationLevel level = ValidationLevel.Flag)
        {
            ValidationContext result = validationContext ?? ValidationContext.ValidContext;
            if (level != ValidationLevel.Flag)
            {
                result = result.UsingStack();
            }

                        
        
        
                result = this.ValidateRef(result, level);
            if (level == ValidationLevel.Flag && !result.IsValid)
            {
                return result;
            }
    
                JsonValueKind valueKind = this.ValueKind;
    
    
    
    
        
    
    
    
    
    
    
                result = this.ValidateObject(valueKind, result, level);
            if (level == ValidationLevel.Flag && !result.IsValid)
            {
                return result;
            }

    

                return result;
        }


    
    
    
    
    
        private static ImmutableDictionary<string, PropertyValidator<SchemaRefsAbsoluteUrisDefs1Json>> CreateLocalPropertyValidators()
        {
            ImmutableDictionary<string, PropertyValidator<SchemaRefsAbsoluteUrisDefs1Json>>.Builder builder =
                ImmutableDictionary.CreateBuilder<string, PropertyValidator<SchemaRefsAbsoluteUrisDefs1Json>>();

                    builder.Add(
                FooJsonPropertyName, __CorvusValidateFoo);
        
            return builder.ToImmutable();
        }

                private static ValidationContext __CorvusValidateFoo(in SchemaRefsAbsoluteUrisDefs1Json that, in ValidationContext validationContext, ValidationLevel level)
        {
            RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner property = that.Foo;
            return property.Validate(validationContext, level);
        }
            
            /// <summary>
        /// Gets the value as a <see cref="JsonObject"/>.
        /// </summary>
        private JsonObject AsObject
        {
            get
            {
                if (this.objectBacking is ImmutableDictionary<string, JsonAny> objectBacking)
                {
                    return new JsonObject(objectBacking);
                }

                return new JsonObject(this.jsonElementBacking);
            }
        }
    
    
    
    
    
            private ValidationContext ValidateRef(in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;


            ValidationContext refResult = this.As<RefDraft201909Feature.RelativeRefsWithAbsoluteUrisAndDefs.Inner>().Validate(validationContext.CreateChildContext(), level);

            if (!refResult.IsValid)
            {
                if (level >= ValidationLevel.Detailed)
                {
                    result = validationContext.MergeResults(false, level, refResult);
                }
                else if (level >= ValidationLevel.Basic)
                {
                    result = validationContext.MergeResults(false, level, refResult);
                }
                else
                {
                    result = validationContext.WithResult(isValid: false);
                }
            }
            else
            {
                if (level >= ValidationLevel.Basic)
                {
                    result = result.MergeResults(result.IsValid, level, refResult);
                }

                result = result.MergeChildContext(refResult, false);
            }

            return result;
        }
    
    
            private ValidationContext ValidateObject(JsonValueKind valueKind, in ValidationContext validationContext, ValidationLevel level)
        {
            ValidationContext result = validationContext;

            if (valueKind != JsonValueKind.Object)
            {
                return result;
            }

                    int propertyCount = 0;
        
        
            foreach (Property property in this.EnumerateObject())
            {
                string propertyName = property.Name;

        
                        if (__CorvusLocalProperties.TryGetValue(propertyName, out PropertyValidator<SchemaRefsAbsoluteUrisDefs1Json>? propertyValidator))
                {
                    result = result.WithLocalProperty(propertyCount);
                    var propertyResult = propertyValidator(this, result.CreateChildContext(), level);
                    result = result.MergeResults(propertyResult.IsValid, level, propertyResult);
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
    }
    