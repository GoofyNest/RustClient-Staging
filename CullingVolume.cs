public class CullingVolume : MonoBehaviour, IClientComponent // TypeDefIndex: 9842
{	// Fields
	[TooltipAttribute] // RVA: 0x9F190 Offset: 0x9E590 VA: 0x18009F190
	public GameObject OccludeeRoot; // 0x18
	[TooltipAttribute] // RVA: 0x9F200 Offset: 0x9E600 VA: 0x18009F200
	public bool Invert; // 0x20
	[TooltipAttribute] // RVA: 0x9F270 Offset: 0x9E670 VA: 0x18009F270
	public bool Portal; // 0x21
	[TooltipAttribute] // RVA: 0x9F310 Offset: 0x9E710 VA: 0x18009F310
	public List<CullingVolume> Connections; // 0x28
	private Transform root; // 0x30
	private Bounds bounds; // 0x38
	private List<LODComponent> components; // 0x50
	private List<LightOccludee> lights; // 0x58
	private float lastSeen; // 0x60

	// Methods

	// RVA: 0x6C5460 Offset: 0x6C3A60 VA: 0x1806C5460
	protected void Awake() { }

	// RVA: 0x6C5D30 Offset: 0x6C4330 VA: 0x1806C5D30
	protected void Start() { }

	// RVA: 0x6C5D40 Offset: 0x6C4340 VA: 0x1806C5D40
	private void UpdateBounds() { }

	// RVA: 0x6C60D0 Offset: 0x6C46D0 VA: 0x1806C60D0
	private void UpdateTrigger() { }

	// RVA: 0x6C5D90 Offset: 0x6C4390 VA: 0x1806C5D90
	private void UpdateComponents() { }

	// RVA: 0x6C5F60 Offset: 0x6C4560 VA: 0x1806C5F60
	private void UpdateLights() { }

	// RVA: 0x6C5980 Offset: 0x6C3F80 VA: 0x1806C5980
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x6C5820 Offset: 0x6C3E20 VA: 0x1806C5820
	public void MarkSeen(bool recursive = True) { }

	// RVA: 0x6C6200 Offset: 0x6C4800 VA: 0x1806C6200
	public bool UpdateVisible(bool recursive = True) { }

	// RVA: 0x6C57F0 Offset: 0x6C3DF0 VA: 0x1806C57F0
	private bool IsVisible() { }

	// RVA: 0x6C5B00 Offset: 0x6C4100 VA: 0x1806C5B00
	private void SetVisible(bool state) { }

	// RVA: 0x6C6360 Offset: 0x6C4960 VA: 0x1806C6360
	public void .ctor() { }

}

