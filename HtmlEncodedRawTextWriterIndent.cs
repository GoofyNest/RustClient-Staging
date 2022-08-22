internal class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter // TypeDefIndex: 1840
{	// Fields
	private int indentLevel; // 0xF0
	private int endBlockPos; // 0xF4
	private string indentChars; // 0xF8
	private bool newLineOnAttributes; // 0x100

	// Methods

	// RVA: 0x12F7A50 Offset: 0x12F6050 VA: 0x1812F7A50
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x12F79E0 Offset: 0x12F5FE0 VA: 0x1812F79E0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x12F75A0 Offset: 0x12F5BA0 VA: 0x1812F75A0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x12F77B0 Offset: 0x12F5DB0 VA: 0x1812F77B0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F74D0 Offset: 0x12F5AD0 VA: 0x1812F74D0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x12F75D0 Offset: 0x12F5BD0 VA: 0x1812F75D0 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F76F0 Offset: 0x12F5CF0 VA: 0x1812F76F0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x12F7460 Offset: 0x12F5A60 VA: 0x1812F7460 Slot: 48
	protected override void FlushBuffer() { }

	// RVA: 0x12F7480 Offset: 0x12F5A80 VA: 0x1812F7480
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x12F7690 Offset: 0x12F5C90 VA: 0x1812F7690
	private void WriteIndent() { }

}

