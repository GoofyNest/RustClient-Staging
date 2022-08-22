internal class QueryOutputWriter : XmlRawWriter // TypeDefIndex: 1859
{	// Fields
	private XmlRawWriter wrapped; // 0x28
	private bool inCDataSection; // 0x30
	private Dictionary<XmlQualifiedName, int> lookupCDataElems; // 0x38
	private BitStack bitsCData; // 0x40
	private XmlQualifiedName qnameCData; // 0x48
	private bool outputDocType; // 0x50
	private bool checkWellFormedDoc; // 0x51
	private bool hasDocElem; // 0x52
	private bool inAttr; // 0x53
	private string systemId; // 0x58
	private string publicId; // 0x60
	private int depth; // 0x68

	// Properties
	internal override IXmlNamespaceResolver NamespaceResolver { set; }
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0xF613A0 Offset: 0xF5F9A0 VA: 0x180F613A0
	public void .ctor(XmlRawWriter writer, XmlWriterSettings settings) { }

	// RVA: 0xF61610 Offset: 0xF5FC10 VA: 0x180F61610 Slot: 35
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0xF61370 Offset: 0xF5F970 VA: 0x180F61370 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0xF61340 Offset: 0xF5F940 VA: 0x180F61340 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0xF60CA0 Offset: 0xF5F2A0 VA: 0x180F60CA0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xF61000 Offset: 0xF5F600 VA: 0x180F61000 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xF60D10 Offset: 0xF5F310 VA: 0x180F60D10 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xF60DA0 Offset: 0xF5F3A0 VA: 0x180F60DA0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xE58510 Offset: 0xE56B10 VA: 0x180E58510 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0xF60FC0 Offset: 0xF5F5C0 VA: 0x180F60FC0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xF60CE0 Offset: 0xF5F2E0 VA: 0x180F60CE0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0xF60E00 Offset: 0xF5F400 VA: 0x180F60E00 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0xE59090 Offset: 0xE57690 VA: 0x180E59090 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0xF611C0 Offset: 0xF5F7C0 VA: 0x180F611C0 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0xE588D0 Offset: 0xE56ED0 VA: 0x180E588D0 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0xF60B40 Offset: 0xF5F140 VA: 0x180F60B40 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0xF60C70 Offset: 0xF5F270 VA: 0x180F60C70 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0xF60E30 Offset: 0xF5F430 VA: 0x180F60E30 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0xF612B0 Offset: 0xF5F8B0 VA: 0x180F612B0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xF611F0 Offset: 0xF5F7F0 VA: 0x180F611F0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0xF60BA0 Offset: 0xF5F1A0 VA: 0x180F60BA0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xF60D70 Offset: 0xF5F370 VA: 0x180F60D70 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0xF60B70 Offset: 0xF5F170 VA: 0x180F60B70 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0xF61280 Offset: 0xF5F880 VA: 0x180F61280 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xF60EF0 Offset: 0xF5F4F0 VA: 0x180F60EF0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xF60E60 Offset: 0xF5F460 VA: 0x180F60E60 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xF60A10 Offset: 0xF5F010 VA: 0x180F60A10 Slot: 28
	public override void Close() { }

	// RVA: 0xF60AD0 Offset: 0xF5F0D0 VA: 0x180F60AD0 Slot: 29
	public override void Flush() { }

	// RVA: 0xF60B00 Offset: 0xF5F100 VA: 0x180F60B00
	private bool StartCDataSection() { }

	// RVA: 0xF60AC0 Offset: 0xF5F0C0 VA: 0x180F60AC0
	private void EndCDataSection() { }

}

