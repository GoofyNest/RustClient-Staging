public class CanvasLOD : LODComponent // TypeDefIndex: 9923
{	// Fields
	public float Distance; // 0x80
	private Canvas canvas; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94

	// Methods

	// RVA: 0x6FE040 Offset: 0x6FC640 VA: 0x1806FE040 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C7920 Offset: 0x4C5F20 VA: 0x1804C7920 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x6FE090 Offset: 0x6FC690 VA: 0x1806FE090 Slot: 13
	protected override void Show() { }

	// RVA: 0x6FDFB0 Offset: 0x6FC5B0 VA: 0x1806FDFB0 Slot: 14
	protected override void Hide() { }

	// RVA: 0x4C7A80 Offset: 0x4C6080 VA: 0x1804C7A80 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x4C7930 Offset: 0x4C5F30 VA: 0x1804C7930 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x6FE120 Offset: 0x6FC720 VA: 0x1806FE120
	public void .ctor() { }

}

