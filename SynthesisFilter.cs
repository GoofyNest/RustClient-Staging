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

	// RVA: 0x2266040 Offset: 0x2264640 VA: 0x182266040
	internal void .ctor(int channelnumber, float factor, float[] eq0) { }

	// RVA: 0x226C130 Offset: 0x226A730 VA: 0x18226C130
	internal void set_Eq(float[] value) { }

	// RVA: 0x22656E0 Offset: 0x2263CE0 VA: 0x1822656E0
	private void InitBlock() { }

	// RVA: 0x2265730 Offset: 0x2263D30 VA: 0x182265730
	internal void Reset() { }

	// RVA: 0x22631E0 Offset: 0x22617E0 VA: 0x1822631E0
	internal void AddSample(float sample, int subbandnumber) { }

	// RVA: 0x2263240 Offset: 0x2261840 VA: 0x182263240
	internal void AddSamples(float[] s) { }

	// RVA: 0x22632D0 Offset: 0x22618D0 VA: 0x1822632D0
	private void ComputeNewValues() { }

	// RVA: 0x22666A0 Offset: 0x2264CA0 VA: 0x1822666A0
	private void compute_pc_samples0(ABuffer buffer) { }

	// RVA: 0x2268A40 Offset: 0x2267040 VA: 0x182268A40
	private void compute_pc_samples1(ABuffer buffer) { }

	// RVA: 0x2269030 Offset: 0x2267630 VA: 0x182269030
	private void compute_pc_samples2(ABuffer buffer) { }

	// RVA: 0x2269620 Offset: 0x2267C20 VA: 0x182269620
	private void compute_pc_samples3(ABuffer buffer) { }

	// RVA: 0x2269C10 Offset: 0x2268210 VA: 0x182269C10
	private void compute_pc_samples4(ABuffer buffer) { }

	// RVA: 0x226A200 Offset: 0x2268800 VA: 0x18226A200
	private void compute_pc_samples5(ABuffer buffer) { }

	// RVA: 0x226A7F0 Offset: 0x2268DF0 VA: 0x18226A7F0
	private void compute_pc_samples6(ABuffer buffer) { }

	// RVA: 0x226ADE0 Offset: 0x22693E0 VA: 0x18226ADE0
	private void compute_pc_samples7(ABuffer buffer) { }

	// RVA: 0x226B3D0 Offset: 0x22699D0 VA: 0x18226B3D0
	private void compute_pc_samples8(ABuffer buffer) { }

	// RVA: 0x226B9C0 Offset: 0x2269FC0 VA: 0x18226B9C0
	private void compute_pc_samples9(ABuffer buffer) { }

	// RVA: 0x2266C90 Offset: 0x2265290 VA: 0x182266C90
	private void compute_pc_samples10(ABuffer buffer) { }

	// RVA: 0x2267280 Offset: 0x2265880 VA: 0x182267280
	private void compute_pc_samples11(ABuffer buffer) { }

	// RVA: 0x2267870 Offset: 0x2265E70 VA: 0x182267870
	private void compute_pc_samples12(ABuffer buffer) { }

	// RVA: 0x2267E60 Offset: 0x2266460 VA: 0x182267E60
	private void compute_pc_samples13(ABuffer buffer) { }

	// RVA: 0x2268450 Offset: 0x2266A50 VA: 0x182268450
	private void compute_pc_samples14(ABuffer buffer) { }

	// RVA: 0x22650F0 Offset: 0x22636F0 VA: 0x1822650F0
	private void Compute_pc_samples15(ABuffer buffer) { }

	// RVA: 0x226BFB0 Offset: 0x226A5B0 VA: 0x18226BFB0
	private void compute_pc_samples(ABuffer buffer) { }

	// RVA: 0x2266480 Offset: 0x2264A80 VA: 0x182266480
	internal void calculate_pc_samples(ABuffer buffer) { }

	// RVA: 0x22657F0 Offset: 0x2263DF0 VA: 0x1822657F0
	private static float[][] SplitArray(float[] array, int blockSize) { }

	// RVA: 0x2265910 Offset: 0x2263F10 VA: 0x182265910
	private static float[] SubArray(float[] array, int offs, int len) { }

	// RVA: 0x22659F0 Offset: 0x2263FF0 VA: 0x1822659F0
	private static void .cctor() { }

}

