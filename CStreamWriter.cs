internal class CStreamWriter : StreamWriter // TypeDefIndex: 684
{	// Fields
	private TermInfoDriver driver; // 0x68

	// Methods

	// RVA: 0x1379120 Offset: 0x1377720 VA: 0x181379120
	public void .ctor(Stream stream, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x1378D40 Offset: 0x1377340 VA: 0x181378D40 Slot: 14
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1378FA0 Offset: 0x13775A0 VA: 0x181378FA0 Slot: 12
	public override void Write(char val) { }

	// RVA: 0x1378C30 Offset: 0x1377230 VA: 0x181378C30
	public void InternalWriteString(string val) { }

	// RVA: 0x1378B50 Offset: 0x1377150 VA: 0x181378B50
	public void InternalWriteChar(char val) { }

	// RVA: 0x1378BB0 Offset: 0x13771B0 VA: 0x181378BB0
	public void InternalWriteChars(char[] buffer, int n) { }

	// RVA: 0x13790E0 Offset: 0x13776E0 VA: 0x1813790E0 Slot: 13
	public override void Write(char[] val) { }

	// RVA: 0x1378C90 Offset: 0x1377290 VA: 0x181378C90 Slot: 15
	public override void Write(string val) { }

}

