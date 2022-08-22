public static class GC // TypeDefIndex: 224
{	// Fields
	internal static readonly object EPHEMERON_TOMBSTONE; // 0x2B10370

	// Properties
	public static int MaxGeneration { get; }

	// Methods

	// RVA: 0x10DEAA0 Offset: 0x10DD0A0 VA: 0x1810DEAA0
	private static int GetCollectionCount(int generation) { }

	// RVA: 0x10DEAB0 Offset: 0x10DD0B0 VA: 0x1810DEAB0
	private static int GetMaxGeneration() { }

	// RVA: 0x10DEAD0 Offset: 0x10DD0D0 VA: 0x1810DEAD0
	private static void InternalCollect(int generation) { }

	// RVA: 0x10DEB70 Offset: 0x10DD170 VA: 0x1810DEB70
	private static void RecordPressure(long bytesAllocated) { }

	// RVA: 0xD6A480 Offset: 0xD68A80 VA: 0x180D6A480
	internal static void register_ephemeron_array(Ephemeron[] array) { }

	// RVA: 0x10DEDD0 Offset: 0x10DD3D0 VA: 0x1810DEDD0
	private static object get_ephemeron_tombstone() { }

	// RVA: 0x10DE870 Offset: 0x10DCE70 VA: 0x1810DE870
	public static void AddMemoryPressure(long bytesAllocated) { }

	// RVA: 0x10DEB80 Offset: 0x10DD180 VA: 0x1810DEB80
	public static void RemoveMemoryPressure(long bytesAllocated) { }

	// RVA: 0x10DE970 Offset: 0x10DCF70 VA: 0x1810DE970
	public static void Collect() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x10DEA00 Offset: 0x10DD000 VA: 0x1810DEA00
	public static int CollectionCount(int generation) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void KeepAlive(object obj) { }

	// RVA: 0x10DED80 Offset: 0x10DD380 VA: 0x1810DED80
	public static int get_MaxGeneration() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x10DED20 Offset: 0x10DD320 VA: 0x1810DED20
	private static void _SuppressFinalize(object o) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x10DEC80 Offset: 0x10DD280 VA: 0x1810DEC80
	public static void SuppressFinalize(object obj) { }

	// RVA: 0x10DED10 Offset: 0x10DD310 VA: 0x1810DED10
	private static void _ReRegisterForFinalize(object o) { }

	// RVA: 0x10DEAE0 Offset: 0x10DD0E0 VA: 0x1810DEAE0
	public static void ReRegisterForFinalize(object obj) { }

	// RVA: 0x10DEAC0 Offset: 0x10DD0C0 VA: 0x1810DEAC0
	public static long GetTotalMemory(bool forceFullCollection) { }

	// RVA: 0x10DED30 Offset: 0x10DD330 VA: 0x1810DED30
	private static void .cctor() { }

}

public class GC : ConsoleSystem // TypeDefIndex: 11925
{	// Fields
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool buffer_enabled; // 0x0
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static int debuglevel; // 0x4
	private static int m_buffer; // 0x8

	// Properties
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static int buffer { get; set; }
	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static bool incremental_enabled { get; set; }
	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static int incremental_milliseconds { get; set; }
	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	public static bool enabled { get; set; }

	// Methods

	// RVA: 0x6E08D0 Offset: 0x6DEED0 VA: 0x1806E08D0
	public static int get_buffer() { }

	// RVA: 0x6E0980 Offset: 0x6DEF80 VA: 0x1806E0980
	public static void set_buffer(int value) { }

	// RVA: 0x6E0940 Offset: 0x6DEF40 VA: 0x1806E0940
	public static bool get_incremental_enabled() { }

	// RVA: 0x6E0A70 Offset: 0x6DF070 VA: 0x1806E0A70
	public static void set_incremental_enabled(bool value) { }

	// RVA: 0x6E0950 Offset: 0x6DEF50 VA: 0x1806E0950
	public static int get_incremental_milliseconds() { }

	// RVA: 0x6E0AC0 Offset: 0x6DF0C0 VA: 0x1806E0AC0
	public static void set_incremental_milliseconds(int value) { }

	// RVA: 0x6E0930 Offset: 0x6DEF30 VA: 0x1806E0930
	public static bool get_enabled() { }

	// RVA: 0x6E0A20 Offset: 0x6DF020 VA: 0x1806E0A20
	public static void set_enabled(bool value) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E08C0 Offset: 0x6DEEC0 VA: 0x1806E08C0
	public static void collect() { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E0B30 Offset: 0x6DF130 VA: 0x1806E0B30
	public static void unload() { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E0740 Offset: 0x6DED40 VA: 0x1806E0740
	public static void alloc(ConsoleSystem.Arg args) { }

	// RVA: 0x6E06E0 Offset: 0x6DECE0 VA: 0x1806E06E0
	public void .ctor() { }

	// RVA: 0x6E0680 Offset: 0x6DEC80 VA: 0x1806E0680
	private static void .cctor() { }

}

public class GC : MonoBehaviour, IClientComponent // TypeDefIndex: 12029
{	// Fields
	private static float gcTime; // 0x0
	private static GarbageCollector.Mode gcMode; // 0x4
	private int heapSize; // 0x18
	private int heapBaseline; // 0x1C
	private int collectionCount; // 0x20

	// Properties
	public static bool Enabled { get; }

	// Methods

	// RVA: 0x4BD920 Offset: 0x4BBF20 VA: 0x1804BD920
	public static bool get_Enabled() { }

	// RVA: 0x4BD140 Offset: 0x4BB740 VA: 0x1804BD140
	public static void Collect() { }

	// RVA: 0x4BD6E0 Offset: 0x4BBCE0 VA: 0x1804BD6E0
	public static void Pause(float time) { }

	// RVA: 0x4BD790 Offset: 0x4BBD90 VA: 0x1804BD790
	public static void Reset(float time) { }

	// RVA: 0x4BD840 Offset: 0x4BBE40 VA: 0x1804BD840
	private static void SetMode(GarbageCollector.Mode mode) { }

	// RVA: 0x4BD220 Offset: 0x4BB820 VA: 0x1804BD220
	private static int GetTotalMemory() { }

	// RVA: 0x4BD1D0 Offset: 0x4BB7D0 VA: 0x1804BD1D0
	private static int CollectionCount() { }

	// RVA: 0x4BD870 Offset: 0x4BBE70 VA: 0x1804BD870
	private void UpdateState() { }

	// RVA: 0x4BD6D0 Offset: 0x4BBCD0 VA: 0x1804BD6D0
	protected void OnEnable() { }

	// RVA: 0x4BD6A0 Offset: 0x4BBCA0 VA: 0x1804BD6A0
	protected void OnDisable() { }

	// RVA: 0x4BD280 Offset: 0x4BB880 VA: 0x1804BD280
	protected void LateUpdate() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

