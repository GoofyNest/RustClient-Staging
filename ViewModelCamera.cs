public class ViewModelCamera : MonoBehaviour // TypeDefIndex: 11450
{	// Fields
	private readonly int _PreviousVP; // 0x18
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

	// Methods

	// RVA: 0x7F1DC0 Offset: 0x7F03C0 VA: 0x1807F1DC0
	private void OnEnable() { }

	// RVA: 0x7F1C70 Offset: 0x7F0270 VA: 0x1807F1C70
	private void OnDisable() { }

	// RVA: 0x7F0D30 Offset: 0x7EF330 VA: 0x1807F0D30
	public void OnBeforeGBuffer(CommandBuffer cb) { }

	// RVA: 0x7F0710 Offset: 0x7EED10 VA: 0x1807F0710
	public void OnAfterGBuffer(CommandBuffer cb) { }

	// RVA: 0x7F1050 Offset: 0x7EF650 VA: 0x1807F1050
	private void OnBeforeImageEffectsOpaque(CommandBuffer cb) { }

	// RVA: 0x7F0410 Offset: 0x7EEA10 VA: 0x1807F0410
	private void OnAfterForwardAlpha(CommandBuffer cb) { }

	// RVA: 0x7F2210 Offset: 0x7F0810 VA: 0x1807F2210
	private void SetCameraMatrices(CommandBuffer cb) { }

	// RVA: 0x7F24C0 Offset: 0x7F0AC0 VA: 0x1807F24C0
	private void UpdateAmbientProbe(CommandBuffer cb) { }

	// RVA: 0x7F3400 Offset: 0x7F1A00 VA: 0x1807F3400
	private void UpdateSkyReflection(CommandBuffer cb) { }

	// RVA: 0x7F2D60 Offset: 0x7F1360 VA: 0x1807F2D60
	private void UpdateSHCoefficients(CommandBuffer cb) { }

	// RVA: 0x7F2B60 Offset: 0x7F1160 VA: 0x1807F2B60
	private void UpdateLightParameters(CommandBuffer cb) { }

	// RVA: 0x7F03B0 Offset: 0x7EE9B0 VA: 0x1807F03B0
	public void Clear() { }

	// RVA: 0x7F02F0 Offset: 0x7EE8F0 VA: 0x1807F02F0
	public void AddGBufferDrawEvent(ViewModelDrawEvent drawEvent) { }

	// RVA: 0x7F0230 Offset: 0x7EE830 VA: 0x1807F0230
	public void AddForwardAlphaDrawEvent(ViewModelDrawEvent drawEvent) { }

	// RVA: 0x7F2190 Offset: 0x7F0790 VA: 0x1807F2190
	public void RemoveGBufferDrawEvent(ViewModelDrawEvent drawEvent) { }

	// RVA: 0x7F2110 Offset: 0x7F0710 VA: 0x1807F2110
	public void RemoveForwardAlphaDrawEvent(ViewModelDrawEvent drawEvent) { }

	// RVA: 0x7F3950 Offset: 0x7F1F50 VA: 0x1807F3950
	public void .ctor() { }

}

