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

	// RVA: 0x12F4620 Offset: 0x12F2C20 VA: 0x1812F4620
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x12F33D0 Offset: 0x12F19D0 VA: 0x1812F33D0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x12F4060 Offset: 0x12F2660 VA: 0x1812F4060 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F31D0 Offset: 0x12F17D0 VA: 0x1812F31D0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x12F36A0 Offset: 0x12F1CA0 VA: 0x1812F36A0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F3860 Offset: 0x12F1E60 VA: 0x1812F3860 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F3ED0 Offset: 0x12F24D0 VA: 0x1812F3ED0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x12F3620 Offset: 0x12F1C20 VA: 0x1812F3620 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x12F3DA0 Offset: 0x12F23A0 VA: 0x1812F3DA0 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x12F4180 Offset: 0x12F2780 VA: 0x1812F4180 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x12F37F0 Offset: 0x12F1DF0 VA: 0x1812F37F0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x12F3300 Offset: 0x12F1900 VA: 0x1812F3300 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x12F4250 Offset: 0x12F2850 VA: 0x1812F4250 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x12F3370 Offset: 0x12F1970 VA: 0x1812F3370 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x12F2F20 Offset: 0x12F1520 VA: 0x1812F2F20
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x12F3CC0 Offset: 0x12F22C0 VA: 0x1812F3CC0
	protected void WriteMetaElement() { }

	// RVA: 0x12F3CA0 Offset: 0x12F22A0 VA: 0x1812F3CA0
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F39B0 Offset: 0x12F1FB0 VA: 0x1812F39B0
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F39F0 Offset: 0x12F1FF0 VA: 0x1812F39F0
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F42C0 Offset: 0x12F28C0 VA: 0x1812F42C0
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F3100 Offset: 0x12F1700 VA: 0x1812F3100
	private void OutputRestAmps() { }

}

