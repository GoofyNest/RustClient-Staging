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

	// RVA: 0x141D900 Offset: 0x141BF00 VA: 0x18141D900
	public void .ctor() { }

	// RVA: 0x141D860 Offset: 0x141BE60 VA: 0x18141D860
	public void .ctor(string connectionString) { }

	// RVA: 0x141D9C0 Offset: 0x141BFC0 VA: 0x18141D9C0
	public void .ctor(SqliteConnection connection) { }

	// RVA: 0x1411C30 Offset: 0x1410230 VA: 0x181411C30 Slot: 22
	public object Clone() { }

	// RVA: 0x1411FA0 Offset: 0x14105A0 VA: 0x181411FA0 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1413010 Offset: 0x1411610 VA: 0x181413010
	internal void OnStateChange(ConnectionState newState) { }

	// RVA: 0x1411BC0 Offset: 0x14101C0 VA: 0x181411BC0
	public SqliteTransaction BeginTransaction() { }

	// RVA: 0x1411AD0 Offset: 0x14100D0 VA: 0x181411AD0 Slot: 15
	protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel) { }

	// RVA: 0x1411C90 Offset: 0x1410290 VA: 0x181411C90 Slot: 16
	public override void Close() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 12
	public override string get_ConnectionString() { }

	// RVA: 0x141DED0 Offset: 0x141C4D0 VA: 0x18141DED0 Slot: 13
	public override void set_ConnectionString(string value) { }

	// RVA: 0x1411E80 Offset: 0x1410480 VA: 0x181411E80
	public SqliteCommand CreateCommand() { }

	// RVA: 0x1411F90 Offset: 0x1410590 VA: 0x181411F90 Slot: 17
	protected override DbCommand CreateDbCommand() { }

	// RVA: 0x1412C80 Offset: 0x1411280 VA: 0x181412C80
	internal static void MapMonoKeyword(string[] arPiece, SortedList<string, string> ls) { }

	// RVA: 0x1412E70 Offset: 0x1411470 VA: 0x181412E70
	internal static string MapMonoUriPath(string path) { }

	// RVA: 0x1412F40 Offset: 0x1411540 VA: 0x181412F40
	internal static string MapUriPath(string path) { }

	// RVA: 0x1414780 Offset: 0x1412D80 VA: 0x181414780
	internal static SortedList<string, string> ParseConnectionString(string connectionString) { }

	// RVA: 0x1412000 Offset: 0x1410600 VA: 0x181412000 Slot: 18
	public override void EnlistTransaction(Transaction transaction) { }

	// RVA: 0x14123F0 Offset: 0x14109F0 VA: 0x1814123F0
	internal static string FindKey(SortedList<string, string> items, string key, string defValue) { }

	// RVA: 0x14130B0 Offset: 0x14116B0 VA: 0x1814130B0 Slot: 21
	public override void Open() { }

	// RVA: 0x574340 Offset: 0x572940 VA: 0x180574340
	public int get_DefaultTimeout() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590 Slot: 14
	public override ConnectionState get_State() { }

	// RVA: 0x14121B0 Offset: 0x14107B0 VA: 0x1814121B0
	private string ExpandFileName(string sourceFile) { }

	// RVA: 0x1412C20 Offset: 0x1411220 VA: 0x181412C20 Slot: 19
	public override DataTable GetSchema(string collectionName) { }

	// RVA: 0x1412470 Offset: 0x1410A70 VA: 0x181412470 Slot: 20
	public override DataTable GetSchema(string collectionName, string[] restrictionValues) { }

	// RVA: 0x141AD50 Offset: 0x1419350 VA: 0x18141AD50
	private static DataTable Schema_ReservedWords() { }

	// RVA: 0x141AB40 Offset: 0x1419140 VA: 0x18141AB40
	private static DataTable Schema_MetaDataCollections() { }

	// RVA: 0x1416130 Offset: 0x1414730 VA: 0x181416130
	private DataTable Schema_DataSourceInformation() { }

	// RVA: 0x1414E10 Offset: 0x1413410 VA: 0x181414E10
	private DataTable Schema_Columns(string strCatalog, string strTable, string strColumn) { }

	// RVA: 0x1419420 Offset: 0x1417A20 VA: 0x181419420
	private DataTable Schema_Indexes(string strCatalog, string strTable, string strIndex) { }

	// RVA: 0x141B6E0 Offset: 0x1419CE0 VA: 0x18141B6E0
	private DataTable Schema_Triggers(string catalog, string table, string triggerName) { }

	// RVA: 0x141B000 Offset: 0x1419600 VA: 0x18141B000
	private DataTable Schema_Tables(string strCatalog, string strTable, string strType) { }

	// RVA: 0x141D140 Offset: 0x141B740 VA: 0x18141D140
	private DataTable Schema_Views(string strCatalog, string strView) { }

	// RVA: 0x14149E0 Offset: 0x1412FE0 VA: 0x1814149E0
	private DataTable Schema_Catalogs(string strCatalog) { }

	// RVA: 0x1416DA0 Offset: 0x14153A0 VA: 0x181416DA0
	private DataTable Schema_DataTypes() { }

	// RVA: 0x1418070 Offset: 0x1416670 VA: 0x181418070
	private DataTable Schema_IndexColumns(string strCatalog, string strTable, string strIndex, string strColumn) { }

	// RVA: 0x141BC90 Offset: 0x141A290 VA: 0x18141BC90
	private DataTable Schema_ViewColumns(string strCatalog, string strView, string strColumn) { }

	// RVA: 0x1417340 Offset: 0x1415940 VA: 0x181417340
	private DataTable Schema_ForeignKeys(string strCatalog, string strTable, string strKeyName) { }

}

public sealed class SqliteFactory : DbProviderFactory, IServiceProvider // TypeDefIndex: 4853
{	// Fields
	private static Type _dbProviderServicesType; // 0x0
	private static object _sqliteServices; // 0x8
	public static readonly SqliteFactory Instance; // 0x10

	// Methods

	// RVA: 0x21F2E20 Offset: 0x21F1420 VA: 0x1821F2E20
	private static void .cctor() { }

	// RVA: 0x21F2B60 Offset: 0x21F1160 VA: 0x1821F2B60 Slot: 4
	private object System.IServiceProvider.GetService(Type serviceType) { }

	// RVA: 0x21F29C0 Offset: 0x21F0FC0 VA: 0x1821F29C0
	private object GetSQLiteProviderServicesInstance() { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
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

	// RVA: 0x140C8E0 Offset: 0x140AEE0 VA: 0x18140C8E0
	internal void .ctor(SQLiteDateFormats fmt) { }

	// RVA: 0x1409B70 Offset: 0x1408170 VA: 0x181409B70 Slot: 61
	protected override void Dispose(bool bDisposing) { }

	// RVA: 0x1408FB0 Offset: 0x14075B0 VA: 0x181408FB0 Slot: 9
	internal override void Close() { }

	// RVA: 0x140C9F0 Offset: 0x140AFF0 VA: 0x18140C9F0 Slot: 6
	internal override string get_Version() { }

	// RVA: 0x140C9F0 Offset: 0x140AFF0 VA: 0x18140C9F0
	internal static string get_SQLiteVersion() { }

