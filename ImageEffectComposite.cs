public class ImageEffectComposite : MonoBehaviour // TypeDefIndex: 8030
{	// Fields
	public RenderTextureFormat format; // 0x18
	public RenderTextureReadWrite readWrite; // 0x1C
	private List<ImageEffectLayer> layers; // 0x20
	private Comparison<ImageEffectLayer> layerSort; // 0x28
	private List<IImageEffect> effects; // 0x30
	private bool sorted; // 0x38

	// Methods

	// RVA: 0x106DED0 Offset: 0x106C4D0 VA: 0x18106DED0
	public void Add(ImageEffectLayer effect) { }

	// RVA: 0x106E400 Offset: 0x106CA00 VA: 0x18106E400
	public void Remove(ImageEffectLayer effect) { }

	[ImageEffectTransformsToLDR] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x106DF30 Offset: 0x106C530 VA: 0x18106DF30
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	// RVA: 0x106E460 Offset: 0x106CA60 VA: 0x18106E460
	public void .ctor() { }

}

private sealed class ImageEffectComposite.<>c // TypeDefIndex: 8031
{	// Fields
	public static readonly ImageEffectComposite.<>c <>9; // 0x0
	public static Comparison<ImageEffectLayer> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x107B370 Offset: 0x1079970 VA: 0x18107B370
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x107AEF0 Offset: 0x10794F0 VA: 0x18107AEF0
	internal int <.ctor>b__9_0(ImageEffectLayer x, ImageEffectLayer y) { }

}

