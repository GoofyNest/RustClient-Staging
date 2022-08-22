public class MLRS : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6422
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 targetPos; // 0x14
	public Vector3 curHitPos; // 0x20
	public uint rocketStorageID; // 0x2C
	public uint dashboardStorageID; // 0x30
	public uint ammoCount; // 0x34

	// Methods

	// RVA: 0x1F28870 Offset: 0x1F26E70 VA: 0x181F28870
	public static void ResetToPool(MLRS instance) { }

	// RVA: 0x1F287B0 Offset: 0x1F26DB0 VA: 0x181F287B0
	public void ResetToPool() { }

	// RVA: 0x1F28400 Offset: 0x1F26A00 VA: 0x181F28400 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F270F0 Offset: 0x1F256F0 VA: 0x181F270F0
	public void CopyTo(MLRS instance) { }

	// RVA: 0x1F27140 Offset: 0x1F25740 VA: 0x181F27140
	public MLRS Copy() { }

	// RVA: 0x1F278F0 Offset: 0x1F25EF0 VA: 0x181F278F0
	public static MLRS Deserialize(Stream stream) { }

	// RVA: 0x1F271E0 Offset: 0x1F257E0 VA: 0x181F271E0
	public static MLRS DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F27860 Offset: 0x1F25E60 VA: 0x181F27860
	public static MLRS DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F27DC0 Offset: 0x1F263C0 VA: 0x181F27DC0
	public static MLRS Deserialize(byte[] buffer) { }

	// RVA: 0x1F28540 Offset: 0x1F26B40 VA: 0x181F28540
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F29250 Offset: 0x1F27850 VA: 0x181F29250 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F29270 Offset: 0x1F27870 VA: 0x181F29270 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MLRS previous) { }

	// RVA: 0x1F28790 Offset: 0x1F26D90 VA: 0x181F28790 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F280F0 Offset: 0x1F266F0 VA: 0x181F280F0
	public static MLRS Deserialize(byte[] buffer, MLRS instance, bool isDelta = False) { }

	// RVA: 0x1F27B70 Offset: 0x1F26170 VA: 0x181F27B70
	public static MLRS Deserialize(Stream stream, MLRS instance, bool isDelta) { }

	// RVA: 0x1F27260 Offset: 0x1F25860 VA: 0x181F27260
	public static MLRS DeserializeLengthDelimited(Stream stream, MLRS instance, bool isDelta) { }

	// RVA: 0x1F27570 Offset: 0x1F25B70 VA: 0x181F27570
	public static MLRS DeserializeLength(Stream stream, int length, MLRS instance, bool isDelta) { }

	// RVA: 0x1F28930 Offset: 0x1F26F30 VA: 0x181F28930
	public static void SerializeDelta(Stream stream, MLRS instance, MLRS previous) { }

	// RVA: 0x1F28F90 Offset: 0x1F27590 VA: 0x181F28F90
	public static void Serialize(Stream stream, MLRS instance) { }

	// RVA: 0x1F29240 Offset: 0x1F27840 VA: 0x181F29240
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F29250 Offset: 0x1F27850 VA: 0x181F29250
	public void ToProto(Stream stream) { }

	// RVA: 0x1F28E80 Offset: 0x1F27480 VA: 0x181F28E80
	public static byte[] SerializeToBytes(MLRS instance) { }

	// RVA: 0x1F28DD0 Offset: 0x1F273D0 VA: 0x181F28DD0
	public static void SerializeLengthDelimited(Stream stream, MLRS instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class MLRS : BaseMountable // TypeDefIndex: 8412
{	// Fields
	private Option __menuOption_Menu_Cannot_Fire_Rockets; // 0x320
	private Option __menuOption_Menu_Fire_Rockets; // 0x378
	private Option __menuOption_Menu_Open_Dashboard_Storage; // 0x3D0
	private Option __menuOption_Menu_Open_Rocket_Storage; // 0x428
	private Option __menuOption_Menu_SetTarget; // 0x480
	private float targetHRot; // 0x4D8
	private float targetVRot; // 0x4DC
	private Nullable<Vector3> hydraulicsBaseLocalPos; // 0x4E0
	private Vector3 hingeTargetLocalRot; // 0x4F0
	private TimeSince timeSinceLightChange; // 0x4FC
	private bool fullscreenMapOpen; // 0x500
	[HeaderAttribute] // RVA: 0xEE780 Offset: 0xEDB80 VA: 0x1800EE780
	[SerializeField] // RVA: 0xEE780 Offset: 0xEDB80 VA: 0x1800EE780
	private GameObjectRef rocketStoragePrefab; // 0x508
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef dashboardStoragePrefab; // 0x510
	[HeaderAttribute] // RVA: 0xEEA20 Offset: 0xEDE20 VA: 0x1800EEA20
	[SerializeField] // RVA: 0xEEA20 Offset: 0xEDE20 VA: 0x1800EEA20
	private Transform hRotator; // 0x518
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float hRotSpeed; // 0x520
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform vRotator; // 0x528
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float vRotSpeed; // 0x530
	[SerializeField] // RVA: 0xEF000 Offset: 0xEE400 VA: 0x1800EF000
	[RangeAttribute] // RVA: 0xEF000 Offset: 0xEE400 VA: 0x1800EF000
	private float vRotMax; // 0x534
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform hydraulics; // 0x538
	[HeaderAttribute] // RVA: 0xEF3F0 Offset: 0xEE7F0 VA: 0x1800EF3F0
	[TooltipAttribute] // RVA: 0xEF3F0 Offset: 0xEE7F0 VA: 0x1800EF3F0
	[SerializeField] // RVA: 0xEF3F0 Offset: 0xEE7F0 VA: 0x1800EF3F0
	public float minRange; // 0x540
	[TooltipAttribute] // RVA: 0xEF7C0 Offset: 0xEEBC0 VA: 0x1800EF7C0
	[SerializeField] // RVA: 0xEF7C0 Offset: 0xEEBC0 VA: 0x1800EF7C0
	public float targetAreaRadius; // 0x544
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef mlrsRocket; // 0x548
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Transform firingPoint; // 0x550
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MLRS.RocketTube[] rocketTubes; // 0x558
	[HeaderAttribute] // RVA: 0xEFCC0 Offset: 0xEF0C0 VA: 0x1800EFCC0
	[SerializeField] // RVA: 0xEFCC0 Offset: 0xEF0C0 VA: 0x1800EFCC0
	private GameObject screensChild; // 0x560
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform leftHandGrip; // 0x568
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform leftJoystick; // 0x570
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform rightHandGrip; // 0x578
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform rightJoystick; // 0x580
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform controlKnobHeight; // 0x588
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform controlKnobAngle; // 0x590
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObjectRef uiDialogPrefab; // 0x598
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Light fireButtonLight; // 0x5A0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject brokenDownEffect; // 0x5A8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem topScreenShutdown; // 0x5B0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ParticleSystem bottomScreenShutdown; // 0x5B8
	[ServerVar] // RVA: 0xF0510 Offset: 0xEF910 VA: 0x1800F0510
	public static float brokenDownMinutes; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <UserTargetHitPos>k__BackingField; // 0x5C0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector3 <TrueHitPos>k__BackingField; // 0x5CC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <CurGravityMultiplier>k__BackingField; // 0x5D8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <RocketAmmoCount>k__BackingField; // 0x5DC
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IsRealigning>k__BackingField; // 0x5E0
	public const BaseEntity.Flags FLAG_FIRING_ROCKETS = 16384;
	public const BaseEntity.Flags FLAG_HAS_AIMING_MODULE = 65536;
	private EntityRef rocketStorageInstance; // 0x5E8
	private EntityRef dashboardStorageInstance; // 0x5F8
	private float rocketBaseGravity; // 0x608
	private float rocketSpeed; // 0x60C
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <RocketDamageRadius>k__BackingField; // 0x610
	private bool isInitialLoad; // 0x614

	// Properties
	public override bool HasMenuOptions { get; }
	public Vector3 UserTargetHitPos { get; set; }
	public Vector3 TrueHitPos { get; set; }
	public bool HasAimingModule { get; }
	private bool CanBeUsed { get; }
	private bool CanFire { get; }
	private float HRotation { get; set; }
	private float VRotation { get; set; }
	public float CurGravityMultiplier { get; set; }
	public int RocketAmmoCount { get; set; }
	public bool IsRealigning { get; set; }
	public bool IsFiringRockets { get; }
	public float RocketDamageRadius { get; set; }

	// Methods

	// RVA: 0x554D00 Offset: 0x553300 VA: 0x180554D00 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x557C00 Offset: 0x556200 VA: 0x180557C00 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5570B0 Offset: 0x5556B0 VA: 0x1805570B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x556E20 Offset: 0x555420 VA: 0x180556E20 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x555C20 Offset: 0x554220 VA: 0x180555C20
	protected void LateUpdate() { }

	// RVA: 0x5578A0 Offset: 0x555EA0 VA: 0x1805578A0 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x557740 Offset: 0x555D40 VA: 0x180557740
	public void SendNewTargetHitPos(Vector3 worldPos) { }

	// RVA: 0x555980 Offset: 0x553F80 VA: 0x180555980 Slot: 65
	protected override bool HideMenuItems(BasePlayer player) { }

	// RVA: 0x5571A0 Offset: 0x5557A0 VA: 0x1805571A0
	private void PositionVisuals() { }

	// RVA: 0x556D10 Offset: 0x555310 VA: 0x180556D10
	private void ShowFullscreenMap() { }

	// RVA: 0x5570A0 Offset: 0x5556A0 VA: 0x1805570A0
	public void OnFullscreenMapClosed() { }

	// RVA: 0x557870 Offset: 0x555E70 VA: 0x180557870
	private bool ShouldShowDashboardUI() { }

	[BaseEntity.Menu] // RVA: 0xF0CB0 Offset: 0xF00B0 VA: 0x1800F0CB0
	[BaseEntity.Menu.Description] // RVA: 0xF0CB0 Offset: 0xF00B0 VA: 0x1800F0CB0
	[BaseEntity.Menu.Icon] // RVA: 0xF0CB0 Offset: 0xF00B0 VA: 0x1800F0CB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xF0CB0 Offset: 0xF00B0 VA: 0x1800F0CB0
	// RVA: 0x556D10 Offset: 0x555310 VA: 0x180556D10
	public void Menu_SetTarget(BasePlayer player) { }

	// RVA: 0x556BB0 Offset: 0x5551B0 VA: 0x180556BB0
	public bool Menu_SetTarget_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x6F4D0 Offset: 0x6E8D0 VA: 0x18006F4D0
	[BaseEntity.Menu.Description] // RVA: 0x6F4D0 Offset: 0x6E8D0 VA: 0x18006F4D0
	[BaseEntity.Menu.Icon] // RVA: 0x6F4D0 Offset: 0x6E8D0 VA: 0x18006F4D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x6F4D0 Offset: 0x6E8D0 VA: 0x18006F4D0
	// RVA: 0x556900 Offset: 0x554F00 VA: 0x180556900
	public void Menu_Fire_Rockets(BasePlayer player) { }

	// RVA: 0x5567E0 Offset: 0x554DE0 VA: 0x1805567E0
	public bool Menu_Fire_Rockets_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x6FC80 Offset: 0x6F080 VA: 0x18006FC80
	[BaseEntity.Menu.Description] // RVA: 0x6FC80 Offset: 0x6F080 VA: 0x18006FC80
	[BaseEntity.Menu.Icon] // RVA: 0x6FC80 Offset: 0x6F080 VA: 0x18006FC80
	[BaseEntity.Menu.ShowIf] // RVA: 0x6FC80 Offset: 0x6F080 VA: 0x18006FC80
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Cannot_Fire_Rockets(BasePlayer player) { }

	// RVA: 0x5566D0 Offset: 0x554CD0 VA: 0x1805566D0
	public bool Menu_Cannot_Fire_Rockets_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x700D0 Offset: 0x6F4D0 VA: 0x1800700D0
	[BaseEntity.Menu.Description] // RVA: 0x700D0 Offset: 0x6F4D0 VA: 0x1800700D0
	[BaseEntity.Menu.Icon] // RVA: 0x700D0 Offset: 0x6F4D0 VA: 0x1800700D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x700D0 Offset: 0x6F4D0 VA: 0x1800700D0
	// RVA: 0x556B70 Offset: 0x555170 VA: 0x180556B70
	public void Menu_Open_Rocket_Storage(BasePlayer player) { }

	// RVA: 0x556AA0 Offset: 0x5550A0 VA: 0x180556AA0
	public bool Menu_Open_Rocket_Storage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x70330 Offset: 0x6F730 VA: 0x180070330
	[BaseEntity.Menu.Description] // RVA: 0x70330 Offset: 0x6F730 VA: 0x180070330
	[BaseEntity.Menu.Icon] // RVA: 0x70330 Offset: 0x6F730 VA: 0x180070330
	[BaseEntity.Menu.ShowIf] // RVA: 0x70330 Offset: 0x6F730 VA: 0x180070330
	// RVA: 0x556A60 Offset: 0x555060 VA: 0x180556A60
	public void Menu_Open_Dashboard_Storage(BasePlayer player) { }

	// RVA: 0x556990 Offset: 0x554F90 VA: 0x180556990
	public bool Menu_Open_Dashboard_Storage_ShowIf(BasePlayer player) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x557F40 Offset: 0x556540 VA: 0x180557F40
	public Vector3 get_UserTargetHitPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x558070 Offset: 0x556670 VA: 0x180558070
	private void set_UserTargetHitPos(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x557F20 Offset: 0x556520 VA: 0x180557F20
	public Vector3 get_TrueHitPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x558050 Offset: 0x556650 VA: 0x180558050
	private void set_TrueHitPos(Vector3 value) { }

	// RVA: 0x557BF0 Offset: 0x5561F0 VA: 0x180557BF0
	public bool get_HasAimingModule() { }

	// RVA: 0x557B10 Offset: 0x556110 VA: 0x180557B10
	private bool get_CanBeUsed() { }

	// RVA: 0x557B50 Offset: 0x556150 VA: 0x180557B50
	private bool get_CanFire() { }

	// RVA: 0x557BC0 Offset: 0x5561C0 VA: 0x180557BC0
	private float get_HRotation() { }

	// RVA: 0x557FA0 Offset: 0x5565A0 VA: 0x180557FA0
	private void set_HRotation(float value) { }

	// RVA: 0x557F60 Offset: 0x556560 VA: 0x180557F60
	private float get_VRotation() { }

	// RVA: 0x558090 Offset: 0x556690 VA: 0x180558090
	private void set_VRotation(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x557BB0 Offset: 0x5561B0 VA: 0x180557BB0
	public float get_CurGravityMultiplier() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x557F90 Offset: 0x556590 VA: 0x180557F90
	private void set_CurGravityMultiplier(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x557F00 Offset: 0x556500 VA: 0x180557F00
	public int get_RocketAmmoCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x558030 Offset: 0x556630 VA: 0x180558030
	private void set_RocketAmmoCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x557EF0 Offset: 0x5564F0 VA: 0x180557EF0
	public bool get_IsRealigning() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x558020 Offset: 0x556620 VA: 0x180558020
	private void set_IsRealigning(bool value) { }

	// RVA: 0x557EE0 Offset: 0x5564E0 VA: 0x180557EE0
	public bool get_IsFiringRockets() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x557F10 Offset: 0x556510 VA: 0x180557F10
	public float get_RocketDamageRadius() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x558040 Offset: 0x556640 VA: 0x180558040
	private void set_RocketDamageRadius(float value) { }

	// RVA: 0x555B30 Offset: 0x554130 VA: 0x180555B30 Slot: 28
	public override void InitShared() { }

	// RVA: 0x5563D0 Offset: 0x5549D0 VA: 0x1805563D0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x554820 Offset: 0x552E20 VA: 0x180554820 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x5577B0 Offset: 0x555DB0 VA: 0x1805577B0
	private void SetUserTargetHitPos(Vector3 worldPos) { }

	// RVA: 0x5558A0 Offset: 0x553EA0 VA: 0x1805558A0
	private StorageContainer GetRocketContainer() { }

	// RVA: 0x554C20 Offset: 0x553220 VA: 0x180554C20
	private StorageContainer GetDashboardContainer() { }

	// RVA: 0x5559D0 Offset: 0x553FD0 VA: 0x1805559D0
	private void HitPosToRotation(Vector3 hitPos, out float hRot, out float vRot, out float g) { }

	// RVA: 0x554840 Offset: 0x552E40 VA: 0x180554840
	private Vector3 GetAimToTarget(Vector3 targetPos, out float g) { }

	// RVA: 0x557620 Offset: 0x555C20 VA: 0x180557620
	private static float ProjectileDistToSpeed(float x, float y, float angle, float g, float fallbackV) { }

	// RVA: 0x5574F0 Offset: 0x555AF0 VA: 0x1805574F0
	private static float ProjectileDistToGravity(float x, float y, float θ, float v) { }

	// RVA: 0x557A80 Offset: 0x556080 VA: 0x180557A80
	public void .ctor() { }

	// RVA: 0x557A40 Offset: 0x556040 VA: 0x180557A40
	private static void .cctor() { }

}

public class MLRS.RocketTube // TypeDefIndex: 8413
{	// Fields
	public Vector3 firingOffset; // 0x10
	public Transform hinge; // 0x20
	public Renderer rocket; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

private struct MLRS.TheoreticalProjectile // TypeDefIndex: 8414
{	// Fields
	public Vector3 pos; // 0x0
	public Vector3 forward; // 0xC
	public float gravityMult; // 0x18

	// Methods

	// RVA: 0xF2AE0 Offset: 0xF1EE0 VA: 0x1800F2AE0
	public void .ctor(Vector3 pos, Vector3 forward, float gravityMult) { }

}

