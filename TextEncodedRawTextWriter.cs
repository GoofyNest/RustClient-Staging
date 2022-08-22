internal class TextEncodedRawTextWriter : XmlEncodedRawTextWriter // TypeDefIndex: 1868
{	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0xE4D440 Offset: 0xE4BA40 VA: 0x180E4D440
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0xE4D430 Offset: 0xE4BA30 VA: 0x180E4D430
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0xE4D420 Offset: 0xE4BA20 VA: 0x180E4D420 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xE4D400 Offset: 0xE4BA00 VA: 0x180E4D400 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0xE4D3D0 Offset: 0xE4B9D0 VA: 0x180E4D3D0 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0xE4D410 Offset: 0xE4BA10 VA: 0x180E4D410 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xE4D410 Offset: 0xE4BA10 VA: 0x180E4D410 Slot: 20
	public override void WriteString(string textBlock) { }

	// RVA: 0xE4D3E0 Offset: 0xE4B9E0 VA: 0x180E4D3E0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0xE4D3E0 Offset: 0xE4B9E0 VA: 0x180E4D3E0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0xE4D410 Offset: 0xE4BA10 VA: 0x180E4D410 Slot: 24
	public override void WriteRaw(string data) { }

}

