internal static class UnsafeNativeMethods.ManifestEtw // TypeDefIndex: 91
{
// Namespace: 
internal static class UnsafeNativeMethods.ManifestEtw // TypeDefIndex: 91
	// Methods

	// RVA: 0x16463B0 Offset: 0x16449B0 VA: 0x1816463B0
	internal static extern uint EventRegister(in Guid providerId, [In] UnsafeNativeMethods.ManifestEtw.EtwEnableCallback enableCallback, [In] void* callbackContext, ref long registrationHandle) { }

	// RVA: 0x1646500 Offset: 0x1644B00 VA: 0x181646500
	internal static extern uint EventUnregister([In] long registrationHandle) { }

	// RVA: 0x1646580 Offset: 0x1644B80 VA: 0x181646580
	internal static int EventWriteTransferWrapper(long registrationHandle, ref EventDescriptor eventDescriptor, Guid* activityId, Guid* relatedActivityId, int userDataCount, EventProvider.EventData* userData) { }

	// RVA: 0x1646680 Offset: 0x1644C80 VA: 0x181646680
	private static extern int EventWriteTransfer([In] long registrationHandle, in EventDescriptor eventDescriptor, [In] Guid* activityId, [In] Guid* relatedActivityId, [In] int userDataCount, [In] EventProvider.EventData* userData) { }

	// RVA: 0x1646320 Offset: 0x1644920 VA: 0x181646320
	internal static extern int EventActivityIdControl([In] UnsafeNativeMethods.ManifestEtw.ActivityControl ControlCode, ref Guid ActivityId) { }

	// RVA: 0x1646460 Offset: 0x1644A60 VA: 0x181646460
	internal static extern int EventSetInformation([In] long registrationHandle, [In] UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS informationClass, [In] void* eventInformation, [In] int informationLength) { }

	// RVA: 0x1646260 Offset: 0x1644860 VA: 0x181646260
	internal static extern int EnumerateTraceGuidsEx(UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceQueryInfoClass, void* InBuffer, int InBufferSize, void* OutBuffer, int OutBufferSize, ref int ReturnLength) { }

}

internal sealed class UnsafeNativeMethods.ManifestEtw.EtwEnableCallback : MulticastDelegate // TypeDefIndex: 92
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x163CE00 Offset: 0x163B400 VA: 0x18163CE00 Slot: 12
	public virtual void Invoke(in Guid sourceId, [In] int isEnabled, [In] byte level, [In] long matchAnyKeywords, [In] long matchAllKeywords, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext) { }

	// RVA: 0x163CCE0 Offset: 0x163B2E0 VA: 0x18163CCE0 Slot: 13
	public virtual IAsyncResult BeginInvoke(in Guid sourceId, [In] int isEnabled, [In] byte level, [In] long matchAnyKeywords, [In] long matchAllKeywords, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext, AsyncCallback callback, object object) { }

	// RVA: 0x163CDE0 Offset: 0x163B3E0 VA: 0x18163CDE0 Slot: 14
	public virtual void EndInvoke(in Guid sourceId, IAsyncResult result) { }

}

internal struct UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR // TypeDefIndex: 93
{	// Fields
	public long Ptr; // 0x0
	public int Size; // 0x8
	public int Type; // 0xC

}

internal enum UnsafeNativeMethods.ManifestEtw.ActivityControl // TypeDefIndex: 94
{	// Fields
	public uint value__; // 0x0
	public const UnsafeNativeMethods.ManifestEtw.ActivityControl EVENT_ACTIVITY_CTRL_GET_ID = 1;
	public const UnsafeNativeMethods.ManifestEtw.ActivityControl EVENT_ACTIVITY_CTRL_SET_ID = 2;
	public const UnsafeNativeMethods.ManifestEtw.ActivityControl EVENT_ACTIVITY_CTRL_CREATE_ID = 3;
	public const UnsafeNativeMethods.ManifestEtw.ActivityControl EVENT_ACTIVITY_CTRL_GET_SET_ID = 4;
	public const UnsafeNativeMethods.ManifestEtw.ActivityControl EVENT_ACTIVITY_CTRL_CREATE_SET_ID = 5;

}

