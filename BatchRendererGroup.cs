public class BatchRendererGroup // TypeDefIndex: 3846
{	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private BatchRendererGroup.OnPerformCulling m_PerformCulling; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19926E0 Offset: 0x1990CE0 VA: 0x1819926E0
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters) { }

}

public sealed class BatchRendererGroup.OnPerformCulling : MulticastDelegate // TypeDefIndex: 3847
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1997C80 Offset: 0x1996280 VA: 0x181997C80 Slot: 12
	public virtual JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext) { }

	// RVA: 0x1997BF0 Offset: 0x19961F0 VA: 0x181997BF0 Slot: 13
	public virtual IAsyncResult BeginInvoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, AsyncCallback callback, object object) { }

	// RVA: 0x12213E0 Offset: 0x121F9E0 VA: 0x1812213E0 Slot: 14
	public virtual JobHandle EndInvoke(IAsyncResult result) { }

}

