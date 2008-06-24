﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.1434
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueFlame.Classes.DatabaseObjects {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SqlStatements {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlStatements() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BlueFlame.Classes.DatabaseObjects.SqlStatements", typeof(SqlStatements).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
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
        ///   Sucht eine lokalisierte Zeichenfolge, die SELECT productid FROM products where file = ?file ähnelt.
        /// </summary>
        internal static string Disc_GetAllProducts {
            get {
                return ResourceManager.GetString("Disc_GetAllProducts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die INSERT INTO images VALUES(?file,?lang,?date,?path,?ext,?dvdmedia) ähnelt.
        /// </summary>
        internal static string Image_Create {
            get {
                return ResourceManager.GetString("Image_Create", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die DELETE FROM images WHERE file = ?file LIMIT 1 ähnelt.
        /// </summary>
        internal static string Image_Remove {
            get {
                return ResourceManager.GetString("Image_Remove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die UPDATE images SET lang = ?lang, date = ?date, path = ?path, ext = ?ext, dvdmedia = ?dvdmedia
        ///WHERE file = ?file LIMIT 1 ähnelt.
        /// </summary>
        internal static string Image_Save {
            get {
                return ResourceManager.GetString("Image_Save", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die INSERT INTO license VALUES(?file,?productid,?licensekey,?distributed,?multi,?insertdate) ähnelt.
        /// </summary>
        internal static string License_Create {
            get {
                return ResourceManager.GetString("License_Create", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die DELETE FROM license WHERE file = ?file AND productid = ?productid AND licensekey = ?licensekey LIMIT 1 ähnelt.
        /// </summary>
        internal static string License_Remove {
            get {
                return ResourceManager.GetString("License_Remove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die UPDATE license SET distributed = ?distributed,multi = ?multi,insertdate = ?insertdate WHERE file = ?file AND productid = ?productid AND licensekey = ?licensekey LIMIT 1 ähnelt.
        /// </summary>
        internal static string License_Save {
            get {
                return ResourceManager.GetString("License_Save", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die INSERT INTO products VALUES(?file,?productid,?productname,?productdescription,?licensefromfile,?licensefromproductid) ähnelt.
        /// </summary>
        internal static string Product_Create {
            get {
                return ResourceManager.GetString("Product_Create", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die DELETE FROM products WHERE file = ?file AND productid = ?productid LIMIT 1 ähnelt.
        /// </summary>
        internal static string Product_Remove {
            get {
                return ResourceManager.GetString("Product_Remove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die UPDATE products SET productname = ?productname, productdescription = ?productdescription,licensefromfile = ?licensefromfile,licensefromproductid = ?licensefromproductid WHERE file = ?file AND productid = ?productid LIMIT 1 ähnelt.
        /// </summary>
        internal static string Product_Save {
            get {
                return ResourceManager.GetString("Product_Save", resourceCulture);
            }
        }
    }
}
