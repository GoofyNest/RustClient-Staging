internal sealed class Parser // TypeDefIndex: 919
{	// Fields
	private SecurityDocument _doc; // 0x10
	private Tokenizer _t; // 0x18

	// Methods

	// RVA: 0x17B2D60 Offset: 0x17B1360 VA: 0x1817B2D60
	internal SecurityElement GetTopElement() { }

	// RVA: 0x17B24A0 Offset: 0x17B0AA0 VA: 0x1817B24A0
	private void GetRequiredSizes(TokenizerStream stream, ref int index) { }

	// RVA: 0x17B22D0 Offset: 0x17B08D0 VA: 0x1817B22D0
	private int DetermineFormat(TokenizerStream stream) { }

	// RVA: 0x17B2D90 Offset: 0x17B1390 VA: 0x1817B2D90
	private void ParseContents() { }

	// RVA: 0x17B3200 Offset: 0x17B1800 VA: 0x1817B3200
	private void .ctor(Tokenizer t) { }

	// RVA: 0x17B3100 Offset: 0x17B1700 VA: 0x1817B3100
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

	// RVA: 0xB16ED0 Offset: 0xB154D0 VA: 0x180B16ED0
	public void .ctor(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0xB16640 Offset: 0xB14C40 VA: 0x180B16640
	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	// RVA: 0xB169D0 Offset: 0xB14FD0 VA: 0x180B169D0
	public void StartParsing(XmlReader reader, string targetNamespace) { }

	// RVA: 0xB15360 Offset: 0xB13960 VA: 0x180B15360
	private bool CheckSchemaRoot(SchemaType rootType, out string code) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public SchemaType FinishParsing() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	public XmlSchema get_XmlSchema() { }

	// RVA: 0x5743F0 Offset: 0x5729F0 VA: 0x1805743F0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	public SchemaInfo get_XdrSchema() { }

	// RVA: 0xB15E40 Offset: 0xB14440 VA: 0x180B15E40
	public bool ParseReaderNode() { }

	// RVA: 0xB166A0 Offset: 0xB14CA0 VA: 0x180B166A0
	private void ProcessAppInfoDocMarkup(bool root) { }

	// RVA: 0xB15730 Offset: 0xB13D30 VA: 0x180B15730
	private XmlElement LoadElementNode(bool root) { }

	// RVA: 0xB15460 Offset: 0xB13A60 VA: 0x180B15460
	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	// RVA: 0xB15580 Offset: 0xB13B80 VA: 0x180B15580
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0xB15BD0 Offset: 0xB141D0 VA: 0x180B15BD0
	private XmlEntityReference LoadEntityReferenceInAttribute() { }

}

public static class Parser.Token // TypeDefIndex: 5790
{
// Namespace: 
public static class Parser.Token // TypeDefIndex: 5790
	// Methods

	// RVA: 0x10981E0 Offset: 0x10967E0 VA: 0x1810981E0
	public static void Check(string s) { }

	// RVA: 0x1098350 Offset: 0x1096950 VA: 0x181098350
	public static bool TryCheck(string s) { }

}

public static class Parser.DateTime // TypeDefIndex: 5791
{	// Fields
	public static readonly Func<object, string> ToString; // 0x3240

	// Methods

	// RVA: 0x10888C0 Offset: 0x1086EC0 VA: 0x1810888C0
	public static bool TryParse(string input, out DateTimeOffset result) { }

	// RVA: 0x1088930 Offset: 0x1086F30 VA: 0x181088930
	private static void .cctor() { }

}

private sealed class Parser.DateTime.<>c // TypeDefIndex: 5792
{	// Fields
	public static readonly Parser.DateTime.<>c <>9; // 0x3288

	// Methods

	// RVA: 0x109BC70 Offset: 0x109A270 VA: 0x18109BC70
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x109B8B0 Offset: 0x1099EB0 VA: 0x18109B8B0
	internal string <.cctor>b__2_0(object l) { }

}

public static class Parser.EmailAddress // TypeDefIndex: 5793
{	// Methods

	// RVA: 0x10889E0 Offset: 0x1086FE0 VA: 0x1810889E0
	public static bool TryParse(string input, out string result) { }

}

public static class Parser.Host // TypeDefIndex: 5794
{	// Methods

	// RVA: 0x1089450 Offset: 0x1087A50 VA: 0x181089450
	public static bool TryParse(string input, out string result) { }

}

public static class Parser.Int // TypeDefIndex: 5795
{	// Methods

	// RVA: 0x10916E0 Offset: 0x108FCE0 VA: 0x1810916E0
	public static bool TryParse(string input, out int result) { }

}

public static class Parser.Long // TypeDefIndex: 5796
{	// Methods

	// RVA: 0x1092730 Offset: 0x1090D30 VA: 0x181092730
	public static bool TryParse(string input, out long result) { }

}

public static class Parser.MD5 // TypeDefIndex: 5797
{	// Fields
	public static readonly Func<object, string> ToString; // 0x2B10360

	// Methods

	// RVA: 0x10927B0 Offset: 0x1090DB0 VA: 0x1810927B0
	public static bool TryParse(string input, out byte[] result) { }

	// RVA: 0x1092850 Offset: 0x1090E50 VA: 0x181092850
	private static void .cctor() { }

}

private sealed class Parser.MD5.<>c // TypeDefIndex: 5798
{	// Fields
	public static readonly Parser.MD5.<>c <>9; // 0x3290

	// Methods

	// RVA: 0x109BCD0 Offset: 0x109A2D0 VA: 0x18109BCD0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x109B950 Offset: 0x1099F50 VA: 0x18109B950
	internal string <.cctor>b__2_0(object l) { }

}

public static class Parser.TimeSpanSeconds // TypeDefIndex: 5799
{	// Methods

	// RVA: 0x10980C0 Offset: 0x10966C0 VA: 0x1810980C0
	public static bool TryParse(string input, out TimeSpan result) { }

}

public static class Parser.Uri // TypeDefIndex: 5800
{	// Methods

	// RVA: 0x109BD30 Offset: 0x109A330 VA: 0x18109BD30
	public static bool TryParse(string input, out Uri result) { }

}