	// RVA: 0x140C980 Offset: 0x140AF80 VA: 0x18140C980 Slot: 7
	internal override int get_Changes() { }

	// RVA: 0x140A830 Offset: 0x1408E30 VA: 0x18140A830 Slot: 8
	internal override void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool) { }

	// RVA: 0x140BA80 Offset: 0x140A080 VA: 0x18140BA80 Slot: 10
	internal override void SetTimeout(int nTimeoutMS) { }

	// RVA: 0x140BBD0 Offset: 0x140A1D0 VA: 0x18140BBD0 Slot: 13
	internal override bool Step(SqliteStatement stmt) { }

	// RVA: 0x140B250 Offset: 0x1409850 VA: 0x18140B250 Slot: 14
	internal override int Reset(SqliteStatement stmt) { }

	// RVA: 0x140B7D0 Offset: 0x1409DD0 VA: 0x18140B7D0 Slot: 11
	internal override string SQLiteLastError() { }

	// RVA: 0x140AAD0 Offset: 0x14090D0 VA: 0x18140AAD0 Slot: 12
	internal override SqliteStatement Prepare(SqliteConnection cnn, string strSql, SqliteStatement previous, uint timeoutMS, out string strRemain) { }

	// RVA: 0x1408990 Offset: 0x1406F90 VA: 0x181408990 Slot: 15
	internal override void Bind_Double(SqliteStatement stmt, int index, double value) { }

	// RVA: 0x1408A80 Offset: 0x1407080 VA: 0x181408A80 Slot: 16
	internal override void Bind_Int32(SqliteStatement stmt, int index, int value) { }

	// RVA: 0x1408B70 Offset: 0x1407170 VA: 0x181408B70 Slot: 17
	internal override void Bind_Int64(SqliteStatement stmt, int index, long value) { }

	// RVA: 0x1408E60 Offset: 0x1407460 VA: 0x181408E60 Slot: 18
	internal override void Bind_Text(SqliteStatement stmt, int index, string value) { }

	// RVA: 0x1408820 Offset: 0x1406E20 VA: 0x181408820 Slot: 20
	internal override void Bind_DateTime(SqliteStatement stmt, int index, DateTime dt) { }

	// RVA: 0x1408700 Offset: 0x1406D00 VA: 0x181408700 Slot: 19
	internal override void Bind_Blob(SqliteStatement stmt, int index, byte[] blobData) { }

	// RVA: 0x1408C60 Offset: 0x1407260 VA: 0x181408C60 Slot: 21
	internal override void Bind_Null(SqliteStatement stmt, int index) { }

	// RVA: 0x1408D40 Offset: 0x1407340 VA: 0x181408D40 Slot: 22
	internal override int Bind_ParamCount(SqliteStatement stmt) { }

	// RVA: 0x1408DB0 Offset: 0x14073B0 VA: 0x181408DB0 Slot: 23
	internal override string Bind_ParamName(SqliteStatement stmt, int index) { }

	// RVA: 0x1409110 Offset: 0x1407710 VA: 0x181409110 Slot: 24
	internal override int ColumnCount(SqliteStatement stmt) { }

	// RVA: 0x1409460 Offset: 0x1407A60 VA: 0x181409460 Slot: 25
	internal override string ColumnName(SqliteStatement stmt, int index) { }

	// RVA: 0x1409090 Offset: 0x1407690 VA: 0x181409090 Slot: 26
	internal override TypeAffinity ColumnAffinity(SqliteStatement stmt, int index) { }

	// RVA: 0x1409670 Offset: 0x1407C70 VA: 0x181409670 Slot: 27
	internal override string ColumnType(SqliteStatement stmt, int index, out TypeAffinity nAffinity) { }

	// RVA: 0x1409510 Offset: 0x1407B10 VA: 0x181409510 Slot: 28
	internal override string ColumnOriginalName(SqliteStatement stmt, int index) { }

	// RVA: 0x1409180 Offset: 0x1407780 VA: 0x181409180 Slot: 29
	internal override string ColumnDatabaseName(SqliteStatement stmt, int index) { }

	// RVA: 0x14095C0 Offset: 0x1407BC0 VA: 0x1814095C0 Slot: 30
	internal override string ColumnTableName(SqliteStatement stmt, int index) { }

	// RVA: 0x1409230 Offset: 0x1407830 VA: 0x181409230 Slot: 31
	internal override void ColumnMetaData(string dataBase, string table, string column, out string dataType, out string collateSequence, out bool notNull, out bool primaryKey, out bool autoIncrement) { }

	// RVA: 0x1409DA0 Offset: 0x14083A0 VA: 0x181409DA0 Slot: 33
	internal override double GetDouble(SqliteStatement stmt, int index) { }

	// RVA: 0x1409E80 Offset: 0x1408480 VA: 0x181409E80 Slot: 34
	internal override int GetInt32(SqliteStatement stmt, int index) { }

	// RVA: 0x1409F00 Offset: 0x1408500 VA: 0x181409F00 Slot: 35
	internal override long GetInt64(SqliteStatement stmt, int index) { }

	// RVA: 0x140A250 Offset: 0x1408850 VA: 0x18140A250 Slot: 36
	internal override string GetText(SqliteStatement stmt, int index) { }

	// RVA: 0x1409CF0 Offset: 0x14082F0 VA: 0x181409CF0 Slot: 38
	internal override DateTime GetDateTime(SqliteStatement stmt, int index) { }

	// RVA: 0x1409B90 Offset: 0x1408190 VA: 0x181409B90 Slot: 37
	internal override long GetBytes(SqliteStatement stmt, int index, int nDataOffset, byte[] bDest, int nStart, int nLength) { }

	// RVA: 0x140A810 Offset: 0x1408E10 VA: 0x18140A810 Slot: 39
	internal override bool IsNull(SqliteStatement stmt, int index) { }

	// RVA: 0x1409970 Offset: 0x1407F70 VA: 0x181409970 Slot: 41
	internal override void CreateFunction(string strFunction, int nArgs, bool needCollSeq, SQLiteCallback func, SQLiteCallback funcstep, SQLiteFinalCallback funcfinal) { }

	// RVA: 0x14097C0 Offset: 0x1407DC0 VA: 0x1814097C0 Slot: 40
	internal override void CreateCollation(string strCollation, SQLiteCollation func, SQLiteCollation func16, IntPtr user_data) { }

	// RVA: 0x1409F80 Offset: 0x1408580 VA: 0x181409F80 Slot: 43
	internal override long GetParamValueBytes(IntPtr p, int nDataOffset, byte[] bDest, int nStart, int nLength) { }

	// RVA: 0x140A0A0 Offset: 0x14086A0 VA: 0x18140A0A0 Slot: 44
	internal override double GetParamValueDouble(IntPtr ptr) { }

	// RVA: 0x140A100 Offset: 0x1408700 VA: 0x18140A100 Slot: 45
	internal override long GetParamValueInt64(IntPtr ptr) { }

	// RVA: 0x140A160 Offset: 0x1408760 VA: 0x18140A160 Slot: 46
	internal override string GetParamValueText(IntPtr ptr) { }

	// RVA: 0x140A1F0 Offset: 0x14087F0 VA: 0x18140A1F0 Slot: 47
	internal override TypeAffinity GetParamValueType(IntPtr ptr) { }

