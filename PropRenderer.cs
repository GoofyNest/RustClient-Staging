public class PropRenderer : MonoBehaviour, IClientComponent // TypeDefIndex: 6623
{	// Fields
	public bool HideLowLods; // 0x18
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

	// Methods

	// RVA: 0x1BAA670 Offset: 0x1BA8C70 VA: 0x181BAA670
	public void DebugAlign() { }

	// RVA: 0x1BAA740 Offset: 0x1BA8D40 VA: 0x181BAA740
	public void PositionCamera(Camera cam) { }

	// RVA: 0x1BAAE40 Offset: 0x1BA9440 VA: 0x181BAAE40
	public void PreRender() { }

	// RVA: 0x1BAACA0 Offset: 0x1BA92A0 VA: 0x181BAACA0
	public void PostRender() { }

	[ContextMenu] // RVA: 0xBBE10 Offset: 0xBB210 VA: 0x1800BBE10
	// RVA: 0x1BA97B0 Offset: 0x1BA7DB0 VA: 0x181BA97B0
	public void CreateIcon() { }

	[ContextMenu] // RVA: 0xBBE80 Offset: 0xBB280 VA: 0x1800BBE80
	// RVA: 0x1BA9AB0 Offset: 0x1BA80B0 VA: 0x181BA9AB0
	public void CreateRender() { }

	// RVA: 0x1BAA6D0 Offset: 0x1BA8CD0 VA: 0x181BAA6D0
	private static float DefaultLightIntensityScale(float intensity) { }

	// RVA: 0x1BA9DB0 Offset: 0x1BA83B0 VA: 0x181BA9DB0
	public void CreateScreenshot(string filename, int width, int height, int SuperSampleSize = 1, PropRenderer.LightIntensityScale lightIntensityScale) { }

	// RVA: 0x1BAB220 Offset: 0x1BA9820 VA: 0x181BAB220
	public static bool RenderScreenshot(GameObject prefab, string filename, int width, int height, int SuperSampleSize = 1) { }

	// RVA: 0x1BAB3F0 Offset: 0x1BA99F0 VA: 0x181BAB3F0
	public void .ctor() { }

}

public sealed class PropRenderer.LightIntensityScale : MulticastDelegate // TypeDefIndex: 6624
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19FC050 Offset: 0x19FA650 VA: 0x1819FC050 Slot: 12
	public virtual float Invoke(float intensity) { }

	// RVA: 0x1BA3660 Offset: 0x1BA1C60 VA: 0x181BA3660 Slot: 13
	public virtual IAsyncResult BeginInvoke(float intensity, AsyncCallback callback, object object) { }

	// RVA: 0x19F9340 Offset: 0x19F7940 VA: 0x1819F9340 Slot: 14
	public virtual float EndInvoke(IAsyncResult result) { }

}

