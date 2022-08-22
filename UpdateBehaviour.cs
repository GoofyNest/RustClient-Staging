public abstract class UpdateBehaviour : MonoBehaviour // TypeDefIndex: 11339
{	// Fields
	internal float lastUpdate; // 0x18
	internal float nextUpdate; // 0x1C

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void DeltaUpdate(float deltaTime);

	// RVA: 0x1134830 Offset: 0x1132E30 VA: 0x181134830
	protected void Sleep(float seconds) { }

	// RVA: 0x1134820 Offset: 0x1132E20 VA: 0x181134820
	protected void SleepAccumulative(float seconds) { }

	// RVA: 0x1134680 Offset: 0x1132C80 VA: 0x181134680 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x1134540 Offset: 0x1132B40 VA: 0x181134540 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

