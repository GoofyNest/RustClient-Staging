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

	// RVA: 0x19A0C80 Offset: 0x199F280 VA: 0x1819A0C80
	public void set_motionVectors(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x8F450 Offset: 0x8E850 VA: 0x18008F450
	// RVA: 0x19A08A0 Offset: 0x199EEA0 VA: 0x1819A08A0
	public Bounds get_bounds() { }

	[FreeFunctionAttribute] // RVA: 0x8F5F0 Offset: 0x8E9F0 VA: 0x18008F5F0
	// RVA: 0x19A04C0 Offset: 0x199EAC0 VA: 0x1819A04C0
	private Material GetMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F7E0 Offset: 0x8EBE0 VA: 0x18008F7E0
	// RVA: 0x19A0590 Offset: 0x199EB90 VA: 0x1819A0590
	private Material GetSharedMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x8F890 Offset: 0x8EC90 VA: 0x18008F890
	// RVA: 0x19A0800 Offset: 0x199EE00 VA: 0x1819A0800
	private void SetMaterial(Material m) { }

	[FreeFunctionAttribute] // RVA: 0x8FA20 Offset: 0x8EE20 VA: 0x18008FA20
	// RVA: 0x19A0440 Offset: 0x199EA40 VA: 0x1819A0440
	private Material[] GetMaterialArray() { }

	[FreeFunctionAttribute] // RVA: 0x8FAE0 Offset: 0x8EEE0 VA: 0x18008FAE0
	// RVA: 0x19A03F0 Offset: 0x199E9F0 VA: 0x1819A03F0
	private void CopySharedMaterialArray([Out] Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8FB80 Offset: 0x8EF80 VA: 0x18008FB80
	// RVA: 0x19A07B0 Offset: 0x199EDB0 VA: 0x1819A07B0
	private void SetMaterialArray(Material[] m) { }

	[FreeFunctionAttribute] // RVA: 0x8FE40 Offset: 0x8F240 VA: 0x18008FE40
	// RVA: 0x19A0760 Offset: 0x199ED60 VA: 0x1819A0760
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunctionAttribute] // RVA: 0x8FF00 Offset: 0x8F300 VA: 0x18008FF00
	// RVA: 0x19A0500 Offset: 0x199EB00 VA: 0x1819A0500
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	[FreeFunctionAttribute] // RVA: 0x901D0 Offset: 0x8F5D0 VA: 0x1800901D0
	// RVA: 0x19A0700 Offset: 0x199ED00 VA: 0x1819A0700
	internal void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex) { }

	[FreeFunctionAttribute] // RVA: 0x90240 Offset: 0x8F640 VA: 0x180090240
	// RVA: 0x19A06C0 Offset: 0x199ECC0 VA: 0x1819A06C0
	public bool HasPropertyBlock() { }

	// RVA: 0x19A0760 Offset: 0x199ED60 VA: 0x1819A0760
	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x19A0700 Offset: 0x199ED00 VA: 0x1819A0700
	public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex) { }

	// RVA: 0x19A0500 Offset: 0x199EB00 VA: 0x1819A0500
	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x19A0900 Offset: 0x199EF00 VA: 0x1819A0900
	public bool get_enabled() { }

	// RVA: 0x19A0BB0 Offset: 0x199F1B0 VA: 0x1819A0BB0
	public void set_enabled(bool value) { }

	[NativeNameAttribute] // RVA: 0x90370 Offset: 0x8F770 VA: 0x180090370
	// RVA: 0x19A0940 Offset: 0x199EF40 VA: 0x1819A0940
	public bool get_isVisible() { }

	// RVA: 0x19A0AF0 Offset: 0x199F0F0 VA: 0x1819A0AF0
	public ShadowCastingMode get_shadowCastingMode() { }

	// RVA: 0x19A0D60 Offset: 0x199F360 VA: 0x1819A0D60
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x19A0AB0 Offset: 0x199F0B0 VA: 0x1819A0AB0
	public bool get_receiveShadows() { }

	// RVA: 0x19A0CD0 Offset: 0x199F2D0 VA: 0x1819A0CD0
	public void set_receiveShadows(bool value) { }

	// RVA: 0x19A0A70 Offset: 0x199F070 VA: 0x1819A0A70
	public MotionVectorGenerationMode get_motionVectorGenerationMode() { }

	// RVA: 0x19A0C40 Offset: 0x199F240 VA: 0x1819A0C40
	public void set_motionVectorGenerationMode(MotionVectorGenerationMode value) { }

	// RVA: 0x19A0980 Offset: 0x199EF80 VA: 0x1819A0980
	public LightProbeUsage get_lightProbeUsage() { }

	// RVA: 0x19A0C00 Offset: 0x199F200 VA: 0x1819A0C00
	public void set_lightProbeUsage(LightProbeUsage value) { }

	// RVA: 0x19A0D20 Offset: 0x199F320 VA: 0x1819A0D20
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0x19A0B30 Offset: 0x199F130 VA: 0x1819A0B30
	public int get_sortingLayerID() { }

	// RVA: 0x19A0DA0 Offset: 0x199F3A0 VA: 0x1819A0DA0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x19A0B70 Offset: 0x199F170 VA: 0x1819A0B70
	public int get_sortingOrder() { }

	// RVA: 0x19A0DE0 Offset: 0x199F3E0 VA: 0x1819A0DE0
	public void set_sortingOrder(int value) { }

	// RVA: 0x19A0A10 Offset: 0x199F010 VA: 0x1819A0A10
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x19A0480 Offset: 0x199EA80 VA: 0x1819A0480
	private int GetMaterialCount() { }

	[NativeNameAttribute] // RVA: 0x90490 Offset: 0x8F890 VA: 0x180090490
	// RVA: 0x19A0550 Offset: 0x199EB50 VA: 0x1819A0550
	private Material[] GetSharedMaterialArray() { }

	// RVA: 0x19A0440 Offset: 0x199EA40 VA: 0x1819A0440
	public Material[] get_materials() { }

	// RVA: 0x19A07B0 Offset: 0x199EDB0 VA: 0x1819A07B0
	public void set_materials(Material[] value) { }

	// RVA: 0x19A04C0 Offset: 0x199EAC0 VA: 0x1819A04C0
	public Material get_material() { }

	// RVA: 0x19A0800 Offset: 0x199EE00 VA: 0x1819A0800
	public void set_material(Material value) { }

	// RVA: 0x19A0590 Offset: 0x199EB90 VA: 0x1819A0590
	public Material get_sharedMaterial() { }

	// RVA: 0x19A0800 Offset: 0x199EE00 VA: 0x1819A0800
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x19A0550 Offset: 0x199EB50 VA: 0x1819A0550
	public Material[] get_sharedMaterials() { }

	// RVA: 0x19A07B0 Offset: 0x199EDB0 VA: 0x1819A07B0
	public void set_sharedMaterials(Material[] value) { }

	// RVA: 0x19A05D0 Offset: 0x199EBD0 VA: 0x1819A05D0
	public void GetSharedMaterials(List<Material> m) { }

	// RVA: 0x19A0850 Offset: 0x199EE50 VA: 0x1819A0850
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x19A09C0 Offset: 0x199EFC0 VA: 0x1819A09C0
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

}

