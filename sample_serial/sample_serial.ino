#define LED_PIN 13

const static String input[40] = {
  "$1,1515762583,-0.067,0,-0.15,56.02,-0.18,0,14"
,"$2,1515762583,-0.062,-0.84679,10.338,12.506,-0.19,34.824,135.52,20"
,"$3,1515762583,-0.068,0,0,0,0,17"
,"$4,1515762583,-1.5e+09,0,-57007,2.4143e+05,0,10"
,"$1,1515762585,-0.067,0,-1.2,54.51,-0.18,0,21"
,"$2,1515762585,-0.062,0.40458,10.676,10.917,-0.19,34.824,135.52,03"
,"$3,1515762585,-0.077,0,0,0,0,1F"
,"$3,1515762635,-0.077,0,0,0,0,17"
,"$2,1515762631,-0.062,24.171,27.536,-2.4295,-0.19,34.824,135.52,1B"
,"$3,1515762631,-0.077,0,0,0,0,13"
,"$4,1515762631,-1.5e+09,0,-55555,2.5667e+05,0,1A"
,"$1,1515762633,-0.067,0,-49,54.51,-0.18,391,04"
,"$2,1515762633,-0.062,5.967,29.804,36.472,-0.19,34.824,135.52,06"
,"$3,1515762633,-0.077,0,0,0,0,11"
,"$4,1515762633,-1.5e+09,0,-54865,2.5739e+05,0,1D"
,"$1,1515762635,-0.067,0,-51,54.51,-0.38,0,02"
,"$2,1515762635,-0.065,24.819,9.1268,6.9488,-0.18,34.824,135.52,31"
,"$4,1515762635,-1.5e+09,0,-55472,2.5806e+05,0,13"
,"$1,1515762637,-0.067,0,-53,54.51,-0.18,45,31"
,"$2,1515762637,-0.062,26.283,11.376,9.1422,-0.19,34.824,135.52,3F"
,"$3,1515762637,-0.077,0,0,0,0,15"
,"$4,1515762637,-1.5e+09,0,-55410,2.5875e+05,0,11"
,"$3,1515762627,-0.077,0,0,0,0,14"
,"$4,1515762627,-1.5e+09,0,-55995,2.5548e+05,0,13"
,"$1,1515762629,-0.067,0,-45,54.51,-0.18,64,3A"
,"$2,1515762629,-0.065,24.684,13.41,10.997,-0.19,34.824,135.52,09"
  };
 int i = 0;
// 初期化
void setup(){ 
  // シリアルポートを9600 bps[ビット/秒]で初期化 
  Serial.begin(9600);
}
 
// 繰り返し処理
void loop(){
        Serial.print(input[i++ % 7]);
        if(i > 1000)
        i = 0;
      delay(10);
}
