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

	// RVA: 0x94C380 Offset: 0x94A980 VA: 0x18094C380 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x94C420 Offset: 0x94AA20 VA: 0x18094C420 Slot: 7
	public override void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x94C4E0 Offset: 0x94AAE0 VA: 0x18094C4E0
	private void SendEvent(Animator animator, string eventName) { }

	// RVA: 0x94C3D0 Offset: 0x94A9D0 VA: 0x18094C3D0 Slot: 6
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x6A7B40 Offset: 0x6A6140 VA: 0x1806A7B40
	public void .ctor() { }

}

