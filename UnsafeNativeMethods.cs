internal static class UnsafeNativeMethods.ManifestEtw // TypeDefIndex: 91
{
// Namespace: 
internal static class UnsafeNativeMethods.ManifestEtw // TypeDefIndex: 91
	// Methods

	// RVA: 0x16460F0 Offset: 0x16446F0 VA: 0x1816460F0
	internal static extern uint EventRegister(in Guid providerId, [In] UnsafeNativeMethods.ManifestEtw.EtwEnableCallback enableCallback, [In] void* callbackContext, ref long registrationHandle) { }

	// RVA: 0x1646240 Offset: 0x1644840 VA: 0x181646240
	internal static extern uint EventUnregister([In] long registrationHandle) { }

	// RVA: 0x16462C0 Offset: 0x16448C0 VA: 0x1816462C0
	internal static int EventWriteTransferWrapper(long registrationHandle, ref EventDescriptor eventDescriptor, Guid* activityId, Guid* relatedActivityId, int userDataCount, EventProvider.EventData* userData) { }

	// RVA: 0x16463C0 Offset: 0x16449C0 VA: 0x1816463C0
	private static extern int EventWriteTransfer([In] long registrationHandle, in EventDescriptor eventDescriptor, [In] Guid* activityId, [In] Guid* relatedActivityId, [In] int userDataCount, [In] EventProvider.EventData* userData) { }

	// RVA: 0x1646060 Offset: 0x1644660 VA: 0x181646060
	internal static extern int EventActivityIdControl([In] UnsafeNativeMethods.ManifestEtw.ActivityControl ControlCode, ref Guid ActivityId) { }

	// RVA: 0x16461A0 Offset: 0x16447A0 VA: 0x1816461A0
	internal static extern int EventSetInformation([In] long registrationHandle, [In] UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS informationClass, [In] void* eventInformation, [In] int informationLength) { }

	// RVA: 0x1645FA0 Offset: 0x16445A0 VA: 0x181645FA0
	internal static extern int EnumerateTraceGuidsEx(UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceQueryInfoClass, void* InBuffer, int InBufferSize, void* OutBuffer, int OutBufferSize, ref int ReturnLength) { }

}

