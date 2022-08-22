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

	// RVA: 0x231EF30 Offset: 0x231D530 VA: 0x18231EF30
	internal static extern int sqlite3_open(string filename, out IntPtr db) { }

	// RVA: 0x231E8B0 Offset: 0x231CEB0 VA: 0x18231E8B0
	internal static extern int sqlite3_close(IntPtr db) { }

	// RVA: 0x231EE20 Offset: 0x231D420 VA: 0x18231EE20
	internal static extern int sqlite3_extended_result_codes(IntPtr db, int onoff) { }

	// RVA: 0x231EFD0 Offset: 0x231D5D0 VA: 0x18231EFD0
	internal static extern int sqlite3_prepare_v2(IntPtr db, string zSql, int nByte, out IntPtr ppStmpt, IntPtr pzTail) { }

	// RVA: 0x231F120 Offset: 0x231D720 VA: 0x18231F120
	internal static extern int sqlite3_step(IntPtr stmHandle) { }

	// RVA: 0x231EEB0 Offset: 0x231D4B0 VA: 0x18231EEB0
	internal static extern int sqlite3_finalize(IntPtr stmHandle) { }

	// RVA: 0x231F0A0 Offset: 0x231D6A0 VA: 0x18231F0A0
	internal static extern int sqlite3_reset(IntPtr stmHandle) { }

	// RVA: 0x231EDA0 Offset: 0x231D3A0 VA: 0x18231EDA0
	internal static extern IntPtr sqlite3_errmsg(IntPtr db) { }

	// RVA: 0x231E830 Offset: 0x231CE30 VA: 0x18231E830
	internal static extern int sqlite3_changes(IntPtr db) { }

	// RVA: 0x231EA50 Offset: 0x231D050 VA: 0x18231EA50
	internal static extern int sqlite3_column_count(IntPtr stmHandle) { }

	// RVA: 0x231EBF0 Offset: 0x231D1F0 VA: 0x18231EBF0
	internal static extern IntPtr sqlite3_column_name(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231ED10 Offset: 0x231D310 VA: 0x18231ED10
	internal static extern int sqlite3_column_type(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231EB60 Offset: 0x231D160 VA: 0x18231EB60
	internal static extern long sqlite3_column_int64(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231EC80 Offset: 0x231D280 VA: 0x18231EC80
	internal static extern IntPtr sqlite3_column_text16(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231E930 Offset: 0x231CF30 VA: 0x18231E930
	internal static extern IntPtr sqlite3_column_blob(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231E9C0 Offset: 0x231CFC0 VA: 0x18231E9C0
	internal static extern int sqlite3_column_bytes(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231EAD0 Offset: 0x231D0D0 VA: 0x18231EAD0
	internal static extern double sqlite3_column_double(IntPtr stmHandle, int iCol) { }

	// RVA: 0x231E780 Offset: 0x231CD80 VA: 0x18231E780
	internal static extern int sqlite3_bind_text16(IntPtr stmHandle, int i, IntPtr str, int len, IntPtr dest) { }

	// RVA: 0x231E650 Offset: 0x231CC50 VA: 0x18231E650
	internal static extern int sqlite3_bind_int64(IntPtr stmHandle, int i, long val) { }

	// RVA: 0x231E500 Offset: 0x231CB00 VA: 0x18231E500
	internal static extern int sqlite3_bind_blob(IntPtr stmHandle, int i, IntPtr str, int len, IntPtr dest) { }

	// RVA: 0x231E5B0 Offset: 0x231CBB0 VA: 0x18231E5B0
	internal static extern int sqlite3_bind_double(IntPtr stmHandle, int i, double val) { }

	// RVA: 0x231E6F0 Offset: 0x231CCF0 VA: 0x18231E6F0
	internal static extern int sqlite3_bind_null(IntPtr stmHandle, int i) { }

	// RVA: 0x231E3C0 Offset: 0x231C9C0 VA: 0x18231E3C0
	public static string GetTypeName(int sqliteType) { }

	// RVA: 0x231E470 Offset: 0x231CA70 VA: 0x18231E470
	private static void .cctor() { }

}

