public class LensDirtinessRenderer : PostProcessEffectRenderer<LensDirtinessEffect> // TypeDefIndex: 12016
{
	private int dataProperty; 
	private Shader lensDirtinessShader; 


	public override void Init() { }

	public override void Render(PostProcessRenderContext context) { }

	public void .ctor() { }

}

private enum LensDirtinessRenderer.Pass // TypeDefIndex: 12017
{
	public int value__; 
	public const LensDirtinessRenderer.Pass Threshold = 0;
	public const LensDirtinessRenderer.Pass Kawase = 1;
	public const LensDirtinessRenderer.Pass Compose = 2;

}

