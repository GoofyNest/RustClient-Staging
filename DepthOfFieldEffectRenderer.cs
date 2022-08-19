public class DepthOfFieldEffectRenderer : PostProcessEffectRenderer<DepthOfFieldEffect> // TypeDefIndex: 10249
{	// Fields
	private float focalDistance01; // 0x20
	private float internalBlurWidth; // 0x24
	private Shader dofShader; // 0x28

	// Methods

	// RVA: 0x97C0E0 Offset: 0x97A6E0 VA: 0x18097C0E0 Slot: 4
	public override void Init() { }

	// RVA: 0x97BF40 Offset: 0x97A540 VA: 0x18097BF40
	private float FocalDistance01(Camera cam, float worldDist) { }

	// RVA: 0x97C830 Offset: 0x97AE30 VA: 0x18097C830
	private void WriteCoc(PostProcessRenderContext context, PropertySheet sheet) { }

	// RVA: 0x97C130 Offset: 0x97A730 VA: 0x18097C130 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x97CD90 Offset: 0x97B390 VA: 0x18097CD90
	public void .ctor() { }

}

