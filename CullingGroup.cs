public class CullingGroup : IDisposable // TypeDefIndex: 3366
{	// Fields
	internal IntPtr m_Ptr; // 0x10
	private CullingGroup.StateChanged m_OnStateChanged; // 0x18

	// Properties
	public CullingGroup.StateChanged onStateChanged { set; }
	public Camera targetCamera { get; set; }

	// Methods

	// RVA: 0x1815220 Offset: 0x1813820 VA: 0x181815220
	public void .ctor() { }

	// RVA: 0x1814F20 Offset: 0x1813520 VA: 0x181814F20 Slot: 1
	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0x787F0 Offset: 0x77BF0 VA: 0x1800787F0
	// RVA: 0x1814E80 Offset: 0x1813480 VA: 0x181814E80
	private void DisposeInternal() { }

	// RVA: 0x1814EC0 Offset: 0x18134C0 VA: 0x181814EC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_onStateChanged(CullingGroup.StateChanged value) { }

	// RVA: 0x1815280 Offset: 0x1813880 VA: 0x181815280
	public Camera get_targetCamera() { }

	// RVA: 0x18152C0 Offset: 0x18138C0 VA: 0x1818152C0
	public void set_targetCamera(Camera value) { }

	// RVA: 0x1815180 Offset: 0x1813780 VA: 0x181815180
	public void SetBoundingSpheres(BoundingSphere[] array) { }

	// RVA: 0x1815140 Offset: 0x1813740 VA: 0x181815140
	public void SetBoundingSphereCount(int count) { }

	[FreeFunctionAttribute] // RVA: 0x79BD0 Offset: 0x78FD0 VA: 0x180079BD0
	// RVA: 0x18150F0 Offset: 0x18136F0 VA: 0x1818150F0
	public void SetBoundingDistances(float[] distances) { }

	[NativeMethodAttribute] // RVA: 0x79F40 Offset: 0x79340 VA: 0x180079F40
	// RVA: 0x18151D0 Offset: 0x18137D0 VA: 0x1818151D0
	private void SetDistanceReferencePoint_InternalTransform(Transform transform) { }

	// RVA: 0x18151D0 Offset: 0x18137D0 VA: 0x1818151D0
	public void SetDistanceReferencePoint(Transform transform) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1815080 Offset: 0x1813680 VA: 0x181815080
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

	[FreeFunctionAttribute] // RVA: 0x7A2C0 Offset: 0x796C0 VA: 0x18007A2C0
	// RVA: 0x1815040 Offset: 0x1813640 VA: 0x181815040
	private static IntPtr Init(object scripting) { }

	[FreeFunctionAttribute] // RVA: 0x7A3D0 Offset: 0x797D0 VA: 0x18007A3D0
	// RVA: 0x1815000 Offset: 0x1813600 VA: 0x181815000
	private void FinalizerFailure() { }

}

public sealed class CullingGroup.StateChanged : MulticastDelegate // TypeDefIndex: 3367
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18209F0 Offset: 0x181EFF0 VA: 0x1818209F0 Slot: 12
	public virtual void Invoke(CullingGroupEvent sphere) { }

	// RVA: 0x1820970 Offset: 0x181EF70 VA: 0x181820970 Slot: 13
	public virtual IAsyncResult BeginInvoke(CullingGroupEvent sphere, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

