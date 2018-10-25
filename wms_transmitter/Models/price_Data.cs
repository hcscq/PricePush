using System;
using System.Collections.Generic;

namespace wms_transmitter.Models
{
    public partial class price_Data
    {
        public string spid { get; set; }
        public string hw { get; set; }
        public double chbdj { get; set; }
        public System.DateTime lastModifyTime { get; set; }
        public System.DateTime LastUploadTime { get; set; }
        public int is_pushed { get; set; }
        public string spbh { get; set; }
        public int ID { get; set; }
    }
}
