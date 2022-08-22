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

	// RVA: 0x12F92C0 Offset: 0x12F78C0 VA: 0x1812F92C0
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x12F92F0 Offset: 0x12F78F0 VA: 0x1812F92F0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x12F7E80 Offset: 0x12F6480 VA: 0x1812F7E80 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x12F8C90 Offset: 0x12F7290 VA: 0x1812F8C90 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F7DA0 Offset: 0x12F63A0 VA: 0x1812F7DA0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x12F81D0 Offset: 0x12F67D0 VA: 0x1812F81D0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F83C0 Offset: 0x12F69C0 VA: 0x1812F83C0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F8AD0 Offset: 0x12F70D0 VA: 0x1812F8AD0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x12F8120 Offset: 0x12F6720 VA: 0x1812F8120 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x12F8950 Offset: 0x12F6F50 VA: 0x1812F8950 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x12F8DD0 Offset: 0x12F73D0 VA: 0x1812F8DD0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x12F8350 Offset: 0x12F6950 VA: 0x1812F8350 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x12F7E10 Offset: 0x12F6410 VA: 0x1812F7E10 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x12F8EC0 Offset: 0x12F74C0 VA: 0x1812F8EC0 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x11C0FA0 Offset: 0x11BF5A0 VA: 0x1811C0FA0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x12F7AC0 Offset: 0x12F60C0 VA: 0x1812F7AC0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x12F8870 Offset: 0x12F6E70 VA: 0x1812F8870
	protected void WriteMetaElement() { }

	// RVA: 0x12F8850 Offset: 0x12F6E50 VA: 0x1812F8850
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F8540 Offset: 0x12F6B40 VA: 0x1812F8540
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F8580 Offset: 0x12F6B80 VA: 0x1812F8580
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F8F30 Offset: 0x12F7530 VA: 0x1812F8F30
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F7CA0 Offset: 0x12F62A0 VA: 0x1812F7CA0
	private void OutputRestAmps() { }

}

