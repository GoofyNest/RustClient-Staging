internal sealed class Parser // TypeDefIndex: 919
{	// Fields
	private SecurityDocument _doc; // 0x10
	private Tokenizer _t; // 0x18

	// Methods

	// RVA: 0x17B5210 Offset: 0x17B3810 VA: 0x1817B5210
	internal SecurityElement GetTopElement() { }

	// RVA: 0x17B4950 Offset: 0x17B2F50 VA: 0x1817B4950
	private void GetRequiredSizes(TokenizerStream stream, ref int index) { }

	// RVA: 0x17B4780 Offset: 0x17B2D80 VA: 0x1817B4780
	private int DetermineFormat(TokenizerStream stream) { }

	// RVA: 0x17B5240 Offset: 0x17B3840 VA: 0x1817B5240
	private void ParseContents() { }

	// RVA: 0x17B56B0 Offset: 0x17B3CB0 VA: 0x1817B56B0
	private void .ctor(Tokenizer t) { }

	// RVA: 0x17B55B0 Offset: 0x17B3BB0 VA: 0x1817B55B0
	internal void .ctor(string input) { }

}

internal sealed class Parser // TypeDefIndex: 2265
{	// Fields
	private SchemaType schemaType; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ValidationEventHandler eventHandler; // 0x28
	private XmlNamespaceManager namespaceManager; // 0x30
	private XmlReader reader; // 0x38
	private PositionInfo positionInfo; // 0x40
	private bool isProcessNamespaces; // 0x48
	private int schemaXmlDepth; // 0x4C
	private int markupDepth; // 0x50
	private SchemaBuilder builder; // 0x58
	private XmlSchema schema; // 0x60
	private SchemaInfo xdrSchema; // 0x68
	private XmlResolver xmlResolver; // 0x70
	private XmlDocument dummyDocument; // 0x78
	private bool processMarkup; // 0x80
	private XmlNode parentNode; // 0x88
	private XmlNamespaceManager annotationNSManager; // 0x90
	private string xmlns; // 0x98
	private XmlCharType xmlCharType; // 0xA0

	// Properties
	public XmlSchema XmlSchema { get; }
	internal XmlResolver XmlResolver { set; }
	public SchemaInfo XdrSchema { get; }

	// Methods

	// RVA: 0xB16A00 Offset: 0xB15000 VA: 0x180B16A00
	public void .ctor(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0xB16170 Offset: 0xB14770 VA: 0x180B16170
	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	// RVA: 0xB16500 Offset: 0xB14B00 VA: 0x180B16500
	public void StartParsing(XmlReader reader, string targetNamespace) { }

	// RVA: 0xB14E90 Offset: 0xB13490 VA: 0x180B14E90
	private bool CheckSchemaRoot(SchemaType rootType, out string code) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public SchemaType FinishParsing() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlSchema get_XmlSchema() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public SchemaInfo get_XdrSchema() { }

	// RVA: 0xB15970 Offset: 0xB13F70 VA: 0x180B15970
	public bool ParseReaderNode() { }

	// RVA: 0xB161D0 Offset: 0xB147D0 VA: 0x180B161D0
	private void ProcessAppInfoDocMarkup(bool root) { }

	// RVA: 0xB15260 Offset: 0xB13860 VA: 0x180B15260
	private XmlElement LoadElementNode(bool root) { }

	// RVA: 0xB14F90 Offset: 0xB13590 VA: 0x180B14F90
	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	// RVA: 0xB150B0 Offset: 0xB136B0 VA: 0x180B150B0
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0xB15700 Offset: 0xB13D00 VA: 0x180B15700
	private XmlEntityReference LoadEntityReferenceInAttribute() { }

}

public static class Parser.Token // TypeDefIndex: 5790
{
// Namespace: 
public static class Parser.Token // TypeDefIndex: 5790
	// Methods

	// RVA: 0x1097770 Offset: 0x1095D70 VA: 0x181097770
	public static void Check(string s) { }

	// RVA: 0x10978E0 Offset: 0x1095EE0 VA: 0x1810978E0
	public static bool TryCheck(string s) { }

}

public static class Parser.DateTime // TypeDefIndex: 5791
{	// Fields
	public static readonly Func<object, string> ToString; // 0x3491

	// Methods

	// RVA: 0x1087E50 Offset: 0x1086450 VA: 0x181087E50
	public static bool TryParse(string input, out DateTimeOffset result) { }

	// RVA: 0x1087EC0 Offset: 0x10864C0 VA: 0x181087EC0
	private static void .cctor() { }

}

private sealed class Parser.DateTime.<>c // TypeDefIndex: 5792
{	// Fields
	public static readonly Parser.DateTime.<>c <>9; // 0x2B112A0

	// Methods

	// RVA: 0x109B200 Offset: 0x1099800 VA: 0x18109B200
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x109AE40 Offset: 0x1099440 VA: 0x18109AE40
	internal string <.cctor>b__2_0(object l) { }

}

public static class Parser.EmailAddress // TypeDefIndex: 5793
{	// Methods

	// RVA: 0x1087F70 Offset: 0x1086570 VA: 0x181087F70
	public static bool TryParse(string input, out string result) { }

}

public static class Parser.Host // TypeDefIndex: 5794
{	// Methods

	// RVA: 0x10889E0 Offset: 0x1086FE0 VA: 0x1810889E0
	public static bool TryParse(string input, out string result) { }

}

public static class Parser.Int // TypeDefIndex: 5795
{	// Methods

	// RVA: 0x1090C70 Offset: 0x108F270 VA: 0x181090C70
	public static bool TryParse(string input, out int result) { }

}

public static class Parser.Long // TypeDefIndex: 5796
{	// Methods

	// RVA: 0x1091CC0 Offset: 0x10902C0 VA: 0x181091CC0
	public static bool TryParse(string input, out long result) { }

}

public static class Parser.MD5 // TypeDefIndex: 5797
{	// Fields
	public static readonly Func<object, string> ToString; // 0x34A0

	// Methods

	// RVA: 0x1091D40 Offset: 0x1090340 VA: 0x181091D40
	public static bool TryParse(string input, out byte[] result) { }

	// RVA: 0x1091DE0 Offset: 0x10903E0 VA: 0x181091DE0
	private static void .cctor() { }

}

private sealed class Parser.MD5.<>c // TypeDefIndex: 5798
{	// Fields
	public static readonly Parser.MD5.<>c <>9; // 0x34DF

	// Methods

	// RVA: 0x109B260 Offset: 0x1099860 VA: 0x18109B260
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x109AEE0 Offset: 0x10994E0 VA: 0x18109AEE0
	internal string <.cctor>b__2_0(object l) { }

}

public static class Parser.TimeSpanSeconds // TypeDefIndex: 5799
{	// Methods

	// RVA: 0x1097650 Offset: 0x1095C50 VA: 0x181097650
	public static bool TryParse(string input, out TimeSpan result) { }

}

public static class Parser.Uri // TypeDefIndex: 5800
{	// Methods

	// RVA: 0x109B2C0 Offset: 0x10998C0 VA: 0x18109B2C0
	public static bool TryParse(string input, out Uri result) { }

}

