public static class CameraEx // TypeDefIndex: 5612
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1976DE0 Offset: 0x19753E0 VA: 0x181976DE0
	public static void FocusOnRenderer(Camera cam, GameObject obj, Vector3 lookDirection, Vector3 Up, int layerMask = -1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1977770 Offset: 0x1975D70 VA: 0x181977770
	public static void SaveScreenshot(Camera cam, string name, int width, int height, bool transparent, int SuperSampleSize, Nullable<Color> background) { }

}

public class CameraEx : MonoBehaviour // TypeDefIndex: 11202
{	// Fields
	public bool overrideAmbientLight; // 0x18
	public AmbientMode ambientMode; // 0x1C
	public Color ambientGroundColor; // 0x20
	public Color ambientEquatorColor; // 0x30
	public Color ambientLight; // 0x40
	public float ambientIntensity; // 0x50
	public ReflectionProbe reflectionProbe; // 0x58
	internal Color old_ambientLight; // 0x60
	internal Color old_ambientGroundColor; // 0x70
	internal Color old_ambientEquatorColor; // 0x80
	internal float old_ambientIntensity; // 0x90
	internal AmbientMode old_ambientMode; // 0x94
	public float aspect; // 0x98

	// Methods

	// RVA: 0x6F6B10 Offset: 0x6F5110 VA: 0x1806F6B10
	private void OnPreRender() { }

	// RVA: 0x6F6A70 Offset: 0x6F5070 VA: 0x1806F6A70
	private void OnPostRender() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

