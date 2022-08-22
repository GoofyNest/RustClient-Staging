public class SubmarineDuo : BaseSubmarine // TypeDefIndex: 8458
{	// Fields
	private Option __menuOption_Menu_SwapSeats; // 0x6F8
	[HeaderAttribute] // RVA: 0x8E710 Offset: 0x8DB10 VA: 0x18008E710
	[SerializeField] // RVA: 0x8E710 Offset: 0x8DB10 VA: 0x18008E710
	private Transform steeringWheel; // 0x750
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform steeringWheelLeftGrip; // 0x758
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform steeringWheelRightGrip; // 0x760
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform leftPedal; // 0x768
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform rightPedal; // 0x770
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform driverLeftFoot; // 0x778
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform driverRightFoot; // 0x780
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform mphNeedle; // 0x788
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform fuelNeedle; // 0x790
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform waterDepthNeedle; // 0x798
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform ammoFlag; // 0x7A0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SubmarineSonar sonar; // 0x7A8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x7A2660 Offset: 0x7A0C60 VA: 0x1807A2660 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7A3B70 Offset: 0x7A2170 VA: 0x1807A3B70 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7A2EF0 Offset: 0x7A14F0 VA: 0x1807A2EF0 Slot: 197
	protected override bool UpdateInteriorVisuals(bool playerIsInside, float speed) { }

	// RVA: 0x7A2CC0 Offset: 0x7A12C0 VA: 0x1807A2CC0 Slot: 198
	protected override bool UpdateExteriorVisuals(bool playerIsInside, float speed) { }

	// RVA: 0x7A37B0 Offset: 0x7A1DB0 VA: 0x1807A37B0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x7A2BF0 Offset: 0x7A11F0 VA: 0x1807A2BF0 Slot: 199
	protected override void TorpedoFired() { }

	[BaseEntity.Menu] // RVA: 0x8F1B0 Offset: 0x8E5B0 VA: 0x18008F1B0
	[BaseEntity.Menu.Description] // RVA: 0x8F1B0 Offset: 0x8E5B0 VA: 0x18008F1B0
	[BaseEntity.Menu.Icon] // RVA: 0x8F1B0 Offset: 0x8E5B0 VA: 0x18008F1B0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8F1B0 Offset: 0x8E5B0 VA: 0x18008F1B0
	// RVA: 0x7A2B60 Offset: 0x7A1160 VA: 0x1807A2B60
	public void Menu_SwapSeats(BasePlayer player) { }

	// RVA: 0x7A2AB0 Offset: 0x7A10B0 VA: 0x1807A2AB0
	public bool Menu_SwapSeats_ShowIf(BasePlayer player) { }

	// RVA: 0x7A2970 Offset: 0x7A0F70 VA: 0x1807A2970 Slot: 190
	protected override bool Menu_Occupied_ShowIf(BasePlayer player) { }

	// RVA: 0x7A3AD0 Offset: 0x7A20D0 VA: 0x1807A3AD0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7A2C10 Offset: 0x7A1210 VA: 0x1807A2C10
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

