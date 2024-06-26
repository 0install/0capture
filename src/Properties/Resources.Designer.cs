﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZeroInstall.Publish.Capture.Cli.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ZeroInstall.Publish.Capture.Cli.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Captures snapshots of the system state and compares them to generate a feed..
        /// </summary>
        internal static string DescriptionCapture {
            get {
                return ResourceManager.GetString("DescriptionCapture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file &apos;{0}&apos; already exists. Use --force to overwrite..
        /// </summary>
        internal static string FileAlreadyExists {
            get {
                return ResourceManager.GetString("FileAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This program comes with ABSOLUTELY NO WARRANTY, to the extent permitted by law.
        ///You may redistribute copies of this program under the terms of the GNU Lesser General Public License..
        /// </summary>
        internal static string LicenseInfo {
            get {
                return ResourceManager.GetString("LicenseInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing arguments. Try {0}.
        /// </summary>
        internal static string MissingArguments {
            get {
                return ResourceManager.GetString("MissingArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {PATH} of the ZIP file to create from the installation directory. Leave unset to create no ZIP archive..
        /// </summary>
        internal static string OptionCollectFiles {
            get {
                return ResourceManager.GetString("OptionCollectFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overwrite existing files..
        /// </summary>
        internal static string OptionForce {
            get {
                return ResourceManager.GetString("OptionForce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show the built-in help text..
        /// </summary>
        internal static string OptionHelp {
            get {
                return ResourceManager.GetString("OptionHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {PATH} of the directory the application to be captured is installed in. Leave unset to auto-detect..
        /// </summary>
        internal static string OptionInstallationDirectory {
            get {
                return ResourceManager.GetString("OptionInstallationDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The relative {PATH} to the main EXE of the application to be captured. Leave unset to auto-detect..
        /// </summary>
        internal static string OptionMainExe {
            get {
                return ResourceManager.GetString("OptionMainExe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Options:.
        /// </summary>
        internal static string Options {
            get {
                return ResourceManager.GetString("Options", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Display version information..
        /// </summary>
        internal static string OptionVersion {
            get {
                return ResourceManager.GetString("OptionVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage:.
        /// </summary>
        internal static string Usage {
            get {
                return ResourceManager.GetString("Usage", resourceCulture);
            }
        }
    }
}
