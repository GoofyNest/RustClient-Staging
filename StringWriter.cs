public class StringWriter : TextWriter // TypeDefIndex: 650
{	// Fields
	private static UnicodeEncoding m_encoding; // 0x0
	private StringBuilder _sb; // 0x28
	private bool _isOpen; // 0x30

	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x1634800 Offset: 0x1632E00 VA: 0x181634800
	public void .ctor() { }

	// RVA: 0x1634700 Offset: 0x1632D00 VA: 0x181634700
	public void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x1634930 Offset: 0x1632F30 VA: 0x181634930
	public void .ctor(StringBuilder sb) { }

	// RVA: 0x1634A40 Offset: 0x1633040 VA: 0x181634A40
	public void .ctor(StringBuilder sb, IFormatProvider formatProvider) { }

	// RVA: 0x1634450 Offset: 0x1632A50 VA: 0x181634450 Slot: 8
	public override void Close() { }

	// RVA: 0xF5FD60 Offset: 0xF5E360 VA: 0x180F5FD60 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1634B10 Offset: 0x1633110 VA: 0x181634B10 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x16346B0 Offset: 0x1632CB0 VA: 0x1816346B0 Slot: 12
	public override void Write(char value) { }

	// RVA: 0x16344A0 Offset: 0x1632AA0 VA: 0x1816344A0 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1634660 Offset: 0x1632C60 VA: 0x181634660 Slot: 15
	public override void Write(string value) { }

	// RVA: 0x1634470 Offset: 0x1632A70 VA: 0x181634470 Slot: 3
	public override string ToString() { }

}

