public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 4488
{	internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	public AnimationClip Item { get; }


	public AnimationClip get_Item(string name) { }

	[NativeMethodAttribute] // RVA: 0xCD1E0 Offset: 0xCC5E0 VA: 0x1800CD1E0
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCD290 Offset: 0xCC690 VA: 0x1800CD290
	[NativeConditionalAttribute] // RVA: 0xCD290 Offset: 0xCC690 VA: 0x1800CD290
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

}

internal sealed class AnimatorOverrideController.OnOverrideControllerDirtyCallback : MulticastDelegate // TypeDefIndex: 4489
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

