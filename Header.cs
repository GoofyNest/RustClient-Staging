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

	// RVA: 0x5E2EA0 Offset: 0x5E14A0 VA: 0x1805E2EA0
	internal void .ctor() { }

	// RVA: 0x5DE260 Offset: 0x5DC860 VA: 0x1805DE260
	private void InitBlock() { }

	// RVA: 0x5DE4C0 Offset: 0x5DCAC0 VA: 0x1805DE4C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x5E2EF0 Offset: 0x5E14F0 VA: 0x1805E2EF0
	internal void read_header(Bitstream stream, Crc16[] crcp) { }

	// RVA: 0x5DE8B0 Offset: 0x5DCEB0 VA: 0x1805DE8B0
	internal int Version() { }

	// RVA: 0x5DE340 Offset: 0x5DC940 VA: 0x1805DE340
	internal int Layer() { }

	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0
	internal int bitrate_index() { }

	// RVA: 0x599CD0 Offset: 0x5982D0 VA: 0x180599CD0
	internal int sample_frequency() { }

	// RVA: 0x5DE1B0 Offset: 0x5DC7B0 VA: 0x1805DE1B0
	internal int Frequency() { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0
	internal int Mode() { }

	// RVA: 0x5DE2C0 Offset: 0x5DC8C0 VA: 0x1805DE2C0
	internal bool IsProtection() { }

	// RVA: 0x5DE270 Offset: 0x5DC870 VA: 0x1805DE270
	internal bool IsChecksumOK() { }

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
	internal int Slots() { }

	// RVA: 0x5E2EE0 Offset: 0x5E14E0 VA: 0x1805E2EE0
	internal int mode_extension() { }

	// RVA: 0x5DDEA0 Offset: 0x5DC4A0 VA: 0x1805DDEA0
	internal int CalculateFrameSize() { }

	// RVA: 0x5DE2D0 Offset: 0x5DC8D0 VA: 0x1805DE2D0
	internal string LayerAsString() { }

	// RVA: 0x5DDDD0 Offset: 0x5DC3D0 VA: 0x1805DDDD0
	internal string BitrateAsString() { }

	// RVA: 0x5DE3F0 Offset: 0x5DC9F0 VA: 0x1805DE3F0
	internal string SampleFrequencyAsString() { }

	// RVA: 0x5DE350 Offset: 0x5DC950 VA: 0x1805DE350
	internal string ModeAsString() { }

	// RVA: 0x5DE840 Offset: 0x5DCE40 VA: 0x1805DE840
	internal string VersionAsString() { }

	// RVA: 0x5DE3E0 Offset: 0x5DC9E0 VA: 0x1805DE3E0
	internal int NumberSubbands() { }

	// RVA: 0x5983B0 Offset: 0x5969B0 VA: 0x1805983B0
	internal int IntensityStereoBound() { }

	// RVA: 0x5DE8C0 Offset: 0x5DCEC0 VA: 0x1805DE8C0
	private static void .cctor() { }

}

