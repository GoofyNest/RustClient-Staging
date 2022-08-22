public class Reader // TypeDefIndex: 6649
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static Reader <Active>k__BackingField; // 0x0
	private Stream stream; // 0x10
	private BinaryReader reader; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Name>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private long <CurrentTime>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Indexer <Index>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private DemoHeader <Header>k__BackingField; // 0x38
	public Action<Indexer.Keyframe, HashSet<uint>> OnScrubToKeyframe; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private long <startPosition>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsPaused>k__BackingField; // 0x50

	// Properties
	public static Reader Active { get; set; }
	public string Name { get; set; }
	public long CurrentTime { get; set; }
	public Indexer Index { get; set; }
	public DemoHeader Header { get; set; }
	private long startPosition { get; set; }
	public bool IsFinished { get; }
	public bool IsPaused { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22CBAF0 Offset: 0x22CA0F0 VA: 0x1822CBAF0
	public static Reader get_Active() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22CBB90 Offset: 0x22CA190 VA: 0x1822CBB90
	internal static void set_Active(Reader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public long get_CurrentTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE73A30 Offset: 0xE72030 VA: 0x180E73A30
	private void set_CurrentTime(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public Indexer get_Index() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	private void set_Index(Indexer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	public DemoHeader get_Header() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	private void set_Header(DemoHeader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	private long get_startPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEE7190 Offset: 0xEE5790 VA: 0x180EE7190
	private void set_startPosition(long value) { }

	// RVA: 0x5DE260 Offset: 0x5DC860 VA: 0x1805DE260
	public void Play() { }

	// RVA: 0x22CB320 Offset: 0x22C9920 VA: 0x1822CB320
	public void Pause() { }

	// RVA: 0x22CB820 Offset: 0x22C9E20 VA: 0x1822CB820
	public void .ctor(string name, Stream stream) { }

	// RVA: 0x22CB700 Offset: 0x22C9D00 VA: 0x1822CB700
	public void SetActive() { }

	// RVA: 0x22CB040 Offset: 0x22C9640 VA: 0x1822CB040
	public void JumpTo(long time) { }

	// RVA: 0x22CAF40 Offset: 0x22C9540 VA: 0x1822CAF40
	public void CreateIndex() { }

	// RVA: 0x22CB340 Offset: 0x22C9940 VA: 0x1822CB340
	private void ReadHeader() { }

	// RVA: 0x22CBB30 Offset: 0x22CA130 VA: 0x1822CBB30
	public bool get_IsFinished() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77B140 Offset: 0x779740 VA: 0x18077B140
	public bool get_IsPaused() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE69B60 Offset: 0xE68160 VA: 0x180E69B60
	internal void set_IsPaused(bool value) { }

	// RVA: 0x22CAFA0 Offset: 0x22C95A0 VA: 0x1822CAFA0
	public static Reader FromFile(string filename) { }

	// RVA: 0x22CB750 Offset: 0x22C9D50 VA: 0x1822CB750
	public void Stop() { }

	// RVA: 0x22CB330 Offset: 0x22C9930 VA: 0x1822CB330
	public void Progress(long timeAmountMs) { }

	// RVA: 0x22CB6C0 Offset: 0x22C9CC0 VA: 0x1822CB6C0
	public void ResetToStart() { }

	// RVA: 0x22CB460 Offset: 0x22C9A60 VA: 0x1822CB460
	public Packet ReadPacket() { }

}

