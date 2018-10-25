using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IBatisNet.DataMapper;
using wms_transmitter.Domain;
using System.Collections;
using System.Windows.Forms;
using wms_transmitter.VO;
using wms_transmitter.Common;
using Oracle.ManagedDataAccess.Client;

namespace wms_transmitter.Dao.Impl
{
    /// <summary>
    /// 系统参数实现类
    /// </summary>
    public class NoticeMDaoImpl : BaseDao, INoticeMDao
    {
        public NoticeMDaoImpl() : base() { }
        public NoticeMDaoImpl(ISqlMapper map) : base(map) { }



        /// <summary>
        /// 插入退货单主档信息
        /// </summary>
        /// <param name="noticeM"></param>
        /// <returns></returns>
        public int insertNoticeM(NoticeM noticeM)
        {
            int r = 0;
            try
            {
                r = Convert.ToInt32(GetMapper().Insert("NoticeM.insertNoticeM", noticeM));
            }
            catch (OracleException oe)
            {
                if (oe.Number == 1)//主键重复
                {
                    r = 1;
                }
                else if (oe.Number == 12543)//数据库链接断开
                {
                    throw new InterfaceException(InterfaceExceptionType.ReTry, oe.Message);
                }
            }
            return r;
        }

        /// <summary>
        /// 插入主档和明细
        /// </summary>
        /// <param name="noticeM"></param>
        public bool insertNoticeMD(NoticeM noticeM)
        {
            //bool result = true;
            //ISqlMapper map = GetMapper();
            //map.BeginTransaction();
            //try
            //{
            //    //插入单据主档
            //    map.Insert("NoticeM.insertNoticeM", noticeM);
            //    //指插入单据明细
            //    IDictionary dt = new Dictionary<string, IList>();
            //    dt.Add("listItem", noticeM.dList);
            //    map.Insert("NoticeD.insertNoticeDBatch", dt);
                
            //    map.CommitTransaction();
            //}
            //catch (OracleException oe)
            //{
            //    if (oe.Number == 1)//主键重复
            //    {
            //        result = false;
            //        Logger.WritingLog("退货单" + noticeM.djbh + "已经存在！");
            //    }
            //    else if (oe.Number == 12543)//数据库链接断开
            //    {
            //        map.RollBackTransaction();
            //        throw new InterfaceException(InterfaceExceptionType.ReTry, oe.Message);
            //    }
            //    else
            //    {
            //        map.RollBackTransaction();
            //        throw new InterfaceException(InterfaceExceptionType.ReTry, oe.Message);
            //    }
            //    map.RollBackTransaction();
            //}
            //catch
            //{
            //    result = false;
            //    map.RollBackTransaction();
            //}
            //return result;

            bool result = false;
            ISqlMapper map = GetMapper();
            map.BeginTransaction();
            try
            {
                //插入单据主档
                map.Insert("NoticeM.insertNoticeM", noticeM);
                //指插入单据明细
                IDictionary dt = new Dictionary<string, IList>();
                dt.Add("listItem", noticeM.dList);
                map.Insert("NoticeD.insertNoticeDBatch", dt);

                map.CommitTransaction();

                result = true;
            }
            catch
            {
                result = false;
                map.RollBackTransaction();
            }
            return result;

        }

        /// <summary>
        /// 更新退货单信息
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int updateNoticeM(ValObj vo)
        {
            return Convert.ToInt32(GetMapper().Update("NoticeM.updateNoticeM", vo));
        }

        /// <summary>
        /// 删除退货单
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int cancelNoticeM(string djbh)
        {
            return Convert.ToInt32(GetMapper().Update("NoticeM.cancelNoticeM", djbh));
        }

        /// <summary>
        /// 反审成功则删除退货单，转入历史表
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public bool deleteNoticeM(string djbh)
        {
            bool result = true;
            ISqlMapper map = GetMapper();
            map.BeginTransaction();
            try
            {
                //插入单据明细到历史表
                map.Insert("NoticeD.insertNoticeDHTY", djbh);
                //删除单据明细
                map.Delete("NoticeD.deleteNoticeD", djbh);
                //主档数据插入历史表
                map.Insert("NoticeM.insertNoticeMHTY", djbh);
                //删除单据主档
                map.Delete("NoticeM.deleteNoticeM", djbh);
                
                map.CommitTransaction();
            }
            catch (OracleException oe)
            {
                if (oe.Number == 1)//主键重复
                {
                    result = true;
                }
                else if (oe.Number == 12543)//数据库链接断开
                {
                    map.RollBackTransaction();
                    throw new InterfaceException(InterfaceExceptionType.ReTry, oe.Message);
                }
                else
                {
                    map.RollBackTransaction();
                    throw new InterfaceException(InterfaceExceptionType.ReTry, oe.Message);
                }
                map.RollBackTransaction();
            }
            catch (Exception ex)
            {
                result = false;
                map.RollBackTransaction();
                throw new InterfaceException(InterfaceExceptionType.NoReTry, ex.Message);
            }
            return result;
        }

        /// <summary>
        /// 反审退货总单
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int ReverseNoticeM(string djbh)
        {
            return Convert.ToInt32(GetMapper().QueryForObject("NoticeM.SelectNoticeMCanReverse", djbh));
        }

        /// <summary>
        /// 反审退货详单
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        public int ReverseNoticeD(string djbh)
        {
            return Convert.ToInt32(GetMapper().QueryForObject("NoticeM.SelectNoticeDCanReverse", djbh));
        }

        public String selectTest(string djbh)
        {
            return (string)GetMapper().QueryForObject("NoticeM.selectTest", djbh);
        }

    }
}