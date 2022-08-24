public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 4488
{	internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	public AnimationClip Item { get; }


	public AnimationClip get_Item(string name) { }

	[NativeMethodAttribute] // RVA: 0xCD390 Offset: 0xCC790 VA: 0x1800CD390
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xCD440 Offset: 0xCC840 VA: 0x1800CD440
	[NativeConditionalAttribute] // RVA: 0xCD440 Offset: 0xCC840 VA: 0x1800CD440
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

}

internal sealed class AnimatorOverrideController.OnOverrideControllerDirtyCallback : MulticastDelegate // TypeDefIndex: 4489
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

