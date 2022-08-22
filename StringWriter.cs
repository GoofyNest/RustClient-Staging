public class StringWriter : TextWriter // TypeDefIndex: 650
{	// Fields
	private static UnicodeEncoding m_encoding; // 0x0
	private StringBuilder _sb; // 0x28
	private bool _isOpen; // 0x30

	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x1634AC0 Offset: 0x16330C0 VA: 0x181634AC0
	public void .ctor() { }

	// RVA: 0x16349C0 Offset: 0x1632FC0 VA: 0x1816349C0
	public void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x1634BF0 Offset: 0x16331F0 VA: 0x181634BF0
	public void .ctor(StringBuilder sb) { }

	// RVA: 0x1634D00 Offset: 0x1633300 VA: 0x181634D00
	public void .ctor(StringBuilder sb, IFormatProvider formatProvider) { }

	// RVA: 0x1634710 Offset: 0x1632D10 VA: 0x181634710 Slot: 8
	public override void Close() { }

	// RVA: 0xF60020 Offset: 0xF5E620 VA: 0x180F60020 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1634DD0 Offset: 0x16333D0 VA: 0x181634DD0 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x1634970 Offset: 0x1632F70 VA: 0x181634970 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x1634760 Offset: 0x1632D60 VA: 0x181634760 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1634920 Offset: 0x1632F20 VA: 0x181634920 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x1634730 Offset: 0x1632D30 VA: 0x181634730 Slot: 3
	public override string ToString() { }

}

