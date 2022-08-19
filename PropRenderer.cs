public class PropRenderer : MonoBehaviour, IClientComponent // TypeDefIndex: 6623
{	// Fields
	public bool HideLowLods; // 0x18
	public bool HideUnskinnable; // 0x19
	public bool Outline; // 0x1A
	[HeaderAttribute] // RVA: 0xBBB10 Offset: 0xBAF10 VA: 0x1800BBB10
	public Vector3 Rotation; // 0x1C
	public Vector3 PostRotation; // 0x28
	[HeaderAttribute] // RVA: 0xBBBC0 Offset: 0xBAFC0 VA: 0x1800BBBC0
	public Vector3 PositionalTweak; // 0x34
	[HeaderAttribute] // RVA: 0x71E00 Offset: 0x71200 VA: 0x180071E00
	public float FieldOfView; // 0x40
	public Vector3 LookDirection; // 0x44
	public Vector3 UpDirection; // 0x50

	// Methods

	// RVA: 0x1BAA570 Offset: 0x1BA8B70 VA: 0x181BAA570
	public void DebugAlign() { }

	// RVA: 0x1BAA640 Offset: 0x1BA8C40 VA: 0x181BAA640
	public void PositionCamera(Camera cam) { }

	// RVA: 0x1BAAD40 Offset: 0x1BA9340 VA: 0x181BAAD40
	public void PreRender() { }

	// RVA: 0x1BAABA0 Offset: 0x1BA91A0 VA: 0x181BAABA0
	public void PostRender() { }

	[ContextMenu] // RVA: 0xBBD60 Offset: 0xBB160 VA: 0x1800BBD60
	// RVA: 0x1BA96B0 Offset: 0x1BA7CB0 VA: 0x181BA96B0
	public void CreateIcon() { }

	[ContextMenu] // RVA: 0xBBDD0 Offset: 0xBB1D0 VA: 0x1800BBDD0
	// RVA: 0x1BA99B0 Offset: 0x1BA7FB0 VA: 0x181BA99B0
	public void CreateRender() { }

	// RVA: 0x1BAA5D0 Offset: 0x1BA8BD0 VA: 0x181BAA5D0
	private static float DefaultLightIntensityScale(float intensity) { }

	// RVA: 0x1BA9CB0 Offset: 0x1BA82B0 VA: 0x181BA9CB0
	public void CreateScreenshot(string filename, int width, int height, int SuperSampleSize = 1, PropRenderer.LightIntensityScale lightIntensityScale) { }

	// RVA: 0x1BAB120 Offset: 0x1BA9720 VA: 0x181BAB120
	public static bool RenderScreenshot(GameObject prefab, string filename, int width, int height, int SuperSampleSize = 1) { }

	// RVA: 0x1BAB2F0 Offset: 0x1BA98F0 VA: 0x181BAB2F0
	public void .ctor() { }

}

public sealed class PropRenderer.LightIntensityScale : MulticastDelegate // TypeDefIndex: 6624
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19FBDD0 Offset: 0x19FA3D0 VA: 0x1819FBDD0 Slot: 12
	public virtual float Invoke(float intensity) { }

	// RVA: 0x1BA3560 Offset: 0x1BA1B60 VA: 0x181BA3560 Slot: 13
	public virtual IAsyncResult BeginInvoke(float intensity, AsyncCallback callback, object object) { }

	// RVA: 0x19F90C0 Offset: 0x19F76C0 VA: 0x1819F90C0 Slot: 14
	public virtual float EndInvoke(IAsyncResult result) { }

}

