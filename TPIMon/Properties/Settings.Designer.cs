﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TPIMon.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://172.16.160.53:8020/")]
        public string SERVER {
            get {
                return ((string)(this["SERVER"]));
            }
            set {
                this["SERVER"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("modem/index.jsp")]
        public string MODEM_INDEX {
            get {
                return ((string)(this["MODEM_INDEX"]));
            }
            set {
                this["MODEM_INDEX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("modem/status.jsp?id=RU")]
        public string MODEM_PAGE {
            get {
                return ((string)(this["MODEM_PAGE"]));
            }
            set {
                this["MODEM_PAGE"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int MODEM_NUM {
            get {
                return ((int)(this["MODEM_NUM"]));
            }
            set {
                this["MODEM_NUM"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5000")]
        public int NET_TIMEOUT {
            get {
                return ((int)(this["NET_TIMEOUT"]));
            }
            set {
                this["NET_TIMEOUT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("RU041 RU042 RU043 RU044 RU045 RU047 RU048 RU050 RU052 RU053 RU055 RU056 RU057 RU0" +
            "58")]
        public string ASUDD_LIST {
            get {
                return ((string)(this["ASUDD_LIST"]));
            }
            set {
                this["ASUDD_LIST"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("preview?modem-id=")]
        public string IMAGE_PREVIEW {
            get {
                return ((string)(this["IMAGE_PREVIEW"]));
            }
            set {
                this["IMAGE_PREVIEW"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Параметр {
            get {
                return ((string)(this["Параметр"]));
            }
            set {
                this["Параметр"] = value;
            }
        }
    }
}
