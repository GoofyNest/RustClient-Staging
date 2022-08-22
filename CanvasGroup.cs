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

	// RVA: 0x23088B0 Offset: 0x2306EB0 VA: 0x1823088B0
	public float get_alpha() { }

	// RVA: 0x2308970 Offset: 0x2306F70 VA: 0x182308970
	public void set_alpha(float value) { }

	// RVA: 0x2308930 Offset: 0x2306F30 VA: 0x182308930
	public bool get_interactable() { }

	// RVA: 0x2308A10 Offset: 0x2307010 VA: 0x182308A10
	public void set_interactable(bool value) { }

	// RVA: 0x2308870 Offset: 0x2306E70 VA: 0x182308870
	public bool get_blocksRaycasts() { }

	// RVA: 0x23089C0 Offset: 0x2306FC0 VA: 0x1823089C0
	public void set_blocksRaycasts(bool value) { }

	// RVA: 0x23088F0 Offset: 0x2306EF0 VA: 0x1823088F0
	public bool get_ignoreParentGroups() { }

	// RVA: 0x2308870 Offset: 0x2306E70 VA: 0x182308870 Slot: 4
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

