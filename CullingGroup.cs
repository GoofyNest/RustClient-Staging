public class CullingGroup : IDisposable // TypeDefIndex: 3366
{	internal IntPtr m_Ptr; // 0x10
	private CullingGroup.StateChanged m_OnStateChanged; // 0x18

	public CullingGroup.StateChanged onStateChanged { set; }
	public Camera targetCamera { get; set; }


	public void .ctor() { }

	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0x787F0 Offset: 0x77BF0 VA: 0x1800787F0
	private void DisposeInternal() { }

	public void Dispose() { }

	public void set_onStateChanged(CullingGroup.StateChanged value) { }

	public Camera get_targetCamera() { }

	public void set_targetCamera(Camera value) { }

	public void SetBoundingSpheres(BoundingSphere[] array) { }

	public void SetBoundingSphereCount(int count) { }

	[FreeFunctionAttribute] // RVA: 0x79BD0 Offset: 0x78FD0 VA: 0x180079BD0
	public void SetBoundingDistances(float[] distances) { }

	[NativeMethodAttribute] // RVA: 0x79F40 Offset: 0x79340 VA: 0x180079F40
	private void SetDistanceReferencePoint_InternalTransform(Transform transform) { }

	public void SetDistanceReferencePoint(Transform transform) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

	[FreeFunctionAttribute] // RVA: 0x7A2C0 Offset: 0x796C0 VA: 0x18007A2C0
	private static IntPtr Init(object scripting) { }

	[FreeFunctionAttribute] // RVA: 0x7A3D0 Offset: 0x797D0 VA: 0x18007A3D0
	private void FinalizerFailure() { }

}

public sealed class CullingGroup.StateChanged : MulticastDelegate // TypeDefIndex: 3367
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(CullingGroupEvent sphere) { }

	public virtual IAsyncResult BeginInvoke(CullingGroupEvent sphere, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

