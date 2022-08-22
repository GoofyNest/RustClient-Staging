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

	// RVA: 0x231EC70 Offset: 0x231D270 VA: 0x18231EC70
	internal static extern int sqlite3_open(string filename, out IntPtr db) { }

	// RVA: 0x231E5F0 Offset: 0x231CBF0 VA: 0x18231E5F0
	internal static extern int sqlite3_close(IntPtr db) { }

	// RVA: 0x231EB60 Offset: 0x231D160 VA: 0x18231EB60
	internal static extern int sqlite3_extended_result_codes(IntPtr db, int onoff) { }

	// RVA: 0x231ED10 Offset: 0x231D310 VA: 0x18231ED10
	internal static extern int sqlite3_prepare_v2(IntPtr db, string zSql, int nByte, out IntPtr ppStmpt, IntPtr pzTail) { }

	// RVA: 0x231EE60 Offset: 0x231D460 VA: 0x18231EE60
	internal static extern int sqlite3_step(IntPtr stmHandle) { }

	// RVA: 0x231EBF0 Offset: 0x231D1F0 VA: 0x18231EBF0
	internal static extern int sqlite3_finalize(IntPtr stmHandle) { }

	// RVA: 0x231EDE0 Offset: 0x231D3E0 VA: 0x18231EDE0
	internal static extern int sqlite3_reset(IntPtr stmHandle) { }

	// RVA: 0x231EAE0 Offset: 0x231D0E0 VA: 0x18231EAE0
	internal static extern IntPtr sqlite3_errmsg(IntPtr db) { }

	// RVA: 0x231E570 Offset: 0x231CB70 VA: 0x18231E570
	internal static extern int sqlite3_changes(IntPtr db) { }

	// RVA: 0x231E790 Offset: 0x231CD90 VA: 0x18231E790
	internal static extern int sqlite3_column_count(IntPtr stmHandle) { }

	// RVA: 0x231E930 Offset: 0x231CF30 VA: 0x18231E930
	internal static extern IntPtr sqlite3_column_name(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231EA50 Offset: 0x231D050 VA: 0x18231EA50
	internal static extern int sqlite3_column_type(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231E8A0 Offset: 0x231CEA0 VA: 0x18231E8A0
	internal static extern long sqlite3_column_int64(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231E9C0 Offset: 0x231CFC0 VA: 0x18231E9C0
	internal static extern IntPtr sqlite3_column_text16(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231E670 Offset: 0x231CC70 VA: 0x18231E670
	internal static extern IntPtr sqlite3_column_blob(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231E700 Offset: 0x231CD00 VA: 0x18231E700
	internal static extern int sqlite3_column_bytes(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231E810 Offset: 0x231CE10 VA: 0x18231E810
	internal static extern double sqlite3_column_double(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231E4C0 Offset: 0x231CAC0 VA: 0x18231E4C0
	internal static extern int sqlite3_bind_text16(IntPtr stmHandle, int i, IntPtr str, int len, IntPtr dest) { }

	// RVA: 0x231E390 Offset: 0x231C990 VA: 0x18231E390
	internal static extern int sqlite3_bind_int64(IntPtr stmHandle, int i, long val) { }

	// RVA: 0x231E240 Offset: 0x231C840 VA: 0x18231E240
	internal static extern int sqlite3_bind_blob(IntPtr stmHandle, int i, IntPtr str, int len, IntPtr dest) { }

	// RVA: 0x231E2F0 Offset: 0x231C8F0 VA: 0x18231E2F0
	internal static extern int sqlite3_bind_double(IntPtr stmHandle, int i, double val) { }

	// RVA: 0x231E430 Offset: 0x231CA30 VA: 0x18231E430
	internal static extern int sqlite3_bind_null(IntPtr stmHandle, int i) { }

	// RVA: 0x231E100 Offset: 0x231C700 VA: 0x18231E100
	public static string GetTypeName(int sqliteType) { }

	// RVA: 0x231E1B0 Offset: 0x231C7B0 VA: 0x18231E1B0
	private static void .cctor() { }

}

