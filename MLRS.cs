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

	// RVA: 0x1F28050 Offset: 0x1F26650 VA: 0x181F28050
	public static void ResetToPool(MLRS instance) { }

	// RVA: 0x1F27F90 Offset: 0x1F26590 VA: 0x181F27F90
	public void ResetToPool() { }

	// RVA: 0x1F27BE0 Offset: 0x1F261E0 VA: 0x181F27BE0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F268D0 Offset: 0x1F24ED0 VA: 0x181F268D0
	public void CopyTo(MLRS instance) { }

	// RVA: 0x1F26920 Offset: 0x1F24F20 VA: 0x181F26920
	public MLRS Copy() { }

	// RVA: 0x1F270D0 Offset: 0x1F256D0 VA: 0x181F270D0
	public static MLRS Deserialize(Stream stream) { }

	// RVA: 0x1F269C0 Offset: 0x1F24FC0 VA: 0x181F269C0
	public static MLRS DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F27040 Offset: 0x1F25640 VA: 0x181F27040
	public static MLRS DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F275A0 Offset: 0x1F25BA0 VA: 0x181F275A0
	public static MLRS Deserialize(byte[] buffer) { }

	// RVA: 0x1F27D20 Offset: 0x1F26320 VA: 0x181F27D20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F28A30 Offset: 0x1F27030 VA: 0x181F28A30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F28A50 Offset: 0x1F27050 VA: 0x181F28A50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MLRS previous) { }

	// RVA: 0x1F27F70 Offset: 0x1F26570 VA: 0x181F27F70 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F278D0 Offset: 0x1F25ED0 VA: 0x181F278D0
	public static MLRS Deserialize(byte[] buffer, MLRS instance, bool isDelta = False) { }

	// RVA: 0x1F27350 Offset: 0x1F25950 VA: 0x181F27350
	public static MLRS Deserialize(Stream stream, MLRS instance, bool isDelta) { }

	// RVA: 0x1F26A40 Offset: 0x1F25040 VA: 0x181F26A40
	public static MLRS DeserializeLengthDelimited(Stream stream, MLRS instance, bool isDelta) { }

	// RVA: 0x1F26D50 Offset: 0x1F25350 VA: 0x181F26D50
	public static MLRS DeserializeLength(Stream stream, int length, MLRS instance, bool isDelta) { }

	// RVA: 0x1F28110 Offset: 0x1F26710 VA: 0x181F28110
	public static void SerializeDelta(Stream stream, MLRS instance, MLRS previous) { }

	// RVA: 0x1F28770 Offset: 0x1F26D70 VA: 0x181F28770
	public static void Serialize(Stream stream, MLRS instance) { }

	// RVA: 0x1F28A20 Offset: 0x1F27020 VA: 0x181F28A20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F28A30 Offset: 0x1F27030 VA: 0x181F28A30
	public void ToProto(Stream stream) { }

	// RVA: 0x1F28660 Offset: 0x1F26C60 VA: 0x181F28660
	public static byte[] SerializeToBytes(MLRS instance) { }

	// RVA: 0x1F285B0 Offset: 0x1F26BB0 VA: 0x181F285B0
	public static void SerializeLengthDelimited(Stream stream, MLRS instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	[BaseEntity.Menu] // RVA: 0xF0CB0 Offset: 0xF00B0 VA: 0x1800F0CB0
	[BaseEntity.Menu.Description] // RVA: 0xF0CB0 Offset: 0xF00B0 VA: 0x1800F0CB0
	[BaseEntity.Menu.Icon] // RVA: 0xF0CB0 Offset: 0xF00B0 VA: 0x1800F0CB0
	[BaseEntity.Menu.ShowIf] // RVA: 0xF0CB0 Offset: 0xF00B0 VA: 0x1800F0CB0
	// RVA: 0x556D80 Offset: 0x555380 VA: 0x180556D80
	public void Menu_SetTarget(BasePlayer player) { }

	// RVA: 0x556C20 Offset: 0x555220 VA: 0x180556C20
	public bool Menu_SetTarget_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x6F4D0 Offset: 0x6E8D0 VA: 0x18006F4D0
	[BaseEntity.Menu.Description] // RVA: 0x6F4D0 Offset: 0x6E8D0 VA: 0x18006F4D0
	[BaseEntity.Menu.Icon] // RVA: 0x6F4D0 Offset: 0x6E8D0 VA: 0x18006F4D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x6F4D0 Offset: 0x6E8D0 VA: 0x18006F4D0
	// RVA: 0x556970 Offset: 0x554F70 VA: 0x180556970
	public void Menu_Fire_Rockets(BasePlayer player) { }

	// RVA: 0x556850 Offset: 0x554E50 VA: 0x180556850
	public bool Menu_Fire_Rockets_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x6FC80 Offset: 0x6F080 VA: 0x18006FC80
	[BaseEntity.Menu.Description] // RVA: 0x6FC80 Offset: 0x6F080 VA: 0x18006FC80
	[BaseEntity.Menu.Icon] // RVA: 0x6FC80 Offset: 0x6F080 VA: 0x18006FC80
	[BaseEntity.Menu.ShowIf] // RVA: 0x6FC80 Offset: 0x6F080 VA: 0x18006FC80
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Menu_Cannot_Fire_Rockets(BasePlayer player) { }

	// RVA: 0x556740 Offset: 0x554D40 VA: 0x180556740
	public bool Menu_Cannot_Fire_Rockets_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x700D0 Offset: 0x6F4D0 VA: 0x1800700D0
	[BaseEntity.Menu.Description] // RVA: 0x700D0 Offset: 0x6F4D0 VA: 0x1800700D0
	[BaseEntity.Menu.Icon] // RVA: 0x700D0 Offset: 0x6F4D0 VA: 0x1800700D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x700D0 Offset: 0x6F4D0 VA: 0x1800700D0
	// RVA: 0x556BE0 Offset: 0x5551E0 VA: 0x180556BE0
	public void Menu_Open_Rocket_Storage(BasePlayer player) { }

	// RVA: 0x556B10 Offset: 0x555110 VA: 0x180556B10
	public bool Menu_Open_Rocket_Storage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x70330 Offset: 0x6F730 VA: 0x180070330
	[BaseEntity.Menu.Description] // RVA: 0x70330 Offset: 0x6F730 VA: 0x180070330
	[BaseEntity.Menu.Icon] // RVA: 0x70330 Offset: 0x6F730 VA: 0x180070330
	[BaseEntity.Menu.ShowIf] // RVA: 0x70330 Offset: 0x6F730 VA: 0x180070330
	// RVA: 0x556AD0 Offset: 0x5550D0 VA: 0x180556AD0
	public void Menu_Open_Dashboard_Storage(BasePlayer player) { }

	// RVA: 0x556A00 Offset: 0x555000 VA: 0x180556A00
	public bool Menu_Open_Dashboard_Storage_ShowIf(BasePlayer player) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x557FB0 Offset: 0x5565B0 VA: 0x180557FB0
	public Vector3 get_UserTargetHitPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5580E0 Offset: 0x5566E0 VA: 0x1805580E0
	private void set_UserTargetHitPos(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x557F90 Offset: 0x556590 VA: 0x180557F90
	public Vector3 get_TrueHitPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x557C20 Offset: 0x556220 VA: 0x180557C20
	public float get_CurGravityMultiplier() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x558000 Offset: 0x556600 VA: 0x180558000
	private void set_CurGravityMultiplier(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x557F70 Offset: 0x556570 VA: 0x180557F70
	public int get_RocketAmmoCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5580A0 Offset: 0x5566A0 VA: 0x1805580A0
	private void set_RocketAmmoCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x557F60 Offset: 0x556560 VA: 0x180557F60
	public bool get_IsRealigning() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x558090 Offset: 0x556690 VA: 0x180558090
	private void set_IsRealigning(bool value) { }

	// RVA: 0x557F50 Offset: 0x556550 VA: 0x180557F50
	public bool get_IsFiringRockets() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x557F80 Offset: 0x556580 VA: 0x180557F80
	public float get_RocketDamageRadius() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0xF2AE0 Offset: 0xF1EE0 VA: 0x1800F2AE0
	public void .ctor(Vector3 pos, Vector3 forward, float gravityMult) { }

}

