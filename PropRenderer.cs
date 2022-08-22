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

	// RVA: 0x1BAA3B0 Offset: 0x1BA89B0 VA: 0x181BAA3B0
	public void DebugAlign() { }

	// RVA: 0x1BAA480 Offset: 0x1BA8A80 VA: 0x181BAA480
	public void PositionCamera(Camera cam) { }

	// RVA: 0x1BAAB80 Offset: 0x1BA9180 VA: 0x181BAAB80
	public void PreRender() { }

	// RVA: 0x1BAA9E0 Offset: 0x1BA8FE0 VA: 0x181BAA9E0
	public void PostRender() { }

	[ContextMenu] // RVA: 0xBBE10 Offset: 0xBB210 VA: 0x1800BBE10
	// RVA: 0x1BA94F0 Offset: 0x1BA7AF0 VA: 0x181BA94F0
	public void CreateIcon() { }

	[ContextMenu] // RVA: 0xBBE80 Offset: 0xBB280 VA: 0x1800BBE80
	// RVA: 0x1BA97F0 Offset: 0x1BA7DF0 VA: 0x181BA97F0
	public void CreateRender() { }

	// RVA: 0x1BAA410 Offset: 0x1BA8A10 VA: 0x181BAA410
	private static float DefaultLightIntensityScale(float intensity) { }

	// RVA: 0x1BA9AF0 Offset: 0x1BA80F0 VA: 0x181BA9AF0
	public void CreateScreenshot(string filename, int width, int height, int SuperSampleSize = 1, PropRenderer.LightIntensityScale lightIntensityScale) { }

	// RVA: 0x1BAAF60 Offset: 0x1BA9560 VA: 0x181BAAF60
	public static bool RenderScreenshot(GameObject prefab, string filename, int width, int height, int SuperSampleSize = 1) { }

	// RVA: 0x1BAB130 Offset: 0x1BA9730 VA: 0x181BAB130
	public void .ctor() { }

}

public sealed class PropRenderer.LightIntensityScale : MulticastDelegate // TypeDefIndex: 6624
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19FBD90 Offset: 0x19FA390 VA: 0x1819FBD90 Slot: 12
	public virtual float Invoke(float intensity) { }

	// RVA: 0x1BA33A0 Offset: 0x1BA19A0 VA: 0x181BA33A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(float intensity, AsyncCallback callback, object object) { }

	// RVA: 0x19F9080 Offset: 0x19F7680 VA: 0x1819F9080 Slot: 14
	public virtual float EndInvoke(IAsyncResult result) { }

}

