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

	// RVA: 0x12F2B50 Offset: 0x12F1150 VA: 0x1812F2B50
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x12F2B80 Offset: 0x12F1180 VA: 0x1812F2B80
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x12F1710 Offset: 0x12EFD10 VA: 0x1812F1710 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x12F2520 Offset: 0x12F0B20 VA: 0x1812F2520 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F1630 Offset: 0x12EFC30 VA: 0x1812F1630 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x12F1A60 Offset: 0x12F0060 VA: 0x1812F1A60 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F1C50 Offset: 0x12F0250 VA: 0x1812F1C50 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F2360 Offset: 0x12F0960 VA: 0x1812F2360 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x12F19B0 Offset: 0x12EFFB0 VA: 0x1812F19B0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x12F21E0 Offset: 0x12F07E0 VA: 0x1812F21E0 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x12F2660 Offset: 0x12F0C60 VA: 0x1812F2660 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x12F1BE0 Offset: 0x12F01E0 VA: 0x1812F1BE0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x12F16A0 Offset: 0x12EFCA0 VA: 0x1812F16A0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x12F2750 Offset: 0x12F0D50 VA: 0x1812F2750 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x11C0640 Offset: 0x11BEC40 VA: 0x1811C0640 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x12F1350 Offset: 0x12EF950 VA: 0x1812F1350
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x12F2100 Offset: 0x12F0700 VA: 0x1812F2100
	protected void WriteMetaElement() { }

	// RVA: 0x12F20E0 Offset: 0x12F06E0 VA: 0x1812F20E0
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F1DD0 Offset: 0x12F03D0 VA: 0x1812F1DD0
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F1E10 Offset: 0x12F0410 VA: 0x1812F1E10
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F27C0 Offset: 0x12F0DC0 VA: 0x1812F27C0
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F1530 Offset: 0x12EFB30 VA: 0x1812F1530
	private void OutputRestAmps() { }

}

