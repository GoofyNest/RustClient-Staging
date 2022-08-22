public class LODManager : SingletonComponent<LODManager> // TypeDefIndex: 9936
{	// Fields
	public float MaxMilliseconds; // 0x18
	private ListHashSet<ILOD> members; // 0x20
	private Stopwatch watch; // 0x28
	private int offset; // 0x30

	// Methods

	// RVA: 0x686130 Offset: 0x684730 VA: 0x180686130
	protected void LateUpdate() { }

	// RVA: 0x686030 Offset: 0x684630 VA: 0x180686030
	public static void Add(ILOD component, Transform transform) { }

	// RVA: 0x686280 Offset: 0x684880 VA: 0x180686280
	public static void Remove(ILOD component, Transform transform) { }

	// RVA: 0x6863B0 Offset: 0x6849B0 VA: 0x1806863B0
	public void .ctor() { }

}

