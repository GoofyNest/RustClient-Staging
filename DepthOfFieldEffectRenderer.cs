public class DepthOfFieldEffectRenderer : PostProcessEffectRenderer<DepthOfFieldEffect> // TypeDefIndex: 10249
{	// Fields
	private float focalDistance01; // 0x20
	private float internalBlurWidth; // 0x24
	private Shader dofShader; // 0x28

	// Methods

	// RVA: 0x97C1F0 Offset: 0x97A7F0 VA: 0x18097C1F0 Slot: 4
	public override void Init() { }

	// RVA: 0x97C050 Offset: 0x97A650 VA: 0x18097C050
	private float FocalDistance01(Camera cam, float worldDist) { }

	// RVA: 0x97C940 Offset: 0x97AF40 VA: 0x18097C940
	private void WriteCoc(PostProcessRenderContext context, PropertySheet sheet) { }

	// RVA: 0x97C240 Offset: 0x97A840 VA: 0x18097C240 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x97CEA0 Offset: 0x97B4A0 VA: 0x18097CEA0
	public void .ctor() { }

}

