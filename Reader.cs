public class Reader // TypeDefIndex: 6649
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Reader <Active>k__BackingField; // 0x0
	private Stream stream; // 0x10
	private BinaryReader reader; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Name>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private long <CurrentTime>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Indexer <Index>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private DemoHeader <Header>k__BackingField; // 0x38
	public Action<Indexer.Keyframe, HashSet<uint>> OnScrubToKeyframe; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private long <startPosition>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22CB1D0 Offset: 0x22C97D0 VA: 0x1822CB1D0
	public static Reader get_Active() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x22CB270 Offset: 0x22C9870 VA: 0x1822CB270
	internal static void set_Active(Reader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	public long get_CurrentTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xE72CC0 Offset: 0xE712C0 VA: 0x180E72CC0
	private void set_CurrentTime(long value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public Indexer get_Index() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_Index(Indexer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	public DemoHeader get_Header() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	private void set_Header(DemoHeader value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	private long get_startPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xEE6420 Offset: 0xEE4A20 VA: 0x180EE6420
	private void set_startPosition(long value) { }

	// RVA: 0x5DE2D0 Offset: 0x5DC8D0 VA: 0x1805DE2D0
	public void Play() { }

	// RVA: 0x22CAA00 Offset: 0x22C9000 VA: 0x1822CAA00
	public void Pause() { }

	// RVA: 0x22CAF00 Offset: 0x22C9500 VA: 0x1822CAF00
	public void .ctor(string name, Stream stream) { }

	// RVA: 0x22CADE0 Offset: 0x22C93E0 VA: 0x1822CADE0
	public void SetActive() { }

	// RVA: 0x22CA720 Offset: 0x22C8D20 VA: 0x1822CA720
	public void JumpTo(long time) { }

	// RVA: 0x22CA620 Offset: 0x22C8C20 VA: 0x1822CA620
	public void CreateIndex() { }

	// RVA: 0x22CAA20 Offset: 0x22C9020 VA: 0x1822CAA20
	private void ReadHeader() { }

	// RVA: 0x22CB210 Offset: 0x22C9810 VA: 0x1822CB210
	public bool get_IsFinished() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x77B0E0 Offset: 0x7796E0 VA: 0x18077B0E0
	public bool get_IsPaused() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xE68DF0 Offset: 0xE673F0 VA: 0x180E68DF0
	internal void set_IsPaused(bool value) { }

	// RVA: 0x22CA680 Offset: 0x22C8C80 VA: 0x1822CA680
	public static Reader FromFile(string filename) { }

	// RVA: 0x22CAE30 Offset: 0x22C9430 VA: 0x1822CAE30
	public void Stop() { }

	// RVA: 0x22CAA10 Offset: 0x22C9010 VA: 0x1822CAA10
	public void Progress(long timeAmountMs) { }

	// RVA: 0x22CADA0 Offset: 0x22C93A0 VA: 0x1822CADA0
	public void ResetToStart() { }

	// RVA: 0x22CAB40 Offset: 0x22C9140 VA: 0x1822CAB40
	public Packet ReadPacket() { }

}

