public class CullingGroup : IDisposable // TypeDefIndex: 3366
{	internal IntPtr m_Ptr; // 0x10
	private CullingGroup.StateChanged m_OnStateChanged; // 0x18

	public CullingGroup.StateChanged onStateChanged { set; }
	public Camera targetCamera { get; set; }


	public void .ctor() { }

	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0x788A0 Offset: 0x77CA0 VA: 0x1800788A0
	private void DisposeInternal() { }

	public void Dispose() { }

	public void set_onStateChanged(CullingGroup.StateChanged value) { }

	public Camera get_targetCamera() { }

	public void set_targetCamera(Camera value) { }

	public void SetBoundingSpheres(BoundingSphere[] array) { }

	public void SetBoundingSphereCount(int count) { }

	[FreeFunctionAttribute] // RVA: 0x79C70 Offset: 0x79070 VA: 0x180079C70
	public void SetBoundingDistances(float[] distances) { }

	[NativeMethodAttribute] // RVA: 0x79FE0 Offset: 0x793E0 VA: 0x180079FE0
	private void SetDistanceReferencePoint_InternalTransform(Transform transform) { }

	public void SetDistanceReferencePoint(Transform transform) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

	[FreeFunctionAttribute] // RVA: 0x7A3F0 Offset: 0x797F0 VA: 0x18007A3F0
	private static IntPtr Init(object scripting) { }

	[FreeFunctionAttribute] // RVA: 0x7A510 Offset: 0x79910 VA: 0x18007A510
	private void FinalizerFailure() { }

}

public sealed class CullingGroup.StateChanged : MulticastDelegate // TypeDefIndex: 3367
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(CullingGroupEvent sphere) { }

	public virtual IAsyncResult BeginInvoke(CullingGroupEvent sphere, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

