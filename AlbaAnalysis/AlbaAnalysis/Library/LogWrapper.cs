using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Library {
    /// <summary>
    /// データの保存処理・取得処理などを一括でwrapするクラス
    /// </summary>
    public class LogWrapper<T, U, V, W> {


        public List<T> listT = new List<T>();
        public List<U> listU = new List<U>();
        public List<V> listV = new List<V>();
        public List<W> listW = new List<W>();

        public void Append(T t) => listT.Add(t);
        public void Append(U u) => listU.Add(u);
        public void Append(V v) => listV.Add(v);
        public void Append(W w) => listW.Add(w);

        /// <summary>
        /// excelから一括でレコードを取り出す。初めに全てメモリに乗せてしまうので、そこまで速くなくてもよい
        /// </summary>
        public void Read() {
            //4つのexcelファイルから全てデータを取り出して時間別にログを整列して、valuetupleにして返す

        }

        /// <summary>
        /// excelにappendしてきたデータを出力する。遅くてもよい
        /// </summary>
        public void Export(string parentPath) {
            //データ型に対応するリスト
            if (!System.IO.Directory.Exists(parentPath))
                System.IO.Directory.CreateDirectory(parentPath);

            

        }
    }
}