	// RVA: 0x140B460 Offset: 0x1409A60 VA: 0x18140B460 Slot: 48
	internal override void ReturnBlob(IntPtr context, byte[] value) { }

	// RVA: 0x140B500 Offset: 0x1409B00 VA: 0x18140B500 Slot: 49
	internal override void ReturnDouble(IntPtr context, double value) { }

	// RVA: 0x140B570 Offset: 0x1409B70 VA: 0x18140B570 Slot: 50
	internal override void ReturnError(IntPtr context, string value) { }

	// RVA: 0x140B620 Offset: 0x1409C20 VA: 0x18140B620 Slot: 51
	internal override void ReturnInt64(IntPtr context, long value) { }

	// RVA: 0x140B690 Offset: 0x1409C90 VA: 0x18140B690 Slot: 52
	internal override void ReturnNull(IntPtr context) { }

	// RVA: 0x140B6F0 Offset: 0x1409CF0 VA: 0x18140B6F0 Slot: 53
	internal override void ReturnText(IntPtr context, string value) { }

	// RVA: 0x14086A0 Offset: 0x1406CA0 VA: 0x1814086A0 Slot: 42
	internal override IntPtr AggregateContext(IntPtr context) { }

	// RVA: 0x140B920 Offset: 0x1409F20 VA: 0x18140B920 Slot: 54
	internal override void SetPassword(byte[] passwordBytes) { }

	// RVA: 0x140BB50 Offset: 0x140A150 VA: 0x18140BB50 Slot: 55
	internal override void SetUpdateHook(SQLiteUpdateCallback func) { }

	// RVA: 0x140B8A0 Offset: 0x1409EA0 VA: 0x18140B8A0 Slot: 56
	internal override void SetCommitHook(SQLiteCommitCallback func) { }

	// RVA: 0x140BA00 Offset: 0x140A000 VA: 0x18140BA00 Slot: 57
	internal override void SetRollbackHook(SQLiteRollbackCallback func) { }

	// RVA: 0x140A300 Offset: 0x1408900 VA: 0x18140A300 Slot: 60
	internal override object GetValue(SqliteStatement stmt, int index, SQLiteType typ) { }

	// RVA: 0x6869A0 Offset: 0x684FA0 VA: 0x1806869A0 Slot: 58
	internal override int GetCursorForTable(SqliteStatement stmt, int db, int rootPage) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 59
	internal override long GetRowIdForCursor(SqliteStatement stmt, int cursor) { }

	// RVA: 0x1409E20 Offset: 0x1408420 VA: 0x181409E20 Slot: 32
	internal override void GetIndexColumnExtendedInfo(string database, string index, string column, out int sortMode, out int onError, out string collationSequence) { }

}

internal class SQLite3_UTF16 : SQLite3 // TypeDefIndex: 4855
{	// Methods

	// RVA: 0x140C8D0 Offset: 0x140AED0 VA: 0x18140C8D0
	internal void .ctor(SQLiteDateFormats fmt) { }

	// RVA: 0x140C800 Offset: 0x140AE00 VA: 0x18140C800 Slot: 4
	public override string ToString(IntPtr b, int nbytelen) { }

	// RVA: 0x140C810 Offset: 0x140AE10 VA: 0x18140C810
	public static string UTF16ToString(IntPtr b, int nbytelen) { }

	// RVA: 0x140C510 Offset: 0x140AB10 VA: 0x18140C510 Slot: 8
	internal override void Open(string strFilename, SQLiteOpenFlagsEnum flags, int maxPoolSize, bool usePool) { }

	// RVA: 0x140BDF0 Offset: 0x140A3F0 VA: 0x18140BDF0 Slot: 20
	internal override void Bind_DateTime(SqliteStatement stmt, int index, DateTime dt) { }

	// RVA: 0x140BE50 Offset: 0x140A450 VA: 0x18140BE50 Slot: 18
	internal override void Bind_Text(SqliteStatement stmt, int index, string value) { }

	// RVA: 0x140C330 Offset: 0x140A930 VA: 0x18140C330 Slot: 38
	internal override DateTime GetDateTime(SqliteStatement stmt, int index) { }

	// RVA: 0x140C060 Offset: 0x140A660 VA: 0x18140C060 Slot: 25
	internal override string ColumnName(SqliteStatement stmt, int index) { }

	// RVA: 0x140C420 Offset: 0x140AA20 VA: 0x18140C420 Slot: 36
	internal override string GetText(SqliteStatement stmt, int index) { }

	// RVA: 0x140C150 Offset: 0x140A750 VA: 0x18140C150 Slot: 28
	internal override string ColumnOriginalName(SqliteStatement stmt, int index) { }

	// RVA: 0x140BF70 Offset: 0x140A570 VA: 0x18140BF70 Slot: 29
	internal override string ColumnDatabaseName(SqliteStatement stmt, int index) { }

	// RVA: 0x140C240 Offset: 0x140A840 VA: 0x18140C240 Slot: 30
	internal override string ColumnTableName(SqliteStatement stmt, int index) { }

	// RVA: 0x140C360 Offset: 0x140A960 VA: 0x18140C360 Slot: 46
	internal override string GetParamValueText(IntPtr ptr) { }

	// RVA: 0x140C6E0 Offset: 0x140ACE0 VA: 0x18140C6E0 Slot: 50
	internal override void ReturnError(IntPtr context, string value) { }

	// RVA: 0x140C760 Offset: 0x140AD60 VA: 0x18140C760 Slot: 53
	internal override void ReturnText(IntPtr context, string value) { }

}

internal abstract class SQLiteBase : SqliteConvert, IDisposable // TypeDefIndex: 4856
{	// Fields
	internal static object _lock; // 0x134D0

	// Properties
	internal abstract string Version { get; }
	internal abstract int Changes { get; }

	// Methods

	// RVA: 0x140D160 Offset: 0x140B760 VA: 0x18140D160
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

	// RVA: 0x140CC90 Offset: 0x140B290 VA: 0x18140CC90 Slot: 5
	public void Dispose() { }

	// RVA: 0x140D070 Offset: 0x140B670 VA: 0x18140D070
	internal static string SQLiteLastError(SqliteConnectionHandle db) { }

	// RVA: 0x140CCB0 Offset: 0x140B2B0 VA: 0x18140CCB0
	internal static void FinalizeStatement(SqliteStatementHandle stmt) { }

	// RVA: 0x140CA70 Offset: 0x140B070 VA: 0x18140CA70
	internal static void CloseConnection(SqliteConnectionHandle db) { }

	// RVA: 0x140CE20 Offset: 0x140B420 VA: 0x18140CE20
	internal static void ResetConnection(SqliteConnectionHandle db) { }

	// RVA: 0x140D100 Offset: 0x140B700 VA: 0x18140D100
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

	// RVA: 0x1410B30 Offset: 0x140F130 VA: 0x181410B30
	public void .ctor(string commandText, SqliteConnection connection) { }

	// RVA: 0x14107D0 Offset: 0x140EDD0 VA: 0x1814107D0
	public void .ctor(SqliteConnection connection) { }

	// RVA: 0x1410520 Offset: 0x140EB20 VA: 0x181410520
	private void .ctor(SqliteCommand source) { }

