public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 4488
{	// Fields
	internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Properties
	public AnimationClip Item { get; }

	// Methods

	// RVA: 0x22DC320 Offset: 0x22DA920 VA: 0x1822DC320
	public AnimationClip get_Item(string name) { }

	[NativeMethodAttribute] // RVA: 0xCD1E0 Offset: 0xCC5E0 VA: 0x1800CD1E0
	// RVA: 0x22DC290 Offset: 0x22DA890 VA: 0x1822DC290
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCD290 Offset: 0xCC690 VA: 0x1800CD290
	[NativeConditionalAttribute] // RVA: 0xCD290 Offset: 0xCC690 VA: 0x1800CD290
	// RVA: 0x22DC2F0 Offset: 0x22DA8F0 VA: 0x1822DC2F0
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

}

internal sealed class AnimatorOverrideController.OnOverrideControllerDirtyCallback : MulticastDelegate // TypeDefIndex: 4489
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A722B0 Offset: 0x1A708B0 VA: 0x181A722B0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

