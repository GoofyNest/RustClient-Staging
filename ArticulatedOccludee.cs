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

	// RVA: 0x77B1F0 Offset: 0x7797F0 VA: 0x18077B1F0
	public bool get_IsVisible() { }

	// RVA: 0x82ECC0 Offset: 0x82D2C0 VA: 0x18082ECC0 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x82EB70 Offset: 0x82D170 VA: 0x18082EB70
	private void ClearVisibility() { }

	// RVA: 0x82F0D0 Offset: 0x82D6D0 VA: 0x18082F0D0
	public void ProcessVisibility(LODGroup lod) { }

	// RVA: 0x82F2A0 Offset: 0x82D8A0 VA: 0x18082F2A0
	private void RegisterForCulling(OcclusionCulling.Sphere sphere, bool visible) { }

	// RVA: 0x82F740 Offset: 0x82DD40 VA: 0x18082F740
	private void UnregisterFromCulling() { }

	// RVA: 0x82F7C0 Offset: 0x82DDC0 VA: 0x18082F7C0
	public void UpdateCullingBounds() { }

	// RVA: 0x82EB50 Offset: 0x82D150 VA: 0x18082EB50 Slot: 7
	protected virtual bool CheckVisibility() { }

	// RVA: 0x82EA40 Offset: 0x82D040 VA: 0x18082EA40
	private void ApplyVisibility(bool vis) { }

	// RVA: 0x82EF30 Offset: 0x82D530 VA: 0x18082EF30 Slot: 8
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x830020 Offset: 0x82E620 VA: 0x180830020
	private void UpdateVisibility(float delay) { }

	// RVA: 0x8302F0 Offset: 0x82E8F0 VA: 0x1808302F0
	private void VisUpdateUsingCulling(float dist, bool visibility) { }

	// RVA: 0x82F4F0 Offset: 0x82DAF0 VA: 0x18082F4F0 Slot: 9
	public virtual void TriggerUpdateVisibilityBounds() { }

	// RVA: 0x82EE60 Offset: 0x82D460 VA: 0x18082EE60 Slot: 10
	protected virtual void OnDrawGizmos() { }

	// RVA: 0x8303A0 Offset: 0x82E9A0 VA: 0x1808303A0
	public void .ctor() { }

}

