public static class GC // TypeDefIndex: 224
{	// Fields
	internal static readonly object EPHEMERON_TOMBSTONE; // 0x13CF0

	// Properties
	public static int MaxGeneration { get; }

	// Methods

	// RVA: 0x10DDD70 Offset: 0x10DC370 VA: 0x1810DDD70
	private static int GetCollectionCount(int generation) { }

	// RVA: 0x10DDD80 Offset: 0x10DC380 VA: 0x1810DDD80
	private static int GetMaxGeneration() { }

	// RVA: 0x10DDDA0 Offset: 0x10DC3A0 VA: 0x1810DDDA0
	private static void InternalCollect(int generation) { }

	// RVA: 0x10DDE40 Offset: 0x10DC440 VA: 0x1810DDE40
	private static void RecordPressure(long bytesAllocated) { }

	// RVA: 0xD69710 Offset: 0xD67D10 VA: 0x180D69710
	internal static void register_ephemeron_array(Ephemeron[] array) { }

	// RVA: 0x10DE0A0 Offset: 0x10DC6A0 VA: 0x1810DE0A0
	private static object get_ephemeron_tombstone() { }

	// RVA: 0x10DDB40 Offset: 0x10DC140 VA: 0x1810DDB40
	public static void AddMemoryPressure(long bytesAllocated) { }

	// RVA: 0x10DDE50 Offset: 0x10DC450 VA: 0x1810DDE50
	public static void RemoveMemoryPressure(long bytesAllocated) { }

	// RVA: 0x10DDC40 Offset: 0x10DC240 VA: 0x1810DDC40
	public static void Collect() { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x10DDCD0 Offset: 0x10DC2D0 VA: 0x1810DDCD0
	public static int CollectionCount(int generation) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void KeepAlive(object obj) { }

	// RVA: 0x10DE050 Offset: 0x10DC650 VA: 0x1810DE050
	public static int get_MaxGeneration() { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x10DDFF0 Offset: 0x10DC5F0 VA: 0x1810DDFF0
	private static void _SuppressFinalize(object o) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x10DDF50 Offset: 0x10DC550 VA: 0x1810DDF50
	public static void SuppressFinalize(object obj) { }

	// RVA: 0x10DDFE0 Offset: 0x10DC5E0 VA: 0x1810DDFE0
	private static void _ReRegisterForFinalize(object o) { }

	// RVA: 0x10DDDB0 Offset: 0x10DC3B0 VA: 0x1810DDDB0
	public static void ReRegisterForFinalize(object obj) { }

	// RVA: 0x10DDD90 Offset: 0x10DC390 VA: 0x1810DDD90
	public static long GetTotalMemory(bool forceFullCollection) { }

	// RVA: 0x10DE000 Offset: 0x10DC600 VA: 0x1810DE000
	private static void .cctor() { }

}

public class GC : ConsoleSystem // TypeDefIndex: 11925
{	// Fields
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static bool buffer_enabled; // 0x0
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static int debuglevel; // 0x4
	private static int m_buffer; // 0x8

	// Properties
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static int buffer { get; set; }
	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	public static bool incremental_enabled { get; set; }
	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	public static int incremental_milliseconds { get; set; }
	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	public static bool enabled { get; set; }

	// Methods

	// RVA: 0x6E0830 Offset: 0x6DEE30 VA: 0x1806E0830
	public static int get_buffer() { }

	// RVA: 0x6E08E0 Offset: 0x6DEEE0 VA: 0x1806E08E0
	public static void set_buffer(int value) { }

	// RVA: 0x6E08A0 Offset: 0x6DEEA0 VA: 0x1806E08A0
	public static bool get_incremental_enabled() { }

	// RVA: 0x6E09D0 Offset: 0x6DEFD0 VA: 0x1806E09D0
	public static void set_incremental_enabled(bool value) { }

	// RVA: 0x6E08B0 Offset: 0x6DEEB0 VA: 0x1806E08B0
	public static int get_incremental_milliseconds() { }

	// RVA: 0x6E0A20 Offset: 0x6DF020 VA: 0x1806E0A20
	public static void set_incremental_milliseconds(int value) { }

	// RVA: 0x6E0890 Offset: 0x6DEE90 VA: 0x1806E0890
	public static bool get_enabled() { }

	// RVA: 0x6E0980 Offset: 0x6DEF80 VA: 0x1806E0980
	public static void set_enabled(bool value) { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6E0820 Offset: 0x6DEE20 VA: 0x1806E0820
	public static void collect() { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6E0A90 Offset: 0x6DF090 VA: 0x1806E0A90
	public static void unload() { }

	[ServerVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	[ClientVar] // RVA: 0x8AB90 Offset: 0x89F90 VA: 0x18008AB90
	// RVA: 0x6E06A0 Offset: 0x6DECA0 VA: 0x1806E06A0
	public static void alloc(ConsoleSystem.Arg args) { }

	// RVA: 0x6E0640 Offset: 0x6DEC40 VA: 0x1806E0640
	public void .ctor() { }

	// RVA: 0x6E05E0 Offset: 0x6DEBE0 VA: 0x1806E05E0
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

