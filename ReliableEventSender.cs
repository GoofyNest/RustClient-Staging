public class ReliableEventSender : StateMachineBehaviour // TypeDefIndex: 9120
{	[HeaderAttribute] // RVA: 0xD1350 Offset: 0xD0750 VA: 0x1800D1350
	public string StateEnter; // 0x18
	[HeaderAttribute] // RVA: 0xD1460 Offset: 0xD0860 VA: 0x1800D1460
	public string MidStateEvent; // 0x20
	[RangeAttribute] // RVA: 0x70FE0 Offset: 0x703E0 VA: 0x180070FE0
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