internal sealed class UnsafeNativeMethods.ManifestEtw.EtwEnableCallback : MulticastDelegate // TypeDefIndex: 92
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x163CB40 Offset: 0x163B140 VA: 0x18163CB40 Slot: 12
	public virtual void Invoke(in Guid sourceId, [In] int isEnabled, [In] byte level, [In] long matchAnyKeywords, [In] long matchAllKeywords, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext) { }

	// RVA: 0x163CA20 Offset: 0x163B020 VA: 0x18163CA20 Slot: 13
	public virtual IAsyncResult BeginInvoke(in Guid sourceId, [In] int isEnabled, [In] byte level, [In] long matchAnyKeywords, [In] long matchAllKeywords, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext, AsyncCallback callback, object object) { }

	// RVA: 0x163CB20 Offset: 0x163B120 VA: 0x18163CB20 Slot: 14
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

	// RVA: 0x21F9710 Offset: 0x21F7D10 VA: 0x1821F9710
	private static void .cctor() { }

	// RVA: 0x21FA070 Offset: 0x21F8670 VA: 0x1821FA070
	internal static extern int sqlite3_close(IntPtr db) { }

	// RVA: 0x21FA0F0 Offset: 0x21F86F0 VA: 0x1821FA0F0
	internal static extern int sqlite3_close_v2(IntPtr db) { }

	// RVA: 0x21FACF0 Offset: 0x21F92F0 VA: 0x1821FACF0
	internal static extern int sqlite3_create_function(IntPtr db, byte[] strName, int nArgs, int nType, IntPtr pvUser, SQLiteCallback func, SQLiteCallback fstep, SQLiteFinalCallback ffinal) { }

	// RVA: 0x21FAF30 Offset: 0x21F9530 VA: 0x1821FAF30
	internal static extern int sqlite3_finalize(IntPtr stmt) { }

	// RVA: 0x21FB380 Offset: 0x21F9980 VA: 0x1821FB380
	internal static extern int sqlite3_open_v2(byte[] utf8Filename, out IntPtr db, int flags, IntPtr vfs) { }

	// RVA: 0x21FB2E0 Offset: 0x21F98E0 VA: 0x1821FB2E0
	internal static extern int sqlite3_open(byte[] utf8Filename, out IntPtr db) { }

	// RVA: 0x21FB240 Offset: 0x21F9840 VA: 0x1821FB240
	internal static extern int sqlite3_open16(string fileName, out IntPtr db) { }

	// RVA: 0x21FB4F0 Offset: 0x21F9AF0 VA: 0x1821FB4F0
	internal static extern int sqlite3_reset(IntPtr stmt) { }

	// RVA: 0x21F9D50 Offset: 0x21F8350 VA: 0x1821F9D50
	internal static extern IntPtr sqlite3_bind_parameter_name(IntPtr stmt, int index) { }

	// RVA: 0x21FA3A0 Offset: 0x21F89A0 VA: 0x1821FA3A0
	internal static extern IntPtr sqlite3_column_database_name(IntPtr stmt, int index) { }

	// RVA: 0x21FA310 Offset: 0x21F8910 VA: 0x1821FA310
	internal static extern IntPtr sqlite3_column_database_name16(IntPtr stmt, int index) { }

	// RVA: 0x21FA430 Offset: 0x21F8A30 VA: 0x1821FA430
	internal static extern IntPtr sqlite3_column_decltype(IntPtr stmt, int index) { }

	// RVA: 0x21FA700 Offset: 0x21F8D00 VA: 0x1821FA700
	internal static extern IntPtr sqlite3_column_name(IntPtr stmt, int index) { }

	// RVA: 0x21FA670 Offset: 0x21F8C70 VA: 0x1821FA670
	internal static extern IntPtr sqlite3_column_name16(IntPtr stmt, int index) { }

	// RVA: 0x21FA820 Offset: 0x21F8E20 VA: 0x1821FA820
	internal static extern IntPtr sqlite3_column_origin_name(IntPtr stmt, int index) { }

	// RVA: 0x21FA790 Offset: 0x21F8D90 VA: 0x1821FA790
	internal static extern IntPtr sqlite3_column_origin_name16(IntPtr stmt, int index) { }

	// RVA: 0x21FA940 Offset: 0x21F8F40 VA: 0x1821FA940
	internal static extern IntPtr sqlite3_column_table_name(IntPtr stmt, int index) { }

	// RVA: 0x21FA8B0 Offset: 0x21F8EB0 VA: 0x1821FA8B0
	internal static extern IntPtr sqlite3_column_table_name16(IntPtr stmt, int index) { }

	// RVA: 0x21FAA60 Offset: 0x21F9060 VA: 0x1821FAA60
	internal static extern IntPtr sqlite3_column_text(IntPtr stmt, int index) { }

	// RVA: 0x21FA9D0 Offset: 0x21F8FD0 VA: 0x1821FA9D0
	internal static extern IntPtr sqlite3_column_text16(IntPtr stmt, int index) { }

	// RVA: 0x21FADF0 Offset: 0x21F93F0 VA: 0x1821FADF0
	internal static extern IntPtr sqlite3_errmsg(IntPtr db) { }

	// RVA: 0x21FB430 Offset: 0x21F9A30 VA: 0x1821FB430
	internal static extern int sqlite3_prepare(IntPtr db, IntPtr pSql, int nBytes, out IntPtr stmt, out IntPtr ptrRemain) { }

	// RVA: 0x21FBB80 Offset: 0x21FA180 VA: 0x1821FBB80
	internal static extern int sqlite3_table_column_metadata(IntPtr db, byte[] dbName, byte[] tblName, byte[] colName, out IntPtr ptrDataType, out IntPtr ptrCollSeq, out int notNull, out int primaryKey, out int autoInc) { }

	// RVA: 0x21FBFB0 Offset: 0x21FA5B0 VA: 0x1821FBFB0
	internal static extern IntPtr sqlite3_value_text(IntPtr p) { }

	// RVA: 0x21FBF30 Offset: 0x21FA530 VA: 0x1821FBF30
	internal static extern IntPtr sqlite3_value_text16(IntPtr p) { }

	// RVA: 0x21FB0D0 Offset: 0x21F96D0 VA: 0x1821FB0D0
	internal static extern IntPtr sqlite3_libversion() { }

	// RVA: 0x21F9FF0 Offset: 0x21F85F0 VA: 0x1821F9FF0
	internal static extern int sqlite3_changes(IntPtr db) { }

	// RVA: 0x21F9F60 Offset: 0x21F8560 VA: 0x1821F9F60
	internal static extern int sqlite3_busy_timeout(IntPtr db, int ms) { }

	// RVA: 0x21F99A0 Offset: 0x21F7FA0 VA: 0x1821F99A0
	internal static extern int sqlite3_bind_blob(IntPtr stmt, int index, byte[] value, int nSize, IntPtr nTransient) { }

	// RVA: 0x21F9A60 Offset: 0x21F8060 VA: 0x1821F9A60
	internal static extern int sqlite3_bind_double(IntPtr stmt, int index, double value) { }

	// RVA: 0x21F9BA0 Offset: 0x21F81A0 VA: 0x1821F9BA0
	internal static extern int sqlite3_bind_int(IntPtr stmt, int index, int value) { }

	// RVA: 0x21F9B00 Offset: 0x21F8100 VA: 0x1821F9B00
	internal static extern int sqlite3_bind_int64(IntPtr stmt, int index, long value) { }

	// RVA: 0x21F9C40 Offset: 0x21F8240 VA: 0x1821F9C40
	internal static extern int sqlite3_bind_null(IntPtr stmt, int index) { }

	// RVA: 0x21F9EA0 Offset: 0x21F84A0 VA: 0x1821F9EA0
	internal static extern int sqlite3_bind_text(IntPtr stmt, int index, byte[] value, int nlen, IntPtr pvReserved) { }

	// RVA: 0x21F9CD0 Offset: 0x21F82D0 VA: 0x1821F9CD0
	internal static extern int sqlite3_bind_parameter_count(IntPtr stmt) { }

	// RVA: 0x21FA290 Offset: 0x21F8890 VA: 0x1821FA290
	internal static extern int sqlite3_column_count(IntPtr stmt) { }

	// RVA: 0x21FBB00 Offset: 0x21FA100 VA: 0x1821FBB00
	internal static extern int sqlite3_step(IntPtr stmt) { }

	// RVA: 0x21FA4C0 Offset: 0x21F8AC0 VA: 0x1821FA4C0
	internal static extern double sqlite3_column_double(IntPtr stmt, int index) { }

	// RVA: 0x21FA5E0 Offset: 0x21F8BE0 VA: 0x1821FA5E0
	internal static extern int sqlite3_column_int(IntPtr stmt, int index) { }

	// RVA: 0x21FA550 Offset: 0x21F8B50 VA: 0x1821FA550
	internal static extern long sqlite3_column_int64(IntPtr stmt, int index) { }

	// RVA: 0x21FA170 Offset: 0x21F8770 VA: 0x1821FA170
	internal static extern IntPtr sqlite3_column_blob(IntPtr stmt, int index) { }

	// RVA: 0x21FA200 Offset: 0x21F8800 VA: 0x1821FA200
	internal static extern int sqlite3_column_bytes(IntPtr stmt, int index) { }

	// RVA: 0x21FAAF0 Offset: 0x21F90F0 VA: 0x1821FAAF0
	internal static extern TypeAffinity sqlite3_column_type(IntPtr stmt, int index) { }

	// RVA: 0x21FAC20 Offset: 0x21F9220 VA: 0x1821FAC20
	internal static extern int sqlite3_create_collation(IntPtr db, byte[] strName, int nType, IntPtr pvUser, SQLiteCollation func) { }

	// RVA: 0x21FBD30 Offset: 0x21FA330 VA: 0x1821FBD30
	internal static extern IntPtr sqlite3_value_blob(IntPtr p) { }

	// RVA: 0x21FBDB0 Offset: 0x21FA3B0 VA: 0x1821FBDB0
	internal static extern int sqlite3_value_bytes(IntPtr p) { }

	// RVA: 0x21FBE30 Offset: 0x21FA430 VA: 0x1821FBE30
	internal static extern double sqlite3_value_double(IntPtr p) { }

	// RVA: 0x21FBEB0 Offset: 0x21FA4B0 VA: 0x1821FBEB0
	internal static extern long sqlite3_value_int64(IntPtr p) { }

	// RVA: 0x21FC030 Offset: 0x21FA630 VA: 0x1821FC030
	internal static extern TypeAffinity sqlite3_value_type(IntPtr p) { }

	// RVA: 0x21FB570 Offset: 0x21F9B70 VA: 0x1821FB570
	internal static extern void sqlite3_result_blob(IntPtr context, byte[] value, int nSize, IntPtr pvReserved) { }

	// RVA: 0x21FB620 Offset: 0x21F9C20 VA: 0x1821FB620
	internal static extern void sqlite3_result_double(IntPtr context, double value) { }

	// RVA: 0x21FB750 Offset: 0x21F9D50 VA: 0x1821FB750
	internal static extern void sqlite3_result_error(IntPtr context, byte[] strErr, int nLen) { }

	// RVA: 0x21FB7F0 Offset: 0x21F9DF0 VA: 0x1821FB7F0
	internal static extern void sqlite3_result_int64(IntPtr context, long value) { }

	// RVA: 0x21FB880 Offset: 0x21F9E80 VA: 0x1821FB880
	internal static extern void sqlite3_result_null(IntPtr context) { }

	// RVA: 0x21FB9B0 Offset: 0x21F9FB0 VA: 0x1821FB9B0
	internal static extern void sqlite3_result_text(IntPtr context, byte[] value, int nLen, IntPtr pvReserved) { }

	// RVA: 0x21F9910 Offset: 0x21F7F10 VA: 0x1821F9910
	internal static extern IntPtr sqlite3_aggregate_context(IntPtr context, int nBytes) { }

	// RVA: 0x21F9DE0 Offset: 0x21F83E0 VA: 0x1821F9DE0
	internal static extern int sqlite3_bind_text16(IntPtr stmt, int index, string value, int nlen, IntPtr pvReserved) { }

	// RVA: 0x21FB6B0 Offset: 0x21F9CB0 VA: 0x1821FB6B0
	internal static extern void sqlite3_result_error16(IntPtr context, string strName, int nLen) { }

	// RVA: 0x21FB900 Offset: 0x21F9F00 VA: 0x1821FB900
	internal static extern void sqlite3_result_text16(IntPtr context, string strName, int nLen, IntPtr pvReserved) { }

	// RVA: 0x21FB030 Offset: 0x21F9630 VA: 0x1821FB030
	internal static extern int sqlite3_key(IntPtr db, byte[] key, int keylen) { }

	// RVA: 0x21FBC90 Offset: 0x21FA290 VA: 0x1821FBC90
	internal static extern IntPtr sqlite3_update_hook(IntPtr db, SQLiteUpdateCallback func, IntPtr pvUser) { }

	// RVA: 0x21FAB80 Offset: 0x21F9180 VA: 0x1821FAB80
	internal static extern IntPtr sqlite3_commit_hook(IntPtr db, SQLiteCommitCallback func, IntPtr pvUser) { }

	// RVA: 0x21FBA60 Offset: 0x21FA060 VA: 0x1821FBA60
	internal static extern IntPtr sqlite3_rollback_hook(IntPtr db, SQLiteRollbackCallback func, IntPtr pvUser) { }

	// RVA: 0x21FB1B0 Offset: 0x21F97B0 VA: 0x1821FB1B0
	internal static extern IntPtr sqlite3_next_stmt(IntPtr db, IntPtr stmt) { }

	// RVA: 0x21FAE70 Offset: 0x21F9470 VA: 0x1821FAE70
	internal static extern int sqlite3_exec(IntPtr db, byte[] strSql, IntPtr pvCallback, IntPtr pvParam, out IntPtr errMsg) { }

	// RVA: 0x21FAFB0 Offset: 0x21F95B0 VA: 0x1821FAFB0
	internal static extern int sqlite3_free(IntPtr ptr) { }

	// RVA: 0x21FB140 Offset: 0x21F9740 VA: 0x1821FB140
	internal static extern int sqlite3_libversion_number() { }

}

