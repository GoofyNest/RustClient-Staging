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

	// RVA: 0x141E820 Offset: 0x141CE20 VA: 0x18141E820
	public void .ctor() { }

	// RVA: 0x141E780 Offset: 0x141CD80 VA: 0x18141E780
	public void .ctor(string connectionString) { }

	// RVA: 0x141E8E0 Offset: 0x141CEE0 VA: 0x18141E8E0
	public void .ctor(SqliteConnection connection) { }

	// RVA: 0x1412B50 Offset: 0x1411150 VA: 0x181412B50 Slot: 22
	public object Clone() { }

	// RVA: 0x1412EC0 Offset: 0x14114C0 VA: 0x181412EC0 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1413F30 Offset: 0x1412530 VA: 0x181413F30
	internal void OnStateChange(ConnectionState newState) { }

	// RVA: 0x1412AE0 Offset: 0x14110E0 VA: 0x181412AE0
	public SqliteTransaction BeginTransaction() { }

	// RVA: 0x14129F0 Offset: 0x1410FF0 VA: 0x1814129F0 Slot: 15
	protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel) { }

	// RVA: 0x1412BB0 Offset: 0x14111B0 VA: 0x181412BB0 Slot: 16
	public override void Close() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 12
	public override string get_ConnectionString() { }

	// RVA: 0x141EDF0 Offset: 0x141D3F0 VA: 0x18141EDF0 Slot: 13
	public override void set_ConnectionString(string value) { }

	// RVA: 0x1412DA0 Offset: 0x14113A0 VA: 0x181412DA0
	public SqliteCommand CreateCommand() { }

	// RVA: 0x1412EB0 Offset: 0x14114B0 VA: 0x181412EB0 Slot: 17
	protected override DbCommand CreateDbCommand() { }

	// RVA: 0x1413BA0 Offset: 0x14121A0 VA: 0x181413BA0
	internal static void MapMonoKeyword(string[] arPiece, SortedList<string, string> ls) { }

	// RVA: 0x1413D90 Offset: 0x1412390 VA: 0x181413D90
	internal static string MapMonoUriPath(string path) { }

	// RVA: 0x1413E60 Offset: 0x1412460 VA: 0x181413E60
	internal static string MapUriPath(string path) { }

	// RVA: 0x14156A0 Offset: 0x1413CA0 VA: 0x1814156A0
	internal static SortedList<string, string> ParseConnectionString(string connectionString) { }

	// RVA: 0x1412F20 Offset: 0x1411520 VA: 0x181412F20 Slot: 18
	public override void EnlistTransaction(Transaction transaction) { }

	// RVA: 0x1413310 Offset: 0x1411910 VA: 0x181413310
	internal static string FindKey(SortedList<string, string> items, string key, string defValue) { }

	// RVA: 0x1413FD0 Offset: 0x14125D0 VA: 0x181413FD0 Slot: 21
	public override void Open() { }

	// RVA: 0x5743B0 Offset: 0x5729B0 VA: 0x1805743B0
	public int get_DefaultTimeout() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600 Slot: 14
	public override ConnectionState get_State() { }

	// RVA: 0x14130D0 Offset: 0x14116D0 VA: 0x1814130D0
	private string ExpandFileName(string sourceFile) { }

	// RVA: 0x1413B40 Offset: 0x1412140 VA: 0x181413B40 Slot: 19
	public override DataTable GetSchema(string collectionName) { }

	// RVA: 0x1413390 Offset: 0x1411990 VA: 0x181413390 Slot: 20
	public override DataTable GetSchema(string collectionName, string[] restrictionValues) { }

	// RVA: 0x141BC70 Offset: 0x141A270 VA: 0x18141BC70
	private static DataTable Schema_ReservedWords() { }

	// RVA: 0x141BA60 Offset: 0x141A060 VA: 0x18141BA60
	private static DataTable Schema_MetaDataCollections() { }

	// RVA: 0x1417050 Offset: 0x1415650 VA: 0x181417050
	private DataTable Schema_DataSourceInformation() { }

	// RVA: 0x1415D30 Offset: 0x1414330 VA: 0x181415D30
	private DataTable Schema_Columns(string strCatalog, string strTable, string strColumn) { }

	// RVA: 0x141A340 Offset: 0x1418940 VA: 0x18141A340
	private DataTable Schema_Indexes(string strCatalog, string strTable, string strIndex) { }

	// RVA: 0x141C600 Offset: 0x141AC00 VA: 0x18141C600
	private DataTable Schema_Triggers(string catalog, string table, string triggerName) { }

	// RVA: 0x141BF20 Offset: 0x141A520 VA: 0x18141BF20
	private DataTable Schema_Tables(string strCatalog, string strTable, string strType) { }

	// RVA: 0x141E060 Offset: 0x141C660 VA: 0x18141E060
	private DataTable Schema_Views(string strCatalog, string strView) { }

	// RVA: 0x1415900 Offset: 0x1413F00 VA: 0x181415900
	private DataTable Schema_Catalogs(string strCatalog) { }

	// RVA: 0x1417CC0 Offset: 0x14162C0 VA: 0x181417CC0
	private DataTable Schema_DataTypes() { }

	// RVA: 0x1418F90 Offset: 0x1417590 VA: 0x181418F90
	private DataTable Schema_IndexColumns(string strCatalog, string strTable, string strIndex, string strColumn) { }

	// RVA: 0x141CBB0 Offset: 0x141B1B0 VA: 0x18141CBB0
	private DataTable Schema_ViewColumns(string strCatalog, string strView, string strColumn) { }

	// RVA: 0x1418260 Offset: 0x1416860 VA: 0x181418260
	private DataTable Schema_ForeignKeys(string strCatalog, string strTable, string strKeyName) { }

}

public sealed class SqliteFactory : DbProviderFactory, IServiceProvider // TypeDefIndex: 4853
{	// Fields
	private static Type _dbProviderServicesType; // 0x0
	private static object _sqliteServices; // 0x8
	public static readonly SqliteFactory Instance; // 0x10

	// Methods

	// RVA: 0x21F2600 Offset: 0x21F0C00 VA: 0x1821F2600
	private static void .cctor() { }

	// RVA: 0x21F2340 Offset: 0x21F0940 VA: 0x1821F2340 Slot: 4
	private object System.IServiceProvider.GetService(Type serviceType) { }

	// RVA: 0x21F21A0 Offset: 0x21F07A0 VA: 0x1821F21A0
	private object GetSQLiteProviderServicesInstance() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
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

	// RVA: 0x140D800 Offset: 0x140BE00 VA: 0x18140D800
	internal void .ctor(SQLiteDateFormats fmt) { }

	// RVA: 0x140AA90 Offset: 0x1409090 VA: 0x18140AA90 Slot: 61
	protected override void Dispose(bool bDisposing) { }

	// RVA: 0x1409ED0 Offset: 0x14084D0 VA: 0x181409ED0 Slot: 9
	internal override void Close() { }

	// RVA: 0x140D910 Offset: 0x140BF10 VA: 0x18140D910 Slot: 6
	internal override string get_Version() { }

	// RVA: 0x140D910 Offset: 0x140BF10 VA: 0x18140D910
	internal static string get_SQLiteVersion() { }

