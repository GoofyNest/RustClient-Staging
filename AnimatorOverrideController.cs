public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 4488
{	// Fields
	internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Properties
	public AnimationClip Item { get; }

	// Methods

	// RVA: 0x22DBA00 Offset: 0x22DA000 VA: 0x1822DBA00
	public AnimationClip get_Item(string name) { }

	[NativeMethodAttribute] // RVA: 0xCD150 Offset: 0xCC550 VA: 0x1800CD150
	// RVA: 0x22DB970 Offset: 0x22D9F70 VA: 0x1822DB970
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCD200 Offset: 0xCC600 VA: 0x1800CD200
	[NativeConditionalAttribute] // RVA: 0xCD200 Offset: 0xCC600 VA: 0x1800CD200
	// RVA: 0x22DB9D0 Offset: 0x22D9FD0 VA: 0x1822DB9D0
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

}

internal sealed class AnimatorOverrideController.OnOverrideControllerDirtyCallback : MulticastDelegate // TypeDefIndex: 4489
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A85B00 Offset: 0x1A84100 VA: 0x181A85B00 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