	// RVA: 0x14108B0 Offset: 0x140EEB0 VA: 0x1814108B0
	public void .ctor(string commandText, SqliteConnection connection, SqliteTransaction transaction) { }

	// RVA: 0x140FE10 Offset: 0x140E410 VA: 0x18140FE10 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x140FC00 Offset: 0x140E200 VA: 0x18140FC00
	internal void ClearCommands() { }

	// RVA: 0x140F9D0 Offset: 0x140DFD0 VA: 0x18140F9D0
	internal SqliteStatement BuildNextCommand() { }

	// RVA: 0x1410320 Offset: 0x140E920 VA: 0x181410320
	internal SqliteStatement GetStatement(int index) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 12
	public override string get_CommandText() { }

	// RVA: 0x1410C40 Offset: 0x140F240 VA: 0x181410C40 Slot: 13
	public override void set_CommandText(string value) { }

	// RVA: 0x5983B0 Offset: 0x5969B0 VA: 0x1805983B0 Slot: 14
	public override int get_CommandTimeout() { }

	// RVA: 0x5983C0 Offset: 0x5969C0 VA: 0x1805983C0 Slot: 15
	public override void set_CommandTimeout(int value) { }

	// RVA: 0x1410D00 Offset: 0x140F300 VA: 0x181410D00 Slot: 16
	public override void set_CommandType(CommandType value) { }

	// RVA: 0x140FDC0 Offset: 0x140E3C0 VA: 0x18140FDC0 Slot: 26
	protected override DbParameter CreateDbParameter() { }

	// RVA: 0x140FDC0 Offset: 0x140E3C0 VA: 0x18140FDC0
	public SqliteParameter CreateParameter() { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public SqliteConnection get_Connection() { }

	// RVA: 0x1410D60 Offset: 0x140F360 VA: 0x181410D60
	public void set_Connection(SqliteConnection value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 17
	protected override DbConnection get_DbConnection() { }

	// RVA: 0x1410E20 Offset: 0x140F420 VA: 0x181410E20 Slot: 18
	protected override void set_DbConnection(DbConnection value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	public SqliteParameterCollection get_Parameters() { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0 Slot: 19
	protected override DbParameterCollection get_DbParameterCollection() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	public SqliteTransaction get_Transaction() { }

	// RVA: 0x1410F70 Offset: 0x140F570 VA: 0x181410F70
	public void set_Transaction(SqliteTransaction value) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360 Slot: 20
	protected override DbTransaction get_DbTransaction() { }

	// RVA: 0x1410E90 Offset: 0x140F490 VA: 0x181410E90 Slot: 21
	protected override void set_DbTransaction(DbTransaction value) { }

	// RVA: 0x14103E0 Offset: 0x140E9E0 VA: 0x1814103E0
	private void InitializeForReader() { }

	// RVA: 0x140FFA0 Offset: 0x140E5A0 VA: 0x18140FFA0 Slot: 27
	protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior) { }

	// RVA: 0x14100C0 Offset: 0x140E6C0 VA: 0x1814100C0
	public SqliteDataReader ExecuteReader(CommandBehavior behavior) { }

	// RVA: 0x1410310 Offset: 0x140E910 VA: 0x181410310
	public SqliteDataReader ExecuteReader() { }

	// RVA: 0x809B70 Offset: 0x808170 VA: 0x180809B70
	internal void ClearDataReader() { }

	// RVA: 0x140FFB0 Offset: 0x140E5B0 VA: 0x18140FFB0 Slot: 28
	public override int ExecuteNonQuery() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 29
	public override void Prepare() { }

	// RVA: 0x8D9520 Offset: 0x8D7B20 VA: 0x1808D9520 Slot: 24
	public override UpdateRowSource get_UpdatedRowSource() { }

	// RVA: 0x8D9560 Offset: 0x8D7B60 VA: 0x1808D9560 Slot: 25
	public override void set_UpdatedRowSource(UpdateRowSource value) { }

	// RVA: 0xC21200 Offset: 0xC1F800 VA: 0x180C21200 Slot: 22
	public override bool get_DesignTimeVisible() { }

	// RVA: 0x1410F00 Offset: 0x140F500 VA: 0x181410F00 Slot: 23
	public override void set_DesignTimeVisible(bool value) { }

	// RVA: 0x140FD60 Offset: 0x140E360 VA: 0x18140FD60 Slot: 30
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

	// RVA: 0x140F850 Offset: 0x140DE50 VA: 0x18140F850
	public void .ctor() { }

	// RVA: 0x140F8D0 Offset: 0x140DED0 VA: 0x18140F8D0
	public void .ctor(SqliteDataAdapter adp) { }

	// RVA: 0x140EA30 Offset: 0x140D030 VA: 0x18140EA30 Slot: 25
	protected override void ApplyParameterInfo(DbParameter parameter, DataRow row, StatementType statementType, bool whereClause) { }

	// RVA: 0x140EBD0 Offset: 0x140D1D0 VA: 0x18140EBD0 Slot: 27
	protected override string GetParameterName(string parameterName) { }

	// RVA: 0x140EB40 Offset: 0x140D140 VA: 0x18140EB40 Slot: 26
	protected override string GetParameterName(int parameterOrdinal) { }

	// RVA: 0x140EC40 Offset: 0x140D240 VA: 0x18140EC40 Slot: 28
	protected override string GetParameterPlaceholder(int parameterOrdinal) { }

	// RVA: 0x140F4F0 Offset: 0x140DAF0 VA: 0x18140F4F0 Slot: 29
	protected override void SetRowUpdatingHandler(DbDataAdapter adapter) { }

	// RVA: 0x140F4E0 Offset: 0x140DAE0 VA: 0x18140F4E0
	private void RowUpdatingEventHandler(object sender, RowUpdatingEventArgs e) { }

	// RVA: 0x140F9A0 Offset: 0x140DFA0 VA: 0x18140F9A0
	public void set_DataAdapter(SqliteDataAdapter value) { }

	// RVA: 0x5828D0 Offset: 0x580ED0 VA: 0x1805828D0 Slot: 13
	public override CatalogLocation get_CatalogLocation() { }

	// RVA: 0x140F960 Offset: 0x140DF60 VA: 0x18140F960 Slot: 14
	public override string get_CatalogSeparator() { }

	// RVA: 0x140F970 Offset: 0x140DF70 VA: 0x18140F970 Slot: 15
	public override string get_QuotePrefix() { }

	// RVA: 0x140F9B0 Offset: 0x140DFB0 VA: 0x18140F9B0 Slot: 16
	public override void set_QuotePrefix(string value) { }

	// RVA: 0x140F980 Offset: 0x140DF80 VA: 0x18140F980 Slot: 17
	public override string get_QuoteSuffix() { }

	// RVA: 0x140F9C0 Offset: 0x140DFC0 VA: 0x18140F9C0 Slot: 18
	public override void set_QuoteSuffix(string value) { }

	// RVA: 0x140F090 Offset: 0x140D690 VA: 0x18140F090 Slot: 22
	public override string QuoteIdentifier(string unquotedIdentifier) { }

	// RVA: 0x140F670 Offset: 0x140DC70 VA: 0x18140F670 Slot: 24
	public override string UnquoteIdentifier(string quotedIdentifier) { }

	// RVA: 0x140F990 Offset: 0x140DF90 VA: 0x18140F990 Slot: 19
	public override string get_SchemaSeparator() { }

	// RVA: 0x140EC60 Offset: 0x140D260 VA: 0x18140EC60 Slot: 20
	protected override DataTable GetSchemaTable(DbCommand sourceCommand) { }

	// RVA: 0x140EDF0 Offset: 0x140D3F0 VA: 0x18140EDF0
	private bool HasSchemaPrimaryKey(DataTable schema) { }

	// RVA: 0x140F1E0 Offset: 0x140D7E0 VA: 0x18140F1E0
	private void ResetIsUniqueSchemaColumn(DataTable schema) { }

}

internal sealed class SQLiteUpdateCallback : MulticastDelegate // TypeDefIndex: 4861
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140E420 Offset: 0x140CA20 VA: 0x18140E420 Slot: 12
	public virtual void Invoke(IntPtr puser, int type, IntPtr database, IntPtr table, long rowid) { }

	// RVA: 0x140E340 Offset: 0x140C940 VA: 0x18140E340 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr puser, int type, IntPtr database, IntPtr table, long rowid, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteCommitCallback : MulticastDelegate // TypeDefIndex: 4862
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140DB00 Offset: 0x140C100 VA: 0x18140DB00 Slot: 12
	public virtual int Invoke(IntPtr puser) { }

	// RVA: 0x140DA80 Offset: 0x140C080 VA: 0x18140DA80 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr puser, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteRollbackCallback : MulticastDelegate // TypeDefIndex: 4863
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140E0D0 Offset: 0x140C6D0 VA: 0x18140E0D0 Slot: 12
	public virtual void Invoke(IntPtr puser) { }

	// RVA: 0x140E2C0 Offset: 0x140C8C0 VA: 0x18140E2C0 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr puser, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class SQLiteCommitHandler : MulticastDelegate // TypeDefIndex: 4864
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, CommitEventArgs e) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, CommitEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class SQLiteUpdateEventHandler : MulticastDelegate // TypeDefIndex: 4865
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xAE4D50 Offset: 0xAE3350 VA: 0x180AE4D50 Slot: 12
	public virtual void Invoke(object sender, UpdateEventArgs e) { }

	// RVA: 0xAE4D10 Offset: 0xAE3310 VA: 0x180AE4D10 Slot: 13
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

	// RVA: 0x1411550 Offset: 0x140FB50 VA: 0x181411550
	internal static SqliteConnectionHandle Remove(string fileName, int maxPoolSize, out int version) { }

	// RVA: 0x1411230 Offset: 0x140F830 VA: 0x181411230
	internal static void Add(string fileName, SqliteConnectionHandle hdl, int version) { }

	// RVA: 0x14118E0 Offset: 0x140FEE0 VA: 0x1814118E0
	private static void ResizePool(SqliteConnectionPool.Pool queue, bool forAdding) { }

	// RVA: 0x14119D0 Offset: 0x140FFD0 VA: 0x1814119D0
	private static void .cctor() { }

}

internal class SqliteConnectionPool.Pool // TypeDefIndex: 4869
{	// Fields
	internal readonly Queue<WeakReference> Queue; // 0x10
	internal int PoolVersion; // 0x18
	internal int MaxPoolSize; // 0x1C

