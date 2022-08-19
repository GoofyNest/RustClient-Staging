public class SubbandLayer2 : ASubband // TypeDefIndex: 7406
{	// Fields
	internal static readonly float[] Grouping5Bits; // 0x0
	internal static readonly float[] Grouping7Bits; // 0x8
	internal static readonly float[] Grouping10Bits; // 0x10
	internal static readonly int[] TableAb1Codelength; // 0x18
	internal static readonly float[][] TableAb1Groupingtables; // 0x20
	internal static readonly float[] TableAb1Factor; // 0x28
	internal static readonly float[] TableAb1C; // 0x30
	internal static readonly float[] TableAb1D; // 0x38
	internal static readonly float[][] TableAb234Groupingtables; // 0x40
	internal static readonly int[] TableAb2Codelength; // 0x48
	internal static readonly float[] TableAb2Factor; // 0x50
	internal static readonly float[] TableAb2C; // 0x58
	internal static readonly float[] TableAb2D; // 0x60
	internal static readonly int[] TableAb3Codelength; // 0x68
	internal static readonly float[] TableAb3Factor; // 0x70
	internal static readonly float[] TableAb3C; // 0x78
	internal static readonly float[] TableAb3D; // 0x80
	internal static readonly int[] TableAb4Codelength; // 0x88
	internal static readonly float[] TableAb4Factor; // 0x90
	internal static readonly float[] TableAb4C; // 0x98
	internal static readonly float[] TableAb4D; // 0xA0
	internal static readonly int[] TableCdCodelength; // 0xA8
	internal static readonly float[][] TableCdGroupingtables; // 0xB0
	internal static readonly float[] TableCdFactor; // 0xB8
	internal static readonly float[] TableCdC; // 0xC0
	internal static readonly float[] TableCdD; // 0xC8
	protected int Allocation; // 0x10
	protected readonly float[] CFactor; // 0x18
	protected readonly int[] Codelength; // 0x20
	protected float[] D; // 0x28
	protected readonly float[] Factor; // 0x30
	protected float[][] Groupingtable; // 0x38
	protected int Groupnumber; // 0x40
	protected int Samplenumber; // 0x44
	protected float[] Samples; // 0x48
	protected float Scalefactor1; // 0x50
	protected float Scalefactor2; // 0x54
	protected float Scalefactor3; // 0x58
	protected int Scfsi; // 0x5C
	protected readonly int Subbandnumber; // 0x60

	// Methods

	// RVA: 0x677140 Offset: 0x675740 VA: 0x180677140
	internal void .ctor(int subbandnumber) { }

	// RVA: 0x6751D0 Offset: 0x6737D0 VA: 0x1806751D0 Slot: 8
	protected virtual int GetAllocationLength(Header header) { }

	// RVA: 0x675240 Offset: 0x673840 VA: 0x180675240 Slot: 9
	protected virtual void PrepareForSampleRead(Header header, int allocation, int channel, float[] factor, int[] codelength, float[] c, float[] d) { }

	// RVA: 0x675EC0 Offset: 0x6744C0 VA: 0x180675EC0 Slot: 4
	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	// RVA: 0x676310 Offset: 0x674910 VA: 0x180676310 Slot: 10
	internal virtual void ReadScaleFactorSelection(Bitstream stream, Crc16 crc) { }

	// RVA: 0x676370 Offset: 0x674970 VA: 0x180676370 Slot: 5
	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	// RVA: 0x675F40 Offset: 0x674540 VA: 0x180675F40 Slot: 6
	internal override bool ReadSampleData(Bitstream stream) { }

	// RVA: 0x675D90 Offset: 0x674390 VA: 0x180675D90 Slot: 7
	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

	// RVA: 0x676760 Offset: 0x674D60 VA: 0x180676760
	private static void .cctor() { }

}
