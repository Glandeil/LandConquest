﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LandConquest.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LandConquest.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
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
        ///   Поиск локализованного ресурса типа System.Byte[].
        /// </summary>
        internal static byte[] HARNGTON {
            get {
                object obj = ResourceManager.GetObject("HARNGTON", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.IO.UnmanagedMemoryStream, аналогичного System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream MainTheme {
            get {
                return ResourceManager.GetStream("MainTheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.IO.UnmanagedMemoryStream, аналогичного System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream MainTheme2 {
            get {
                return ResourceManager.GetStream("MainTheme2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.IO.UnmanagedMemoryStream, аналогичного System.IO.MemoryStream.
        /// </summary>
        internal static System.IO.UnmanagedMemoryStream MainTheme3 {
            get {
                return ResourceManager.GetStream("MainTheme3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на End-User License Agreement (EULA) of Land Conquest.
        ///This End-User License Agreement (&quot;EULA&quot;) is a legal agreement between you and Land Conquest.
        ///This EULA agreement governs your acquisition and use of our Land Conquest software (&quot;Software&quot;) directly from Land Conquest or indirectly through a Land Conquest authorized reseller or distributor (a &quot;Reseller&quot;).
        ///Please read this EULA agreement carefully before completing the registration process and using the Land Conquest software. It provides a license to use [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string UserAgreement {
            get {
                return ResourceManager.GetString("UserAgreement", resourceCulture);
            }
        }
    }
}