	// Methods

	// RVA: 0x1408610 Offset: 0x1406C10 VA: 0x181408610
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

	// RVA: 0x141F0C0 Offset: 0x141D6C0 VA: 0x18141F0C0
	public static byte[] ToUTF8(string sourceText) { }

	// RVA: 0x141F050 Offset: 0x141D650 VA: 0x18141F050
	public byte[] ToUTF8(DateTime dateTimeValue) { }

	// RVA: 0x141EFF0 Offset: 0x141D5F0 VA: 0x18141EFF0 Slot: 4
	public virtual string ToString(IntPtr nativestring, int nativestringlen) { }

	// RVA: 0x141F790 Offset: 0x141DD90 VA: 0x18141F790
	public static string UTF8ToString(IntPtr nativestring, int nativestringlen) { }

	// RVA: 0x141EA60 Offset: 0x141D060 VA: 0x18141EA60
	public DateTime ToDateTime(string dateText) { }

	// RVA: 0x141ED40 Offset: 0x141D340 VA: 0x18141ED40
	public DateTime ToDateTime(double julianDay) { }

	// RVA: 0x141EDA0 Offset: 0x141D3A0 VA: 0x18141EDA0
	public double ToJulianDay(DateTime value) { }

	// RVA: 0x141EDD0 Offset: 0x141D3D0 VA: 0x18141EDD0
	public string ToString(DateTime dateValue) { }

	// RVA: 0x141EA30 Offset: 0x141D030 VA: 0x18141EA30
	internal DateTime ToDateTime(IntPtr ptr, int len) { }

	// RVA: 0x141E460 Offset: 0x141CA60 VA: 0x18141E460
	public static string[] Split(string source, char separator) { }

	// RVA: 0x141E7E0 Offset: 0x141CDE0 VA: 0x18141E7E0
	public static bool ToBoolean(string source) { }

	// RVA: 0x141E320 Offset: 0x141C920 VA: 0x18141E320
	internal static Type SQLiteTypeToType(SQLiteType t) { }

	// RVA: 0x141F620 Offset: 0x141DC20 VA: 0x18141F620
	internal static DbType TypeToDbType(Type typ) { }

	// RVA: 0x141DF80 Offset: 0x141C580 VA: 0x18141DF80
	internal static int DbTypeToColumnSize(DbType typ) { }

	// RVA: 0x141E010 Offset: 0x141C610 VA: 0x18141E010
	internal static object DbTypeToNumericPrecision(DbType typ) { }

	// RVA: 0x141E0A0 Offset: 0x141C6A0 VA: 0x18141E0A0
	internal static object DbTypeToNumericScale(DbType typ) { }

	// RVA: 0x141E130 Offset: 0x141C730 VA: 0x18141E130
	internal static string DbTypeToTypeName(DbType typ) { }

	// RVA: 0x141E290 Offset: 0x141C890 VA: 0x18141E290
	internal static Type DbTypeToType(DbType typ) { }

	// RVA: 0x141F4C0 Offset: 0x141DAC0 VA: 0x18141F4C0
	internal static TypeAffinity TypeToAffinity(Type typ) { }

	// RVA: 0x141F1D0 Offset: 0x141D7D0 VA: 0x18141F1D0
	internal static DbType TypeNameToDbType(string Name) { }

	// RVA: 0x141F8F0 Offset: 0x141DEF0 VA: 0x18141F8F0
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

	// RVA: 0x14242E0 Offset: 0x14228E0 VA: 0x1814242E0
	public void add_RowUpdating(EventHandler<RowUpdatingEventArgs> value) { }

	// RVA: 0x14245B0 Offset: 0x1422BB0 VA: 0x1814245B0
	public void remove_RowUpdating(EventHandler<RowUpdatingEventArgs> value) { }

	// RVA: 0x1424160 Offset: 0x1422760 VA: 0x181424160
	internal static Delegate FindBuilder(MulticastDelegate mcd) { }

