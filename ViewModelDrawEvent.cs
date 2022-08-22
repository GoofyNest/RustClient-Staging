public struct ViewModelDrawEvent : IEquatable<ViewModelDrawEvent> // TypeDefIndex: 11452
{	// Fields
	public ViewModelRenderer viewModelRenderer; // 0x0
	public Renderer renderer; // 0x8
	public bool skipDepthPrePass; // 0x10
	public Material material; // 0x18
	public int subMesh; // 0x20
	public int pass; // 0x24

	// Methods

	// RVA: 0xF88F0 Offset: 0xF7CF0 VA: 0x1800F88F0 Slot: 4
	public bool Equals(ViewModelDrawEvent other) { }

	// RVA: 0xF8930 Offset: 0xF7D30 VA: 0x1800F8930 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF89E0 Offset: 0xF7DE0 VA: 0x1800F89E0 Slot: 2
	public override int GetHashCode() { }

}

