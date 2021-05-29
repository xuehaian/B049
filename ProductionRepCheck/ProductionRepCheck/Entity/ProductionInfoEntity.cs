using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionRepCheck.Entity
{
    abstract class ProductionInfoEntity
    {
        // メーカーコード
        int makerCodeRF;
        // 車台型式
        string frameModelRF;
        // 生産車台番号開始
        int stProduceFrameNoRF;
        // 生産車台番号終了
        int edProduceFrameNoRF;
        // 生産年式
        int produceTypeOfYearRF;

        public int MakerCodeRF { get => makerCodeRF; set => makerCodeRF = value; }
        public string FrameModelRF { get => frameModelRF; set => frameModelRF = value; }
        public int StProduceFrameNoRF { get => stProduceFrameNoRF; set => stProduceFrameNoRF = value; }
        public int EdProduceFrameNoRF { get => edProduceFrameNoRF; set => edProduceFrameNoRF = value; }
        public int ProduceTypeOfYearRF { get => produceTypeOfYearRF; set => produceTypeOfYearRF = value; }

        public abstract void SetData(string dataInfo);

        public abstract string GetMakerCodeFrameModelKey();

    }
}
