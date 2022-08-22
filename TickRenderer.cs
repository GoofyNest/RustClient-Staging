public class TickRenderer : MaskableGraphic // TypeDefIndex: 7073
{	// Fields
	public List<TickRenderer.Tick> Ticks; // 0xC8
	private static UIVertex[] quad; // 0x0

	// Methods

	// RVA: 0xFD51C0 Offset: 0xFD37C0 VA: 0x180FD51C0 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0xFD57F0 Offset: 0xFD3DF0 VA: 0x180FD57F0
	public void .ctor() { }

	// RVA: 0xFD57A0 Offset: 0xFD3DA0 VA: 0x180FD57A0
	private static void .cctor() { }

}

public struct TickRenderer.Tick // TypeDefIndex: 7074
{	// Fields
	public float Pos; // 0x0
	public Color Color; // 0x4
	public float Height; // 0x14

}