	// RVA: 0x140D8A0 Offset: 0x140BEA0 VA: 0x18140D8A0 Slot: 7
	internal override int get_Changes() { }

	// RVA: 0x140B750 Offset: 0x1409D50 VA: 0x18140B750 Slot: 8
	internal override void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool) { }

	// RVA: 0x140C9A0 Offset: 0x140AFA0 VA: 0x18140C9A0 Slot: 10
	internal override void SetTimeout(int nTimeoutMS) { }

	// RVA: 0x140CAF0 Offset: 0x140B0F0 VA: 0x18140CAF0 Slot: 13
	internal override bool Step(SqliteStatement stmt) { }

	// RVA: 0x140C170 Offset: 0x140A770 VA: 0x18140C170 Slot: 14
	internal override int Reset(SqliteStatement stmt) { }

	// RVA: 0x140C6F0 Offset: 0x140ACF0 VA: 0x18140C6F0 Slot: 11
	internal override string SQLiteLastError() { }

	// RVA: 0x140B9F0 Offset: 0x1409FF0 VA: 0x18140B9F0 Slot: 12
	internal override SqliteStatement Prepare(SqliteConnection cnn, string strSql, SqliteStatement previous, uint timeoutMS, out string strRemain) { }

	// RVA: 0x14098B0 Offset: 0x1407EB0 VA: 0x1814098B0 Slot: 15
	internal override void Bind_Double(SqliteStatement stmt, int index, double value) { }

	// RVA: 0x14099A0 Offset: 0x1407FA0 VA: 0x1814099A0 Slot: 16
	internal override void Bind_Int32(SqliteStatement stmt, int index, int value) { }

	// RVA: 0x1409A90 Offset: 0x1408090 VA: 0x181409A90 Slot: 17
	internal override void Bind_Int64(SqliteStatement stmt, int index, long value) { }

	// RVA: 0x1409D80 Offset: 0x1408380 VA: 0x181409D80 Slot: 18
	internal override void Bind_Text(SqliteStatement stmt, int index, string value) { }

	// RVA: 0x1409740 Offset: 0x1407D40 VA: 0x181409740 Slot: 20
	internal override void Bind_DateTime(SqliteStatement stmt, int index, DateTime dt) { }

	// RVA: 0x1409620 Offset: 0x1407C20 VA: 0x181409620 Slot: 19
	internal override void Bind_Blob(SqliteStatement stmt, int index, byte[] blobData) { }

	// RVA: 0x1409B80 Offset: 0x1408180 VA: 0x181409B80 Slot: 21
	internal override void Bind_Null(SqliteStatement stmt, int index) { }

	// RVA: 0x1409C60 Offset: 0x1408260 VA: 0x181409C60 Slot: 22
	internal override int Bind_ParamCount(SqliteStatement stmt) { }

	// RVA: 0x1409CD0 Offset: 0x14082D0 VA: 0x181409CD0 Slot: 23
	internal override string Bind_ParamName(SqliteStatement stmt, int index) { }

	// RVA: 0x140A030 Offset: 0x1408630 VA: 0x18140A030 Slot: 24
	internal override int ColumnCount(SqliteStatement stmt) { }

	// RVA: 0x140A380 Offset: 0x1408980 VA: 0x18140A380 Slot: 25
	internal override string ColumnName(SqliteStatement stmt, int index) { }

	// RVA: 0x1409FB0 Offset: 0x14085B0 VA: 0x181409FB0 Slot: 26
	internal override TypeAffinity ColumnAffinity(SqliteStatement stmt, int index) { }

	// RVA: 0x140A590 Offset: 0x1408B90 VA: 0x18140A590 Slot: 27
	internal override string ColumnType(SqliteStatement stmt, int index, out TypeAffinity nAffinity) { }

	// RVA: 0x140A430 Offset: 0x1408A30 VA: 0x18140A430 Slot: 28
	internal override string ColumnOriginalName(SqliteStatement stmt, int index) { }

	// RVA: 0x140A0A0 Offset: 0x14086A0 VA: 0x18140A0A0 Slot: 29
	internal override string ColumnDatabaseName(SqliteStatement stmt, int index) { }

	// RVA: 0x140A4E0 Offset: 0x1408AE0 VA: 0x18140A4E0 Slot: 30
	internal override string ColumnTableName(SqliteStatement stmt, int index) { }

	// RVA: 0x140A150 Offset: 0x1408750 VA: 0x18140A150 Slot: 31
	internal override void ColumnMetaData(string dataBase, string table, string column, out string dataType, out string collateSequence, out bool notNull, out bool primaryKey, out bool autoIncrement) { }

	// RVA: 0x140ACC0 Offset: 0x14092C0 VA: 0x18140ACC0 Slot: 33
	internal override double GetDouble(SqliteStatement stmt, int index) { }

	// RVA: 0x140ADA0 Offset: 0x14093A0 VA: 0x18140ADA0 Slot: 34
	internal override int GetInt32(SqliteStatement stmt, int index) { }

	// RVA: 0x140AE20 Offset: 0x1409420 VA: 0x18140AE20 Slot: 35
	internal override long GetInt64(SqliteStatement stmt, int index) { }

	// RVA: 0x140B170 Offset: 0x1409770 VA: 0x18140B170 Slot: 36
	internal override string GetText(SqliteStatement stmt, int index) { }

	// RVA: 0x140AC10 Offset: 0x1409210 VA: 0x18140AC10 Slot: 38
	internal override DateTime GetDateTime(SqliteStatement stmt, int index) { }

	// RVA: 0x140AAB0 Offset: 0x14090B0 VA: 0x18140AAB0 Slot: 37
	internal override long GetBytes(SqliteStatement stmt, int index, int nDataOffset, byte[] bDest, int nStart, int nLength) { }

	// RVA: 0x140B730 Offset: 0x1409D30 VA: 0x18140B730 Slot: 39
	internal override bool IsNull(SqliteStatement stmt, int index) { }

	// RVA: 0x140A890 Offset: 0x1408E90 VA: 0x18140A890 Slot: 41
	internal override void CreateFunction(string strFunction, int nArgs, bool needCollSeq, SQLiteCallback func, SQLiteCallback funcstep, SQLiteFinalCallback funcfinal) { }

	// RVA: 0x140A6E0 Offset: 0x1408CE0 VA: 0x18140A6E0 Slot: 40
	internal override void CreateCollation(string strCollation, SQLiteCollation func, SQLiteCollation func16, IntPtr user_data) { }

	// RVA: 0x140AEA0 Offset: 0x14094A0 VA: 0x18140AEA0 Slot: 43
	internal override long GetParamValueBytes(IntPtr p, int nDataOffset, byte[] bDest, int nStart, int nLength) { }

	// RVA: 0x140AFC0 Offset: 0x14095C0 VA: 0x18140AFC0 Slot: 44
	internal override double GetParamValueDouble(IntPtr ptr) { }

	// RVA: 0x140B020 Offset: 0x1409620 VA: 0x18140B020 Slot: 45
	internal override long GetParamValueInt64(IntPtr ptr) { }

	// RVA: 0x140B080 Offset: 0x1409680 VA: 0x18140B080 Slot: 46
	internal override string GetParamValueText(IntPtr ptr) { }

	// RVA: 0x140B110 Offset: 0x1409710 VA: 0x18140B110 Slot: 47
	internal override TypeAffinity GetParamValueType(IntPtr ptr) { }

	// RVA: 0x140C380 Offset: 0x140A980 VA: 0x18140C380 Slot: 48
	internal override void ReturnBlob(IntPtr context, byte[] value) { }

	// RVA: 0x140C420 Offset: 0x140AA20 VA: 0x18140C420 Slot: 49
	internal override void ReturnDouble(IntPtr context, double value) { }

	// RVA: 0x140C490 Offset: 0x140AA90 VA: 0x18140C490 Slot: 50
	internal override void ReturnError(IntPtr context, string value) { }

	// RVA: 0x140C540 Offset: 0x140AB40 VA: 0x18140C540 Slot: 51
	internal override void ReturnInt64(IntPtr context, long value) { }

	// RVA: 0x140C5B0 Offset: 0x140ABB0 VA: 0x18140C5B0 Slot: 52
	internal override void ReturnNull(IntPtr context) { }

	// RVA: 0x140C610 Offset: 0x140AC10 VA: 0x18140C610 Slot: 53
	internal override void ReturnText(IntPtr context, string value) { }

	// RVA: 0x14095C0 Offset: 0x1407BC0 VA: 0x1814095C0 Slot: 42
	internal override IntPtr AggregateContext(IntPtr context) { }

	// RVA: 0x140C840 Offset: 0x140AE40 VA: 0x18140C840 Slot: 54
	internal override void SetPassword(byte[] passwordBytes) { }

	// RVA: 0x140CA70 Offset: 0x140B070 VA: 0x18140CA70 Slot: 55
	internal override void SetUpdateHook(SQLiteUpdateCallback func) { }

	// RVA: 0x140C7C0 Offset: 0x140ADC0 VA: 0x18140C7C0 Slot: 56
	internal override void SetCommitHook(SQLiteCommitCallback func) { }

	// RVA: 0x140C920 Offset: 0x140AF20 VA: 0x18140C920 Slot: 57
	internal override void SetRollbackHook(SQLiteRollbackCallback func) { }

	// RVA: 0x140B220 Offset: 0x1409820 VA: 0x18140B220 Slot: 60
	internal override object GetValue(SqliteStatement stmt, int index, SQLiteType typ) { }

	// RVA: 0x686A10 Offset: 0x685010 VA: 0x180686A10 Slot: 58
	internal override int GetCursorForTable(SqliteStatement stmt, int db, int rootPage) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 59
	internal override long GetRowIdForCursor(SqliteStatement stmt, int cursor) { }

	// RVA: 0x140AD40 Offset: 0x1409340 VA: 0x18140AD40 Slot: 32
	internal override void GetIndexColumnExtendedInfo(string database, string index, string column, out int sortMode, out int onError, out string collationSequence) { }

}

