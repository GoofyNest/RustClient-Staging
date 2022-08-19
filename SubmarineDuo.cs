public class SubmarineDuo : BaseSubmarine // TypeDefIndex: 8458
{	// Fields
	private Option __menuOption_Menu_SwapSeats; // 0x6F8
	[HeaderAttribute] // RVA: 0x8E690 Offset: 0x8DA90 VA: 0x18008E690
	[SerializeField] // RVA: 0x8E690 Offset: 0x8DA90 VA: 0x18008E690
	private Transform steeringWheel; // 0x750
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform steeringWheelLeftGrip; // 0x758
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform steeringWheelRightGrip; // 0x760
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform leftPedal; // 0x768
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform rightPedal; // 0x770
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform driverLeftFoot; // 0x778
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform driverRightFoot; // 0x780
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform mphNeedle; // 0x788
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform fuelNeedle; // 0x790
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform waterDepthNeedle; // 0x798
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform ammoFlag; // 0x7A0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SubmarineSonar sonar; // 0x7A8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform torpedoTubeHatch; // 0x7B0
	private float smoothedSpeed; // 0x7B8
	private float flagLerp; // 0x7BC
	private SubmarineDuo.FlagState flagState; // 0x7C0
	private const float FLAG_DOWN_ANGLE = 0;
	private const float FLAG_UP_ANGLE = 90;
	private bool torpedoJustFired; // 0x7C4
	private SubmarineDuo.TorpedoDoorState torpedoDoorState; // 0x7C8
	private const float TORPEDO_DOOR_CLOSED_ANGLE = 0;
	private const float TORPEDO_DOOR_OPEN_ANGLE = 230;
	private const float TORPEDO_OPEN_SPEED = 1100;
	private const float TORPEDO_CLOSE_SPEED = 450;
	private Vector3 torpedoVec; // 0x7CC

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7A2550 Offset: 0x7A0B50 VA: 0x1807A2550 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7A3A60 Offset: 0x7A2060 VA: 0x1807A3A60 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7A2DE0 Offset: 0x7A13E0 VA: 0x1807A2DE0 Slot: 197
	protected override bool UpdateInteriorVisuals(bool playerIsInside, float speed) { }

	// RVA: 0x7A2BB0 Offset: 0x7A11B0 VA: 0x1807A2BB0 Slot: 198
	protected override bool UpdateExteriorVisuals(bool playerIsInside, float speed) { }

	// RVA: 0x7A36A0 Offset: 0x7A1CA0 VA: 0x1807A36A0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x7A2AE0 Offset: 0x7A10E0 VA: 0x1807A2AE0 Slot: 199
	protected override void TorpedoFired() { }

	[BaseEntity.Menu] // RVA: 0x8F080 Offset: 0x8E480 VA: 0x18008F080
	[BaseEntity.Menu.Description] // RVA: 0x8F080 Offset: 0x8E480 VA: 0x18008F080
	[BaseEntity.Menu.Icon] // RVA: 0x8F080 Offset: 0x8E480 VA: 0x18008F080
	[BaseEntity.Menu.ShowIf] // RVA: 0x8F080 Offset: 0x8E480 VA: 0x18008F080
	// RVA: 0x7A2A50 Offset: 0x7A1050 VA: 0x1807A2A50
	public void Menu_SwapSeats(BasePlayer player) { }

	// RVA: 0x7A29A0 Offset: 0x7A0FA0 VA: 0x1807A29A0
	public bool Menu_SwapSeats_ShowIf(BasePlayer player) { }

	// RVA: 0x7A2860 Offset: 0x7A0E60 VA: 0x1807A2860 Slot: 190
	protected override bool Menu_Occupied_ShowIf(BasePlayer player) { }

	// RVA: 0x7A39C0 Offset: 0x7A1FC0 VA: 0x1807A39C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7A2B00 Offset: 0x7A1100 VA: 0x1807A2B00
	internal static Vector3 <UpdateInteriorVisuals>g__SetGauge|31_0(Vector3 localAngles, float amount, float maxReading, float maxDegrees, bool zAxis) { }

}

private enum SubmarineDuo.FlagState // TypeDefIndex: 8459
{	// Fields
	public int value__; // 0x0
	public const SubmarineDuo.FlagState Down = 0;
	public const SubmarineDuo.FlagState Up = 1;
	public const SubmarineDuo.FlagState MovingUp = 2;
	public const SubmarineDuo.FlagState MovingDown = 3;

}

private enum SubmarineDuo.TorpedoDoorState // TypeDefIndex: 8460
{	// Fields
	public int value__; // 0x0
	public const SubmarineDuo.TorpedoDoorState Closed = 0;
	public const SubmarineDuo.TorpedoDoorState Closing = 1;
	public const SubmarineDuo.TorpedoDoorState Opening = 2;

}

