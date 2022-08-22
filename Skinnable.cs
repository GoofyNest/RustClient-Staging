public class Skinnable : ScriptableObject // TypeDefIndex: 7715
{
// Namespace: 
[CreateAssetMenuAttribute] // RVA: 0xC7170 Offset: 0xC6570 VA: 0x1800C7170
public class Skinnable : ScriptableObject // TypeDefIndex: 7715
	// Fields
	public string Name; // 0x18
	public string ItemName; // 0x20
	public GameObject EntityPrefab; // 0x28
	public string EntityPrefabName; // 0x30
	public GameObject ViewmodelPrefab; // 0x38
	public string ViewmodelPrefabName; // 0x40
	public Mesh[] MeshDownloads; // 0x48
	public string[] MeshDownloadPaths; // 0x50
	public Category Category; // 0x58
	public bool HideInWorkshopUpload; // 0x5C
	public Skinnable.Group[] Groups; // 0x60
	public static Skinnable[] All; // 0x0
	private Material[] _sourceMaterials; // 0x68

	// Properties
	public Material[] SourceMaterials { get; }

	// Methods

	// RVA: 0xE75C00 Offset: 0xE74200 VA: 0x180E75C00
	public static Skinnable FindForItem(string itemType) { }

	// RVA: 0xE75B40 Offset: 0xE74140 VA: 0x180E75B40
	public static Skinnable FindForEntity(string entityName) { }

	// RVA: 0xE75CC0 Offset: 0xE742C0 VA: 0x180E75CC0
	public Material[] get_SourceMaterials() { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class Skinnable.Group // TypeDefIndex: 7716
{	// Fields
	public string Name; // 0x10
	public Material Material; // 0x18
	public int MaxTextureSize; // 0x20

	// Methods

	// RVA: 0xE738B0 Offset: 0xE71EB0 VA: 0x180E738B0
	public void .ctor() { }

}

private sealed class Skinnable.<>c__DisplayClass13_0 // TypeDefIndex: 7717
{	// Fields
	public string itemType; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE80A20 Offset: 0xE7F020 VA: 0x180E80A20
	internal bool <FindForItem>b__0(Skinnable x) { }

}

private sealed class Skinnable.<>c__DisplayClass14_0 // TypeDefIndex: 7718
{	// Fields
	public string entityName; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE80A90 Offset: 0xE7F090 VA: 0x180E80A90
	internal bool <FindForEntity>b__0(Skinnable x) { }

}

