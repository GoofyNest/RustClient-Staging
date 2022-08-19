public class SubsurfaceProfileTexture // TypeDefIndex: 10664
{	// Fields
	public const int SUBSURFACE_RADIUS_SCALE = 1024;
	public const int SUBSURFACE_KERNEL_SIZE = 3;
	private List<SubsurfaceProfileTexture.SubsurfaceProfileEntry> entries; // 0x10
	private Texture2D texture; // 0x18

	// Properties
	public Texture2D Texture { get; }

	// Methods

	// RVA: 0x7A5090 Offset: 0x7A3690 VA: 0x1807A5090
	public Texture2D get_Texture() { }

	// RVA: 0x7A4F40 Offset: 0x7A3540 VA: 0x1807A4F40
	public void .ctor() { }

	// RVA: 0x7A4A80 Offset: 0x7A3080 VA: 0x1807A4A80
	public int FindEntryIndex(SubsurfaceProfile profile) { }

	// RVA: 0x7A4060 Offset: 0x7A2660 VA: 0x1807A4060
	public int AddProfile(SubsurfaceProfileData data, SubsurfaceProfile profile) { }

	// RVA: 0x7A4E20 Offset: 0x7A3420 VA: 0x1807A4E20
	public void UpdateProfile(int id, SubsurfaceProfileData data) { }

	// RVA: 0x7A4C30 Offset: 0x7A3230 VA: 0x1807A4C30
	public void RemoveProfile(int id) { }

	// RVA: 0x7A4370 Offset: 0x7A2970 VA: 0x1807A4370
	public static Color ColorClamp(Color color, float min = 0, float max = 1) { }

	// RVA: 0x7A4450 Offset: 0x7A2A50 VA: 0x1807A4450
	private Texture2D CreateTexture() { }

	// RVA: 0x7A4270 Offset: 0x7A2870 VA: 0x1807A4270
	private void CheckReleaseTexture() { }

	// RVA: 0x7A4B80 Offset: 0x7A3180 VA: 0x1807A4B80
	private void ReleaseTexture() { }

}

private struct SubsurfaceProfileTexture.SubsurfaceProfileEntry // TypeDefIndex: 10665
{	// Fields
	public SubsurfaceProfileData data; // 0x0
	public SubsurfaceProfile profile; // 0x28

	// Methods

	// RVA: 0xF65D0 Offset: 0xF59D0 VA: 0x1800F65D0
	public void .ctor(SubsurfaceProfileData data, SubsurfaceProfile profile) { }

}

