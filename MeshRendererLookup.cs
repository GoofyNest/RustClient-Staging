public class MeshRendererLookup // TypeDefIndex: 9167
{	// Fields
	public MeshRendererLookup.LookupGroup src; // 0x10
	public MeshRendererLookup.LookupGroup dst; // 0x18

	// Methods

	// RVA: 0x969B50 Offset: 0x968150 VA: 0x180969B50
	public void Apply() { }

	// RVA: 0x969BD0 Offset: 0x9681D0 VA: 0x180969BD0
	public void Clear() { }

	// RVA: 0x969AC0 Offset: 0x9680C0 VA: 0x180969AC0
	public void Add(MeshRendererInstance instance) { }

	// RVA: 0x969C20 Offset: 0x968220 VA: 0x180969C20
	public MeshRendererLookup.LookupEntry Get(int index) { }

	// RVA: 0x969C80 Offset: 0x968280 VA: 0x180969C80
	public void .ctor() { }

}

public class MeshRendererLookup.LookupGroup // TypeDefIndex: 9168
{	// Fields
	public List<MeshRendererLookup.LookupEntry> data; // 0x10

	// Methods

	// RVA: 0x957FC0 Offset: 0x9565C0 VA: 0x180957FC0
	public void Clear() { }

	// RVA: 0x957EE0 Offset: 0x9564E0 VA: 0x180957EE0
	public void Add(MeshRendererInstance instance) { }

	// RVA: 0x958010 Offset: 0x956610 VA: 0x180958010
	public MeshRendererLookup.LookupEntry Get(int index) { }

	// RVA: 0x958150 Offset: 0x956750 VA: 0x180958150
	public void .ctor() { }

}

public struct MeshRendererLookup.LookupEntry // TypeDefIndex: 9169
{	// Fields
	public Renderer renderer; // 0x0

	// Methods

	// RVA: 0xFA8E0 Offset: 0xF9CE0 VA: 0x1800FA8E0
	public void .ctor(MeshRendererInstance instance) { }

}

