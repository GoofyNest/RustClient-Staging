public class ImageRenderController : SingletonComponent<ImageRenderController> // TypeDefIndex: 10100
{	// Fields
	public Camera Camera; // 0x18

	// Methods

	// RVA: 0x515E30 Offset: 0x514430 VA: 0x180515E30
	public void OnEnable() { }

	// RVA: 0x80DF40 Offset: 0x80C540 VA: 0x18080DF40
	private byte[] RenderImpl(int imageWidth, int imageHeight, Vector3 position, Quaternion rotation, int quality) { }

	// RVA: 0x80DE40 Offset: 0x80C440 VA: 0x18080DE40
	private static ImageRenderController GetOrCreate() { }

	// RVA: 0x80E270 Offset: 0x80C870 VA: 0x18080E270
	public static byte[] Render(int imageWidth, int imageHeight, Vector3 position, Quaternion rotation, int quality = 75) { }

	// RVA: 0x80E710 Offset: 0x80CD10 VA: 0x18080E710
	private static void SetPlayerModelVisible(BasePlayer player, bool visible) { }

	// RVA: 0x80EAB0 Offset: 0x80D0B0 VA: 0x18080EAB0
	public void .ctor() { }

}

