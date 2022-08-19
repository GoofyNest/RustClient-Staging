public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 4731
{	// Properties
	[NativePropertyAttribute] // RVA: 0xA4160 Offset: 0xA3560 VA: 0x1800A4160
	public float alpha { get; set; }
	[NativePropertyAttribute] // RVA: 0xA4230 Offset: 0xA3630 VA: 0x1800A4230
	public bool interactable { get; set; }
	[NativePropertyAttribute] // RVA: 0xA44F0 Offset: 0xA38F0 VA: 0x1800A44F0
	public bool blocksRaycasts { get; set; }
	[NativePropertyAttribute] // RVA: 0xA4620 Offset: 0xA3A20 VA: 0x1800A4620
	public bool ignoreParentGroups { get; }

	// Methods

	// RVA: 0x2307F90 Offset: 0x2306590 VA: 0x182307F90
	public float get_alpha() { }

	// RVA: 0x2308050 Offset: 0x2306650 VA: 0x182308050
	public void set_alpha(float value) { }

	// RVA: 0x2308010 Offset: 0x2306610 VA: 0x182308010
	public bool get_interactable() { }

	// RVA: 0x23080F0 Offset: 0x23066F0 VA: 0x1823080F0
	public void set_interactable(bool value) { }

	// RVA: 0x2307F50 Offset: 0x2306550 VA: 0x182307F50
	public bool get_blocksRaycasts() { }

	// RVA: 0x23080A0 Offset: 0x23066A0 VA: 0x1823080A0
	public void set_blocksRaycasts(bool value) { }

	// RVA: 0x2307FD0 Offset: 0x23065D0 VA: 0x182307FD0
	public bool get_ignoreParentGroups() { }

	// RVA: 0x2307F50 Offset: 0x2306550 VA: 0x182307F50 Slot: 4
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

