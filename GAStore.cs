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

	// RVA: 0x13C31E0 Offset: 0x13C17E0 VA: 0x1813C31E0
	private static GAStore get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	private SqliteConnection get_SqlDatabase() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_SqlDatabase(SqliteConnection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7F9AE0 Offset: 0x7F80E0 VA: 0x1807F9AE0
	private void set_DbReady(bool value) { }

	// RVA: 0x13C3300 Offset: 0x13C1900 VA: 0x1813C3300
	public static bool get_IsTableReady() { }

	// RVA: 0x13C33B0 Offset: 0x13C19B0 VA: 0x1813C33B0
	private static void set_IsTableReady(bool value) { }

	// RVA: 0x13C32A0 Offset: 0x13C18A0 VA: 0x1813C32A0
	public static bool get_IsDbTooLargeForEvents() { }

	// RVA: 0x13C30B0 Offset: 0x13C16B0 VA: 0x1813C30B0
	private void .ctor() { }

	// RVA: 0x13C2300 Offset: 0x13C0900 VA: 0x1813C2300
	public static JSONArray ExecuteQuerySync(string sql) { }

	// RVA: 0x13C23C0 Offset: 0x13C09C0 VA: 0x1813C23C0
	public static JSONArray ExecuteQuerySync(string sql, Dictionary<string, object> parameters) { }

	// RVA: 0x13C2430 Offset: 0x13C0A30 VA: 0x1813C2430
	public static JSONArray ExecuteQuerySync(string sql, Dictionary<string, object> parameters, bool useTransaction) { }

	// RVA: 0x13C14D0 Offset: 0x13BFAD0 VA: 0x1813C14D0
	public static bool EnsureDatabase(bool dropDatabase, string key) { }

	// RVA: 0x13C2CA0 Offset: 0x13C12A0 VA: 0x1813C2CA0
	public static void SetState(string key, string value) { }

	// RVA: 0x13C3100 Offset: 0x13C1700 VA: 0x1813C3100
	public static long get_DbSizeBytes() { }

	// RVA: 0x13C2E10 Offset: 0x13C1410 VA: 0x1813C2E10
	private static void TrimEventTable() { }

	// RVA: 0x13C3020 Offset: 0x13C1620 VA: 0x1813C3020
	private static void .cctor() { }

}

