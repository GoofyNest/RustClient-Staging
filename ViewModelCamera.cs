public class ViewModelCamera : MonoBehaviour // TypeDefIndex: 11454
{	private readonly int _PreviousVP; // 0x18
	private readonly int _NonJitteredVP; // 0x1C
	private readonly int _WorldSpaceCameraPos; // 0x20
	private readonly int _HasLastPositionData; // 0x24
	private readonly int _CurrentM; // 0x28
	private readonly int _PreviousM; // 0x2C
	private readonly int _WorldSpaceLightPos0; // 0x30
	private readonly int _LightColor0; // 0x34
	private readonly int unity_SHAr; // 0x38
	private readonly int unity_SHAg; // 0x3C
	private readonly int unity_SHAb; // 0x40
	private readonly int unity_SHBr; // 0x44
	private readonly int unity_SHBg; // 0x48
	private readonly int unity_SHBb; // 0x4C
	private readonly int unity_SHC; // 0x50
	private readonly int ambient_SHAr; // 0x54
	private readonly int ambient_SHAg; // 0x58
	private readonly int ambient_SHAb; // 0x5C
	private readonly int ambient_SHBr; // 0x60
	private readonly int ambient_SHBg; // 0x64
	private readonly int ambient_SHBb; // 0x68
	private readonly int ambient_SHC; // 0x6C
	private readonly int global_MainLightingAtten; // 0x70
	private readonly int global_SkyReflection; // 0x74
	private readonly int global_SkyReflection_HDR; // 0x78
	public static ViewModelCamera Instance; // 0x0
	private ListHashSet<ViewModelDrawEvent> afterGBufferEvents; // 0x80
	private ListHashSet<ViewModelDrawEvent> afterForwardAlphaDrawEvents; // 0x88
	private Material utilsMaterial; // 0x90
	private int stencilPassID; // 0x98
	private int motionPassID; // 0x9C
	private int blockDepthPassID; // 0xA0
	private int clearDepthPassID; // 0xA4
	private CommandBufferManager commandBufferManager; // 0xA8
	private CommandBufferDesc onBeforeGBufferDesc; // 0xB0
	private CommandBufferDesc onAfterGBufferDesc; // 0xB8
	private CommandBufferDesc onBeforeImageEffectsOpaqueDesc; // 0xC0
	private CommandBufferDesc onAfterForwardAlphaDesc; // 0xC8
	private Matrix4x4 previousViewProjectionMatrix; // 0xD0


	private void OnEnable() { }

	private void OnDisable() { }

	public void OnBeforeGBuffer(CommandBuffer cb) { }

	public void OnAfterGBuffer(CommandBuffer cb) { }

	private void OnBeforeImageEffectsOpaque(CommandBuffer cb) { }

	private void OnAfterForwardAlpha(CommandBuffer cb) { }

	private void SetCameraMatrices(CommandBuffer cb) { }

	private void UpdateAmbientProbe(CommandBuffer cb) { }

	private void UpdateSkyReflection(CommandBuffer cb) { }

	private void UpdateSHCoefficients(CommandBuffer cb) { }

	private void UpdateLightParameters(CommandBuffer cb) { }

	public void Clear() { }

	public void AddGBufferDrawEvent(ViewModelDrawEvent drawEvent) { }

	public void AddForwardAlphaDrawEvent(ViewModelDrawEvent drawEvent) { }

	public void RemoveGBufferDrawEvent(ViewModelDrawEvent drawEvent) { }

	public void RemoveForwardAlphaDrawEvent(ViewModelDrawEvent drawEvent) { }

	public void .ctor() { }

}

