using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wms_transmitter.Domain;
using System.Collections;
using wms_transmitter.VO;

namespace wms_transmitter.Dao
{
    /// <summary>
    /// 系统参数接口
    /// </summary>
    public interface INoticeMDao
    {
        int insertNoticeM(NoticeM noticeM);

        bool insertNoticeMD(NoticeM noticeM);

        int updateNoticeM(ValObj vo);

        int cancelNoticeM(string djbh); 
        
        String selectTest(string djbh);

        int ReverseNoticeM(string djbh);

        int ReverseNoticeD(string djbh);

        bool deleteNoticeM(string djbh);
    }
}
