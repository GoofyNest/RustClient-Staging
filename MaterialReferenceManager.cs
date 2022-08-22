public class MaterialReferenceManager // TypeDefIndex: 6741
{	// Fields
	private static MaterialReferenceManager s_Instance; // 0x0
	private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
	private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
	private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x20

	// Properties
	public static MaterialReferenceManager instance { get; }

	// Methods

	// RVA: 0xC66B80 Offset: 0xC65180 VA: 0x180C66B80
	public static MaterialReferenceManager get_instance() { }

	// RVA: 0xC665A0 Offset: 0xC64BA0 VA: 0x180C665A0
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0xC66500 Offset: 0xC64B00 VA: 0x180C66500
	private void AddFontAssetInternal(TMP_FontAsset fontAsset) { }

	// RVA: 0xC666B0 Offset: 0xC64CB0 VA: 0x180C666B0
	public static void AddFontMaterial(int hashCode, Material material) { }

	// RVA: 0xC66640 Offset: 0xC64C40 VA: 0x180C66640
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	// RVA: 0xC66470 Offset: 0xC64A70 VA: 0x180C66470
	public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0xC663F0 Offset: 0xC649F0 VA: 0x180C663F0
	private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0xC66720 Offset: 0xC64D20 VA: 0x180C66720
	public bool Contains(TMP_FontAsset font) { }

	// RVA: 0xC66910 Offset: 0xC64F10 VA: 0x180C66910
	public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC66890 Offset: 0xC64E90 VA: 0x180C66890
	private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC66800 Offset: 0xC64E00 VA: 0x180C66800
	public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0xC66780 Offset: 0xC64D80 VA: 0x180C66780
	private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0xC66A20 Offset: 0xC65020 VA: 0x180C66A20
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	// RVA: 0xC669A0 Offset: 0xC64FA0 VA: 0x180C669A0
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	// RVA: 0xC66AB0 Offset: 0xC650B0 VA: 0x180C66AB0
	public void .ctor() { }

}

