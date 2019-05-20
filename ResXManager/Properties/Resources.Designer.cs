//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// 
// This template generates PublicResXFileCodeGenerator compatible code plus some
// useful extensions. 
// 
// The original version provided by ResXResourceManager is restricted to resource key names
// that are valid c# identifiers to keep this template simple (KISS!).
// 
// Us it as it is or as a scaffold to generate the code you need.
//
// As long as you have ResXResourceManager running in the background, the generated code 
// will be kept up to date.
//  
//------------------------------------------------------------------------------

namespace tomenglertde.ResXManager.Properties {
    using System;

    using JetBrains.Annotations;

    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by a text template.
    // To add or remove a member, edit your .ResX file.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ResXResourceManager", "1.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("tomenglertde.ResXManager.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Assembly location: {0}.
        /// </summary>
        [NotNull]
        public static string AssemblyLocation {
            get {
                return ResourceManager.GetString("AssemblyLocation", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to ResX Resource Manager loaded.&amp;#13;&amp;#10;Hom....
        /// </summary>
        [NotNull]
        public static string IntroMessage {
            get {
                return ResourceManager.GetString("IntroMessage", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The project has no resource file for the language ....
        /// </summary>
        [NotNull]
        public static string ProjectHasNoResourceFile {
            get {
                return ResourceManager.GetString("ProjectHasNoResourceFile", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Some files in your project are not writable. You m....
        /// </summary>
        [NotNull]
        public static string ProjectHasReadOnlyFiles {
            get {
                return ResourceManager.GetString("ProjectHasReadOnlyFiles", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Do you want to save the changes?.
        /// </summary>
        [NotNull]
        public static string QuerySaveChanges {
            get {
                return ResourceManager.GetString("QuerySaveChanges", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Version: {0}.
        /// </summary>
        /// <remarks>
        /// @Invariant
        /// </remarks>
        [NotNull]
        public static string Version {
            get {
                return ResourceManager.GetString("Version", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to You have unsaved changes; reloading all resources ....
        /// </summary>
        [NotNull]
        public static string WarningUnsavedChanges {
            get {
                return ResourceManager.GetString("WarningUnsavedChanges", resourceCulture) ?? string.Empty;
            }
        }
    }

    /// <summary>
    /// Keys of all available strings in the applications resx-resources.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    public enum StringResourceKey
    {
        /// <summary>
        ///   Looks up a localized string similar to Assembly location: {0}.
        /// </summary>
        AssemblyLocation,
        /// <summary>
        ///   Looks up a localized string similar to ResX Resource Manager loaded.&amp;#13;&amp;#10;Hom....
        /// </summary>
        IntroMessage,
        /// <summary>
        ///   Looks up a localized string similar to The project has no resource file for the language ....
        /// </summary>
        ProjectHasNoResourceFile,
        /// <summary>
        ///   Looks up a localized string similar to Some files in your project are not writable. You m....
        /// </summary>
        ProjectHasReadOnlyFiles,
        /// <summary>
        ///   Looks up a localized string similar to Do you want to save the changes?.
        /// </summary>
        QuerySaveChanges,
        /// <summary>
        ///   Looks up a localized string similar to Version: {0}.
        /// </summary>
        /// <remarks>
        /// @Invariant
        /// </remarks>
        Version,
        /// <summary>
        ///   Looks up a localized string similar to You have unsaved changes; reloading all resources ....
        /// </summary>
        WarningUnsavedChanges,
    }

    /// <summary>
    /// Specifies a localized description for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
    public sealed class LocalizedDescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        private readonly StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedDescriptionAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedDescriptionAttribute(StringResourceKey resourceKey)
        {
            _resourceKey = resourceKey;
        }

        /// <summary>
        /// Gets the localized description from the resource id stored in this attribute.
        /// </summary>
        public override string Description
        {
            get
            {
                return Resources.ResourceManager.GetString(_resourceKey.ToString());
            }
        }
    }

    /// <summary>
    /// Specifies a localized display name for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
    public sealed class LocalizedDisplayNameAttribute : System.ComponentModel.DisplayNameAttribute
    {
        private readonly StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedDisplayNameAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedDisplayNameAttribute(StringResourceKey resourceKey)
        {
            _resourceKey = resourceKey;
        }

        /// <summary>
        /// Gets the localized display name from the resource id stored in this attribute.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return Resources.ResourceManager.GetString(_resourceKey.ToString());
            }
        }
    }

    /// <summary>
    /// Specifies a localized display name for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
    public sealed class LocalizedCategoryAttribute : System.ComponentModel.CategoryAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedCategoryAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedCategoryAttribute(StringResourceKey resourceKey)
            : base(resourceKey.ToString())
        {
        }

        /// <summary>
        /// Gets the localized category name from the resource id stored in this attribute.
        /// </summary>
        protected override string GetLocalizedString(string value)
        {
            return Resources.ResourceManager.GetString(value);
        }
    }

    /// <summary>
    /// Specifies a localized display name for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public sealed class LocalizedTextAttribute : global::TomsToolbox.Desktop.TextAttribute
    {
        // This code is generated by Resources.Designer.t4
        // If you get compile errors because you don't use the TomsToolbox.Desktop NuGet package, remove this part in the Resources.Designer.t4 file. 
        // Just search for this text and follow the instructions above.

        private readonly StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedTextAttribute"/> class.
        /// </summary>
        /// <param name="key">Any user defined key to specify the usage of this text.</param>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedTextAttribute(object key, StringResourceKey resourceKey)
            : base(key)
        {
            _resourceKey = resourceKey;
        }

        /// <summary>
        /// Gets the localized text from the resource id stored in this attribute.
        /// </summary>
        public override string Text
        {
            get
            {
                return Resources.ResourceManager.GetString(_resourceKey.ToString());
            }
        }
    }

    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.DataTypeAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class DataTypeAttribute : System.ComponentModel.DataAnnotations.DataTypeAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypeAttribute"/> class.
        /// </summary>
        public DataTypeAttribute(StringResourceKey resourceKey, System.ComponentModel.DataAnnotations.DataType dataType)
            : base(dataType)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypeAttribute"/> class.
        /// </summary>
        public DataTypeAttribute(StringResourceKey resourceKey, string customDataType)
            : base(customDataType)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(Resources);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    
    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.RangeAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class RangeAttribute : System.ComponentModel.DataAnnotations.RangeAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeAttribute"/> class.
        /// </summary>
        public RangeAttribute(StringResourceKey resourceKey, int minimum, int maximum)
            : base(minimum, maximum)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeAttribute"/> class.
        /// </summary>
        public RangeAttribute(StringResourceKey resourceKey, double minimum, double maximum)
            : base(minimum, maximum)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeAttribute"/> class.
        /// </summary>
        public RangeAttribute(StringResourceKey resourceKey, Type type, string minimum, string maximum)
            : base(type, minimum, maximum)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(Resources);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    
    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.RegularExpressionAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class RegularExpressionAttribute : System.ComponentModel.DataAnnotations.RegularExpressionAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegularExpressionAttribute"/> class.
        /// </summary>
        public RegularExpressionAttribute(StringResourceKey resourceKey, string pattern)
            : base(pattern)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(Resources);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    
    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.RequiredAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class RequiredAttribute : System.ComponentModel.DataAnnotations.RequiredAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredAttribute"/> class.
        /// </summary>
        public RequiredAttribute(StringResourceKey resourceKey)
            : base()
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(Resources);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    
    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.StringLengthAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class StringLengthAttribute : System.ComponentModel.DataAnnotations.StringLengthAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringLengthAttribute"/> class.
        /// </summary>
        public StringLengthAttribute(StringResourceKey resourceKey, int maximumLength)
            : base(maximumLength)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(Resources);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    

}
