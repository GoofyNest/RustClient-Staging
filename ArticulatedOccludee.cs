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

	// RVA: 0x77B0E0 Offset: 0x7796E0 VA: 0x18077B0E0
	public bool get_IsVisible() { }

	// RVA: 0x82EBB0 Offset: 0x82D1B0 VA: 0x18082EBB0 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x82EA60 Offset: 0x82D060 VA: 0x18082EA60
	private void ClearVisibility() { }

	// RVA: 0x82EFC0 Offset: 0x82D5C0 VA: 0x18082EFC0
	public void ProcessVisibility(LODGroup lod) { }

	// RVA: 0x82F190 Offset: 0x82D790 VA: 0x18082F190
	private void RegisterForCulling(OcclusionCulling.Sphere sphere, bool visible) { }

	// RVA: 0x82F630 Offset: 0x82DC30 VA: 0x18082F630
	private void UnregisterFromCulling() { }

	// RVA: 0x82F6B0 Offset: 0x82DCB0 VA: 0x18082F6B0
	public void UpdateCullingBounds() { }

	// RVA: 0x82EA40 Offset: 0x82D040 VA: 0x18082EA40 Slot: 7
	protected virtual bool CheckVisibility() { }

	// RVA: 0x82E930 Offset: 0x82CF30 VA: 0x18082E930
	private void ApplyVisibility(bool vis) { }

	// RVA: 0x82EE20 Offset: 0x82D420 VA: 0x18082EE20 Slot: 8
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x82FF10 Offset: 0x82E510 VA: 0x18082FF10
	private void UpdateVisibility(float delay) { }

	// RVA: 0x8301E0 Offset: 0x82E7E0 VA: 0x1808301E0
	private void VisUpdateUsingCulling(float dist, bool visibility) { }

	// RVA: 0x82F3E0 Offset: 0x82D9E0 VA: 0x18082F3E0 Slot: 9
	public virtual void TriggerUpdateVisibilityBounds() { }

	// RVA: 0x82ED50 Offset: 0x82D350 VA: 0x18082ED50 Slot: 10
	protected virtual void OnDrawGizmos() { }

	// RVA: 0x830290 Offset: 0x82E890 VA: 0x180830290
	public void .ctor() { }

}

