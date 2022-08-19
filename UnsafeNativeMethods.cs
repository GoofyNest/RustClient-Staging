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

	// RVA: 0x21F98D0 Offset: 0x21F7ED0 VA: 0x1821F98D0
	private static void .cctor() { }

	// RVA: 0x21FA230 Offset: 0x21F8830 VA: 0x1821FA230
	internal static extern int sqlite3_close(IntPtr db) { }

	// RVA: 0x21FA2B0 Offset: 0x21F88B0 VA: 0x1821FA2B0
	internal static extern int sqlite3_close_v2(IntPtr db) { }

	// RVA: 0x21FAEB0 Offset: 0x21F94B0 VA: 0x1821FAEB0
	internal static extern int sqlite3_create_function(IntPtr db, byte[] strName, int nArgs, int nType, IntPtr pvUser, SQLiteCallback func, SQLiteCallback fstep, SQLiteFinalCallback ffinal) { }

	// RVA: 0x21FB0F0 Offset: 0x21F96F0 VA: 0x1821FB0F0
	internal static extern int sqlite3_finalize(IntPtr stmt) { }

	// RVA: 0x21FB540 Offset: 0x21F9B40 VA: 0x1821FB540
	internal static extern int sqlite3_open_v2(byte[] utf8Filename, out IntPtr db, int flags, IntPtr vfs) { }

	// RVA: 0x21FB4A0 Offset: 0x21F9AA0 VA: 0x1821FB4A0
	internal static extern int sqlite3_open(byte[] utf8Filename, out IntPtr db) { }

	// RVA: 0x21FB400 Offset: 0x21F9A00 VA: 0x1821FB400
	internal static extern int sqlite3_open16(string fileName, out IntPtr db) { }

	// RVA: 0x21FB6B0 Offset: 0x21F9CB0 VA: 0x1821FB6B0
	internal static extern int sqlite3_reset(IntPtr stmt) { }

	// RVA: 0x21F9F10 Offset: 0x21F8510 VA: 0x1821F9F10
	internal static extern IntPtr sqlite3_bind_parameter_name(IntPtr stmt, int index) { }

	// RVA: 0x21FA560 Offset: 0x21F8B60 VA: 0x1821FA560
	internal static extern IntPtr sqlite3_column_database_name(IntPtr stmt, int index) { }

	// RVA: 0x21FA4D0 Offset: 0x21F8AD0 VA: 0x1821FA4D0
	internal static extern IntPtr sqlite3_column_database_name16(IntPtr stmt, int index) { }

	// RVA: 0x21FA5F0 Offset: 0x21F8BF0 VA: 0x1821FA5F0
	internal static extern IntPtr sqlite3_column_decltype(IntPtr stmt, int index) { }

	// RVA: 0x21FA8C0 Offset: 0x21F8EC0 VA: 0x1821FA8C0
	internal static extern IntPtr sqlite3_column_name(IntPtr stmt, int index) { }

	// RVA: 0x21FA830 Offset: 0x21F8E30 VA: 0x1821FA830
	internal static extern IntPtr sqlite3_column_name16(IntPtr stmt, int index) { }

	// RVA: 0x21FA9E0 Offset: 0x21F8FE0 VA: 0x1821FA9E0
	internal static extern IntPtr sqlite3_column_origin_name(IntPtr stmt, int index) { }

	// RVA: 0x21FA950 Offset: 0x21F8F50 VA: 0x1821FA950
	internal static extern IntPtr sqlite3_column_origin_name16(IntPtr stmt, int index) { }

	// RVA: 0x21FAB00 Offset: 0x21F9100 VA: 0x1821FAB00
	internal static extern IntPtr sqlite3_column_table_name(IntPtr stmt, int index) { }

	// RVA: 0x21FAA70 Offset: 0x21F9070 VA: 0x1821FAA70
	internal static extern IntPtr sqlite3_column_table_name16(IntPtr stmt, int index) { }

	// RVA: 0x21FAC20 Offset: 0x21F9220 VA: 0x1821FAC20
	internal static extern IntPtr sqlite3_column_text(IntPtr stmt, int index) { }

	// RVA: 0x21FAB90 Offset: 0x21F9190 VA: 0x1821FAB90
	internal static extern IntPtr sqlite3_column_text16(IntPtr stmt, int index) { }

	// RVA: 0x21FAFB0 Offset: 0x21F95B0 VA: 0x1821FAFB0
	internal static extern IntPtr sqlite3_errmsg(IntPtr db) { }

	// RVA: 0x21FB5F0 Offset: 0x21F9BF0 VA: 0x1821FB5F0
	internal static extern int sqlite3_prepare(IntPtr db, IntPtr pSql, int nBytes, out IntPtr stmt, out IntPtr ptrRemain) { }

	// RVA: 0x21FBD40 Offset: 0x21FA340 VA: 0x1821FBD40
	internal static extern int sqlite3_table_column_metadata(IntPtr db, byte[] dbName, byte[] tblName, byte[] colName, out IntPtr ptrDataType, out IntPtr ptrCollSeq, out int notNull, out int primaryKey, out int autoInc) { }

	// RVA: 0x21FC170 Offset: 0x21FA770 VA: 0x1821FC170
	internal static extern IntPtr sqlite3_value_text(IntPtr p) { }

	// RVA: 0x21FC0F0 Offset: 0x21FA6F0 VA: 0x1821FC0F0
	internal static extern IntPtr sqlite3_value_text16(IntPtr p) { }

	// RVA: 0x21FB290 Offset: 0x21F9890 VA: 0x1821FB290
	internal static extern IntPtr sqlite3_libversion() { }

	// RVA: 0x21FA1B0 Offset: 0x21F87B0 VA: 0x1821FA1B0
	internal static extern int sqlite3_changes(IntPtr db) { }

	// RVA: 0x21FA120 Offset: 0x21F8720 VA: 0x1821FA120
	internal static extern int sqlite3_busy_timeout(IntPtr db, int ms) { }

	// RVA: 0x21F9B60 Offset: 0x21F8160 VA: 0x1821F9B60
	internal static extern int sqlite3_bind_blob(IntPtr stmt, int index, byte[] value, int nSize, IntPtr nTransient) { }

	// RVA: 0x21F9C20 Offset: 0x21F8220 VA: 0x1821F9C20
	internal static extern int sqlite3_bind_double(IntPtr stmt, int index, double value) { }

	// RVA: 0x21F9D60 Offset: 0x21F8360 VA: 0x1821F9D60
	internal static extern int sqlite3_bind_int(IntPtr stmt, int index, int value) { }

	// RVA: 0x21F9CC0 Offset: 0x21F82C0 VA: 0x1821F9CC0
	internal static extern int sqlite3_bind_int64(IntPtr stmt, int index, long value) { }

	// RVA: 0x21F9E00 Offset: 0x21F8400 VA: 0x1821F9E00
	internal static extern int sqlite3_bind_null(IntPtr stmt, int index) { }

	// RVA: 0x21FA060 Offset: 0x21F8660 VA: 0x1821FA060
	internal static extern int sqlite3_bind_text(IntPtr stmt, int index, byte[] value, int nlen, IntPtr pvReserved) { }

	// RVA: 0x21F9E90 Offset: 0x21F8490 VA: 0x1821F9E90
	internal static extern int sqlite3_bind_parameter_count(IntPtr stmt) { }

	// RVA: 0x21FA450 Offset: 0x21F8A50 VA: 0x1821FA450
	internal static extern int sqlite3_column_count(IntPtr stmt) { }

	// RVA: 0x21FBCC0 Offset: 0x21FA2C0 VA: 0x1821FBCC0
	internal static extern int sqlite3_step(IntPtr stmt) { }

	// RVA: 0x21FA680 Offset: 0x21F8C80 VA: 0x1821FA680
	internal static extern double sqlite3_column_double(IntPtr stmt, int index) { }

	// RVA: 0x21FA7A0 Offset: 0x21F8DA0 VA: 0x1821FA7A0
	internal static extern int sqlite3_column_int(IntPtr stmt, int index) { }

	// RVA: 0x21FA710 Offset: 0x21F8D10 VA: 0x1821FA710
	internal static extern long sqlite3_column_int64(IntPtr stmt, int index) { }

	// RVA: 0x21FA330 Offset: 0x21F8930 VA: 0x1821FA330
	internal static extern IntPtr sqlite3_column_blob(IntPtr stmt, int index) { }

	// RVA: 0x21FA3C0 Offset: 0x21F89C0 VA: 0x1821FA3C0
	internal static extern int sqlite3_column_bytes(IntPtr stmt, int index) { }

	// RVA: 0x21FACB0 Offset: 0x21F92B0 VA: 0x1821FACB0
	internal static extern TypeAffinity sqlite3_column_type(IntPtr stmt, int index) { }

	// RVA: 0x21FADE0 Offset: 0x21F93E0 VA: 0x1821FADE0
	internal static extern int sqlite3_create_collation(IntPtr db, byte[] strName, int nType, IntPtr pvUser, SQLiteCollation func) { }

	// RVA: 0x21FBEF0 Offset: 0x21FA4F0 VA: 0x1821FBEF0
	internal static extern IntPtr sqlite3_value_blob(IntPtr p) { }

	// RVA: 0x21FBF70 Offset: 0x21FA570 VA: 0x1821FBF70
	internal static extern int sqlite3_value_bytes(IntPtr p) { }

	// RVA: 0x21FBFF0 Offset: 0x21FA5F0 VA: 0x1821FBFF0
	internal static extern double sqlite3_value_double(IntPtr p) { }

	// RVA: 0x21FC070 Offset: 0x21FA670 VA: 0x1821FC070
	internal static extern long sqlite3_value_int64(IntPtr p) { }

	// RVA: 0x21FC1F0 Offset: 0x21FA7F0 VA: 0x1821FC1F0
	internal static extern TypeAffinity sqlite3_value_type(IntPtr p) { }

	// RVA: 0x21FB730 Offset: 0x21F9D30 VA: 0x1821FB730
	internal static extern void sqlite3_result_blob(IntPtr context, byte[] value, int nSize, IntPtr pvReserved) { }

	// RVA: 0x21FB7E0 Offset: 0x21F9DE0 VA: 0x1821FB7E0
	internal static extern void sqlite3_result_double(IntPtr context, double value) { }

	// RVA: 0x21FB910 Offset: 0x21F9F10 VA: 0x1821FB910
	internal static extern void sqlite3_result_error(IntPtr context, byte[] strErr, int nLen) { }

	// RVA: 0x21FB9B0 Offset: 0x21F9FB0 VA: 0x1821FB9B0
	internal static extern void sqlite3_result_int64(IntPtr context, long value) { }

	// RVA: 0x21FBA40 Offset: 0x21FA040 VA: 0x1821FBA40
	internal static extern void sqlite3_result_null(IntPtr context) { }

	// RVA: 0x21FBB70 Offset: 0x21FA170 VA: 0x1821FBB70
	internal static extern void sqlite3_result_text(IntPtr context, byte[] value, int nLen, IntPtr pvReserved) { }

	// RVA: 0x21F9AD0 Offset: 0x21F80D0 VA: 0x1821F9AD0
	internal static extern IntPtr sqlite3_aggregate_context(IntPtr context, int nBytes) { }

	// RVA: 0x21F9FA0 Offset: 0x21F85A0 VA: 0x1821F9FA0
	internal static extern int sqlite3_bind_text16(IntPtr stmt, int index, string value, int nlen, IntPtr pvReserved) { }

	// RVA: 0x21FB870 Offset: 0x21F9E70 VA: 0x1821FB870
	internal static extern void sqlite3_result_error16(IntPtr context, string strName, int nLen) { }

	// RVA: 0x21FBAC0 Offset: 0x21FA0C0 VA: 0x1821FBAC0
	internal static extern void sqlite3_result_text16(IntPtr context, string strName, int nLen, IntPtr pvReserved) { }

	// RVA: 0x21FB1F0 Offset: 0x21F97F0 VA: 0x1821FB1F0
	internal static extern int sqlite3_key(IntPtr db, byte[] key, int keylen) { }

	// RVA: 0x21FBE50 Offset: 0x21FA450 VA: 0x1821FBE50
	internal static extern IntPtr sqlite3_update_hook(IntPtr db, SQLiteUpdateCallback func, IntPtr pvUser) { }

	// RVA: 0x21FAD40 Offset: 0x21F9340 VA: 0x1821FAD40
	internal static extern IntPtr sqlite3_commit_hook(IntPtr db, SQLiteCommitCallback func, IntPtr pvUser) { }

	// RVA: 0x21FBC20 Offset: 0x21FA220 VA: 0x1821FBC20
	internal static extern IntPtr sqlite3_rollback_hook(IntPtr db, SQLiteRollbackCallback func, IntPtr pvUser) { }

	// RVA: 0x21FB370 Offset: 0x21F9970 VA: 0x1821FB370
	internal static extern IntPtr sqlite3_next_stmt(IntPtr db, IntPtr stmt) { }

	// RVA: 0x21FB030 Offset: 0x21F9630 VA: 0x1821FB030
	internal static extern int sqlite3_exec(IntPtr db, byte[] strSql, IntPtr pvCallback, IntPtr pvParam, out IntPtr errMsg) { }

	// RVA: 0x21FB170 Offset: 0x21F9770 VA: 0x1821FB170
	internal static extern int sqlite3_free(IntPtr ptr) { }

	// RVA: 0x21FB300 Offset: 0x21F9900 VA: 0x1821FB300
	internal static extern int sqlite3_libversion_number() { }

}

