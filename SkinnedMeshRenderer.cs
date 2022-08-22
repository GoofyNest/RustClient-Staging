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

	// RVA: 0x19A3A40 Offset: 0x19A2040 VA: 0x1819A3A40
	public bool get_updateWhenOffscreen() { }

	// RVA: 0x19A3C10 Offset: 0x19A2210 VA: 0x1819A3C10
	public void set_updateWhenOffscreen(bool value) { }

	// RVA: 0x19A3980 Offset: 0x19A1F80 VA: 0x1819A3980
	public Transform get_rootBone() { }

	// RVA: 0x19A3B20 Offset: 0x19A2120 VA: 0x1819A3B20
	public void set_rootBone(Transform value) { }

	// RVA: 0x19A38D0 Offset: 0x19A1ED0 VA: 0x1819A38D0
	public Transform[] get_bones() { }

	// RVA: 0x19A3A80 Offset: 0x19A2080 VA: 0x1819A3A80
	public void set_bones(Transform[] value) { }

	// RVA: 0x19A39C0 Offset: 0x19A1FC0 VA: 0x1819A39C0
	public Mesh get_sharedMesh() { }

	// RVA: 0x19A3B70 Offset: 0x19A2170 VA: 0x1819A3B70
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x19A3A00 Offset: 0x19A2000 VA: 0x1819A3A00
	public bool get_skinnedMotionVectors() { }

	// RVA: 0x19A3BC0 Offset: 0x19A21C0 VA: 0x1819A3BC0
	public void set_skinnedMotionVectors(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x96580 Offset: 0x95980 VA: 0x180096580
	// RVA: 0x19A37D0 Offset: 0x19A1DD0 VA: 0x1819A37D0
	private Bounds GetLocalAABB() { }

	// RVA: 0x19A3880 Offset: 0x19A1E80 VA: 0x1819A3880
	private void SetLocalAABB(Bounds b) { }

	// RVA: 0x19A3910 Offset: 0x19A1F10 VA: 0x1819A3910
	public Bounds get_localBounds() { }

	// RVA: 0x19A3AD0 Offset: 0x19A20D0 VA: 0x1819A3AD0
	public void set_localBounds(Bounds value) { }

	// RVA: 0x19A3780 Offset: 0x19A1D80 VA: 0x1819A3780
	private void GetLocalAABB_Injected(out Bounds ret) { }

	// RVA: 0x19A3830 Offset: 0x19A1E30 VA: 0x1819A3830
	private void SetLocalAABB_Injected(ref Bounds b) { }

}

