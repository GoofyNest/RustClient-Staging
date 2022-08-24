public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 4488
{	internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	public AnimationClip Item { get; }


	public AnimationClip get_Item(string name) { }

	[NativeMethodAttribute] // RVA: 0xCD310 Offset: 0xCC710 VA: 0x1800CD310
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCD370 Offset: 0xCC770 VA: 0x1800CD370
	[NativeConditionalAttribute] // RVA: 0xCD370 Offset: 0xCC770 VA: 0x1800CD370
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

}

internal sealed class AnimatorOverrideController.OnOverrideControllerDirtyCallback : MulticastDelegate // TypeDefIndex: 4489
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

