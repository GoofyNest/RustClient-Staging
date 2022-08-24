public class CullingVolume : MonoBehaviour, IClientComponent // TypeDefIndex: 9842
{	[TooltipAttribute] // RVA: 0x9EE70 Offset: 0x9E270 VA: 0x18009EE70
	public GameObject OccludeeRoot; // 0x18
	[TooltipAttribute] // RVA: 0x9EEE0 Offset: 0x9E2E0 VA: 0x18009EEE0
	public bool Invert; // 0x20
	[TooltipAttribute] // RVA: 0x9F020 Offset: 0x9E420 VA: 0x18009F020
	public bool Portal; // 0x21
	[TooltipAttribute] // RVA: 0x9F090 Offset: 0x9E490 VA: 0x18009F090
	public List<CullingVolume> Connections; // 0x28
	private Transform root; // 0x30
	private Bounds bounds; // 0x38
	private List<LODComponent> components; // 0x50
	private List<LightOccludee> lights; // 0x58
	private float lastSeen; // 0x60


	protected void Awake() { }

	protected void Start() { }

	private void UpdateBounds() { }

	private void UpdateTrigger() { }

	private void UpdateComponents() { }

	private void UpdateLights() { }

	protected void OnDrawGizmosSelected() { }

	public void MarkSeen(bool recursive = True) { }

	public bool UpdateVisible(bool recursive = True) { }

	private bool IsVisible() { }

	private void SetVisible(bool state) { }

	public void .ctor() { }

}

