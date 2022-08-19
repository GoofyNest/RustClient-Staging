public struct ViewModelDrawEvent : IEquatable<ViewModelDrawEvent> // TypeDefIndex: 11452
{	// Fields
	public ViewModelRenderer viewModelRenderer; // 0x0
	public Renderer renderer; // 0x8
	public bool skipDepthPrePass; // 0x10
	public Material material; // 0x18
	public int subMesh; // 0x20
	public int pass; // 0x24

	// Methods

	// RVA: 0xF8970 Offset: 0xF7D70 VA: 0x1800F8970 Slot: 4
	public bool Equals(ViewModelDrawEvent other) { }

	// RVA: 0xF89B0 Offset: 0xF7DB0 VA: 0x1800F89B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF8A60 Offset: 0xF7E60 VA: 0x1800F8A60 Slot: 2
	public override int GetHashCode() { }

}

