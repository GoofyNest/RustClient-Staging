public class FoliageDisplacement : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 10675
{	// Fields
	public bool moving; // 0x18
	public bool billboard; // 0x19
	public Mesh mesh; // 0x20
	public Material material; // 0x28
	private bool visible; // 0x30
	private LODCell cell; // 0x38

	// Methods

	// RVA: 0x74B170 Offset: 0x749770 VA: 0x18074B170
	protected void OnEnable() { }

	// RVA: 0x74B0B0 Offset: 0x7496B0 VA: 0x18074B0B0
	protected void OnDisable() { }

	// RVA: 0x74B1F0 Offset: 0x7497F0 VA: 0x18074B1F0 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x74B070 Offset: 0x749670 VA: 0x18074B070 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x74B270 Offset: 0x749870 VA: 0x18074B270
	private void SetVisible(bool state) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

