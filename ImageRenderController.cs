public class ImageRenderController : SingletonComponent<ImageRenderController> // TypeDefIndex: 10100
{	// Fields
	public Camera Camera; // 0x18

	// Methods

	// RVA: 0x515E30 Offset: 0x514430 VA: 0x180515E30
	public void OnEnable() { }

	// RVA: 0x80DE30 Offset: 0x80C430 VA: 0x18080DE30
	private byte[] RenderImpl(int imageWidth, int imageHeight, Vector3 position, Quaternion rotation, int quality) { }

	// RVA: 0x80DD30 Offset: 0x80C330 VA: 0x18080DD30
	private static ImageRenderController GetOrCreate() { }

	// RVA: 0x80E160 Offset: 0x80C760 VA: 0x18080E160
	public static byte[] Render(int imageWidth, int imageHeight, Vector3 position, Quaternion rotation, int quality = 75) { }

	// RVA: 0x80E600 Offset: 0x80CC00 VA: 0x18080E600
	private static void SetPlayerModelVisible(BasePlayer player, bool visible) { }

	// RVA: 0x80E9A0 Offset: 0x80CFA0 VA: 0x18080E9A0
	public void .ctor() { }

}

