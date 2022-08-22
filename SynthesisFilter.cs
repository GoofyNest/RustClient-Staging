public class SynthesisFilter // TypeDefIndex: 7397
{	// Fields
	private const double MY_PI = 3,14159265358979;
	private static readonly float Cos164; // 0x0
	private static readonly float Cos364; // 0x4
	private static readonly float Cos564; // 0x8
	private static readonly float Cos764; // 0xC
	private static readonly float Cos964; // 0x10
	private static readonly float Cos1164; // 0x14
	private static readonly float Cos1364; // 0x18
	private static readonly float Cos1564; // 0x1C
	private static readonly float Cos1764; // 0x20
	private static readonly float Cos1964; // 0x24
	private static readonly float Cos2164; // 0x28
	private static readonly float Cos2364; // 0x2C
	private static readonly float Cos2564; // 0x30
	private static readonly float Cos2764; // 0x34
	private static readonly float Cos2964; // 0x38
	private static readonly float Cos3164; // 0x3C
	private static readonly float Cos132; // 0x40
	private static readonly float Cos332; // 0x44
	private static readonly float Cos532; // 0x48
	private static readonly float Cos732; // 0x4C
	private static readonly float Cos932; // 0x50
	private static readonly float Cos1132; // 0x54
	private static readonly float Cos1332; // 0x58
	private static readonly float Cos1532; // 0x5C
	private static readonly float Cos116; // 0x60
	private static readonly float Cos316; // 0x64
	private static readonly float Cos516; // 0x68
	private static readonly float Cos716; // 0x6C
	private static readonly float Cos18; // 0x70
	private static readonly float Cos38; // 0x74
	private static readonly float Cos14; // 0x78
	private static float[] _d; // 0x80
	private static float[][] _d16; // 0x88
	private static readonly float[] DData; // 0x90
	private readonly int _Channel; // 0x10
	private readonly float[] _Samples; // 0x18
	private readonly float _Scalefactor; // 0x20
	private readonly float[] _V1; // 0x28
	private readonly float[] _V2; // 0x30
	private float[] _TmpOut; // 0x38
	private float[] _ActualV; // 0x40
	private int _ActualWritePos; // 0x48
	private float[] _Eq; // 0x50

	// Properties
	internal float[] Eq { set; }

	// Methods

	// RVA: 0x2265E80 Offset: 0x2264480 VA: 0x182265E80
	internal void .ctor(int channelnumber, float factor, float[] eq0) { }

	// RVA: 0x226BF70 Offset: 0x226A570 VA: 0x18226BF70
	internal void set_Eq(float[] value) { }

	// RVA: 0x2265520 Offset: 0x2263B20 VA: 0x182265520
	private void InitBlock() { }

	// RVA: 0x2265570 Offset: 0x2263B70 VA: 0x182265570
	internal void Reset() { }

	// RVA: 0x2263020 Offset: 0x2261620 VA: 0x182263020
	internal void AddSample(float sample, int subbandnumber) { }

	// RVA: 0x2263080 Offset: 0x2261680 VA: 0x182263080
	internal void AddSamples(float[] s) { }

	// RVA: 0x2263110 Offset: 0x2261710 VA: 0x182263110
	private void ComputeNewValues() { }

	// RVA: 0x22664E0 Offset: 0x2264AE0 VA: 0x1822664E0
	private void compute_pc_samples0(ABuffer buffer) { }

	// RVA: 0x2268880 Offset: 0x2266E80 VA: 0x182268880
	private void compute_pc_samples1(ABuffer buffer) { }

	// RVA: 0x2268E70 Offset: 0x2267470 VA: 0x182268E70
	private void compute_pc_samples2(ABuffer buffer) { }

	// RVA: 0x2269460 Offset: 0x2267A60 VA: 0x182269460
	private void compute_pc_samples3(ABuffer buffer) { }

	// RVA: 0x2269A50 Offset: 0x2268050 VA: 0x182269A50
	private void compute_pc_samples4(ABuffer buffer) { }

	// RVA: 0x226A040 Offset: 0x2268640 VA: 0x18226A040
	private void compute_pc_samples5(ABuffer buffer) { }

	// RVA: 0x226A630 Offset: 0x2268C30 VA: 0x18226A630
	private void compute_pc_samples6(ABuffer buffer) { }

	// RVA: 0x226AC20 Offset: 0x2269220 VA: 0x18226AC20
	private void compute_pc_samples7(ABuffer buffer) { }

	// RVA: 0x226B210 Offset: 0x2269810 VA: 0x18226B210
	private void compute_pc_samples8(ABuffer buffer) { }

	// RVA: 0x226B800 Offset: 0x2269E00 VA: 0x18226B800
	private void compute_pc_samples9(ABuffer buffer) { }

	// RVA: 0x2266AD0 Offset: 0x22650D0 VA: 0x182266AD0
	private void compute_pc_samples10(ABuffer buffer) { }

	// RVA: 0x22670C0 Offset: 0x22656C0 VA: 0x1822670C0
	private void compute_pc_samples11(ABuffer buffer) { }

	// RVA: 0x22676B0 Offset: 0x2265CB0 VA: 0x1822676B0
	private void compute_pc_samples12(ABuffer buffer) { }

	// RVA: 0x2267CA0 Offset: 0x22662A0 VA: 0x182267CA0
	private void compute_pc_samples13(ABuffer buffer) { }

	// RVA: 0x2268290 Offset: 0x2266890 VA: 0x182268290
	private void compute_pc_samples14(ABuffer buffer) { }

	// RVA: 0x2264F30 Offset: 0x2263530 VA: 0x182264F30
	private void Compute_pc_samples15(ABuffer buffer) { }

	// RVA: 0x226BDF0 Offset: 0x226A3F0 VA: 0x18226BDF0
	private void compute_pc_samples(ABuffer buffer) { }

	// RVA: 0x22662C0 Offset: 0x22648C0 VA: 0x1822662C0
	internal void calculate_pc_samples(ABuffer buffer) { }

	// RVA: 0x2265630 Offset: 0x2263C30 VA: 0x182265630
	private static float[][] SplitArray(float[] array, int blockSize) { }

	// RVA: 0x2265750 Offset: 0x2263D50 VA: 0x182265750
	private static float[] SubArray(float[] array, int offs, int len) { }

	// RVA: 0x2265830 Offset: 0x2263E30 VA: 0x182265830
	private static void .cctor() { }

}

