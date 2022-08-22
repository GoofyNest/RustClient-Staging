internal class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter // TypeDefIndex: 1840
{	// Fields
	private int indentLevel; // 0xF0
	private int endBlockPos; // 0xF4
	private string indentChars; // 0xF8
	private bool newLineOnAttributes; // 0x100

	// Methods

	// RVA: 0x12F15A0 Offset: 0x12EFBA0 VA: 0x1812F15A0
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x12F1530 Offset: 0x12EFB30 VA: 0x1812F1530
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x12F10F0 Offset: 0x12EF6F0 VA: 0x1812F10F0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x12F1300 Offset: 0x12EF900 VA: 0x1812F1300 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F1020 Offset: 0x12EF620 VA: 0x1812F1020 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x12F1120 Offset: 0x12EF720 VA: 0x1812F1120 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x12F1240 Offset: 0x12EF840 VA: 0x1812F1240 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x12F0FB0 Offset: 0x12EF5B0 VA: 0x1812F0FB0 Slot: 48
	protected override void FlushBuffer() { }

	// RVA: 0x12F0FD0 Offset: 0x12EF5D0 VA: 0x1812F0FD0
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x12F11E0 Offset: 0x12EF7E0 VA: 0x1812F11E0
	private void WriteIndent() { }

}