internal enum UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS // TypeDefIndex: 95
{	// Fields
	public int value__; // 0x0
	public const UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS BinaryTrackInfo = 0;
	public const UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS SetEnableAllKeywords = 1;
	public const UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS SetTraits = 2;

}

internal enum UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS // TypeDefIndex: 96
{	// Fields
	public int value__; // 0x0
	public const UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceGuidQueryList = 0;
	public const UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceGuidQueryInfo = 1;
	public const UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceGuidQueryProcess = 2;
	public const UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceStackTracingInfo = 3;
	public const UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS MaxTraceSetInfoClass = 4;

}

internal struct UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO // TypeDefIndex: 97
{	// Fields
	public int InstanceCount; // 0x0
	public int Reserved; // 0x4

}

internal struct UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO // TypeDefIndex: 98
{	// Fields
	public int NextOffset; // 0x0
	public int EnableCount; // 0x4
	public int Pid; // 0x8
	public int Flags; // 0xC

}

internal struct UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO // TypeDefIndex: 99
{	// Fields
	public int IsEnabled; // 0x0
	public byte Level; // 0x4
	public byte Reserved1; // 0x5
	public ushort LoggerId; // 0x6
	public int EnableProperty; // 0x8
	public int Reserved2; // 0xC
	public long MatchAnyKeyword; // 0x10
	public long MatchAllKeyword; // 0x18

}

internal static class UnsafeNativeMethods // TypeDefIndex: 4896
{	// Fields
	internal static readonly bool use_sqlite3_close_v2; // 0x0
	internal static readonly bool use_sqlite3_open_v2; // 0x1
	internal static readonly bool use_sqlite3_create_function_v2; // 0x2

	// Methods

	// RVA: 0x21F99D0 Offset: 0x21F7FD0 VA: 0x1821F99D0
	private static void .cctor() { }

	// RVA: 0x21FA330 Offset: 0x21F8930 VA: 0x1821FA330
	internal static extern int sqlite3_close(IntPtr db) { }

	// RVA: 0x21FA3B0 Offset: 0x21F89B0 VA: 0x1821FA3B0
	internal static extern int sqlite3_close_v2(IntPtr db) { }

	// RVA: 0x21FAFB0 Offset: 0x21F95B0 VA: 0x1821FAFB0
	internal static extern int sqlite3_create_function(IntPtr db, byte[] strName, int nArgs, int nType, IntPtr pvUser, SQLiteCallback func, SQLiteCallback fstep, SQLiteFinalCallback ffinal) { }

	// RVA: 0x21FB1F0 Offset: 0x21F97F0 VA: 0x1821FB1F0
	internal static extern int sqlite3_finalize(IntPtr stmt) { }

	// RVA: 0x21FB640 Offset: 0x21F9C40 VA: 0x1821FB640
	internal static extern int sqlite3_open_v2(byte[] utf8Filename, out IntPtr db, int flags, IntPtr vfs) { }

	// RVA: 0x21FB5A0 Offset: 0x21F9BA0 VA: 0x1821FB5A0
	internal static extern int sqlite3_open(byte[] utf8Filename, out IntPtr db) { }

	// RVA: 0x21FB500 Offset: 0x21F9B00 VA: 0x1821FB500
	internal static extern int sqlite3_open16(string fileName, out IntPtr db) { }

	// RVA: 0x21FB7B0 Offset: 0x21F9DB0 VA: 0x1821FB7B0
	internal static extern int sqlite3_reset(IntPtr stmt) { }

	// RVA: 0x21FA010 Offset: 0x21F8610 VA: 0x1821FA010
	internal static extern IntPtr sqlite3_bind_parameter_name(IntPtr stmt, int index) { }

