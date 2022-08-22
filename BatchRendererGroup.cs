public class BatchRendererGroup // TypeDefIndex: 3846
{	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private BatchRendererGroup.OnPerformCulling m_PerformCulling; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A5020 Offset: 0x19A3620 VA: 0x1819A5020
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters) { }

}

public sealed class BatchRendererGroup.OnPerformCulling : MulticastDelegate // TypeDefIndex: 3847
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19AA5C0 Offset: 0x19A8BC0 VA: 0x1819AA5C0 Slot: 12
	public virtual JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext) { }

	// RVA: 0x19AA530 Offset: 0x19A8B30 VA: 0x1819AA530 Slot: 13
	public virtual IAsyncResult BeginInvoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, AsyncCallback callback, object object) { }

	// RVA: 0x1220A80 Offset: 0x121F080 VA: 0x181220A80 Slot: 14
	public virtual JobHandle EndInvoke(IAsyncResult result) { }

}

