public class DeferredDecal : MonoBehaviour // TypeDefIndex: 10653
{	public Mesh mesh; // 0x18
	public Material material; // 0x20
	public DeferredDecalQueue queue; // 0x28
	public bool applyImmediately; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool <IsDecalEnabled>k__BackingField; // 0x2D
	private bool cached; // 0x2E
	private Matrix4x4 localToWorldMatrix; // 0x30

	public bool IsDecalEnabled { get; set; }
	public Matrix4x4 matrix { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_IsDecalEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_IsDecalEnabled(bool value) { }

	public Matrix4x4 get_matrix() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	public void DisableDecal() { }

	public void EnableDecal() { }

	public void .ctor() { }

}

