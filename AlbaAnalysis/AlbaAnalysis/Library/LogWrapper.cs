using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            var lines = File.ReadAllLines(filePath);
            var props = typeof(Y).GetSortedProperties();
            var list = new List<Y>();
            foreach (var l in lines) {
                var rets = l.Split(',')
                    .Zip(props, (line, prop) => new { data = line, mem = prop });
                var entity = (Y)Activator.CreateInstance(typeof(Y));
                foreach (var ret in rets)
                    ret.mem.SetValue(entity, double.Parse(ret.data));
                list.Add(entity);
            }
            return list;
            //ここで型もわかるようになったし、変数名とヘッダの値を見て比較したらいいかとも思ったが、変数名を変えた時の修正が結構面倒になる。
            //orderを付けて確実に出力できるようにする？
        }

        /// <summary>
        /// excelから一括でレコードを取り出す。初めに全てメモリに乗せてしまうので、そこまで速くなくてもよい
        /// </summary>
        public Tuple<List<T>, List<U>, List<V>, List<W>> Read(string directoryPath) {//2017まではファイルのパスをcomboboxに表示していたが、今年はディレクトリ名を出すようにする
            var typeArray = new[] { typeof(T), typeof(U), typeof(V), typeof(W) };
            var listT = new List<T>();
            var listU = new List<U>();
            var listV = new List<V>();
            var listW = new List<W>();

            //4つのexcelファイルから全てデータを取り出して時間別にログを整列して、valuetupleにして返す
            var fileNames = Directory.GetFiles(directoryPath);  //クラス名がファイルに含まれているかで紐づける？
            var typeDispNameDict = new Dictionary<string, Type>();
            typeArray.ToList().ForEach(t => typeDispNameDict.Add((Attribute.GetCustomAttribute(t, typeof(DisplayAttribute)) as DisplayAttribute).Name, t));
            foreach (var fn in fileNames)
                foreach (var dictName in typeDispNameDict)
                    if (fn.Contains(dictName.Key)) {
                        if (typeof(T) == dictName.Value)
                            listT = readList(fn, (T)Activator.CreateInstance(dictName.Value));
                        else if (typeof(U) == dictName.Value)
                            listU = readList(fn, (U)Activator.CreateInstance(dictName.Value));
                        else if (typeof(V) == dictName.Value)
                            listV = readList(fn, (V)Activator.CreateInstance(dictName.Value));
                        else if (typeof(W) == dictName.Value)
                            listW = readList(fn, (W)Activator.CreateInstance(dictName.Value));
                    }
            return Tuple.Create(listT, listU, listV, listW);
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
                var props = typeof(Y).GetSortedProperties();

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
