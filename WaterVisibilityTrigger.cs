public class WaterVisibilityTrigger : EnvironmentVolumeTrigger // TypeDefIndex: 10634
{	// Fields
	public bool togglePhysics; // 0x38
	public bool toggleVisuals; // 0x39
	private long enteredTick; // 0x40
	private static long ticks; // 0x0
	private static SortedList<long, WaterVisibilityTrigger> tracker; // 0x8

	// Methods

	// RVA: 0x8EF570 Offset: 0x8EDB70 VA: 0x1808EF570
	public static void Reset() { }

	// RVA: 0x8EE900 Offset: 0x8ECF00 VA: 0x1808EE900
	protected void OnDestroy() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10
	private int GetVisibilityMask() { }

	// RVA: 0x8EF7A0 Offset: 0x8EDDA0 VA: 0x1808EF7A0
	private void ToggleVisibility() { }

	// RVA: 0x8EF400 Offset: 0x8EDA00 VA: 0x1808EF400
	private void ResetVisibility() { }

	// RVA: 0x8EF600 Offset: 0x8EDC00 VA: 0x1808EF600
	private void ToggleCollision(Collider other) { }

	// RVA: 0x8EF260 Offset: 0x8ED860 VA: 0x1808EF260
	private void ResetCollision(Collider other) { }

	// RVA: 0x8EE9C0 Offset: 0x8ECFC0 VA: 0x1808EE9C0
	protected void OnTriggerEnter(Collider other) { }

	// RVA: 0x8EECE0 Offset: 0x8ED2E0 VA: 0x1808EECE0
	protected void OnTriggerExit(Collider other) { }

	// RVA: 0x8EF990 Offset: 0x8EDF90 VA: 0x1808EF990
	public void .ctor() { }

	// RVA: 0x8EF910 Offset: 0x8EDF10 VA: 0x1808EF910
	private static void .cctor() { }

}

