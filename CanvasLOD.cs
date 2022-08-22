public class CanvasLOD : LODComponent // TypeDefIndex: 9923
{	// Fields
	public float Distance; // 0x80
	private Canvas canvas; // 0x88
	private int curlod; // 0x90
	private bool force; // 0x94

	// Methods

	// RVA: 0x6FDF90 Offset: 0x6FC590 VA: 0x1806FDF90 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x4C78B0 Offset: 0x4C5EB0 VA: 0x1804C78B0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x6FDFE0 Offset: 0x6FC5E0 VA: 0x1806FDFE0 Slot: 13
	protected override void Show() { }

	// RVA: 0x6FDF00 Offset: 0x6FC500 VA: 0x1806FDF00 Slot: 14
	protected override void Hide() { }

	// RVA: 0x4C7A10 Offset: 0x4C6010 VA: 0x1804C7A10 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x4C78C0 Offset: 0x4C5EC0 VA: 0x1804C78C0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x6FE070 Offset: 0x6FC670 VA: 0x1806FE070
	public void .ctor() { }

}

