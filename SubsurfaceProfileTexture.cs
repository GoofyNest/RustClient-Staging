public class SubsurfaceProfileTexture // TypeDefIndex: 10664
{	public const int SUBSURFACE_RADIUS_SCALE = 1024;
	public const int SUBSURFACE_KERNEL_SIZE = 3;
	private List<SubsurfaceProfileTexture.SubsurfaceProfileEntry> entries; // 0x10
	private Texture2D texture; // 0x18

	public Texture2D Texture { get; }


	public Texture2D get_Texture() { }

	public void .ctor() { }

	public int FindEntryIndex(SubsurfaceProfile profile) { }

	public int AddProfile(SubsurfaceProfileData data, SubsurfaceProfile profile) { }

	public void UpdateProfile(int id, SubsurfaceProfileData data) { }

	public void RemoveProfile(int id) { }

	public static Color ColorClamp(Color color, float min = 0, float max = 1) { }

	private Texture2D CreateTexture() { }

	private void CheckReleaseTexture() { }

	private void ReleaseTexture() { }

}

private struct SubsurfaceProfileTexture.SubsurfaceProfileEntry // TypeDefIndex: 10665
{	public SubsurfaceProfileData data; // 0x0
	public SubsurfaceProfile profile; // 0x28


	public void .ctor(SubsurfaceProfileData data, SubsurfaceProfile profile) { }

}

