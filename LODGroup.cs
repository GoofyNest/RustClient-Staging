public class LODGroup : Component // TypeDefIndex: 3441
{	public Vector3 localReferencePoint { get; set; }
	public float size { get; set; }
	public LODFadeMode fadeMode { get; set; }
	public bool animateCrossFading { get; set; }
	public bool enabled { get; set; }


	public Vector3 get_localReferencePoint() { }

	public void set_localReferencePoint(Vector3 value) { }

	public float get_size() { }

	public void set_size(float value) { }

	public LODFadeMode get_fadeMode() { }

	public void set_fadeMode(LODFadeMode value) { }

	public bool get_animateCrossFading() { }

	public void set_animateCrossFading(bool value) { }

	public bool get_enabled() { }

	public void set_enabled(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x97000 Offset: 0x96400 VA: 0x180097000
	public void RecalculateBounds() { }

	[FreeFunctionAttribute] // RVA: 0x970F0 Offset: 0x964F0 VA: 0x1800970F0
	public LOD[] GetLODs() { }

	[FreeFunctionAttribute] // RVA: 0x97250 Offset: 0x96650 VA: 0x180097250
	public void SetLODs(LOD[] lods) { }

	private void get_localReferencePoint_Injected(out Vector3 ret) { }

	private void set_localReferencePoint_Injected(ref Vector3 value) { }

}

