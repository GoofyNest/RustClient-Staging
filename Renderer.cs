public class Renderer : Component // TypeDefIndex: 3403
{	[ObsoleteAttribute] // RVA: 0x905A0 Offset: 0x8F9A0 VA: 0x1800905A0
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

	[FreeFunctionAttribute] // RVA: 0x8F510 Offset: 0x8E910 VA: 0x18008F510
	public Bounds get_bounds() { }

	[FreeFunctionAttribute] // RVA: 0x8F670 Offset: 0x8EA70 VA: 0x18008F670
	private Material GetMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F820 Offset: 0x8EC20 VA: 0x18008F820
	private Material GetSharedMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F890 Offset: 0x8EC90 VA: 0x18008F890
	private void SetMaterial(Material m) { }

	[FreeFunctionAttribute] // RVA: 0x8F9E0 Offset: 0x8EDE0 VA: 0x18008F9E0
	private Material[] GetMaterialArray() { }

	[FreeFunctionAttribute] // RVA: 0x8FAD0 Offset: 0x8EED0 VA: 0x18008FAD0
	private void CopySharedMaterialArray([Out] Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8FB70 Offset: 0x8EF70 VA: 0x18008FB70
	private void SetMaterialArray(Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8FE30 Offset: 0x8F230 VA: 0x18008FE30
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x8FEF0 Offset: 0x8F2F0 VA: 0x18008FEF0
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[FreeFunctionAttribute] // RVA: 0x90190 Offset: 0x8F590 VA: 0x180090190
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) { }

	[FreeFunctionAttribute] // RVA: 0x90200 Offset: 0x8F600 VA: 0x180090200
	public bool HasPropertyBlock() { }

	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	public bool get_enabled() { }

	public void set_enabled(bool value) { }

	[NativeNameAttribute] // RVA: 0x90330 Offset: 0x8F730 VA: 0x180090330
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

	[NativeNameAttribute] // RVA: 0x90480 Offset: 0x8F880 VA: 0x180090480
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

