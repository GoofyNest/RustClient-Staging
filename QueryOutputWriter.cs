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

	// RVA: 0xF60900 Offset: 0xF5EF00 VA: 0x180F60900
	public void .ctor(XmlRawWriter writer, XmlWriterSettings settings) { }

	// RVA: 0xF60B70 Offset: 0xF5F170 VA: 0x180F60B70 Slot: 35
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0xF608D0 Offset: 0xF5EED0 VA: 0x180F608D0 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0xF608A0 Offset: 0xF5EEA0 VA: 0x180F608A0 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0xF60200 Offset: 0xF5E800 VA: 0x180F60200 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xF60560 Offset: 0xF5EB60 VA: 0x180F60560 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xF60270 Offset: 0xF5E870 VA: 0x180F60270 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xF60300 Offset: 0xF5E900 VA: 0x180F60300 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0xE57A60 Offset: 0xE56060 VA: 0x180E57A60 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0xF60520 Offset: 0xF5EB20 VA: 0x180F60520 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xF60240 Offset: 0xF5E840 VA: 0x180F60240 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0xF60360 Offset: 0xF5E960 VA: 0x180F60360 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0xE585E0 Offset: 0xE56BE0 VA: 0x180E585E0 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0xF60720 Offset: 0xF5ED20 VA: 0x180F60720 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0xE57E20 Offset: 0xE56420 VA: 0x180E57E20 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0xF600A0 Offset: 0xF5E6A0 VA: 0x180F600A0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0xF601D0 Offset: 0xF5E7D0 VA: 0x180F601D0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0xF60390 Offset: 0xF5E990 VA: 0x180F60390 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0xF60810 Offset: 0xF5EE10 VA: 0x180F60810 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xF60750 Offset: 0xF5ED50 VA: 0x180F60750 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0xF60100 Offset: 0xF5E700 VA: 0x180F60100 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xF602D0 Offset: 0xF5E8D0 VA: 0x180F602D0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0xF600D0 Offset: 0xF5E6D0 VA: 0x180F600D0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0xF607E0 Offset: 0xF5EDE0 VA: 0x180F607E0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xF60450 Offset: 0xF5EA50 VA: 0x180F60450 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xF603C0 Offset: 0xF5E9C0 VA: 0x180F603C0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0xF5FF70 Offset: 0xF5E570 VA: 0x180F5FF70 Slot: 28
	public override void Close() { }

	// RVA: 0xF60030 Offset: 0xF5E630 VA: 0x180F60030 Slot: 29
	public override void Flush() { }

	// RVA: 0xF60060 Offset: 0xF5E660 VA: 0x180F60060
	private bool StartCDataSection() { }

	// RVA: 0xF60020 Offset: 0xF5E620 VA: 0x180F60020
	private void EndCDataSection() { }

}

