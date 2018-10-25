using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using wms_transmitter.Domain;
using System.Collections;
using System.Data;
using wms_transmitter.VO;

namespace wms_transmitter.Domain
{
    /// <summary>
    /// 变化明细
    /// </summary>
    [Serializable]
    public class UpdatePrice
    {
        public int ID {get;set;}
        public string SPID
        { get; set; }
        /// <summary>
        /// SPBH
        /// </summary>		
        public string SPBH
        { get; set; }
        /// <summary>
        /// HW
        /// </summary>		
        public string HW
        { get; set; }
        /// <summary>
        /// CHBDJ
        /// </summary>		
        public double CHBDJ
        { get; set; }
        /// <summary>
        /// 状态
        /// </summary>		
        public int IS_PUSHED
        { get; set; }
        public int OLD_STATUS { get; set; }
    }
}
