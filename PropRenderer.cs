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

	// RVA: 0x1BAAE60 Offset: 0x1BA9460 VA: 0x181BAAE60
	public void DebugAlign() { }

	// RVA: 0x1BAAF30 Offset: 0x1BA9530 VA: 0x181BAAF30
	public void PositionCamera(Camera cam) { }

	// RVA: 0x1BAB630 Offset: 0x1BA9C30 VA: 0x181BAB630
	public void PreRender() { }

	// RVA: 0x1BAB490 Offset: 0x1BA9A90 VA: 0x181BAB490
	public void PostRender() { }

	[ContextMenu] // RVA: 0xBBE10 Offset: 0xBB210 VA: 0x1800BBE10
	// RVA: 0x1BA9FA0 Offset: 0x1BA85A0 VA: 0x181BA9FA0
	public void CreateIcon() { }

	[ContextMenu] // RVA: 0xBBE80 Offset: 0xBB280 VA: 0x1800BBE80
	// RVA: 0x1BAA2A0 Offset: 0x1BA88A0 VA: 0x181BAA2A0
	public void CreateRender() { }

	// RVA: 0x1BAAEC0 Offset: 0x1BA94C0 VA: 0x181BAAEC0
	private static float DefaultLightIntensityScale(float intensity) { }

	// RVA: 0x1BAA5A0 Offset: 0x1BA8BA0 VA: 0x181BAA5A0
	public void CreateScreenshot(string filename, int width, int height, int SuperSampleSize = 1, PropRenderer.LightIntensityScale lightIntensityScale) { }

	// RVA: 0x1BABA10 Offset: 0x1BAA010 VA: 0x181BABA10
	public static bool RenderScreenshot(GameObject prefab, string filename, int width, int height, int SuperSampleSize = 1) { }

	// RVA: 0x1BABBE0 Offset: 0x1BAA1E0 VA: 0x181BABBE0
	public void .ctor() { }

}

public sealed class PropRenderer.LightIntensityScale : MulticastDelegate // TypeDefIndex: 6624
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19E9450 Offset: 0x19E7A50 VA: 0x1819E9450 Slot: 12
	public virtual float Invoke(float intensity) { }

	// RVA: 0x1BA3E50 Offset: 0x1BA2450 VA: 0x181BA3E50 Slot: 13
	public virtual IAsyncResult BeginInvoke(float intensity, AsyncCallback callback, object object) { }

	// RVA: 0x19E6740 Offset: 0x19E4D40 VA: 0x1819E6740 Slot: 14
	public virtual float EndInvoke(IAsyncResult result) { }

}

