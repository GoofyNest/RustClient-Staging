internal class BitStack // TypeDefIndex: 1830
{	// Fields
	private uint[] bitStack; // 0x10
	private int stackPos; // 0x18
	private uint curr; // 0x1C

	// Methods

	// RVA: 0x12E9240 Offset: 0x12E7840 VA: 0x1812E9240
	public void .ctor() { }

	// RVA: 0x12E9030 Offset: 0x12E7630 VA: 0x1812E9030
	public void PushBit(bool bit) { }

	// RVA: 0x12E8F70 Offset: 0x12E7570 VA: 0x1812E8F70
	public bool PopBit() { }

	// RVA: 0x12E8F60 Offset: 0x12E7560 VA: 0x1812E8F60
	public bool PeekBit() { }

	// RVA: 0x12E9150 Offset: 0x12E7750 VA: 0x1812E9150
	private void PushCurr() { }

	// RVA: 0x12E8FE0 Offset: 0x12E75E0 VA: 0x1812E8FE0
	private void PopCurr() { }

}

