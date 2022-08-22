public class BatchRendererGroup // TypeDefIndex: 3846
{	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private BatchRendererGroup.OnPerformCulling m_PerformCulling; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x19A52E0 Offset: 0x19A38E0 VA: 0x1819A52E0
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters) { }

}

public sealed class BatchRendererGroup.OnPerformCulling : MulticastDelegate // TypeDefIndex: 3847
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19AA880 Offset: 0x19A8E80 VA: 0x1819AA880 Slot: 12
	public virtual JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext) { }

	// RVA: 0x19AA7F0 Offset: 0x19A8DF0 VA: 0x1819AA7F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, AsyncCallback callback, object object) { }

	// RVA: 0x1220D40 Offset: 0x121F340 VA: 0x181220D40 Slot: 14
	public virtual JobHandle EndInvoke(IAsyncResult result) { }

}

