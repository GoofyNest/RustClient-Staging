public class WebHeaderCollection : NameValueCollection, ISerializable // TypeDefIndex: 2902
{	// Fields
	private static readonly HeaderInfoTable HInfo; // 0x0
	private string[] m_CommonHeaders; // 0x60
	private int m_NumCommonHeaders; // 0x68
	private static readonly string[] s_CommonHeaderNames; // 0x8
	private static readonly sbyte[] s_CommonHeaderHints; // 0x10
	private NameValueCollection m_InnerCollection; // 0x70
	private WebHeaderCollectionType m_Type; // 0x78
	private static readonly char[] HttpTrimCharacters; // 0x18
	private static WebHeaderCollection.RfcChar[] RfcCharMap; // 0x20

	// Properties
	private NameValueCollection InnerCollection { get; }
	private bool AllowHttpRequestHeader { get; }
	public string Item { get; set; }
	public override int Count { get; }
	public override string[] AllKeys { get; }

	// Methods

	// RVA: 0x118A360 Offset: 0x1188960 VA: 0x18118A360
	private void NormalizeCommonHeaders() { }

	// RVA: 0x118BA40 Offset: 0x118A040 VA: 0x18118BA40
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0x1189190 Offset: 0x1187790 VA: 0x181189190
	internal static bool AllowMultiValues(string name) { }

	// RVA: 0x118B9D0 Offset: 0x1189FD0 VA: 0x18118B9D0
	private bool get_AllowHttpRequestHeader() { }

	// RVA: 0x118BAF0 Offset: 0x118A0F0 VA: 0x18118BAF0
	public string get_Item(HttpRequestHeader header) { }

	// RVA: 0x118BBC0 Offset: 0x118A1C0 VA: 0x18118BBC0
	public void set_Item(HttpRequestHeader header, string value) { }

	// RVA: 0x118A550 Offset: 0x1188B50 VA: 0x18118A550
	public void Remove(HttpRequestHeader header) { }

	// RVA: 0x1188D00 Offset: 0x1187300 VA: 0x181188D00
	internal void AddInternal(string name, string value) { }

	// RVA: 0x1189230 Offset: 0x1187830 VA: 0x181189230
	internal void ChangeInternal(string name, string value) { }

	// RVA: 0x118A4F0 Offset: 0x1188AF0 VA: 0x18118A4F0
	internal void RemoveInternal(string name) { }

	// RVA: 0x1189720 Offset: 0x1187D20 VA: 0x181189720
	internal void CheckUpdate(string name, string value) { }

	// RVA: 0x11892A0 Offset: 0x11878A0 VA: 0x1811892A0
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x11897E0 Offset: 0x1187DE0 VA: 0x1811897E0
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x118AB30 Offset: 0x1189130 VA: 0x18118AB30
	internal void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x1189000 Offset: 0x1187600 VA: 0x181189000 Slot: 14
	public override void Add(string name, string value) { }

	// RVA: 0x1188D70 Offset: 0x1187370 VA: 0x181188D70
	public void Add(string header) { }

	// RVA: 0x118A930 Offset: 0x1188F30 VA: 0x18118A930 Slot: 17
	public override void Set(string name, string value) { }

	// RVA: 0x118A740 Offset: 0x1188D40 VA: 0x18118A740
	internal void SetInternal(string name, string value) { }

	// RVA: 0x118A630 Offset: 0x1188C30 VA: 0x18118A630 Slot: 18
	public override void Remove(string name) { }

	// RVA: 0x1189CD0 Offset: 0x11882D0 VA: 0x181189CD0 Slot: 16
	public override string[] GetValues(string header) { }

	// RVA: 0x118AD30 Offset: 0x1189330 VA: 0x18118AD30 Slot: 3
	public override string ToString() { }

	// RVA: 0x1189850 Offset: 0x1187E50 VA: 0x181189850
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x118B920 Offset: 0x1189F20 VA: 0x18118B920
	public void .ctor() { }

	// RVA: 0x118B840 Offset: 0x1189E40 VA: 0x18118B840
	internal void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x118B680 Offset: 0x1189C80 VA: 0x18118B680
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	public override void OnDeserialization(object sender) { }

	// RVA: 0x1189B60 Offset: 0x1188160 VA: 0x181189B60 Slot: 10
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11888A0 Offset: 0x1186EA0 VA: 0x1811888A0 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1189F90 Offset: 0x1188590 VA: 0x181189F90 Slot: 15
	public override string Get(string name) { }

	// RVA: 0x1189AA0 Offset: 0x11880A0 VA: 0x181189AA0 Slot: 12
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x118BA00 Offset: 0x118A000 VA: 0x18118BA00 Slot: 13
	public override int get_Count() { }

	// RVA: 0x1189F40 Offset: 0x1188540 VA: 0x181189F40 Slot: 19
	public override string Get(int index) { }

	// RVA: 0x1189EF0 Offset: 0x11884F0 VA: 0x181189EF0 Slot: 20
	public override string[] GetValues(int index) { }

	// RVA: 0x1189B10 Offset: 0x1188110 VA: 0x181189B10 Slot: 21
	public override string GetKey(int index) { }

	// RVA: 0x118B990 Offset: 0x1189F90 VA: 0x18118B990 Slot: 22
	public override string[] get_AllKeys() { }

	// RVA: 0x118AD90 Offset: 0x1189390 VA: 0x18118AD90
	private static void .cctor() { }

}

private enum WebHeaderCollection.RfcChar // TypeDefIndex: 2903
{	// Fields
	public byte value__; // 0x0
	public const WebHeaderCollection.RfcChar High = 0;
	public const WebHeaderCollection.RfcChar Reg = 1;
	public const WebHeaderCollection.RfcChar Ctl = 2;
	public const WebHeaderCollection.RfcChar CR = 3;
	public const WebHeaderCollection.RfcChar LF = 4;
	public const WebHeaderCollection.RfcChar WS = 5;
	public const WebHeaderCollection.RfcChar Colon = 6;
	public const WebHeaderCollection.RfcChar Delim = 7;

}

