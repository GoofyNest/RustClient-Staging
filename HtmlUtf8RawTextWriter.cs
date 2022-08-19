internal class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter // TypeDefIndex: 1842
{	// Fields
	protected ByteStack elementScope; // 0x90
	protected ElementProperties currentElementProperties; // 0x98
	private AttributeProperties currentAttributeProperties; // 0x9C
	private bool endsWithAmpersand; // 0xA0
	private byte[] uriEscapingBuffer; // 0xA8
	private string mediaType; // 0xB0
	private bool doNotEscapeUriAttributes; // 0xB8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8

	// Methods

	// RVA: 0x12F4360 Offset: 0x12F2960 VA: 0x1812F4360
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x12F3110 Offset: 0x12F1710 VA: 0x1812F3110 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x12F3DA0 Offset: 0x12F23A0 VA: 0x1812F3DA0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F2F10 Offset: 0x12F1510 VA: 0x1812F2F10 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x12F33E0 Offset: 0x12F19E0 VA: 0x1812F33E0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F35A0 Offset: 0x12F1BA0 VA: 0x1812F35A0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F3C10 Offset: 0x12F2210 VA: 0x1812F3C10 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x12F3360 Offset: 0x12F1960 VA: 0x1812F3360 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x12F3AE0 Offset: 0x12F20E0 VA: 0x1812F3AE0 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x12F3EC0 Offset: 0x12F24C0 VA: 0x1812F3EC0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x12F3530 Offset: 0x12F1B30 VA: 0x1812F3530 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x12F3040 Offset: 0x12F1640 VA: 0x1812F3040 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x12F3F90 Offset: 0x12F2590 VA: 0x1812F3F90 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x12F30B0 Offset: 0x12F16B0 VA: 0x1812F30B0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x12F2C60 Offset: 0x12F1260 VA: 0x1812F2C60
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x12F3A00 Offset: 0x12F2000 VA: 0x1812F3A00
	protected void WriteMetaElement() { }

	// RVA: 0x12F39E0 Offset: 0x12F1FE0 VA: 0x1812F39E0
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F36F0 Offset: 0x12F1CF0 VA: 0x1812F36F0
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F3730 Offset: 0x12F1D30 VA: 0x1812F3730
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F4000 Offset: 0x12F2600 VA: 0x1812F4000
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F2E40 Offset: 0x12F1440 VA: 0x1812F2E40
	private void OutputRestAmps() { }

}

