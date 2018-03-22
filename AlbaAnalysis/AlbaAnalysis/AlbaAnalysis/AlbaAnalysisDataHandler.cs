using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.ComponentModel;
using System.IO.Ports;
using System.IO;
using AlbaAnalysis.Entity;

namespace AlbaAnalysis {
    public class AlbaAnalysisDataHandler {

        BindingSource _baudS = new BindingSource();
        BindingSource _portS = new BindingSource();
        BindingSource _fileS = new BindingSource();
        BindingList<BaudRateEntity> _baudBl;
        BindingList<string> _portBl;
        BindingList<string> _fileBl;

        public AlbaAnalysisDataHandler(BindingSource baudS, BindingSource portS, BindingSource fileS) {
            _baudS = baudS;
            _portS = portS;
            _fileS = fileS;
            _baudBl = new BindingList<BaudRateEntity>(setBaudList());
            _baudS.DataSource = _baudBl;

            _portBl = new BindingList<string>(SerialPort.GetPortNames().ToList());
            if (_portBl.Count == 0)
                _portBl.Add("利用可能なシリアルポートは存在しません。");
            _portS.DataSource = _portBl;

            if (!Directory.Exists(Constants.pathBase))
                Directory.CreateDirectory(Constants.pathBase);
            _fileBl = new BindingList<string>(AddAllPath());
            _fileS.DataSource = _fileBl;
        }

        public void resetFileList() {
            _fileBl.Clear();
            _fileBl = new BindingList<string>(AddAllPath());
            _fileS.DataSource = _fileBl;
        }


        public Tuple<FirstEntity, SecondEntity, ThirdEntity, ForthEntity> PopRecord(List<FirstEntity> first, List<SecondEntity> second, List<ThirdEntity> third, List<ForthEntity> fourth) {
            //それぞれのlistから計測時間の小さいデータを抜き出してリストのデータを一つ減らすようなメソッドがほしい
            var dict = new Dictionary<Type, double>() {
                { typeof(FirstEntity), first.First().AirSpeedTime },
                { typeof(SecondEntity), second.First().MpuTime },
                { typeof(FirstEntity),third.First().ControlTime },
                { typeof(FirstEntity), fourth.First().ControlTime },
            };

            var min = dict.Select(d => new { key = d.Key, value = d.Value }).Min(d => d.value);
            var min_key = dict.First(d => d.Value == min).Key;

            if (min_key == typeof(FirstEntity)) {
                var tmp = first[0];
                first.RemoveAt(0);
                return Tuple.Create<FirstEntity, SecondEntity, ThirdEntity, ForthEntity>(tmp, null, null, null);
            } else if (min_key == typeof(SecondEntity)) {
                var tmp = second.First();
                second.RemoveAt(0);
                return Tuple.Create<FirstEntity, SecondEntity, ThirdEntity, ForthEntity>(null, tmp, null, null);
            } else if (min_key == typeof(ThirdEntity)) {
                var tmp = third.First();
                third.RemoveAt(0);
                return Tuple.Create<FirstEntity, SecondEntity, ThirdEntity, ForthEntity>(null, null, tmp, null);
            } else if (min_key == typeof(ForthEntity)) {
                var tmp = fourth.First();
                fourth.RemoveAt(0);
                return Tuple.Create<FirstEntity, SecondEntity, ThirdEntity, ForthEntity>(null, null, null, tmp);
            }
            return Tuple.Create<FirstEntity, SecondEntity, ThirdEntity, ForthEntity>(null, null, null, null);
        }

        private List<string> AddAllPath() {
            return new List<string>(Directory.GetFiles(Constants.pathBase, "*.csv", SearchOption.AllDirectories)
                .ToList()
                .Where(p => {
                    var file = new System.IO.FileInfo(p);
                    return file.Length != 0;
                }));
        }

        private List<BaudRateEntity> setBaudList() {
            return new List<BaudRateEntity> {
            new BaudRateEntity {
                name = "4800bps",
                rate = 4800
             },
            new BaudRateEntity {
                name = "14400bps",
                rate = 14400
            },
             new BaudRateEntity {
                name = "115200bps",
                rate = 115200
            }
            };
        }
    }
}