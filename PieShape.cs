public class PieShape : Graphic // TypeDefIndex: 11201
{	// Fields
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float outerSize; // 0x90
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float innerSize; // 0x94
	public float startRadius; // 0x98
	public float endRadius; // 0x9C
	public float border; // 0xA0
	public bool debugDrawing; // 0xA4

	// Methods

	// RVA: 0x90D5E0 Offset: 0x90BBE0 VA: 0x18090D5E0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vbo) { }

	// RVA: 0x90DD70 Offset: 0x90C370 VA: 0x18090DD70
	public void .ctor() { }

}

