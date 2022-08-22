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

	// RVA: 0x118EF40 Offset: 0x118D540 VA: 0x18118EF40
	private void NormalizeCommonHeaders() { }

	// RVA: 0x1190620 Offset: 0x118EC20 VA: 0x181190620
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0x118DD70 Offset: 0x118C370 VA: 0x18118DD70
	internal static bool AllowMultiValues(string name) { }

	// RVA: 0x11905B0 Offset: 0x118EBB0 VA: 0x1811905B0
	private bool get_AllowHttpRequestHeader() { }

	// RVA: 0x11906D0 Offset: 0x118ECD0 VA: 0x1811906D0
	public string get_Item(HttpRequestHeader header) { }

	// RVA: 0x11907A0 Offset: 0x118EDA0 VA: 0x1811907A0
	public void set_Item(HttpRequestHeader header, string value) { }

	// RVA: 0x118F130 Offset: 0x118D730 VA: 0x18118F130
	public void Remove(HttpRequestHeader header) { }

	// RVA: 0x118D8E0 Offset: 0x118BEE0 VA: 0x18118D8E0
	internal void AddInternal(string name, string value) { }

	// RVA: 0x118DE10 Offset: 0x118C410 VA: 0x18118DE10
	internal void ChangeInternal(string name, string value) { }

	// RVA: 0x118F0D0 Offset: 0x118D6D0 VA: 0x18118F0D0
	internal void RemoveInternal(string name) { }

	// RVA: 0x118E300 Offset: 0x118C900 VA: 0x18118E300
	internal void CheckUpdate(string name, string value) { }

	// RVA: 0x118DE80 Offset: 0x118C480 VA: 0x18118DE80
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x118E3C0 Offset: 0x118C9C0 VA: 0x18118E3C0
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x118F710 Offset: 0x118DD10 VA: 0x18118F710
	internal void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x118DBE0 Offset: 0x118C1E0 VA: 0x18118DBE0 Slot: 14
	public override void Add(string name, string value) { }

	// RVA: 0x118D950 Offset: 0x118BF50 VA: 0x18118D950
	public void Add(string header) { }

	// RVA: 0x118F510 Offset: 0x118DB10 VA: 0x18118F510 Slot: 17
	public override void Set(string name, string value) { }

	// RVA: 0x118F320 Offset: 0x118D920 VA: 0x18118F320
	internal void SetInternal(string name, string value) { }

	// RVA: 0x118F210 Offset: 0x118D810 VA: 0x18118F210 Slot: 18
	public override void Remove(string name) { }

	// RVA: 0x118E8B0 Offset: 0x118CEB0 VA: 0x18118E8B0 Slot: 16
	public override string[] GetValues(string header) { }

	// RVA: 0x118F910 Offset: 0x118DF10 VA: 0x18118F910 Slot: 3
	public override string ToString() { }

	// RVA: 0x118E430 Offset: 0x118CA30 VA: 0x18118E430
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x1190500 Offset: 0x118EB00 VA: 0x181190500
	public void .ctor() { }

	// RVA: 0x1190420 Offset: 0x118EA20 VA: 0x181190420
	internal void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x1190260 Offset: 0x118E860 VA: 0x181190260
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	public override void OnDeserialization(object sender) { }

	// RVA: 0x118E740 Offset: 0x118CD40 VA: 0x18118E740 Slot: 10
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x118D480 Offset: 0x118BA80 VA: 0x18118D480 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x118EB70 Offset: 0x118D170 VA: 0x18118EB70 Slot: 15
	public override string Get(string name) { }

	// RVA: 0x118E680 Offset: 0x118CC80 VA: 0x18118E680 Slot: 12
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x11905E0 Offset: 0x118EBE0 VA: 0x1811905E0 Slot: 13
	public override int get_Count() { }

	// RVA: 0x118EB20 Offset: 0x118D120 VA: 0x18118EB20 Slot: 19
	public override string Get(int index) { }

	// RVA: 0x118EAD0 Offset: 0x118D0D0 VA: 0x18118EAD0 Slot: 20
	public override string[] GetValues(int index) { }

	// RVA: 0x118E6F0 Offset: 0x118CCF0 VA: 0x18118E6F0 Slot: 21
	public override string GetKey(int index) { }

	// RVA: 0x1190570 Offset: 0x118EB70 VA: 0x181190570 Slot: 22
	public override string[] get_AllKeys() { }

	// RVA: 0x118F970 Offset: 0x118DF70 VA: 0x18118F970
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

