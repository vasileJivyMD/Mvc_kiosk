//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvc_Kiosk
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_GAME_TYPES_CONFIG
    {
        public int CONFIG_ID { get; set; }
        public int GAME_TYPE_ID { get; set; }
        public int GAME_TYPE_CONFIG_GROUP { get; set; }
    
        public virtual T_CONFIG_VALUES T_CONFIG_VALUES { get; set; }
    }
}
