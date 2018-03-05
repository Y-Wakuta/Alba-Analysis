using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Entity
{
    public enum FirstDataOrder
    {
        time,
        airspeed_time,
        airspeed,
        height_time,
        height,
        cadence_time,
        cadence,
        checksum
    }

    public enum SecondDataOrder
    {
        time,
        mpu_time,
        mpu_yaw,
        mpu_pitch,
        mpu_roll,
        gps_time,
        gps_latitude,
        gps_gratitude,
        checksum
    }

    public enum ThirdDataOrder
    {
        time,
        souda_time,
        souda1,
        souda2,
        right_roll,
        right_yaw,
        checksum
    }

    public enum ForthDataOrder
    {
        time,
        souda_time,
        right_serve_vol,
        left_serve_vol,
        left_roll,
        left_yaw,
        checksum
    }

    public enum InputEnum
    {
        first = 0,
        second,
        third,
        forth,
        notAccepted
    }
}
