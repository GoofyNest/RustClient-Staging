internal class ReflectionMethodsCache // TypeDefIndex: 5022
{	public ReflectionMethodsCache.Raycast3DCallback raycast3D; // 0x10
	public ReflectionMethodsCache.RaycastAllCallback raycast3DAll; // 0x18
	public ReflectionMethodsCache.Raycast2DCallback raycast2D; // 0x20
	public ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll; // 0x28
	public ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc; // 0x30
	public ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc; // 0x38
	private static ReflectionMethodsCache s_ReflectionMethodsCache; // 0x0

	public static ReflectionMethodsCache Singleton { get; }


	public void .ctor() { }

	public static ReflectionMethodsCache get_Singleton() { }

	private static void .cctor() { }

}

public sealed class ReflectionMethodsCache.Raycast3DCallback : MulticastDelegate // TypeDefIndex: 5023
{
	public void .ctor(object object, IntPtr method) { }

	public virtual bool Invoke(Ray r, out RaycastHit hit, float f, int i) { }

	public virtual IAsyncResult BeginInvoke(Ray r, out RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

	public virtual bool EndInvoke(out RaycastHit hit, IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.Raycast2DCallback : MulticastDelegate // TypeDefIndex: 5024
{
	public void .ctor(object object, IntPtr method) { }

	public virtual RaycastHit2D Invoke(Vector2 p1, Vector2 p2, float f, int i) { }

	public virtual IAsyncResult BeginInvoke(Vector2 p1, Vector2 p2, float f, int i, AsyncCallback callback, object object) { }

	public virtual RaycastHit2D EndInvoke(IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.RaycastAllCallback : MulticastDelegate // TypeDefIndex: 5025
{
	public void .ctor(object object, IntPtr method) { }

	public virtual RaycastHit[] Invoke(Ray r, float f, int i) { }

	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	public virtual RaycastHit[] EndInvoke(IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.GetRayIntersectionAllCallback : MulticastDelegate // TypeDefIndex: 5026
{
	public void .ctor(object object, IntPtr method) { }

	public virtual RaycastHit2D[] Invoke(Ray r, float f, int i) { }

	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	public virtual RaycastHit2D[] EndInvoke(IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback : MulticastDelegate // TypeDefIndex: 5027
{
	public void .ctor(object object, IntPtr method) { }

	public virtual int Invoke(Ray r, RaycastHit2D[] results, float f, int i) { }

	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit2D[] results, float f, int i, AsyncCallback callback, object object) { }

	public virtual int EndInvoke(IAsyncResult result) { }

}

public sealed class ReflectionMethodsCache.GetRaycastNonAllocCallback : MulticastDelegate // TypeDefIndex: 5028
{
	public void .ctor(object object, IntPtr method) { }

	public virtual int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

	public virtual int EndInvoke(IAsyncResult result) { }

}

