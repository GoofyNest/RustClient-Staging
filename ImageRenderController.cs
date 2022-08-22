public class ImageRenderController : SingletonComponent<ImageRenderController> // TypeDefIndex: 10100
{	// Fields
	public Camera Camera; // 0x18

	// Methods

	// RVA: 0x515DC0 Offset: 0x5143C0 VA: 0x180515DC0
	public void OnEnable() { }

	// RVA: 0x80E4D0 Offset: 0x80CAD0 VA: 0x18080E4D0
	private byte[] RenderImpl(int imageWidth, int imageHeight, Vector3 position, Quaternion rotation, int quality) { }

	// RVA: 0x80E3D0 Offset: 0x80C9D0 VA: 0x18080E3D0
	private static ImageRenderController GetOrCreate() { }

	// RVA: 0x80E800 Offset: 0x80CE00 VA: 0x18080E800
	public static byte[] Render(int imageWidth, int imageHeight, Vector3 position, Quaternion rotation, int quality = 75) { }

	// RVA: 0x80ECA0 Offset: 0x80D2A0 VA: 0x18080ECA0
	private static void SetPlayerModelVisible(BasePlayer player, bool visible) { }

	// RVA: 0x80F040 Offset: 0x80D640 VA: 0x18080F040
	public void .ctor() { }

}

