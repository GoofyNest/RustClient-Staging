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

	// RVA: 0xF60640 Offset: 0xF5EC40 VA: 0x180F60640
	public void .ctor(XmlRawWriter writer, XmlWriterSettings settings) { }

	// RVA: 0xF608B0 Offset: 0xF5EEB0 VA: 0x180F608B0 Slot: 35
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0xF60610 Offset: 0xF5EC10 VA: 0x180F60610 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0xF605E0 Offset: 0xF5EBE0 VA: 0x180F605E0 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0xF5FF40 Offset: 0xF5E540 VA: 0x180F5FF40 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xF602A0 Offset: 0xF5E8A0 VA: 0x180F602A0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xF5FFB0 Offset: 0xF5E5B0 VA: 0x180F5FFB0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xF60040 Offset: 0xF5E640 VA: 0x180F60040 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xE577A0 Offset: 0xE55DA0 VA: 0x180E577A0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0xF60260 Offset: 0xF5E860 VA: 0x180F60260 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xF5FF80 Offset: 0xF5E580 VA: 0x180F5FF80 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0xF600A0 Offset: 0xF5E6A0 VA: 0x180F600A0 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0xE58320 Offset: 0xE56920 VA: 0x180E58320 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0xF60460 Offset: 0xF5EA60 VA: 0x180F60460 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0xE57B60 Offset: 0xE56160 VA: 0x180E57B60 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0xF5FDE0 Offset: 0xF5E3E0 VA: 0x180F5FDE0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0xF5FF10 Offset: 0xF5E510 VA: 0x180F5FF10 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0xF600D0 Offset: 0xF5E6D0 VA: 0x180F600D0 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0xF60550 Offset: 0xF5EB50 VA: 0x180F60550 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xF60490 Offset: 0xF5EA90 VA: 0x180F60490 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0xF5FE40 Offset: 0xF5E440 VA: 0x180F5FE40 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xF60010 Offset: 0xF5E610 VA: 0x180F60010 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0xF5FE10 Offset: 0xF5E410 VA: 0x180F5FE10 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0xF60520 Offset: 0xF5EB20 VA: 0x180F60520 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xF60190 Offset: 0xF5E790 VA: 0x180F60190 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xF60100 Offset: 0xF5E700 VA: 0x180F60100 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xF5FCB0 Offset: 0xF5E2B0 VA: 0x180F5FCB0 Slot: 28
	public override void Close() { }

	// RVA: 0xF5FD70 Offset: 0xF5E370 VA: 0x180F5FD70 Slot: 29
	public override void Flush() { }

	// RVA: 0xF5FDA0 Offset: 0xF5E3A0 VA: 0x180F5FDA0
	private bool StartCDataSection() { }

	// RVA: 0xF5FD60 Offset: 0xF5E360 VA: 0x180F5FD60
	private void EndCDataSection() { }

}

