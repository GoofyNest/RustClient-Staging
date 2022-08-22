public struct OccludeeSphere // TypeDefIndex: 11508
{	// Fields
	public int id; // 0x0
	public OccludeeState state; // 0x8
	public OcclusionCulling.Sphere sphere; // 0x10

	// Properties
	public bool IsRegistered { get; }

	// Methods

	// RVA: 0xFB160 Offset: 0xFA560 VA: 0x1800FB160
	public bool get_IsRegistered() { }

	// RVA: 0xFAFD0 Offset: 0xFA3D0 VA: 0x1800FAFD0
	public void Invalidate() { }

	// RVA: 0xFB090 Offset: 0xFA490 VA: 0x1800FB090
	public void .ctor(int id) { }

	// RVA: 0xFB000 Offset: 0xFA400 VA: 0x1800FB000
	public void .ctor(int id, OcclusionCulling.Sphere sphere) { }

}

