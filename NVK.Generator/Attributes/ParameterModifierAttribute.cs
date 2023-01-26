namespace NVK.Generator.Attributes;

/// <summary>An attribute used to specify a string value for a <see cref="ParameterModifier"/>.</summary>
[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
internal class ParameterModifierAttribute : Attribute
{
    /*********
    ** Properties
    *********/
    /// <summary>The value that the enum value represents.</summary>
    public string Value { get; }

    /// <summary>Whether the value is required for calling the function pointer as well as the parameter definition.</summary>
    public bool IsRequiredForCalling { get; }


    /*********
    ** Public Methods
    *********/
    /// <summary>Constructs an instance.</summary>
    /// <param name="value">The value that the enum value represents.</param>
    /// <param name="isRequiredForCalling">Whether the value is required for calling the function pointer as well as the parameter definition.</param>
    public ParameterModifierAttribute(string value, bool isRequiredForCalling)
    {
        Value = value;
        IsRequiredForCalling = isRequiredForCalling;
    }
}
