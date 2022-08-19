public class LensDirtinessRenderer : PostProcessEffectRenderer<LensDirtinessEffect> // TypeDefIndex: 10265
{	// Fields
	private int dataProperty; // 0x20
	private Shader lensDirtinessShader; // 0x28

	// Methods

	// RVA: 0x68ACB0 Offset: 0x6892B0 VA: 0x18068ACB0 Slot: 4
	public override void Init() { }

	// RVA: 0x68AD00 Offset: 0x689300 VA: 0x18068AD00 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x68B9F0 Offset: 0x689FF0 VA: 0x18068B9F0
	public void .ctor() { }

}

private enum LensDirtinessRenderer.Pass // TypeDefIndex: 10266
{	// Fields
	public int value__; // 0x0
	public const LensDirtinessRenderer.Pass Threshold = 0;
	public const LensDirtinessRenderer.Pass Kawase = 1;
	public const LensDirtinessRenderer.Pass Compose = 2;

}

