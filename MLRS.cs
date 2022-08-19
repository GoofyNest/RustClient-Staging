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

	// RVA: 0x1F27F50 Offset: 0x1F26550 VA: 0x181F27F50
	public static void ResetToPool(MLRS instance) { }

	// RVA: 0x1F27E90 Offset: 0x1F26490 VA: 0x181F27E90
	public void ResetToPool() { }

	// RVA: 0x1F27AE0 Offset: 0x1F260E0 VA: 0x181F27AE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F267D0 Offset: 0x1F24DD0 VA: 0x181F267D0
	public void CopyTo(MLRS instance) { }

	// RVA: 0x1F26820 Offset: 0x1F24E20 VA: 0x181F26820
	public MLRS Copy() { }

	// RVA: 0x1F26FD0 Offset: 0x1F255D0 VA: 0x181F26FD0
	public static MLRS Deserialize(Stream stream) { }

	// RVA: 0x1F268C0 Offset: 0x1F24EC0 VA: 0x181F268C0
	public static MLRS DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F26F40 Offset: 0x1F25540 VA: 0x181F26F40
	public static MLRS DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F274A0 Offset: 0x1F25AA0 VA: 0x181F274A0
	public static MLRS Deserialize(byte[] buffer) { }

	// RVA: 0x1F27C20 Offset: 0x1F26220 VA: 0x181F27C20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F28930 Offset: 0x1F26F30 VA: 0x181F28930 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F28950 Offset: 0x1F26F50 VA: 0x181F28950 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MLRS previous) { }

	// RVA: 0x1F27E70 Offset: 0x1F26470 VA: 0x181F27E70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F277D0 Offset: 0x1F25DD0 VA: 0x181F277D0
	public static MLRS Deserialize(byte[] buffer, MLRS instance, bool isDelta = False) { }

	// RVA: 0x1F27250 Offset: 0x1F25850 VA: 0x181F27250
	public static MLRS Deserialize(Stream stream, MLRS instance, bool isDelta) { }

	// RVA: 0x1F26940 Offset: 0x1F24F40 VA: 0x181F26940
	public static MLRS DeserializeLengthDelimited(Stream stream, MLRS instance, bool isDelta) { }

	// RVA: 0x1F26C50 Offset: 0x1F25250 VA: 0x181F26C50
	public static MLRS DeserializeLength(Stream stream, int length, MLRS instance, bool isDelta) { }

	// RVA: 0x1F28010 Offset: 0x1F26610 VA: 0x181F28010
	public static void SerializeDelta(Stream stream, MLRS instance, MLRS previous) { }

	// RVA: 0x1F28670 Offset: 0x1F26C70 VA: 0x181F28670
	public static void Serialize(Stream stream, MLRS instance) { }

	// RVA: 0x1F28920 Offset: 0x1F26F20 VA: 0x181F28920
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F28930 Offset: 0x1F26F30 VA: 0x181F28930
	public void ToProto(Stream stream) { }

	// RVA: 0x1F28560 Offset: 0x1F26B60 VA: 0x181F28560
	public static byte[] SerializeToBytes(MLRS instance) { }

	// RVA: 0x1F284B0 Offset: 0x1F26AB0 VA: 0x181F284B0
	public static void SerializeLengthDelimited(Stream stream, MLRS instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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
	[HeaderAttribute] // RVA: 0xEE700 Offset: 0xEDB00 VA: 0x1800EE700
	[SerializeField] // RVA: 0xEE700 Offset: 0xEDB00 VA: 0x1800EE700
	private GameObjectRef rocketStoragePrefab; // 0x508
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObjectRef dashboardStoragePrefab; // 0x510
	[HeaderAttribute] // RVA: 0xEE9A0 Offset: 0xEDDA0 VA: 0x1800EE9A0
	[SerializeField] // RVA: 0xEE9A0 Offset: 0xEDDA0 VA: 0x1800EE9A0
	private Transform hRotator; // 0x518
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float hRotSpeed; // 0x520
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform vRotator; // 0x528
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float vRotSpeed; // 0x530
	[SerializeField] // RVA: 0xEEFC0 Offset: 0xEE3C0 VA: 0x1800EEFC0
	[RangeAttribute] // RVA: 0xEEFC0 Offset: 0xEE3C0 VA: 0x1800EEFC0
	private float vRotMax; // 0x534
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform hydraulics; // 0x538
	[HeaderAttribute] // RVA: 0xEF320 Offset: 0xEE720 VA: 0x1800EF320
	[TooltipAttribute] // RVA: 0xEF320 Offset: 0xEE720 VA: 0x1800EF320
	[SerializeField] // RVA: 0xEF320 Offset: 0xEE720 VA: 0x1800EF320
	public float minRange; // 0x540
	[TooltipAttribute] // RVA: 0xEF720 Offset: 0xEEB20 VA: 0x1800EF720
	[SerializeField] // RVA: 0xEF720 Offset: 0xEEB20 VA: 0x1800EF720
	public float targetAreaRadius; // 0x544
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObjectRef mlrsRocket; // 0x548
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public Transform firingPoint; // 0x550
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private MLRS.RocketTube[] rocketTubes; // 0x558
	[HeaderAttribute] // RVA: 0xEFC40 Offset: 0xEF040 VA: 0x1800EFC40
	[SerializeField] // RVA: 0xEFC40 Offset: 0xEF040 VA: 0x1800EFC40
	private GameObject screensChild; // 0x560
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform leftHandGrip; // 0x568
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform leftJoystick; // 0x570
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform rightHandGrip; // 0x578
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform rightJoystick; // 0x580
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform controlKnobHeight; // 0x588
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform controlKnobAngle; // 0x590
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObjectRef uiDialogPrefab; // 0x598
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Light fireButtonLight; // 0x5A0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private GameObject brokenDownEffect; // 0x5A8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem topScreenShutdown; // 0x5B0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private ParticleSystem bottomScreenShutdown; // 0x5B8
	[ServerVar] // RVA: 0xF0480 Offset: 0xEF880 VA: 0x1800F0480
	public static float brokenDownMinutes; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector3 <UserTargetHitPos>k__BackingField; // 0x5C0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Vector3 <TrueHitPos>k__BackingField; // 0x5CC
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <CurGravityMultiplier>k__BackingField; // 0x5D8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <RocketAmmoCount>k__BackingField; // 0x5DC
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <IsRealigning>k__BackingField; // 0x5E0
	public const BaseEntity.Flags FLAG_FIRING_ROCKETS = 16384;
	public const BaseEntity.Flags FLAG_HAS_AIMING_MODULE = 65536;
	private EntityRef rocketStorageInstance; // 0x5E8
	private EntityRef dashboardStorageInstance; // 0x5F8
	private float rocketBaseGravity; // 0x608
	private float rocketSpeed; // 0x60C
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x554D70 Offset: 0x553370 VA: 0x180554D70 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x557C70 Offset: 0x556270 VA: 0x180557C70 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x557120 Offset: 0x555720 VA: 0x180557120 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x556E90 Offset: 0x555490 VA: 0x180556E90 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x555C90 Offset: 0x554290 VA: 0x180555C90
	protected void LateUpdate() { }

	// RVA: 0x557910 Offset: 0x555F10 VA: 0x180557910 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x5577B0 Offset: 0x555DB0 VA: 0x1805577B0
	public void SendNewTargetHitPos(Vector3 worldPos) { }

	// RVA: 0x5559F0 Offset: 0x553FF0 VA: 0x1805559F0 Slot: 65
	protected override bool HideMenuItems(BasePlayer player) { }

	// RVA: 0x557210 Offset: 0x555810 VA: 0x180557210
	private void PositionVisuals() { }

	// RVA: 0x556D80 Offset: 0x555380 VA: 0x180556D80
	private void ShowFullscreenMap() { }

	// RVA: 0x557110 Offset: 0x555710 VA: 0x180557110
	public void OnFullscreenMapClosed() { }

	// RVA: 0x5578E0 Offset: 0x555EE0 VA: 0x1805578E0
	private bool ShouldShowDashboardUI() { }

	[BaseEntity.Menu] // RVA: 0xF0C20 Offset: 0xF0020 VA: 0x1800F0C20
	[BaseEntity.Menu.Description] // RVA: 0xF0C20 Offset: 0xF0020 VA: 0x1800F0C20
	[BaseEntity.Menu.Icon] // RVA: 0xF0C20 Offset: 0xF0020 VA: 0x1800F0C20
	[BaseEntity.Menu.ShowIf] // RVA: 0xF0C20 Offset: 0xF0020 VA: 0x1800F0C20
	// RVA: 0x556D80 Offset: 0x555380 VA: 0x180556D80
	public void Menu_SetTarget(BasePlayer player) { }

	// RVA: 0x556C20 Offset: 0x555220 VA: 0x180556C20
	public bool Menu_SetTarget_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x6F400 Offset: 0x6E800 VA: 0x18006F400
	[BaseEntity.Menu.Description] // RVA: 0x6F400 Offset: 0x6E800 VA: 0x18006F400
	[BaseEntity.Menu.Icon] // RVA: 0x6F400 Offset: 0x6E800 VA: 0x18006F400
	[BaseEntity.Menu.ShowIf] // RVA: 0x6F400 Offset: 0x6E800 VA: 0x18006F400
	// RVA: 0x556970 Offset: 0x554F70 VA: 0x180556970
	public void Menu_Fire_Rockets(BasePlayer player) { }

	// RVA: 0x556850 Offset: 0x554E50 VA: 0x180556850
	public bool Menu_Fire_Rockets_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x6FBB0 Offset: 0x6EFB0 VA: 0x18006FBB0
	[BaseEntity.Menu.Description] // RVA: 0x6FBB0 Offset: 0x6EFB0 VA: 0x18006FBB0
	[BaseEntity.Menu.Icon] // RVA: 0x6FBB0 Offset: 0x6EFB0 VA: 0x18006FBB0
	[BaseEntity.Menu.ShowIf] // RVA: 0x6FBB0 Offset: 0x6EFB0 VA: 0x18006FBB0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Cannot_Fire_Rockets(BasePlayer player) { }

	// RVA: 0x556740 Offset: 0x554D40 VA: 0x180556740
	public bool Menu_Cannot_Fire_Rockets_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x6FFC0 Offset: 0x6F3C0 VA: 0x18006FFC0
	[BaseEntity.Menu.Description] // RVA: 0x6FFC0 Offset: 0x6F3C0 VA: 0x18006FFC0
	[BaseEntity.Menu.Icon] // RVA: 0x6FFC0 Offset: 0x6F3C0 VA: 0x18006FFC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x6FFC0 Offset: 0x6F3C0 VA: 0x18006FFC0
	// RVA: 0x556BE0 Offset: 0x5551E0 VA: 0x180556BE0
	public void Menu_Open_Rocket_Storage(BasePlayer player) { }

	// RVA: 0x556B10 Offset: 0x555110 VA: 0x180556B10
	public bool Menu_Open_Rocket_Storage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x70260 Offset: 0x6F660 VA: 0x180070260
	[BaseEntity.Menu.Description] // RVA: 0x70260 Offset: 0x6F660 VA: 0x180070260
	[BaseEntity.Menu.Icon] // RVA: 0x70260 Offset: 0x6F660 VA: 0x180070260
	[BaseEntity.Menu.ShowIf] // RVA: 0x70260 Offset: 0x6F660 VA: 0x180070260
	// RVA: 0x556AD0 Offset: 0x5550D0 VA: 0x180556AD0
	public void Menu_Open_Dashboard_Storage(BasePlayer player) { }

	// RVA: 0x556A00 Offset: 0x555000 VA: 0x180556A00
	public bool Menu_Open_Dashboard_Storage_ShowIf(BasePlayer player) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x557FB0 Offset: 0x5565B0 VA: 0x180557FB0
	public Vector3 get_UserTargetHitPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5580E0 Offset: 0x5566E0 VA: 0x1805580E0
	private void set_UserTargetHitPos(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x557F90 Offset: 0x556590 VA: 0x180557F90
	public Vector3 get_TrueHitPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5580C0 Offset: 0x5566C0 VA: 0x1805580C0
	private void set_TrueHitPos(Vector3 value) { }

	// RVA: 0x557C60 Offset: 0x556260 VA: 0x180557C60
	public bool get_HasAimingModule() { }

	// RVA: 0x557B80 Offset: 0x556180 VA: 0x180557B80
	private bool get_CanBeUsed() { }

	// RVA: 0x557BC0 Offset: 0x5561C0 VA: 0x180557BC0
	private bool get_CanFire() { }

	// RVA: 0x557C30 Offset: 0x556230 VA: 0x180557C30
	private float get_HRotation() { }

	// RVA: 0x558010 Offset: 0x556610 VA: 0x180558010
	private void set_HRotation(float value) { }

	// RVA: 0x557FD0 Offset: 0x5565D0 VA: 0x180557FD0
	private float get_VRotation() { }

	// RVA: 0x558100 Offset: 0x556700 VA: 0x180558100
	private void set_VRotation(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x557C20 Offset: 0x556220 VA: 0x180557C20
	public float get_CurGravityMultiplier() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x558000 Offset: 0x556600 VA: 0x180558000
	private void set_CurGravityMultiplier(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x557F70 Offset: 0x556570 VA: 0x180557F70
	public int get_RocketAmmoCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5580A0 Offset: 0x5566A0 VA: 0x1805580A0
	private void set_RocketAmmoCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x557F60 Offset: 0x556560 VA: 0x180557F60
	public bool get_IsRealigning() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x558090 Offset: 0x556690 VA: 0x180558090
	private void set_IsRealigning(bool value) { }

	// RVA: 0x557F50 Offset: 0x556550 VA: 0x180557F50
	public bool get_IsFiringRockets() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x557F80 Offset: 0x556580 VA: 0x180557F80
	public float get_RocketDamageRadius() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5580B0 Offset: 0x5566B0 VA: 0x1805580B0
	private void set_RocketDamageRadius(float value) { }

	// RVA: 0x555BA0 Offset: 0x5541A0 VA: 0x180555BA0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x556440 Offset: 0x554A40 VA: 0x180556440 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x554890 Offset: 0x552E90 VA: 0x180554890 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x557820 Offset: 0x555E20 VA: 0x180557820
	private void SetUserTargetHitPos(Vector3 worldPos) { }

	// RVA: 0x555910 Offset: 0x553F10 VA: 0x180555910
	private StorageContainer GetRocketContainer() { }

	// RVA: 0x554C90 Offset: 0x553290 VA: 0x180554C90
	private StorageContainer GetDashboardContainer() { }

	// RVA: 0x555A40 Offset: 0x554040 VA: 0x180555A40
	private void HitPosToRotation(Vector3 hitPos, out float hRot, out float vRot, out float g) { }

	// RVA: 0x5548B0 Offset: 0x552EB0 VA: 0x1805548B0
	private Vector3 GetAimToTarget(Vector3 targetPos, out float g) { }

	// RVA: 0x557690 Offset: 0x555C90 VA: 0x180557690
	private static float ProjectileDistToSpeed(float x, float y, float angle, float g, float fallbackV) { }

	// RVA: 0x557560 Offset: 0x555B60 VA: 0x180557560
	private static float ProjectileDistToGravity(float x, float y, float θ, float v) { }

	// RVA: 0x557AF0 Offset: 0x5560F0 VA: 0x180557AF0
	public void .ctor() { }

	// RVA: 0x557AB0 Offset: 0x5560B0 VA: 0x180557AB0
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

	// RVA: 0xF2B60 Offset: 0xF1F60 VA: 0x1800F2B60
	public void .ctor(Vector3 pos, Vector3 forward, float gravityMult) { }

}

