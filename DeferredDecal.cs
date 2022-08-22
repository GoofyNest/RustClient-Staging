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
	// RVA: 0x847230 Offset: 0x845830 VA: 0x180847230
	public bool get_IsDecalEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x847360 Offset: 0x845960 VA: 0x180847360
	private void set_IsDecalEnabled(bool value) { }

	// RVA: 0x847240 Offset: 0x845840 VA: 0x180847240
	public Matrix4x4 get_matrix() { }

	// RVA: 0x8471B0 Offset: 0x8457B0 VA: 0x1808471B0
	protected void OnEnable() { }

	// RVA: 0x8470F0 Offset: 0x8456F0 VA: 0x1808470F0
	protected void OnDisable() { }

	// RVA: 0x8470F0 Offset: 0x8456F0 VA: 0x1808470F0
	public void DisableDecal() { }

	// RVA: 0x847150 Offset: 0x845750 VA: 0x180847150
	public void EnableDecal() { }

	// RVA: 0x847220 Offset: 0x845820 VA: 0x180847220
	public void .ctor() { }

}

