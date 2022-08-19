public class CullingGroup : IDisposable // TypeDefIndex: 3366
{	// Fields
	internal IntPtr m_Ptr; // 0x10
	private CullingGroup.StateChanged m_OnStateChanged; // 0x18

	// Properties
	public CullingGroup.StateChanged onStateChanged { set; }
	public Camera targetCamera { get; set; }

	// Methods

	// RVA: 0x1827B20 Offset: 0x1826120 VA: 0x181827B20
	public void .ctor() { }

	// RVA: 0x1827820 Offset: 0x1825E20 VA: 0x181827820 Slot: 1
	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0x787A0 Offset: 0x77BA0 VA: 0x1800787A0
	// RVA: 0x1827780 Offset: 0x1825D80 VA: 0x181827780
	private void DisposeInternal() { }

	// RVA: 0x18277C0 Offset: 0x1825DC0 VA: 0x1818277C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_onStateChanged(CullingGroup.StateChanged value) { }

	// RVA: 0x1827B80 Offset: 0x1826180 VA: 0x181827B80
	public Camera get_targetCamera() { }

	// RVA: 0x1827BC0 Offset: 0x18261C0 VA: 0x181827BC0
	public void set_targetCamera(Camera value) { }

	// RVA: 0x1827A80 Offset: 0x1826080 VA: 0x181827A80
	public void SetBoundingSpheres(BoundingSphere[] array) { }

	// RVA: 0x1827A40 Offset: 0x1826040 VA: 0x181827A40
	public void SetBoundingSphereCount(int count) { }

	[FreeFunctionAttribute] // RVA: 0x79C20 Offset: 0x79020 VA: 0x180079C20
	// RVA: 0x18279F0 Offset: 0x1825FF0 VA: 0x1818279F0
	public void SetBoundingDistances(float[] distances) { }

	[NativeMethodAttribute] // RVA: 0x79F10 Offset: 0x79310 VA: 0x180079F10
	// RVA: 0x1827AD0 Offset: 0x18260D0 VA: 0x181827AD0
	private void SetDistanceReferencePoint_InternalTransform(Transform transform) { }

	// RVA: 0x1827AD0 Offset: 0x18260D0 VA: 0x181827AD0
	public void SetDistanceReferencePoint(Transform transform) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1827980 Offset: 0x1825F80 VA: 0x181827980
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

	[FreeFunctionAttribute] // RVA: 0x7A2D0 Offset: 0x796D0 VA: 0x18007A2D0
	// RVA: 0x1827940 Offset: 0x1825F40 VA: 0x181827940
	private static IntPtr Init(object scripting) { }

	[FreeFunctionAttribute] // RVA: 0x7A3B0 Offset: 0x797B0 VA: 0x18007A3B0
	// RVA: 0x1827900 Offset: 0x1825F00 VA: 0x181827900
	private void FinalizerFailure() { }

}

public sealed class CullingGroup.StateChanged : MulticastDelegate // TypeDefIndex: 3367
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1832E30 Offset: 0x1831430 VA: 0x181832E30 Slot: 12
	public virtual void Invoke(CullingGroupEvent sphere) { }

	// RVA: 0x1832DB0 Offset: 0x18313B0 VA: 0x181832DB0 Slot: 13
	public virtual IAsyncResult BeginInvoke(CullingGroupEvent sphere, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

