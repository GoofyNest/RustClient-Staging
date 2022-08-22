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
	// RVA: 0x22CB2D0 Offset: 0x22C98D0 VA: 0x1822CB2D0
	public static Reader get_Active() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x22CB370 Offset: 0x22C9970 VA: 0x1822CB370
	internal static void set_Active(Reader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	public long get_CurrentTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE72F80 Offset: 0xE71580 VA: 0x180E72F80
	private void set_CurrentTime(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public Indexer get_Index() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_Index(Indexer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public DemoHeader get_Header() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	private void set_Header(DemoHeader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	private long get_startPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xEE66E0 Offset: 0xEE4CE0 VA: 0x180EE66E0
	private void set_startPosition(long value) { }

	// RVA: 0x5DE2D0 Offset: 0x5DC8D0 VA: 0x1805DE2D0
	public void Play() { }

	// RVA: 0x22CAB00 Offset: 0x22C9100 VA: 0x1822CAB00
	public void Pause() { }

	// RVA: 0x22CB000 Offset: 0x22C9600 VA: 0x1822CB000
	public void .ctor(string name, Stream stream) { }

	// RVA: 0x22CAEE0 Offset: 0x22C94E0 VA: 0x1822CAEE0
	public void SetActive() { }

	// RVA: 0x22CA820 Offset: 0x22C8E20 VA: 0x1822CA820
	public void JumpTo(long time) { }

	// RVA: 0x22CA720 Offset: 0x22C8D20 VA: 0x1822CA720
	public void CreateIndex() { }

	// RVA: 0x22CAB20 Offset: 0x22C9120 VA: 0x1822CAB20
	private void ReadHeader() { }

	// RVA: 0x22CB310 Offset: 0x22C9910 VA: 0x1822CB310
	public bool get_IsFinished() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x77B1F0 Offset: 0x7797F0 VA: 0x18077B1F0
	public bool get_IsPaused() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE690B0 Offset: 0xE676B0 VA: 0x180E690B0
	internal void set_IsPaused(bool value) { }

	// RVA: 0x22CA780 Offset: 0x22C8D80 VA: 0x1822CA780
	public static Reader FromFile(string filename) { }

	// RVA: 0x22CAF30 Offset: 0x22C9530 VA: 0x1822CAF30
	public void Stop() { }

	// RVA: 0x22CAB10 Offset: 0x22C9110 VA: 0x1822CAB10
	public void Progress(long timeAmountMs) { }

	// RVA: 0x22CAEA0 Offset: 0x22C94A0 VA: 0x1822CAEA0
	public void ResetToStart() { }

	// RVA: 0x22CAC40 Offset: 0x22C9240 VA: 0x1822CAC40
	public Packet ReadPacket() { }

}

