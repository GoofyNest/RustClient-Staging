public class DepthOfFieldEffectRenderer : PostProcessEffectRenderer<DepthOfFieldEffect> // TypeDefIndex: 10249
{	// Fields
	private float focalDistance01; // 0x20
	private float internalBlurWidth; // 0x24
	private Shader dofShader; // 0x28

	// Methods

	// RVA: 0x97C6F0 Offset: 0x97ACF0 VA: 0x18097C6F0 Slot: 4
	public override void Init() { }

	// RVA: 0x97C550 Offset: 0x97AB50 VA: 0x18097C550
	private float FocalDistance01(Camera cam, float worldDist) { }

	// RVA: 0x97CE40 Offset: 0x97B440 VA: 0x18097CE40
	private void WriteCoc(PostProcessRenderContext context, PropertySheet sheet) { }

	// RVA: 0x97C740 Offset: 0x97AD40 VA: 0x18097C740 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x97D3A0 Offset: 0x97B9A0 VA: 0x18097D3A0
	public void .ctor() { }

}