internal class SQLite3_UTF16 : SQLite3 // TypeDefIndex: 4855
{	// Methods

	// RVA: 0x140D7F0 Offset: 0x140BDF0 VA: 0x18140D7F0
	internal void .ctor(SQLiteDateFormats fmt) { }

	// RVA: 0x140D720 Offset: 0x140BD20 VA: 0x18140D720 Slot: 4
	public override string ToString(IntPtr b, int nbytelen) { }

	// RVA: 0x140D730 Offset: 0x140BD30 VA: 0x18140D730
	public static string UTF16ToString(IntPtr b, int nbytelen) { }

	// RVA: 0x140D430 Offset: 0x140BA30 VA: 0x18140D430 Slot: 8
	internal override void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool) { }

	// RVA: 0x140CD10 Offset: 0x140B310 VA: 0x18140CD10 Slot: 20
	internal override void Bind_DateTime(SqliteStatement stmt, int index, DateTime dt) { }

	// RVA: 0x140CD70 Offset: 0x140B370 VA: 0x18140CD70 Slot: 18
	internal override void Bind_Text(SqliteStatement stmt, int index, string value) { }

	// RVA: 0x140D250 Offset: 0x140B850 VA: 0x18140D250 Slot: 38
	internal override DateTime GetDateTime(SqliteStatement stmt, int index) { }

	// RVA: 0x140CF80 Offset: 0x140B580 VA: 0x18140CF80 Slot: 25
	internal override string ColumnName(SqliteStatement stmt, int index) { }

	// RVA: 0x140D340 Offset: 0x140B940 VA: 0x18140D340 Slot: 36
	internal override string GetText(SqliteStatement stmt, int index) { }

	// RVA: 0x140D070 Offset: 0x140B670 VA: 0x18140D070 Slot: 28
	internal override string ColumnOriginalName(SqliteStatement stmt, int index) { }

	// RVA: 0x140CE90 Offset: 0x140B490 VA: 0x18140CE90 Slot: 29
	internal override string ColumnDatabaseName(SqliteStatement stmt, int index) { }

	// RVA: 0x140D160 Offset: 0x140B760 VA: 0x18140D160 Slot: 30
	internal override string ColumnTableName(SqliteStatement stmt, int index) { }

	// RVA: 0x140D280 Offset: 0x140B880 VA: 0x18140D280 Slot: 46
	internal override string GetParamValueText(IntPtr ptr) { }

	// RVA: 0x140D600 Offset: 0x140BC00 VA: 0x18140D600 Slot: 50
	internal override void ReturnError(IntPtr context, string value) { }

	// RVA: 0x140D680 Offset: 0x140BC80 VA: 0x18140D680 Slot: 53
	internal override void ReturnText(IntPtr context, string value) { }

}

internal abstract class SQLiteBase : SqliteConvert, IDisposable // TypeDefIndex: 4856
{	// Fields
	internal static object _lock; // 0x13769

	// Properties
	internal abstract string Version { get; }
	internal abstract int Changes { get; }

	// Methods

	// RVA: 0x140E080 Offset: 0x140C680 VA: 0x18140E080
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

	// RVA: 0x140DBB0 Offset: 0x140C1B0 VA: 0x18140DBB0 Slot: 5
	public void Dispose() { }

	// RVA: 0x140DF90 Offset: 0x140C590 VA: 0x18140DF90
	internal static string SQLiteLastError(SqliteConnectionHandle db) { }

	// RVA: 0x140DBD0 Offset: 0x140C1D0 VA: 0x18140DBD0
	internal static void FinalizeStatement(SqliteStatementHandle stmt) { }

	// RVA: 0x140D990 Offset: 0x140BF90 VA: 0x18140D990
	internal static void CloseConnection(SqliteConnectionHandle db) { }

	// RVA: 0x140DD40 Offset: 0x140C340 VA: 0x18140DD40
	internal static void ResetConnection(SqliteConnectionHandle db) { }

	// RVA: 0x140E020 Offset: 0x140C620 VA: 0x18140E020
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

	// RVA: 0x1411A50 Offset: 0x1410050 VA: 0x181411A50
	public void .ctor(string commandText, SqliteConnection connection) { }

	// RVA: 0x14116F0 Offset: 0x140FCF0 VA: 0x1814116F0
	public void .ctor(SqliteConnection connection) { }

