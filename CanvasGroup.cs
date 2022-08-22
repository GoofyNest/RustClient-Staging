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

	// RVA: 0x2308090 Offset: 0x2306690 VA: 0x182308090
	public float get_alpha() { }

	// RVA: 0x2308150 Offset: 0x2306750 VA: 0x182308150
	public void set_alpha(float value) { }

	// RVA: 0x2308110 Offset: 0x2306710 VA: 0x182308110
	public bool get_interactable() { }

	// RVA: 0x23081F0 Offset: 0x23067F0 VA: 0x1823081F0
	public void set_interactable(bool value) { }

	// RVA: 0x2308050 Offset: 0x2306650 VA: 0x182308050
	public bool get_blocksRaycasts() { }

	// RVA: 0x23081A0 Offset: 0x23067A0 VA: 0x1823081A0
	public void set_blocksRaycasts(bool value) { }

	// RVA: 0x23080D0 Offset: 0x23066D0 VA: 0x1823080D0
	public bool get_ignoreParentGroups() { }

	// RVA: 0x2308050 Offset: 0x2306650 VA: 0x182308050 Slot: 4
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

