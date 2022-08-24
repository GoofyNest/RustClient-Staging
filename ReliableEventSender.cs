public class ReliableEventSender : StateMachineBehaviour // TypeDefIndex: 9120
{	[HeaderAttribute] // RVA: 0xD1430 Offset: 0xD0830 VA: 0x1800D1430
	public string StateEnter; // 0x18
	[HeaderAttribute] // RVA: 0xD1540 Offset: 0xD0940 VA: 0x1800D1540
	public string MidStateEvent; // 0x20
	[RangeAttribute] // RVA: 0x717B0 Offset: 0x70BB0 VA: 0x1800717B0
	public float TargetEventTime; // 0x28
	private bool sentBeginEvent; // 0x2C
	private float lastTime; // 0x30
	private AnimationEvents eventComponent; // 0x38


	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public override void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	private void SendEvent(Animator animator, string eventName) { }

	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public void .ctor() { }

}

