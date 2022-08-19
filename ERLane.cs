public struct ERLane // TypeDefIndex: 7219
{	// Fields
	public float position; // 0x0
	public ERLaneDirection direction; // 0x4
	public ERDirectionType turnDirection; // 0x8
	public int laneIndex; // 0xC

	// Methods

	// RVA: 0xFAE80 Offset: 0xFA280 VA: 0x1800FAE80
	public void .ctor(float position, ERLaneDirection direction, int index) { }

	// RVA: 0xFAE40 Offset: 0xFA240 VA: 0x1800FAE40
	public void .ctor(ERLane lane) { }

	// RVA: 0xFAE40 Offset: 0xFA240 VA: 0x1800FAE40
	public void Copy(ERLane lane) { }

}

