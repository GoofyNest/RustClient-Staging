public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 4731
{	[NativePropertyAttribute] // RVA: 0xA4440 Offset: 0xA3840 VA: 0x1800A4440
	public float alpha { get; set; }
	[NativePropertyAttribute] // RVA: 0xA4500 Offset: 0xA3900 VA: 0x1800A4500
	public bool interactable { get; set; }
	[NativePropertyAttribute] // RVA: 0xA4730 Offset: 0xA3B30 VA: 0x1800A4730
	public bool blocksRaycasts { get; set; }
	[NativePropertyAttribute] // RVA: 0xA47D0 Offset: 0xA3BD0 VA: 0x1800A47D0
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

