public class LightOccludee : MonoBehaviour // TypeDefIndex: 11310
{	// Fields
	public float RadiusScale; // 0x18
	public float MinTimeVisible; // 0x1C
	public bool IsDynamic; // 0x20
	private Light light; // 0x28
	private LightEx lightEx; // 0x30
	private VolumetricLightBeam volumetricBeam; // 0x38
	private OccludeeSphere occludee; // 0x40
	private bool lodVisible; // 0x60
	private bool volumeVisible; // 0x61
	private bool occludeeCulled; // 0x62

	// Properties
	public bool IsVisible { get; }

	// Methods

	// RVA: 0x4F32E0 Offset: 0x4F18E0 VA: 0x1804F32E0
	public bool get_IsVisible() { }

	// RVA: 0x4F2810 Offset: 0x4F0E10 VA: 0x1804F2810
	private void Awake() { }

	// RVA: 0x4F2970 Offset: 0x4F0F70 VA: 0x1804F2970
	private void OnEnable() { }

	// RVA: 0x4F28A0 Offset: 0x4F0EA0 VA: 0x1804F28A0
	private void OnDisable() { }

	// RVA: 0x4F2F00 Offset: 0x4F1500 VA: 0x1804F2F00
	private void UpdateCullingSphere() { }

	// RVA: 0x4F30C0 Offset: 0x4F16C0 VA: 0x1804F30C0
	public void UpdateDynamicOccludee() { }

	// RVA: 0x4F2A00 Offset: 0x4F1000 VA: 0x1804F2A00
	private void RegisterToOcclusionCulling() { }

	// RVA: 0x4F2E90 Offset: 0x4F1490 VA: 0x1804F2E90
	private void UnregisterFromOcclusionCulling() { }

	// RVA: 0x4F3180 Offset: 0x4F1780 VA: 0x1804F3180
	private void UpdateVisibility() { }

	// RVA: 0x4F2E70 Offset: 0x4F1470 VA: 0x1804F2E70
	public void SetLODVisible(bool state) { }

	// RVA: 0x4F2E80 Offset: 0x4F1480 VA: 0x1804F2E80
	public void SetVolumeVisible(bool state) { }

	// RVA: 0x4F29F0 Offset: 0x4F0FF0 VA: 0x1804F29F0 Slot: 4
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x4F32C0 Offset: 0x4F18C0 VA: 0x1804F32C0
	public void .ctor() { }

}

