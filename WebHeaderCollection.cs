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

	// RVA: 0x118A620 Offset: 0x1188C20 VA: 0x18118A620
	private void NormalizeCommonHeaders() { }

	// RVA: 0x118BD00 Offset: 0x118A300 VA: 0x18118BD00
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0x1189450 Offset: 0x1187A50 VA: 0x181189450
	internal static bool AllowMultiValues(string name) { }

	// RVA: 0x118BC90 Offset: 0x118A290 VA: 0x18118BC90
	private bool get_AllowHttpRequestHeader() { }

	// RVA: 0x118BDB0 Offset: 0x118A3B0 VA: 0x18118BDB0
	public string get_Item(HttpRequestHeader header) { }

	// RVA: 0x118BE80 Offset: 0x118A480 VA: 0x18118BE80
	public void set_Item(HttpRequestHeader header, string value) { }

	// RVA: 0x118A810 Offset: 0x1188E10 VA: 0x18118A810
	public void Remove(HttpRequestHeader header) { }

	// RVA: 0x1188FC0 Offset: 0x11875C0 VA: 0x181188FC0
	internal void AddInternal(string name, string value) { }

	// RVA: 0x11894F0 Offset: 0x1187AF0 VA: 0x1811894F0
	internal void ChangeInternal(string name, string value) { }

	// RVA: 0x118A7B0 Offset: 0x1188DB0 VA: 0x18118A7B0
	internal void RemoveInternal(string name) { }

	// RVA: 0x11899E0 Offset: 0x1187FE0 VA: 0x1811899E0
	internal void CheckUpdate(string name, string value) { }

	// RVA: 0x1189560 Offset: 0x1187B60 VA: 0x181189560
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x1189AA0 Offset: 0x11880A0 VA: 0x181189AA0
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x118ADF0 Offset: 0x11893F0 VA: 0x18118ADF0
	internal void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x11892C0 Offset: 0x11878C0 VA: 0x1811892C0 Slot: 14
	public override void Add(string name, string value) { }

	// RVA: 0x1189030 Offset: 0x1187630 VA: 0x181189030
	public void Add(string header) { }

	// RVA: 0x118ABF0 Offset: 0x11891F0 VA: 0x18118ABF0 Slot: 17
	public override void Set(string name, string value) { }

	// RVA: 0x118AA00 Offset: 0x1189000 VA: 0x18118AA00
	internal void SetInternal(string name, string value) { }

	// RVA: 0x118A8F0 Offset: 0x1188EF0 VA: 0x18118A8F0 Slot: 18
	public override void Remove(string name) { }

	// RVA: 0x1189F90 Offset: 0x1188590 VA: 0x181189F90 Slot: 16
	public override string[] GetValues(string header) { }

	// RVA: 0x118AFF0 Offset: 0x11895F0 VA: 0x18118AFF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1189B10 Offset: 0x1188110 VA: 0x181189B10
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x118BBE0 Offset: 0x118A1E0 VA: 0x18118BBE0
	public void .ctor() { }

	// RVA: 0x118BB00 Offset: 0x118A100 VA: 0x18118BB00
	internal void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x118B940 Offset: 0x1189F40 VA: 0x18118B940
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	public override void OnDeserialization(object sender) { }

	// RVA: 0x1189E20 Offset: 0x1188420 VA: 0x181189E20 Slot: 10
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1188B60 Offset: 0x1187160 VA: 0x181188B60 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x118A250 Offset: 0x1188850 VA: 0x18118A250 Slot: 15
	public override string Get(string name) { }

	// RVA: 0x1189D60 Offset: 0x1188360 VA: 0x181189D60 Slot: 12
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x118BCC0 Offset: 0x118A2C0 VA: 0x18118BCC0 Slot: 13
	public override int get_Count() { }

	// RVA: 0x118A200 Offset: 0x1188800 VA: 0x18118A200 Slot: 19
	public override string Get(int index) { }

	// RVA: 0x118A1B0 Offset: 0x11887B0 VA: 0x18118A1B0 Slot: 20
	public override string[] GetValues(int index) { }

	// RVA: 0x1189DD0 Offset: 0x11883D0 VA: 0x181189DD0 Slot: 21
	public override string GetKey(int index) { }

	// RVA: 0x118BC50 Offset: 0x118A250 VA: 0x18118BC50 Slot: 22
	public override string[] get_AllKeys() { }

	// RVA: 0x118B050 Offset: 0x1189650 VA: 0x18118B050
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

