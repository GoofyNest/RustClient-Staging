public class SubsurfaceProfileTexture // TypeDefIndex: 10664
{	// Fields
	public const int SUBSURFACE_RADIUS_SCALE = 1024;
	public const int SUBSURFACE_KERNEL_SIZE = 3;
	private List<SubsurfaceProfileTexture.SubsurfaceProfileEntry> entries; // 0x10
	private Texture2D texture; // 0x18

	// Properties
	public Texture2D Texture { get; }

	// Methods

	// RVA: 0x7C35A0 Offset: 0x7C1BA0 VA: 0x1807C35A0
	public Texture2D get_Texture() { }

	// RVA: 0x7C3450 Offset: 0x7C1A50 VA: 0x1807C3450
	public void .ctor() { }

	// RVA: 0x7C2F90 Offset: 0x7C1590 VA: 0x1807C2F90
	public int FindEntryIndex(SubsurfaceProfile profile) { }

	// RVA: 0x7C2570 Offset: 0x7C0B70 VA: 0x1807C2570
	public int AddProfile(SubsurfaceProfileData data, SubsurfaceProfile profile) { }

	// RVA: 0x7C3330 Offset: 0x7C1930 VA: 0x1807C3330
	public void UpdateProfile(int id, SubsurfaceProfileData data) { }

	// RVA: 0x7C3140 Offset: 0x7C1740 VA: 0x1807C3140
	public void RemoveProfile(int id) { }

	// RVA: 0x7C2880 Offset: 0x7C0E80 VA: 0x1807C2880
	public static Color ColorClamp(Color color, float min = 0, float max = 1) { }

	// RVA: 0x7C2960 Offset: 0x7C0F60 VA: 0x1807C2960
	private Texture2D CreateTexture() { }

	// RVA: 0x7C2780 Offset: 0x7C0D80 VA: 0x1807C2780
	private void CheckReleaseTexture() { }

	// RVA: 0x7C3090 Offset: 0x7C1690 VA: 0x1807C3090
	private void ReleaseTexture() { }

}

private struct SubsurfaceProfileTexture.SubsurfaceProfileEntry // TypeDefIndex: 10665
{	// Fields
	public SubsurfaceProfileData data; // 0x0
	public SubsurfaceProfile profile; // 0x28

	// Methods

	// RVA: 0xF68B0 Offset: 0xF5CB0 VA: 0x1800F68B0
	public void .ctor(SubsurfaceProfileData data, SubsurfaceProfile profile) { }

}

