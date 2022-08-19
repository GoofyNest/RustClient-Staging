internal class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter // TypeDefIndex: 1840
{	// Fields
	private int indentLevel; // 0xF0
	private int endBlockPos; // 0xF4
	private string indentChars; // 0xF8
	private bool newLineOnAttributes; // 0x100

	// Methods

	// RVA: 0x12F12E0 Offset: 0x12EF8E0 VA: 0x1812F12E0
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x12F1270 Offset: 0x12EF870 VA: 0x1812F1270
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x12F0E30 Offset: 0x12EF430 VA: 0x1812F0E30 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x12F1040 Offset: 0x12EF640 VA: 0x1812F1040 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F0D60 Offset: 0x12EF360 VA: 0x1812F0D60 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x12F0E60 Offset: 0x12EF460 VA: 0x1812F0E60 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F0F80 Offset: 0x12EF580 VA: 0x1812F0F80 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x12F0CF0 Offset: 0x12EF2F0 VA: 0x1812F0CF0 Slot: 48
	protected override void FlushBuffer() { }

	// RVA: 0x12F0D10 Offset: 0x12EF310 VA: 0x1812F0D10
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x12F0F20 Offset: 0x12EF520 VA: 0x1812F0F20
	private void WriteIndent() { }

}

