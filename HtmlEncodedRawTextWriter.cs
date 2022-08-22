internal class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter // TypeDefIndex: 1839
{	// Fields
	protected ByteStack elementScope; // 0xC0
	protected ElementProperties currentElementProperties; // 0xC8
	private AttributeProperties currentAttributeProperties; // 0xCC
	private bool endsWithAmpersand; // 0xD0
	private byte[] uriEscapingBuffer; // 0xD8
	private string mediaType; // 0xE0
	private bool doNotEscapeUriAttributes; // 0xE8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8

	// Methods

	// RVA: 0x12F2E10 Offset: 0x12F1410 VA: 0x1812F2E10
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x12F2E40 Offset: 0x12F1440 VA: 0x1812F2E40
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x12F19D0 Offset: 0x12EFFD0 VA: 0x1812F19D0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x12F27E0 Offset: 0x12F0DE0 VA: 0x1812F27E0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F18F0 Offset: 0x12EFEF0 VA: 0x1812F18F0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x12F1D20 Offset: 0x12F0320 VA: 0x1812F1D20 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F1F10 Offset: 0x12F0510 VA: 0x1812F1F10 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F2620 Offset: 0x12F0C20 VA: 0x1812F2620 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x12F1C70 Offset: 0x12F0270 VA: 0x1812F1C70 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x12F24A0 Offset: 0x12F0AA0 VA: 0x1812F24A0 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x12F2920 Offset: 0x12F0F20 VA: 0x1812F2920 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x12F1EA0 Offset: 0x12F04A0 VA: 0x1812F1EA0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x12F1960 Offset: 0x12EFF60 VA: 0x1812F1960 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x12F2A10 Offset: 0x12F1010 VA: 0x1812F2A10 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x11C0900 Offset: 0x11BEF00 VA: 0x1811C0900 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x12F1610 Offset: 0x12EFC10 VA: 0x1812F1610
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x12F23C0 Offset: 0x12F09C0 VA: 0x1812F23C0
	protected void WriteMetaElement() { }

	// RVA: 0x12F23A0 Offset: 0x12F09A0 VA: 0x1812F23A0
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F2090 Offset: 0x12F0690 VA: 0x1812F2090
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F20D0 Offset: 0x12F06D0 VA: 0x1812F20D0
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F2A80 Offset: 0x12F1080 VA: 0x1812F2A80
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F17F0 Offset: 0x12EFDF0 VA: 0x1812F17F0
	private void OutputRestAmps() { }

}

