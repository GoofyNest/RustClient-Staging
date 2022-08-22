public class ArticulatedOccludee : BaseMonoBehaviour // TypeDefIndex: 9274
{	// Fields
	private const float UpdateBoundsFadeStart = 20;
	private const float UpdateBoundsFadeLength = 1000;
	private const float UpdateBoundsMaxFrequency = 15;
	private const float UpdateBoundsMinFrequency = 0,5;
	private LODGroup lodGroup; // 0x18
	public List<Collider> colliders; // 0x20
	private OccludeeSphere localOccludee; // 0x28
	private List<Renderer> renderers; // 0x48
	private bool isVisible; // 0x50
	private Action TriggerUpdateVisibilityBoundsDelegate; // 0x58

	// Properties
	public bool IsVisible { get; }

	// Methods

	// RVA: 0x77B140 Offset: 0x779740 VA: 0x18077B140
	public bool get_IsVisible() { }

	// RVA: 0x82F210 Offset: 0x82D810 VA: 0x18082F210 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x82F0C0 Offset: 0x82D6C0 VA: 0x18082F0C0
	private void ClearVisibility() { }

	// RVA: 0x82F620 Offset: 0x82DC20 VA: 0x18082F620
	public void ProcessVisibility(LODGroup lod) { }

	// RVA: 0x82F7F0 Offset: 0x82DDF0 VA: 0x18082F7F0
	private void RegisterForCulling(OcclusionCulling.Sphere sphere, bool visible) { }

	// RVA: 0x82FC90 Offset: 0x82E290 VA: 0x18082FC90
	private void UnregisterFromCulling() { }

	// RVA: 0x82FD10 Offset: 0x82E310 VA: 0x18082FD10
	public void UpdateCullingBounds() { }

	// RVA: 0x82F0A0 Offset: 0x82D6A0 VA: 0x18082F0A0 Slot: 7
	protected virtual bool CheckVisibility() { }

	// RVA: 0x82EF90 Offset: 0x82D590 VA: 0x18082EF90
	private void ApplyVisibility(bool vis) { }

	// RVA: 0x82F480 Offset: 0x82DA80 VA: 0x18082F480 Slot: 8
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x830570 Offset: 0x82EB70 VA: 0x180830570
	private void UpdateVisibility(float delay) { }

	// RVA: 0x830840 Offset: 0x82EE40 VA: 0x180830840
	private void VisUpdateUsingCulling(float dist, bool visibility) { }

	// RVA: 0x82FA40 Offset: 0x82E040 VA: 0x18082FA40 Slot: 9
	public virtual void TriggerUpdateVisibilityBounds() { }

	// RVA: 0x82F3B0 Offset: 0x82D9B0 VA: 0x18082F3B0 Slot: 10
	protected virtual void OnDrawGizmos() { }

	// RVA: 0x8308F0 Offset: 0x82EEF0 VA: 0x1808308F0
	public void .ctor() { }

}

