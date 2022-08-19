public class MaterialReplacement : MonoBehaviour // TypeDefIndex: 6584
{	// Fields
	private bool initialized; // 0x18
	public Material[] Default; // 0x20
	public Material[] Override; // 0x28
	public Renderer Renderer; // 0x30

	// Methods

	// RVA: 0x1BA4D00 Offset: 0x1BA3300 VA: 0x181BA4D00
	public static void ReplaceRecursive(GameObject go, Material mat) { }

	// RVA: 0x1BA4F00 Offset: 0x1BA3500 VA: 0x181BA4F00
	public static void ReplaceRecursive(GameObject obj, Material[] find, Material[] replace) { }

	// RVA: 0x1BA4B30 Offset: 0x1BA3130 VA: 0x181BA4B30
	public static void Prepare(GameObject go) { }

	// RVA: 0x1BA4A80 Offset: 0x1BA3080 VA: 0x181BA4A80
	private static bool MaterialsContainAny(Material[] source, Material[] find) { }

	// RVA: 0x1BA57A0 Offset: 0x1BA3DA0 VA: 0x181BA57A0
	public static void Reset(GameObject go) { }

	// RVA: 0x1BA49B0 Offset: 0x1BA2FB0 VA: 0x181BA49B0
	private void Init() { }

	// RVA: 0x1BA52A0 Offset: 0x1BA38A0 VA: 0x181BA52A0
	private void Replace(Material mat) { }

	// RVA: 0x1BA5630 Offset: 0x1BA3C30 VA: 0x181BA5630
	private void Replace(Material find, Material replace) { }

	// RVA: 0x1BA53C0 Offset: 0x1BA39C0 VA: 0x181BA53C0
	private void Replace(Material[] find, Material[] replace) { }

	// RVA: 0x1BA5960 Offset: 0x1BA3F60 VA: 0x181BA5960
	private void Revert() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

