public static class GC // TypeDefIndex: 224
{	// Fields
	internal static readonly object EPHEMERON_TOMBSTONE; // 0x13CF0

	// Properties
	public static int MaxGeneration { get; }

	// Methods

	// RVA: 0x10DE030 Offset: 0x10DC630 VA: 0x1810DE030
	private static int GetCollectionCount(int generation) { }

	// RVA: 0x10DE040 Offset: 0x10DC640 VA: 0x1810DE040
	private static int GetMaxGeneration() { }

	// RVA: 0x10DE060 Offset: 0x10DC660 VA: 0x1810DE060
	private static void InternalCollect(int generation) { }

	// RVA: 0x10DE100 Offset: 0x10DC700 VA: 0x1810DE100
	private static void RecordPressure(long bytesAllocated) { }

	// RVA: 0xD699D0 Offset: 0xD67FD0 VA: 0x180D699D0
	internal static void register_ephemeron_array(Ephemeron[] array) { }

	// RVA: 0x10DE360 Offset: 0x10DC960 VA: 0x1810DE360
	private static object get_ephemeron_tombstone() { }

	// RVA: 0x10DDE00 Offset: 0x10DC400 VA: 0x1810DDE00
	public static void AddMemoryPressure(long bytesAllocated) { }

	// RVA: 0x10DE110 Offset: 0x10DC710 VA: 0x1810DE110
	public static void RemoveMemoryPressure(long bytesAllocated) { }

	// RVA: 0x10DDF00 Offset: 0x10DC500 VA: 0x1810DDF00
	public static void Collect() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x10DDF90 Offset: 0x10DC590 VA: 0x1810DDF90
	public static int CollectionCount(int generation) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void KeepAlive(object obj) { }

	// RVA: 0x10DE310 Offset: 0x10DC910 VA: 0x1810DE310
	public static int get_MaxGeneration() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x10DE2B0 Offset: 0x10DC8B0 VA: 0x1810DE2B0
	private static void _SuppressFinalize(object o) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x10DE210 Offset: 0x10DC810 VA: 0x1810DE210
	public static void SuppressFinalize(object obj) { }

	// RVA: 0x10DE2A0 Offset: 0x10DC8A0 VA: 0x1810DE2A0
	private static void _ReRegisterForFinalize(object o) { }

	// RVA: 0x10DE070 Offset: 0x10DC670 VA: 0x1810DE070
	public static void ReRegisterForFinalize(object obj) { }

	// RVA: 0x10DE050 Offset: 0x10DC650 VA: 0x1810DE050
	public static long GetTotalMemory(bool forceFullCollection) { }

	// RVA: 0x10DE2C0 Offset: 0x10DC8C0 VA: 0x1810DE2C0
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

	// RVA: 0x6E0940 Offset: 0x6DEF40 VA: 0x1806E0940
	public static int get_buffer() { }

	// RVA: 0x6E09F0 Offset: 0x6DEFF0 VA: 0x1806E09F0
	public static void set_buffer(int value) { }

	// RVA: 0x6E09B0 Offset: 0x6DEFB0 VA: 0x1806E09B0
	public static bool get_incremental_enabled() { }

	// RVA: 0x6E0AE0 Offset: 0x6DF0E0 VA: 0x1806E0AE0
	public static void set_incremental_enabled(bool value) { }

	// RVA: 0x6E09C0 Offset: 0x6DEFC0 VA: 0x1806E09C0
	public static int get_incremental_milliseconds() { }

	// RVA: 0x6E0B30 Offset: 0x6DF130 VA: 0x1806E0B30
	public static void set_incremental_milliseconds(int value) { }

	// RVA: 0x6E09A0 Offset: 0x6DEFA0 VA: 0x1806E09A0
	public static bool get_enabled() { }

	// RVA: 0x6E0A90 Offset: 0x6DF090 VA: 0x1806E0A90
	public static void set_enabled(bool value) { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E0930 Offset: 0x6DEF30 VA: 0x1806E0930
	public static void collect() { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E0BA0 Offset: 0x6DF1A0 VA: 0x1806E0BA0
	public static void unload() { }

	[ServerVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	[ClientVar] // RVA: 0x8AC00 Offset: 0x8A000 VA: 0x18008AC00
	// RVA: 0x6E07B0 Offset: 0x6DEDB0 VA: 0x1806E07B0
	public static void alloc(ConsoleSystem.Arg args) { }

	// RVA: 0x6E0750 Offset: 0x6DED50 VA: 0x1806E0750
	public void .ctor() { }

	// RVA: 0x6E06F0 Offset: 0x6DECF0 VA: 0x1806E06F0
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

	// RVA: 0x4BD990 Offset: 0x4BBF90 VA: 0x1804BD990
	public static bool get_Enabled() { }

	// RVA: 0x4BD1B0 Offset: 0x4BB7B0 VA: 0x1804BD1B0
	public static void Collect() { }

	// RVA: 0x4BD750 Offset: 0x4BBD50 VA: 0x1804BD750
	public static void Pause(float time) { }

	// RVA: 0x4BD800 Offset: 0x4BBE00 VA: 0x1804BD800
	public static void Reset(float time) { }

	// RVA: 0x4BD8B0 Offset: 0x4BBEB0 VA: 0x1804BD8B0
	private static void SetMode(GarbageCollector.Mode mode) { }

	// RVA: 0x4BD290 Offset: 0x4BB890 VA: 0x1804BD290
	private static int GetTotalMemory() { }

	// RVA: 0x4BD240 Offset: 0x4BB840 VA: 0x1804BD240
	private static int CollectionCount() { }

	// RVA: 0x4BD8E0 Offset: 0x4BBEE0 VA: 0x1804BD8E0
	private void UpdateState() { }

	// RVA: 0x4BD740 Offset: 0x4BBD40 VA: 0x1804BD740
	protected void OnEnable() { }

	// RVA: 0x4BD710 Offset: 0x4BBD10 VA: 0x1804BD710
	protected void OnDisable() { }

	// RVA: 0x4BD2F0 Offset: 0x4BB8F0 VA: 0x1804BD2F0
	protected void LateUpdate() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

