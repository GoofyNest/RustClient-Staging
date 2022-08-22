internal class CStreamWriter : StreamWriter // TypeDefIndex: 684
{	// Fields
	private TermInfoDriver driver; // 0x68

	// Methods

	// RVA: 0x13784E0 Offset: 0x1376AE0 VA: 0x1813784E0
	public void .ctor(Stream stream, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x1378100 Offset: 0x1376700 VA: 0x181378100 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1378360 Offset: 0x1376960 VA: 0x181378360 Slot: 12
	public override void Write(char val) { }

	// RVA: 0x1377FF0 Offset: 0x13765F0 VA: 0x181377FF0
	public void InternalWriteString(string val) { }

	// RVA: 0x1377F10 Offset: 0x1376510 VA: 0x181377F10
	public void InternalWriteChar(char val) { }

	// RVA: 0x1377F70 Offset: 0x1376570 VA: 0x181377F70
	public void InternalWriteChars(char[] buffer, int n) { }

	// RVA: 0x13784A0 Offset: 0x1376AA0 VA: 0x1813784A0 Slot: 13
	public override void Write(char[] val) { }

	// RVA: 0x1378050 Offset: 0x1376650 VA: 0x181378050 Slot: 15
	public override void Write(string val) { }

}

