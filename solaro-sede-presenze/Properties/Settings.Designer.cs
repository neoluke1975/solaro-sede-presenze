﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace solaro_sede_presenze.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:/program files/winfarm/archivi/arc2000.phs")]
        public string connessione_solaro1_remota {
            get {
                return ((string)(this["connessione_solaro1_remota"]));
            }
            set {
                this["connessione_solaro1_remota"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:/program files/winfarm/archivi/arc2000.phs")]
        public string connessione_solaro2_remota {
            get {
                return ((string)(this["connessione_solaro2_remota"]));
            }
            set {
                this["connessione_solaro2_remota"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:/program files/winfarm/archivi/arc2000.phs")]
        public string connessione_solaro1_locale {
            get {
                return ((string)(this["connessione_solaro1_locale"]));
            }
            set {
                this["connessione_solaro1_locale"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("c:/program files/winfarm/archivi/arc2000.phs")]
        public string connessione_solaro2_locale {
            get {
                return ((string)(this["connessione_solaro2_locale"]));
            }
            set {
                this["connessione_solaro2_locale"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string ip_solaro1 {
            get {
                return ((string)(this["ip_solaro1"]));
            }
            set {
                this["ip_solaro1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string ip_solaro2 {
            get {
                return ((string)(this["ip_solaro2"]));
            }
            set {
                this["ip_solaro2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string ip_solaro1_locale {
            get {
                return ((string)(this["ip_solaro1_locale"]));
            }
            set {
                this["ip_solaro1_locale"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string ip_solaro2_locale {
            get {
                return ((string)(this["ip_solaro2_locale"]));
            }
            set {
                this["ip_solaro2_locale"] = value;
            }
        }
    }
}
