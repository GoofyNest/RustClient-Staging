internal sealed class LayerIIIDecoder : IFrameDecoder // TypeDefIndex: 7402
{	// Fields
	private const int SSLIMIT = 18;
	private const int SBLIMIT = 32;
	private static readonly int[][] Slen; // 0x0
	internal static readonly int[] Pretab; // 0x8
	internal static readonly float[] TwoToNegativeHalfPow; // 0x10
	internal static readonly float[] PowerTable; // 0x18
	internal static readonly float[][] Io; // 0x20
	internal static readonly float[] Tan12; // 0x28
	private static int[][] _reorderTable; // 0x30
	private static readonly float[] Cs; // 0x38
	private static readonly float[] Ca; // 0x40
	internal static readonly float[][] Win; // 0x48
	internal static readonly int[][][] NrOfSfbBlock; // 0x50
	private readonly ABuffer _Buffer; // 0x10
	private readonly int _Channels; // 0x18
	private readonly SynthesisFilter _Filter1; // 0x20
	private readonly SynthesisFilter _Filter2; // 0x28
	private readonly int _FirstChannel; // 0x30
	private readonly Header _Header; // 0x38
	private readonly int[] _Is1D; // 0x40
	private readonly float[][] _K; // 0x48
	private readonly int _LastChannel; // 0x50
	private readonly float[][][] _Lr; // 0x58
	private readonly int _MaxGr; // 0x60
	private readonly int[] _Nonzero; // 0x68
	private readonly float[] _Out1D; // 0x70
	private readonly float[][] _Prevblck; // 0x78
	private readonly float[][][] _Ro; // 0x80
	private readonly ScaleFactorData[] _Scalefac; // 0x88
	private readonly SBI[] _SfBandIndex; // 0x90
	private readonly int _Sfreq; // 0x98
	private readonly Layer3SideInfo _SideInfo; // 0xA0
	private readonly Bitstream _Stream; // 0xA8
	private readonly int _WhichChannels; // 0xB0
	private BitReserve _BitReserve; // 0xB8
	private int _CheckSumHuff; // 0xC0
	private int _FrameStart; // 0xC4
	internal int[] IsPos; // 0xC8
	internal float[] IsRatio; // 0xD0
	private int[] _NewSlen; // 0xD8
	private int _Part2Start; // 0xE0
	internal float[] Rawout; // 0xE8
	private float[] _Samples1; // 0xF0
	private float[] _Samples2; // 0xF8
	internal int[] ScalefacBuffer; // 0x100
	internal ScaleFactorTable Sftable; // 0x108
	internal float[] TsOutCopy; // 0x110
	internal int[] V; // 0x118
	internal int[] W; // 0x120
	internal int[] X; // 0x128
	internal int[] Y; // 0x130

	// Methods

	// RVA: 0x6706C0 Offset: 0x66ECC0 VA: 0x1806706C0
	private static void .cctor() { }

	// RVA: 0x6719D0 Offset: 0x66FFD0 VA: 0x1806719D0
	internal void .ctor(Bitstream stream, Header header, SynthesisFilter filtera, SynthesisFilter filterb, ABuffer buffer, int whichCh) { }

	// RVA: 0x661DF0 Offset: 0x6603F0 VA: 0x180661DF0 Slot: 4
	public void DecodeFrame() { }

	// RVA: 0x666BF0 Offset: 0x6651F0 VA: 0x180666BF0
	private void InitBlock() { }

	// RVA: 0x661E00 Offset: 0x660400 VA: 0x180661E00
	internal void Decode() { }

	// RVA: 0x66B5F0 Offset: 0x669BF0 VA: 0x18066B5F0
	private bool ReadSideInfo() { }

	// RVA: 0x668A70 Offset: 0x667070 VA: 0x180668A70
	private void ReadScaleFactors(int ch, int gr) { }

	// RVA: 0x663FA0 Offset: 0x6625A0 VA: 0x180663FA0
	private void GetLSFScaleData(int ch, int gr) { }

	// RVA: 0x663620 Offset: 0x661C20 VA: 0x180663620
	private void GLSFScaleFactors(int ch, int gr) { }

	// RVA: 0x664BC0 Offset: 0x6631C0 VA: 0x180664BC0
	private void HuffmanDecode(int ch, int gr) { }

	// RVA: 0x663C30 Offset: 0x662230 VA: 0x180663C30
	private void GetKStereoValues(int isPos, int ioType, int i) { }

	// RVA: 0x662350 Offset: 0x660950 VA: 0x180662350
	private void DequantizeSample(float[][] xr, int ch, int gr) { }

	// RVA: 0x66D780 Offset: 0x66BD80 VA: 0x18066D780
	private void Reorder(float[][] xr, int ch, int gr) { }

	// RVA: 0x66DFE0 Offset: 0x66C5E0 VA: 0x18066DFE0
	private void Stereo(int gr) { }

	// RVA: 0x661A20 Offset: 0x660020 VA: 0x180661A20
	private void Antialias(int ch, int gr) { }

	// RVA: 0x6658F0 Offset: 0x663EF0 VA: 0x1806658F0
	private void Hybrid(int ch, int gr) { }

	// RVA: 0x6632F0 Offset: 0x6618F0 VA: 0x1806632F0
	private void DoDownMix() { }

	// RVA: 0x666D10 Offset: 0x665310 VA: 0x180666D10
	internal void InverseMdct(float[] inValues, float[] outValues, int blockType) { }

	// RVA: 0x661D20 Offset: 0x660320 VA: 0x180661D20
	private static float[] CreatePowerTable() { }

	// RVA: 0x66DED0 Offset: 0x66C4D0 VA: 0x18066DED0
	internal static int[] Reorder(int[] scalefacBand) { }

}

