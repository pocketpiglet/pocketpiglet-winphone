﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.586
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PocketPiglet {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class AppResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PocketPiglet.AppResources", typeof(AppResources).Assembly);
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
        ///   Looks up a localized string similar to Get ready to remember a sandwich recipe....
        /// </summary>
        public static string FeedGamePageTextBlockLevelTextHint {
            get {
                return ResourceManager.GetString("FeedGamePageTextBlockLevelTextHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Level {0:D} of {1:D}..
        /// </summary>
        public static string FeedGamePageTextBlockLevelTextLevelNum {
            get {
                return ResourceManager.GetString("FeedGamePageTextBlockLevelTextLevelNum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        public static string MessageBoxHeaderError {
            get {
                return ResourceManager.GetString("MessageBoxHeaderError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Info.
        /// </summary>
        public static string MessageBoxHeaderInfo {
            get {
                return ResourceManager.GetString("MessageBoxHeaderInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning.
        /// </summary>
        public static string MessageBoxHeaderWarning {
            get {
                return ResourceManager.GetString("MessageBoxHeaderWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Game over. Do you want to play again?.
        /// </summary>
        public static string MessageBoxMessageGameOverQuestion {
            get {
                return ResourceManager.GetString("MessageBoxMessageGameOverQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This game is available in the full version only. Do you want to purchase full version now?.
        /// </summary>
        public static string MessageBoxMessageGameTrialVersionQuestion {
            get {
                return ResourceManager.GetString("MessageBoxMessageGameTrialVersionQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Congratulations, you have just won the game! Do you want to play again?.
        /// </summary>
        public static string MessageBoxMessageGameWonQuestion {
            get {
                return ResourceManager.GetString("MessageBoxMessageGameWonQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not open Marketplace:.
        /// </summary>
        public static string MessageBoxMessageMarketplaceOpenError {
            get {
                return ResourceManager.GetString("MessageBoxMessageMarketplaceOpenError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are currently playing music on your phone. Pet will not be able to move or talk while music is playing. Do you want to pause music until application exit?.
        /// </summary>
        public static string MessageBoxMessageMusicPauseQuestion {
            get {
                return ResourceManager.GetString("MessageBoxMessageMusicPauseQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Congratulations, you have a new highscore! Do you want to play again?.
        /// </summary>
        public static string MessageBoxMessageNewHighscoreQuestion {
            get {
                return ResourceManager.GetString("MessageBoxMessageNewHighscoreQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pet talk is available just for a limited time in trial version. Pet will not talk until application restart. Do you want to purchase full version now?.
        /// </summary>
        public static string MessageBoxMessageTalkTrialVersionQuestion {
            get {
                return ResourceManager.GetString("MessageBoxMessageTalkTrialVersionQuestion", resourceCulture);
            }
        }
    }
}
