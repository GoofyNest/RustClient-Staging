public class WaitForSecondsRealtimeEx : CustomYieldInstruction, Pool.IPooled // TypeDefIndex: 6168
{	// Fields
	private bool _isInPool; // 0x10
	private float _waitUntilTime; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <WaitTime>k__BackingField; // 0x18

	// Properties
	public float WaitTime { get; set; }
	public override bool keepWaiting { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774710 Offset: 0x772D10 VA: 0x180774710
	public float get_WaitTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774750 Offset: 0x772D50 VA: 0x180774750
	public void set_WaitTime(float value) { }

	// RVA: 0x14BCD40 Offset: 0x14BB340 VA: 0x1814BCD40 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x14BCD10 Offset: 0x14BB310 VA: 0x1814BCD10 Slot: 8
	public void EnterPool() { }

	// RVA: 0x14BCD20 Offset: 0x14BB320 VA: 0x1814BCD20 Slot: 9
	public void LeavePool() { }

	// RVA: 0x14BCD30 Offset: 0x14BB330 VA: 0x1814BCD30
	public void .ctor() { }

}

