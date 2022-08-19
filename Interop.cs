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

	// RVA: 0x231EE30 Offset: 0x231D430 VA: 0x18231EE30
	internal static extern int sqlite3_open(string filename, out IntPtr db) { }

	// RVA: 0x231E7B0 Offset: 0x231CDB0 VA: 0x18231E7B0
	internal static extern int sqlite3_close(IntPtr db) { }

	// RVA: 0x231ED20 Offset: 0x231D320 VA: 0x18231ED20
	internal static extern int sqlite3_extended_result_codes(IntPtr db, int onoff) { }

	// RVA: 0x231EED0 Offset: 0x231D4D0 VA: 0x18231EED0
	internal static extern int sqlite3_prepare_v2(IntPtr db, string zSql, int nByte, out IntPtr ppStmpt, IntPtr pzTail) { }

	// RVA: 0x231F020 Offset: 0x231D620 VA: 0x18231F020
	internal static extern int sqlite3_step(IntPtr stmHandle) { }

	// RVA: 0x231EDB0 Offset: 0x231D3B0 VA: 0x18231EDB0
	internal static extern int sqlite3_finalize(IntPtr stmHandle) { }

	// RVA: 0x231EFA0 Offset: 0x231D5A0 VA: 0x18231EFA0
	internal static extern int sqlite3_reset(IntPtr stmHandle) { }

	// RVA: 0x231ECA0 Offset: 0x231D2A0 VA: 0x18231ECA0
	internal static extern IntPtr sqlite3_errmsg(IntPtr db) { }

	// RVA: 0x231E730 Offset: 0x231CD30 VA: 0x18231E730
	internal static extern int sqlite3_changes(IntPtr db) { }

	// RVA: 0x231E950 Offset: 0x231CF50 VA: 0x18231E950
	internal static extern int sqlite3_column_count(IntPtr stmHandle) { }

	// RVA: 0x231EAF0 Offset: 0x231D0F0 VA: 0x18231EAF0
	internal static extern IntPtr sqlite3_column_name(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231EC10 Offset: 0x231D210 VA: 0x18231EC10
	internal static extern int sqlite3_column_type(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231EA60 Offset: 0x231D060 VA: 0x18231EA60
	internal static extern long sqlite3_column_int64(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231EB80 Offset: 0x231D180 VA: 0x18231EB80
	internal static extern IntPtr sqlite3_column_text16(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231E830 Offset: 0x231CE30 VA: 0x18231E830
	internal static extern IntPtr sqlite3_column_blob(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231E8C0 Offset: 0x231CEC0 VA: 0x18231E8C0
	internal static extern int sqlite3_column_bytes(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231E9D0 Offset: 0x231CFD0 VA: 0x18231E9D0
	internal static extern double sqlite3_column_double(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231E680 Offset: 0x231CC80 VA: 0x18231E680
	internal static extern int sqlite3_bind_text16(IntPtr stmHandle, int i, IntPtr str, int len, IntPtr dest) { }

	// RVA: 0x231E550 Offset: 0x231CB50 VA: 0x18231E550
	internal static extern int sqlite3_bind_int64(IntPtr stmHandle, int i, long val) { }

	// RVA: 0x231E400 Offset: 0x231CA00 VA: 0x18231E400
	internal static extern int sqlite3_bind_blob(IntPtr stmHandle, int i, IntPtr str, int len, IntPtr dest) { }

	// RVA: 0x231E4B0 Offset: 0x231CAB0 VA: 0x18231E4B0
	internal static extern int sqlite3_bind_double(IntPtr stmHandle, int i, double val) { }

	// RVA: 0x231E5F0 Offset: 0x231CBF0 VA: 0x18231E5F0
	internal static extern int sqlite3_bind_null(IntPtr stmHandle, int i) { }

	// RVA: 0x231E2C0 Offset: 0x231C8C0 VA: 0x18231E2C0
	public static string GetTypeName(int sqliteType) { }

	// RVA: 0x231E370 Offset: 0x231C970 VA: 0x18231E370
	private static void .cctor() { }

}

