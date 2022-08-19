public class FoliageDisplacement : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 10675
{	// Fields
	public bool moving; // 0x18
	public bool billboard; // 0x19
	public Mesh mesh; // 0x20
	public Material material; // 0x28
	private bool visible; // 0x30
	private LODCell cell; // 0x38

	// Methods

	// RVA: 0x74B110 Offset: 0x749710 VA: 0x18074B110
	protected void OnEnable() { }

	// RVA: 0x74B050 Offset: 0x749650 VA: 0x18074B050
	protected void OnDisable() { }

	// RVA: 0x74B190 Offset: 0x749790 VA: 0x18074B190 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x74B010 Offset: 0x749610 VA: 0x18074B010 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x74B210 Offset: 0x749810 VA: 0x18074B210
	private void SetVisible(bool state) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