	// RVA: 0x1424250 Offset: 0x1422850 VA: 0x181424250
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

	// RVA: 0x1428460 Offset: 0x1426A60 VA: 0x181428460
	internal void .ctor(SqliteCommand cmd, CommandBehavior behave) { }

	// RVA: 0x14247D0 Offset: 0x1422DD0 VA: 0x1814247D0 Slot: 21
	public override void Close() { }

	// RVA: 0x1424640 Offset: 0x1422C40 VA: 0x181424640
	private void CheckClosed() { }

	// RVA: 0x1424760 Offset: 0x1422D60 VA: 0x181424760
	private void CheckValidRow() { }

	// RVA: 0x1424CB0 Offset: 0x14232B0 VA: 0x181424CB0 Slot: 24
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x1428510 Offset: 0x1426B10 VA: 0x181428510 Slot: 17
	public override int get_FieldCount() { }

	// RVA: 0x1428580 Offset: 0x1426B80 VA: 0x181428580 Slot: 19
	public override int get_VisibleFieldCount() { }

	// RVA: 0x14282E0 Offset: 0x14268E0 VA: 0x1814282E0
	private TypeAffinity VerifyType(int i, DbType typ) { }

	// RVA: 0x1424A20 Offset: 0x1423020 VA: 0x181424A20 Slot: 28
	public override bool GetBoolean(int i) { }

	// RVA: 0x1424BF0 Offset: 0x14231F0 VA: 0x181424BF0 Slot: 23
	public override string GetDataTypeName(int i) { }

	// RVA: 0x1424D20 Offset: 0x1423320 VA: 0x181424D20 Slot: 25
	public override Type GetFieldType(int i) { }

	// RVA: 0x1424DF0 Offset: 0x14233F0 VA: 0x181424DF0 Slot: 29
	public override int GetInt32(int i) { }

	// RVA: 0x1424F60 Offset: 0x1423560 VA: 0x181424F60 Slot: 30
	public override long GetInt64(int i) { }

	// RVA: 0x14250D0 Offset: 0x14236D0 VA: 0x1814250D0 Slot: 26
	public override string GetName(int i) { }

	// RVA: 0x1425380 Offset: 0x1423980 VA: 0x181425380 Slot: 27
	public override DataTable GetSchemaTable() { }

	// RVA: 0x1425390 Offset: 0x1423990 VA: 0x181425390
	internal DataTable GetSchemaTable(bool wantUniqueInfo, bool wantDefaultValue) { }

	// RVA: 0x1427AD0 Offset: 0x14260D0 VA: 0x181427AD0 Slot: 31
	public override string GetString(int i) { }

	// RVA: 0x1427C40 Offset: 0x1426240 VA: 0x181427C40 Slot: 32
	public override object GetValue(int i) { }

	// RVA: 0x1427D00 Offset: 0x1426300 VA: 0x181427D00 Slot: 33
	public override int GetValues(object[] values) { }

	// RVA: 0x1427DF0 Offset: 0x14263F0 VA: 0x181427DF0 Slot: 34
	public override bool IsDBNull(int i) { }

	// RVA: 0x1427F50 Offset: 0x1426550 VA: 0x181427F50 Slot: 35
	public override bool NextResult() { }

	// RVA: 0x1425170 Offset: 0x1423770 VA: 0x181425170
	private SQLiteType GetSQLiteType(int i) { }

	// RVA: 0x1428250 Offset: 0x1426850 VA: 0x181428250 Slot: 36
	public override bool Read() { }

	// RVA: 0x1428570 Offset: 0x1426B70 VA: 0x181428570 Slot: 18
	public override int get_RecordsAffected() { }

	// RVA: 0x1428550 Offset: 0x1426B50 VA: 0x181428550 Slot: 20
	public override object get_Item(int i) { }

	// RVA: 0x1427E90 Offset: 0x1426490 VA: 0x181427E90
	private void LoadKeyInfo() { }

	// RVA: 0x1428420 Offset: 0x1426A20 VA: 0x181428420
	private static void .cctor() { }

}

internal class SQLiteEnlistment : IEnlistmentNotification // TypeDefIndex: 4877
{	// Fields
	internal SqliteTransaction _transaction; // 0x10
	internal Transaction _scope; // 0x18
	internal bool _disposeConnection; // 0x20

	// Methods

	// RVA: 0x140DF80 Offset: 0x140C580 VA: 0x18140DF80
	internal void .ctor(SqliteConnection cnn, Transaction scope) { }

	// RVA: 0x140DE00 Offset: 0x140C400 VA: 0x18140DE00
	private void Cleanup(SqliteConnection cnn) { }

	// RVA: 0x140DE50 Offset: 0x140C450 VA: 0x18140DE50 Slot: 4
	public void Rollback(Enlistment enlistment) { }

}

public sealed class SqliteException : DbException // TypeDefIndex: 4878
{	// Fields
	private SQLiteErrorCode _errorCode; // 0x88
	private static string[] _errorMessages; // 0x0

	// Methods

	// RVA: 0x21F2810 Offset: 0x21F0E10 VA: 0x1821F2810
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x21F2830 Offset: 0x21F0E30 VA: 0x1821F2830
	public void .ctor(int errorCode, string extendedInformation) { }

	// RVA: 0x21F29B0 Offset: 0x21F0FB0 VA: 0x1821F29B0
	public void .ctor() { }

	// RVA: 0x21F1BF0 Offset: 0x21F01F0 VA: 0x1821F1BF0
	private static string GetStockErrorMessage(int errorCode, string errorMessage) { }

	// RVA: 0x21F1CF0 Offset: 0x21F02F0 VA: 0x1821F1CF0
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

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 4
	public virtual object Invoke(object[] args) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public virtual void Step(object[] args, int stepNumber, ref object contextData) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 6
	public virtual object Final(object contextData) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 7
	public virtual int Compare(string param1, string param2) { }

	// RVA: 0x21F3450 Offset: 0x21F1A50 VA: 0x1821F3450
	internal object[] ConvertParams(int nArgs, IntPtr argsptr) { }

	// RVA: 0x21F3B30 Offset: 0x21F2130 VA: 0x1821F3B30
	private void SetReturnValue(IntPtr context, object returnValue) { }

	// RVA: 0x21F3AD0 Offset: 0x21F20D0 VA: 0x1821F3AD0
	internal void ScalarCallback(IntPtr context, int nArgs, IntPtr argsptr) { }

	// RVA: 0x21F33B0 Offset: 0x21F19B0 VA: 0x1821F33B0
	internal int CompareCallback(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2) { }

	// RVA: 0x21F3350 Offset: 0x21F1950 VA: 0x1821F3350
	internal int CompareCallback16(IntPtr ptr, int len1, IntPtr ptr1, int len2, IntPtr ptr2) { }

	// RVA: 0x21F3EE0 Offset: 0x21F24E0 VA: 0x1821F3EE0
	internal void StepCallback(IntPtr context, int nArgs, IntPtr argsptr) { }

	// RVA: 0x21F39A0 Offset: 0x21F1FA0 VA: 0x1821F39A0
	internal void FinalCallback(IntPtr context) { }

	// RVA: 0x21F4080 Offset: 0x21F2680 VA: 0x1821F4080
	private static void .cctor() { }

