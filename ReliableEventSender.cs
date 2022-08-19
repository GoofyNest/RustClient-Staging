public class ReliableEventSender : StateMachineBehaviour // TypeDefIndex: 9120
{	// Fields
	[HeaderAttribute] // RVA: 0xD1270 Offset: 0xD0670 VA: 0x1800D1270
	public string StateEnter; // 0x18
	[HeaderAttribute] // RVA: 0xD13D0 Offset: 0xD07D0 VA: 0x1800D13D0
	public string MidStateEvent; // 0x20
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float TargetEventTime; // 0x28
	private bool sentBeginEvent; // 0x2C
	private float lastTime; // 0x30
	private AnimationEvents eventComponent; // 0x38

	// Methods

	// RVA: 0x94C270 Offset: 0x94A870 VA: 0x18094C270 Slot: 4
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x94C310 Offset: 0x94A910 VA: 0x18094C310 Slot: 7
	public override void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x94C3D0 Offset: 0x94A9D0 VA: 0x18094C3D0
	private void SendEvent(Animator animator, string eventName) { }

	// RVA: 0x94C2C0 Offset: 0x94A8C0 VA: 0x18094C2C0 Slot: 6
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x6A7A30 Offset: 0x6A6030 VA: 0x1806A7A30
	public void .ctor() { }

}
