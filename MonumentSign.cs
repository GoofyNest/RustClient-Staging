public class MonumentSign : LODComponent // TypeDefIndex: 8808
{	// Fields
	public float viewDistance; // 0x80
	public GameObject uiRoot; // 0x88
	public RustText signText; // 0x90
	private MonumentInfo closestMonument; // 0x98
	private int currentLod; // 0xA0
	private bool force; // 0xA4

	// Methods

	// RVA: 0x7B67D0 Offset: 0x7B4DD0 VA: 0x1807B67D0
	private void UpdateText() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x7B60D0 Offset: 0x7B46D0 VA: 0x1807B60D0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x7B6630 Offset: 0x7B4C30 VA: 0x1807B6630 Slot: 13
	protected override void Show() { }

	// RVA: 0x7B64F0 Offset: 0x7B4AF0 VA: 0x1807B64F0 Slot: 14
	protected override void Hide() { }

	// RVA: 0x7B6580 Offset: 0x7B4B80 VA: 0x1807B6580 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x4C7930 Offset: 0x4C5F30 VA: 0x1804C7930 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x7B60E0 Offset: 0x7B46E0 VA: 0x1807B60E0
	private MonumentInfo FindClosestMonument() { }

	// RVA: 0x7B6900 Offset: 0x7B4F00 VA: 0x1807B6900
	public void .ctor() { }

}

