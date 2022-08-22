public class CullingVolume : MonoBehaviour, IClientComponent // TypeDefIndex: 9842
{	// Fields
	[TooltipAttribute] // RVA: 0x9F260 Offset: 0x9E660 VA: 0x18009F260
	public GameObject OccludeeRoot; // 0x18
	[TooltipAttribute] // RVA: 0x9F2D0 Offset: 0x9E6D0 VA: 0x18009F2D0
	public bool Invert; // 0x20
	[TooltipAttribute] // RVA: 0x9F340 Offset: 0x9E740 VA: 0x18009F340
	public bool Portal; // 0x21
	[TooltipAttribute] // RVA: 0x9F3E0 Offset: 0x9E7E0 VA: 0x18009F3E0
	public List<CullingVolume> Connections; // 0x28
	private Transform root; // 0x30
	private Bounds bounds; // 0x38
	private List<LODComponent> components; // 0x50
	private List<LightOccludee> lights; // 0x58
	private float lastSeen; // 0x60

	// Methods

	// RVA: 0x6C5500 Offset: 0x6C3B00 VA: 0x1806C5500
	protected void Awake() { }

	// RVA: 0x6C5DD0 Offset: 0x6C43D0 VA: 0x1806C5DD0
	protected void Start() { }

	// RVA: 0x6C5DE0 Offset: 0x6C43E0 VA: 0x1806C5DE0
	private void UpdateBounds() { }

	// RVA: 0x6C6170 Offset: 0x6C4770 VA: 0x1806C6170
	private void UpdateTrigger() { }

	// RVA: 0x6C5E30 Offset: 0x6C4430 VA: 0x1806C5E30
	private void UpdateComponents() { }

	// RVA: 0x6C6000 Offset: 0x6C4600 VA: 0x1806C6000
	private void UpdateLights() { }

	// RVA: 0x6C5A20 Offset: 0x6C4020 VA: 0x1806C5A20
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x6C58C0 Offset: 0x6C3EC0 VA: 0x1806C58C0
	public void MarkSeen(bool recursive = True) { }

	// RVA: 0x6C62A0 Offset: 0x6C48A0 VA: 0x1806C62A0
	public bool UpdateVisible(bool recursive = True) { }

	// RVA: 0x6C5890 Offset: 0x6C3E90 VA: 0x1806C5890
	private bool IsVisible() { }

	// RVA: 0x6C5BA0 Offset: 0x6C41A0 VA: 0x1806C5BA0
	private void SetVisible(bool state) { }

	// RVA: 0x6C6400 Offset: 0x6C4A00 VA: 0x1806C6400
	public void .ctor() { }

}

