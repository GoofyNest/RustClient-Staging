public class ReliableEventSender : StateMachineBehaviour // TypeDefIndex: 9120
{	// Fields
	[HeaderAttribute] // RVA: 0xD1300 Offset: 0xD0700 VA: 0x1800D1300
	public string StateEnter; // 0x18
	[HeaderAttribute] // RVA: 0xD1410 Offset: 0xD0810 VA: 0x1800D1410
	public string MidStateEvent; // 0x20
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float TargetEventTime; // 0x28
	private bool sentBeginEvent; // 0x2C
	private float lastTime; // 0x30
	private AnimationEvents eventComponent; // 0x38

	// Methods

	// RVA: 0x94C890 Offset: 0x94AE90 VA: 0x18094C890 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x94C930 Offset: 0x94AF30 VA: 0x18094C930 Slot: 7
	public override void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x94C9F0 Offset: 0x94AFF0 VA: 0x18094C9F0
	private void SendEvent(Animator animator, string eventName) { }

	// RVA: 0x94C8E0 Offset: 0x94AEE0 VA: 0x18094C8E0 Slot: 6
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x6A7AD0 Offset: 0x6A60D0 VA: 0x1806A7AD0
	public void .ctor() { }

}

