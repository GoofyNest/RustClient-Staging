public class MaterialReplacement : MonoBehaviour // TypeDefIndex: 6584
{	// Fields
	private bool initialized; // 0x18
	public Material[] Default; // 0x20
	public Material[] Override; // 0x28
	public Renderer Renderer; // 0x30

	// Methods

	// RVA: 0x1BA4B40 Offset: 0x1BA3140 VA: 0x181BA4B40
	public static void ReplaceRecursive(GameObject go, Material mat) { }

	// RVA: 0x1BA4D40 Offset: 0x1BA3340 VA: 0x181BA4D40
	public static void ReplaceRecursive(GameObject obj, Material[] find, Material[] replace) { }

	// RVA: 0x1BA4970 Offset: 0x1BA2F70 VA: 0x181BA4970
	public static void Prepare(GameObject go) { }

	// RVA: 0x1BA48C0 Offset: 0x1BA2EC0 VA: 0x181BA48C0
	private static bool MaterialsContainAny(Material[] source, Material[] find) { }

	// RVA: 0x1BA55E0 Offset: 0x1BA3BE0 VA: 0x181BA55E0
	public static void Reset(GameObject go) { }

	// RVA: 0x1BA47F0 Offset: 0x1BA2DF0 VA: 0x181BA47F0
	private void Init() { }

	// RVA: 0x1BA50E0 Offset: 0x1BA36E0 VA: 0x181BA50E0
	private void Replace(Material mat) { }

	// RVA: 0x1BA5470 Offset: 0x1BA3A70 VA: 0x181BA5470
	private void Replace(Material find, Material replace) { }

	// RVA: 0x1BA5200 Offset: 0x1BA3800 VA: 0x181BA5200
	private void Replace(Material[] find, Material[] replace) { }

	// RVA: 0x1BA57A0 Offset: 0x1BA3DA0 VA: 0x181BA57A0
	private void Revert() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

