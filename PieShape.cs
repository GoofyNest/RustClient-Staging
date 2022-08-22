public class PieShape : Graphic // TypeDefIndex: 11201
{	// Fields
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float outerSize; // 0x90
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float innerSize; // 0x94
	public float startRadius; // 0x98
	public float endRadius; // 0x9C
	public float border; // 0xA0
	public bool debugDrawing; // 0xA4

	// Methods

	// RVA: 0x90DC00 Offset: 0x90C200 VA: 0x18090DC00 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vbo) { }

	// RVA: 0x90E390 Offset: 0x90C990 VA: 0x18090E390
	public void .ctor() { }

}

