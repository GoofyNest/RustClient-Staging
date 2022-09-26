public class TickRenderer : MaskableGraphic // TypeDefIndex: 7107
{
	public List<TickRenderer.Tick> Ticks; 
	private static UIVertex[] quad; 


	protected override void OnPopulateMesh(VertexHelper vh) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct TickRenderer.Tick // TypeDefIndex: 7108
{
	public float Pos; 
	public Color Color; 
	public float Height; 

}

