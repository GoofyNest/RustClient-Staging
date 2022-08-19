public class LODGroup : Component // TypeDefIndex: 3441
{	// Properties
	public Vector3 localReferencePoint { get; set; }
	public float size { get; set; }
	public LODFadeMode fadeMode { get; set; }
	public bool animateCrossFading { get; set; }
	public bool enabled { get; set; }

	// Methods

	// RVA: 0x18E9B40 Offset: 0x18E8140 VA: 0x1818E9B40
	public Vector3 get_localReferencePoint() { }

	// RVA: 0x18E9D00 Offset: 0x18E8300 VA: 0x1818E9D00
	public void set_localReferencePoint(Vector3 value) { }

	// RVA: 0x18E9B90 Offset: 0x18E8190 VA: 0x1818E9B90
	public float get_size() { }

	// RVA: 0x18E9D50 Offset: 0x18E8350 VA: 0x1818E9D50
	public void set_size(float value) { }

	// RVA: 0x18E9AB0 Offset: 0x18E80B0 VA: 0x1818E9AB0
	public LODFadeMode get_fadeMode() { }

	// RVA: 0x18E9C70 Offset: 0x18E8270 VA: 0x1818E9C70
	public void set_fadeMode(LODFadeMode value) { }

	// RVA: 0x18E9A30 Offset: 0x18E8030 VA: 0x1818E9A30
	public bool get_animateCrossFading() { }

	// RVA: 0x18E9BD0 Offset: 0x18E81D0 VA: 0x1818E9BD0
	public void set_animateCrossFading(bool value) { }

	// RVA: 0x18E9A70 Offset: 0x18E8070 VA: 0x1818E9A70
	public bool get_enabled() { }

	// RVA: 0x18E9C20 Offset: 0x18E8220 VA: 0x1818E9C20
	public void set_enabled(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x96F40 Offset: 0x96340 VA: 0x180096F40
	// RVA: 0x18E99A0 Offset: 0x18E7FA0 VA: 0x1818E99A0
	public void RecalculateBounds() { }

	[FreeFunctionAttribute] // RVA: 0x970A0 Offset: 0x964A0 VA: 0x1800970A0
	// RVA: 0x18E9960 Offset: 0x18E7F60 VA: 0x1818E9960
	public LOD[] GetLODs() { }

	[FreeFunctionAttribute] // RVA: 0x971D0 Offset: 0x965D0 VA: 0x1800971D0
	// RVA: 0x18E99E0 Offset: 0x18E7FE0 VA: 0x1818E99E0
	public void SetLODs(LOD[] lods) { }

	// RVA: 0x18E9AF0 Offset: 0x18E80F0 VA: 0x1818E9AF0
	private void get_localReferencePoint_Injected(out Vector3 ret) { }

	// RVA: 0x18E9CB0 Offset: 0x18E82B0 VA: 0x1818E9CB0
	private void set_localReferencePoint_Injected(ref Vector3 value) { }

}

