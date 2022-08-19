public abstract class UpdateBehaviour : MonoBehaviour // TypeDefIndex: 11339
{	// Fields
	internal float lastUpdate; // 0x18
	internal float nextUpdate; // 0x1C

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void DeltaUpdate(float deltaTime);

	// RVA: 0x1134570 Offset: 0x1132B70 VA: 0x181134570
	protected void Sleep(float seconds) { }

	// RVA: 0x1134560 Offset: 0x1132B60 VA: 0x181134560
	protected void SleepAccumulative(float seconds) { }

	// RVA: 0x11343C0 Offset: 0x11329C0 VA: 0x1811343C0 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x1134280 Offset: 0x1132880 VA: 0x181134280 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

