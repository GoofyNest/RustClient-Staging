public class MeshRendererLookup // TypeDefIndex: 9167
{	// Fields
	public MeshRendererLookup.LookupGroup src; // 0x10
	public MeshRendererLookup.LookupGroup dst; // 0x18

	// Methods

	// RVA: 0x96A050 Offset: 0x968650 VA: 0x18096A050
	public void Apply() { }

	// RVA: 0x96A0D0 Offset: 0x9686D0 VA: 0x18096A0D0
	public void Clear() { }

	// RVA: 0x969FC0 Offset: 0x9685C0 VA: 0x180969FC0
	public void Add(MeshRendererInstance instance) { }

	// RVA: 0x96A120 Offset: 0x968720 VA: 0x18096A120
	public MeshRendererLookup.LookupEntry Get(int index) { }

	// RVA: 0x96A180 Offset: 0x968780 VA: 0x18096A180
	public void .ctor() { }

}

public class MeshRendererLookup.LookupGroup // TypeDefIndex: 9168
{	// Fields
	public List<MeshRendererLookup.LookupEntry> data; // 0x10

	// Methods

	// RVA: 0x9584C0 Offset: 0x956AC0 VA: 0x1809584C0
	public void Clear() { }

	// RVA: 0x9583E0 Offset: 0x9569E0 VA: 0x1809583E0
	public void Add(MeshRendererInstance instance) { }

	// RVA: 0x958510 Offset: 0x956B10 VA: 0x180958510
	public MeshRendererLookup.LookupEntry Get(int index) { }

	// RVA: 0x958650 Offset: 0x956C50 VA: 0x180958650
	public void .ctor() { }

}

public struct MeshRendererLookup.LookupEntry // TypeDefIndex: 9169
{	// Fields
	public Renderer renderer; // 0x0

	// Methods

	// RVA: 0xFA8E0 Offset: 0xF9CE0 VA: 0x1800FA8E0
	public void .ctor(MeshRendererInstance instance) { }

}

