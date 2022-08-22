public class FoliageDisplacement : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 10675
{	// Fields
	public bool moving; // 0x18
	public bool billboard; // 0x19
	public Mesh mesh; // 0x20
	public Material material; // 0x28
	private bool visible; // 0x30
	private LODCell cell; // 0x38

	// Methods

	// RVA: 0x74B220 Offset: 0x749820 VA: 0x18074B220
	protected void OnEnable() { }

	// RVA: 0x74B160 Offset: 0x749760 VA: 0x18074B160
	protected void OnDisable() { }

	// RVA: 0x74B2A0 Offset: 0x7498A0 VA: 0x18074B2A0 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x74B120 Offset: 0x749720 VA: 0x18074B120 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x74B320 Offset: 0x749920 VA: 0x18074B320
	private void SetVisible(bool state) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