	// RVA: 0x21F2EF0 Offset: 0x21F14F0 VA: 0x1821F2EF0
	internal static SqliteFunction[] BindFunctions(SQLiteBase sqlbase) { }

}

private class SqliteFunction.AggregateData // TypeDefIndex: 4881
{	// Fields
	internal int _count; // 0x10
	internal object _data; // 0x18

	// Methods

	// RVA: 0x1077810 Offset: 0x1075E10 VA: 0x181077810
	public void .ctor() { }

}

internal sealed class SQLiteCallback : MulticastDelegate // TypeDefIndex: 4884
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140D260 Offset: 0x140B860 VA: 0x18140D260 Slot: 12
	public virtual void Invoke(IntPtr context, int nArgs, IntPtr argsptr) { }

	// RVA: 0x140D1C0 Offset: 0x140B7C0 VA: 0x18140D1C0 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr context, int nArgs, IntPtr argsptr, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteFinalCallback : MulticastDelegate // TypeDefIndex: 4885
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140E0D0 Offset: 0x140C6D0 VA: 0x18140E0D0 Slot: 12
	public virtual void Invoke(IntPtr context) { }

	// RVA: 0x140E050 Offset: 0x140C650 VA: 0x18140E050 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr context, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal sealed class SQLiteCollation : MulticastDelegate // TypeDefIndex: 4886
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x140D6A0 Offset: 0x140BCA0 VA: 0x18140D6A0 Slot: 12
	public virtual int Invoke(IntPtr puser, int len1, IntPtr pv1, int len2, IntPtr pv2) { }

