public class SubmarineDuo : BaseSubmarine // TypeDefIndex: 8458
{	private Option __menuOption_Menu_SwapSeats; // 0x6F8
	[HeaderAttribute] // RVA: 0x8E6F0 Offset: 0x8DAF0 VA: 0x18008E6F0
	[SerializeField] // RVA: 0x8E6F0 Offset: 0x8DAF0 VA: 0x18008E6F0
	private Transform steeringWheel; // 0x750
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform steeringWheelLeftGrip; // 0x758
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform steeringWheelRightGrip; // 0x760
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform leftPedal; // 0x768
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform rightPedal; // 0x770
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform driverLeftFoot; // 0x778
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform driverRightFoot; // 0x780
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform mphNeedle; // 0x788
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform fuelNeedle; // 0x790
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform waterDepthNeedle; // 0x798
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform ammoFlag; // 0x7A0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private SubmarineSonar sonar; // 0x7A8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
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

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	protected override bool UpdateInteriorVisuals(bool playerIsInside, float speed) { }

	protected override bool UpdateExteriorVisuals(bool playerIsInside, float speed) { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	protected override void TorpedoFired() { }

	[BaseEntity.Menu] // RVA: 0x8F270 Offset: 0x8E670 VA: 0x18008F270
	[BaseEntity.Menu.Description] // RVA: 0x8F270 Offset: 0x8E670 VA: 0x18008F270
	[BaseEntity.Menu.Icon] // RVA: 0x8F270 Offset: 0x8E670 VA: 0x18008F270
	[BaseEntity.Menu.ShowIf] // RVA: 0x8F270 Offset: 0x8E670 VA: 0x18008F270
	public void Menu_SwapSeats(BasePlayer player) { }

	public bool Menu_SwapSeats_ShowIf(BasePlayer player) { }

	protected override bool Menu_Occupied_ShowIf(BasePlayer player) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal static Vector3 <UpdateInteriorVisuals>g__SetGauge|31_0(Vector3 localAngles, float amount, float maxReading, float maxDegrees, bool zAxis) { }

}

private enum SubmarineDuo.FlagState // TypeDefIndex: 8459
{	public int value__; // 0x0
	public const SubmarineDuo.FlagState Down = 0;
	public const SubmarineDuo.FlagState Up = 1;
	public const SubmarineDuo.FlagState MovingUp = 2;
	public const SubmarineDuo.FlagState MovingDown = 3;

}

private enum SubmarineDuo.TorpedoDoorState // TypeDefIndex: 8460
{	public int value__; // 0x0
	public const SubmarineDuo.TorpedoDoorState Closed = 0;
	public const SubmarineDuo.TorpedoDoorState Closing = 1;
	public const SubmarineDuo.TorpedoDoorState Opening = 2;

}

