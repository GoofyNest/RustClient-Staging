internal static class Interop // TypeDefIndex: 7359
{	// Fields
	internal const int SQLITE_OK = 0;
	internal const int SQLITE_ROW = 100;
	internal const int SQLITE_DONE = 101;
	internal const int SQLITE_INTEGER = 1;
	internal const int SQLITE_FLOAT = 2;
	internal const int SQLITE_TEXT = 3;
	internal const int SQLITE_BLOB = 4;
	internal const int SQLITE_NULL = 5;
	internal static IntPtr SQLITE_STATIC; // 0x0
	internal static IntPtr SQLITE_TRANSIENT; // 0x8

	// Methods

	// RVA: 0x231F750 Offset: 0x231DD50 VA: 0x18231F750
	internal static extern int sqlite3_open(string filename, out IntPtr db) { }

	// RVA: 0x231F0D0 Offset: 0x231D6D0 VA: 0x18231F0D0
	internal static extern int sqlite3_close(IntPtr db) { }

	// RVA: 0x231F640 Offset: 0x231DC40 VA: 0x18231F640
	internal static extern int sqlite3_extended_result_codes(IntPtr db, int onoff) { }

	// RVA: 0x231F7F0 Offset: 0x231DDF0 VA: 0x18231F7F0
	internal static extern int sqlite3_prepare_v2(IntPtr db, string zSql, int nByte, out IntPtr ppStmpt, IntPtr pzTail) { }

	// RVA: 0x231F940 Offset: 0x231DF40 VA: 0x18231F940
	internal static extern int sqlite3_step(IntPtr stmHandle) { }

	// RVA: 0x231F6D0 Offset: 0x231DCD0 VA: 0x18231F6D0
	internal static extern int sqlite3_finalize(IntPtr stmHandle) { }

	// RVA: 0x231F8C0 Offset: 0x231DEC0 VA: 0x18231F8C0
	internal static extern int sqlite3_reset(IntPtr stmHandle) { }

	// RVA: 0x231F5C0 Offset: 0x231DBC0 VA: 0x18231F5C0
	internal static extern IntPtr sqlite3_errmsg(IntPtr db) { }

	// RVA: 0x231F050 Offset: 0x231D650 VA: 0x18231F050
	internal static extern int sqlite3_changes(IntPtr db) { }

	// RVA: 0x231F270 Offset: 0x231D870 VA: 0x18231F270
	internal static extern int sqlite3_column_count(IntPtr stmHandle) { }

	// RVA: 0x231F410 Offset: 0x231DA10 VA: 0x18231F410
	internal static extern IntPtr sqlite3_column_name(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231F530 Offset: 0x231DB30 VA: 0x18231F530
	internal static extern int sqlite3_column_type(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231F380 Offset: 0x231D980 VA: 0x18231F380
	internal static extern long sqlite3_column_int64(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231F4A0 Offset: 0x231DAA0 VA: 0x18231F4A0
	internal static extern IntPtr sqlite3_column_text16(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231F150 Offset: 0x231D750 VA: 0x18231F150
	internal static extern IntPtr sqlite3_column_blob(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231F1E0 Offset: 0x231D7E0 VA: 0x18231F1E0
	internal static extern int sqlite3_column_bytes(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231F2F0 Offset: 0x231D8F0 VA: 0x18231F2F0
	internal static extern double sqlite3_column_double(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231EFA0 Offset: 0x231D5A0 VA: 0x18231EFA0
	internal static extern int sqlite3_bind_text16(IntPtr stmHandle, int i, IntPtr str, int len, IntPtr dest) { }

	// RVA: 0x231EE70 Offset: 0x231D470 VA: 0x18231EE70
	internal static extern int sqlite3_bind_int64(IntPtr stmHandle, int i, long val) { }

	// RVA: 0x231ED20 Offset: 0x231D320 VA: 0x18231ED20
	internal static extern int sqlite3_bind_blob(IntPtr stmHandle, int i, IntPtr str, int len, IntPtr dest) { }

	// RVA: 0x231EDD0 Offset: 0x231D3D0 VA: 0x18231EDD0
	internal static extern int sqlite3_bind_double(IntPtr stmHandle, int i, double val) { }

	// RVA: 0x231EF10 Offset: 0x231D510 VA: 0x18231EF10
	internal static extern int sqlite3_bind_null(IntPtr stmHandle, int i) { }

	// RVA: 0x231EBE0 Offset: 0x231D1E0 VA: 0x18231EBE0
	public static string GetTypeName(int sqliteType) { }

	// RVA: 0x231EC90 Offset: 0x231D290 VA: 0x18231EC90
	private static void .cctor() { }

}

