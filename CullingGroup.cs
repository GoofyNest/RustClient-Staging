public class CullingGroup : IDisposable // TypeDefIndex: 3366
{	// Fields
	internal IntPtr m_Ptr; // 0x10
	private CullingGroup.StateChanged m_OnStateChanged; // 0x18

	// Properties
	public CullingGroup.StateChanged onStateChanged { set; }
	public Camera targetCamera { get; set; }

	// Methods

	// RVA: 0x1827DE0 Offset: 0x18263E0 VA: 0x181827DE0
	public void .ctor() { }

	// RVA: 0x1827AE0 Offset: 0x18260E0 VA: 0x181827AE0 Slot: 1
	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0x787F0 Offset: 0x77BF0 VA: 0x1800787F0
	// RVA: 0x1827A40 Offset: 0x1826040 VA: 0x181827A40
	private void DisposeInternal() { }

	// RVA: 0x1827A80 Offset: 0x1826080 VA: 0x181827A80 Slot: 4
	public void Dispose() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_onStateChanged(CullingGroup.StateChanged value) { }

	// RVA: 0x1827E40 Offset: 0x1826440 VA: 0x181827E40
	public Camera get_targetCamera() { }

	// RVA: 0x1827E80 Offset: 0x1826480 VA: 0x181827E80
	public void set_targetCamera(Camera value) { }

	// RVA: 0x1827D40 Offset: 0x1826340 VA: 0x181827D40
	public void SetBoundingSpheres(BoundingSphere[] array) { }

	// RVA: 0x1827D00 Offset: 0x1826300 VA: 0x181827D00
	public void SetBoundingSphereCount(int count) { }

	[FreeFunctionAttribute] // RVA: 0x79BD0 Offset: 0x78FD0 VA: 0x180079BD0
	// RVA: 0x1827CB0 Offset: 0x18262B0 VA: 0x181827CB0
	public void SetBoundingDistances(float[] distances) { }

	[NativeMethodAttribute] // RVA: 0x79F40 Offset: 0x79340 VA: 0x180079F40
	// RVA: 0x1827D90 Offset: 0x1826390 VA: 0x181827D90
	private void SetDistanceReferencePoint_InternalTransform(Transform transform) { }

	// RVA: 0x1827D90 Offset: 0x1826390 VA: 0x181827D90
	public void SetDistanceReferencePoint(Transform transform) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1827C40 Offset: 0x1826240 VA: 0x181827C40
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

	[FreeFunctionAttribute] // RVA: 0x7A2C0 Offset: 0x796C0 VA: 0x18007A2C0
	// RVA: 0x1827C00 Offset: 0x1826200 VA: 0x181827C00
	private static IntPtr Init(object scripting) { }

	[FreeFunctionAttribute] // RVA: 0x7A3D0 Offset: 0x797D0 VA: 0x18007A3D0
	// RVA: 0x1827BC0 Offset: 0x18261C0 VA: 0x181827BC0
	private void FinalizerFailure() { }

}

public sealed class CullingGroup.StateChanged : MulticastDelegate // TypeDefIndex: 3367
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18330B0 Offset: 0x18316B0 VA: 0x1818330B0 Slot: 12
	public virtual void Invoke(CullingGroupEvent sphere) { }

	// RVA: 0x1833030 Offset: 0x1831630 VA: 0x181833030 Slot: 13
	public virtual IAsyncResult BeginInvoke(CullingGroupEvent sphere, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

