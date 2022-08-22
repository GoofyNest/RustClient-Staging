internal class ReflectionMethodsCache // TypeDefIndex: 5022
{	// Fields
	public ReflectionMethodsCache.Raycast3DCallback raycast3D; // 0x10
	public ReflectionMethodsCache.RaycastAllCallback raycast3DAll; // 0x18
	public ReflectionMethodsCache.Raycast2DCallback raycast2D; // 0x20
	public ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll; // 0x28
	public ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc; // 0x30
	public ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc; // 0x38
	private static ReflectionMethodsCache s_ReflectionMethodsCache; // 0x0

	// Properties
	public static ReflectionMethodsCache Singleton { get; }

	// Methods

	// RVA: 0x171A220 Offset: 0x1718820 VA: 0x18171A220
	public void .ctor() { }

	// RVA: 0x171B130 Offset: 0x1719730 VA: 0x18171B130
	public static ReflectionMethodsCache get_Singleton() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public sealed class ReflectionMethodsCache.Raycast3DCallback : MulticastDelegate // TypeDefIndex: 5023
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17187E0 Offset: 0x1716DE0 VA: 0x1817187E0 Slot: 12
	public virtual bool Invoke(Ray r, out RaycastHit hit, float f, int i) { }

	// RVA: 0x17186D0 Offset: 0x1716CD0 VA: 0x1817186D0 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, out RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x17187A0 Offset: 0x1716DA0 VA: 0x1817187A0 Slot: 14
	public virtual bool EndInvoke(out RaycastHit hit, IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.Raycast2DCallback : MulticastDelegate // TypeDefIndex: 5024
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17182E0 Offset: 0x17168E0 VA: 0x1817182E0 Slot: 12
	public virtual RaycastHit2D Invoke(Vector2 p1, Vector2 p2, float f, int i) { }

	// RVA: 0x17181D0 Offset: 0x17167D0 VA: 0x1817181D0 Slot: 13
	public virtual IAsyncResult BeginInvoke(Vector2 p1, Vector2 p2, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x1718290 Offset: 0x1716890 VA: 0x181718290 Slot: 14
	public virtual RaycastHit2D EndInvoke(IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.RaycastAllCallback : MulticastDelegate // TypeDefIndex: 5025
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17100E0 Offset: 0x170E6E0 VA: 0x1817100E0 Slot: 12
	public virtual RaycastHit[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x1718C30 Offset: 0x1717230 VA: 0x181718C30 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual RaycastHit[] EndInvoke(IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.GetRayIntersectionAllCallback : MulticastDelegate // TypeDefIndex: 5026
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17100E0 Offset: 0x170E6E0 VA: 0x1817100E0 Slot: 12
	public virtual RaycastHit2D[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x1710030 Offset: 0x170E630 VA: 0x181710030 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual RaycastHit2D[] EndInvoke(IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback : MulticastDelegate // TypeDefIndex: 5027
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17105A0 Offset: 0x170EBA0 VA: 0x1817105A0 Slot: 12
	public virtual int Invoke(Ray r, RaycastHit2D[] results, float f, int i) { }

	// RVA: 0x17104E0 Offset: 0x170EAE0 VA: 0x1817104E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit2D[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0xB9A9D0 Offset: 0xB98FD0 VA: 0x180B9A9D0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.GetRaycastNonAllocCallback : MulticastDelegate // TypeDefIndex: 5028
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17105A0 Offset: 0x170EBA0 VA: 0x1817105A0 Slot: 12
	public virtual int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	// RVA: 0x17109F0 Offset: 0x170EFF0 VA: 0x1817109F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0xB9A9D0 Offset: 0xB98FD0 VA: 0x180B9A9D0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

