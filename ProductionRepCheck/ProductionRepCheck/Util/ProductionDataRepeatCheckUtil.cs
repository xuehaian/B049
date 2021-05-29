using ProductionRepCheck.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionRepCheck.Util
{
    class ProductionDataRepeatCheckUtil<T> where T : ProductionInfoEntity, new()
    {
        

        // key 为 makerCodeRF + frameModelRF  value 为 其所对应的实体类数据
        Dictionary<string, List<T>> makerCodeFramModelDic = null;
        // 存储重复的数据
        Dictionary<string, List<T>> fixedMakerCodeFrameModelDic = new Dictionary<string, List<T>>();
        
        /// <summary>
        /// save datadata to makerCodeDrameModelDic
        /// </summary>
        /// <param name="dataInput"></param>
        public void MakeMakerCodeRFDicFromdataFile(string dataInput)
        {
            List<T> stProduceFrameNoList = null;
            string makerCodeFrameModel;
            int stProduceFrameNoRF;
            // メーカーコード，車台型式をキーとして、車台型式,生産年式キーDICを保存
            makerCodeFramModelDic = new Dictionary<string, List<T>>();

            string dataLineStr = string.Empty;
            using (StreamReader sr = new StreamReader(dataInput))
            {
                // dataファイルから行毎に取得して処理
                while ((dataLineStr = sr.ReadLine()) != null)
                {
                    // 行に内容がないと、次の行に
                    if (dataLineStr.Length <= 0)
                    {
                        continue;
                    }
                    T currEntity = new T();
                    // dataの行から、Entityにする
                    currEntity.SetData(dataLineStr);                
                    makerCodeFrameModel = currEntity.GetMakerCodeFrameModelKey();
                    stProduceFrameNoRF = currEntity.StProduceFrameNoRF;
                    // 尝试获取 makerCodeRF + frameModelRF 所对应的数据
                    if (makerCodeFramModelDic.TryGetValue(makerCodeFrameModel, out stProduceFrameNoList))
                    {
                        stProduceFrameNoList.Add(currEntity);
                    }
                    else
                    {
                        stProduceFrameNoList = new List<T>();
                        stProduceFrameNoList.Add(currEntity);
                        makerCodeFramModelDic.Add(makerCodeFrameModel, stProduceFrameNoList);
                    }
                }
            }
        }

        public void SameRangeCheck()
        {
            SameRangeCheck(makerCodeFramModelDic);
        }

        /// <summary>
        /// 重复Check
        /// </summary>
        /// <param name="makerCodeRFDic"></param>
        private void SameRangeCheck(Dictionary<string, List<T>> makerCodeRFDic)
        {
            int PreStart = 0;
            int PreEnd = 0;
            string makerCoderRF;
            bool LineOneFlag;
            bool continuityFlag;
            T preEntity = null;
            List<T> entityList = null;
            foreach (KeyValuePair<string, List<T>> kv in makerCodeRFDic)
            {
                makerCoderRF = kv.Key;

                // 排序
                List<T> SortDic = kv.Value.OrderBy(p => p.MakerCodeRF).ThenBy(p => p.FrameModelRF).
                    ThenBy(p => p.StProduceFrameNoRF).ThenByDescending(p => p.EdProduceFrameNoRF).ToList();

                // 第一行判断
                LineOneFlag = true;
                // 数据连续判断
                continuityFlag = true;

                foreach (T next in SortDic)
                {
                    // 初始化 PreStart PreEnd
                    if (LineOneFlag)
                    {
                        PreStart = next.StProduceFrameNoRF;
                        PreEnd = next.EdProduceFrameNoRF;
                        preEntity = next;
                        LineOneFlag = false;
                        continue;
                    }

                    // 前条数据的车台番号范围与后一条车台番号范围不相交，交换比较的位置
                    if (PreEnd < next.StProduceFrameNoRF)
                    {
                        PreStart = next.StProduceFrameNoRF;
                        PreEnd = next.EdProduceFrameNoRF;
                        preEntity = next;
                        continuityFlag = true;
                        continue;
                    }

                    // 保存一节连续重复数据的第一条数据
                    if (continuityFlag)
                    {
                        if (fixedMakerCodeFrameModelDic.TryGetValue(makerCoderRF, out entityList))
                        {
                            entityList.Add(preEntity);
                        }
                        else
                        {
                            entityList = new List<T>();
                            entityList.Add(preEntity);
                            fixedMakerCodeFrameModelDic.Add(makerCoderRF, entityList);
                        }
                        continuityFlag = false;
                    }

                    // save repeat data
                    if (fixedMakerCodeFrameModelDic.TryGetValue(makerCoderRF, out entityList))
                    {
                        entityList.Add(next);
                    }
                    else
                    {
                        entityList = new List<T>();
                        entityList.Add(next);
                        fixedMakerCodeFrameModelDic.Add(makerCoderRF, entityList);
                    }
                }
            }
        }

        /// <summary>
        /// data出力
        /// </summary>
        /// <param name="dataOutput"></param>
        public string ExportdataFile(string dataOutput)
        {
            string result;
            if (fixedMakerCodeFrameModelDic.Count == 0)
            {
                result = "无";
            }
            else
            {
                result = "有";
                List<T> sortList = null;
                string dirPath = Path.GetDirectoryName(dataOutput);
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }

                using (StreamWriter sw = new StreamWriter(dataOutput, false, Encoding.Default))
                {
                    Dictionary<string, List<T>>.ValueCollection productionDics = fixedMakerCodeFrameModelDic.Values;

                    foreach (List<T> entityList in productionDics)
                    {
                        sortList = entityList.OrderBy(p => p.StProduceFrameNoRF).ThenBy(p => p.EdProduceFrameNoRF).ToList<T>();
                        foreach (T item in sortList)
                        {
                            sw.WriteLine(item.ToString());
                        }
                        sw.Flush();
                    }
                }
            }
            
            return result;
        }
    }
}