	// RVA: 0x21FA660 Offset: 0x21F8C60 VA: 0x1821FA660
	internal static extern IntPtr sqlite3_column_database_name(IntPtr stmt, int index) { }

	// RVA: 0x21FA5D0 Offset: 0x21F8BD0 VA: 0x1821FA5D0
	internal static extern IntPtr sqlite3_column_database_name16(IntPtr stmt, int index) { }

	// RVA: 0x21FA6F0 Offset: 0x21F8CF0 VA: 0x1821FA6F0
	internal static extern IntPtr sqlite3_column_decltype(IntPtr stmt, int index) { }

	// RVA: 0x21FA9C0 Offset: 0x21F8FC0 VA: 0x1821FA9C0
	internal static extern IntPtr sqlite3_column_name(IntPtr stmt, int index) { }

	// RVA: 0x21FA930 Offset: 0x21F8F30 VA: 0x1821FA930
	internal static extern IntPtr sqlite3_column_name16(IntPtr stmt, int index) { }

	// RVA: 0x21FAAE0 Offset: 0x21F90E0 VA: 0x1821FAAE0
	internal static extern IntPtr sqlite3_column_origin_name(IntPtr stmt, int index) { }

	// RVA: 0x21FAA50 Offset: 0x21F9050 VA: 0x1821FAA50
	internal static extern IntPtr sqlite3_column_origin_name16(IntPtr stmt, int index) { }

	// RVA: 0x21FAC00 Offset: 0x21F9200 VA: 0x1821FAC00
	internal static extern IntPtr sqlite3_column_table_name(IntPtr stmt, int index) { }

	// RVA: 0x21FAB70 Offset: 0x21F9170 VA: 0x1821FAB70
	internal static extern IntPtr sqlite3_column_table_name16(IntPtr stmt, int index) { }

	// RVA: 0x21FAD20 Offset: 0x21F9320 VA: 0x1821FAD20
	internal static extern IntPtr sqlite3_column_text(IntPtr stmt, int index) { }

	// RVA: 0x21FAC90 Offset: 0x21F9290 VA: 0x1821FAC90
	internal static extern IntPtr sqlite3_column_text16(IntPtr stmt, int index) { }

	// RVA: 0x21FB0B0 Offset: 0x21F96B0 VA: 0x1821FB0B0
	internal static extern IntPtr sqlite3_errmsg(IntPtr db) { }

	// RVA: 0x21FB6F0 Offset: 0x21F9CF0 VA: 0x1821FB6F0
	internal static extern int sqlite3_prepare(IntPtr db, IntPtr pSql, int nBytes, out IntPtr stmt, out IntPtr ptrRemain) { }

	// RVA: 0x21FBE40 Offset: 0x21FA440 VA: 0x1821FBE40
	internal static extern int sqlite3_table_column_metadata(IntPtr db, byte[] dbName, byte[] tblName, byte[] colName, out IntPtr ptrDataType, out IntPtr ptrCollSeq, out int notNull, out int primaryKey, out int autoInc) { }

	// RVA: 0x21FC270 Offset: 0x21FA870 VA: 0x1821FC270
	internal static extern IntPtr sqlite3_value_text(IntPtr p) { }

	// RVA: 0x21FC1F0 Offset: 0x21FA7F0 VA: 0x1821FC1F0
	internal static extern IntPtr sqlite3_value_text16(IntPtr p) { }

	// RVA: 0x21FB390 Offset: 0x21F9990 VA: 0x1821FB390
	internal static extern IntPtr sqlite3_libversion() { }

	// RVA: 0x21FA2B0 Offset: 0x21F88B0 VA: 0x1821FA2B0
	internal static extern int sqlite3_changes(IntPtr db) { }

	// RVA: 0x21FA220 Offset: 0x21F8820 VA: 0x1821FA220
	internal static extern int sqlite3_busy_timeout(IntPtr db, int ms) { }