	// RVA: 0x1411440 Offset: 0x140FA40 VA: 0x181411440
	private void .ctor(SqliteCommand source) { }

	// RVA: 0x14117D0 Offset: 0x140FDD0 VA: 0x1814117D0
	public void .ctor(string commandText, SqliteConnection connection, SqliteTransaction transaction) { }

	// RVA: 0x1410D30 Offset: 0x140F330 VA: 0x181410D30 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1410B20 Offset: 0x140F120 VA: 0x181410B20
	internal void ClearCommands() { }

	// RVA: 0x14108F0 Offset: 0x140EEF0 VA: 0x1814108F0
	internal SqliteStatement BuildNextCommand() { }

	// RVA: 0x1411240 Offset: 0x140F840 VA: 0x181411240
	internal SqliteStatement GetStatement(int index) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 12
	public override string get_CommandText() { }

	// RVA: 0x1411B60 Offset: 0x1410160 VA: 0x181411B60 Slot: 13
	public override void set_CommandText(string value) { }

	// RVA: 0x598420 Offset: 0x596A20 VA: 0x180598420 Slot: 14
	public override int get_CommandTimeout() { }

	// RVA: 0x598430 Offset: 0x596A30 VA: 0x180598430 Slot: 15
	public override void set_CommandTimeout(int value) { }

	// RVA: 0x1411C20 Offset: 0x1410220 VA: 0x181411C20 Slot: 16
	public override void set_CommandType(CommandType value) { }

	// RVA: 0x1410CE0 Offset: 0x140F2E0 VA: 0x181410CE0 Slot: 26
	protected override DbParameter CreateDbParameter() { }

	// RVA: 0x1410CE0 Offset: 0x140F2E0 VA: 0x181410CE0
	public SqliteParameter CreateParameter() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public SqliteConnection get_Connection() { }

	// RVA: 0x1411C80 Offset: 0x1410280 VA: 0x181411C80
	public void set_Connection(SqliteConnection value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 17
	protected override DbConnection get_DbConnection() { }

	// RVA: 0x1411D40 Offset: 0x1410340 VA: 0x181411D40 Slot: 18
	protected override void set_DbConnection(DbConnection value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	public SqliteParameterCollection get_Parameters() { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860 Slot: 19
	protected override DbParameterCollection get_DbParameterCollection() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	public SqliteTransaction get_Transaction() { }

	// RVA: 0x1411E90 Offset: 0x1410490 VA: 0x181411E90
	public void set_Transaction(SqliteTransaction value) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 20
	protected override DbTransaction get_DbTransaction() { }

	// RVA: 0x1411DB0 Offset: 0x14103B0 VA: 0x181411DB0 Slot: 21
	protected override void set_DbTransaction(DbTransaction value) { }

	// RVA: 0x1411300 Offset: 0x140F900 VA: 0x181411300
	private void InitializeForReader() { }

	// RVA: 0x1410EC0 Offset: 0x140F4C0 VA: 0x181410EC0 Slot: 27
	protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior) { }

	// RVA: 0x1410FE0 Offset: 0x140F5E0 VA: 0x181410FE0
	public SqliteDataReader ExecuteReader(CommandBehavior behavior) { }

	// RVA: 0x1411230 Offset: 0x140F830 VA: 0x181411230
	public SqliteDataReader ExecuteReader() { }

	// RVA: 0x8095E0 Offset: 0x807BE0 VA: 0x1808095E0
	internal void ClearDataReader() { }

	// RVA: 0x1410ED0 Offset: 0x140F4D0 VA: 0x181410ED0 Slot: 28
	public override int ExecuteNonQuery() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 29
	public override void Prepare() { }

	// RVA: 0x8D9010 Offset: 0x8D7610 VA: 0x1808D9010 Slot: 24
	public override UpdateRowSource get_UpdatedRowSource() { }

	// RVA: 0x8D9050 Offset: 0x8D7650 VA: 0x1808D9050 Slot: 25
	public override void set_UpdatedRowSource(UpdateRowSource value) { }

	// RVA: 0xC20D30 Offset: 0xC1F330 VA: 0x180C20D30 Slot: 22
	public override bool get_DesignTimeVisible() { }

	// RVA: 0x1411E20 Offset: 0x1410420 VA: 0x181411E20 Slot: 23
	public override void set_DesignTimeVisible(bool value) { }

	// RVA: 0x1410C80 Offset: 0x140F280 VA: 0x181410C80 Slot: 30
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

	// RVA: 0x1410770 Offset: 0x140ED70 VA: 0x181410770
	public void .ctor() { }

	// RVA: 0x14107F0 Offset: 0x140EDF0 VA: 0x1814107F0
	public void .ctor(SqliteDataAdapter adp) { }

	// RVA: 0x140F950 Offset: 0x140DF50 VA: 0x18140F950 Slot: 25
	protected override void ApplyParameterInfo(DbParameter parameter, DataRow row, StatementType statementType, bool whereClause) { }

	// RVA: 0x140FAF0 Offset: 0x140E0F0 VA: 0x18140FAF0 Slot: 27
	protected override string GetParameterName(string parameterName) { }

	// RVA: 0x140FA60 Offset: 0x140E060 VA: 0x18140FA60 Slot: 26
	protected override string GetParameterName(int parameterOrdinal) { }

	// RVA: 0x140FB60 Offset: 0x140E160 VA: 0x18140FB60 Slot: 28
	protected override string GetParameterPlaceholder(int parameterOrdinal) { }

	// RVA: 0x1410410 Offset: 0x140EA10 VA: 0x181410410 Slot: 29
	protected override void SetRowUpdatingHandler(DbDataAdapter adapter) { }

	// RVA: 0x1410400 Offset: 0x140EA00 VA: 0x181410400
	private void RowUpdatingEventHandler(object sender, RowUpdatingEventArgs e) { }

	// RVA: 0x14108C0 Offset: 0x140EEC0 VA: 0x1814108C0
	public void set_DataAdapter(SqliteDataAdapter value) { }

	// RVA: 0x582940 Offset: 0x580F40 VA: 0x180582940 Slot: 13
	public override CatalogLocation get_CatalogLocation() { }

	// RVA: 0x1410880 Offset: 0x140EE80 VA: 0x181410880 Slot: 14
	public override string get_CatalogSeparator() { }

	// RVA: 0x1410890 Offset: 0x140EE90 VA: 0x181410890 Slot: 15
	public override string get_QuotePrefix() { }

	// RVA: 0x14108D0 Offset: 0x140EED0 VA: 0x1814108D0 Slot: 16
	public override void set_QuotePrefix(string value) { }

	// RVA: 0x14108A0 Offset: 0x140EEA0 VA: 0x1814108A0 Slot: 17
	public override string get_QuoteSuffix() { }

	// RVA: 0x14108E0 Offset: 0x140EEE0 VA: 0x1814108E0 Slot: 18
	public override void set_QuoteSuffix(string value) { }

	// RVA: 0x140FFB0 Offset: 0x140E5B0 VA: 0x18140FFB0 Slot: 22
	public override string QuoteIdentifier(string unquotedIdentifier) { }

	// RVA: 0x1410590 Offset: 0x140EB90 VA: 0x181410590 Slot: 24
	public override string UnquoteIdentifier(string quotedIdentifier) { }

	// RVA: 0x14108B0 Offset: 0x140EEB0 VA: 0x1814108B0 Slot: 19
	public override string get_SchemaSeparator() { }

	// RVA: 0x140FB80 Offset: 0x140E180 VA: 0x18140FB80 Slot: 20
	protected override DataTable GetSchemaTable(DbCommand sourceCommand) { }

	// RVA: 0x140FD10 Offset: 0x140E310 VA: 0x18140FD10
	private bool HasSchemaPrimaryKey(DataTable schema) { }

	// RVA: 0x1410100 Offset: 0x140E700 VA: 0x181410100
	private void ResetIsUniqueSchemaColumn(DataTable schema) { }

}

internal sealed class SQLiteUpdateCallback : MulticastDelegate // TypeDefIndex: 4861
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140F340 Offset: 0x140D940 VA: 0x18140F340 Slot: 12
	public virtual void Invoke(IntPtr puser, int type, IntPtr database, IntPtr table, long rowid) { }

	// RVA: 0x140F260 Offset: 0x140D860 VA: 0x18140F260 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr puser, int type, IntPtr database, IntPtr table, long rowid, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteCommitCallback : MulticastDelegate // TypeDefIndex: 4862
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140EA20 Offset: 0x140D020 VA: 0x18140EA20 Slot: 12
	public virtual int Invoke(IntPtr puser) { }

	// RVA: 0x140E9A0 Offset: 0x140CFA0 VA: 0x18140E9A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr puser, AsyncCallback callback, object object) { }

	// RVA: 0xB9A9D0 Offset: 0xB98FD0 VA: 0x180B9A9D0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteRollbackCallback : MulticastDelegate // TypeDefIndex: 4863
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140EFF0 Offset: 0x140D5F0 VA: 0x18140EFF0 Slot: 12
	public virtual void Invoke(IntPtr puser) { }

	// RVA: 0x140F1E0 Offset: 0x140D7E0 VA: 0x18140F1E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr puser, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class SQLiteCommitHandler : MulticastDelegate // TypeDefIndex: 4864
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, CommitEventArgs e) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, CommitEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class SQLiteUpdateEventHandler : MulticastDelegate // TypeDefIndex: 4865
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4880 Offset: 0xAE2E80 VA: 0x180AE4880 Slot: 12
	public virtual void Invoke(object sender, UpdateEventArgs e) { }

