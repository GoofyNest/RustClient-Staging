internal class BitStack // TypeDefIndex: 1830
{	// Fields
	private uint[] bitStack; // 0x10
	private int stackPos; // 0x18
	private uint curr; // 0x1C

	// Methods

	// RVA: 0x12E2D90 Offset: 0x12E1390 VA: 0x1812E2D90
	public void .ctor() { }

	// RVA: 0x12E2B80 Offset: 0x12E1180 VA: 0x1812E2B80
	public void PushBit(bool bit) { }

	// RVA: 0x12E2AC0 Offset: 0x12E10C0 VA: 0x1812E2AC0
	public bool PopBit() { }

	// RVA: 0x12E2AB0 Offset: 0x12E10B0 VA: 0x1812E2AB0
	public bool PeekBit() { }

	// RVA: 0x12E2CA0 Offset: 0x12E12A0 VA: 0x1812E2CA0
	private void PushCurr() { }

	// RVA: 0x12E2B30 Offset: 0x12E1130 VA: 0x1812E2B30
	private void PopCurr() { }

}

