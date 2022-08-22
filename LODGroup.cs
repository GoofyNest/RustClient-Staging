public class LODGroup : Component // TypeDefIndex: 3441
{	// Properties
	public Vector3 localReferencePoint { get; set; }
	public float size { get; set; }
	public LODFadeMode fadeMode { get; set; }
	public bool animateCrossFading { get; set; }
	public bool enabled { get; set; }

	// Methods

	// RVA: 0x18E9B00 Offset: 0x18E8100 VA: 0x1818E9B00
	public Vector3 get_localReferencePoint() { }

	// RVA: 0x18E9CC0 Offset: 0x18E82C0 VA: 0x1818E9CC0
	public void set_localReferencePoint(Vector3 value) { }

	// RVA: 0x18E9B50 Offset: 0x18E8150 VA: 0x1818E9B50
	public float get_size() { }

	// RVA: 0x18E9D10 Offset: 0x18E8310 VA: 0x1818E9D10
	public void set_size(float value) { }

	// RVA: 0x18E9A70 Offset: 0x18E8070 VA: 0x1818E9A70
	public LODFadeMode get_fadeMode() { }

	// RVA: 0x18E9C30 Offset: 0x18E8230 VA: 0x1818E9C30
	public void set_fadeMode(LODFadeMode value) { }

	// RVA: 0x18E99F0 Offset: 0x18E7FF0 VA: 0x1818E99F0
	public bool get_animateCrossFading() { }

	// RVA: 0x18E9B90 Offset: 0x18E8190 VA: 0x1818E9B90
	public void set_animateCrossFading(bool value) { }

	// RVA: 0x18E9A30 Offset: 0x18E8030 VA: 0x1818E9A30
	public bool get_enabled() { }

	// RVA: 0x18E9BE0 Offset: 0x18E81E0 VA: 0x1818E9BE0
	public void set_enabled(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x97000 Offset: 0x96400 VA: 0x180097000
	// RVA: 0x18E9960 Offset: 0x18E7F60 VA: 0x1818E9960
	public void RecalculateBounds() { }

	[FreeFunctionAttribute] // RVA: 0x970F0 Offset: 0x964F0 VA: 0x1800970F0
	// RVA: 0x18E9920 Offset: 0x18E7F20 VA: 0x1818E9920
	public LOD[] GetLODs() { }

	[FreeFunctionAttribute] // RVA: 0x97250 Offset: 0x96650 VA: 0x180097250
	// RVA: 0x18E99A0 Offset: 0x18E7FA0 VA: 0x1818E99A0
	public void SetLODs(LOD[] lods) { }

	// RVA: 0x18E9AB0 Offset: 0x18E80B0 VA: 0x1818E9AB0
	private void get_localReferencePoint_Injected(out Vector3 ret) { }

	// RVA: 0x18E9C70 Offset: 0x18E8270 VA: 0x1818E9C70
	private void set_localReferencePoint_Injected(ref Vector3 value) { }

}

