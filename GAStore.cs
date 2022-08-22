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

	// RVA: 0x13C34A0 Offset: 0x13C1AA0 VA: 0x1813C34A0
	private static GAStore get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	private SqliteConnection get_SqlDatabase() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_SqlDatabase(SqliteConnection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7F9BF0 Offset: 0x7F81F0 VA: 0x1807F9BF0
	private void set_DbReady(bool value) { }

	// RVA: 0x13C35C0 Offset: 0x13C1BC0 VA: 0x1813C35C0
	public static bool get_IsTableReady() { }

	// RVA: 0x13C3670 Offset: 0x13C1C70 VA: 0x1813C3670
	private static void set_IsTableReady(bool value) { }

	// RVA: 0x13C3560 Offset: 0x13C1B60 VA: 0x1813C3560
	public static bool get_IsDbTooLargeForEvents() { }

	// RVA: 0x13C3370 Offset: 0x13C1970 VA: 0x1813C3370
	private void .ctor() { }

	// RVA: 0x13C25C0 Offset: 0x13C0BC0 VA: 0x1813C25C0
	public static JSONArray ExecuteQuerySync(string sql) { }

	// RVA: 0x13C2680 Offset: 0x13C0C80 VA: 0x1813C2680
	public static JSONArray ExecuteQuerySync(string sql, Dictionary<string, object> parameters) { }

	// RVA: 0x13C26F0 Offset: 0x13C0CF0 VA: 0x1813C26F0
	public static JSONArray ExecuteQuerySync(string sql, Dictionary<string, object> parameters, bool useTransaction) { }

	// RVA: 0x13C1790 Offset: 0x13BFD90 VA: 0x1813C1790
	public static bool EnsureDatabase(bool dropDatabase, string key) { }

	// RVA: 0x13C2F60 Offset: 0x13C1560 VA: 0x1813C2F60
	public static void SetState(string key, string value) { }

	// RVA: 0x13C33C0 Offset: 0x13C19C0 VA: 0x1813C33C0
	public static long get_DbSizeBytes() { }

	// RVA: 0x13C30D0 Offset: 0x13C16D0 VA: 0x1813C30D0
	private static void TrimEventTable() { }

	// RVA: 0x13C32E0 Offset: 0x13C18E0 VA: 0x1813C32E0
	private static void .cctor() { }

}

