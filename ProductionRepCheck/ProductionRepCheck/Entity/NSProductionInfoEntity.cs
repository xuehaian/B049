using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionRepCheck.Entity
{
    class NSProductionInfoEntity : ProductionInfoEntity
    {
        // 提供日付
        int offerDateRF;
        
        public int OfferDateRF { get => offerDateRF; set => offerDateRF = value; }

        /// <summary>
        /// パラメータなしのコンストラクタ
        /// </summary>
        public NSProductionInfoEntity()
        {
            offerDateRF = 0;          
        }

        /// <summary>
        /// 「提供日付,メーカーコード,車台型式,生産車台番号開始,生産車台番号終了,生産年式」の順番でセット
        /// </summary>
        /// <param name="dataInfo"></param>
        public override void SetData(string dataInfo)
        {
            string[] fields = dataInfo.Split(',');
            offerDateRF = int.Parse(fields[0]);
            MakerCodeRF = int.Parse(fields[1]);
            FrameModelRF = fields[2];
            StProduceFrameNoRF = int.Parse(fields[3]);
            EdProduceFrameNoRF = int.Parse(fields[4]);
            ProduceTypeOfYearRF = int.Parse(fields[5]);
        }

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
            return offerDateRF + "," + MakerCodeRF + "," + FrameModelRF + "," + StProduceFrameNoRF + "," + EdProduceFrameNoRF + "," + ProduceTypeOfYearRF;
        }      
        
    }
}
