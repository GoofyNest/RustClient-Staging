public class MonumentSign : LODComponent // TypeDefIndex: 8808
{	// Fields
	public float viewDistance; // 0x80
	public GameObject uiRoot; // 0x88
	public RustText signText; // 0x90
	private MonumentInfo closestMonument; // 0x98
	private int currentLod; // 0xA0
	private bool force; // 0xA4

	// Methods

	// RVA: 0x7B68E0 Offset: 0x7B4EE0 VA: 0x1807B68E0
	private void UpdateText() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	protected override void InitLOD() { }

	// RVA: 0x7B61E0 Offset: 0x7B47E0 VA: 0x1807B61E0 Slot: 9
	protected override void EnableLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	protected override void DisableLOD() { }

	// RVA: 0x7B6740 Offset: 0x7B4D40 VA: 0x1807B6740 Slot: 13
	protected override void Show() { }

	// RVA: 0x7B6600 Offset: 0x7B4C00 VA: 0x1807B6600 Slot: 14
	protected override void Hide() { }

	// RVA: 0x7B6690 Offset: 0x7B4C90 VA: 0x1807B6690 Slot: 12
	protected override void SetLOD(int newlod) { }

	// RVA: 0x4C7930 Offset: 0x4C5F30 VA: 0x1804C7930 Slot: 11
	protected override int GetLOD(float distance) { }

	// RVA: 0x7B61F0 Offset: 0x7B47F0 VA: 0x1807B61F0
	private MonumentInfo FindClosestMonument() { }

	// RVA: 0x7B6A10 Offset: 0x7B5010 VA: 0x1807B6A10
	public void .ctor() { }

}

