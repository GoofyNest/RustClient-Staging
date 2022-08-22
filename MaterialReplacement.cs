public class MaterialReplacement : MonoBehaviour // TypeDefIndex: 6584
{	// Fields
	private bool initialized; // 0x18
	public Material[] Default; // 0x20
	public Material[] Override; // 0x28
	public Renderer Renderer; // 0x30

	// Methods

	// RVA: 0x1BA4E00 Offset: 0x1BA3400 VA: 0x181BA4E00
	public static void ReplaceRecursive(GameObject go, Material mat) { }

	// RVA: 0x1BA5000 Offset: 0x1BA3600 VA: 0x181BA5000
	public static void ReplaceRecursive(GameObject obj, Material[] find, Material[] replace) { }

	// RVA: 0x1BA4C30 Offset: 0x1BA3230 VA: 0x181BA4C30
	public static void Prepare(GameObject go) { }

	// RVA: 0x1BA4B80 Offset: 0x1BA3180 VA: 0x181BA4B80
	private static bool MaterialsContainAny(Material[] source, Material[] find) { }

	// RVA: 0x1BA58A0 Offset: 0x1BA3EA0 VA: 0x181BA58A0
	public static void Reset(GameObject go) { }

	// RVA: 0x1BA4AB0 Offset: 0x1BA30B0 VA: 0x181BA4AB0
	private void Init() { }

	// RVA: 0x1BA53A0 Offset: 0x1BA39A0 VA: 0x181BA53A0
	private void Replace(Material mat) { }

	// RVA: 0x1BA5730 Offset: 0x1BA3D30 VA: 0x181BA5730
	private void Replace(Material find, Material replace) { }

	// RVA: 0x1BA54C0 Offset: 0x1BA3AC0 VA: 0x181BA54C0
	private void Replace(Material[] find, Material[] replace) { }

	// RVA: 0x1BA5A60 Offset: 0x1BA4060 VA: 0x181BA5A60
	private void Revert() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

