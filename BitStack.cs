internal class BitStack // TypeDefIndex: 1830
{	// Fields
	private uint[] bitStack; // 0x10
	private int stackPos; // 0x18
	private uint curr; // 0x1C

	// Methods

	// RVA: 0x12E2AD0 Offset: 0x12E10D0 VA: 0x1812E2AD0
	public void .ctor() { }

	// RVA: 0x12E28C0 Offset: 0x12E0EC0 VA: 0x1812E28C0
	public void PushBit(bool bit) { }

	// RVA: 0x12E2800 Offset: 0x12E0E00 VA: 0x1812E2800
	public bool PopBit() { }

	// RVA: 0x12E27F0 Offset: 0x12E0DF0 VA: 0x1812E27F0
	public bool PeekBit() { }

	// RVA: 0x12E29E0 Offset: 0x12E0FE0 VA: 0x1812E29E0
	private void PushCurr() { }

	// RVA: 0x12E2870 Offset: 0x12E0E70 VA: 0x1812E2870
	private void PopCurr() { }

}

