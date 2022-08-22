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

	// RVA: 0x12FAAD0 Offset: 0x12F90D0 VA: 0x1812FAAD0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x12F9880 Offset: 0x12F7E80 VA: 0x1812F9880 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x12FA510 Offset: 0x12F8B10 VA: 0x1812FA510 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F9680 Offset: 0x12F7C80 VA: 0x1812F9680 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x12F9B50 Offset: 0x12F8150 VA: 0x1812F9B50 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F9D10 Offset: 0x12F8310 VA: 0x1812F9D10 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12FA380 Offset: 0x12F8980 VA: 0x1812FA380 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x12F9AD0 Offset: 0x12F80D0 VA: 0x1812F9AD0 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x12FA250 Offset: 0x12F8850 VA: 0x1812FA250 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x12FA630 Offset: 0x12F8C30 VA: 0x1812FA630 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x12F9CA0 Offset: 0x12F82A0 VA: 0x1812F9CA0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x12F97B0 Offset: 0x12F7DB0 VA: 0x1812F97B0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x12FA700 Offset: 0x12F8D00 VA: 0x1812FA700 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x12F9820 Offset: 0x12F7E20 VA: 0x1812F9820 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x12F93D0 Offset: 0x12F79D0 VA: 0x1812F93D0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x12FA170 Offset: 0x12F8770 VA: 0x1812FA170
	protected void WriteMetaElement() { }

	// RVA: 0x12FA150 Offset: 0x12F8750 VA: 0x1812FA150
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F9E60 Offset: 0x12F8460 VA: 0x1812F9E60
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F9EA0 Offset: 0x12F84A0 VA: 0x1812F9EA0
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12FA770 Offset: 0x12F8D70 VA: 0x1812FA770
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x12F95B0 Offset: 0x12F7BB0 VA: 0x1812F95B0
	private void OutputRestAmps() { }

}

