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
	// RVA: 0x79B7E0 Offset: 0x799DE0 VA: 0x18079B7E0
	public Vector3 get_InheritedVelocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC590 Offset: 0x4BAB90 VA: 0x1804BC590
	public void set_InheritedVelocity(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4D7B0 Offset: 0xA4BDB0 VA: 0x180A4D7B0
	public Vector3 get_TargetMovement() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC580 Offset: 0x4BAB80 VA: 0x1804BC580
	protected void set_TargetMovement(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x533DF0 Offset: 0x5323F0 VA: 0x180533DF0
	public float get_Running() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x533E00 Offset: 0x532400 VA: 0x180533E00
	protected void set_Running(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x805B80 Offset: 0x804180 VA: 0x180805B80
	public float get_Ducking() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x86DEE0 Offset: 0x86C4E0 VA: 0x18086DEE0
	protected void set_Ducking(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6F06F0 Offset: 0x6EECF0 VA: 0x1806F06F0
	public float get_Crawling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6F0700 Offset: 0x6EED00 VA: 0x1806F0700
	protected void set_Crawling(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC550 Offset: 0x4BAB50 VA: 0x1804BC550
	public float get_Grounded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	protected void set_Grounded(float value) { }

	// RVA: 0xA4D770 Offset: 0xA4BD70 VA: 0x180A4D770
	public bool get_IsRunning() { }

	// RVA: 0xA4D750 Offset: 0xA4BD50 VA: 0x180A4D750
	public bool get_IsDucked() { }

	// RVA: 0xA4D740 Offset: 0xA4BD40 VA: 0x180A4D740
	public bool get_IsCrawling() { }

	// RVA: 0xA4D760 Offset: 0xA4BD60 VA: 0x180A4D760
	public bool get_IsGrounded() { }

	// RVA: 0xA4D4C0 Offset: 0xA4BAC0 VA: 0x180A4D4C0 Slot: 4
	public virtual Vector3 CurrentVelocity() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 5
	public virtual float CurrentMoveSpeed() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 6
	public virtual Collider GetCollider() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 7
	public virtual void Init(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void BlockJump(float duration) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void BlockSprint(float duration) { }

	// RVA: 0xA4D780 Offset: 0xA4BD80 VA: 0x180A4D780
	public bool get_RecentlyTeleported() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public virtual void ClientInput(InputState state, ModelState modelState) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 11
	public virtual void DoFixedUpdate(ModelState modelState) { }

	// RVA: 0xA4D5B0 Offset: 0xA4BBB0 VA: 0x180A4D5B0 Slot: 12
	public virtual void FrameUpdate(BasePlayer player, ModelState modelState) { }

	// RVA: 0xA4D6A0 Offset: 0xA4BCA0 VA: 0x180A4D6A0 Slot: 13
	public virtual void TeleportTo(Vector3 position, BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 14
	public virtual void Push(Vector3 velocity) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 15
	public virtual void SetParent(Transform parent) { }

	// RVA: 0xA4D530 Offset: 0xA4BB30 VA: 0x180A4D530
	public void FixedUpdate() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 16
	public virtual void PlayerAttemptedMount() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 17
	public virtual void PlayerCompletedMount() { }

	// RVA: 0x6F5E40 Offset: 0x6F4440 VA: 0x1806F5E40
	public void .ctor() { }

}

