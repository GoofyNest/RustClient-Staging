public class MeshRendererLookup // TypeDefIndex: 9167
{	// Fields
	public MeshRendererLookup.LookupGroup src; // 0x10
	public MeshRendererLookup.LookupGroup dst; // 0x18

	// Methods

	// RVA: 0x969A40 Offset: 0x968040 VA: 0x180969A40
	public void Apply() { }

	// RVA: 0x969AC0 Offset: 0x9680C0 VA: 0x180969AC0
	public void Clear() { }

	// RVA: 0x9699B0 Offset: 0x967FB0 VA: 0x1809699B0
	public void Add(MeshRendererInstance instance) { }

	// RVA: 0x969B10 Offset: 0x968110 VA: 0x180969B10
	public MeshRendererLookup.LookupEntry Get(int index) { }

	// RVA: 0x969B70 Offset: 0x968170 VA: 0x180969B70
	public void .ctor() { }

}

public class MeshRendererLookup.LookupGroup // TypeDefIndex: 9168
{	// Fields
	public List<MeshRendererLookup.LookupEntry> data; // 0x10

	// Methods

	// RVA: 0x957EB0 Offset: 0x9564B0 VA: 0x180957EB0
	public void Clear() { }

	// RVA: 0x957DD0 Offset: 0x9563D0 VA: 0x180957DD0
	public void Add(MeshRendererInstance instance) { }

	// RVA: 0x957F00 Offset: 0x956500 VA: 0x180957F00
	public MeshRendererLookup.LookupEntry Get(int index) { }

	// RVA: 0x958040 Offset: 0x956640 VA: 0x180958040
	public void .ctor() { }

}

public struct MeshRendererLookup.LookupEntry // TypeDefIndex: 9169
{	// Fields
	public Renderer renderer; // 0x0

	// Methods

	// RVA: 0xFA8E0 Offset: 0xF9CE0 VA: 0x1800FA8E0
	public void .ctor(MeshRendererInstance instance) { }

}

