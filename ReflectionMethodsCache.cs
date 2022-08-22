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

	// RVA: 0x1713670 Offset: 0x1711C70 VA: 0x181713670
	public void .ctor() { }

	// RVA: 0x1714580 Offset: 0x1712B80 VA: 0x181714580
	public static ReflectionMethodsCache get_Singleton() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public sealed class ReflectionMethodsCache.Raycast3DCallback : MulticastDelegate // TypeDefIndex: 5023
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1711C30 Offset: 0x1710230 VA: 0x181711C30 Slot: 12
	public virtual bool Invoke(Ray r, out RaycastHit hit, float f, int i) { }

	// RVA: 0x1711B20 Offset: 0x1710120 VA: 0x181711B20 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, out RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x1711BF0 Offset: 0x17101F0 VA: 0x181711BF0 Slot: 14
	public virtual bool EndInvoke(out RaycastHit hit, IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.Raycast2DCallback : MulticastDelegate // TypeDefIndex: 5024
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1711730 Offset: 0x170FD30 VA: 0x181711730 Slot: 12
	public virtual RaycastHit2D Invoke(Vector2 p1, Vector2 p2, float f, int i) { }

	// RVA: 0x1711620 Offset: 0x170FC20 VA: 0x181711620 Slot: 13
	public virtual IAsyncResult BeginInvoke(Vector2 p1, Vector2 p2, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x17116E0 Offset: 0x170FCE0 VA: 0x1817116E0 Slot: 14
	public virtual RaycastHit2D EndInvoke(IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.RaycastAllCallback : MulticastDelegate // TypeDefIndex: 5025
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1709530 Offset: 0x1707B30 VA: 0x181709530 Slot: 12
	public virtual RaycastHit[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x1712080 Offset: 0x1710680 VA: 0x181712080 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual RaycastHit[] EndInvoke(IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.GetRayIntersectionAllCallback : MulticastDelegate // TypeDefIndex: 5026
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1709530 Offset: 0x1707B30 VA: 0x181709530 Slot: 12
	public virtual RaycastHit2D[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x1709480 Offset: 0x1707A80 VA: 0x181709480 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual RaycastHit2D[] EndInvoke(IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback : MulticastDelegate // TypeDefIndex: 5027
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17099F0 Offset: 0x1707FF0 VA: 0x1817099F0 Slot: 12
	public virtual int Invoke(Ray r, RaycastHit2D[] results, float f, int i) { }

	// RVA: 0x1709930 Offset: 0x1707F30 VA: 0x181709930 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit2D[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.GetRaycastNonAllocCallback : MulticastDelegate // TypeDefIndex: 5028
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17099F0 Offset: 0x1707FF0 VA: 0x1817099F0 Slot: 12
	public virtual int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	// RVA: 0x1709E40 Offset: 0x1708440 VA: 0x181709E40 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

