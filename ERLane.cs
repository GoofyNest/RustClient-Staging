public struct ERLane // TypeDefIndex: 7219
{	// Fields
	public float position; // 0x0
	public ERLaneDirection direction; // 0x4
	public ERDirectionType turnDirection; // 0x8
	public int laneIndex; // 0xC

	// Methods

	// RVA: 0xFAE00 Offset: 0xFA200 VA: 0x1800FAE00
	public void .ctor(float position, ERLaneDirection direction, int index) { }

	// RVA: 0xFADC0 Offset: 0xFA1C0 VA: 0x1800FADC0
	public void .ctor(ERLane lane) { }

	// RVA: 0xFADC0 Offset: 0xFA1C0 VA: 0x1800FADC0
	public void Copy(ERLane lane) { }

}

