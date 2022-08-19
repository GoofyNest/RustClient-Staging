public class ImageEffectComposite : MonoBehaviour // TypeDefIndex: 8030
{	// Fields
	public RenderTextureFormat format; // 0x18
	public RenderTextureReadWrite readWrite; // 0x1C
	private List<ImageEffectLayer> layers; // 0x20
	private Comparison<ImageEffectLayer> layerSort; // 0x28
	private List<IImageEffect> effects; // 0x30
	private bool sorted; // 0x38

	// Methods

	// RVA: 0x106D1A0 Offset: 0x106B7A0 VA: 0x18106D1A0
	public void Add(ImageEffectLayer effect) { }

	// RVA: 0x106D6D0 Offset: 0x106BCD0 VA: 0x18106D6D0
	public void Remove(ImageEffectLayer effect) { }

	[ImageEffectTransformsToLDR] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x106D200 Offset: 0x106B800 VA: 0x18106D200
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	// RVA: 0x106D730 Offset: 0x106BD30 VA: 0x18106D730
	public void .ctor() { }

}

private sealed class ImageEffectComposite.<>c // TypeDefIndex: 8031
{	// Fields
	public static readonly ImageEffectComposite.<>c <>9; // 0x0
	public static Comparison<ImageEffectLayer> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x107A640 Offset: 0x1078C40 VA: 0x18107A640
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x107A1C0 Offset: 0x10787C0 VA: 0x18107A1C0
	internal int <.ctor>b__9_0(ImageEffectLayer x, ImageEffectLayer y) { }

}

