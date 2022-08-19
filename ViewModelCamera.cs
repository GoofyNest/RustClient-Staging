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

	// RVA: 0x7F1CB0 Offset: 0x7F02B0 VA: 0x1807F1CB0
	private void OnEnable() { }

	// RVA: 0x7F1B60 Offset: 0x7F0160 VA: 0x1807F1B60
	private void OnDisable() { }

	// RVA: 0x7F0C20 Offset: 0x7EF220 VA: 0x1807F0C20
	public void OnBeforeGBuffer(CommandBuffer cb) { }

	// RVA: 0x7F0600 Offset: 0x7EEC00 VA: 0x1807F0600
	public void OnAfterGBuffer(CommandBuffer cb) { }

	// RVA: 0x7F0F40 Offset: 0x7EF540 VA: 0x1807F0F40
	private void OnBeforeImageEffectsOpaque(CommandBuffer cb) { }

	// RVA: 0x7F0300 Offset: 0x7EE900 VA: 0x1807F0300
	private void OnAfterForwardAlpha(CommandBuffer cb) { }

	// RVA: 0x7F2100 Offset: 0x7F0700 VA: 0x1807F2100
	private void SetCameraMatrices(CommandBuffer cb) { }

	// RVA: 0x7F23B0 Offset: 0x7F09B0 VA: 0x1807F23B0
	private void UpdateAmbientProbe(CommandBuffer cb) { }

	// RVA: 0x7F32F0 Offset: 0x7F18F0 VA: 0x1807F32F0
	private void UpdateSkyReflection(CommandBuffer cb) { }

	// RVA: 0x7F2C50 Offset: 0x7F1250 VA: 0x1807F2C50
	private void UpdateSHCoefficients(CommandBuffer cb) { }

	// RVA: 0x7F2A50 Offset: 0x7F1050 VA: 0x1807F2A50
	private void UpdateLightParameters(CommandBuffer cb) { }

	// RVA: 0x7F02A0 Offset: 0x7EE8A0 VA: 0x1807F02A0
	public void Clear() { }

	// RVA: 0x7F01E0 Offset: 0x7EE7E0 VA: 0x1807F01E0
	public void AddGBufferDrawEvent(ViewModelDrawEvent drawEvent) { }

	// RVA: 0x7F0120 Offset: 0x7EE720 VA: 0x1807F0120
	public void AddForwardAlphaDrawEvent(ViewModelDrawEvent drawEvent) { }

	// RVA: 0x7F2080 Offset: 0x7F0680 VA: 0x1807F2080
	public void RemoveGBufferDrawEvent(ViewModelDrawEvent drawEvent) { }

	// RVA: 0x7F2000 Offset: 0x7F0600 VA: 0x1807F2000
	public void RemoveForwardAlphaDrawEvent(ViewModelDrawEvent drawEvent) { }

	// RVA: 0x7F3840 Offset: 0x7F1E40 VA: 0x1807F3840
	public void .ctor() { }

}