	// RVA: 0x21F9C60 Offset: 0x21F8260 VA: 0x1821F9C60
	internal static extern int sqlite3_bind_blob(IntPtr stmt, int index, byte[] value, int nSize, IntPtr nTransient) { }

	// RVA: 0x21F9D20 Offset: 0x21F8320 VA: 0x1821F9D20
	internal static extern int sqlite3_bind_double(IntPtr stmt, int index, double value) { }

	// RVA: 0x21F9E60 Offset: 0x21F8460 VA: 0x1821F9E60
	internal static extern int sqlite3_bind_int(IntPtr stmt, int index, int value) { }

	// RVA: 0x21F9DC0 Offset: 0x21F83C0 VA: 0x1821F9DC0
	internal static extern int sqlite3_bind_int64(IntPtr stmt, int index, long value) { }

	// RVA: 0x21F9F00 Offset: 0x21F8500 VA: 0x1821F9F00
	internal static extern int sqlite3_bind_null(IntPtr stmt, int index) { }

	// RVA: 0x21FA160 Offset: 0x21F8760 VA: 0x1821FA160
	internal static extern int sqlite3_bind_text(IntPtr stmt, int index, byte[] value, int nlen, IntPtr pvReserved) { }

	// RVA: 0x21F9F90 Offset: 0x21F8590 VA: 0x1821F9F90
	internal static extern int sqlite3_bind_parameter_count(IntPtr stmt) { }

	// RVA: 0x21FA550 Offset: 0x21F8B50 VA: 0x1821FA550
	internal static extern int sqlite3_column_count(IntPtr stmt) { }

	// RVA: 0x21FBDC0 Offset: 0x21FA3C0 VA: 0x1821FBDC0
	internal static extern int sqlite3_step(IntPtr stmt) { }

	// RVA: 0x21FA780 Offset: 0x21F8D80 VA: 0x1821FA780
	internal static extern double sqlite3_column_double(IntPtr stmt, int index) { }

	// RVA: 0x21FA8A0 Offset: 0x21F8EA0 VA: 0x1821FA8A0
	internal static extern int sqlite3_column_int(IntPtr stmt, int index) { }

	// RVA: 0x21FA810 Offset: 0x21F8E10 VA: 0x1821FA810
	internal static extern long sqlite3_column_int64(IntPtr stmt, int index) { }

	// RVA: 0x21FA430 Offset: 0x21F8A30 VA: 0x1821FA430
	internal static extern IntPtr sqlite3_column_blob(IntPtr stmt, int index) { }

	// RVA: 0x21FA4C0 Offset: 0x21F8AC0 VA: 0x1821FA4C0
	internal static extern int sqlite3_column_bytes(IntPtr stmt, int index) { }

	// RVA: 0x21FADB0 Offset: 0x21F93B0 VA: 0x1821FADB0
	internal static extern TypeAffinity sqlite3_column_type(IntPtr stmt, int index) { }

	// RVA: 0x21FAEE0 Offset: 0x21F94E0 VA: 0x1821FAEE0
	internal static extern int sqlite3_create_collation(IntPtr db, byte[] strName, int nType, IntPtr pvUser, SQLiteCollation func) { }

	// RVA: 0x21FBFF0 Offset: 0x21FA5F0 VA: 0x1821FBFF0
	internal static extern IntPtr sqlite3_value_blob(IntPtr p) { }

	// RVA: 0x21FC070 Offset: 0x21FA670 VA: 0x1821FC070
	internal static extern int sqlite3_value_bytes(IntPtr p) { }

	// RVA: 0x21FC0F0 Offset: 0x21FA6F0 VA: 0x1821FC0F0
	internal static extern double sqlite3_value_double(IntPtr p) { }

	// RVA: 0x21FC170 Offset: 0x21FA770 VA: 0x1821FC170
	internal static extern long sqlite3_value_int64(IntPtr p) { }

