public class WaitForSecondsRealtimeEx : CustomYieldInstruction, Pool.IPooled // TypeDefIndex: 6168
{	private bool _isInPool; // 0x10
	private float _waitUntilTime; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <WaitTime>k__BackingField; // 0x18

	public float WaitTime { get; set; }
	public override bool keepWaiting { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_WaitTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_WaitTime(float value) { }

	public override bool get_keepWaiting() { }

	public void EnterPool() { }

	public void LeavePool() { }

	public void .ctor() { }

}

