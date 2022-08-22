internal class CStreamWriter : StreamWriter // TypeDefIndex: 684
{	// Fields
	private TermInfoDriver driver; // 0x68

	// Methods

	// RVA: 0x13793E0 Offset: 0x13779E0 VA: 0x1813793E0
	public void .ctor(Stream stream, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x1379000 Offset: 0x1377600 VA: 0x181379000 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1379260 Offset: 0x1377860 VA: 0x181379260 Slot: 12
	public override void Write(char val) { }

	// RVA: 0x1378EF0 Offset: 0x13774F0 VA: 0x181378EF0
	public void InternalWriteString(string val) { }

	// RVA: 0x1378E10 Offset: 0x1377410 VA: 0x181378E10
	public void InternalWriteChar(char val) { }

	// RVA: 0x1378E70 Offset: 0x1377470 VA: 0x181378E70
	public void InternalWriteChars(char[] buffer, int n) { }

	// RVA: 0x13793A0 Offset: 0x13779A0 VA: 0x1813793A0 Slot: 13
	public override void Write(char[] val) { }

	// RVA: 0x1378F50 Offset: 0x1377550 VA: 0x181378F50 Slot: 15
	public override void Write(string val) { }

}

