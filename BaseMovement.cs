public class BaseMovement : MonoBehaviour // TypeDefIndex: 9668
{	// Fields
	public bool adminCheat; // 0x18
	public float adminSpeed; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BasePlayer <Owner>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <InheritedVelocity>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <TargetMovement>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Running>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Ducking>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Crawling>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Grounded>k__BackingField; // 0x4C
	private const float RECENTLY_TELEPORTED_TIME = 1;
	private float lastTeleportedTime; // 0x50

	// Properties
	public BasePlayer Owner { get; set; }
	public Vector3 InheritedVelocity { get; set; }
	public Vector3 TargetMovement { get; set; }
	public float Running { get; set; }
	public float Ducking { get; set; }
	public float Crawling { get; set; }
	public float Grounded { get; set; }
	public bool IsRunning { get; }
	public bool IsDucked { get; }
	public bool IsCrawling { get; }
	public bool IsGrounded { get; }
	public bool RecentlyTeleported { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public BasePlayer get_Owner() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	private void set_Owner(BasePlayer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0440 Offset: 0x7CEA40 VA: 0x1807D0440
	public Vector3 get_InheritedVelocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC600 Offset: 0x4BAC00 VA: 0x1804BC600
	public void set_InheritedVelocity(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D000 Offset: 0xA4B600 VA: 0x180A4D000
	public Vector3 get_TargetMovement() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5F0 Offset: 0x4BABF0 VA: 0x1804BC5F0
	protected void set_TargetMovement(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x533E60 Offset: 0x532460 VA: 0x180533E60
	public float get_Running() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x533E70 Offset: 0x532470 VA: 0x180533E70
	protected void set_Running(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8054E0 Offset: 0x803AE0 VA: 0x1808054E0
	public float get_Ducking() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x88AA90 Offset: 0x889090 VA: 0x18088AA90
	protected void set_Ducking(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6F0650 Offset: 0x6EEC50 VA: 0x1806F0650
	public float get_Crawling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6F0660 Offset: 0x6EEC60 VA: 0x1806F0660
	protected void set_Crawling(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public float get_Grounded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC620 Offset: 0x4BAC20 VA: 0x1804BC620
	protected void set_Grounded(float value) { }

	// RVA: 0xA4CFC0 Offset: 0xA4B5C0 VA: 0x180A4CFC0
	public bool get_IsRunning() { }

	// RVA: 0xA4CFA0 Offset: 0xA4B5A0 VA: 0x180A4CFA0
	public bool get_IsDucked() { }

	// RVA: 0xA4CF90 Offset: 0xA4B590 VA: 0x180A4CF90
	public bool get_IsCrawling() { }

	// RVA: 0xA4CFB0 Offset: 0xA4B5B0 VA: 0x180A4CFB0
	public bool get_IsGrounded() { }

	// RVA: 0xA4CD10 Offset: 0xA4B310 VA: 0x180A4CD10 Slot: 4
	public virtual Vector3 CurrentVelocity() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 5
	public virtual float CurrentMoveSpeed() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	public virtual Collider GetCollider() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 7
	public virtual void Init(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void BlockJump(float duration) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void BlockSprint(float duration) { }

	// RVA: 0xA4CFD0 Offset: 0xA4B5D0 VA: 0x180A4CFD0
	public bool get_RecentlyTeleported() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public virtual void ClientInput(InputState state, ModelState modelState) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	public virtual void DoFixedUpdate(ModelState modelState) { }

	// RVA: 0xA4CE00 Offset: 0xA4B400 VA: 0x180A4CE00 Slot: 12
	public virtual void FrameUpdate(BasePlayer player, ModelState modelState) { }

	// RVA: 0xA4CEF0 Offset: 0xA4B4F0 VA: 0x180A4CEF0 Slot: 13
	public virtual void TeleportTo(Vector3 position, BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 14
	public virtual void Push(Vector3 velocity) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 15
	public virtual void SetParent(Transform parent) { }

	// RVA: 0xA4CD80 Offset: 0xA4B380 VA: 0x180A4CD80
	public void FixedUpdate() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	public virtual void PlayerAttemptedMount() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 17
	public virtual void PlayerCompletedMount() { }

	// RVA: 0x6F5DE0 Offset: 0x6F43E0 VA: 0x1806F5DE0
	public void .ctor() { }

}

