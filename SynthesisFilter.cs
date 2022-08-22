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

	// RVA: 0x2266140 Offset: 0x2264740 VA: 0x182266140
	internal void .ctor(int channelnumber, float factor, float[] eq0) { }

	// RVA: 0x226C230 Offset: 0x226A830 VA: 0x18226C230
	internal void set_Eq(float[] value) { }

	// RVA: 0x22657E0 Offset: 0x2263DE0 VA: 0x1822657E0
	private void InitBlock() { }

	// RVA: 0x2265830 Offset: 0x2263E30 VA: 0x182265830
	internal void Reset() { }

	// RVA: 0x22632E0 Offset: 0x22618E0 VA: 0x1822632E0
	internal void AddSample(float sample, int subbandnumber) { }

	// RVA: 0x2263340 Offset: 0x2261940 VA: 0x182263340
	internal void AddSamples(float[] s) { }

	// RVA: 0x22633D0 Offset: 0x22619D0 VA: 0x1822633D0
	private void ComputeNewValues() { }

	// RVA: 0x22667A0 Offset: 0x2264DA0 VA: 0x1822667A0
	private void compute_pc_samples0(ABuffer buffer) { }

	// RVA: 0x2268B40 Offset: 0x2267140 VA: 0x182268B40
	private void compute_pc_samples1(ABuffer buffer) { }

	// RVA: 0x2269130 Offset: 0x2267730 VA: 0x182269130
	private void compute_pc_samples2(ABuffer buffer) { }

	// RVA: 0x2269720 Offset: 0x2267D20 VA: 0x182269720
	private void compute_pc_samples3(ABuffer buffer) { }

	// RVA: 0x2269D10 Offset: 0x2268310 VA: 0x182269D10
	private void compute_pc_samples4(ABuffer buffer) { }

	// RVA: 0x226A300 Offset: 0x2268900 VA: 0x18226A300
	private void compute_pc_samples5(ABuffer buffer) { }

	// RVA: 0x226A8F0 Offset: 0x2268EF0 VA: 0x18226A8F0
	private void compute_pc_samples6(ABuffer buffer) { }

	// RVA: 0x226AEE0 Offset: 0x22694E0 VA: 0x18226AEE0
	private void compute_pc_samples7(ABuffer buffer) { }

	// RVA: 0x226B4D0 Offset: 0x2269AD0 VA: 0x18226B4D0
	private void compute_pc_samples8(ABuffer buffer) { }

	// RVA: 0x226BAC0 Offset: 0x226A0C0 VA: 0x18226BAC0
	private void compute_pc_samples9(ABuffer buffer) { }

	// RVA: 0x2266D90 Offset: 0x2265390 VA: 0x182266D90
	private void compute_pc_samples10(ABuffer buffer) { }

	// RVA: 0x2267380 Offset: 0x2265980 VA: 0x182267380
	private void compute_pc_samples11(ABuffer buffer) { }

	// RVA: 0x2267970 Offset: 0x2265F70 VA: 0x182267970
	private void compute_pc_samples12(ABuffer buffer) { }

	// RVA: 0x2267F60 Offset: 0x2266560 VA: 0x182267F60
	private void compute_pc_samples13(ABuffer buffer) { }

	// RVA: 0x2268550 Offset: 0x2266B50 VA: 0x182268550
	private void compute_pc_samples14(ABuffer buffer) { }

	// RVA: 0x22651F0 Offset: 0x22637F0 VA: 0x1822651F0
	private void Compute_pc_samples15(ABuffer buffer) { }

	// RVA: 0x226C0B0 Offset: 0x226A6B0 VA: 0x18226C0B0
	private void compute_pc_samples(ABuffer buffer) { }

	// RVA: 0x2266580 Offset: 0x2264B80 VA: 0x182266580
	internal void calculate_pc_samples(ABuffer buffer) { }

	// RVA: 0x22658F0 Offset: 0x2263EF0 VA: 0x1822658F0
	private static float[][] SplitArray(float[] array, int blockSize) { }

	// RVA: 0x2265A10 Offset: 0x2264010 VA: 0x182265A10
	private static float[] SubArray(float[] array, int offs, int len) { }

	// RVA: 0x2265AF0 Offset: 0x22640F0 VA: 0x182265AF0
	private static void .cctor() { }

}

