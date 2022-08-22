public class CullingVolume : MonoBehaviour, IClientComponent // TypeDefIndex: 9842
{	[TooltipAttribute] // RVA: 0x9F260 Offset: 0x9E660 VA: 0x18009F260
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

