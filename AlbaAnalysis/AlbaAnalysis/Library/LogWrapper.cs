using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

        private List<Y> readList<Y>(string filePath, Y y) {
            //ここで型もわかるようになったし、変数名とヘッダの値を見て比較したらいいかとも思ったが、変数名を変えた時の修正が結構面倒になる。
            //orderを付けて確実に出力できるようにする？
        }

        /// <summary>
        /// excelから一括でレコードを取り出す。初めに全てメモリに乗せてしまうので、そこまで速くなくてもよい
        /// </summary>
        public Tuple<List<T>, List<U>, List<V>, List<W>> Read(string directoryPath) {//2017まではファイルのパスをcomboboxに表示していたが、今年はディレクトリ名を出すようにする
            var typeArray = new[] { typeof(T), typeof(U), typeof(V), typeof(W) };

            //4つのexcelファイルから全てデータを取り出して時間別にログを整列して、valuetupleにして返す
            var fileNames = Directory.GetFiles(directoryPath);  //クラス名がファイルに含まれているかで紐づける？
            var typeDispNameDict = new Dictionary<string, Type>();
            typeArray.ToList().ForEach(t => typeDispNameDict.Add((Attribute.GetCustomAttribute(t, typeof(DisplayNameAttribute)) as DisplayNameAttribute).DisplayName, t));
            foreach (var fn in fileNames)
                foreach (var dictName in typeDispNameDict)
                    if (fn.Contains(dictName.Key))
                        readList(fn, dictName.Value);

        }

        /// <summary>
        /// excelにappendしてきたデータを出力する。遅くてもよい
        /// </summary>
        private void exportList<Y>(string directoryPath, List<Y> target) {
            //データ型に対応するリスト
            if (!System.IO.Directory.Exists(directoryPath))
                System.IO.Directory.CreateDirectory(directoryPath);

            var className = Attribute.GetCustomAttribute(typeof(Y), typeof(DisplayNameAttribute)) as DisplayNameAttribute;

            using (var sw = new StreamWriter(directoryPath + className.DisplayName + ".csv", append: true)) {
                var props = typeof(Y).GetProperties();

                var headerArray = props.Select(p => nameof(p));
                sw.Write(String.Join(",", headerArray));

                foreach (var t in target) {
                    var strArray = props.Select(p => p.GetValue(t).ToString());
                    sw.Write(String.Join(",", strArray));
                }
            }
        }

        public void Export(string parentpath) {
            exportList(parentpath, listT);
            exportList(parentpath, listU);
            exportList(parentpath, listV);
            exportList(parentpath, listW);
        }
    }
}
