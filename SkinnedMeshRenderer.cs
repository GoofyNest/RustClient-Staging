public class SkinnedMeshRenderer : Renderer // TypeDefIndex: 3436
{	public bool updateWhenOffscreen { get; set; }
	public Transform rootBone { get; set; }
	public Transform[] bones { get; set; }
	[NativePropertyAttribute] // RVA: 0x96700 Offset: 0x95B00 VA: 0x180096700
	public Mesh sharedMesh { get; set; }
	[NativePropertyAttribute] // RVA: 0x96780 Offset: 0x95B80 VA: 0x180096780
	public bool skinnedMotionVectors { get; set; }
	public Bounds localBounds { get; set; }


	public bool get_updateWhenOffscreen() { }

	public void set_updateWhenOffscreen(bool value) { }

	public Transform get_rootBone() { }

	public void set_rootBone(Transform value) { }

	public Transform[] get_bones() { }

	public void set_bones(Transform[] value) { }

	public Mesh get_sharedMesh() { }

	public void set_sharedMesh(Mesh value) { }

	public bool get_skinnedMotionVectors() { }

	public void set_skinnedMotionVectors(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x96680 Offset: 0x95A80 VA: 0x180096680
	private Bounds GetLocalAABB() { }

	private void SetLocalAABB(Bounds b) { }

	public Bounds get_localBounds() { }

	public void set_localBounds(Bounds value) { }

	private void GetLocalAABB_Injected(out Bounds ret) { }

	private void SetLocalAABB_Injected(ref Bounds b) { }

}