	// RVA: 0x140D5C0 Offset: 0x140BBC0 VA: 0x18140D5C0 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr puser, int len1, IntPtr pv1, int len2, IntPtr pv2, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
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

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Name() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_Arguments() { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0
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

	// RVA: 0x21F5C80 Offset: 0x21F4280 VA: 0x1821F5C80
	internal void .ctor(SqliteConnection cnn, SqliteDataReader reader, SqliteStatement stmt) { }

	// RVA: 0xD87C40 Offset: 0xD86240 VA: 0x180D87C40
	internal int get_Count() { }

	// RVA: 0x21F5BE0 Offset: 0x21F41E0 VA: 0x1821F5BE0
	internal void Sync(int i) { }

	// RVA: 0x21F5AF0 Offset: 0x21F40F0 VA: 0x1821F5AF0
	internal void Sync() { }

	// RVA: 0x21F5A20 Offset: 0x21F4020 VA: 0x1821F5A20
	internal void Reset() { }

	// RVA: 0x21F4ED0 Offset: 0x21F34D0 VA: 0x1821F4ED0 Slot: 4
	public void Dispose() { }

	// RVA: 0x21F5040 Offset: 0x21F3640 VA: 0x1821F5040
	internal string GetDataTypeName(int i) { }

	// RVA: 0x21F50F0 Offset: 0x21F36F0 VA: 0x1821F50F0
	internal Type GetFieldType(int i) { }

	// RVA: 0x21F5420 Offset: 0x21F3A20 VA: 0x1821F5420
	internal string GetName(int i) { }

	// RVA: 0x21F4F70 Offset: 0x21F3570 VA: 0x1821F4F70
	internal bool GetBoolean(int i) { }

	// RVA: 0x21F51C0 Offset: 0x21F37C0 VA: 0x1821F51C0
	internal int GetInt32(int i) { }

	// RVA: 0x21F52F0 Offset: 0x21F38F0 VA: 0x1821F52F0
	internal long GetInt64(int i) { }

	// RVA: 0x21F5460 Offset: 0x21F3A60 VA: 0x1821F5460
	internal string GetString(int i) { }

	// RVA: 0x21F5530 Offset: 0x21F3B30 VA: 0x1821F5530
	internal object GetValue(int i) { }

	// RVA: 0x21F58C0 Offset: 0x21F3EC0 VA: 0x1821F58C0
	internal bool IsDBNull(int i) { }

	// RVA: 0x21F44C0 Offset: 0x21F2AC0 VA: 0x1821F44C0
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

	// RVA: 0x21F1840 Offset: 0x21EFE40 VA: 0x1821F1840
	internal void .ctor(SqliteConnection cnn, string database, string table, string[] columns) { }

	// RVA: 0x21F1B60 Offset: 0x21F0160 VA: 0x1821F1B60
	internal void set_IsValid(bool value) { }

	// RVA: 0x21F16E0 Offset: 0x21EFCE0 VA: 0x1821F16E0
	internal void Sync(long rowid) { }

	// RVA: 0x21F1660 Offset: 0x21EFC60 VA: 0x1821F1660 Slot: 4
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

	// RVA: 0x21F8540 Offset: 0x21F6B40 VA: 0x1821F8540
	public void .ctor() { }

	// RVA: 0x21F88C0 Offset: 0x21F6EC0 VA: 0x1821F88C0
	public void .ctor(string parameterName, object value) { }

	// RVA: 0x21F8830 Offset: 0x21F6E30 VA: 0x1821F8830
	public void .ctor(string parameterName, DbType parameterType, int parameterSize, string sourceColumn, DataRowVersion rowVersion) { }

	// RVA: 0x21F8690 Offset: 0x21F6C90 VA: 0x1821F8690
	private void .ctor(SqliteParameter source) { }

	[EditorBrowsableAttribute] // RVA: 0x8CD10 Offset: 0x8C110 VA: 0x18008CD10
	// RVA: 0x21F85B0 Offset: 0x21F6BB0 VA: 0x1821F85B0
	public void .ctor(string parameterName, DbType parameterType, int parameterSize, ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, DataRowVersion rowVersion, object value) { }

	// RVA: 0xC66170 Offset: 0xC64770 VA: 0x180C66170 Slot: 10
	public override bool get_IsNullable() { }

	// RVA: 0xE73A10 Offset: 0xE72010 VA: 0x180E73A10 Slot: 11
	public override void set_IsNullable(bool value) { }

	// RVA: 0x21F8950 Offset: 0x21F6F50 VA: 0x1821F8950 Slot: 6
	public override DbType get_DbType() { }

	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0 Slot: 7
	public override void set_DbType(DbType value) { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 8
	public override ParameterDirection get_Direction() { }

	// RVA: 0x21F8A20 Offset: 0x21F7020 VA: 0x1821F8A20 Slot: 9
	public override void set_Direction(ParameterDirection value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0 Slot: 12
	public override string get_ParameterName() { }

	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010 Slot: 13
	public override void set_ParameterName(string value) { }

	// RVA: 0xC75070 Offset: 0xC73670 VA: 0x180C75070 Slot: 14
	public override void set_Size(int value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 15
	public override string get_SourceColumn() { }

	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0 Slot: 16
	public override void set_SourceColumn(string value) { }

	// RVA: 0x21F8A80 Offset: 0x21F7080 VA: 0x1821F8A80 Slot: 17
	public override void set_SourceColumnNullMapping(bool value) { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0 Slot: 18
	public override DataRowVersion get_SourceVersion() { }

	// RVA: 0x960000 Offset: 0x95E600 VA: 0x180960000 Slot: 19
	public override void set_SourceVersion(DataRowVersion value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 20
	public override object get_Value() { }

	// RVA: 0x21F8A90 Offset: 0x21F7090 VA: 0x1821F8A90 Slot: 21
	public override void set_Value(object value) { }

	// RVA: 0x21F8370 Offset: 0x21F6970 VA: 0x1821F8370 Slot: 22
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

	// RVA: 0x21F8240 Offset: 0x21F6840 VA: 0x1821F8240
	internal void .ctor(SqliteCommand cmd) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 22
	public override bool get_IsFixedSize() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 23
	public override bool get_IsReadOnly() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 24
	public override object get_SyncRoot() { }

	// RVA: 0x21F79E0 Offset: 0x21F5FE0 VA: 0x1821F79E0 Slot: 29
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x21F77E0 Offset: 0x21F5DE0 VA: 0x1821F77E0
	public int Add(SqliteParameter parameter) { }

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	// RVA: 0x21F7770 Offset: 0x21F5D70 VA: 0x1821F7770 Slot: 25
	public override int Add(object value) { }

	// RVA: 0x21F7690 Offset: 0x21F5C90 VA: 0x1821F7690
	public SqliteParameter AddWithValue(string parameterName, object value) { }

	// RVA: 0x21F78C0 Offset: 0x21F5EC0 VA: 0x1821F78C0 Slot: 28
	public override void Clear() { }

	// RVA: 0x21F7910 Offset: 0x21F5F10 VA: 0x1821F7910 Slot: 26
	public override bool Contains(object value) { }

	// RVA: 0x21F7990 Offset: 0x21F5F90 VA: 0x1821F7990 Slot: 27
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x21F82C0 Offset: 0x21F68C0 VA: 0x1821F82C0 Slot: 21
	public override int get_Count() { }

	// RVA: 0x21F8300 Offset: 0x21F6900 VA: 0x1821F8300
	public SqliteParameter get_Item(int index) { }

	// RVA: 0x21F7A60 Offset: 0x21F6060 VA: 0x1821F7A60 Slot: 30
	protected override DbParameter GetParameter(int index) { }

	// RVA: 0x21F7AC0 Offset: 0x21F60C0 VA: 0x1821F7AC0 Slot: 32
	public override int IndexOf(string parameterName) { }

	// RVA: 0x21F7C00 Offset: 0x21F6200 VA: 0x1821F7C00 Slot: 31
	public override int IndexOf(object value) { }

	// RVA: 0x21F7C80 Offset: 0x21F6280 VA: 0x1821F7C80 Slot: 33
	public override void Insert(int index, object value) { }

	// RVA: 0x21F8130 Offset: 0x21F6730 VA: 0x1821F8130 Slot: 34
	public override void Remove(object value) { }

	// RVA: 0x21F80D0 Offset: 0x21F66D0 VA: 0x1821F80D0 Slot: 35
	public override void RemoveAt(int index) { }

	// RVA: 0x21F81B0 Offset: 0x21F67B0 VA: 0x1821F81B0 Slot: 36
	protected override void SetParameter(int index, DbParameter value) { }

	// RVA: 0x4A04D0 Offset: 0x49EAD0 VA: 0x1804A04D0
	internal void Unbind() { }

	// RVA: 0x21F7D10 Offset: 0x21F6310 VA: 0x1821F7D10
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

	// RVA: 0x21F9840 Offset: 0x21F7E40 VA: 0x1821F9840
	internal void .ctor(SQLiteBase sqlbase, SqliteStatementHandle stmt, string strCommand, SqliteStatement previous) { }

	// RVA: 0x21F93E0 Offset: 0x21F79E0 VA: 0x1821F93E0
	internal bool MapParameter(string s, SqliteParameter p) { }

	// RVA: 0x21F9360 Offset: 0x21F7960 VA: 0x1821F9360 Slot: 4
	public void Dispose() { }

	// RVA: 0x21F92E0 Offset: 0x21F78E0 VA: 0x1821F92E0
	internal void BindParameters() { }

	// RVA: 0x21F8D30 Offset: 0x21F7330 VA: 0x1821F8D30
	private void BindParameter(int index, SqliteParameter param) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	internal string[] get_TypeDefinitions() { }

	// RVA: 0x21F95F0 Offset: 0x21F7BF0 VA: 0x1821F95F0
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

	// RVA: 0x21F9FE0 Offset: 0x21F85E0 VA: 0x1821F9FE0
	internal void .ctor(SqliteConnection connection, bool deferredLock) { }

	// RVA: 0x21F9A90 Offset: 0x21F8090 VA: 0x1821F9A90 Slot: 7
	public override void Commit() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public SqliteConnection get_Connection() { }

	// RVA: 0x21F9BE0 Offset: 0x21F81E0 VA: 0x1821F9BE0 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x21F9F90 Offset: 0x21F8590 VA: 0x1821F9F90 Slot: 9
	public override void Rollback() { }

	// RVA: 0x21F9E80 Offset: 0x21F8480 VA: 0x1821F9E80
	internal static void IssueRollback(SqliteConnection cnn) { }

	// RVA: 0x21F9D20 Offset: 0x21F8320 VA: 0x1821F9D20
	internal bool IsValid(bool throwError) { }

}

internal class SqliteConnectionHandle : CriticalHandle // TypeDefIndex: 4897
{	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x691EB0 Offset: 0x6904B0 VA: 0x180691EB0
	public static IntPtr op_Implicit(SqliteConnectionHandle db) { }

	// RVA: 0x14111B0 Offset: 0x140F7B0 VA: 0x1814111B0
	public static SqliteConnectionHandle op_Implicit(IntPtr db) { }

	// RVA: 0x1411120 Offset: 0x140F720 VA: 0x181411120
	private void .ctor(IntPtr db) { }

	// RVA: 0x14110E0 Offset: 0x140F6E0 VA: 0x1814110E0
	internal void .ctor() { }

	// RVA: 0x1411070 Offset: 0x140F670 VA: 0x181411070 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x1411170 Offset: 0x140F770 VA: 0x181411170 Slot: 5
	public override bool get_IsInvalid() { }

}

internal class SqliteStatementHandle : CriticalHandle // TypeDefIndex: 4898
{	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x691EB0 Offset: 0x6904B0 VA: 0x180691EB0
	public static IntPtr op_Implicit(SqliteStatementHandle stmt) { }

	// RVA: 0x21F8CB0 Offset: 0x21F72B0 VA: 0x1821F8CB0
	public static SqliteStatementHandle op_Implicit(IntPtr stmt) { }

	// RVA: 0x21F8BE0 Offset: 0x21F71E0 VA: 0x1821F8BE0
	private void .ctor(IntPtr stmt) { }

	// RVA: 0x21F8C30 Offset: 0x21F7230 VA: 0x1821F8C30
	internal void .ctor() { }

	// RVA: 0x21F8B70 Offset: 0x21F7170 VA: 0x1821F8B70 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x21F8C70 Offset: 0x21F7270 VA: 0x1821F8C70 Slot: 5
	public override bool get_IsInvalid() { }

}

public class SqliteException : Exception // TypeDefIndex: 7360
{	// Methods

	// RVA: 0x231F9C0 Offset: 0x231DFC0 VA: 0x18231F9C0
	public void .ctor(string message) { }

}

