public sealed class SqliteConnection : DbConnection, ICloneable // TypeDefIndex: 4852
{
// Namespace: 
internal class <Module> // TypeDefIndex: 4851

// Namespace: Mono.Data.Sqlite
public sealed class SqliteConnection : DbConnection, ICloneable // TypeDefIndex: 4852
	// Fields
	private ConnectionState _connectionState; // 0x28
	private string _connectionString; // 0x30
	internal int _transactionLevel; // 0x38
	private IsolationLevel _defaultIsolation; // 0x3C
	internal SQLiteEnlistment _enlistment; // 0x40
	internal SQLiteBase _sql; // 0x48
	private string _dataSource; // 0x50
	private byte[] _password; // 0x58
	private int _defaultTimeout; // 0x60
	internal bool _binaryGuid; // 0x64
	internal long _version; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SQLiteUpdateEventHandler _updateHandler; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SQLiteCommitHandler _commitHandler; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventHandler _rollbackHandler; // 0x80
	private SQLiteUpdateCallback _updateCallback; // 0x88
	private SQLiteCommitCallback _commitCallback; // 0x90
	private SQLiteRollbackCallback _rollbackCallback; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private StateChangeEventHandler StateChange; // 0xA0

	// Properties
	[EditorAttribute] // RVA: 0xDD8C0 Offset: 0xDCCC0 VA: 0x1800DD8C0
	[RefreshPropertiesAttribute] // RVA: 0xDD8C0 Offset: 0xDCCC0 VA: 0x1800DD8C0
	[DefaultValueAttribute] // RVA: 0xDD8C0 Offset: 0xDCCC0 VA: 0x1800DD8C0
	public override string ConnectionString { get; set; }
	public int DefaultTimeout { get; }
	[BrowsableAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E9F0 Offset: 0x9DDF0 VA: 0x18009E9F0
	public override ConnectionState State { get; }

	// Methods

	// RVA: 0x141E560 Offset: 0x141CB60 VA: 0x18141E560
	public void .ctor() { }

	// RVA: 0x141E4C0 Offset: 0x141CAC0 VA: 0x18141E4C0
	public void .ctor(string connectionString) { }

	// RVA: 0x141E620 Offset: 0x141CC20 VA: 0x18141E620
	public void .ctor(SqliteConnection connection) { }

	// RVA: 0x1412890 Offset: 0x1410E90 VA: 0x181412890 Slot: 22
	public object Clone() { }

	// RVA: 0x1412C00 Offset: 0x1411200 VA: 0x181412C00 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1413C70 Offset: 0x1412270 VA: 0x181413C70
	internal void OnStateChange(ConnectionState newState) { }

	// RVA: 0x1412820 Offset: 0x1410E20 VA: 0x181412820
	public SqliteTransaction BeginTransaction() { }

	// RVA: 0x1412730 Offset: 0x1410D30 VA: 0x181412730 Slot: 15
	protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel) { }

	// RVA: 0x14128F0 Offset: 0x1410EF0 VA: 0x1814128F0 Slot: 16
	public override void Close() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 12
	public override string get_ConnectionString() { }

	// RVA: 0x141EB30 Offset: 0x141D130 VA: 0x18141EB30 Slot: 13
	public override void set_ConnectionString(string value) { }

	// RVA: 0x1412AE0 Offset: 0x14110E0 VA: 0x181412AE0
	public SqliteCommand CreateCommand() { }

	// RVA: 0x1412BF0 Offset: 0x14111F0 VA: 0x181412BF0 Slot: 17
	protected override DbCommand CreateDbCommand() { }

	// RVA: 0x14138E0 Offset: 0x1411EE0 VA: 0x1814138E0
	internal static void MapMonoKeyword(string[] arPiece, SortedList<string, string> ls) { }

	// RVA: 0x1413AD0 Offset: 0x14120D0 VA: 0x181413AD0
	internal static string MapMonoUriPath(string path) { }

	// RVA: 0x1413BA0 Offset: 0x14121A0 VA: 0x181413BA0
	internal static string MapUriPath(string path) { }

	// RVA: 0x14153E0 Offset: 0x14139E0 VA: 0x1814153E0
	internal static SortedList<string, string> ParseConnectionString(string connectionString) { }

	// RVA: 0x1412C60 Offset: 0x1411260 VA: 0x181412C60 Slot: 18
	public override void EnlistTransaction(Transaction transaction) { }

	// RVA: 0x1413050 Offset: 0x1411650 VA: 0x181413050
	internal static string FindKey(SortedList<string, string> items, string key, string defValue) { }

	// RVA: 0x1413D10 Offset: 0x1412310 VA: 0x181413D10 Slot: 21
	public override void Open() { }

	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	public int get_DefaultTimeout() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600 Slot: 14
	public override ConnectionState get_State() { }

	// RVA: 0x1412E10 Offset: 0x1411410 VA: 0x181412E10
	private string ExpandFileName(string sourceFile) { }

	// RVA: 0x1413880 Offset: 0x1411E80 VA: 0x181413880 Slot: 19
	public override DataTable GetSchema(string collectionName) { }

	// RVA: 0x14130D0 Offset: 0x14116D0 VA: 0x1814130D0 Slot: 20
	public override DataTable GetSchema(string collectionName, string[] restrictionValues) { }

	// RVA: 0x141B9B0 Offset: 0x1419FB0 VA: 0x18141B9B0
	private static DataTable Schema_ReservedWords() { }

	// RVA: 0x141B7A0 Offset: 0x1419DA0 VA: 0x18141B7A0
	private static DataTable Schema_MetaDataCollections() { }

	// RVA: 0x1416D90 Offset: 0x1415390 VA: 0x181416D90
	private DataTable Schema_DataSourceInformation() { }

	// RVA: 0x1415A70 Offset: 0x1414070 VA: 0x181415A70
	private DataTable Schema_Columns(string strCatalog, string strTable, string strColumn) { }

	// RVA: 0x141A080 Offset: 0x1418680 VA: 0x18141A080
	private DataTable Schema_Indexes(string strCatalog, string strTable, string strIndex) { }

	// RVA: 0x141C340 Offset: 0x141A940 VA: 0x18141C340
	private DataTable Schema_Triggers(string catalog, string table, string triggerName) { }

	// RVA: 0x141BC60 Offset: 0x141A260 VA: 0x18141BC60
	private DataTable Schema_Tables(string strCatalog, string strTable, string strType) { }

	// RVA: 0x141DDA0 Offset: 0x141C3A0 VA: 0x18141DDA0
	private DataTable Schema_Views(string strCatalog, string strView) { }

	// RVA: 0x1415640 Offset: 0x1413C40 VA: 0x181415640
	private DataTable Schema_Catalogs(string strCatalog) { }

	// RVA: 0x1417A00 Offset: 0x1416000 VA: 0x181417A00
	private DataTable Schema_DataTypes() { }

	// RVA: 0x1418CD0 Offset: 0x14172D0 VA: 0x181418CD0
	private DataTable Schema_IndexColumns(string strCatalog, string strTable, string strIndex, string strColumn) { }

	// RVA: 0x141C8F0 Offset: 0x141AEF0 VA: 0x18141C8F0
	private DataTable Schema_ViewColumns(string strCatalog, string strView, string strColumn) { }

	// RVA: 0x1417FA0 Offset: 0x14165A0 VA: 0x181417FA0
	private DataTable Schema_ForeignKeys(string strCatalog, string strTable, string strKeyName) { }

}

public sealed class SqliteFactory : DbProviderFactory, IServiceProvider // TypeDefIndex: 4853
{	// Fields
	private static Type _dbProviderServicesType; // 0x0
	private static object _sqliteServices; // 0x8
	public static readonly SqliteFactory Instance; // 0x10

	// Methods

	// RVA: 0x21F2340 Offset: 0x21F0940 VA: 0x1821F2340
	private static void .cctor() { }

	// RVA: 0x21F2080 Offset: 0x21F0680 VA: 0x1821F2080 Slot: 4
	private object System.IServiceProvider.GetService(Type serviceType) { }

	// RVA: 0x21F1EE0 Offset: 0x21F04E0 VA: 0x1821F1EE0
	private object GetSQLiteProviderServicesInstance() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

internal class SQLite3 : SQLiteBase // TypeDefIndex: 4854
{	// Fields
	protected SqliteConnectionHandle _sql; // 0x18
	protected string _fileName; // 0x20
	protected bool _usePool; // 0x28
	protected int _poolVersion; // 0x2C
	private bool _buildingSchema; // 0x30
	protected SqliteFunction[] _functionsArray; // 0x38

	// Properties
	internal override string Version { get; }
	internal static string SQLiteVersion { get; }
	internal override int Changes { get; }

	// Methods

	// RVA: 0x140D540 Offset: 0x140BB40 VA: 0x18140D540
	internal void .ctor(SQLiteDateFormats fmt) { }

	// RVA: 0x140A7D0 Offset: 0x1408DD0 VA: 0x18140A7D0 Slot: 61
	protected override void Dispose(bool bDisposing) { }

	// RVA: 0x1409C10 Offset: 0x1408210 VA: 0x181409C10 Slot: 9
	internal override void Close() { }

	// RVA: 0x140D650 Offset: 0x140BC50 VA: 0x18140D650 Slot: 6
	internal override string get_Version() { }

	// RVA: 0x140D650 Offset: 0x140BC50 VA: 0x18140D650
	internal static string get_SQLiteVersion() { }

	// RVA: 0x140D5E0 Offset: 0x140BBE0 VA: 0x18140D5E0 Slot: 7
	internal override int get_Changes() { }

	// RVA: 0x140B490 Offset: 0x1409A90 VA: 0x18140B490 Slot: 8
	internal override void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool) { }

	// RVA: 0x140C6E0 Offset: 0x140ACE0 VA: 0x18140C6E0 Slot: 10
	internal override void SetTimeout(int nTimeoutMS) { }

	// RVA: 0x140C830 Offset: 0x140AE30 VA: 0x18140C830 Slot: 13
	internal override bool Step(SqliteStatement stmt) { }

