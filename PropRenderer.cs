public class PropRenderer : MonoBehaviour, IClientComponent // TypeDefIndex: 6623
{	public bool HideLowLods; // 0x18
	public bool HideUnskinnable; // 0x19
	public bool Outline; // 0x1A
	[HeaderAttribute] // RVA: 0xBBBA0 Offset: 0xBAFA0 VA: 0x1800BBBA0
	public Vector3 Rotation; // 0x1C
	public Vector3 PostRotation; // 0x28
	[HeaderAttribute] // RVA: 0xBBC50 Offset: 0xBB050 VA: 0x1800BBC50
	public Vector3 PositionalTweak; // 0x34
	[HeaderAttribute] // RVA: 0x71EA0 Offset: 0x712A0 VA: 0x180071EA0
	public float FieldOfView; // 0x40
	public Vector3 LookDirection; // 0x44
	public Vector3 UpDirection; // 0x50


	public void DebugAlign() { }

	public void PositionCamera(Camera cam) { }

	public void PreRender() { }

	public void PostRender() { }

	[ContextMenu] // RVA: 0xBBE10 Offset: 0xBB210 VA: 0x1800BBE10
	public void CreateIcon() { }

	[ContextMenu] // RVA: 0xBBE80 Offset: 0xBB280 VA: 0x1800BBE80
	public void CreateRender() { }

	private static float DefaultLightIntensityScale(float intensity) { }

	public void CreateScreenshot(string filename, int width, int height, int SuperSampleSize = 1, PropRenderer.LightIntensityScale lightIntensityScale) { }

	public static bool RenderScreenshot(GameObject prefab, string filename, int width, int height, int SuperSampleSize = 1) { }

	public void .ctor() { }

}

public sealed class PropRenderer.LightIntensityScale : MulticastDelegate // TypeDefIndex: 6624
{
	public void .ctor(object object, IntPtr method) { }

	public virtual float Invoke(float intensity) { }

	public virtual IAsyncResult BeginInvoke(float intensity, AsyncCallback callback, object object) { }

	public virtual float EndInvoke(IAsyncResult result) { }

}

