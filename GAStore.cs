internal class GAStore // TypeDefIndex: 5669
{	// Fields
	private static readonly GAStore _instance; // 0x0
	private string dbPath; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SqliteConnection <SqlDatabase>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <DbReady>k__BackingField; // 0x20
	private bool _tableReady; // 0x21

	// Properties
	private static GAStore Instance { get; }
	private SqliteConnection SqlDatabase { get; set; }
	private bool DbReady { set; }
	public static bool IsTableReady { get; set; }
	public static bool IsDbTooLargeForEvents { get; }
	public static long DbSizeBytes { get; }

	// Methods

	// RVA: 0x13C25A0 Offset: 0x13C0BA0 VA: 0x1813C25A0
	private static GAStore get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	private SqliteConnection get_SqlDatabase() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_SqlDatabase(SqliteConnection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7FA180 Offset: 0x7F8780 VA: 0x1807FA180
	private void set_DbReady(bool value) { }

	// RVA: 0x13C26C0 Offset: 0x13C0CC0 VA: 0x1813C26C0
	public static bool get_IsTableReady() { }

	// RVA: 0x13C2770 Offset: 0x13C0D70 VA: 0x1813C2770
	private static void set_IsTableReady(bool value) { }

	// RVA: 0x13C2660 Offset: 0x13C0C60 VA: 0x1813C2660
	public static bool get_IsDbTooLargeForEvents() { }

	// RVA: 0x13C2470 Offset: 0x13C0A70 VA: 0x1813C2470
	private void .ctor() { }

	// RVA: 0x13C16C0 Offset: 0x13BFCC0 VA: 0x1813C16C0
	public static JSONArray ExecuteQuerySync(string sql) { }

	// RVA: 0x13C1780 Offset: 0x13BFD80 VA: 0x1813C1780
	public static JSONArray ExecuteQuerySync(string sql, Dictionary<string, object> parameters) { }

	// RVA: 0x13C17F0 Offset: 0x13BFDF0 VA: 0x1813C17F0
	public static JSONArray ExecuteQuerySync(string sql, Dictionary<string, object> parameters, bool useTransaction) { }

	// RVA: 0x13C0890 Offset: 0x13BEE90 VA: 0x1813C0890
	public static bool EnsureDatabase(bool dropDatabase, string key) { }

	// RVA: 0x13C2060 Offset: 0x13C0660 VA: 0x1813C2060
	public static void SetState(string key, string value) { }

	// RVA: 0x13C24C0 Offset: 0x13C0AC0 VA: 0x1813C24C0
	public static long get_DbSizeBytes() { }

	// RVA: 0x13C21D0 Offset: 0x13C07D0 VA: 0x1813C21D0
	private static void TrimEventTable() { }

	// RVA: 0x13C23E0 Offset: 0x13C09E0 VA: 0x1813C23E0
	private static void .cctor() { }

}