	// RVA: 0x140BEB0 Offset: 0x140A4B0 VA: 0x18140BEB0 Slot: 14
	internal override int Reset(SqliteStatement stmt) { }

	// RVA: 0x140C430 Offset: 0x140AA30 VA: 0x18140C430 Slot: 11
	internal override string SQLiteLastError() { }

	// RVA: 0x140B730 Offset: 0x1409D30 VA: 0x18140B730 Slot: 12
	internal override SqliteStatement Prepare(SqliteConnection cnn, string strSql, SqliteStatement previous, uint timeoutMS, out string strRemain) { }

	// RVA: 0x14095F0 Offset: 0x1407BF0 VA: 0x1814095F0 Slot: 15
	internal override void Bind_Double(SqliteStatement stmt, int index, double value) { }

	// RVA: 0x14096E0 Offset: 0x1407CE0 VA: 0x1814096E0 Slot: 16
	internal override void Bind_Int32(SqliteStatement stmt, int index, int value) { }

	// RVA: 0x14097D0 Offset: 0x1407DD0 VA: 0x1814097D0 Slot: 17
	internal override void Bind_Int64(SqliteStatement stmt, int index, long value) { }

	// RVA: 0x1409AC0 Offset: 0x14080C0 VA: 0x181409AC0 Slot: 18
	internal override void Bind_Text(SqliteStatement stmt, int index, string value) { }

	// RVA: 0x1409480 Offset: 0x1407A80 VA: 0x181409480 Slot: 20
	internal override void Bind_DateTime(SqliteStatement stmt, int index, DateTime dt) { }

	// RVA: 0x1409360 Offset: 0x1407960 VA: 0x181409360 Slot: 19
	internal override void Bind_Blob(SqliteStatement stmt, int index, byte[] blobData) { }

	// RVA: 0x14098C0 Offset: 0x1407EC0 VA: 0x1814098C0 Slot: 21
	internal override void Bind_Null(SqliteStatement stmt, int index) { }

	// RVA: 0x14099A0 Offset: 0x1407FA0 VA: 0x1814099A0 Slot: 22
	internal override int Bind_ParamCount(SqliteStatement stmt) { }

	// RVA: 0x1409A10 Offset: 0x1408010 VA: 0x181409A10 Slot: 23
	internal override string Bind_ParamName(SqliteStatement stmt, int index) { }

	// RVA: 0x1409D70 Offset: 0x1408370 VA: 0x181409D70 Slot: 24
	internal override int ColumnCount(SqliteStatement stmt) { }

	// RVA: 0x140A0C0 Offset: 0x14086C0 VA: 0x18140A0C0 Slot: 25
	internal override string ColumnName(SqliteStatement stmt, int index) { }

	// RVA: 0x1409CF0 Offset: 0x14082F0 VA: 0x181409CF0 Slot: 26
	internal override TypeAffinity ColumnAffinity(SqliteStatement stmt, int index) { }

	// RVA: 0x140A2D0 Offset: 0x14088D0 VA: 0x18140A2D0 Slot: 27
	internal override string ColumnType(SqliteStatement stmt, int index, out TypeAffinity nAffinity) { }

	// RVA: 0x140A170 Offset: 0x1408770 VA: 0x18140A170 Slot: 28
	internal override string ColumnOriginalName(SqliteStatement stmt, int index) { }

	// RVA: 0x1409DE0 Offset: 0x14083E0 VA: 0x181409DE0 Slot: 29
	internal override string ColumnDatabaseName(SqliteStatement stmt, int index) { }

	// RVA: 0x140A220 Offset: 0x1408820 VA: 0x18140A220 Slot: 30
	internal override string ColumnTableName(SqliteStatement stmt, int index) { }

	// RVA: 0x1409E90 Offset: 0x1408490 VA: 0x181409E90 Slot: 31
	internal override void ColumnMetaData(string dataBase, string table, string column, out string dataType, out string collateSequence, out bool notNull, out bool primaryKey, out bool autoIncrement) { }

	// RVA: 0x140AA00 Offset: 0x1409000 VA: 0x18140AA00 Slot: 33
	internal override double GetDouble(SqliteStatement stmt, int index) { }

	// RVA: 0x140AAE0 Offset: 0x14090E0 VA: 0x18140AAE0 Slot: 34
	internal override int GetInt32(SqliteStatement stmt, int index) { }

	// RVA: 0x140AB60 Offset: 0x1409160 VA: 0x18140AB60 Slot: 35
	internal override long GetInt64(SqliteStatement stmt, int index) { }

	// RVA: 0x140AEB0 Offset: 0x14094B0 VA: 0x18140AEB0 Slot: 36
	internal override string GetText(SqliteStatement stmt, int index) { }

	// RVA: 0x140A950 Offset: 0x1408F50 VA: 0x18140A950 Slot: 38
	internal override DateTime GetDateTime(SqliteStatement stmt, int index) { }

	// RVA: 0x140A7F0 Offset: 0x1408DF0 VA: 0x18140A7F0 Slot: 37
	internal override long GetBytes(SqliteStatement stmt, int index, int nDataOffset, byte[] bDest, int nStart, int nLength) { }

	// RVA: 0x140B470 Offset: 0x1409A70 VA: 0x18140B470 Slot: 39
	internal override bool IsNull(SqliteStatement stmt, int index) { }

	// RVA: 0x140A5D0 Offset: 0x1408BD0 VA: 0x18140A5D0 Slot: 41
	internal override void CreateFunction(string strFunction, int nArgs, bool needCollSeq, SQLiteCallback func, SQLiteCallback funcstep, SQLiteFinalCallback funcfinal) { }

	// RVA: 0x140A420 Offset: 0x1408A20 VA: 0x18140A420 Slot: 40
	internal override void CreateCollation(string strCollation, SQLiteCollation func, SQLiteCollation func16, IntPtr user_data) { }

	// RVA: 0x140ABE0 Offset: 0x14091E0 VA: 0x18140ABE0 Slot: 43
	internal override long GetParamValueBytes(IntPtr p, int nDataOffset, byte[] bDest, int nStart, int nLength) { }

	// RVA: 0x140AD00 Offset: 0x1409300 VA: 0x18140AD00 Slot: 44
	internal override double GetParamValueDouble(IntPtr ptr) { }

	// RVA: 0x140AD60 Offset: 0x1409360 VA: 0x18140AD60 Slot: 45
	internal override long GetParamValueInt64(IntPtr ptr) { }

	// RVA: 0x140ADC0 Offset: 0x14093C0 VA: 0x18140ADC0 Slot: 46
	internal override string GetParamValueText(IntPtr ptr) { }

	// RVA: 0x140AE50 Offset: 0x1409450 VA: 0x18140AE50 Slot: 47
	internal override TypeAffinity GetParamValueType(IntPtr ptr) { }

	// RVA: 0x140C0C0 Offset: 0x140A6C0 VA: 0x18140C0C0 Slot: 48
	internal override void ReturnBlob(IntPtr context, byte[] value) { }

	// RVA: 0x140C160 Offset: 0x140A760 VA: 0x18140C160 Slot: 49
	internal override void ReturnDouble(IntPtr context, double value) { }

	// RVA: 0x140C1D0 Offset: 0x140A7D0 VA: 0x18140C1D0 Slot: 50
	internal override void ReturnError(IntPtr context, string value) { }

	// RVA: 0x140C280 Offset: 0x140A880 VA: 0x18140C280 Slot: 51
	internal override void ReturnInt64(IntPtr context, long value) { }

	// RVA: 0x140C2F0 Offset: 0x140A8F0 VA: 0x18140C2F0 Slot: 52
	internal override void ReturnNull(IntPtr context) { }

	// RVA: 0x140C350 Offset: 0x140A950 VA: 0x18140C350 Slot: 53
	internal override void ReturnText(IntPtr context, string value) { }

	// RVA: 0x1409300 Offset: 0x1407900 VA: 0x181409300 Slot: 42
	internal override IntPtr AggregateContext(IntPtr context) { }

	// RVA: 0x140C580 Offset: 0x140AB80 VA: 0x18140C580 Slot: 54
	internal override void SetPassword(byte[] passwordBytes) { }

	// RVA: 0x140C7B0 Offset: 0x140ADB0 VA: 0x18140C7B0 Slot: 55
	internal override void SetUpdateHook(SQLiteUpdateCallback func) { }

	// RVA: 0x140C500 Offset: 0x140AB00 VA: 0x18140C500 Slot: 56
	internal override void SetCommitHook(SQLiteCommitCallback func) { }

	// RVA: 0x140C660 Offset: 0x140AC60 VA: 0x18140C660 Slot: 57
	internal override void SetRollbackHook(SQLiteRollbackCallback func) { }

	// RVA: 0x140AF60 Offset: 0x1409560 VA: 0x18140AF60 Slot: 60
	internal override object GetValue(SqliteStatement stmt, int index, SQLiteType typ) { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 58
	internal override int GetCursorForTable(SqliteStatement stmt, int db, int rootPage) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 59
	internal override long GetRowIdForCursor(SqliteStatement stmt, int cursor) { }

	// RVA: 0x140AA80 Offset: 0x1409080 VA: 0x18140AA80 Slot: 32
	internal override void GetIndexColumnExtendedInfo(string database, string index, string column, out int sortMode, out int onError, out string collationSequence) { }

}

internal class SQLite3_UTF16 : SQLite3 // TypeDefIndex: 4855
{	// Methods

	// RVA: 0x140D530 Offset: 0x140BB30 VA: 0x18140D530
	internal void .ctor(SQLiteDateFormats fmt) { }

	// RVA: 0x140D460 Offset: 0x140BA60 VA: 0x18140D460 Slot: 4
	public override string ToString(IntPtr b, int nbytelen) { }

	// RVA: 0x140D470 Offset: 0x140BA70 VA: 0x18140D470
	public static string UTF16ToString(IntPtr b, int nbytelen) { }

