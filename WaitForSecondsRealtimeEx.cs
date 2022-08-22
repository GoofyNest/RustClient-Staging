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
	// RVA: 0x7747C0 Offset: 0x772DC0 VA: 0x1807747C0
	public float get_WaitTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x774800 Offset: 0x772E00 VA: 0x180774800
	public void set_WaitTime(float value) { }

	// RVA: 0x14BDC70 Offset: 0x14BC270 VA: 0x1814BDC70 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x14BDC40 Offset: 0x14BC240 VA: 0x1814BDC40 Slot: 8
	public void EnterPool() { }

	// RVA: 0x14BDC50 Offset: 0x14BC250 VA: 0x1814BDC50 Slot: 9
	public void LeavePool() { }

	// RVA: 0x14BDC60 Offset: 0x14BC260 VA: 0x1814BDC60
	public void .ctor() { }

}

