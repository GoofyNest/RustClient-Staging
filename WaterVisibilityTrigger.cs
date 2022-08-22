public class WaterVisibilityTrigger : EnvironmentVolumeTrigger // TypeDefIndex: 10634
{	// Fields
	public bool togglePhysics; // 0x38
	public bool toggleVisuals; // 0x39
	private long enteredTick; // 0x40
	private static long ticks; // 0x0
	private static SortedList<long, WaterVisibilityTrigger> tracker; // 0x8

	// Methods

	// RVA: 0x8EFA80 Offset: 0x8EE080 VA: 0x1808EFA80
	public static void Reset() { }

	// RVA: 0x8EEE10 Offset: 0x8ED410 VA: 0x1808EEE10
	protected void OnDestroy() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0
	private int GetVisibilityMask() { }

	// RVA: 0x8EFCB0 Offset: 0x8EE2B0 VA: 0x1808EFCB0
	private void ToggleVisibility() { }

	// RVA: 0x8EF910 Offset: 0x8EDF10 VA: 0x1808EF910
	private void ResetVisibility() { }

	// RVA: 0x8EFB10 Offset: 0x8EE110 VA: 0x1808EFB10
	private void ToggleCollision(Collider other) { }

	// RVA: 0x8EF770 Offset: 0x8EDD70 VA: 0x1808EF770
	private void ResetCollision(Collider other) { }

	// RVA: 0x8EEED0 Offset: 0x8ED4D0 VA: 0x1808EEED0
	protected void OnTriggerEnter(Collider other) { }

	// RVA: 0x8EF1F0 Offset: 0x8ED7F0 VA: 0x1808EF1F0
	protected void OnTriggerExit(Collider other) { }

	// RVA: 0x8EFEA0 Offset: 0x8EE4A0 VA: 0x1808EFEA0
	public void .ctor() { }

	// RVA: 0x8EFE20 Offset: 0x8EE420 VA: 0x1808EFE20
	private static void .cctor() { }

}

