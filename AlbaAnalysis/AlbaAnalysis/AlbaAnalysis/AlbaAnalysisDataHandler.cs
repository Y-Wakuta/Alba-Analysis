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
        public string pathBase = @"../../../Log/";

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

            _fileBl = new BindingList<string>(AddAllPath());
            _fileS.DataSource = _fileBl;
        }

        public void resetFileList() {
            _fileBl.Clear();
            _fileBl = new BindingList<string>(AddAllPath());
            _fileS.DataSource = _fileBl;
        }

        private List<string> AddAllPath() {
            return new List<string>(Directory.GetFiles(pathBase, "*.csv", SearchOption.AllDirectories)
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
