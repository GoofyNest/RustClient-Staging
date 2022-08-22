public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 4488
{	// Fields
	internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Properties
	public AnimationClip Item { get; }

	// Methods

	// RVA: 0x22DBB00 Offset: 0x22DA100 VA: 0x1822DBB00
	public AnimationClip get_Item(string name) { }

	[NativeMethodAttribute] // RVA: 0xCD1E0 Offset: 0xCC5E0 VA: 0x1800CD1E0
	// RVA: 0x22DBA70 Offset: 0x22DA070 VA: 0x1822DBA70
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCD290 Offset: 0xCC690 VA: 0x1800CD290
	[NativeConditionalAttribute] // RVA: 0xCD290 Offset: 0xCC690 VA: 0x1800CD290
	// RVA: 0x22DBAD0 Offset: 0x22DA0D0 VA: 0x1822DBAD0
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

}

internal sealed class AnimatorOverrideController.OnOverrideControllerDirtyCallback : MulticastDelegate // TypeDefIndex: 4489
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A85D80 Offset: 0x1A84380 VA: 0x181A85D80 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

