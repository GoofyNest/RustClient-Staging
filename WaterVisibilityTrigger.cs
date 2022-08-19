public class WaterVisibilityTrigger : EnvironmentVolumeTrigger // TypeDefIndex: 10634
{	// Fields
	public bool togglePhysics; // 0x38
	public bool toggleVisuals; // 0x39
	private long enteredTick; // 0x40
	private static long ticks; // 0x0
	private static SortedList<long, WaterVisibilityTrigger> tracker; // 0x8

	// Methods

	// RVA: 0x8EF460 Offset: 0x8EDA60 VA: 0x1808EF460
	public static void Reset() { }

	// RVA: 0x8EE7F0 Offset: 0x8ECDF0 VA: 0x1808EE7F0
	protected void OnDestroy() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	private int GetVisibilityMask() { }

	// RVA: 0x8EF690 Offset: 0x8EDC90 VA: 0x1808EF690
	private void ToggleVisibility() { }

	// RVA: 0x8EF2F0 Offset: 0x8ED8F0 VA: 0x1808EF2F0
	private void ResetVisibility() { }

	// RVA: 0x8EF4F0 Offset: 0x8EDAF0 VA: 0x1808EF4F0
	private void ToggleCollision(Collider other) { }

	// RVA: 0x8EF150 Offset: 0x8ED750 VA: 0x1808EF150
	private void ResetCollision(Collider other) { }

	// RVA: 0x8EE8B0 Offset: 0x8ECEB0 VA: 0x1808EE8B0
	protected void OnTriggerEnter(Collider other) { }

	// RVA: 0x8EEBD0 Offset: 0x8ED1D0 VA: 0x1808EEBD0
	protected void OnTriggerExit(Collider other) { }

	// RVA: 0x8EF880 Offset: 0x8EDE80 VA: 0x1808EF880
	public void .ctor() { }

	// RVA: 0x8EF800 Offset: 0x8EDE00 VA: 0x1808EF800
	private static void .cctor() { }

}

