﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSRule.Resources {
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
    internal class ReportStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ReportStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PSRule.Resources.ReportStrings", typeof(ReportStrings).Assembly);
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
        ///   Looks up a localized string similar to Related resources.
        /// </summary>
        internal static string Markdown_Links {
            get {
                return ResourceManager.GetString("Markdown_Links", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Outcome.
        /// </summary>
        internal static string Markdown_Outcome {
            get {
                return ResourceManager.GetString("Markdown_Outcome", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Recommendation.
        /// </summary>
        internal static string Markdown_Recommendation {
            get {
                return ResourceManager.GetString("Markdown_Recommendation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result summary.
        /// </summary>
        internal static string Markdown_Results {
            get {
                return ResourceManager.GetString("Markdown_Results", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following results were reported..
        /// </summary>
        internal static string Markdown_ResultText {
            get {
                return ResourceManager.GetString("Markdown_ResultText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name.
        /// </summary>
        internal static string Markdown_TargetName {
            get {
                return ResourceManager.GetString("Markdown_TargetName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type.
        /// </summary>
        internal static string Markdown_TargetType {
            get {
                return ResourceManager.GetString("Markdown_TargetType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to See details [online]({0})..
        /// </summary>
        internal static string NUnit_DetailsLink {
            get {
                return ResourceManager.GetString("NUnit_DetailsLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following reasons were reported:.
        /// </summary>
        internal static string NUnit_ReportedReasons {
            get {
                return ResourceManager.GetString("NUnit_ReportedReasons", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The directory into which the repo was cloned..
        /// </summary>
        internal static string SARIF_REPOROOT_Description {
            get {
                return ResourceManager.GetString("SARIF_REPOROOT_Description", resourceCulture);
            }
        }
    }
}
