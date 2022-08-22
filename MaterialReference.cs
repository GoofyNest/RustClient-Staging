public struct MaterialReference // TypeDefIndex: 6742
{	// Fields
	public int index; // 0x0
	public TMP_FontAsset fontAsset; // 0x8
	public Material material; // 0x10
	public bool isDefaultMaterial; // 0x18
	public bool isFallbackMaterial; // 0x19
	public Material fallbackMaterial; // 0x20
	public float padding; // 0x28
	public int referenceCount; // 0x2C

	// Methods

	// RVA: 0x117550 Offset: 0x116950 VA: 0x180117550
	public void .ctor(int index, TMP_FontAsset fontAsset, Material material, float padding) { }

	// RVA: 0xC67570 Offset: 0xC65B70 VA: 0x180C67570
	public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset) { }

	// RVA: 0xC67360 Offset: 0xC65960 VA: 0x180C67360
	public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

	// RVA: 0xC67180 Offset: 0xC65780 VA: 0x180C67180
	public static int AddMaterialReference(Material material, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

}

