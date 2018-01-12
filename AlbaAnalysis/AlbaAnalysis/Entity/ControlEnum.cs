using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbaAnalysis.Entity {
    public enum ControlDataOrder {
        MpuXR,
        MpuYR,
        MpuZR,
        MpuXR_A,
        MpuYR_A,
        MpuZR_A,
        VoltageR,
        MpuXL,
        MpuYL,
        MpuZL,
        MpuXL_A,
        MpuYL_A,
        MpuZL_A,
        VoltageL,
    }

    public enum InputDataOrder {
        ErebonRInput,
        DrugR,
        ErebonLInput,
        DrugL,
    }

    public enum MpuDataOrder {
        MpuRoll,
        MpuPitch,
        MpuYaw,
    }

    public enum KeikiDataOrder {
        AirSpeed,
        Sonar,
        Cadence,
    }

    public enum InputEnum {
        control = 0,
        input,
        mpu,
        keiki,
        notAccepted
    }
}
