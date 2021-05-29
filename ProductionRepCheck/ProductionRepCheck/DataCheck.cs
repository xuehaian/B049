using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductionRepCheck.Entity;
using ProductionRepCheck.Util;

namespace ProductionRepCheck
{
    class DataCheck<T> where T : ProductionInfoEntity, new()
    {

        readonly string dataInputPath;
        readonly string dataOUtputPath;

        ProductionDataRepeatCheckUtil<T> dVDProductionUtil = new ProductionDataRepeatCheckUtil<T>();

        /// <summary>
        /// ファイル、パスの設定
        /// </summary>
        /// <param name="dataInputPath"></param>
        /// <param name="dataOUtputPath"></param>
        public DataCheck(string dataInputPath, string dataOUtputPath)
        {
            this.dataInputPath = dataInputPath;
            this.dataOUtputPath = dataOUtputPath;
        }

        /// <summary>
        /// 実行check
        /// </summary>
        /// <param name="result"></param>
        public void Run(out string result)
        {
            dVDProductionUtil.MakeMakerCodeRFDicFromdataFile(dataInputPath);
            dVDProductionUtil.SameRangeCheck();
            result = dVDProductionUtil.ExportdataFile(dataOUtputPath);
        }
    }
}
