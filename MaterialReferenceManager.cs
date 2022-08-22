public class MaterialReferenceManager // TypeDefIndex: 6741
{	// Fields
	private static MaterialReferenceManager s_Instance; // 0x0
	private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
	private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
	private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x20

	// Properties
	public static MaterialReferenceManager instance { get; }

	// Methods

	// RVA: 0xC67050 Offset: 0xC65650 VA: 0x180C67050
	public static MaterialReferenceManager get_instance() { }

	// RVA: 0xC66A70 Offset: 0xC65070 VA: 0x180C66A70
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0xC669D0 Offset: 0xC64FD0 VA: 0x180C669D0
	private void AddFontAssetInternal(TMP_FontAsset fontAsset) { }

	// RVA: 0xC66B80 Offset: 0xC65180 VA: 0x180C66B80
	public static void AddFontMaterial(int hashCode, Material material) { }

	// RVA: 0xC66B10 Offset: 0xC65110 VA: 0x180C66B10
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	// RVA: 0xC66940 Offset: 0xC64F40 VA: 0x180C66940
	public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0xC668C0 Offset: 0xC64EC0 VA: 0x180C668C0
	private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0xC66BF0 Offset: 0xC651F0 VA: 0x180C66BF0
	public bool Contains(TMP_FontAsset font) { }

	// RVA: 0xC66DE0 Offset: 0xC653E0 VA: 0x180C66DE0
	public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC66D60 Offset: 0xC65360 VA: 0x180C66D60
	private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC66CD0 Offset: 0xC652D0 VA: 0x180C66CD0
	public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0xC66C50 Offset: 0xC65250 VA: 0x180C66C50
	private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0xC66EF0 Offset: 0xC654F0 VA: 0x180C66EF0
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	// RVA: 0xC66E70 Offset: 0xC65470 VA: 0x180C66E70
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	// RVA: 0xC66F80 Offset: 0xC65580 VA: 0x180C66F80
	public void .ctor() { }

}

