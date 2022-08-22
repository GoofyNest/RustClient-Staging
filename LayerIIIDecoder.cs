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

	// RVA: 0x670650 Offset: 0x66EC50 VA: 0x180670650
	private static void .cctor() { }

	// RVA: 0x671960 Offset: 0x66FF60 VA: 0x180671960
	internal void .ctor(Bitstream stream, Header header, SynthesisFilter filtera, SynthesisFilter filterb, ABuffer buffer, int whichCh) { }

	// RVA: 0x661D80 Offset: 0x660380 VA: 0x180661D80 Slot: 4
	public void DecodeFrame() { }

	// RVA: 0x666B80 Offset: 0x665180 VA: 0x180666B80
	private void InitBlock() { }

	// RVA: 0x661D90 Offset: 0x660390 VA: 0x180661D90
	internal void Decode() { }

	// RVA: 0x66B580 Offset: 0x669B80 VA: 0x18066B580
	private bool ReadSideInfo() { }

	// RVA: 0x668A00 Offset: 0x667000 VA: 0x180668A00
	private void ReadScaleFactors(int ch, int gr) { }

	// RVA: 0x663F30 Offset: 0x662530 VA: 0x180663F30
	private void GetLSFScaleData(int ch, int gr) { }

	// RVA: 0x6635B0 Offset: 0x661BB0 VA: 0x1806635B0
	private void GLSFScaleFactors(int ch, int gr) { }

	// RVA: 0x664B50 Offset: 0x663150 VA: 0x180664B50
	private void HuffmanDecode(int ch, int gr) { }

	// RVA: 0x663BC0 Offset: 0x6621C0 VA: 0x180663BC0
	private void GetKStereoValues(int isPos, int ioType, int i) { }

	// RVA: 0x6622E0 Offset: 0x6608E0 VA: 0x1806622E0
	private void DequantizeSample(float[][] xr, int ch, int gr) { }

	// RVA: 0x66D710 Offset: 0x66BD10 VA: 0x18066D710
	private void Reorder(float[][] xr, int ch, int gr) { }

	// RVA: 0x66DF70 Offset: 0x66C570 VA: 0x18066DF70
	private void Stereo(int gr) { }

	// RVA: 0x6619B0 Offset: 0x65FFB0 VA: 0x1806619B0
	private void Antialias(int ch, int gr) { }

	// RVA: 0x665880 Offset: 0x663E80 VA: 0x180665880
	private void Hybrid(int ch, int gr) { }

	// RVA: 0x663280 Offset: 0x661880 VA: 0x180663280
	private void DoDownMix() { }

	// RVA: 0x666CA0 Offset: 0x6652A0 VA: 0x180666CA0
	internal void InverseMdct(float[] inValues, float[] outValues, int blockType) { }

	// RVA: 0x661CB0 Offset: 0x6602B0 VA: 0x180661CB0
	private static float[] CreatePowerTable() { }

	// RVA: 0x66DE60 Offset: 0x66C460 VA: 0x18066DE60
	internal static int[] Reorder(int[] scalefacBand) { }

}

