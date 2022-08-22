internal sealed class Parser // TypeDefIndex: 919
{	// Fields
	private SecurityDocument _doc; // 0x10
	private Tokenizer _t; // 0x18

	// Methods

	// RVA: 0x17B4F50 Offset: 0x17B3550 VA: 0x1817B4F50
	internal SecurityElement GetTopElement() { }

	// RVA: 0x17B4690 Offset: 0x17B2C90 VA: 0x1817B4690
	private void GetRequiredSizes(TokenizerStream stream, ref int index) { }

	// RVA: 0x17B44C0 Offset: 0x17B2AC0 VA: 0x1817B44C0
	private int DetermineFormat(TokenizerStream stream) { }

	// RVA: 0x17B4F80 Offset: 0x17B3580 VA: 0x1817B4F80
	private void ParseContents() { }

	// RVA: 0x17B53F0 Offset: 0x17B39F0 VA: 0x1817B53F0
	private void .ctor(Tokenizer t) { }

	// RVA: 0x17B52F0 Offset: 0x17B38F0 VA: 0x1817B52F0
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

	// RVA: 0xB16740 Offset: 0xB14D40 VA: 0x180B16740
	public void .ctor(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0xB15EB0 Offset: 0xB144B0 VA: 0x180B15EB0
	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	// RVA: 0xB16240 Offset: 0xB14840 VA: 0x180B16240
	public void StartParsing(XmlReader reader, string targetNamespace) { }

	// RVA: 0xB14BD0 Offset: 0xB131D0 VA: 0x180B14BD0
	private bool CheckSchemaRoot(SchemaType rootType, out string code) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public SchemaType FinishParsing() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public XmlSchema get_XmlSchema() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	public SchemaInfo get_XdrSchema() { }

	// RVA: 0xB156B0 Offset: 0xB13CB0 VA: 0x180B156B0
	public bool ParseReaderNode() { }

	// RVA: 0xB15F10 Offset: 0xB14510 VA: 0x180B15F10
	private void ProcessAppInfoDocMarkup(bool root) { }

	// RVA: 0xB14FA0 Offset: 0xB135A0 VA: 0x180B14FA0
	private XmlElement LoadElementNode(bool root) { }

	// RVA: 0xB14CD0 Offset: 0xB132D0 VA: 0x180B14CD0
	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	// RVA: 0xB14DF0 Offset: 0xB133F0 VA: 0x180B14DF0
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0xB15440 Offset: 0xB13A40 VA: 0x180B15440
	private XmlEntityReference LoadEntityReferenceInAttribute() { }

}

public static class Parser.Token // TypeDefIndex: 5790
{
// Namespace: 
public static class Parser.Token // TypeDefIndex: 5790
	// Methods

	// RVA: 0x10974B0 Offset: 0x1095AB0 VA: 0x1810974B0
	public static void Check(string s) { }

	// RVA: 0x1097620 Offset: 0x1095C20 VA: 0x181097620
	public static bool TryCheck(string s) { }

}

public static class Parser.DateTime // TypeDefIndex: 5791
{	// Fields
	public static readonly Func<object, string> ToString; // 0x3491

	// Methods

	// RVA: 0x1087B90 Offset: 0x1086190 VA: 0x181087B90
	public static bool TryParse(string input, out DateTimeOffset result) { }

	// RVA: 0x1087C00 Offset: 0x1086200 VA: 0x181087C00
	private static void .cctor() { }

}

private sealed class Parser.DateTime.<>c // TypeDefIndex: 5792
{	// Fields
	public static readonly Parser.DateTime.<>c <>9; // 0x2B10260

	// Methods

	// RVA: 0x109AF40 Offset: 0x1099540 VA: 0x18109AF40
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x109AB80 Offset: 0x1099180 VA: 0x18109AB80
	internal string <.cctor>b__2_0(object l) { }

}

public static class Parser.EmailAddress // TypeDefIndex: 5793
{	// Methods

	// RVA: 0x1087CB0 Offset: 0x10862B0 VA: 0x181087CB0
	public static bool TryParse(string input, out string result) { }

}

public static class Parser.Host // TypeDefIndex: 5794
{	// Methods

	// RVA: 0x1088720 Offset: 0x1086D20 VA: 0x181088720
	public static bool TryParse(string input, out string result) { }

}

public static class Parser.Int // TypeDefIndex: 5795
{	// Methods

	// RVA: 0x10909B0 Offset: 0x108EFB0 VA: 0x1810909B0
	public static bool TryParse(string input, out int result) { }

}

public static class Parser.Long // TypeDefIndex: 5796
{	// Methods

	// RVA: 0x1091A00 Offset: 0x1090000 VA: 0x181091A00
	public static bool TryParse(string input, out long result) { }

}

public static class Parser.MD5 // TypeDefIndex: 5797
{	// Fields
	public static readonly Func<object, string> ToString; // 0x34A0

	// Methods

	// RVA: 0x1091A80 Offset: 0x1090080 VA: 0x181091A80
	public static bool TryParse(string input, out byte[] result) { }

	// RVA: 0x1091B20 Offset: 0x1090120 VA: 0x181091B20
	private static void .cctor() { }

}

private sealed class Parser.MD5.<>c // TypeDefIndex: 5798
{	// Fields
	public static readonly Parser.MD5.<>c <>9; // 0x34DF

	// Methods

	// RVA: 0x109AFA0 Offset: 0x10995A0 VA: 0x18109AFA0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x109AC20 Offset: 0x1099220 VA: 0x18109AC20
	internal string <.cctor>b__2_0(object l) { }

}

public static class Parser.TimeSpanSeconds // TypeDefIndex: 5799
{	// Methods

	// RVA: 0x1097390 Offset: 0x1095990 VA: 0x181097390
	public static bool TryParse(string input, out TimeSpan result) { }

}

public static class Parser.Uri // TypeDefIndex: 5800
{	// Methods

	// RVA: 0x109B000 Offset: 0x1099600 VA: 0x18109B000
	public static bool TryParse(string input, out Uri result) { }

}

