//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFirstApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class hm_imapfolders
    {
        public int folderid { get; set; }
        public int folderaccountid { get; set; }
        public int folderparentid { get; set; }
        public string foldername { get; set; }
        public byte folderissubscribed { get; set; }
        public System.DateTime foldercreationtime { get; set; }
        public long foldercurrentuid { get; set; }
    }
}
