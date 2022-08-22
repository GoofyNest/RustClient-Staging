public abstract class UpdateBehaviour : MonoBehaviour // TypeDefIndex: 11339
{	// Fields
	internal float lastUpdate; // 0x18
	internal float nextUpdate; // 0x1C

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void DeltaUpdate(float deltaTime);

	// RVA: 0x11352A0 Offset: 0x11338A0 VA: 0x1811352A0
	protected void Sleep(float seconds) { }

	// RVA: 0x1135290 Offset: 0x1133890 VA: 0x181135290
	protected void SleepAccumulative(float seconds) { }

	// RVA: 0x11350F0 Offset: 0x11336F0 VA: 0x1811350F0 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x1134FB0 Offset: 0x11335B0 VA: 0x181134FB0 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	protected void .ctor() { }

}

