public class TickRenderer : MaskableGraphic // TypeDefIndex: 7073
{	// Fields
	public List<TickRenderer.Tick> Ticks; // 0xC8
	private static UIVertex[] quad; // 0x0

	// Methods

	// RVA: 0xFD4460 Offset: 0xFD2A60 VA: 0x180FD4460 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0xFD4A90 Offset: 0xFD3090 VA: 0x180FD4A90
	public void .ctor() { }

	// RVA: 0xFD4A40 Offset: 0xFD3040 VA: 0x180FD4A40
	private static void .cctor() { }

}

public struct TickRenderer.Tick // TypeDefIndex: 7074
{	// Fields
	public float Pos; // 0x0
	public Color Color; // 0x4
	public float Height; // 0x14

}

