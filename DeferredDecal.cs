public class DeferredDecal : MonoBehaviour // TypeDefIndex: 10649
{	// Fields
	public Mesh mesh; // 0x18
	public Material material; // 0x20
	public DeferredDecalQueue queue; // 0x28
	public bool applyImmediately; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IsDecalEnabled>k__BackingField; // 0x2D
	private bool cached; // 0x2E
	private Matrix4x4 localToWorldMatrix; // 0x30

	// Properties
	public bool IsDecalEnabled { get; set; }
	public Matrix4x4 matrix { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x847120 Offset: 0x845720 VA: 0x180847120
	public bool get_IsDecalEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x847250 Offset: 0x845850 VA: 0x180847250
	private void set_IsDecalEnabled(bool value) { }

	// RVA: 0x847130 Offset: 0x845730 VA: 0x180847130
	public Matrix4x4 get_matrix() { }

	// RVA: 0x8470A0 Offset: 0x8456A0 VA: 0x1808470A0
	protected void OnEnable() { }

	// RVA: 0x846FE0 Offset: 0x8455E0 VA: 0x180846FE0
	protected void OnDisable() { }

	// RVA: 0x846FE0 Offset: 0x8455E0 VA: 0x180846FE0
	public void DisableDecal() { }

	// RVA: 0x847040 Offset: 0x845640 VA: 0x180847040
	public void EnableDecal() { }

	// RVA: 0x847110 Offset: 0x845710 VA: 0x180847110
	public void .ctor() { }

}