	// RVA: 0xAE4840 Offset: 0xAE2E40 VA: 0x180AE4840 Slot: 13
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

	// RVA: 0x1412470 Offset: 0x1410A70 VA: 0x181412470
	internal static SqliteConnectionHandle Remove(string fileName, int maxPoolSize, out int version) { }

	// RVA: 0x1412150 Offset: 0x1410750 VA: 0x181412150
	internal static void Add(string fileName, SqliteConnectionHandle hdl, int version) { }

	// RVA: 0x1412800 Offset: 0x1410E00 VA: 0x181412800
	private static void ResizePool(SqliteConnectionPool.Pool queue, bool forAdding) { }

	// RVA: 0x14128F0 Offset: 0x1410EF0 VA: 0x1814128F0
	private static void .cctor() { }

}

internal class SqliteConnectionPool.Pool // TypeDefIndex: 4869
{	// Fields
	internal readonly Queue<WeakReference> Queue; // 0x10
	internal int PoolVersion; // 0x18
	internal int MaxPoolSize; // 0x1C

	// Methods

	// RVA: 0x1409530 Offset: 0x1407B30 VA: 0x181409530
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

	// RVA: 0x141FFE0 Offset: 0x141E5E0 VA: 0x18141FFE0
	public static byte[] ToUTF8(string sourceText) { }

	// RVA: 0x141FF70 Offset: 0x141E570 VA: 0x18141FF70
	public byte[] ToUTF8(DateTime dateTimeValue) { }

	// RVA: 0x141FF10 Offset: 0x141E510 VA: 0x18141FF10 Slot: 4
	public virtual string ToString(IntPtr nativestring, int nativestringlen) { }

	// RVA: 0x14206B0 Offset: 0x141ECB0 VA: 0x1814206B0
	public static string UTF8ToString(IntPtr nativestring, int nativestringlen) { }

	// RVA: 0x141F980 Offset: 0x141DF80 VA: 0x18141F980
	public DateTime ToDateTime(string dateText) { }

	// RVA: 0x141FC60 Offset: 0x141E260 VA: 0x18141FC60
	public DateTime ToDateTime(double julianDay) { }

	// RVA: 0x141FCC0 Offset: 0x141E2C0 VA: 0x18141FCC0
	public double ToJulianDay(DateTime value) { }

	// RVA: 0x141FCF0 Offset: 0x141E2F0 VA: 0x18141FCF0
	public string ToString(DateTime dateValue) { }

	// RVA: 0x141F950 Offset: 0x141DF50 VA: 0x18141F950
	internal DateTime ToDateTime(IntPtr ptr, int len) { }

	// RVA: 0x141F380 Offset: 0x141D980 VA: 0x18141F380
	public static string[] Split(string source, char separator) { }

	// RVA: 0x141F700 Offset: 0x141DD00 VA: 0x18141F700
	public static bool ToBoolean(string source) { }

	// RVA: 0x141F240 Offset: 0x141D840 VA: 0x18141F240
	internal static Type SQLiteTypeToType(SQLiteType t) { }

	// RVA: 0x1420540 Offset: 0x141EB40 VA: 0x181420540
	internal static DbType TypeToDbType(Type typ) { }

	// RVA: 0x141EEA0 Offset: 0x141D4A0 VA: 0x18141EEA0
	internal static int DbTypeToColumnSize(DbType typ) { }

	// RVA: 0x141EF30 Offset: 0x141D530 VA: 0x18141EF30
	internal static object DbTypeToNumericPrecision(DbType typ) { }

	// RVA: 0x141EFC0 Offset: 0x141D5C0 VA: 0x18141EFC0
	internal static object DbTypeToNumericScale(DbType typ) { }

	// RVA: 0x141F050 Offset: 0x141D650 VA: 0x18141F050
	internal static string DbTypeToTypeName(DbType typ) { }

	// RVA: 0x141F1B0 Offset: 0x141D7B0 VA: 0x18141F1B0
	internal static Type DbTypeToType(DbType typ) { }

	// RVA: 0x14203E0 Offset: 0x141E9E0 VA: 0x1814203E0
	internal static TypeAffinity TypeToAffinity(Type typ) { }

	// RVA: 0x14200F0 Offset: 0x141E6F0 VA: 0x1814200F0
	internal static DbType TypeNameToDbType(string Name) { }

	// RVA: 0x1420810 Offset: 0x141EE10 VA: 0x181420810
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

	// RVA: 0x1425200 Offset: 0x1423800 VA: 0x181425200
	public void add_RowUpdating(EventHandler<RowUpdatingEventArgs> value) { }

	// RVA: 0x14254D0 Offset: 0x1423AD0 VA: 0x1814254D0
	public void remove_RowUpdating(EventHandler<RowUpdatingEventArgs> value) { }

