internal static class UnsafeNativeMethods.ManifestEtw // TypeDefIndex: 91
{
// Namespace: 
internal static class UnsafeNativeMethods.ManifestEtw // TypeDefIndex: 91
	// Methods

	// RVA: 0x16336D0 Offset: 0x1631CD0 VA: 0x1816336D0
	internal static extern uint EventRegister(in Guid providerId, [In] UnsafeNativeMethods.ManifestEtw.EtwEnableCallback enableCallback, [In] void* callbackContext, ref long registrationHandle) { }

	// RVA: 0x1633820 Offset: 0x1631E20 VA: 0x181633820
	internal static extern uint EventUnregister([In] long registrationHandle) { }

	// RVA: 0x16338A0 Offset: 0x1631EA0 VA: 0x1816338A0
	internal static int EventWriteTransferWrapper(long registrationHandle, ref EventDescriptor eventDescriptor, Guid* activityId, Guid* relatedActivityId, int userDataCount, EventProvider.EventData* userData) { }

	// RVA: 0x16339A0 Offset: 0x1631FA0 VA: 0x1816339A0
	private static extern int EventWriteTransfer([In] long registrationHandle, in EventDescriptor eventDescriptor, [In] Guid* activityId, [In] Guid* relatedActivityId, [In] int userDataCount, [In] EventProvider.EventData* userData) { }

	// RVA: 0x1633640 Offset: 0x1631C40 VA: 0x181633640
	internal static extern int EventActivityIdControl([In] UnsafeNativeMethods.ManifestEtw.ActivityControl ControlCode, ref Guid ActivityId) { }

	// RVA: 0x1633780 Offset: 0x1631D80 VA: 0x181633780
	internal static extern int EventSetInformation([In] long registrationHandle, [In] UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS informationClass, [In] void* eventInformation, [In] int informationLength) { }

	// RVA: 0x1633580 Offset: 0x1631B80 VA: 0x181633580
	internal static extern int EnumerateTraceGuidsEx(UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceQueryInfoClass, void* InBuffer, int InBufferSize, void* OutBuffer, int OutBufferSize, ref int ReturnLength) { }

}