	// RVA: 0x140D170 Offset: 0x140B770 VA: 0x18140D170 Slot: 8
	internal override void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool) { }

	// RVA: 0x140CA50 Offset: 0x140B050 VA: 0x18140CA50 Slot: 20
	internal override void Bind_DateTime(SqliteStatement stmt, int index, DateTime dt) { }

	// RVA: 0x140CAB0 Offset: 0x140B0B0 VA: 0x18140CAB0 Slot: 18
	internal override void Bind_Text(SqliteStatement stmt, int index, string value) { }

	// RVA: 0x140CF90 Offset: 0x140B590 VA: 0x18140CF90 Slot: 38
	internal override DateTime GetDateTime(SqliteStatement stmt, int index) { }

	// RVA: 0x140CCC0 Offset: 0x140B2C0 VA: 0x18140CCC0 Slot: 25
	internal override string ColumnName(SqliteStatement stmt, int index) { }

	// RVA: 0x140D080 Offset: 0x140B680 VA: 0x18140D080 Slot: 36
	internal override string GetText(SqliteStatement stmt, int index) { }

	// RVA: 0x140CDB0 Offset: 0x140B3B0 VA: 0x18140CDB0 Slot: 28
	internal override string ColumnOriginalName(SqliteStatement stmt, int index) { }

	// RVA: 0x140CBD0 Offset: 0x140B1D0 VA: 0x18140CBD0 Slot: 29
	internal override string ColumnDatabaseName(SqliteStatement stmt, int index) { }

	// RVA: 0x140CEA0 Offset: 0x140B4A0 VA: 0x18140CEA0 Slot: 30
	internal override string ColumnTableName(SqliteStatement stmt, int index) { }

	// RVA: 0x140CFC0 Offset: 0x140B5C0 VA: 0x18140CFC0 Slot: 46
	internal override string GetParamValueText(IntPtr ptr) { }

	// RVA: 0x140D340 Offset: 0x140B940 VA: 0x18140D340 Slot: 50
	internal override void ReturnError(IntPtr context, string value) { }

	// RVA: 0x140D3C0 Offset: 0x140B9C0 VA: 0x18140D3C0 Slot: 53
	internal override void ReturnText(IntPtr context, string value) { }

}

internal abstract class SQLiteBase : SqliteConvert, IDisposable // TypeDefIndex: 4856
{	// Fields
	internal static object _lock; // 0x13769

	// Properties
	internal abstract string Version { get; }
	internal abstract int Changes { get; }

	// Methods

