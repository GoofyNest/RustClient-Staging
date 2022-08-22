public class LODGroup : Component // TypeDefIndex: 3441
{	// Properties
	public Vector3 localReferencePoint { get; set; }
	public float size { get; set; }
	public LODFadeMode fadeMode { get; set; }
	public bool animateCrossFading { get; set; }
	public bool enabled { get; set; }

	// Methods

	// RVA: 0x18E94E0 Offset: 0x18E7AE0 VA: 0x1818E94E0
	public Vector3 get_localReferencePoint() { }

	// RVA: 0x18E96A0 Offset: 0x18E7CA0 VA: 0x1818E96A0
	public void set_localReferencePoint(Vector3 value) { }

	// RVA: 0x18E9530 Offset: 0x18E7B30 VA: 0x1818E9530
	public float get_size() { }

	// RVA: 0x18E96F0 Offset: 0x18E7CF0 VA: 0x1818E96F0
	public void set_size(float value) { }

	// RVA: 0x18E9450 Offset: 0x18E7A50 VA: 0x1818E9450
	public LODFadeMode get_fadeMode() { }

	// RVA: 0x18E9610 Offset: 0x18E7C10 VA: 0x1818E9610
	public void set_fadeMode(LODFadeMode value) { }

	// RVA: 0x18E93D0 Offset: 0x18E79D0 VA: 0x1818E93D0
	public bool get_animateCrossFading() { }

	// RVA: 0x18E9570 Offset: 0x18E7B70 VA: 0x1818E9570
	public void set_animateCrossFading(bool value) { }

	// RVA: 0x18E9410 Offset: 0x18E7A10 VA: 0x1818E9410
	public bool get_enabled() { }

	// RVA: 0x18E95C0 Offset: 0x18E7BC0 VA: 0x1818E95C0
	public void set_enabled(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x97000 Offset: 0x96400 VA: 0x180097000
	// RVA: 0x18E9340 Offset: 0x18E7940 VA: 0x1818E9340
	public void RecalculateBounds() { }

	[FreeFunctionAttribute] // RVA: 0x970F0 Offset: 0x964F0 VA: 0x1800970F0
	// RVA: 0x18E9300 Offset: 0x18E7900 VA: 0x1818E9300
	public LOD[] GetLODs() { }

	[FreeFunctionAttribute] // RVA: 0x97250 Offset: 0x96650 VA: 0x180097250
	// RVA: 0x18E9380 Offset: 0x18E7980 VA: 0x1818E9380
	public void SetLODs(LOD[] lods) { }

	// RVA: 0x18E9490 Offset: 0x18E7A90 VA: 0x1818E9490
	private void get_localReferencePoint_Injected(out Vector3 ret) { }

	// RVA: 0x18E9650 Offset: 0x18E7C50 VA: 0x1818E9650
	private void set_localReferencePoint_Injected(ref Vector3 value) { }

}

