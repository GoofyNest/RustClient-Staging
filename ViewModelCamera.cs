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

	// RVA: 0x7F2350 Offset: 0x7F0950 VA: 0x1807F2350
	private void OnEnable() { }

	// RVA: 0x7F2200 Offset: 0x7F0800 VA: 0x1807F2200
	private void OnDisable() { }

	// RVA: 0x7F12C0 Offset: 0x7EF8C0 VA: 0x1807F12C0
	public void OnBeforeGBuffer(CommandBuffer cb) { }

	// RVA: 0x7F0CA0 Offset: 0x7EF2A0 VA: 0x1807F0CA0
	public void OnAfterGBuffer(CommandBuffer cb) { }

	// RVA: 0x7F15E0 Offset: 0x7EFBE0 VA: 0x1807F15E0
	private void OnBeforeImageEffectsOpaque(CommandBuffer cb) { }

	// RVA: 0x7F09A0 Offset: 0x7EEFA0 VA: 0x1807F09A0
	private void OnAfterForwardAlpha(CommandBuffer cb) { }

	// RVA: 0x7F27A0 Offset: 0x7F0DA0 VA: 0x1807F27A0
	private void SetCameraMatrices(CommandBuffer cb) { }

	// RVA: 0x7F2A50 Offset: 0x7F1050 VA: 0x1807F2A50
	private void UpdateAmbientProbe(CommandBuffer cb) { }

	// RVA: 0x7F3990 Offset: 0x7F1F90 VA: 0x1807F3990
	private void UpdateSkyReflection(CommandBuffer cb) { }

	// RVA: 0x7F32F0 Offset: 0x7F18F0 VA: 0x1807F32F0
	private void UpdateSHCoefficients(CommandBuffer cb) { }

	// RVA: 0x7F30F0 Offset: 0x7F16F0 VA: 0x1807F30F0
	private void UpdateLightParameters(CommandBuffer cb) { }

	// RVA: 0x7F0940 Offset: 0x7EEF40 VA: 0x1807F0940
	public void Clear() { }

	// RVA: 0x7F0880 Offset: 0x7EEE80 VA: 0x1807F0880
	public void AddGBufferDrawEvent(ViewModelDrawEvent drawEvent) { }

	// RVA: 0x7F07C0 Offset: 0x7EEDC0 VA: 0x1807F07C0
	public void AddForwardAlphaDrawEvent(ViewModelDrawEvent drawEvent) { }

	// RVA: 0x7F2720 Offset: 0x7F0D20 VA: 0x1807F2720
	public void RemoveGBufferDrawEvent(ViewModelDrawEvent drawEvent) { }

	// RVA: 0x7F26A0 Offset: 0x7F0CA0 VA: 0x1807F26A0
	public void RemoveForwardAlphaDrawEvent(ViewModelDrawEvent drawEvent) { }

	// RVA: 0x7F3EE0 Offset: 0x7F24E0 VA: 0x1807F3EE0
	public void .ctor() { }

}

