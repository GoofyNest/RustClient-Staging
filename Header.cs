public class Header // TypeDefIndex: 1237
{	// Fields
	public string HeaderNamespace; // 0x10
	public bool MustUnderstand; // 0x18
	public string Name; // 0x20
	public object Value; // 0x28

}

public class Header // TypeDefIndex: 7392
{	// Fields
	internal const int MPEG2_LSF = 0;
	internal const int MPEG25_LSF = 2;
	internal const int MPEG1 = 1;
	internal const int STEREO = 0;
	internal const int JOINT_STEREO = 1;
	internal const int DUAL_CHANNEL = 2;
	internal const int SINGLE_CHANNEL = 3;
	internal const int FOURTYFOUR_POINT_ONE = 0;
	internal const int FOURTYEIGHT = 1;
	internal const int THIRTYTWO = 2;
	internal static readonly int[][] Frequencies; // 0x0
	internal static readonly int[][][] Bitrates; // 0x8
	internal static readonly string[][][] BitrateStr; // 0x10
	internal short Checksum; // 0x10
	internal int NSlots; // 0x14
	private Crc16 _CRC; // 0x18
	internal int Framesize; // 0x20
	private bool _Copyright; // 0x24
	private bool _Original; // 0x25
	private int _Headerstring; // 0x28
	private int _Layer; // 0x2C
	private int _ProtectionBit; // 0x30
	private int _BitrateIndex; // 0x34
	private int _PaddingBit; // 0x38
	private int _ModeExtension; // 0x3C
	private int _Mode; // 0x40
	private int _NumberOfSubbands; // 0x44
	private int _IntensityStereoBound; // 0x48
	private int _SampleFrequency; // 0x4C
	private sbyte _Syncmode; // 0x50
	private int _Version; // 0x54

	// Methods

	// RVA: 0x5E2F10 Offset: 0x5E1510 VA: 0x1805E2F10
	internal void .ctor() { }

	// RVA: 0x5DE2D0 Offset: 0x5DC8D0 VA: 0x1805DE2D0
	private void InitBlock() { }

	// RVA: 0x5DE530 Offset: 0x5DCB30 VA: 0x1805DE530 Slot: 3
	public override string ToString() { }

	// RVA: 0x5E2F60 Offset: 0x5E1560 VA: 0x1805E2F60
	internal void read_header(Bitstream stream, Crc16[] crcp) { }

	// RVA: 0x5DE920 Offset: 0x5DCF20 VA: 0x1805DE920
	internal int Version() { }

	// RVA: 0x5DE3B0 Offset: 0x5DC9B0 VA: 0x1805DE3B0
	internal int Layer() { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40
	internal int bitrate_index() { }

	// RVA: 0x599D40 Offset: 0x598340 VA: 0x180599D40
	internal int sample_frequency() { }

	// RVA: 0x5DE220 Offset: 0x5DC820 VA: 0x1805DE220
	internal int Frequency() { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	internal int Mode() { }

	// RVA: 0x5DE330 Offset: 0x5DC930 VA: 0x1805DE330
	internal bool IsProtection() { }

	// RVA: 0x5DE2E0 Offset: 0x5DC8E0 VA: 0x1805DE2E0
	internal bool IsChecksumOK() { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	internal int Slots() { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50
	internal int mode_extension() { }

	// RVA: 0x5DDF10 Offset: 0x5DC510 VA: 0x1805DDF10
	internal int CalculateFrameSize() { }

	// RVA: 0x5DE340 Offset: 0x5DC940 VA: 0x1805DE340
	internal string LayerAsString() { }

	// RVA: 0x5DDE40 Offset: 0x5DC440 VA: 0x1805DDE40
	internal string BitrateAsString() { }

	// RVA: 0x5DE460 Offset: 0x5DCA60 VA: 0x1805DE460
	internal string SampleFrequencyAsString() { }

	// RVA: 0x5DE3C0 Offset: 0x5DC9C0 VA: 0x1805DE3C0
	internal string ModeAsString() { }

	// RVA: 0x5DE8B0 Offset: 0x5DCEB0 VA: 0x1805DE8B0
	internal string VersionAsString() { }

	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	internal int NumberSubbands() { }

	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420
	internal int IntensityStereoBound() { }

	// RVA: 0x5DE930 Offset: 0x5DCF30 VA: 0x1805DE930
	private static void .cctor() { }

}

