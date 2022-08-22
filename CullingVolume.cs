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

	// RVA: 0x6C5570 Offset: 0x6C3B70 VA: 0x1806C5570
	protected void Awake() { }

	// RVA: 0x6C5E40 Offset: 0x6C4440 VA: 0x1806C5E40
	protected void Start() { }

	// RVA: 0x6C5E50 Offset: 0x6C4450 VA: 0x1806C5E50
	private void UpdateBounds() { }

	// RVA: 0x6C61E0 Offset: 0x6C47E0 VA: 0x1806C61E0
	private void UpdateTrigger() { }

	// RVA: 0x6C5EA0 Offset: 0x6C44A0 VA: 0x1806C5EA0
	private void UpdateComponents() { }

	// RVA: 0x6C6070 Offset: 0x6C4670 VA: 0x1806C6070
	private void UpdateLights() { }

	// RVA: 0x6C5A90 Offset: 0x6C4090 VA: 0x1806C5A90
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x6C5930 Offset: 0x6C3F30 VA: 0x1806C5930
	public void MarkSeen(bool recursive = True) { }

	// RVA: 0x6C6310 Offset: 0x6C4910 VA: 0x1806C6310
	public bool UpdateVisible(bool recursive = True) { }

	// RVA: 0x6C5900 Offset: 0x6C3F00 VA: 0x1806C5900
	private bool IsVisible() { }

	// RVA: 0x6C5C10 Offset: 0x6C4210 VA: 0x1806C5C10
	private void SetVisible(bool state) { }

	// RVA: 0x6C6470 Offset: 0x6C4A70 VA: 0x1806C6470
	public void .ctor() { }

}