	// RVA: 0x1425080 Offset: 0x1423680 VA: 0x181425080
	internal static Delegate FindBuilder(MulticastDelegate mcd) { }

	// RVA: 0x1425170 Offset: 0x1423770 VA: 0x181425170
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

	// RVA: 0x1429380 Offset: 0x1427980 VA: 0x181429380
	internal void .ctor(SqliteCommand cmd, CommandBehavior behave) { }

	// RVA: 0x14256F0 Offset: 0x1423CF0 VA: 0x1814256F0 Slot: 21
	public override void Close() { }

	// RVA: 0x1425560 Offset: 0x1423B60 VA: 0x181425560
	private void CheckClosed() { }

	// RVA: 0x1425680 Offset: 0x1423C80 VA: 0x181425680
	private void CheckValidRow() { }

	// RVA: 0x1425BD0 Offset: 0x14241D0 VA: 0x181425BD0 Slot: 24
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x1429430 Offset: 0x1427A30 VA: 0x181429430 Slot: 17
	public override int get_FieldCount() { }

	// RVA: 0x14294A0 Offset: 0x1427AA0 VA: 0x1814294A0 Slot: 19
	public override int get_VisibleFieldCount() { }

	// RVA: 0x1429200 Offset: 0x1427800 VA: 0x181429200
	private TypeAffinity VerifyType(int i, DbType typ) { }

	// RVA: 0x1425940 Offset: 0x1423F40 VA: 0x181425940 Slot: 28
	public override bool GetBoolean(int i) { }

	// RVA: 0x1425B10 Offset: 0x1424110 VA: 0x181425B10 Slot: 23
	public override string GetDataTypeName(int i) { }

	// RVA: 0x1425C40 Offset: 0x1424240 VA: 0x181425C40 Slot: 25
	public override Type GetFieldType(int i) { }

	// RVA: 0x1425D10 Offset: 0x1424310 VA: 0x181425D10 Slot: 29
	public override int GetInt32(int i) { }

	// RVA: 0x1425E80 Offset: 0x1424480 VA: 0x181425E80 Slot: 30
	public override long GetInt64(int i) { }

	// RVA: 0x1425FF0 Offset: 0x14245F0 VA: 0x181425FF0 Slot: 26
	public override string GetName(int i) { }

	// RVA: 0x14262A0 Offset: 0x14248A0 VA: 0x1814262A0 Slot: 27
	public override DataTable GetSchemaTable() { }

	// RVA: 0x14262B0 Offset: 0x14248B0 VA: 0x1814262B0
	internal DataTable GetSchemaTable(bool wantUniqueInfo, bool wantDefaultValue) { }

	// RVA: 0x14289F0 Offset: 0x1426FF0 VA: 0x1814289F0 Slot: 31
	public override string GetString(int i) { }

	// RVA: 0x1428B60 Offset: 0x1427160 VA: 0x181428B60 Slot: 32
	public override object GetValue(int i) { }

	// RVA: 0x1428C20 Offset: 0x1427220 VA: 0x181428C20 Slot: 33
	public override int GetValues(object[] values) { }

	// RVA: 0x1428D10 Offset: 0x1427310 VA: 0x181428D10 Slot: 34
	public override bool IsDBNull(int i) { }

	// RVA: 0x1428E70 Offset: 0x1427470 VA: 0x181428E70 Slot: 35
	public override bool NextResult() { }

	// RVA: 0x1426090 Offset: 0x1424690 VA: 0x181426090
	private SQLiteType GetSQLiteType(int i) { }

	// RVA: 0x1429170 Offset: 0x1427770 VA: 0x181429170 Slot: 36
	public override bool Read() { }

	// RVA: 0x1429490 Offset: 0x1427A90 VA: 0x181429490 Slot: 18
	public override int get_RecordsAffected() { }

	// RVA: 0x1429470 Offset: 0x1427A70 VA: 0x181429470 Slot: 20
	public override object get_Item(int i) { }

	// RVA: 0x1428DB0 Offset: 0x14273B0 VA: 0x181428DB0
	private void LoadKeyInfo() { }

	// RVA: 0x1429340 Offset: 0x1427940 VA: 0x181429340
	private static void .cctor() { }

}

internal class SQLiteEnlistment : IEnlistmentNotification // TypeDefIndex: 4877
{	// Fields
	internal SqliteTransaction _transaction; // 0x10
	internal Transaction _scope; // 0x18
	internal bool _disposeConnection; // 0x20

	// Methods

	// RVA: 0x140EEA0 Offset: 0x140D4A0 VA: 0x18140EEA0
	internal void .ctor(SqliteConnection cnn, Transaction scope) { }

	// RVA: 0x140ED20 Offset: 0x140D320 VA: 0x18140ED20
	private void Cleanup(SqliteConnection cnn) { }

	// RVA: 0x140ED70 Offset: 0x140D370 VA: 0x18140ED70 Slot: 4
	public void Rollback(Enlistment enlistment) { }

}

public sealed class SqliteException : DbException // TypeDefIndex: 4878
{	// Fields
	private SQLiteErrorCode _errorCode; // 0x88
	private static string[] _errorMessages; // 0x0

	// Methods

	// RVA: 0x21F1FF0 Offset: 0x21F05F0 VA: 0x1821F1FF0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x21F2010 Offset: 0x21F0610 VA: 0x1821F2010
	public void .ctor(int errorCode, string extendedInformation) { }

	// RVA: 0x21F2190 Offset: 0x21F0790 VA: 0x1821F2190
	public void .ctor() { }

	// RVA: 0x21F13D0 Offset: 0x21EF9D0 VA: 0x1821F13D0
	private static string GetStockErrorMessage(int errorCode, string errorMessage) { }

	// RVA: 0x21F14D0 Offset: 0x21EFAD0 VA: 0x1821F14D0
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

	// RVA: 0x21F2C30 Offset: 0x21F1230 VA: 0x1821F2C30
	internal object[] ConvertParams(int nArgs, IntPtr argsptr) { }

	// RVA: 0x21F3310 Offset: 0x21F1910 VA: 0x1821F3310
	private void SetReturnValue(IntPtr context, object returnValue) { }

	// RVA: 0x21F32B0 Offset: 0x21F18B0 VA: 0x1821F32B0
	internal void ScalarCallback(IntPtr context, int nArgs, IntPtr argsptr) { }

	// RVA: 0x21F2B90 Offset: 0x21F1190 VA: 0x1821F2B90
	internal int CompareCallback(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2) { }

	// RVA: 0x21F2B30 Offset: 0x21F1130 VA: 0x1821F2B30
	internal int CompareCallback16(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2) { }

	// RVA: 0x21F36C0 Offset: 0x21F1CC0 VA: 0x1821F36C0
	internal void StepCallback(IntPtr context, int nArgs, IntPtr argsptr) { }

	// RVA: 0x21F3180 Offset: 0x21F1780 VA: 0x1821F3180
	internal void FinalCallback(IntPtr context) { }

	// RVA: 0x21F3860 Offset: 0x21F1E60 VA: 0x1821F3860
	private static void .cctor() { }

