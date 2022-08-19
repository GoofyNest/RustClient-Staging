public class MaterialReferenceManager // TypeDefIndex: 6741
{	// Fields
	private static MaterialReferenceManager s_Instance; // 0x0
	private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
	private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
	private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x20

	// Properties
	public static MaterialReferenceManager instance { get; }

	// Methods

	// RVA: 0xC668C0 Offset: 0xC64EC0 VA: 0x180C668C0
	public static MaterialReferenceManager get_instance() { }

	// RVA: 0xC662E0 Offset: 0xC648E0 VA: 0x180C662E0
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0xC66240 Offset: 0xC64840 VA: 0x180C66240
	private void AddFontAssetInternal(TMP_FontAsset fontAsset) { }

	// RVA: 0xC663F0 Offset: 0xC649F0 VA: 0x180C663F0
	public static void AddFontMaterial(int hashCode, Material material) { }

	// RVA: 0xC66380 Offset: 0xC64980 VA: 0x180C66380
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	// RVA: 0xC661B0 Offset: 0xC647B0 VA: 0x180C661B0
	public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0xC66130 Offset: 0xC64730 VA: 0x180C66130
	private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0xC66460 Offset: 0xC64A60 VA: 0x180C66460
	public bool Contains(TMP_FontAsset font) { }

	// RVA: 0xC66650 Offset: 0xC64C50 VA: 0x180C66650
	public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC665D0 Offset: 0xC64BD0 VA: 0x180C665D0
	private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0xC66540 Offset: 0xC64B40 VA: 0x180C66540
	public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0xC664C0 Offset: 0xC64AC0 VA: 0x180C664C0
	private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0xC66760 Offset: 0xC64D60 VA: 0x180C66760
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	// RVA: 0xC666E0 Offset: 0xC64CE0 VA: 0x180C666E0
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	// RVA: 0xC667F0 Offset: 0xC64DF0 VA: 0x180C667F0
	public void .ctor() { }

}

