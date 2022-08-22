public class SEScreenSpaceShadows : MonoBehaviour // TypeDefIndex: 11526
{	// Fields
	private CommandBuffer blendShadowsCommandBuffer; // 0x18
	private CommandBuffer renderShadowsCommandBuffer; // 0x20
	private Camera attachedCamera; // 0x28
	public Light sun; // 0x30
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float blendStrength; // 0x38
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float accumulation; // 0x3C
	[RangeAttribute] // RVA: 0xB9CA0 Offset: 0xB90A0 VA: 0x1800B9CA0
	public float lengthFade; // 0x40
	[RangeAttribute] // RVA: 0xB9D50 Offset: 0xB9150 VA: 0x1800B9D50
	public float range; // 0x44
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float zThickness; // 0x48
	[RangeAttribute] // RVA: 0xB9DE0 Offset: 0xB91E0 VA: 0x1800B9DE0
	public int samples; // 0x4C
	[RangeAttribute] // RVA: 0xB9E00 Offset: 0xB9200 VA: 0x1800B9E00
	public float nearSampleQuality; // 0x50
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float traceBias; // 0x54
	public bool stochasticSampling; // 0x58
	public bool leverageTemporalAA; // 0x59
	public bool bilateralBlur; // 0x5A
	[RangeAttribute] // RVA: 0xA4560 Offset: 0xA3960 VA: 0x1800A4560
	public int blurPasses; // 0x5C
	[RangeAttribute] // RVA: 0xB9F20 Offset: 0xB9320 VA: 0x1800B9F20
	public float blurDepthTolerance; // 0x60
	private Material material; // 0x68
	private object initChecker; // 0x70
	private bool sunInitialized; // 0x78
	private int temporalJitterCounter; // 0x7C
	private bool previousBilateralBlurSetting; // 0x80
	private int previousBlurPassesSetting; // 0x84
	private Texture2D noBlendTex; // 0x88

	// Methods

	// RVA: 0x49C500 Offset: 0x49AB00 VA: 0x18049C500
	private void AddCommandBufferClean(Light light, CommandBuffer commandBuffer, LightEvent lightEvent) { }

	// RVA: 0x49C410 Offset: 0x49AA10 VA: 0x18049C410
	private void AddCommandBufferClean(Camera camera, CommandBuffer commandBuffer, CameraEvent cameraEvent) { }

	// RVA: 0x49D910 Offset: 0x49BF10 VA: 0x18049D910
	private void RemoveCommandBuffer(Light light, CommandBuffer commandBuffer, LightEvent lightEvent) { }

	// RVA: 0x49D6E0 Offset: 0x49BCE0 VA: 0x18049D6E0
	private void RemoveCommandBuffer(Camera camera, CommandBuffer commandBuffer, CameraEvent cameraEvent) { }

	// RVA: 0x49DB40 Offset: 0x49C140 VA: 0x18049DB40
	private void RemoveCommandBuffers() { }

	// RVA: 0x49C5F0 Offset: 0x49ABF0 VA: 0x18049C5F0
	public bool GetCompatibleRenderPath() { }

	// RVA: 0x49C690 Offset: 0x49AC90 VA: 0x18049C690
	private void Init() { }

	// RVA: 0x49D030 Offset: 0x49B630 VA: 0x18049D030
	private void OnEnable() { }

	// RVA: 0x49D000 Offset: 0x49B600 VA: 0x18049D000
	private void OnDisable() { }

	// RVA: 0x49D080 Offset: 0x49B680 VA: 0x18049D080
	private void OnPreRender() { }

	// RVA: 0x49D040 Offset: 0x49B640 VA: 0x18049D040
	private void OnPostRender() { }

	// RVA: 0x49DBF0 Offset: 0x49C1F0 VA: 0x18049DBF0
	public void .ctor() { }

}

