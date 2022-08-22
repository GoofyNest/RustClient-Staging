public class LensDirtinessRenderer : PostProcessEffectRenderer<LensDirtinessEffect> // TypeDefIndex: 10265
{	// Fields
	private int dataProperty; // 0x20
	private Shader lensDirtinessShader; // 0x28

	// Methods

	// RVA: 0x68AC40 Offset: 0x689240 VA: 0x18068AC40 Slot: 4
	public override void Init() { }

	// RVA: 0x68AC90 Offset: 0x689290 VA: 0x18068AC90 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x68B980 Offset: 0x689F80 VA: 0x18068B980
	public void .ctor() { }

}

private enum LensDirtinessRenderer.Pass // TypeDefIndex: 10266
{	// Fields
	public int value__; // 0x0
	public const LensDirtinessRenderer.Pass Threshold = 0;
	public const LensDirtinessRenderer.Pass Kawase = 1;
	public const LensDirtinessRenderer.Pass Compose = 2;

}

