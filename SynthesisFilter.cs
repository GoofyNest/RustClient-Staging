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

	// RVA: 0x2266960 Offset: 0x2264F60 VA: 0x182266960
	internal void .ctor(int channelnumber, float factor, float[] eq0) { }

	// RVA: 0x226CA50 Offset: 0x226B050 VA: 0x18226CA50
	internal void set_Eq(float[] value) { }

	// RVA: 0x2266000 Offset: 0x2264600 VA: 0x182266000
	private void InitBlock() { }

	// RVA: 0x2266050 Offset: 0x2264650 VA: 0x182266050
	internal void Reset() { }

	// RVA: 0x2263B00 Offset: 0x2262100 VA: 0x182263B00
	internal void AddSample(float sample, int subbandnumber) { }

	// RVA: 0x2263B60 Offset: 0x2262160 VA: 0x182263B60
	internal void AddSamples(float[] s) { }

	// RVA: 0x2263BF0 Offset: 0x22621F0 VA: 0x182263BF0
	private void ComputeNewValues() { }

	// RVA: 0x2266FC0 Offset: 0x22655C0 VA: 0x182266FC0
	private void compute_pc_samples0(ABuffer buffer) { }

	// RVA: 0x2269360 Offset: 0x2267960 VA: 0x182269360
	private void compute_pc_samples1(ABuffer buffer) { }

	// RVA: 0x2269950 Offset: 0x2267F50 VA: 0x182269950
	private void compute_pc_samples2(ABuffer buffer) { }

	// RVA: 0x2269F40 Offset: 0x2268540 VA: 0x182269F40
	private void compute_pc_samples3(ABuffer buffer) { }

	// RVA: 0x226A530 Offset: 0x2268B30 VA: 0x18226A530
	private void compute_pc_samples4(ABuffer buffer) { }

	// RVA: 0x226AB20 Offset: 0x2269120 VA: 0x18226AB20
	private void compute_pc_samples5(ABuffer buffer) { }

	// RVA: 0x226B110 Offset: 0x2269710 VA: 0x18226B110
	private void compute_pc_samples6(ABuffer buffer) { }

	// RVA: 0x226B700 Offset: 0x2269D00 VA: 0x18226B700
	private void compute_pc_samples7(ABuffer buffer) { }

	// RVA: 0x226BCF0 Offset: 0x226A2F0 VA: 0x18226BCF0
	private void compute_pc_samples8(ABuffer buffer) { }

	// RVA: 0x226C2E0 Offset: 0x226A8E0 VA: 0x18226C2E0
	private void compute_pc_samples9(ABuffer buffer) { }

	// RVA: 0x22675B0 Offset: 0x2265BB0 VA: 0x1822675B0
	private void compute_pc_samples10(ABuffer buffer) { }

	// RVA: 0x2267BA0 Offset: 0x22661A0 VA: 0x182267BA0
	private void compute_pc_samples11(ABuffer buffer) { }

	// RVA: 0x2268190 Offset: 0x2266790 VA: 0x182268190
	private void compute_pc_samples12(ABuffer buffer) { }

	// RVA: 0x2268780 Offset: 0x2266D80 VA: 0x182268780
	private void compute_pc_samples13(ABuffer buffer) { }

	// RVA: 0x2268D70 Offset: 0x2267370 VA: 0x182268D70
	private void compute_pc_samples14(ABuffer buffer) { }

	// RVA: 0x2265A10 Offset: 0x2264010 VA: 0x182265A10
	private void Compute_pc_samples15(ABuffer buffer) { }

	// RVA: 0x226C8D0 Offset: 0x226AED0 VA: 0x18226C8D0
	private void compute_pc_samples(ABuffer buffer) { }

	// RVA: 0x2266DA0 Offset: 0x22653A0 VA: 0x182266DA0
	internal void calculate_pc_samples(ABuffer buffer) { }

	// RVA: 0x2266110 Offset: 0x2264710 VA: 0x182266110
	private static float[][] SplitArray(float[] array, int blockSize) { }

	// RVA: 0x2266230 Offset: 0x2264830 VA: 0x182266230
	private static float[] SubArray(float[] array, int offs, int len) { }

	// RVA: 0x2266310 Offset: 0x2264910 VA: 0x182266310
	private static void .cctor() { }

}

