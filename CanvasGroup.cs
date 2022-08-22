public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 4731
{	// Properties
	[NativePropertyAttribute] // RVA: 0xA41F0 Offset: 0xA35F0 VA: 0x1800A41F0
	public float alpha { get; set; }
	[NativePropertyAttribute] // RVA: 0xA42C0 Offset: 0xA36C0 VA: 0x1800A42C0
	public bool interactable { get; set; }
	[NativePropertyAttribute] // RVA: 0xA4580 Offset: 0xA3980 VA: 0x1800A4580
	public bool blocksRaycasts { get; set; }
	[NativePropertyAttribute] // RVA: 0xA46B0 Offset: 0xA3AB0 VA: 0x1800A46B0
	public bool ignoreParentGroups { get; }

	// Methods

	// RVA: 0x2307DD0 Offset: 0x23063D0 VA: 0x182307DD0
	public float get_alpha() { }

	// RVA: 0x2307E90 Offset: 0x2306490 VA: 0x182307E90
	public void set_alpha(float value) { }

	// RVA: 0x2307E50 Offset: 0x2306450 VA: 0x182307E50
	public bool get_interactable() { }

	// RVA: 0x2307F30 Offset: 0x2306530 VA: 0x182307F30
	public void set_interactable(bool value) { }

	// RVA: 0x2307D90 Offset: 0x2306390 VA: 0x182307D90
	public bool get_blocksRaycasts() { }

	// RVA: 0x2307EE0 Offset: 0x23064E0 VA: 0x182307EE0
	public void set_blocksRaycasts(bool value) { }

	// RVA: 0x2307E10 Offset: 0x2306410 VA: 0x182307E10
	public bool get_ignoreParentGroups() { }

	// RVA: 0x2307D90 Offset: 0x2306390 VA: 0x182307D90 Slot: 4
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

