﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CubeApp.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CubeApp.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Coordinate X:.
        /// </summary>
        internal static string CoordinateX {
            get {
                return ResourceManager.GetString("CoordinateX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Coordinate Y:.
        /// </summary>
        internal static string CoordinateY {
            get {
                return ResourceManager.GetString("CoordinateY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Coordinate Z:.
        /// </summary>
        internal static string CoordinateZ {
            get {
                return ResourceManager.GetString("CoordinateZ", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CUBE A:.
        /// </summary>
        internal static string CubeAHead {
            get {
                return ResourceManager.GetString("CubeAHead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CUBE B:.
        /// </summary>
        internal static string CubeBHead {
            get {
                return ResourceManager.GetString("CubeBHead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dimension:.
        /// </summary>
        internal static string Dimension {
            get {
                return ResourceManager.GetString("Dimension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The intersection volume between cubeA and cubeB is.
        /// </summary>
        internal static string Result {
            get {
                return ResourceManager.GetString("Result", resourceCulture);
            }
        }
    }
}
