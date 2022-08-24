public class CullingGroup : IDisposable // TypeDefIndex: 3366
{	internal IntPtr m_Ptr; // 0x10
	private CullingGroup.StateChanged m_OnStateChanged; // 0x18

	public CullingGroup.StateChanged onStateChanged { set; }
	public Camera targetCamera { get; set; }


	public void .ctor() { }

	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0x78880 Offset: 0x77C80 VA: 0x180078880
	private void DisposeInternal() { }

	public void Dispose() { }

	public void set_onStateChanged(CullingGroup.StateChanged value) { }

	public Camera get_targetCamera() { }

	public void set_targetCamera(Camera value) { }

	public void SetBoundingSpheres(BoundingSphere[] array) { }

	public void SetBoundingSphereCount(int count) { }

	[FreeFunctionAttribute] // RVA: 0x79C70 Offset: 0x79070 VA: 0x180079C70
	public void SetBoundingDistances(float[] distances) { }

	[NativeMethodAttribute] // RVA: 0x79FF0 Offset: 0x793F0 VA: 0x180079FF0
	private void SetDistanceReferencePoint_InternalTransform(Transform transform) { }

	public void SetDistanceReferencePoint(Transform transform) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

	[FreeFunctionAttribute] // RVA: 0x7A3B0 Offset: 0x797B0 VA: 0x18007A3B0
	private static IntPtr Init(object scripting) { }

	[FreeFunctionAttribute] // RVA: 0x7A4C0 Offset: 0x798C0 VA: 0x18007A4C0
	private void FinalizerFailure() { }

}

public sealed class CullingGroup.StateChanged : MulticastDelegate // TypeDefIndex: 3367
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(CullingGroupEvent sphere) { }

	public virtual IAsyncResult BeginInvoke(CullingGroupEvent sphere, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

