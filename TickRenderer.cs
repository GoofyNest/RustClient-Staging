public class TickRenderer : MaskableGraphic // TypeDefIndex: 7073
{	// Fields
	public List<TickRenderer.Tick> Ticks; // 0xC8
	private static UIVertex[] quad; // 0x0

	// Methods

	// RVA: 0xFD4720 Offset: 0xFD2D20 VA: 0x180FD4720 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0xFD4D50 Offset: 0xFD3350 VA: 0x180FD4D50
	public void .ctor() { }

	// RVA: 0xFD4D00 Offset: 0xFD3300 VA: 0x180FD4D00
	private static void .cctor() { }

}

public struct TickRenderer.Tick // TypeDefIndex: 7074
{	// Fields
	public float Pos; // 0x0
	public Color Color; // 0x4
	public float Height; // 0x14

}

