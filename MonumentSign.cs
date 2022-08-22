public class MonumentSign : LODComponent // TypeDefIndex: 8808
{	// Fields
	public float viewDistance; // 0x80
	public GameObject uiRoot; // 0x88
	public RustText signText; // 0x90
	private MonumentInfo closestMonument; // 0x98
	private int currentLod; // 0xA0
	private bool force; // 0xA4

	// Methods

	// RVA: 0x7D4CD0 Offset: 0x7D32D0 VA: 0x1807D4CD0
	private void UpdateText() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x7D45D0 Offset: 0x7D2BD0 VA: 0x1807D45D0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x7D4B30 Offset: 0x7D3130 VA: 0x1807D4B30 Slot: 13
	protected override void Show() { }

	// RVA: 0x7D49F0 Offset: 0x7D2FF0 VA: 0x1807D49F0 Slot: 14
	protected override void Hide() { }

	// RVA: 0x7D4A80 Offset: 0x7D3080 VA: 0x1807D4A80 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x4C78C0 Offset: 0x4C5EC0 VA: 0x1804C78C0 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x7D45E0 Offset: 0x7D2BE0 VA: 0x1807D45E0
	private MonumentInfo FindClosestMonument() { }

	// RVA: 0x7D4E00 Offset: 0x7D3400 VA: 0x1807D4E00
	public void .ctor() { }

}

