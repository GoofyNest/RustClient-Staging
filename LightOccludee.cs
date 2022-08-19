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

	// RVA: 0x4F3350 Offset: 0x4F1950 VA: 0x1804F3350
	public bool get_IsVisible() { }

	// RVA: 0x4F2880 Offset: 0x4F0E80 VA: 0x1804F2880
	private void Awake() { }

	// RVA: 0x4F29E0 Offset: 0x4F0FE0 VA: 0x1804F29E0
	private void OnEnable() { }

	// RVA: 0x4F2910 Offset: 0x4F0F10 VA: 0x1804F2910
	private void OnDisable() { }

	// RVA: 0x4F2F70 Offset: 0x4F1570 VA: 0x1804F2F70
	private void UpdateCullingSphere() { }

	// RVA: 0x4F3130 Offset: 0x4F1730 VA: 0x1804F3130
	public void UpdateDynamicOccludee() { }

	// RVA: 0x4F2A70 Offset: 0x4F1070 VA: 0x1804F2A70
	private void RegisterToOcclusionCulling() { }

	// RVA: 0x4F2F00 Offset: 0x4F1500 VA: 0x1804F2F00
	private void UnregisterFromOcclusionCulling() { }

	// RVA: 0x4F31F0 Offset: 0x4F17F0 VA: 0x1804F31F0
	private void UpdateVisibility() { }

	// RVA: 0x4F2EE0 Offset: 0x4F14E0 VA: 0x1804F2EE0
	public void SetLODVisible(bool state) { }

	// RVA: 0x4F2EF0 Offset: 0x4F14F0 VA: 0x1804F2EF0
	public void SetVolumeVisible(bool state) { }

	// RVA: 0x4F2A60 Offset: 0x4F1060 VA: 0x1804F2A60 Slot: 4
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x4F3330 Offset: 0x4F1930 VA: 0x1804F3330
	public void .ctor() { }

}

