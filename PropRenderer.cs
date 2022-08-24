public class PropRenderer : MonoBehaviour, IClientComponent // TypeDefIndex: 6623
{	public bool HideLowLods; // 0x18
	public bool HideUnskinnable; // 0x19
	public bool Outline; // 0x1A
	[HeaderAttribute] // RVA: 0xBBCF0 Offset: 0xBB0F0 VA: 0x1800BBCF0
	public Vector3 Rotation; // 0x1C
	public Vector3 PostRotation; // 0x28
	[HeaderAttribute] // RVA: 0xBBDA0 Offset: 0xBB1A0 VA: 0x1800BBDA0
	public Vector3 PositionalTweak; // 0x34
	[HeaderAttribute] // RVA: 0x71F60 Offset: 0x71360 VA: 0x180071F60
	public float FieldOfView; // 0x40
	public Vector3 LookDirection; // 0x44
	public Vector3 UpDirection; // 0x50


	public void DebugAlign() { }

	public void PositionCamera(Camera cam) { }

	public void PreRender() { }

	public void PostRender() { }

	[ContextMenu] // RVA: 0xBBF60 Offset: 0xBB360 VA: 0x1800BBF60
	public void CreateIcon() { }

	[ContextMenu] // RVA: 0xBBFD0 Offset: 0xBB3D0 VA: 0x1800BBFD0
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

