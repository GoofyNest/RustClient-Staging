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

	// RVA: 0x19B3880 Offset: 0x19B1E80 VA: 0x1819B3880
	public void set_motionVectors(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x8F450 Offset: 0x8E850 VA: 0x18008F450
	// RVA: 0x19B34A0 Offset: 0x19B1AA0 VA: 0x1819B34A0
	public Bounds get_bounds() { }

	[FreeFunctionAttribute] // RVA: 0x8F5F0 Offset: 0x8E9F0 VA: 0x18008F5F0
	// RVA: 0x19B30C0 Offset: 0x19B16C0 VA: 0x1819B30C0
	private Material GetMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F7E0 Offset: 0x8EBE0 VA: 0x18008F7E0
	// RVA: 0x19B3190 Offset: 0x19B1790 VA: 0x1819B3190
	private Material GetSharedMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F890 Offset: 0x8EC90 VA: 0x18008F890
	// RVA: 0x19B3400 Offset: 0x19B1A00 VA: 0x1819B3400
	private void SetMaterial(Material m) { }

	[FreeFunctionAttribute] // RVA: 0x8FA20 Offset: 0x8EE20 VA: 0x18008FA20
	// RVA: 0x19B3040 Offset: 0x19B1640 VA: 0x1819B3040
	private Material[] GetMaterialArray() { }

	[FreeFunctionAttribute] // RVA: 0x8FAE0 Offset: 0x8EEE0 VA: 0x18008FAE0
	// RVA: 0x19B2FF0 Offset: 0x19B15F0 VA: 0x1819B2FF0
	private void CopySharedMaterialArray([Out] Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8FB80 Offset: 0x8EF80 VA: 0x18008FB80
	// RVA: 0x19B33B0 Offset: 0x19B19B0 VA: 0x1819B33B0
	private void SetMaterialArray(Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8FE40 Offset: 0x8F240 VA: 0x18008FE40
	// RVA: 0x19B3360 Offset: 0x19B1960 VA: 0x1819B3360
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x8FF00 Offset: 0x8F300 VA: 0x18008FF00
	// RVA: 0x19B3100 Offset: 0x19B1700 VA: 0x1819B3100
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[FreeFunctionAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	// RVA: 0x19B3300 Offset: 0x19B1900 VA: 0x1819B3300
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) { }

	[FreeFunctionAttribute] // RVA: 0x90240 Offset: 0x8F640 VA: 0x180090240
	// RVA: 0x19B32C0 Offset: 0x19B18C0 VA: 0x1819B32C0
	public bool HasPropertyBlock() { }

	// RVA: 0x19B3360 Offset: 0x19B1960 VA: 0x1819B3360
	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x19B3300 Offset: 0x19B1900 VA: 0x1819B3300
	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	// RVA: 0x19B3100 Offset: 0x19B1700 VA: 0x1819B3100
	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x19B3500 Offset: 0x19B1B00 VA: 0x1819B3500
	public bool get_enabled() { }

	// RVA: 0x19B37B0 Offset: 0x19B1DB0 VA: 0x1819B37B0
	public void set_enabled(bool value) { }

	[NativeNameAttribute] // RVA: 0x90370 Offset: 0x8F770 VA: 0x180090370
	// RVA: 0x19B3540 Offset: 0x19B1B40 VA: 0x1819B3540
	public bool get_isVisible() { }

	// RVA: 0x19B36F0 Offset: 0x19B1CF0 VA: 0x1819B36F0
	public ShadowCastingMode get_shadowCastingMode() { }

	// RVA: 0x19B3960 Offset: 0x19B1F60 VA: 0x1819B3960
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x19B36B0 Offset: 0x19B1CB0 VA: 0x1819B36B0
	public bool get_receiveShadows() { }

	// RVA: 0x19B38D0 Offset: 0x19B1ED0 VA: 0x1819B38D0
	public void set_receiveShadows(bool value) { }

	// RVA: 0x19B3670 Offset: 0x19B1C70 VA: 0x1819B3670
	public MotionVectorGenerationMode get_motionVectorGenerationMode() { }

	// RVA: 0x19B3840 Offset: 0x19B1E40 VA: 0x1819B3840
	public void set_motionVectorGenerationMode(MotionVectorGenerationMode value) { }

	// RVA: 0x19B3580 Offset: 0x19B1B80 VA: 0x1819B3580
	public LightProbeUsage get_lightProbeUsage() { }

	// RVA: 0x19B3800 Offset: 0x19B1E00 VA: 0x1819B3800
	public void set_lightProbeUsage(LightProbeUsage value) { }

	// RVA: 0x19B3920 Offset: 0x19B1F20 VA: 0x1819B3920
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0x19B3730 Offset: 0x19B1D30 VA: 0x1819B3730
	public int get_sortingLayerID() { }

	// RVA: 0x19B39A0 Offset: 0x19B1FA0 VA: 0x1819B39A0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x19B3770 Offset: 0x19B1D70 VA: 0x1819B3770
	public int get_sortingOrder() { }

	// RVA: 0x19B39E0 Offset: 0x19B1FE0 VA: 0x1819B39E0
	public void set_sortingOrder(int value) { }

	// RVA: 0x19B3610 Offset: 0x19B1C10 VA: 0x1819B3610
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x19B3080 Offset: 0x19B1680 VA: 0x1819B3080
	private int GetMaterialCount() { }

	[NativeNameAttribute] // RVA: 0x90490 Offset: 0x8F890 VA: 0x180090490
	// RVA: 0x19B3150 Offset: 0x19B1750 VA: 0x1819B3150
	private Material[] GetSharedMaterialArray() { }

	// RVA: 0x19B3040 Offset: 0x19B1640 VA: 0x1819B3040
	public Material[] get_materials() { }

	// RVA: 0x19B33B0 Offset: 0x19B19B0 VA: 0x1819B33B0
	public void set_materials(Material[] value) { }

	// RVA: 0x19B30C0 Offset: 0x19B16C0 VA: 0x1819B30C0
	public Material get_material() { }

	// RVA: 0x19B3400 Offset: 0x19B1A00 VA: 0x1819B3400
	public void set_material(Material value) { }

	// RVA: 0x19B3190 Offset: 0x19B1790 VA: 0x1819B3190
	public Material get_sharedMaterial() { }

	// RVA: 0x19B3400 Offset: 0x19B1A00 VA: 0x1819B3400
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x19B3150 Offset: 0x19B1750 VA: 0x1819B3150
	public Material[] get_sharedMaterials() { }

	// RVA: 0x19B33B0 Offset: 0x19B19B0 VA: 0x1819B33B0
	public void set_sharedMaterials(Material[] value) { }

	// RVA: 0x19B31D0 Offset: 0x19B17D0 VA: 0x1819B31D0
	public void GetSharedMaterials(List<Material> m) { }

	// RVA: 0x19B3450 Offset: 0x19B1A50 VA: 0x1819B3450
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x19B35C0 Offset: 0x19B1BC0 VA: 0x1819B35C0
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

}

