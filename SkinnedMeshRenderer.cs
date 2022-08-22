public class SkinnedMeshRenderer : Renderer // TypeDefIndex: 3436
{	// Properties
	public bool updateWhenOffscreen { get; set; }
	public Transform rootBone { get; set; }
	public Transform[] bones { get; set; }
	[NativePropertyAttribute] // RVA: 0x965C0 Offset: 0x959C0 VA: 0x1800965C0
	public Mesh sharedMesh { get; set; }
	[NativePropertyAttribute] // RVA: 0x966B0 Offset: 0x95AB0 VA: 0x1800966B0
	public bool skinnedMotionVectors { get; set; }
	public Bounds localBounds { get; set; }

	// Methods

	// RVA: 0x19B6380 Offset: 0x19B4980 VA: 0x1819B6380
	public bool get_updateWhenOffscreen() { }

	// RVA: 0x19B6550 Offset: 0x19B4B50 VA: 0x1819B6550
	public void set_updateWhenOffscreen(bool value) { }

	// RVA: 0x19B62C0 Offset: 0x19B48C0 VA: 0x1819B62C0
	public Transform get_rootBone() { }

	// RVA: 0x19B6460 Offset: 0x19B4A60 VA: 0x1819B6460
	public void set_rootBone(Transform value) { }

	// RVA: 0x19B6210 Offset: 0x19B4810 VA: 0x1819B6210
	public Transform[] get_bones() { }

	// RVA: 0x19B63C0 Offset: 0x19B49C0 VA: 0x1819B63C0
	public void set_bones(Transform[] value) { }

	// RVA: 0x19B6300 Offset: 0x19B4900 VA: 0x1819B6300
	public Mesh get_sharedMesh() { }

	// RVA: 0x19B64B0 Offset: 0x19B4AB0 VA: 0x1819B64B0
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x19B6340 Offset: 0x19B4940 VA: 0x1819B6340
	public bool get_skinnedMotionVectors() { }

	// RVA: 0x19B6500 Offset: 0x19B4B00 VA: 0x1819B6500
	public void set_skinnedMotionVectors(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x96580 Offset: 0x95980 VA: 0x180096580
	// RVA: 0x19B6110 Offset: 0x19B4710 VA: 0x1819B6110
	private Bounds GetLocalAABB() { }

	// RVA: 0x19B61C0 Offset: 0x19B47C0 VA: 0x1819B61C0
	private void SetLocalAABB(Bounds b) { }

	// RVA: 0x19B6250 Offset: 0x19B4850 VA: 0x1819B6250
	public Bounds get_localBounds() { }

	// RVA: 0x19B6410 Offset: 0x19B4A10 VA: 0x1819B6410
	public void set_localBounds(Bounds value) { }

	// RVA: 0x19B60C0 Offset: 0x19B46C0 VA: 0x1819B60C0
	private void GetLocalAABB_Injected(out Bounds ret) { }

	// RVA: 0x19B6170 Offset: 0x19B4770 VA: 0x1819B6170
	private void SetLocalAABB_Injected(ref Bounds b) { }

}

