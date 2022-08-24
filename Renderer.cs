public class Renderer : Component // TypeDefIndex: 3403
{	[ObsoleteAttribute] // RVA: 0x906A0 Offset: 0x8FAA0 VA: 0x1800906A0
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

	[FreeFunctionAttribute] // RVA: 0x8F550 Offset: 0x8E950 VA: 0x18008F550
	public Bounds get_bounds() { }

	[FreeFunctionAttribute] // RVA: 0x8F6B0 Offset: 0x8EAB0 VA: 0x18008F6B0
	private Material GetMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F8A0 Offset: 0x8ECA0 VA: 0x18008F8A0
	private Material GetSharedMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F950 Offset: 0x8ED50 VA: 0x18008F950
	private void SetMaterial(Material m) { }

	[FreeFunctionAttribute] // RVA: 0x8FAE0 Offset: 0x8EEE0 VA: 0x18008FAE0
	private Material[] GetMaterialArray() { }

	[FreeFunctionAttribute] // RVA: 0x8FBE0 Offset: 0x8EFE0 VA: 0x18008FBE0
	private void CopySharedMaterialArray([Out] Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8FCC0 Offset: 0x8F0C0 VA: 0x18008FCC0
	private void SetMaterialArray(Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8FF80 Offset: 0x8F380 VA: 0x18008FF80
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x90040 Offset: 0x8F440 VA: 0x180090040
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[FreeFunctionAttribute] // RVA: 0x902E0 Offset: 0x8F6E0 VA: 0x1800902E0
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) { }

	[FreeFunctionAttribute] // RVA: 0x90380 Offset: 0x8F780 VA: 0x180090380
	public bool HasPropertyBlock() { }

	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	public bool get_enabled() { }

	public void set_enabled(bool value) { }

	[NativeNameAttribute] // RVA: 0x904B0 Offset: 0x8F8B0 VA: 0x1800904B0
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

	[NativeNameAttribute] // RVA: 0x905D0 Offset: 0x8F9D0 VA: 0x1800905D0
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

