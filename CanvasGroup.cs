public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 4731
{	[NativePropertyAttribute] // RVA: 0xA41F0 Offset: 0xA35F0 VA: 0x1800A41F0
	public float alpha { get; set; }
	[NativePropertyAttribute] // RVA: 0xA42C0 Offset: 0xA36C0 VA: 0x1800A42C0
	public bool interactable { get; set; }
	[NativePropertyAttribute] // RVA: 0xA4580 Offset: 0xA3980 VA: 0x1800A4580
	public bool blocksRaycasts { get; set; }
	[NativePropertyAttribute] // RVA: 0xA46B0 Offset: 0xA3AB0 VA: 0x1800A46B0
	public bool ignoreParentGroups { get; }


	public float get_alpha() { }

	public void set_alpha(float value) { }

	public bool get_interactable() { }

	public void set_interactable(bool value) { }

	public bool get_blocksRaycasts() { }

	public void set_blocksRaycasts(bool value) { }

	public bool get_ignoreParentGroups() { }

	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