	// RVA: 0x21F26D0 Offset: 0x21F0CD0 VA: 0x1821F26D0
	internal static SqliteFunction[] BindFunctions(SQLiteBase sqlbase) { }

}

private class SqliteFunction.AggregateData // TypeDefIndex: 4881
{	// Fields
	internal int _count; // 0x10
	internal object _data; // 0x18

	// Methods

	// RVA: 0x1076DA0 Offset: 0x10753A0 VA: 0x181076DA0
	public void .ctor() { }

}

internal sealed class SQLiteCallback : MulticastDelegate // TypeDefIndex: 4884
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140E180 Offset: 0x140C780 VA: 0x18140E180 Slot: 12
	public virtual void Invoke(IntPtr context, int nArgs, IntPtr argsptr) { }

	// RVA: 0x140E0E0 Offset: 0x140C6E0 VA: 0x18140E0E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr context, int nArgs, IntPtr argsptr, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteFinalCallback : MulticastDelegate // TypeDefIndex: 4885
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140EFF0 Offset: 0x140D5F0 VA: 0x18140EFF0 Slot: 12
	public virtual void Invoke(IntPtr context) { }

	// RVA: 0x140EF70 Offset: 0x140D570 VA: 0x18140EF70 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr context, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteCollation : MulticastDelegate // TypeDefIndex: 4886
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140E5C0 Offset: 0x140CBC0 VA: 0x18140E5C0 Slot: 12
	public virtual int Invoke(IntPtr puser, int len1, IntPtr pv1, int len2, IntPtr pv2) { }

	// RVA: 0x140E4E0 Offset: 0x140CAE0 VA: 0x18140E4E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr puser, int len1, IntPtr pv1, int len2, IntPtr pv2, AsyncCallback callback, object object) { }

	// RVA: 0xB9A9D0 Offset: 0xB98FD0 VA: 0x180B9A9D0 Slot: 14
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

	// RVA: 0x21F5460 Offset: 0x21F3A60 VA: 0x1821F5460
	internal void .ctor(SqliteConnection cnn, SqliteDataReader reader, SqliteStatement stmt) { }

	// RVA: 0xD87190 Offset: 0xD85790 VA: 0x180D87190
	internal int get_Count() { }

	// RVA: 0x21F53C0 Offset: 0x21F39C0 VA: 0x1821F53C0
	internal void Sync(int i) { }

	// RVA: 0x21F52D0 Offset: 0x21F38D0 VA: 0x1821F52D0
	internal void Sync() { }

	// RVA: 0x21F5200 Offset: 0x21F3800 VA: 0x1821F5200
	internal void Reset() { }

	// RVA: 0x21F46B0 Offset: 0x21F2CB0 VA: 0x1821F46B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x21F4820 Offset: 0x21F2E20 VA: 0x1821F4820
	internal string GetDataTypeName(int i) { }

	// RVA: 0x21F48D0 Offset: 0x21F2ED0 VA: 0x1821F48D0
	internal Type GetFieldType(int i) { }

	// RVA: 0x21F4C00 Offset: 0x21F3200 VA: 0x1821F4C00
	internal string GetName(int i) { }

	// RVA: 0x21F4750 Offset: 0x21F2D50 VA: 0x1821F4750
	internal bool GetBoolean(int i) { }

	// RVA: 0x21F49A0 Offset: 0x21F2FA0 VA: 0x1821F49A0
	internal int GetInt32(int i) { }

	// RVA: 0x21F4AD0 Offset: 0x21F30D0 VA: 0x1821F4AD0
	internal long GetInt64(int i) { }

	// RVA: 0x21F4C40 Offset: 0x21F3240 VA: 0x1821F4C40
	internal string GetString(int i) { }

	// RVA: 0x21F4D10 Offset: 0x21F3310 VA: 0x1821F4D10
	internal object GetValue(int i) { }

	// RVA: 0x21F50A0 Offset: 0x21F36A0 VA: 0x1821F50A0
	internal bool IsDBNull(int i) { }

	// RVA: 0x21F3CA0 Offset: 0x21F22A0 VA: 0x1821F3CA0
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

	// RVA: 0x21F1020 Offset: 0x21EF620 VA: 0x1821F1020
	internal void .ctor(SqliteConnection cnn, string database, string table, string[] columns) { }

	// RVA: 0x21F1340 Offset: 0x21EF940 VA: 0x1821F1340
	internal void set_IsValid(bool value) { }

	// RVA: 0x21F0EC0 Offset: 0x21EF4C0 VA: 0x1821F0EC0
	internal void Sync(long rowid) { }

	// RVA: 0x21F0E40 Offset: 0x21EF440 VA: 0x1821F0E40 Slot: 4
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

	// RVA: 0x21F7D20 Offset: 0x21F6320 VA: 0x1821F7D20
	public void .ctor() { }

	// RVA: 0x21F80A0 Offset: 0x21F66A0 VA: 0x1821F80A0
	public void .ctor(string parameterName, object value) { }

	// RVA: 0x21F8010 Offset: 0x21F6610 VA: 0x1821F8010
	public void .ctor(string parameterName, DbType parameterType, int parameterSize, string sourceColumn, DataRowVersion rowVersion) { }

	// RVA: 0x21F7E70 Offset: 0x21F6470 VA: 0x1821F7E70
	private void .ctor(SqliteParameter source) { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x21F7D90 Offset: 0x21F6390 VA: 0x1821F7D90
	public void .ctor(string parameterName, DbType parameterType, int parameterSize, ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, DataRowVersion rowVersion, object value) { }

	// RVA: 0xC65CA0 Offset: 0xC642A0 VA: 0x180C65CA0 Slot: 10
	public override bool get_IsNullable() { }

	// RVA: 0xE72F60 Offset: 0xE71560 VA: 0x180E72F60 Slot: 11
	public override void set_IsNullable(bool value) { }

	// RVA: 0x21F8130 Offset: 0x21F6730 VA: 0x1821F8130 Slot: 6
	public override DbType get_DbType() { }

	// RVA: 0x7D0D90 Offset: 0x7CF390 VA: 0x1807D0D90 Slot: 7
	public override void set_DbType(DbType value) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 8
	public override ParameterDirection get_Direction() { }

	// RVA: 0x21F8200 Offset: 0x21F6800 VA: 0x1821F8200 Slot: 9
	public override void set_Direction(ParameterDirection value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 12
	public override string get_ParameterName() { }

	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080 Slot: 13
	public override void set_ParameterName(string value) { }

	// RVA: 0xC74BD0 Offset: 0xC731D0 VA: 0x180C74BD0 Slot: 14
	public override void set_Size(int value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 15
	public override string get_SourceColumn() { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450 Slot: 16
	public override void set_SourceColumn(string value) { }

	// RVA: 0x21F8260 Offset: 0x21F6860 VA: 0x1821F8260 Slot: 17
	public override void set_SourceColumnNullMapping(bool value) { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460 Slot: 18
	public override DataRowVersion get_SourceVersion() { }

	// RVA: 0x95FB00 Offset: 0x95E100 VA: 0x18095FB00 Slot: 19
	public override void set_SourceVersion(DataRowVersion value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 20
	public override object get_Value() { }

	// RVA: 0x21F8270 Offset: 0x21F6870 VA: 0x1821F8270 Slot: 21
	public override void set_Value(object value) { }

	// RVA: 0x21F7B50 Offset: 0x21F6150 VA: 0x1821F7B50 Slot: 22
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

	// RVA: 0x21F7A20 Offset: 0x21F6020 VA: 0x1821F7A20
	internal void .ctor(SqliteCommand cmd) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 22
	public override bool get_IsFixedSize() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 23
	public override bool get_IsReadOnly() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 24
	public override object get_SyncRoot() { }

	// RVA: 0x21F71C0 Offset: 0x21F57C0 VA: 0x1821F71C0 Slot: 29
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x21F6FC0 Offset: 0x21F55C0 VA: 0x1821F6FC0
	public int Add(SqliteParameter parameter) { }

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	// RVA: 0x21F6F50 Offset: 0x21F5550 VA: 0x1821F6F50 Slot: 25
	public override int Add(object value) { }

	// RVA: 0x21F6E70 Offset: 0x21F5470 VA: 0x1821F6E70
	public SqliteParameter AddWithValue(string parameterName, object value) { }

	// RVA: 0x21F70A0 Offset: 0x21F56A0 VA: 0x1821F70A0 Slot: 28
	public override void Clear() { }

	// RVA: 0x21F70F0 Offset: 0x21F56F0 VA: 0x1821F70F0 Slot: 26
	public override bool Contains(object value) { }

	// RVA: 0x21F7170 Offset: 0x21F5770 VA: 0x1821F7170 Slot: 27
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x21F7AA0 Offset: 0x21F60A0 VA: 0x1821F7AA0 Slot: 21
	public override int get_Count() { }

	// RVA: 0x21F7AE0 Offset: 0x21F60E0 VA: 0x1821F7AE0
	public SqliteParameter get_Item(int index) { }

	// RVA: 0x21F7240 Offset: 0x21F5840 VA: 0x1821F7240 Slot: 30
	protected override DbParameter GetParameter(int index) { }

	// RVA: 0x21F72A0 Offset: 0x21F58A0 VA: 0x1821F72A0 Slot: 32
	public override int IndexOf(string parameterName) { }

	// RVA: 0x21F73E0 Offset: 0x21F59E0 VA: 0x1821F73E0 Slot: 31
	public override int IndexOf(object value) { }

	// RVA: 0x21F7460 Offset: 0x21F5A60 VA: 0x1821F7460 Slot: 33
	public override void Insert(int index, object value) { }

	// RVA: 0x21F7910 Offset: 0x21F5F10 VA: 0x1821F7910 Slot: 34
	public override void Remove(object value) { }

	// RVA: 0x21F78B0 Offset: 0x21F5EB0 VA: 0x1821F78B0 Slot: 35
	public override void RemoveAt(int index) { }

	// RVA: 0x21F7990 Offset: 0x21F5F90 VA: 0x1821F7990 Slot: 36
	protected override void SetParameter(int index, DbParameter value) { }

	// RVA: 0x4A04D0 Offset: 0x49EAD0 VA: 0x1804A04D0
	internal void Unbind() { }

	// RVA: 0x21F74F0 Offset: 0x21F5AF0 VA: 0x1821F74F0
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

	// RVA: 0x21F9020 Offset: 0x21F7620 VA: 0x1821F9020
	internal void .ctor(SQLiteBase sqlbase, SqliteStatementHandle stmt, string strCommand, SqliteStatement previous) { }

	// RVA: 0x21F8BC0 Offset: 0x21F71C0 VA: 0x1821F8BC0
	internal bool MapParameter(string s, SqliteParameter p) { }

	// RVA: 0x21F8B40 Offset: 0x21F7140 VA: 0x1821F8B40 Slot: 4
	public void Dispose() { }

	// RVA: 0x21F8AC0 Offset: 0x21F70C0 VA: 0x1821F8AC0
	internal void BindParameters() { }

	// RVA: 0x21F8510 Offset: 0x21F6B10 VA: 0x1821F8510
	private void BindParameter(int index, SqliteParameter param) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal string[] get_TypeDefinitions() { }

	// RVA: 0x21F8DD0 Offset: 0x21F73D0 VA: 0x1821F8DD0
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

	// RVA: 0x21F97C0 Offset: 0x21F7DC0 VA: 0x1821F97C0
	internal void .ctor(SqliteConnection connection, bool deferredLock) { }

	// RVA: 0x21F9270 Offset: 0x21F7870 VA: 0x1821F9270 Slot: 7
	public override void Commit() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public SqliteConnection get_Connection() { }

	// RVA: 0x21F93C0 Offset: 0x21F79C0 VA: 0x1821F93C0 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x21F9770 Offset: 0x21F7D70 VA: 0x1821F9770 Slot: 9
	public override void Rollback() { }

	// RVA: 0x21F9660 Offset: 0x21F7C60 VA: 0x1821F9660
	internal static void IssueRollback(SqliteConnection cnn) { }

	// RVA: 0x21F9500 Offset: 0x21F7B00 VA: 0x1821F9500
	internal bool IsValid(bool throwError) { }

}

internal class SqliteConnectionHandle : CriticalHandle // TypeDefIndex: 4897
{	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x691F20 Offset: 0x690520 VA: 0x180691F20
	public static IntPtr op_Implicit(SqliteConnectionHandle db) { }

	// RVA: 0x14120D0 Offset: 0x14106D0 VA: 0x1814120D0
	public static SqliteConnectionHandle op_Implicit(IntPtr db) { }

	// RVA: 0x1412040 Offset: 0x1410640 VA: 0x181412040
	private void .ctor(IntPtr db) { }

	// RVA: 0x1412000 Offset: 0x1410600 VA: 0x181412000
	internal void .ctor() { }

	// RVA: 0x1411F90 Offset: 0x1410590 VA: 0x181411F90 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x1412090 Offset: 0x1410690 VA: 0x181412090 Slot: 5
	public override bool get_IsInvalid() { }

}

internal class SqliteStatementHandle : CriticalHandle // TypeDefIndex: 4898
{	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x691F20 Offset: 0x690520 VA: 0x180691F20
	public static IntPtr op_Implicit(SqliteStatementHandle stmt) { }

	// RVA: 0x21F8490 Offset: 0x21F6A90 VA: 0x1821F8490
	public static SqliteStatementHandle op_Implicit(IntPtr stmt) { }

	// RVA: 0x21F83C0 Offset: 0x21F69C0 VA: 0x1821F83C0
	private void .ctor(IntPtr stmt) { }

	// RVA: 0x21F8410 Offset: 0x21F6A10 VA: 0x1821F8410
	internal void .ctor() { }

	// RVA: 0x21F8350 Offset: 0x21F6950 VA: 0x1821F8350 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x21F8450 Offset: 0x21F6A50 VA: 0x1821F8450 Slot: 5
	public override bool get_IsInvalid() { }

}

public class SqliteException : Exception // TypeDefIndex: 7360
{	// Methods

	// RVA: 0x231F1A0 Offset: 0x231D7A0 VA: 0x18231F1A0
	public void .ctor(string message) { }

}

