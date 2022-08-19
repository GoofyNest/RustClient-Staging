public class SkinnedMeshRenderer : Renderer // TypeDefIndex: 3436
{	// Properties
	public bool updateWhenOffscreen { get; set; }
	public Transform rootBone { get; set; }
	public Transform[] bones { get; set; }
	[NativePropertyAttribute] // RVA: 0x96540 Offset: 0x95940 VA: 0x180096540
	public Mesh sharedMesh { get; set; }
	[NativePropertyAttribute] // RVA: 0x96630 Offset: 0x95A30 VA: 0x180096630
	public bool skinnedMotionVectors { get; set; }
	public Bounds localBounds { get; set; }

	// Methods

	// RVA: 0x19B63C0 Offset: 0x19B49C0 VA: 0x1819B63C0
	public bool get_updateWhenOffscreen() { }

	// RVA: 0x19B6590 Offset: 0x19B4B90 VA: 0x1819B6590
	public void set_updateWhenOffscreen(bool value) { }

	// RVA: 0x19B6300 Offset: 0x19B4900 VA: 0x1819B6300
	public Transform get_rootBone() { }

	// RVA: 0x19B64A0 Offset: 0x19B4AA0 VA: 0x1819B64A0
	public void set_rootBone(Transform value) { }

	// RVA: 0x19B6250 Offset: 0x19B4850 VA: 0x1819B6250
	public Transform[] get_bones() { }

	// RVA: 0x19B6400 Offset: 0x19B4A00 VA: 0x1819B6400
	public void set_bones(Transform[] value) { }

	// RVA: 0x19B6340 Offset: 0x19B4940 VA: 0x1819B6340
	public Mesh get_sharedMesh() { }

	// RVA: 0x19B64F0 Offset: 0x19B4AF0 VA: 0x1819B64F0
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x19B6380 Offset: 0x19B4980 VA: 0x1819B6380
	public bool get_skinnedMotionVectors() { }

	// RVA: 0x19B6540 Offset: 0x19B4B40 VA: 0x1819B6540
	public void set_skinnedMotionVectors(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x964D0 Offset: 0x958D0 VA: 0x1800964D0
	// RVA: 0x19B6150 Offset: 0x19B4750 VA: 0x1819B6150
	private Bounds GetLocalAABB() { }

	// RVA: 0x19B6200 Offset: 0x19B4800 VA: 0x1819B6200
	private void SetLocalAABB(Bounds b) { }

	// RVA: 0x19B6290 Offset: 0x19B4890 VA: 0x1819B6290
	public Bounds get_localBounds() { }

	// RVA: 0x19B6450 Offset: 0x19B4A50 VA: 0x1819B6450
	public void set_localBounds(Bounds value) { }

	// RVA: 0x19B6100 Offset: 0x19B4700 VA: 0x1819B6100
	private void GetLocalAABB_Injected(out Bounds ret) { }

	// RVA: 0x19B61B0 Offset: 0x19B47B0 VA: 0x1819B61B0
	private void SetLocalAABB_Injected(ref Bounds b) { }

}

