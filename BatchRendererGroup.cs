public class BatchRendererGroup // TypeDefIndex: 3846
{	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private BatchRendererGroup.OnPerformCulling m_PerformCulling; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x19A5060 Offset: 0x19A3660 VA: 0x1819A5060
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters) { }

}

public sealed class BatchRendererGroup.OnPerformCulling : MulticastDelegate // TypeDefIndex: 3847
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19AA600 Offset: 0x19A8C00 VA: 0x1819AA600 Slot: 12
	public virtual JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext) { }

	// RVA: 0x19AA570 Offset: 0x19A8B70 VA: 0x1819AA570 Slot: 13
	public virtual IAsyncResult BeginInvoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, AsyncCallback callback, object object) { }

	// RVA: 0x1220A80 Offset: 0x121F080 VA: 0x181220A80 Slot: 14
	public virtual JobHandle EndInvoke(IAsyncResult result) { }

}

