public class DeferredDecal : MonoBehaviour // TypeDefIndex: 10649
{	// Fields
	public Mesh mesh; // 0x18
	public Material material; // 0x20
	public DeferredDecalQueue queue; // 0x28
	public bool applyImmediately; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsDecalEnabled>k__BackingField; // 0x2D
	private bool cached; // 0x2E
	private Matrix4x4 localToWorldMatrix; // 0x30

	// Properties
	public bool IsDecalEnabled { get; set; }
	public Matrix4x4 matrix { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x847780 Offset: 0x845D80 VA: 0x180847780
	public bool get_IsDecalEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8478B0 Offset: 0x845EB0 VA: 0x1808478B0
	private void set_IsDecalEnabled(bool value) { }

	// RVA: 0x847790 Offset: 0x845D90 VA: 0x180847790
	public Matrix4x4 get_matrix() { }

	// RVA: 0x847700 Offset: 0x845D00 VA: 0x180847700
	protected void OnEnable() { }

	// RVA: 0x847640 Offset: 0x845C40 VA: 0x180847640
	protected void OnDisable() { }

	// RVA: 0x847640 Offset: 0x845C40 VA: 0x180847640
	public void DisableDecal() { }

	// RVA: 0x8476A0 Offset: 0x845CA0 VA: 0x1808476A0
	public void EnableDecal() { }

	// RVA: 0x847770 Offset: 0x845D70 VA: 0x180847770
	public void .ctor() { }

}

