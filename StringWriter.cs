public class StringWriter : TextWriter // TypeDefIndex: 650
{	// Fields
	private static UnicodeEncoding m_encoding; // 0x0
	private StringBuilder _sb; // 0x28
	private bool _isOpen; // 0x30

	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x1621DE0 Offset: 0x16203E0 VA: 0x181621DE0
	public void .ctor() { }

	// RVA: 0x1621CE0 Offset: 0x16202E0 VA: 0x181621CE0
	public void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x1621F10 Offset: 0x1620510 VA: 0x181621F10
	public void .ctor(StringBuilder sb) { }

	// RVA: 0x1622020 Offset: 0x1620620 VA: 0x181622020
	public void .ctor(StringBuilder sb, IFormatProvider formatProvider) { }

	// RVA: 0x1621A30 Offset: 0x1620030 VA: 0x181621A30 Slot: 8
	public override void Close() { }

	// RVA: 0xF60AC0 Offset: 0xF5F0C0 VA: 0x180F60AC0 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16220F0 Offset: 0x16206F0 VA: 0x1816220F0 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x1621C90 Offset: 0x1620290 VA: 0x181621C90 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x1621A80 Offset: 0x1620080 VA: 0x181621A80 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1621C40 Offset: 0x1620240 VA: 0x181621C40 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x1621A50 Offset: 0x1620050 VA: 0x181621A50 Slot: 3
	public override string ToString() { }

}