internal sealed class UnsafeNativeMethods.ManifestEtw.EtwEnableCallback : MulticastDelegate // TypeDefIndex: 92
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x162A120 Offset: 0x1628720 VA: 0x18162A120 Slot: 12
	public virtual void Invoke(in Guid sourceId, [In] int isEnabled, [In] byte level, [In] long matchAnyKeywords, [In] long matchAllKeywords, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext) { }

	// RVA: 0x162A000 Offset: 0x1628600 VA: 0x18162A000 Slot: 13
	public virtual IAsyncResult BeginInvoke(in Guid sourceId, [In] int isEnabled, [In] byte level, [In] long matchAnyKeywords, [In] long matchAllKeywords, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext, AsyncCallback callback, object object) { }

	// RVA: 0x162A100 Offset: 0x1628700 VA: 0x18162A100 Slot: 14
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

	// RVA: 0x21FA1F0 Offset: 0x21F87F0 VA: 0x1821FA1F0
	private static void .cctor() { }

	// RVA: 0x21FAB50 Offset: 0x21F9150 VA: 0x1821FAB50
	internal static extern int sqlite3_close(IntPtr db) { }

	// RVA: 0x21FABD0 Offset: 0x21F91D0 VA: 0x1821FABD0
	internal static extern int sqlite3_close_v2(IntPtr db) { }

	// RVA: 0x21FB7D0 Offset: 0x21F9DD0 VA: 0x1821FB7D0
	internal static extern int sqlite3_create_function(IntPtr db, byte[] strName, int nArgs, int nType, IntPtr pvUser, SQLiteCallback func, SQLiteCallback fstep, SQLiteFinalCallback ffinal) { }

	// RVA: 0x21FBA10 Offset: 0x21FA010 VA: 0x1821FBA10
	internal static extern int sqlite3_finalize(IntPtr stmt) { }

	// RVA: 0x21FBE60 Offset: 0x21FA460 VA: 0x1821FBE60
	internal static extern int sqlite3_open_v2(byte[] utf8Filename, out IntPtr db, int flags, IntPtr vfs) { }

	// RVA: 0x21FBDC0 Offset: 0x21FA3C0 VA: 0x1821FBDC0
	internal static extern int sqlite3_open(byte[] utf8Filename, out IntPtr db) { }

	// RVA: 0x21FBD20 Offset: 0x21FA320 VA: 0x1821FBD20
	internal static extern int sqlite3_open16(string fileName, out IntPtr db) { }

	// RVA: 0x21FBFD0 Offset: 0x21FA5D0 VA: 0x1821FBFD0
	internal static extern int sqlite3_reset(IntPtr stmt) { }

	// RVA: 0x21FA830 Offset: 0x21F8E30 VA: 0x1821FA830
	internal static extern IntPtr sqlite3_bind_parameter_name(IntPtr stmt, int index) { }

	// RVA: 0x21FAE80 Offset: 0x21F9480 VA: 0x1821FAE80
	internal static extern IntPtr sqlite3_column_database_name(IntPtr stmt, int index) { }

	// RVA: 0x21FADF0 Offset: 0x21F93F0 VA: 0x1821FADF0
	internal static extern IntPtr sqlite3_column_database_name16(IntPtr stmt, int index) { }

	// RVA: 0x21FAF10 Offset: 0x21F9510 VA: 0x1821FAF10
	internal static extern IntPtr sqlite3_column_decltype(IntPtr stmt, int index) { }

	// RVA: 0x21FB1E0 Offset: 0x21F97E0 VA: 0x1821FB1E0
	internal static extern IntPtr sqlite3_column_name(IntPtr stmt, int index) { }

	// RVA: 0x21FB150 Offset: 0x21F9750 VA: 0x1821FB150
	internal static extern IntPtr sqlite3_column_name16(IntPtr stmt, int index) { }

	// RVA: 0x21FB300 Offset: 0x21F9900 VA: 0x1821FB300
	internal static extern IntPtr sqlite3_column_origin_name(IntPtr stmt, int index) { }

	// RVA: 0x21FB270 Offset: 0x21F9870 VA: 0x1821FB270
	internal static extern IntPtr sqlite3_column_origin_name16(IntPtr stmt, int index) { }

	// RVA: 0x21FB420 Offset: 0x21F9A20 VA: 0x1821FB420
	internal static extern IntPtr sqlite3_column_table_name(IntPtr stmt, int index) { }

	// RVA: 0x21FB390 Offset: 0x21F9990 VA: 0x1821FB390
	internal static extern IntPtr sqlite3_column_table_name16(IntPtr stmt, int index) { }

	// RVA: 0x21FB540 Offset: 0x21F9B40 VA: 0x1821FB540
	internal static extern IntPtr sqlite3_column_text(IntPtr stmt, int index) { }

	// RVA: 0x21FB4B0 Offset: 0x21F9AB0 VA: 0x1821FB4B0
	internal static extern IntPtr sqlite3_column_text16(IntPtr stmt, int index) { }

	// RVA: 0x21FB8D0 Offset: 0x21F9ED0 VA: 0x1821FB8D0
	internal static extern IntPtr sqlite3_errmsg(IntPtr db) { }

	// RVA: 0x21FBF10 Offset: 0x21FA510 VA: 0x1821FBF10
	internal static extern int sqlite3_prepare(IntPtr db, IntPtr pSql, int nBytes, out IntPtr stmt, out IntPtr ptrRemain) { }

	// RVA: 0x21FC660 Offset: 0x21FAC60 VA: 0x1821FC660
	internal static extern int sqlite3_table_column_metadata(IntPtr db, byte[] dbName, byte[] tblName, byte[] colName, out IntPtr ptrDataType, out IntPtr ptrCollSeq, out int notNull, out int primaryKey, out int autoInc) { }

	// RVA: 0x21FCA90 Offset: 0x21FB090 VA: 0x1821FCA90
	internal static extern IntPtr sqlite3_value_text(IntPtr p) { }

	// RVA: 0x21FCA10 Offset: 0x21FB010 VA: 0x1821FCA10
	internal static extern IntPtr sqlite3_value_text16(IntPtr p) { }

	// RVA: 0x21FBBB0 Offset: 0x21FA1B0 VA: 0x1821FBBB0
	internal static extern IntPtr sqlite3_libversion() { }

	// RVA: 0x21FAAD0 Offset: 0x21F90D0 VA: 0x1821FAAD0
	internal static extern int sqlite3_changes(IntPtr db) { }

	// RVA: 0x21FAA40 Offset: 0x21F9040 VA: 0x1821FAA40
	internal static extern int sqlite3_busy_timeout(IntPtr db, int ms) { }

	// RVA: 0x21FA480 Offset: 0x21F8A80 VA: 0x1821FA480
	internal static extern int sqlite3_bind_blob(IntPtr stmt, int index, byte[] value, int nSize, IntPtr nTransient) { }

	// RVA: 0x21FA540 Offset: 0x21F8B40 VA: 0x1821FA540
	internal static extern int sqlite3_bind_double(IntPtr stmt, int index, double value) { }

	// RVA: 0x21FA680 Offset: 0x21F8C80 VA: 0x1821FA680
	internal static extern int sqlite3_bind_int(IntPtr stmt, int index, int value) { }

	// RVA: 0x21FA5E0 Offset: 0x21F8BE0 VA: 0x1821FA5E0
	internal static extern int sqlite3_bind_int64(IntPtr stmt, int index, long value) { }

	// RVA: 0x21FA720 Offset: 0x21F8D20 VA: 0x1821FA720
	internal static extern int sqlite3_bind_null(IntPtr stmt, int index) { }

	// RVA: 0x21FA980 Offset: 0x21F8F80 VA: 0x1821FA980
	internal static extern int sqlite3_bind_text(IntPtr stmt, int index, byte[] value, int nlen, IntPtr pvReserved) { }

	// RVA: 0x21FA7B0 Offset: 0x21F8DB0 VA: 0x1821FA7B0
	internal static extern int sqlite3_bind_parameter_count(IntPtr stmt) { }

	// RVA: 0x21FAD70 Offset: 0x21F9370 VA: 0x1821FAD70
	internal static extern int sqlite3_column_count(IntPtr stmt) { }

	// RVA: 0x21FC5E0 Offset: 0x21FABE0 VA: 0x1821FC5E0
	internal static extern int sqlite3_step(IntPtr stmt) { }

	// RVA: 0x21FAFA0 Offset: 0x21F95A0 VA: 0x1821FAFA0
	internal static extern double sqlite3_column_double(IntPtr stmt, int index) { }

	// RVA: 0x21FB0C0 Offset: 0x21F96C0 VA: 0x1821FB0C0
	internal static extern int sqlite3_column_int(IntPtr stmt, int index) { }

	// RVA: 0x21FB030 Offset: 0x21F9630 VA: 0x1821FB030
	internal static extern long sqlite3_column_int64(IntPtr stmt, int index) { }

	// RVA: 0x21FAC50 Offset: 0x21F9250 VA: 0x1821FAC50
	internal static extern IntPtr sqlite3_column_blob(IntPtr stmt, int index) { }

	// RVA: 0x21FACE0 Offset: 0x21F92E0 VA: 0x1821FACE0
	internal static extern int sqlite3_column_bytes(IntPtr stmt, int index) { }

	// RVA: 0x21FB5D0 Offset: 0x21F9BD0 VA: 0x1821FB5D0
	internal static extern TypeAffinity sqlite3_column_type(IntPtr stmt, int index) { }

	// RVA: 0x21FB700 Offset: 0x21F9D00 VA: 0x1821FB700
	internal static extern int sqlite3_create_collation(IntPtr db, byte[] strName, int nType, IntPtr pvUser, SQLiteCollation func) { }

	// RVA: 0x21FC810 Offset: 0x21FAE10 VA: 0x1821FC810
	internal static extern IntPtr sqlite3_value_blob(IntPtr p) { }

	// RVA: 0x21FC890 Offset: 0x21FAE90 VA: 0x1821FC890
	internal static extern int sqlite3_value_bytes(IntPtr p) { }

	// RVA: 0x21FC910 Offset: 0x21FAF10 VA: 0x1821FC910
	internal static extern double sqlite3_value_double(IntPtr p) { }

	// RVA: 0x21FC990 Offset: 0x21FAF90 VA: 0x1821FC990
	internal static extern long sqlite3_value_int64(IntPtr p) { }

	// RVA: 0x21FCB10 Offset: 0x21FB110 VA: 0x1821FCB10
	internal static extern TypeAffinity sqlite3_value_type(IntPtr p) { }

	// RVA: 0x21FC050 Offset: 0x21FA650 VA: 0x1821FC050
	internal static extern void sqlite3_result_blob(IntPtr context, byte[] value, int nSize, IntPtr pvReserved) { }

	// RVA: 0x21FC100 Offset: 0x21FA700 VA: 0x1821FC100
	internal static extern void sqlite3_result_double(IntPtr context, double value) { }

	// RVA: 0x21FC230 Offset: 0x21FA830 VA: 0x1821FC230
	internal static extern void sqlite3_result_error(IntPtr context, byte[] strErr, int nLen) { }

	// RVA: 0x21FC2D0 Offset: 0x21FA8D0 VA: 0x1821FC2D0
	internal static extern void sqlite3_result_int64(IntPtr context, long value) { }

	// RVA: 0x21FC360 Offset: 0x21FA960 VA: 0x1821FC360
	internal static extern void sqlite3_result_null(IntPtr context) { }

	// RVA: 0x21FC490 Offset: 0x21FAA90 VA: 0x1821FC490
	internal static extern void sqlite3_result_text(IntPtr context, byte[] value, int nLen, IntPtr pvReserved) { }

	// RVA: 0x21FA3F0 Offset: 0x21F89F0 VA: 0x1821FA3F0
	internal static extern IntPtr sqlite3_aggregate_context(IntPtr context, int nBytes) { }

	// RVA: 0x21FA8C0 Offset: 0x21F8EC0 VA: 0x1821FA8C0
	internal static extern int sqlite3_bind_text16(IntPtr stmt, int index, string value, int nlen, IntPtr pvReserved) { }

	// RVA: 0x21FC190 Offset: 0x21FA790 VA: 0x1821FC190
	internal static extern void sqlite3_result_error16(IntPtr context, string strName, int nLen) { }

	// RVA: 0x21FC3E0 Offset: 0x21FA9E0 VA: 0x1821FC3E0
	internal static extern void sqlite3_result_text16(IntPtr context, string strName, int nLen, IntPtr pvReserved) { }

	// RVA: 0x21FBB10 Offset: 0x21FA110 VA: 0x1821FBB10
	internal static extern int sqlite3_key(IntPtr db, byte[] key, int keylen) { }

	// RVA: 0x21FC770 Offset: 0x21FAD70 VA: 0x1821FC770
	internal static extern IntPtr sqlite3_update_hook(IntPtr db, SQLiteUpdateCallback func, IntPtr pvUser) { }

	// RVA: 0x21FB660 Offset: 0x21F9C60 VA: 0x1821FB660
	internal static extern IntPtr sqlite3_commit_hook(IntPtr db, SQLiteCommitCallback func, IntPtr pvUser) { }

	// RVA: 0x21FC540 Offset: 0x21FAB40 VA: 0x1821FC540
	internal static extern IntPtr sqlite3_rollback_hook(IntPtr db, SQLiteRollbackCallback func, IntPtr pvUser) { }

	// RVA: 0x21FBC90 Offset: 0x21FA290 VA: 0x1821FBC90
	internal static extern IntPtr sqlite3_next_stmt(IntPtr db, IntPtr stmt) { }

	// RVA: 0x21FB950 Offset: 0x21F9F50 VA: 0x1821FB950
	internal static extern int sqlite3_exec(IntPtr db, byte[] strSql, IntPtr pvCallback, IntPtr pvParam, out IntPtr errMsg) { }

	// RVA: 0x21FBA90 Offset: 0x21FA090 VA: 0x1821FBA90
	internal static extern int sqlite3_free(IntPtr ptr) { }

	// RVA: 0x21FBC20 Offset: 0x21FA220 VA: 0x1821FBC20
	internal static extern int sqlite3_libversion_number() { }

}

