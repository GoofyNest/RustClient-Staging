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

	// RVA: 0xC670A0 Offset: 0xC656A0 VA: 0x180C670A0
	public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset) { }

	// RVA: 0xC66E90 Offset: 0xC65490 VA: 0x180C66E90
	public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

	// RVA: 0xC66CB0 Offset: 0xC652B0 VA: 0x180C66CB0
	public static int AddMaterialReference(Material material, MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

}