	// RVA: 0x21FC2F0 Offset: 0x21FA8F0 VA: 0x1821FC2F0
	internal static extern TypeAffinity sqlite3_value_type(IntPtr p) { }

	// RVA: 0x21FB830 Offset: 0x21F9E30 VA: 0x1821FB830
	internal static extern void sqlite3_result_blob(IntPtr context, byte[] value, int nSize, IntPtr pvReserved) { }

	// RVA: 0x21FB8E0 Offset: 0x21F9EE0 VA: 0x1821FB8E0
	internal static extern void sqlite3_result_double(IntPtr context, double value) { }

	// RVA: 0x21FBA10 Offset: 0x21FA010 VA: 0x1821FBA10
	internal static extern void sqlite3_result_error(IntPtr context, byte[] strErr, int nLen) { }

	// RVA: 0x21FBAB0 Offset: 0x21FA0B0 VA: 0x1821FBAB0
	internal static extern void sqlite3_result_int64(IntPtr context, long value) { }

	// RVA: 0x21FBB40 Offset: 0x21FA140 VA: 0x1821FBB40
	internal static extern void sqlite3_result_null(IntPtr context) { }

	// RVA: 0x21FBC70 Offset: 0x21FA270 VA: 0x1821FBC70
	internal static extern void sqlite3_result_text(IntPtr context, byte[] value, int nLen, IntPtr pvReserved) { }

	// RVA: 0x21F9BD0 Offset: 0x21F81D0 VA: 0x1821F9BD0
	internal static extern IntPtr sqlite3_aggregate_context(IntPtr context, int nBytes) { }

	// RVA: 0x21FA0A0 Offset: 0x21F86A0 VA: 0x1821FA0A0
	internal static extern int sqlite3_bind_text16(IntPtr stmt, int index, string value, int nlen, IntPtr pvReserved) { }

	// RVA: 0x21FB970 Offset: 0x21F9F70 VA: 0x1821FB970
	internal static extern void sqlite3_result_error16(IntPtr context, string strName, int nLen) { }

	// RVA: 0x21FBBC0 Offset: 0x21FA1C0 VA: 0x1821FBBC0
	internal static extern void sqlite3_result_text16(IntPtr context, string strName, int nLen, IntPtr pvReserved) { }

	// RVA: 0x21FB2F0 Offset: 0x21F98F0 VA: 0x1821FB2F0
	internal static extern int sqlite3_key(IntPtr db, byte[] key, int keylen) { }

	// RVA: 0x21FBF50 Offset: 0x21FA550 VA: 0x1821FBF50
	internal static extern IntPtr sqlite3_update_hook(IntPtr db, SQLiteUpdateCallback func, IntPtr pvUser) { }

	// RVA: 0x21FAE40 Offset: 0x21F9440 VA: 0x1821FAE40
	internal static extern IntPtr sqlite3_commit_hook(IntPtr db, SQLiteCommitCallback func, IntPtr pvUser) { }

	// RVA: 0x21FBD20 Offset: 0x21FA320 VA: 0x1821FBD20
	internal static extern IntPtr sqlite3_rollback_hook(IntPtr db, SQLiteRollbackCallback func, IntPtr pvUser) { }

	// RVA: 0x21FB470 Offset: 0x21F9A70 VA: 0x1821FB470
	internal static extern IntPtr sqlite3_next_stmt(IntPtr db, IntPtr stmt) { }

	// RVA: 0x21FB130 Offset: 0x21F9730 VA: 0x1821FB130
	internal static extern int sqlite3_exec(IntPtr db, byte[] strSql, IntPtr pvCallback, IntPtr pvParam, out IntPtr errMsg) { }

	// RVA: 0x21FB270 Offset: 0x21F9870 VA: 0x1821FB270
	internal static extern int sqlite3_free(IntPtr ptr) { }

	// RVA: 0x21FB400 Offset: 0x21F9A00 VA: 0x1821FB400
	internal static extern int sqlite3_libversion_number() { }

}

