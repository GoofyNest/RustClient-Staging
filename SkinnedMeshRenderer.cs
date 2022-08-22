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

	// RVA: 0x19B6640 Offset: 0x19B4C40 VA: 0x1819B6640
	public bool get_updateWhenOffscreen() { }

	// RVA: 0x19B6810 Offset: 0x19B4E10 VA: 0x1819B6810
	public void set_updateWhenOffscreen(bool value) { }

	// RVA: 0x19B6580 Offset: 0x19B4B80 VA: 0x1819B6580
	public Transform get_rootBone() { }

	// RVA: 0x19B6720 Offset: 0x19B4D20 VA: 0x1819B6720
	public void set_rootBone(Transform value) { }

	// RVA: 0x19B64D0 Offset: 0x19B4AD0 VA: 0x1819B64D0
	public Transform[] get_bones() { }

	// RVA: 0x19B6680 Offset: 0x19B4C80 VA: 0x1819B6680
	public void set_bones(Transform[] value) { }

	// RVA: 0x19B65C0 Offset: 0x19B4BC0 VA: 0x1819B65C0
	public Mesh get_sharedMesh() { }

	// RVA: 0x19B6770 Offset: 0x19B4D70 VA: 0x1819B6770
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x19B6600 Offset: 0x19B4C00 VA: 0x1819B6600
	public bool get_skinnedMotionVectors() { }

	// RVA: 0x19B67C0 Offset: 0x19B4DC0 VA: 0x1819B67C0
	public void set_skinnedMotionVectors(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x96580 Offset: 0x95980 VA: 0x180096580
	// RVA: 0x19B63D0 Offset: 0x19B49D0 VA: 0x1819B63D0
	private Bounds GetLocalAABB() { }

	// RVA: 0x19B6480 Offset: 0x19B4A80 VA: 0x1819B6480
	private void SetLocalAABB(Bounds b) { }

	// RVA: 0x19B6510 Offset: 0x19B4B10 VA: 0x1819B6510
	public Bounds get_localBounds() { }

	// RVA: 0x19B66D0 Offset: 0x19B4CD0 VA: 0x1819B66D0
	public void set_localBounds(Bounds value) { }

	// RVA: 0x19B6380 Offset: 0x19B4980 VA: 0x1819B6380
	private void GetLocalAABB_Injected(out Bounds ret) { }

	// RVA: 0x19B6430 Offset: 0x19B4A30 VA: 0x1819B6430
	private void SetLocalAABB_Injected(ref Bounds b) { }

}

