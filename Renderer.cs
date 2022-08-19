public class Renderer : Component // TypeDefIndex: 3403
{	// Properties
	[ObsoleteAttribute] // RVA: 0x904E0 Offset: 0x8F8E0 VA: 0x1800904E0
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

	// RVA: 0x19B3600 Offset: 0x19B1C00 VA: 0x1819B3600
	public void set_motionVectors(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x8F3D0 Offset: 0x8E7D0 VA: 0x18008F3D0
	// RVA: 0x19B3220 Offset: 0x19B1820 VA: 0x1819B3220
	public Bounds get_bounds() { }

	[FreeFunctionAttribute] // RVA: 0x8F570 Offset: 0x8E970 VA: 0x18008F570
	// RVA: 0x19B2E40 Offset: 0x19B1440 VA: 0x1819B2E40
	private Material GetMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F760 Offset: 0x8EB60 VA: 0x18008F760
	// RVA: 0x19B2F10 Offset: 0x19B1510 VA: 0x1819B2F10
	private Material GetSharedMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F810 Offset: 0x8EC10 VA: 0x18008F810
	// RVA: 0x19B3180 Offset: 0x19B1780 VA: 0x1819B3180
	private void SetMaterial(Material m) { }

	[FreeFunctionAttribute] // RVA: 0x8F8F0 Offset: 0x8ECF0 VA: 0x18008F8F0
	// RVA: 0x19B2DC0 Offset: 0x19B13C0 VA: 0x1819B2DC0
	private Material[] GetMaterialArray() { }

	[FreeFunctionAttribute] // RVA: 0x8FA60 Offset: 0x8EE60 VA: 0x18008FA60
	// RVA: 0x19B2D70 Offset: 0x19B1370 VA: 0x1819B2D70
	private void CopySharedMaterialArray([Out] Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8FB00 Offset: 0x8EF00 VA: 0x18008FB00
	// RVA: 0x19B3130 Offset: 0x19B1730 VA: 0x1819B3130
	private void SetMaterialArray(Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8FDC0 Offset: 0x8F1C0 VA: 0x18008FDC0
	// RVA: 0x19B30E0 Offset: 0x19B16E0 VA: 0x1819B30E0
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x8FE80 Offset: 0x8F280 VA: 0x18008FE80
	// RVA: 0x19B2E80 Offset: 0x19B1480 VA: 0x1819B2E80
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[FreeFunctionAttribute] // RVA: 0x90150 Offset: 0x8F550 VA: 0x180090150
	// RVA: 0x19B3080 Offset: 0x19B1680 VA: 0x1819B3080
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) { }

	[FreeFunctionAttribute] // RVA: 0x901C0 Offset: 0x8F5C0 VA: 0x1800901C0
	// RVA: 0x19B3040 Offset: 0x19B1640 VA: 0x1819B3040
	public bool HasPropertyBlock() { }

	// RVA: 0x19B30E0 Offset: 0x19B16E0 VA: 0x1819B30E0
	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x19B3080 Offset: 0x19B1680 VA: 0x1819B3080
	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	// RVA: 0x19B2E80 Offset: 0x19B1480 VA: 0x1819B2E80
	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x19B3280 Offset: 0x19B1880 VA: 0x1819B3280
	public bool get_enabled() { }

	// RVA: 0x19B3530 Offset: 0x19B1B30 VA: 0x1819B3530
	public void set_enabled(bool value) { }

	[NativeNameAttribute] // RVA: 0x902B0 Offset: 0x8F6B0 VA: 0x1800902B0
	// RVA: 0x19B32C0 Offset: 0x19B18C0 VA: 0x1819B32C0
	public bool get_isVisible() { }

	// RVA: 0x19B3470 Offset: 0x19B1A70 VA: 0x1819B3470
	public ShadowCastingMode get_shadowCastingMode() { }

	// RVA: 0x19B36E0 Offset: 0x19B1CE0 VA: 0x1819B36E0
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x19B3430 Offset: 0x19B1A30 VA: 0x1819B3430
	public bool get_receiveShadows() { }

	// RVA: 0x19B3650 Offset: 0x19B1C50 VA: 0x1819B3650
	public void set_receiveShadows(bool value) { }

	// RVA: 0x19B33F0 Offset: 0x19B19F0 VA: 0x1819B33F0
	public MotionVectorGenerationMode get_motionVectorGenerationMode() { }

	// RVA: 0x19B35C0 Offset: 0x19B1BC0 VA: 0x1819B35C0
	public void set_motionVectorGenerationMode(MotionVectorGenerationMode value) { }

	// RVA: 0x19B3300 Offset: 0x19B1900 VA: 0x1819B3300
	public LightProbeUsage get_lightProbeUsage() { }

	// RVA: 0x19B3580 Offset: 0x19B1B80 VA: 0x1819B3580
	public void set_lightProbeUsage(LightProbeUsage value) { }

	// RVA: 0x19B36A0 Offset: 0x19B1CA0 VA: 0x1819B36A0
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0x19B34B0 Offset: 0x19B1AB0 VA: 0x1819B34B0
	public int get_sortingLayerID() { }

	// RVA: 0x19B3720 Offset: 0x19B1D20 VA: 0x1819B3720
	public void set_sortingLayerID(int value) { }

	// RVA: 0x19B34F0 Offset: 0x19B1AF0 VA: 0x1819B34F0
	public int get_sortingOrder() { }

	// RVA: 0x19B3760 Offset: 0x19B1D60 VA: 0x1819B3760
	public void set_sortingOrder(int value) { }

	// RVA: 0x19B3390 Offset: 0x19B1990 VA: 0x1819B3390
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x19B2E00 Offset: 0x19B1400 VA: 0x1819B2E00
	private int GetMaterialCount() { }

	[NativeNameAttribute] // RVA: 0x903C0 Offset: 0x8F7C0 VA: 0x1800903C0
	// RVA: 0x19B2ED0 Offset: 0x19B14D0 VA: 0x1819B2ED0
	private Material[] GetSharedMaterialArray() { }

	// RVA: 0x19B2DC0 Offset: 0x19B13C0 VA: 0x1819B2DC0
	public Material[] get_materials() { }

	// RVA: 0x19B3130 Offset: 0x19B1730 VA: 0x1819B3130
	public void set_materials(Material[] value) { }

	// RVA: 0x19B2E40 Offset: 0x19B1440 VA: 0x1819B2E40
	public Material get_material() { }

	// RVA: 0x19B3180 Offset: 0x19B1780 VA: 0x1819B3180
	public void set_material(Material value) { }

	// RVA: 0x19B2F10 Offset: 0x19B1510 VA: 0x1819B2F10
	public Material get_sharedMaterial() { }

	// RVA: 0x19B3180 Offset: 0x19B1780 VA: 0x1819B3180
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x19B2ED0 Offset: 0x19B14D0 VA: 0x1819B2ED0
	public Material[] get_sharedMaterials() { }

	// RVA: 0x19B3130 Offset: 0x19B1730 VA: 0x1819B3130
	public void set_sharedMaterials(Material[] value) { }

	// RVA: 0x19B2F50 Offset: 0x19B1550 VA: 0x1819B2F50
	public void GetSharedMaterials(List<Material> m) { }

	// RVA: 0x19B31D0 Offset: 0x19B17D0 VA: 0x1819B31D0
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x19B3340 Offset: 0x19B1940 VA: 0x1819B3340
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

}

