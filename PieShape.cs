public class PieShape : Graphic // TypeDefIndex: 11205
{	[RangeAttribute] // RVA: 0x717B0 Offset: 0x70BB0 VA: 0x1800717B0
	public float outerSize; // 0x90
	[RangeAttribute] // RVA: 0x717B0 Offset: 0x70BB0 VA: 0x1800717B0
	public float innerSize; // 0x94
	public float startRadius; // 0x98
	public float endRadius; // 0x9C
	public float border; // 0xA0
	public bool debugDrawing; // 0xA4


	protected override void OnPopulateMesh(VertexHelper vbo) { }

	public void .ctor() { }

}