	// RVA: 0x140DDC0 Offset: 0x140C3C0 VA: 0x18140DDC0
	internal void .ctor(SQLiteDateFormats fmt) { }

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract string get_Version();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract int get_Changes();

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void Close();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract void SetTimeout(int nTimeoutMS);

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract string SQLiteLastError();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract SqliteStatement Prepare(SqliteConnection cnn, string strSql, SqliteStatement previous, uint timeoutMS, out string strRemain);

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract bool Step(SqliteStatement stmt);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract int Reset(SqliteStatement stmt);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void Bind_Double(SqliteStatement stmt, int index, double value);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract void Bind_Int32(SqliteStatement stmt, int index, int value);

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract void Bind_Int64(SqliteStatement stmt, int index, long value);

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract void Bind_Text(SqliteStatement stmt, int index, string value);

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract void Bind_Blob(SqliteStatement stmt, int index, byte[] blobData);

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract void Bind_DateTime(SqliteStatement stmt, int index, DateTime dt);

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract void Bind_Null(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 22
	internal abstract int Bind_ParamCount(SqliteStatement stmt);

	// RVA: -1 Offset: -1 Slot: 23
	internal abstract string Bind_ParamName(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 24
	internal abstract int ColumnCount(SqliteStatement stmt);

	// RVA: -1 Offset: -1 Slot: 25
	internal abstract string ColumnName(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 26
	internal abstract TypeAffinity ColumnAffinity(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 27
	internal abstract string ColumnType(SqliteStatement stmt, int index, out TypeAffinity nAffinity);

	// RVA: -1 Offset: -1 Slot: 28
	internal abstract string ColumnOriginalName(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 29
	internal abstract string ColumnDatabaseName(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 30
	internal abstract string ColumnTableName(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 31
	internal abstract void ColumnMetaData(string dataBase, string table, string column, out string dataType, out string collateSequence, out bool notNull, out bool primaryKey, out bool autoIncrement);

	// RVA: -1 Offset: -1 Slot: 32
	internal abstract void GetIndexColumnExtendedInfo(string database, string index, string column, out int sortMode, out int onError, out string collationSequence);

	// RVA: -1 Offset: -1 Slot: 33
	internal abstract double GetDouble(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 34
	internal abstract int GetInt32(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 35
	internal abstract long GetInt64(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 36
	internal abstract string GetText(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 37
	internal abstract long GetBytes(SqliteStatement stmt, int index, int nDataoffset, byte[] bDest, int nStart, int nLength);

	// RVA: -1 Offset: -1 Slot: 38
	internal abstract DateTime GetDateTime(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 39
	internal abstract bool IsNull(SqliteStatement stmt, int index);

	// RVA: -1 Offset: -1 Slot: 40
	internal abstract void CreateCollation(string strCollation, SQLiteCollation func, SQLiteCollation func16, IntPtr user_data);

	// RVA: -1 Offset: -1 Slot: 41
	internal abstract void CreateFunction(string strFunction, int nArgs, bool needCollSeq, SQLiteCallback func, SQLiteCallback funcstep, SQLiteFinalCallback funcfinal);

	// RVA: -1 Offset: -1 Slot: 42
	internal abstract IntPtr AggregateContext(IntPtr context);

	// RVA: -1 Offset: -1 Slot: 43
	internal abstract long GetParamValueBytes(IntPtr ptr, int nDataOffset, byte[] bDest, int nStart, int nLength);

	// RVA: -1 Offset: -1 Slot: 44
	internal abstract double GetParamValueDouble(IntPtr ptr);

	// RVA: -1 Offset: -1 Slot: 45
	internal abstract long GetParamValueInt64(IntPtr ptr);

	// RVA: -1 Offset: -1 Slot: 46
	internal abstract string GetParamValueText(IntPtr ptr);

	// RVA: -1 Offset: -1 Slot: 47
	internal abstract TypeAffinity GetParamValueType(IntPtr ptr);

	// RVA: -1 Offset: -1 Slot: 48
	internal abstract void ReturnBlob(IntPtr context, byte[] value);

	// RVA: -1 Offset: -1 Slot: 49
	internal abstract void ReturnDouble(IntPtr context, double value);

	// RVA: -1 Offset: -1 Slot: 50
	internal abstract void ReturnError(IntPtr context, string value);

	// RVA: -1 Offset: -1 Slot: 51
	internal abstract void ReturnInt64(IntPtr context, long value);

	// RVA: -1 Offset: -1 Slot: 52
	internal abstract void ReturnNull(IntPtr context);

	// RVA: -1 Offset: -1 Slot: 53
	internal abstract void ReturnText(IntPtr context, string value);

	// RVA: -1 Offset: -1 Slot: 54
	internal abstract void SetPassword(byte[] passwordBytes);

	// RVA: -1 Offset: -1 Slot: 55
	internal abstract void SetUpdateHook(SQLiteUpdateCallback func);

	// RVA: -1 Offset: -1 Slot: 56
	internal abstract void SetCommitHook(SQLiteCommitCallback func);

	// RVA: -1 Offset: -1 Slot: 57
	internal abstract void SetRollbackHook(SQLiteRollbackCallback func);

	// RVA: -1 Offset: -1 Slot: 58
	internal abstract int GetCursorForTable(SqliteStatement stmt, int database, int rootPage);

	// RVA: -1 Offset: -1 Slot: 59
	internal abstract long GetRowIdForCursor(SqliteStatement stmt, int cursor);

	// RVA: -1 Offset: -1 Slot: 60
	internal abstract object GetValue(SqliteStatement stmt, int index, SQLiteType typ);

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 61
	protected virtual void Dispose(bool bDisposing) { }

	// RVA: 0x140D8F0 Offset: 0x140BEF0 VA: 0x18140D8F0 Slot: 5
	public void Dispose() { }

	// RVA: 0x140DCD0 Offset: 0x140C2D0 VA: 0x18140DCD0
	internal static string SQLiteLastError(SqliteConnectionHandle db) { }

	// RVA: 0x140D910 Offset: 0x140BF10 VA: 0x18140D910
	internal static void FinalizeStatement(SqliteStatementHandle stmt) { }

	// RVA: 0x140D6D0 Offset: 0x140BCD0 VA: 0x18140D6D0
	internal static void CloseConnection(SqliteConnectionHandle db) { }

	// RVA: 0x140DA80 Offset: 0x140C080 VA: 0x18140DA80
	internal static void ResetConnection(SqliteConnectionHandle db) { }

	// RVA: 0x140DD60 Offset: 0x140C360 VA: 0x18140DD60
	private static void .cctor() { }

}

internal enum SQLiteOpenFlagsEnum // TypeDefIndex: 4858
{	// Fields
	public int value__; // 0x0
	public const SQLiteOpenFlagsEnum None = 0;
	public const SQLiteOpenFlagsEnum ReadOnly = 1;
	public const SQLiteOpenFlagsEnum ReadWrite = 2;
	public const SQLiteOpenFlagsEnum Create = 4;
	public const SQLiteOpenFlagsEnum Default = 6;
	public const SQLiteOpenFlagsEnum FileProtectionComplete = 1048576;
	public const SQLiteOpenFlagsEnum FileProtectionCompleteUnlessOpen = 2097152;
	public const SQLiteOpenFlagsEnum FileProtectionCompleteUntilFirstUserAuthentication = 3145728;
	public const SQLiteOpenFlagsEnum FileProtectionNone = 4194304;

}

public sealed class SqliteCommand : DbCommand, ICloneable // TypeDefIndex: 4859
{	// Fields
	private string _commandText; // 0x28
	private SqliteConnection _cnn; // 0x30
	private long _version; // 0x38
	private WeakReference _activeReader; // 0x40
	internal int _commandTimeout; // 0x48
	private bool _designTimeVisible; // 0x4C
	private UpdateRowSource _updateRowSource; // 0x50
	private SqliteParameterCollection _parameterCollection; // 0x58
	internal List<SqliteStatement> _statementList; // 0x60
	internal string _remainingText; // 0x68
	private SqliteTransaction _transaction; // 0x70

	// Properties
	[DefaultValueAttribute] // RVA: 0xDF090 Offset: 0xDE490 VA: 0x1800DF090
	[RefreshPropertiesAttribute] // RVA: 0xDF090 Offset: 0xDE490 VA: 0x1800DF090
	[EditorAttribute] // RVA: 0xDF090 Offset: 0xDE490 VA: 0x1800DF090
	public override string CommandText { get; set; }
	[DefaultValueAttribute] // RVA: 0xDF190 Offset: 0xDE590 VA: 0x1800DF190
	public override int CommandTimeout { get; set; }
	[DefaultValueAttribute] // RVA: 0xDF340 Offset: 0xDE740 VA: 0x1800DF340
	[RefreshPropertiesAttribute] // RVA: 0xDF340 Offset: 0xDE740 VA: 0x1800DF340
	public override CommandType CommandType { set; }
	[EditorAttribute] // RVA: 0xDF440 Offset: 0xDE840 VA: 0x1800DF440
	[DefaultValueAttribute] // RVA: 0xDF440 Offset: 0xDE840 VA: 0x1800DF440
	public SqliteConnection Connection { get; set; }
	protected override DbConnection DbConnection { get; set; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	public SqliteParameterCollection Parameters { get; }
	protected override DbParameterCollection DbParameterCollection { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	[BrowsableAttribute] // RVA: 0x9E850 Offset: 0x9DC50 VA: 0x18009E850
	public SqliteTransaction Transaction { get; set; }
	protected override DbTransaction DbTransaction { get; set; }
	[DefaultValueAttribute] // RVA: 0xDF7C0 Offset: 0xDEBC0 VA: 0x1800DF7C0
	public override UpdateRowSource UpdatedRowSource { get; set; }
	[DefaultValueAttribute] // RVA: 0xDF8D0 Offset: 0xDECD0 VA: 0x1800DF8D0
	[EditorBrowsableAttribute] // RVA: 0xDF8D0 Offset: 0xDECD0 VA: 0x1800DF8D0
	[BrowsableAttribute] // RVA: 0xDF8D0 Offset: 0xDECD0 VA: 0x1800DF8D0
	[DesignOnlyAttribute] // RVA: 0xDF8D0 Offset: 0xDECD0 VA: 0x1800DF8D0
	public override bool DesignTimeVisible { get; set; }

	// Methods

	// RVA: 0x1411790 Offset: 0x140FD90 VA: 0x181411790
	public void .ctor(string commandText, SqliteConnection connection) { }

	// RVA: 0x1411430 Offset: 0x140FA30 VA: 0x181411430
	public void .ctor(SqliteConnection connection) { }

	// RVA: 0x1411180 Offset: 0x140F780 VA: 0x181411180
	private void .ctor(SqliteCommand source) { }

	// RVA: 0x1411510 Offset: 0x140FB10 VA: 0x181411510
	public void .ctor(string commandText, SqliteConnection connection, SqliteTransaction transaction) { }

	// RVA: 0x1410A70 Offset: 0x140F070 VA: 0x181410A70 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1410860 Offset: 0x140EE60 VA: 0x181410860
	internal void ClearCommands() { }

	// RVA: 0x1410630 Offset: 0x140EC30 VA: 0x181410630
	internal SqliteStatement BuildNextCommand() { }

	// RVA: 0x1410F80 Offset: 0x140F580 VA: 0x181410F80
	internal SqliteStatement GetStatement(int index) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 12
	public override string get_CommandText() { }

	// RVA: 0x14118A0 Offset: 0x140FEA0 VA: 0x1814118A0 Slot: 13
	public override void set_CommandText(string value) { }

	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420 Slot: 14
	public override int get_CommandTimeout() { }

	// RVA: 0x598430 Offset: 0x596A30 VA: 0x180598430 Slot: 15
	public override void set_CommandTimeout(int value) { }

	// RVA: 0x1411960 Offset: 0x140FF60 VA: 0x181411960 Slot: 16
	public override void set_CommandType(CommandType value) { }

	// RVA: 0x1410A20 Offset: 0x140F020 VA: 0x181410A20 Slot: 26
	protected override DbParameter CreateDbParameter() { }

	// RVA: 0x1410A20 Offset: 0x140F020 VA: 0x181410A20
	public SqliteParameter CreateParameter() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public SqliteConnection get_Connection() { }

	// RVA: 0x14119C0 Offset: 0x140FFC0 VA: 0x1814119C0
	public void set_Connection(SqliteConnection value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 17
	protected override DbConnection get_DbConnection() { }

	// RVA: 0x1411A80 Offset: 0x1410080 VA: 0x181411A80 Slot: 18
	protected override void set_DbConnection(DbConnection value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public SqliteParameterCollection get_Parameters() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 19
	protected override DbParameterCollection get_DbParameterCollection() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public SqliteTransaction get_Transaction() { }

	// RVA: 0x1411BD0 Offset: 0x14101D0 VA: 0x181411BD0
	public void set_Transaction(SqliteTransaction value) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 20
	protected override DbTransaction get_DbTransaction() { }

	// RVA: 0x1411AF0 Offset: 0x14100F0 VA: 0x181411AF0 Slot: 21
	protected override void set_DbTransaction(DbTransaction value) { }

	// RVA: 0x1411040 Offset: 0x140F640 VA: 0x181411040
	private void InitializeForReader() { }

	// RVA: 0x1410C00 Offset: 0x140F200 VA: 0x181410C00 Slot: 27
	protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior) { }

	// RVA: 0x1410D20 Offset: 0x140F320 VA: 0x181410D20
	public SqliteDataReader ExecuteReader(CommandBehavior behavior) { }

	// RVA: 0x1410F70 Offset: 0x140F570 VA: 0x181410F70
	public SqliteDataReader ExecuteReader() { }

	// RVA: 0x8094D0 Offset: 0x807AD0 VA: 0x1808094D0
	internal void ClearDataReader() { }

	// RVA: 0x1410C10 Offset: 0x140F210 VA: 0x181410C10 Slot: 28
	public override int ExecuteNonQuery() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 29
	public override void Prepare() { }

	// RVA: 0x8D8F00 Offset: 0x8D7500 VA: 0x1808D8F00 Slot: 24
	public override UpdateRowSource get_UpdatedRowSource() { }

	// RVA: 0x8D8F40 Offset: 0x8D7540 VA: 0x1808D8F40 Slot: 25
	public override void set_UpdatedRowSource(UpdateRowSource value) { }

	// RVA: 0xC20A70 Offset: 0xC1F070 VA: 0x180C20A70 Slot: 22
	public override bool get_DesignTimeVisible() { }

	// RVA: 0x1411B60 Offset: 0x1410160 VA: 0x181411B60 Slot: 23
	public override void set_DesignTimeVisible(bool value) { }

	// RVA: 0x14109C0 Offset: 0x140EFC0 VA: 0x1814109C0 Slot: 30
	public object Clone() { }

}

public sealed class SqliteCommandBuilder : DbCommandBuilder // TypeDefIndex: 4860
{	// Properties
	public SqliteDataAdapter DataAdapter { set; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public override CatalogLocation CatalogLocation { get; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public override string CatalogSeparator { get; }
	[DefaultValueAttribute] // RVA: 0xDFC30 Offset: 0xDF030 VA: 0x1800DFC30
	[BrowsableAttribute] // RVA: 0xDFC30 Offset: 0xDF030 VA: 0x1800DFC30
	public override string QuotePrefix { get; set; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public override string QuoteSuffix { get; set; }
	[BrowsableAttribute] // RVA: 0x9A900 Offset: 0x99D00 VA: 0x18009A900
	public override string SchemaSeparator { get; }

	// Methods

	// RVA: 0x14104B0 Offset: 0x140EAB0 VA: 0x1814104B0
	public void .ctor() { }

	// RVA: 0x1410530 Offset: 0x140EB30 VA: 0x181410530
	public void .ctor(SqliteDataAdapter adp) { }

	// RVA: 0x140F690 Offset: 0x140DC90 VA: 0x18140F690 Slot: 25
	protected override void ApplyParameterInfo(DbParameter parameter, DataRow row, StatementType statementType, bool whereClause) { }

	// RVA: 0x140F830 Offset: 0x140DE30 VA: 0x18140F830 Slot: 27
	protected override string GetParameterName(string parameterName) { }

	// RVA: 0x140F7A0 Offset: 0x140DDA0 VA: 0x18140F7A0 Slot: 26
	protected override string GetParameterName(int parameterOrdinal) { }

	// RVA: 0x140F8A0 Offset: 0x140DEA0 VA: 0x18140F8A0 Slot: 28
	protected override string GetParameterPlaceholder(int parameterOrdinal) { }

	// RVA: 0x1410150 Offset: 0x140E750 VA: 0x181410150 Slot: 29
	protected override void SetRowUpdatingHandler(DbDataAdapter adapter) { }

	// RVA: 0x1410140 Offset: 0x140E740 VA: 0x181410140
	private void RowUpdatingEventHandler(object sender, RowUpdatingEventArgs e) { }

	// RVA: 0x1410600 Offset: 0x140EC00 VA: 0x181410600
	public void set_DataAdapter(SqliteDataAdapter value) { }

	// RVA: 0x582940 Offset: 0x580F40 VA: 0x180582940 Slot: 13
	public override CatalogLocation get_CatalogLocation() { }

	// RVA: 0x14105C0 Offset: 0x140EBC0 VA: 0x1814105C0 Slot: 14
	public override string get_CatalogSeparator() { }

	// RVA: 0x14105D0 Offset: 0x140EBD0 VA: 0x1814105D0 Slot: 15
	public override string get_QuotePrefix() { }

	// RVA: 0x1410610 Offset: 0x140EC10 VA: 0x181410610 Slot: 16
	public override void set_QuotePrefix(string value) { }

	// RVA: 0x14105E0 Offset: 0x140EBE0 VA: 0x1814105E0 Slot: 17
	public override string get_QuoteSuffix() { }

	// RVA: 0x1410620 Offset: 0x140EC20 VA: 0x181410620 Slot: 18
	public override void set_QuoteSuffix(string value) { }

	// RVA: 0x140FCF0 Offset: 0x140E2F0 VA: 0x18140FCF0 Slot: 22
	public override string QuoteIdentifier(string unquotedIdentifier) { }

	// RVA: 0x14102D0 Offset: 0x140E8D0 VA: 0x1814102D0 Slot: 24
	public override string UnquoteIdentifier(string quotedIdentifier) { }

	// RVA: 0x14105F0 Offset: 0x140EBF0 VA: 0x1814105F0 Slot: 19
	public override string get_SchemaSeparator() { }

	// RVA: 0x140F8C0 Offset: 0x140DEC0 VA: 0x18140F8C0 Slot: 20
	protected override DataTable GetSchemaTable(DbCommand sourceCommand) { }

	// RVA: 0x140FA50 Offset: 0x140E050 VA: 0x18140FA50
	private bool HasSchemaPrimaryKey(DataTable schema) { }

	// RVA: 0x140FE40 Offset: 0x140E440 VA: 0x18140FE40
	private void ResetIsUniqueSchemaColumn(DataTable schema) { }

}

internal sealed class SQLiteUpdateCallback : MulticastDelegate // TypeDefIndex: 4861
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140F080 Offset: 0x140D680 VA: 0x18140F080 Slot: 12
	public virtual void Invoke(IntPtr puser, int type, IntPtr database, IntPtr table, long rowid) { }

	// RVA: 0x140EFA0 Offset: 0x140D5A0 VA: 0x18140EFA0 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr puser, int type, IntPtr database, IntPtr table, long rowid, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteCommitCallback : MulticastDelegate // TypeDefIndex: 4862
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140E760 Offset: 0x140CD60 VA: 0x18140E760 Slot: 12
	public virtual int Invoke(IntPtr puser) { }

	// RVA: 0x140E6E0 Offset: 0x140CCE0 VA: 0x18140E6E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr puser, AsyncCallback callback, object object) { }

	// RVA: 0xB9A710 Offset: 0xB98D10 VA: 0x180B9A710 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteRollbackCallback : MulticastDelegate // TypeDefIndex: 4863
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140ED30 Offset: 0x140D330 VA: 0x18140ED30 Slot: 12
	public virtual void Invoke(IntPtr puser) { }

	// RVA: 0x140EF20 Offset: 0x140D520 VA: 0x18140EF20 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr puser, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class SQLiteCommitHandler : MulticastDelegate // TypeDefIndex: 4864
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, CommitEventArgs e) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, CommitEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class SQLiteUpdateEventHandler : MulticastDelegate // TypeDefIndex: 4865
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE45C0 Offset: 0xAE2BC0 VA: 0x180AE45C0 Slot: 12
	public virtual void Invoke(object sender, UpdateEventArgs e) { }

	// RVA: 0xAE4580 Offset: 0xAE2B80 VA: 0x180AE4580 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, UpdateEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal static class SqliteConnectionPool // TypeDefIndex: 4868
{
// Namespace: Mono.Data.Sqlite
public class CommitEventArgs : EventArgs // TypeDefIndex: 4867

// Namespace: Mono.Data.Sqlite
internal static class SqliteConnectionPool // TypeDefIndex: 4868
	// Fields
	private static SortedList<string, SqliteConnectionPool.Pool> _connections; // 0x0
	private static int _poolVersion; // 0x8

	// Methods

	// RVA: 0x14121B0 Offset: 0x14107B0 VA: 0x1814121B0
	internal static SqliteConnectionHandle Remove(string fileName, int maxPoolSize, out int version) { }

	// RVA: 0x1411E90 Offset: 0x1410490 VA: 0x181411E90
	internal static void Add(string fileName, SqliteConnectionHandle hdl, int version) { }

	// RVA: 0x1412540 Offset: 0x1410B40 VA: 0x181412540
	private static void ResizePool(SqliteConnectionPool.Pool queue, bool forAdding) { }

	// RVA: 0x1412630 Offset: 0x1410C30 VA: 0x181412630
	private static void .cctor() { }

}

internal class SqliteConnectionPool.Pool // TypeDefIndex: 4869
{	// Fields
	internal readonly Queue<WeakReference> Queue; // 0x10
	internal int PoolVersion; // 0x18
	internal int MaxPoolSize; // 0x1C

	// Methods

	// RVA: 0x1409270 Offset: 0x1407870 VA: 0x181409270
	internal void .ctor(int version, int maxSize) { }

}

public abstract class SqliteConvert // TypeDefIndex: 4870
{	// Fields
	protected static readonly DateTime UnixEpoch; // 0x0
	private static string[] _datetimeFormats; // 0x8
	private static Encoding _utf8; // 0x10
	internal SQLiteDateFormats _datetimeFormat; // 0x10
	private static Type[] _affinitytotype; // 0x18
	private static DbType[] _typetodbtype; // 0x20
	private static int[] _dbtypetocolumnsize; // 0x28
	private static object[] _dbtypetonumericprecision; // 0x30
	private static object[] _dbtypetonumericscale; // 0x38
	private static SQLiteTypeNames[] _dbtypeNames; // 0x40
	private static Type[] _dbtypeToType; // 0x48
	private static TypeAffinity[] _typecodeAffinities; // 0x50
	private static SQLiteTypeNames[] _typeNames; // 0x58

	// Methods

	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	internal void .ctor(SQLiteDateFormats fmt) { }

	// RVA: 0x141FD20 Offset: 0x141E320 VA: 0x18141FD20
	public static byte[] ToUTF8(string sourceText) { }

	// RVA: 0x141FCB0 Offset: 0x141E2B0 VA: 0x18141FCB0
	public byte[] ToUTF8(DateTime dateTimeValue) { }

	// RVA: 0x141FC50 Offset: 0x141E250 VA: 0x18141FC50 Slot: 4
	public virtual string ToString(IntPtr nativestring, int nativestringlen) { }

	// RVA: 0x14203F0 Offset: 0x141E9F0 VA: 0x1814203F0
	public static string UTF8ToString(IntPtr nativestring, int nativestringlen) { }

	// RVA: 0x141F6C0 Offset: 0x141DCC0 VA: 0x18141F6C0
	public DateTime ToDateTime(string dateText) { }

	// RVA: 0x141F9A0 Offset: 0x141DFA0 VA: 0x18141F9A0
	public DateTime ToDateTime(double julianDay) { }

	// RVA: 0x141FA00 Offset: 0x141E000 VA: 0x18141FA00
	public double ToJulianDay(DateTime value) { }

	// RVA: 0x141FA30 Offset: 0x141E030 VA: 0x18141FA30
	public string ToString(DateTime dateValue) { }

	// RVA: 0x141F690 Offset: 0x141DC90 VA: 0x18141F690
	internal DateTime ToDateTime(IntPtr ptr, int len) { }

	// RVA: 0x141F0C0 Offset: 0x141D6C0 VA: 0x18141F0C0
	public static string[] Split(string source, char separator) { }

	// RVA: 0x141F440 Offset: 0x141DA40 VA: 0x18141F440
	public static bool ToBoolean(string source) { }

	// RVA: 0x141EF80 Offset: 0x141D580 VA: 0x18141EF80
	internal static Type SQLiteTypeToType(SQLiteType t) { }

	// RVA: 0x1420280 Offset: 0x141E880 VA: 0x181420280
	internal static DbType TypeToDbType(Type typ) { }

	// RVA: 0x141EBE0 Offset: 0x141D1E0 VA: 0x18141EBE0
	internal static int DbTypeToColumnSize(DbType typ) { }

	// RVA: 0x141EC70 Offset: 0x141D270 VA: 0x18141EC70
	internal static object DbTypeToNumericPrecision(DbType typ) { }

	// RVA: 0x141ED00 Offset: 0x141D300 VA: 0x18141ED00
	internal static object DbTypeToNumericScale(DbType typ) { }

	// RVA: 0x141ED90 Offset: 0x141D390 VA: 0x18141ED90
	internal static string DbTypeToTypeName(DbType typ) { }

	// RVA: 0x141EEF0 Offset: 0x141D4F0 VA: 0x18141EEF0
	internal static Type DbTypeToType(DbType typ) { }

	// RVA: 0x1420120 Offset: 0x141E720 VA: 0x181420120
	internal static TypeAffinity TypeToAffinity(Type typ) { }

	// RVA: 0x141FE30 Offset: 0x141E430 VA: 0x18141FE30
	internal static DbType TypeNameToDbType(string Name) { }

	// RVA: 0x1420550 Offset: 0x141EB50 VA: 0x181420550
	private static void .cctor() { }

}

public enum SQLiteDateFormats // TypeDefIndex: 4872
{	// Fields
	public int value__; // 0x0
	public const SQLiteDateFormats Ticks = 0;
	public const SQLiteDateFormats ISO8601 = 1;
	public const SQLiteDateFormats JulianDay = 2;
	public const SQLiteDateFormats UnixEpoch = 3;

}

internal class SQLiteType // TypeDefIndex: 4873
{	// Fields
	internal DbType Type; // 0x10
	internal TypeAffinity Affinity; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal struct SQLiteTypeNames // TypeDefIndex: 4874
{	// Fields
	internal string typeName; // 0x0
	internal DbType dataType; // 0x8

	// Methods

	// RVA: 0xF9160 Offset: 0xF8560 VA: 0x1800F9160
	internal void .ctor(string newtypeName, DbType newdataType) { }

}

public sealed class SqliteDataAdapter : DbDataAdapter // TypeDefIndex: 4875
{	// Fields
	private static object _updatingEventPH; // 0x0
	private static object _updatedEventPH; // 0x8

	// Methods

	// RVA: 0x1424F40 Offset: 0x1423540 VA: 0x181424F40
	public void add_RowUpdating(EventHandler<RowUpdatingEventArgs> value) { }

	// RVA: 0x1425210 Offset: 0x1423810 VA: 0x181425210
	public void remove_RowUpdating(EventHandler<RowUpdatingEventArgs> value) { }

	// RVA: 0x1424DC0 Offset: 0x14233C0 VA: 0x181424DC0
	internal static Delegate FindBuilder(MulticastDelegate mcd) { }

	// RVA: 0x1424EB0 Offset: 0x14234B0 VA: 0x181424EB0
	private static void .cctor() { }

}

public sealed class SqliteDataReader : DbDataReader // TypeDefIndex: 4876
{	// Fields
	private SqliteCommand _command; // 0x18
	private int _activeStatementIndex; // 0x20
	private SqliteStatement _activeStatement; // 0x28
	private int _readingState; // 0x30
	private int _rowsAffected; // 0x34
	private int _fieldCount; // 0x38
	private SQLiteType[] _fieldTypeArray; // 0x40
	private CommandBehavior _commandBehavior; // 0x48
	internal bool _disposeCommand; // 0x4C
	private SqliteKeyReader _keyInfo; // 0x50
	internal long _version; // 0x58
	private static bool hasColumnMetadataSupport; // 0x0

	// Properties
	public override int FieldCount { get; }
	public override int VisibleFieldCount { get; }
	public override int RecordsAffected { get; }
	public override object Item { get; }

	// Methods

	// RVA: 0x14290C0 Offset: 0x14276C0 VA: 0x1814290C0
	internal void .ctor(SqliteCommand cmd, CommandBehavior behave) { }

	// RVA: 0x1425430 Offset: 0x1423A30 VA: 0x181425430 Slot: 21
	public override void Close() { }

	// RVA: 0x14252A0 Offset: 0x14238A0 VA: 0x1814252A0
	private void CheckClosed() { }

	// RVA: 0x14253C0 Offset: 0x14239C0 VA: 0x1814253C0
	private void CheckValidRow() { }

	// RVA: 0x1425910 Offset: 0x1423F10 VA: 0x181425910 Slot: 24
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x1429170 Offset: 0x1427770 VA: 0x181429170 Slot: 17
	public override int get_FieldCount() { }

	// RVA: 0x14291E0 Offset: 0x14277E0 VA: 0x1814291E0 Slot: 19
	public override int get_VisibleFieldCount() { }

	// RVA: 0x1428F40 Offset: 0x1427540 VA: 0x181428F40
	private TypeAffinity VerifyType(int i, DbType typ) { }

	// RVA: 0x1425680 Offset: 0x1423C80 VA: 0x181425680 Slot: 28
	public override bool GetBoolean(int i) { }

	// RVA: 0x1425850 Offset: 0x1423E50 VA: 0x181425850 Slot: 23
	public override string GetDataTypeName(int i) { }

	// RVA: 0x1425980 Offset: 0x1423F80 VA: 0x181425980 Slot: 25
	public override Type GetFieldType(int i) { }

	// RVA: 0x1425A50 Offset: 0x1424050 VA: 0x181425A50 Slot: 29
	public override int GetInt32(int i) { }

	// RVA: 0x1425BC0 Offset: 0x14241C0 VA: 0x181425BC0 Slot: 30
	public override long GetInt64(int i) { }

	// RVA: 0x1425D30 Offset: 0x1424330 VA: 0x181425D30 Slot: 26
	public override string GetName(int i) { }

	// RVA: 0x1425FE0 Offset: 0x14245E0 VA: 0x181425FE0 Slot: 27
	public override DataTable GetSchemaTable() { }

	// RVA: 0x1425FF0 Offset: 0x14245F0 VA: 0x181425FF0
	internal DataTable GetSchemaTable(bool wantUniqueInfo, bool wantDefaultValue) { }

	// RVA: 0x1428730 Offset: 0x1426D30 VA: 0x181428730 Slot: 31
	public override string GetString(int i) { }

	// RVA: 0x14288A0 Offset: 0x1426EA0 VA: 0x1814288A0 Slot: 32
	public override object GetValue(int i) { }

	// RVA: 0x1428960 Offset: 0x1426F60 VA: 0x181428960 Slot: 33
	public override int GetValues(object[] values) { }

	// RVA: 0x1428A50 Offset: 0x1427050 VA: 0x181428A50 Slot: 34
	public override bool IsDBNull(int i) { }

	// RVA: 0x1428BB0 Offset: 0x14271B0 VA: 0x181428BB0 Slot: 35
	public override bool NextResult() { }

	// RVA: 0x1425DD0 Offset: 0x14243D0 VA: 0x181425DD0
	private SQLiteType GetSQLiteType(int i) { }

	// RVA: 0x1428EB0 Offset: 0x14274B0 VA: 0x181428EB0 Slot: 36
	public override bool Read() { }

	// RVA: 0x14291D0 Offset: 0x14277D0 VA: 0x1814291D0 Slot: 18
	public override int get_RecordsAffected() { }

	// RVA: 0x14291B0 Offset: 0x14277B0 VA: 0x1814291B0 Slot: 20
	public override object get_Item(int i) { }

	// RVA: 0x1428AF0 Offset: 0x14270F0 VA: 0x181428AF0
	private void LoadKeyInfo() { }

	// RVA: 0x1429080 Offset: 0x1427680 VA: 0x181429080
	private static void .cctor() { }

}

internal class SQLiteEnlistment : IEnlistmentNotification // TypeDefIndex: 4877
{	// Fields
	internal SqliteTransaction _transaction; // 0x10
	internal Transaction _scope; // 0x18
	internal bool _disposeConnection; // 0x20

	// Methods

	// RVA: 0x140EBE0 Offset: 0x140D1E0 VA: 0x18140EBE0
	internal void .ctor(SqliteConnection cnn, Transaction scope) { }

	// RVA: 0x140EA60 Offset: 0x140D060 VA: 0x18140EA60
	private void Cleanup(SqliteConnection cnn) { }

	// RVA: 0x140EAB0 Offset: 0x140D0B0 VA: 0x18140EAB0 Slot: 4
	public void Rollback(Enlistment enlistment) { }

}

public sealed class SqliteException : DbException // TypeDefIndex: 4878
{	// Fields
	private SQLiteErrorCode _errorCode; // 0x88
	private static string[] _errorMessages; // 0x0

	// Methods

	// RVA: 0x21F1D30 Offset: 0x21F0330 VA: 0x1821F1D30
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x21F1D50 Offset: 0x21F0350 VA: 0x1821F1D50
	public void .ctor(int errorCode, string extendedInformation) { }

	// RVA: 0x21F1ED0 Offset: 0x21F04D0 VA: 0x1821F1ED0
	public void .ctor() { }

	// RVA: 0x21F1110 Offset: 0x21EF710 VA: 0x1821F1110
	private static string GetStockErrorMessage(int errorCode, string errorMessage) { }

	// RVA: 0x21F1210 Offset: 0x21EF810 VA: 0x1821F1210
	private static void .cctor() { }

}

public enum SQLiteErrorCode // TypeDefIndex: 4879
{	// Fields
	public int value__; // 0x0
	public const SQLiteErrorCode Ok = 0;
	public const SQLiteErrorCode Error = 1;
	public const SQLiteErrorCode Internal = 2;
	public const SQLiteErrorCode Perm = 3;
	public const SQLiteErrorCode Abort = 4;
	public const SQLiteErrorCode Busy = 5;
	public const SQLiteErrorCode Locked = 6;
	public const SQLiteErrorCode NoMem = 7;
	public const SQLiteErrorCode ReadOnly = 8;
	public const SQLiteErrorCode Interrupt = 9;
	public const SQLiteErrorCode IOErr = 10;
	public const SQLiteErrorCode Corrupt = 11;
	public const SQLiteErrorCode NotFound = 12;
	public const SQLiteErrorCode Full = 13;
	public const SQLiteErrorCode CantOpen = 14;
	public const SQLiteErrorCode Protocol = 15;
	public const SQLiteErrorCode Empty = 16;
	public const SQLiteErrorCode Schema = 17;
	public const SQLiteErrorCode TooBig = 18;
	public const SQLiteErrorCode Constraint = 19;
	public const SQLiteErrorCode Mismatch = 20;
	public const SQLiteErrorCode Misuse = 21;
	public const SQLiteErrorCode NOLFS = 22;
	public const SQLiteErrorCode Auth = 23;
	public const SQLiteErrorCode Format = 24;
	public const SQLiteErrorCode Range = 25;
	public const SQLiteErrorCode NotADatabase = 26;
	public const SQLiteErrorCode Row = 100;
	public const SQLiteErrorCode Done = 101;

}

public abstract class SqliteFunction // TypeDefIndex: 4880
{	// Fields
	internal SQLiteBase _base; // 0x10
	private Dictionary<long, SqliteFunction.AggregateData> _contextDataList; // 0x18
	private SQLiteCallback _InvokeFunc; // 0x20
	private SQLiteCallback _StepFunc; // 0x28
	private SQLiteFinalCallback _FinalFunc; // 0x30
	private SQLiteCollation _CompareFunc; // 0x38
	private SQLiteCollation _CompareFunc16; // 0x40
	internal IntPtr _context; // 0x48
	private static List<SqliteFunctionAttribute> _registeredFunctions; // 0x0

	// Methods

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 4
	public virtual object Invoke(object[] args) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public virtual void Step(object[] args, int stepNumber, ref object contextData) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	public virtual object Final(object contextData) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 7
	public virtual int Compare(string param1, string param2) { }

	// RVA: 0x21F2970 Offset: 0x21F0F70 VA: 0x1821F2970
	internal object[] ConvertParams(int nArgs, IntPtr argsptr) { }

	// RVA: 0x21F3050 Offset: 0x21F1650 VA: 0x1821F3050
	private void SetReturnValue(IntPtr context, object returnValue) { }

	// RVA: 0x21F2FF0 Offset: 0x21F15F0 VA: 0x1821F2FF0
	internal void ScalarCallback(IntPtr context, int nArgs, IntPtr argsptr) { }

	// RVA: 0x21F28D0 Offset: 0x21F0ED0 VA: 0x1821F28D0
	internal int CompareCallback(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2) { }

	// RVA: 0x21F2870 Offset: 0x21F0E70 VA: 0x1821F2870
	internal int CompareCallback16(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2) { }

	// RVA: 0x21F3400 Offset: 0x21F1A00 VA: 0x1821F3400
	internal void StepCallback(IntPtr context, int nArgs, IntPtr argsptr) { }

	// RVA: 0x21F2EC0 Offset: 0x21F14C0 VA: 0x1821F2EC0
	internal void FinalCallback(IntPtr context) { }

	// RVA: 0x21F35A0 Offset: 0x21F1BA0 VA: 0x1821F35A0
	private static void .cctor() { }

	// RVA: 0x21F2410 Offset: 0x21F0A10 VA: 0x1821F2410
	internal static SqliteFunction[] BindFunctions(SQLiteBase sqlbase) { }

}

private class SqliteFunction.AggregateData // TypeDefIndex: 4881
{	// Fields
	internal int _count; // 0x10
	internal object _data; // 0x18

	// Methods

	// RVA: 0x1076AE0 Offset: 0x10750E0 VA: 0x181076AE0
	public void .ctor() { }

}

internal sealed class SQLiteCallback : MulticastDelegate // TypeDefIndex: 4884
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140DEC0 Offset: 0x140C4C0 VA: 0x18140DEC0 Slot: 12
	public virtual void Invoke(IntPtr context, int nArgs, IntPtr argsptr) { }

	// RVA: 0x140DE20 Offset: 0x140C420 VA: 0x18140DE20 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr context, int nArgs, IntPtr argsptr, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteFinalCallback : MulticastDelegate // TypeDefIndex: 4885
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140ED30 Offset: 0x140D330 VA: 0x18140ED30 Slot: 12
	public virtual void Invoke(IntPtr context) { }

	// RVA: 0x140ECB0 Offset: 0x140D2B0 VA: 0x18140ECB0 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr context, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteCollation : MulticastDelegate // TypeDefIndex: 4886
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140E300 Offset: 0x140C900 VA: 0x18140E300 Slot: 12
	public virtual int Invoke(IntPtr puser, int len1, IntPtr pv1, int len2, IntPtr pv2) { }

	// RVA: 0x140E220 Offset: 0x140C820 VA: 0x18140E220 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr puser, int len1, IntPtr pv1, int len2, IntPtr pv2, AsyncCallback callback, object object) { }

	// RVA: 0xB9A710 Offset: 0xB98D10 VA: 0x180B9A710 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

public sealed class SqliteFunctionAttribute : Attribute // TypeDefIndex: 4887
{	// Fields
	private string _name; // 0x10
	private int _arguments; // 0x18
	private FunctionType _functionType; // 0x1C
	internal Type _instanceType; // 0x20

	// Properties
	public string Name { get; }
	public int Arguments { get; }
	public FunctionType FuncType { get; }

	// Methods

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Name() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_Arguments() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460
	public FunctionType get_FuncType() { }

}

internal sealed class SqliteKeyReader : IDisposable // TypeDefIndex: 4888
{	// Fields
	private SqliteKeyReader.KeyInfo[] _keyInfo; // 0x10
	private SqliteStatement _stmt; // 0x18
	private bool _isValid; // 0x20

	// Properties
	internal int Count { get; }

	// Methods

	// RVA: 0x21F51A0 Offset: 0x21F37A0 VA: 0x1821F51A0
	internal void .ctor(SqliteConnection cnn, SqliteDataReader reader, SqliteStatement stmt) { }

	// RVA: 0xD86ED0 Offset: 0xD854D0 VA: 0x180D86ED0
	internal int get_Count() { }

	// RVA: 0x21F5100 Offset: 0x21F3700 VA: 0x1821F5100
	internal void Sync(int i) { }

	// RVA: 0x21F5010 Offset: 0x21F3610 VA: 0x1821F5010
	internal void Sync() { }

	// RVA: 0x21F4F40 Offset: 0x21F3540 VA: 0x1821F4F40
	internal void Reset() { }

	// RVA: 0x21F43F0 Offset: 0x21F29F0 VA: 0x1821F43F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x21F4560 Offset: 0x21F2B60 VA: 0x1821F4560
	internal string GetDataTypeName(int i) { }

	// RVA: 0x21F4610 Offset: 0x21F2C10 VA: 0x1821F4610
	internal Type GetFieldType(int i) { }

	// RVA: 0x21F4940 Offset: 0x21F2F40 VA: 0x1821F4940
	internal string GetName(int i) { }

	// RVA: 0x21F4490 Offset: 0x21F2A90 VA: 0x1821F4490
	internal bool GetBoolean(int i) { }

	// RVA: 0x21F46E0 Offset: 0x21F2CE0 VA: 0x1821F46E0
	internal int GetInt32(int i) { }

	// RVA: 0x21F4810 Offset: 0x21F2E10 VA: 0x1821F4810
	internal long GetInt64(int i) { }

	// RVA: 0x21F4980 Offset: 0x21F2F80 VA: 0x1821F4980
	internal string GetString(int i) { }

	// RVA: 0x21F4A50 Offset: 0x21F3050 VA: 0x1821F4A50
	internal object GetValue(int i) { }

	// RVA: 0x21F4DE0 Offset: 0x21F33E0 VA: 0x1821F4DE0
	internal bool IsDBNull(int i) { }

	// RVA: 0x21F39E0 Offset: 0x21F1FE0 VA: 0x1821F39E0
	internal void AppendSchemaTable(DataTable tbl) { }

}

private struct SqliteKeyReader.KeyInfo // TypeDefIndex: 4889
{	// Fields
	internal string databaseName; // 0x0
	internal string tableName; // 0x8
	internal string columnName; // 0x10
	internal int database; // 0x18
	internal int rootPage; // 0x1C
	internal int cursor; // 0x20
	internal SqliteKeyReader.KeyQuery query; // 0x28
	internal int column; // 0x30

}

private sealed class SqliteKeyReader.KeyQuery : IDisposable // TypeDefIndex: 4890
{	// Fields
	private SqliteCommand _command; // 0x10
	internal SqliteDataReader _reader; // 0x18

	// Properties
	internal bool IsValid { set; }

	// Methods

	// RVA: 0x21F0D60 Offset: 0x21EF360 VA: 0x1821F0D60
	internal void .ctor(SqliteConnection cnn, string database, string table, string[] columns) { }

	// RVA: 0x21F1080 Offset: 0x21EF680 VA: 0x1821F1080
	internal void set_IsValid(bool value) { }

	// RVA: 0x21F0C00 Offset: 0x21EF200 VA: 0x1821F0C00
	internal void Sync(long rowid) { }

	// RVA: 0x21F0B80 Offset: 0x21EF180 VA: 0x1821F0B80 Slot: 4
	public void Dispose() { }

}

public sealed class SqliteParameter : DbParameter, ICloneable // TypeDefIndex: 4891
{	// Fields
	internal int _dbType; // 0x18
	private DataRowVersion _rowVersion; // 0x1C
	private object _objValue; // 0x20
	private string _sourceColumn; // 0x28
	private string _parameterName; // 0x30
	private int _dataSize; // 0x38
	private bool _nullable; // 0x3C
	private bool _nullMapping; // 0x3D

	// Properties
	public override bool IsNullable { get; set; }
	[RefreshPropertiesAttribute] // RVA: 0xE0AC0 Offset: 0xDFEC0 VA: 0x1800E0AC0
	[DbProviderSpecificTypePropertyAttribute] // RVA: 0xE0AC0 Offset: 0xDFEC0 VA: 0x1800E0AC0
	public override DbType DbType { get; set; }
	public override ParameterDirection Direction { get; set; }
	public override string ParameterName { get; set; }
	[DefaultValueAttribute] // RVA: 0xE0C60 Offset: 0xE0060 VA: 0x1800E0C60
	public override int Size { set; }
	public override string SourceColumn { get; set; }
	public override bool SourceColumnNullMapping { set; }
	public override DataRowVersion SourceVersion { get; set; }
	[TypeConverterAttribute] // RVA: 0xE0C80 Offset: 0xE0080 VA: 0x1800E0C80
	[RefreshPropertiesAttribute] // RVA: 0xE0C80 Offset: 0xE0080 VA: 0x1800E0C80
	public override object Value { get; set; }

	// Methods

	// RVA: 0x21F7A60 Offset: 0x21F6060 VA: 0x1821F7A60
	public void .ctor() { }

	// RVA: 0x21F7DE0 Offset: 0x21F63E0 VA: 0x1821F7DE0
	public void .ctor(string parameterName, object value) { }

	// RVA: 0x21F7D50 Offset: 0x21F6350 VA: 0x1821F7D50
	public void .ctor(string parameterName, DbType parameterType, int parameterSize, string sourceColumn, DataRowVersion rowVersion) { }

	// RVA: 0x21F7BB0 Offset: 0x21F61B0 VA: 0x1821F7BB0
	private void .ctor(SqliteParameter source) { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x21F7AD0 Offset: 0x21F60D0 VA: 0x1821F7AD0
	public void .ctor(string parameterName, DbType parameterType, int parameterSize, ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, DataRowVersion rowVersion, object value) { }

	// RVA: 0xC659E0 Offset: 0xC63FE0 VA: 0x180C659E0 Slot: 10
	public override bool get_IsNullable() { }

	// RVA: 0xE72CA0 Offset: 0xE712A0 VA: 0x180E72CA0 Slot: 11
	public override void set_IsNullable(bool value) { }

	// RVA: 0x21F7E70 Offset: 0x21F6470 VA: 0x1821F7E70 Slot: 6
	public override DbType get_DbType() { }

	// RVA: 0x7D0C80 Offset: 0x7CF280 VA: 0x1807D0C80 Slot: 7
	public override void set_DbType(DbType value) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 8
	public override ParameterDirection get_Direction() { }

	// RVA: 0x21F7F40 Offset: 0x21F6540 VA: 0x1821F7F40 Slot: 9
	public override void set_Direction(ParameterDirection value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 12
	public override string get_ParameterName() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080 Slot: 13
	public override void set_ParameterName(string value) { }

	// RVA: 0xC74910 Offset: 0xC72F10 VA: 0x180C74910 Slot: 14
	public override void set_Size(int value) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 15
	public override string get_SourceColumn() { }

	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340 Slot: 16
	public override void set_SourceColumn(string value) { }

	// RVA: 0x21F7FA0 Offset: 0x21F65A0 VA: 0x1821F7FA0 Slot: 17
	public override void set_SourceColumnNullMapping(bool value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460 Slot: 18
	public override DataRowVersion get_SourceVersion() { }

	// RVA: 0x95F9F0 Offset: 0x95DFF0 VA: 0x18095F9F0 Slot: 19
	public override void set_SourceVersion(DataRowVersion value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 20
	public override object get_Value() { }

	// RVA: 0x21F7FB0 Offset: 0x21F65B0 VA: 0x1821F7FB0 Slot: 21
	public override void set_Value(object value) { }

	// RVA: 0x21F7890 Offset: 0x21F5E90 VA: 0x1821F7890 Slot: 22
	public object Clone() { }

}

public sealed class SqliteParameterCollection : DbParameterCollection // TypeDefIndex: 4892
{	// Fields
	private SqliteCommand _command; // 0x18
	private List<SqliteParameter> _parameterList; // 0x20
	private bool _unboundFlag; // 0x28

	// Properties
	public override bool IsFixedSize { get; }
	public override bool IsReadOnly { get; }
	public override object SyncRoot { get; }
	public override int Count { get; }
	public SqliteParameter Item { get; }

	// Methods

	// RVA: 0x21F7760 Offset: 0x21F5D60 VA: 0x1821F7760
	internal void .ctor(SqliteCommand cmd) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 22
	public override bool get_IsFixedSize() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 23
	public override bool get_IsReadOnly() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 24
	public override object get_SyncRoot() { }

	// RVA: 0x21F6F00 Offset: 0x21F5500 VA: 0x1821F6F00 Slot: 29
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x21F6D00 Offset: 0x21F5300 VA: 0x1821F6D00
	public int Add(SqliteParameter parameter) { }

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	// RVA: 0x21F6C90 Offset: 0x21F5290 VA: 0x1821F6C90 Slot: 25
	public override int Add(object value) { }

	// RVA: 0x21F6BB0 Offset: 0x21F51B0 VA: 0x1821F6BB0
	public SqliteParameter AddWithValue(string parameterName, object value) { }

	// RVA: 0x21F6DE0 Offset: 0x21F53E0 VA: 0x1821F6DE0 Slot: 28
	public override void Clear() { }

	// RVA: 0x21F6E30 Offset: 0x21F5430 VA: 0x1821F6E30 Slot: 26
	public override bool Contains(object value) { }

	// RVA: 0x21F6EB0 Offset: 0x21F54B0 VA: 0x1821F6EB0 Slot: 27
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x21F77E0 Offset: 0x21F5DE0 VA: 0x1821F77E0 Slot: 21
	public override int get_Count() { }

	// RVA: 0x21F7820 Offset: 0x21F5E20 VA: 0x1821F7820
	public SqliteParameter get_Item(int index) { }

	// RVA: 0x21F6F80 Offset: 0x21F5580 VA: 0x1821F6F80 Slot: 30
	protected override DbParameter GetParameter(int index) { }

	// RVA: 0x21F6FE0 Offset: 0x21F55E0 VA: 0x1821F6FE0 Slot: 32
	public override int IndexOf(string parameterName) { }

	// RVA: 0x21F7120 Offset: 0x21F5720 VA: 0x1821F7120 Slot: 31
	public override int IndexOf(object value) { }

	// RVA: 0x21F71A0 Offset: 0x21F57A0 VA: 0x1821F71A0 Slot: 33
	public override void Insert(int index, object value) { }

	// RVA: 0x21F7650 Offset: 0x21F5C50 VA: 0x1821F7650 Slot: 34
	public override void Remove(object value) { }

	// RVA: 0x21F75F0 Offset: 0x21F5BF0 VA: 0x1821F75F0 Slot: 35
	public override void RemoveAt(int index) { }

	// RVA: 0x21F76D0 Offset: 0x21F5CD0 VA: 0x1821F76D0 Slot: 36
	protected override void SetParameter(int index, DbParameter value) { }

	// RVA: 0x4A04D0 Offset: 0x49EAD0 VA: 0x1804A04D0
	internal void Unbind() { }

	// RVA: 0x21F7230 Offset: 0x21F5830 VA: 0x1821F7230
	internal void MapParameters(SqliteStatement activeStatement) { }

}

internal sealed class SqliteStatement : IDisposable // TypeDefIndex: 4893
{	// Fields
	internal SQLiteBase _sql; // 0x10
	internal string _sqlStatement; // 0x18
	internal SqliteStatementHandle _sqlite_stmt; // 0x20
	internal int _unnamedParameters; // 0x28
	internal string[] _paramNames; // 0x30
	internal SqliteParameter[] _paramValues; // 0x38
	internal SqliteCommand _command; // 0x40
	private string[] _types; // 0x48

	// Properties
	internal string[] TypeDefinitions { get; }

	// Methods

	// RVA: 0x21F8D60 Offset: 0x21F7360 VA: 0x1821F8D60
	internal void .ctor(SQLiteBase sqlbase, SqliteStatementHandle stmt, string strCommand, SqliteStatement previous) { }

	// RVA: 0x21F8900 Offset: 0x21F6F00 VA: 0x1821F8900
	internal bool MapParameter(string s, SqliteParameter p) { }

	// RVA: 0x21F8880 Offset: 0x21F6E80 VA: 0x1821F8880 Slot: 4
	public void Dispose() { }

	// RVA: 0x21F8800 Offset: 0x21F6E00 VA: 0x1821F8800
	internal void BindParameters() { }

	// RVA: 0x21F8250 Offset: 0x21F6850 VA: 0x1821F8250
	private void BindParameter(int index, SqliteParameter param) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal string[] get_TypeDefinitions() { }

	// RVA: 0x21F8B10 Offset: 0x21F7110 VA: 0x1821F8B10
	internal void SetTypes(string typedefs) { }

}

public sealed class SqliteTransaction : DbTransaction // TypeDefIndex: 4894
{	// Fields
	internal SqliteConnection _cnn; // 0x18
	internal long _version; // 0x20
	private IsolationLevel _level; // 0x28

	// Properties
	public SqliteConnection Connection { get; }

	// Methods

	// RVA: 0x21F9500 Offset: 0x21F7B00 VA: 0x1821F9500
	internal void .ctor(SqliteConnection connection, bool deferredLock) { }

	// RVA: 0x21F8FB0 Offset: 0x21F75B0 VA: 0x1821F8FB0 Slot: 7
	public override void Commit() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public SqliteConnection get_Connection() { }

	// RVA: 0x21F9100 Offset: 0x21F7700 VA: 0x1821F9100 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x21F94B0 Offset: 0x21F7AB0 VA: 0x1821F94B0 Slot: 9
	public override void Rollback() { }

	// RVA: 0x21F93A0 Offset: 0x21F79A0 VA: 0x1821F93A0
	internal static void IssueRollback(SqliteConnection cnn) { }

	// RVA: 0x21F9240 Offset: 0x21F7840 VA: 0x1821F9240
	internal bool IsValid(bool throwError) { }

}

internal class SqliteConnectionHandle : CriticalHandle // TypeDefIndex: 4897
{	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x691E10 Offset: 0x690410 VA: 0x180691E10
	public static IntPtr op_Implicit(SqliteConnectionHandle db) { }

	// RVA: 0x1411E10 Offset: 0x1410410 VA: 0x181411E10
	public static SqliteConnectionHandle op_Implicit(IntPtr db) { }

	// RVA: 0x1411D80 Offset: 0x1410380 VA: 0x181411D80
	private void .ctor(IntPtr db) { }

	// RVA: 0x1411D40 Offset: 0x1410340 VA: 0x181411D40
	internal void .ctor() { }

	// RVA: 0x1411CD0 Offset: 0x14102D0 VA: 0x181411CD0 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x1411DD0 Offset: 0x14103D0 VA: 0x181411DD0 Slot: 5
	public override bool get_IsInvalid() { }

}

internal class SqliteStatementHandle : CriticalHandle // TypeDefIndex: 4898
{	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x691E10 Offset: 0x690410 VA: 0x180691E10
	public static IntPtr op_Implicit(SqliteStatementHandle stmt) { }

	// RVA: 0x21F81D0 Offset: 0x21F67D0 VA: 0x1821F81D0
	public static SqliteStatementHandle op_Implicit(IntPtr stmt) { }

	// RVA: 0x21F8100 Offset: 0x21F6700 VA: 0x1821F8100
	private void .ctor(IntPtr stmt) { }

	// RVA: 0x21F8150 Offset: 0x21F6750 VA: 0x1821F8150
	internal void .ctor() { }

	// RVA: 0x21F8090 Offset: 0x21F6690 VA: 0x1821F8090 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x21F8190 Offset: 0x21F6790 VA: 0x1821F8190 Slot: 5
	public override bool get_IsInvalid() { }

}

public class SqliteException : Exception // TypeDefIndex: 7360
{	// Methods

	// RVA: 0x231EEE0 Offset: 0x231D4E0 VA: 0x18231EEE0
	public void .ctor(string message) { }

}

