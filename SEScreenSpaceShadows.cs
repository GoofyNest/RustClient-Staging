public class SEScreenSpaceShadows : MonoBehaviour // TypeDefIndex: 11526
{	private CommandBuffer blendShadowsCommandBuffer; // 0x18
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


	private void AddCommandBufferClean(Light light, CommandBuffer commandBuffer, LightEvent lightEvent) { }

	private void AddCommandBufferClean(Camera camera, CommandBuffer commandBuffer, CameraEvent cameraEvent) { }

	private void RemoveCommandBuffer(Light light, CommandBuffer commandBuffer, LightEvent lightEvent) { }

	private void RemoveCommandBuffer(Camera camera, CommandBuffer commandBuffer, CameraEvent cameraEvent) { }

	private void RemoveCommandBuffers() { }

	public bool GetCompatibleRenderPath() { }

	private void Init() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void OnPreRender() { }

	private void OnPostRender() { }

	public void .ctor() { }

}

