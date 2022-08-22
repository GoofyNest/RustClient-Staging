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
	// RVA: 0x7746B0 Offset: 0x772CB0 VA: 0x1807746B0
	public float get_WaitTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7746F0 Offset: 0x772CF0 VA: 0x1807746F0
	public void set_WaitTime(float value) { }

	// RVA: 0x14BD9B0 Offset: 0x14BBFB0 VA: 0x1814BD9B0 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x14BD980 Offset: 0x14BBF80 VA: 0x1814BD980 Slot: 8
	public void EnterPool() { }

	// RVA: 0x14BD990 Offset: 0x14BBF90 VA: 0x1814BD990 Slot: 9
	public void LeavePool() { }

	// RVA: 0x14BD9A0 Offset: 0x14BBFA0 VA: 0x1814BD9A0
	public void .ctor() { }

}

