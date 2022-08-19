public struct OccludeeSphere // TypeDefIndex: 11508
{	// Fields
	public int id; // 0x0
	public OccludeeState state; // 0x8
	public OcclusionCulling.Sphere sphere; // 0x10

	// Properties
	public bool IsRegistered { get; }

	// Methods

	// RVA: 0xFB1E0 Offset: 0xFA5E0 VA: 0x1800FB1E0
	public bool get_IsRegistered() { }

	// RVA: 0xFB050 Offset: 0xFA450 VA: 0x1800FB050
	public void Invalidate() { }

	// RVA: 0xFB110 Offset: 0xFA510 VA: 0x1800FB110
	public void .ctor(int id) { }

	// RVA: 0xFB080 Offset: 0xFA480 VA: 0x1800FB080
	public void .ctor(int id, OcclusionCulling.Sphere sphere) { }

}

