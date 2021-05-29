using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionRepCheck.Entity
{
    class DVDProductionInfoEntity : ProductionInfoEntity
    {
        /// <summary>
        /// パラメータなしのコンストラクタ
        /// </summary>
        public DVDProductionInfoEntity()
        {
            MakerCodeRF = 0;
            FrameModelRF = string.Empty;
            StProduceFrameNoRF = 0;
            EdProduceFrameNoRF = 0;
            ProduceTypeOfYearRF = 0;
        }

        /// <summary>
        /// 「メーカーコード,車台型式,生産車台番号開始,生産車台番号終了,生産年式」の順番でセット
        /// </summary>
        /// <param name="dataInfo"></param>
        public override void SetData(string dataInfo)
        {
            MakerCodeRF = int.Parse(dataInfo.Substring(0, 2));
            FrameModelRF = dataInfo.Substring(2, 20);
            StProduceFrameNoRF = int.Parse(dataInfo.Substring(22, 7));
            EdProduceFrameNoRF = int.Parse(dataInfo.Substring(29, 7));
            ProduceTypeOfYearRF = int.Parse(dataInfo.Substring(36, 6));
        }

        /// <summary>
        /// メーカーコード、車台型式のキー取得
        /// </summary>
        /// <returns></returns>
        public override string GetMakerCodeFrameModelKey()
        {
            return MakerCodeRF + FrameModelRF;
        }

        /// <summary>
        /// CSV出力するために、ToString()をoverrideする
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MakerCodeRF + "," + FrameModelRF + "," +
                string.Format("{0:0000000}", StProduceFrameNoRF) + "," +
                string.Format("{0:0000000}", EdProduceFrameNoRF) + "," + 
                ProduceTypeOfYearRF;
        }
    }
}
