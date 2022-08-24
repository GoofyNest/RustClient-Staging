public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 4731
{	[NativePropertyAttribute] // RVA: 0xA4310 Offset: 0xA3710 VA: 0x1800A4310
	public float alpha { get; set; }
	[NativePropertyAttribute] // RVA: 0xA43E0 Offset: 0xA37E0 VA: 0x1800A43E0
	public bool interactable { get; set; }
	[NativePropertyAttribute] // RVA: 0xA4600 Offset: 0xA3A00 VA: 0x1800A4600
	public bool blocksRaycasts { get; set; }
	[NativePropertyAttribute] // RVA: 0xA46D0 Offset: 0xA3AD0 VA: 0x1800A46D0
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

