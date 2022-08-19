public class LODManager : SingletonComponent<LODManager> // TypeDefIndex: 9936
{	// Fields
	public float MaxMilliseconds; // 0x18
	private ListHashSet<ILOD> members; // 0x20
	private Stopwatch watch; // 0x28
	private int offset; // 0x30

	// Methods

	// RVA: 0x6861A0 Offset: 0x6847A0 VA: 0x1806861A0
	protected void LateUpdate() { }

	// RVA: 0x6860A0 Offset: 0x6846A0 VA: 0x1806860A0
	public static void Add(ILOD component, Transform transform) { }

	// RVA: 0x6862F0 Offset: 0x6848F0 VA: 0x1806862F0
	public static void Remove(ILOD component, Transform transform) { }

	// RVA: 0x686420 Offset: 0x684A20 VA: 0x180686420
	public void .ctor() { }

}

