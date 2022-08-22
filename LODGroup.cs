public class LODGroup : Component // TypeDefIndex: 3441
{	// Properties
	public Vector3 localReferencePoint { get; set; }
	public float size { get; set; }
	public LODFadeMode fadeMode { get; set; }
	public bool animateCrossFading { get; set; }
	public bool enabled { get; set; }

	// Methods

	// RVA: 0x18E9DC0 Offset: 0x18E83C0 VA: 0x1818E9DC0
	public Vector3 get_localReferencePoint() { }

	// RVA: 0x18E9F80 Offset: 0x18E8580 VA: 0x1818E9F80
	public void set_localReferencePoint(Vector3 value) { }

	// RVA: 0x18E9E10 Offset: 0x18E8410 VA: 0x1818E9E10
	public float get_size() { }

	// RVA: 0x18E9FD0 Offset: 0x18E85D0 VA: 0x1818E9FD0
	public void set_size(float value) { }

	// RVA: 0x18E9D30 Offset: 0x18E8330 VA: 0x1818E9D30
	public LODFadeMode get_fadeMode() { }

	// RVA: 0x18E9EF0 Offset: 0x18E84F0 VA: 0x1818E9EF0
	public void set_fadeMode(LODFadeMode value) { }

	// RVA: 0x18E9CB0 Offset: 0x18E82B0 VA: 0x1818E9CB0
	public bool get_animateCrossFading() { }

	// RVA: 0x18E9E50 Offset: 0x18E8450 VA: 0x1818E9E50
	public void set_animateCrossFading(bool value) { }

	// RVA: 0x18E9CF0 Offset: 0x18E82F0 VA: 0x1818E9CF0
	public bool get_enabled() { }

	// RVA: 0x18E9EA0 Offset: 0x18E84A0 VA: 0x1818E9EA0
	public void set_enabled(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x97000 Offset: 0x96400 VA: 0x180097000
	// RVA: 0x18E9C20 Offset: 0x18E8220 VA: 0x1818E9C20
	public void RecalculateBounds() { }

	[FreeFunctionAttribute] // RVA: 0x970F0 Offset: 0x964F0 VA: 0x1800970F0
	// RVA: 0x18E9BE0 Offset: 0x18E81E0 VA: 0x1818E9BE0
	public LOD[] GetLODs() { }

	[FreeFunctionAttribute] // RVA: 0x97250 Offset: 0x96650 VA: 0x180097250
	// RVA: 0x18E9C60 Offset: 0x18E8260 VA: 0x1818E9C60
	public void SetLODs(LOD[] lods) { }

	// RVA: 0x18E9D70 Offset: 0x18E8370 VA: 0x1818E9D70
	private void get_localReferencePoint_Injected(out Vector3 ret) { }

	// RVA: 0x18E9F30 Offset: 0x18E8530 VA: 0x1818E9F30
	private void set_localReferencePoint_Injected(ref Vector3 value) { }

}

