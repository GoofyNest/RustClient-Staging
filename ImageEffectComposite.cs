public class ImageEffectComposite : MonoBehaviour // TypeDefIndex: 8030
{	// Fields
	public RenderTextureFormat format; // 0x18
	public RenderTextureReadWrite readWrite; // 0x1C
	private List<ImageEffectLayer> layers; // 0x20
	private Comparison<ImageEffectLayer> layerSort; // 0x28
	private List<IImageEffect> effects; // 0x30
	private bool sorted; // 0x38

	// Methods

	// RVA: 0x106D460 Offset: 0x106BA60 VA: 0x18106D460
	public void Add(ImageEffectLayer effect) { }

	// RVA: 0x106D990 Offset: 0x106BF90 VA: 0x18106D990
	public void Remove(ImageEffectLayer effect) { }

	[ImageEffectTransformsToLDR] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x106D4C0 Offset: 0x106BAC0 VA: 0x18106D4C0
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	// RVA: 0x106D9F0 Offset: 0x106BFF0 VA: 0x18106D9F0
	public void .ctor() { }

}

private sealed class ImageEffectComposite.<>c // TypeDefIndex: 8031
{	// Fields
	public static readonly ImageEffectComposite.<>c <>9; // 0x0
	public static Comparison<ImageEffectLayer> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x107A900 Offset: 0x1078F00 VA: 0x18107A900
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x107A480 Offset: 0x1078A80 VA: 0x18107A480
	internal int <.ctor>b__9_0(ImageEffectLayer x, ImageEffectLayer y) { }

}

