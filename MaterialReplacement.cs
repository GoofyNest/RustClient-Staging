public class MaterialReplacement : MonoBehaviour // TypeDefIndex: 6584
{	// Fields
	private bool initialized; // 0x18
	public Material[] Default; // 0x20
	public Material[] Override; // 0x28
	public Renderer Renderer; // 0x30

	// Methods

	// RVA: 0x1BA55F0 Offset: 0x1BA3BF0 VA: 0x181BA55F0
	public static void ReplaceRecursive(GameObject go, Material mat) { }

	// RVA: 0x1BA57F0 Offset: 0x1BA3DF0 VA: 0x181BA57F0
	public static void ReplaceRecursive(GameObject obj, Material[] find, Material[] replace) { }

	// RVA: 0x1BA5420 Offset: 0x1BA3A20 VA: 0x181BA5420
	public static void Prepare(GameObject go) { }

	// RVA: 0x1BA5370 Offset: 0x1BA3970 VA: 0x181BA5370
	private static bool MaterialsContainAny(Material[] source, Material[] find) { }

	// RVA: 0x1BA6090 Offset: 0x1BA4690 VA: 0x181BA6090
	public static void Reset(GameObject go) { }

	// RVA: 0x1BA52A0 Offset: 0x1BA38A0 VA: 0x181BA52A0
	private void Init() { }

	// RVA: 0x1BA5B90 Offset: 0x1BA4190 VA: 0x181BA5B90
	private void Replace(Material mat) { }

	// RVA: 0x1BA5F20 Offset: 0x1BA4520 VA: 0x181BA5F20
	private void Replace(Material find, Material replace) { }

	// RVA: 0x1BA5CB0 Offset: 0x1BA42B0 VA: 0x181BA5CB0
	private void Replace(Material[] find, Material[] replace) { }

	// RVA: 0x1BA6250 Offset: 0x1BA4850 VA: 0x181BA6250
	private void Revert() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

