public class Renderer : Component // TypeDefIndex: 3403
{	[ObsoleteAttribute] // RVA: 0x90560 Offset: 0x8F960 VA: 0x180090560
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


	public void set_motionVectors(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x8F450 Offset: 0x8E850 VA: 0x18008F450
	public Bounds get_bounds() { }

	[FreeFunctionAttribute] // RVA: 0x8F5F0 Offset: 0x8E9F0 VA: 0x18008F5F0
	private Material GetMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F7E0 Offset: 0x8EBE0 VA: 0x18008F7E0
	private Material GetSharedMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F890 Offset: 0x8EC90 VA: 0x18008F890
	private void SetMaterial(Material m) { }

	[FreeFunctionAttribute] // RVA: 0x8FA20 Offset: 0x8EE20 VA: 0x18008FA20
	private Material[] GetMaterialArray() { }

	[FreeFunctionAttribute] // RVA: 0x8FAE0 Offset: 0x8EEE0 VA: 0x18008FAE0
	private void CopySharedMaterialArray([Out] Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8FB80 Offset: 0x8EF80 VA: 0x18008FB80
	private void SetMaterialArray(Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8FE40 Offset: 0x8F240 VA: 0x18008FE40
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x8FF00 Offset: 0x8F300 VA: 0x18008FF00
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[FreeFunctionAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) { }

	[FreeFunctionAttribute] // RVA: 0x90240 Offset: 0x8F640 VA: 0x180090240
	public bool HasPropertyBlock() { }

	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	public bool get_enabled() { }

	public void set_enabled(bool value) { }

	[NativeNameAttribute] // RVA: 0x90370 Offset: 0x8F770 VA: 0x180090370
	public bool get_isVisible() { }

	public ShadowCastingMode get_shadowCastingMode() { }

	public void set_shadowCastingMode(ShadowCastingMode value) { }

	public bool get_receiveShadows() { }

	public void set_receiveShadows(bool value) { }

	public MotionVectorGenerationMode get_motionVectorGenerationMode() { }

	public void set_motionVectorGenerationMode(MotionVectorGenerationMode value) { }

	public LightProbeUsage get_lightProbeUsage() { }

	public void set_lightProbeUsage(LightProbeUsage value) { }

	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	public int get_sortingLayerID() { }

	public void set_sortingLayerID(int value) { }

	public int get_sortingOrder() { }

	public void set_sortingOrder(int value) { }

	public Matrix4x4 get_localToWorldMatrix() { }

	private int GetMaterialCount() { }

	[NativeNameAttribute] // RVA: 0x90490 Offset: 0x8F890 VA: 0x180090490
	private Material[] GetSharedMaterialArray() { }

	public Material[] get_materials() { }

	public void set_materials(Material[] value) { }

	public Material get_material() { }

	public void set_material(Material value) { }

	public Material get_sharedMaterial() { }

	public void set_sharedMaterial(Material value) { }

	public Material[] get_sharedMaterials() { }

	public void set_sharedMaterials(Material[] value) { }

	public void GetSharedMaterials(List<Material> m) { }

	private void get_bounds_Injected(out Bounds ret) { }

	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

}

