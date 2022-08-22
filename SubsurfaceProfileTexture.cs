public class SubsurfaceProfileTexture // TypeDefIndex: 10664
{	// Fields
	public const int SUBSURFACE_RADIUS_SCALE = 1024;
	public const int SUBSURFACE_KERNEL_SIZE = 3;
	private List<SubsurfaceProfileTexture.SubsurfaceProfileEntry> entries; // 0x10
	private Texture2D texture; // 0x18

	// Properties
	public Texture2D Texture { get; }

	// Methods

	// RVA: 0x7A51A0 Offset: 0x7A37A0 VA: 0x1807A51A0
	public Texture2D get_Texture() { }

	// RVA: 0x7A5050 Offset: 0x7A3650 VA: 0x1807A5050
	public void .ctor() { }

	// RVA: 0x7A4B90 Offset: 0x7A3190 VA: 0x1807A4B90
	public int FindEntryIndex(SubsurfaceProfile profile) { }

	// RVA: 0x7A4170 Offset: 0x7A2770 VA: 0x1807A4170
	public int AddProfile(SubsurfaceProfileData data, SubsurfaceProfile profile) { }

	// RVA: 0x7A4F30 Offset: 0x7A3530 VA: 0x1807A4F30
	public void UpdateProfile(int id, SubsurfaceProfileData data) { }

	// RVA: 0x7A4D40 Offset: 0x7A3340 VA: 0x1807A4D40
	public void RemoveProfile(int id) { }

	// RVA: 0x7A4480 Offset: 0x7A2A80 VA: 0x1807A4480
	public static Color ColorClamp(Color color, float min = 0, float max = 1) { }

	// RVA: 0x7A4560 Offset: 0x7A2B60 VA: 0x1807A4560
	private Texture2D CreateTexture() { }

	// RVA: 0x7A4380 Offset: 0x7A2980 VA: 0x1807A4380
	private void CheckReleaseTexture() { }

	// RVA: 0x7A4C90 Offset: 0x7A3290 VA: 0x1807A4C90
	private void ReleaseTexture() { }

}

private struct SubsurfaceProfileTexture.SubsurfaceProfileEntry // TypeDefIndex: 10665
{	// Fields
	public SubsurfaceProfileData data; // 0x0
	public SubsurfaceProfile profile; // 0x28

	// Methods

	// RVA: 0xF6550 Offset: 0xF5950 VA: 0x1800F6550
	public void .ctor(SubsurfaceProfileData data, SubsurfaceProfile profile) { }

}

