public class Renderer : Component // TypeDefIndex: 3403
{	// Properties
	[ObsoleteAttribute] // RVA: 0x90560 Offset: 0x8F960 VA: 0x180090560
	public bool motionVectors { set; }
	public Bounds bounds { get; }
	public bool enabled { get; set; }
	public bool isVisible { get; }
	public ShadowCastingMode shadowCastingMode { get; set; }
	public bool receiveShadows { get; set; }
	public MotionVectorGenerationMode motionVectorGenerationMode { get; set; }
	public LightProbeUsage lightProbeUsage { get; set; }
	public ReflectionProbeUsage reflectionProbeUsage { set; }
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public Matrix4x4 localToWorldMatrix { get; }
	public Material[] materials { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material[] sharedMaterials { get; set; }

	// Methods

	// RVA: 0x19B35C0 Offset: 0x19B1BC0 VA: 0x1819B35C0
	public void set_motionVectors(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x8F450 Offset: 0x8E850 VA: 0x18008F450
	// RVA: 0x19B31E0 Offset: 0x19B17E0 VA: 0x1819B31E0
	public Bounds get_bounds() { }

	[FreeFunctionAttribute] // RVA: 0x8F5F0 Offset: 0x8E9F0 VA: 0x18008F5F0
	// RVA: 0x19B2E00 Offset: 0x19B1400 VA: 0x1819B2E00
	private Material GetMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F7E0 Offset: 0x8EBE0 VA: 0x18008F7E0
	// RVA: 0x19B2ED0 Offset: 0x19B14D0 VA: 0x1819B2ED0
	private Material GetSharedMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F890 Offset: 0x8EC90 VA: 0x18008F890
	// RVA: 0x19B3140 Offset: 0x19B1740 VA: 0x1819B3140
	private void SetMaterial(Material m) { }

	[FreeFunctionAttribute] // RVA: 0x8FA20 Offset: 0x8EE20 VA: 0x18008FA20
	// RVA: 0x19B2D80 Offset: 0x19B1380 VA: 0x1819B2D80
	private Material[] GetMaterialArray() { }

	[FreeFunctionAttribute] // RVA: 0x8FAE0 Offset: 0x8EEE0 VA: 0x18008FAE0
	// RVA: 0x19B2D30 Offset: 0x19B1330 VA: 0x1819B2D30
	private void CopySharedMaterialArray([Out] Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8FB80 Offset: 0x8EF80 VA: 0x18008FB80
	// RVA: 0x19B30F0 Offset: 0x19B16F0 VA: 0x1819B30F0
	private void SetMaterialArray(Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8FE40 Offset: 0x8F240 VA: 0x18008FE40
	// RVA: 0x19B30A0 Offset: 0x19B16A0 VA: 0x1819B30A0
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x8FF00 Offset: 0x8F300 VA: 0x18008FF00
	// RVA: 0x19B2E40 Offset: 0x19B1440 VA: 0x1819B2E40
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[FreeFunctionAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	// RVA: 0x19B3040 Offset: 0x19B1640 VA: 0x1819B3040
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) { }

	[FreeFunctionAttribute] // RVA: 0x90240 Offset: 0x8F640 VA: 0x180090240
	// RVA: 0x19B3000 Offset: 0x19B1600 VA: 0x1819B3000
	public bool HasPropertyBlock() { }

	// RVA: 0x19B30A0 Offset: 0x19B16A0 VA: 0x1819B30A0
	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x19B3040 Offset: 0x19B1640 VA: 0x1819B3040
	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	// RVA: 0x19B2E40 Offset: 0x19B1440 VA: 0x1819B2E40
	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x19B3240 Offset: 0x19B1840 VA: 0x1819B3240
	public bool get_enabled() { }

	// RVA: 0x19B34F0 Offset: 0x19B1AF0 VA: 0x1819B34F0
	public void set_enabled(bool value) { }

	[NativeNameAttribute] // RVA: 0x90370 Offset: 0x8F770 VA: 0x180090370
	// RVA: 0x19B3280 Offset: 0x19B1880 VA: 0x1819B3280
	public bool get_isVisible() { }

	// RVA: 0x19B3430 Offset: 0x19B1A30 VA: 0x1819B3430
	public ShadowCastingMode get_shadowCastingMode() { }

	// RVA: 0x19B36A0 Offset: 0x19B1CA0 VA: 0x1819B36A0
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x19B33F0 Offset: 0x19B19F0 VA: 0x1819B33F0
	public bool get_receiveShadows() { }

	// RVA: 0x19B3610 Offset: 0x19B1C10 VA: 0x1819B3610
	public void set_receiveShadows(bool value) { }

	// RVA: 0x19B33B0 Offset: 0x19B19B0 VA: 0x1819B33B0
	public MotionVectorGenerationMode get_motionVectorGenerationMode() { }

	// RVA: 0x19B3580 Offset: 0x19B1B80 VA: 0x1819B3580
	public void set_motionVectorGenerationMode(MotionVectorGenerationMode value) { }

	// RVA: 0x19B32C0 Offset: 0x19B18C0 VA: 0x1819B32C0
	public LightProbeUsage get_lightProbeUsage() { }

	// RVA: 0x19B3540 Offset: 0x19B1B40 VA: 0x1819B3540
	public void set_lightProbeUsage(LightProbeUsage value) { }

	// RVA: 0x19B3660 Offset: 0x19B1C60 VA: 0x1819B3660
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0x19B3470 Offset: 0x19B1A70 VA: 0x1819B3470
	public int get_sortingLayerID() { }

	// RVA: 0x19B36E0 Offset: 0x19B1CE0 VA: 0x1819B36E0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x19B34B0 Offset: 0x19B1AB0 VA: 0x1819B34B0
	public int get_sortingOrder() { }

	// RVA: 0x19B3720 Offset: 0x19B1D20 VA: 0x1819B3720
	public void set_sortingOrder(int value) { }

	// RVA: 0x19B3350 Offset: 0x19B1950 VA: 0x1819B3350
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x19B2DC0 Offset: 0x19B13C0 VA: 0x1819B2DC0
	private int GetMaterialCount() { }

	[NativeNameAttribute] // RVA: 0x90490 Offset: 0x8F890 VA: 0x180090490
	// RVA: 0x19B2E90 Offset: 0x19B1490 VA: 0x1819B2E90
	private Material[] GetSharedMaterialArray() { }

	// RVA: 0x19B2D80 Offset: 0x19B1380 VA: 0x1819B2D80
	public Material[] get_materials() { }

	// RVA: 0x19B30F0 Offset: 0x19B16F0 VA: 0x1819B30F0
	public void set_materials(Material[] value) { }

	// RVA: 0x19B2E00 Offset: 0x19B1400 VA: 0x1819B2E00
	public Material get_material() { }

	// RVA: 0x19B3140 Offset: 0x19B1740 VA: 0x1819B3140
	public void set_material(Material value) { }

	// RVA: 0x19B2ED0 Offset: 0x19B14D0 VA: 0x1819B2ED0
	public Material get_sharedMaterial() { }

	// RVA: 0x19B3140 Offset: 0x19B1740 VA: 0x1819B3140
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x19B2E90 Offset: 0x19B1490 VA: 0x1819B2E90
	public Material[] get_sharedMaterials() { }

	// RVA: 0x19B30F0 Offset: 0x19B16F0 VA: 0x1819B30F0
	public void set_sharedMaterials(Material[] value) { }

	// RVA: 0x19B2F10 Offset: 0x19B1510 VA: 0x1819B2F10
	public void GetSharedMaterials(List<Material> m) { }

	// RVA: 0x19B3190 Offset: 0x19B1790 VA: 0x1819B3190
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x19B3300 Offset: 0x19B1900 VA: 0x1819B3300
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

}

