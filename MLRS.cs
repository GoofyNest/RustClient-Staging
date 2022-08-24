public class MLRS : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6422
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 targetPos; // 0x14
	public Vector3 curHitPos; // 0x20
	public uint rocketStorageID; // 0x2C
	public uint dashboardStorageID; // 0x30
	public uint ammoCount; // 0x34


	public static void ResetToPool(MLRS instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(MLRS instance) { }

	public MLRS Copy() { }

	public static MLRS Deserialize(Stream stream) { }

	public static MLRS DeserializeLengthDelimited(Stream stream) { }

	public static MLRS DeserializeLength(Stream stream, int length) { }

	public static MLRS Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, MLRS previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static MLRS Deserialize(byte[] buffer, MLRS instance, bool isDelta = False) { }

	public static MLRS Deserialize(Stream stream, MLRS instance, bool isDelta) { }

	public static MLRS DeserializeLengthDelimited(Stream stream, MLRS instance, bool isDelta) { }

	public static MLRS DeserializeLength(Stream stream, int length, MLRS instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, MLRS instance, MLRS previous) { }

	public static void Serialize(Stream stream, MLRS instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(MLRS instance) { }

	public static void SerializeLengthDelimited(Stream stream, MLRS instance) { }

	public void .ctor() { }

}

public class MLRS : BaseMountable // TypeDefIndex: 8412
{	private Option __menuOption_Menu_Cannot_Fire_Rockets; // 0x320
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
	[HeaderAttribute] // RVA: 0xEE830 Offset: 0xEDC30 VA: 0x1800EE830
	[SerializeField] // RVA: 0xEE830 Offset: 0xEDC30 VA: 0x1800EE830
	private GameObjectRef rocketStoragePrefab; // 0x508
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObjectRef dashboardStoragePrefab; // 0x510
	[HeaderAttribute] // RVA: 0xEEAD0 Offset: 0xEDED0 VA: 0x1800EEAD0
	[SerializeField] // RVA: 0xEEAD0 Offset: 0xEDED0 VA: 0x1800EEAD0
	private Transform hRotator; // 0x518
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float hRotSpeed; // 0x520
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform vRotator; // 0x528
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float vRotSpeed; // 0x530
	[SerializeField] // RVA: 0xEF020 Offset: 0xEE420 VA: 0x1800EF020
	[RangeAttribute] // RVA: 0xEF020 Offset: 0xEE420 VA: 0x1800EF020
	private float vRotMax; // 0x534
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform hydraulics; // 0x538
	[HeaderAttribute] // RVA: 0xEF440 Offset: 0xEE840 VA: 0x1800EF440
	[TooltipAttribute] // RVA: 0xEF440 Offset: 0xEE840 VA: 0x1800EF440
	[SerializeField] // RVA: 0xEF440 Offset: 0xEE840 VA: 0x1800EF440
	public float minRange; // 0x540
	[TooltipAttribute] // RVA: 0xEF830 Offset: 0xEEC30 VA: 0x1800EF830
	[SerializeField] // RVA: 0xEF830 Offset: 0xEEC30 VA: 0x1800EF830
	public float targetAreaRadius; // 0x544
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObjectRef mlrsRocket; // 0x548
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Transform firingPoint; // 0x550
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private MLRS.RocketTube[] rocketTubes; // 0x558
	[HeaderAttribute] // RVA: 0xEFD10 Offset: 0xEF110 VA: 0x1800EFD10
	[SerializeField] // RVA: 0xEFD10 Offset: 0xEF110 VA: 0x1800EFD10
	private GameObject screensChild; // 0x560
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform leftHandGrip; // 0x568
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform leftJoystick; // 0x570
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform rightHandGrip; // 0x578
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform rightJoystick; // 0x580
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform controlKnobHeight; // 0x588
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform controlKnobAngle; // 0x590
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObjectRef uiDialogPrefab; // 0x598
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Light fireButtonLight; // 0x5A0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private GameObject brokenDownEffect; // 0x5A8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem topScreenShutdown; // 0x5B0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private ParticleSystem bottomScreenShutdown; // 0x5B8
	[ServerVar] // RVA: 0xF0640 Offset: 0xEFA40 VA: 0x1800F0640
	public static float brokenDownMinutes; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Vector3 <UserTargetHitPos>k__BackingField; // 0x5C0
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Vector3 <TrueHitPos>k__BackingField; // 0x5CC
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float <CurGravityMultiplier>k__BackingField; // 0x5D8
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int <RocketAmmoCount>k__BackingField; // 0x5DC
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool <IsRealigning>k__BackingField; // 0x5E0
	public const BaseEntity.Flags FLAG_FIRING_ROCKETS = 16384;
	public const BaseEntity.Flags FLAG_HAS_AIMING_MODULE = 65536;
	private EntityRef rocketStorageInstance; // 0x5E8
	private EntityRef dashboardStorageInstance; // 0x5F8
	private float rocketBaseGravity; // 0x608
	private float rocketSpeed; // 0x60C
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float <RocketDamageRadius>k__BackingField; // 0x610
	private bool isInitialLoad; // 0x614

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


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	protected void LateUpdate() { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public void SendNewTargetHitPos(Vector3 worldPos) { }

	protected override bool HideMenuItems(BasePlayer player) { }

	private void PositionVisuals() { }

	private void ShowFullscreenMap() { }

	public void OnFullscreenMapClosed() { }

	private bool ShouldShowDashboardUI() { }

	[BaseEntity.Menu] // RVA: 0xF0D70 Offset: 0xF0170 VA: 0x1800F0D70
	[BaseEntity.Menu.Description] // RVA: 0xF0D70 Offset: 0xF0170 VA: 0x1800F0D70
	[BaseEntity.Menu.Icon] // RVA: 0xF0D70 Offset: 0xF0170 VA: 0x1800F0D70
	[BaseEntity.Menu.ShowIf] // RVA: 0xF0D70 Offset: 0xF0170 VA: 0x1800F0D70
	public void Menu_SetTarget(BasePlayer player) { }

	public bool Menu_SetTarget_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x6F5F0 Offset: 0x6E9F0 VA: 0x18006F5F0
	[BaseEntity.Menu.Description] // RVA: 0x6F5F0 Offset: 0x6E9F0 VA: 0x18006F5F0
	[BaseEntity.Menu.Icon] // RVA: 0x6F5F0 Offset: 0x6E9F0 VA: 0x18006F5F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x6F5F0 Offset: 0x6E9F0 VA: 0x18006F5F0
	public void Menu_Fire_Rockets(BasePlayer player) { }

	public bool Menu_Fire_Rockets_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x6FD50 Offset: 0x6F150 VA: 0x18006FD50
	[BaseEntity.Menu.Description] // RVA: 0x6FD50 Offset: 0x6F150 VA: 0x18006FD50
	[BaseEntity.Menu.Icon] // RVA: 0x6FD50 Offset: 0x6F150 VA: 0x18006FD50
	[BaseEntity.Menu.ShowIf] // RVA: 0x6FD50 Offset: 0x6F150 VA: 0x18006FD50
	public void Menu_Cannot_Fire_Rockets(BasePlayer player) { }

	public bool Menu_Cannot_Fire_Rockets_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x701A0 Offset: 0x6F5A0 VA: 0x1800701A0
	[BaseEntity.Menu.Description] // RVA: 0x701A0 Offset: 0x6F5A0 VA: 0x1800701A0
	[BaseEntity.Menu.Icon] // RVA: 0x701A0 Offset: 0x6F5A0 VA: 0x1800701A0
	[BaseEntity.Menu.ShowIf] // RVA: 0x701A0 Offset: 0x6F5A0 VA: 0x1800701A0
	public void Menu_Open_Rocket_Storage(BasePlayer player) { }

	public bool Menu_Open_Rocket_Storage_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x703F0 Offset: 0x6F7F0 VA: 0x1800703F0
	[BaseEntity.Menu.Description] // RVA: 0x703F0 Offset: 0x6F7F0 VA: 0x1800703F0
	[BaseEntity.Menu.Icon] // RVA: 0x703F0 Offset: 0x6F7F0 VA: 0x1800703F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x703F0 Offset: 0x6F7F0 VA: 0x1800703F0
	public void Menu_Open_Dashboard_Storage(BasePlayer player) { }

	public bool Menu_Open_Dashboard_Storage_ShowIf(BasePlayer player) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Vector3 get_UserTargetHitPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_UserTargetHitPos(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public Vector3 get_TrueHitPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_TrueHitPos(Vector3 value) { }

	public bool get_HasAimingModule() { }

	private bool get_CanBeUsed() { }

	private bool get_CanFire() { }

	private float get_HRotation() { }

	private void set_HRotation(float value) { }

	private float get_VRotation() { }

	private void set_VRotation(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_CurGravityMultiplier() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_CurGravityMultiplier(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public int get_RocketAmmoCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_RocketAmmoCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool get_IsRealigning() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_IsRealigning(bool value) { }

	public bool get_IsFiringRockets() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_RocketDamageRadius() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_RocketDamageRadius(float value) { }

	public override void InitShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override bool CanBeLooted(BasePlayer player) { }

	private void SetUserTargetHitPos(Vector3 worldPos) { }

	private StorageContainer GetRocketContainer() { }

	private StorageContainer GetDashboardContainer() { }

	private void HitPosToRotation(Vector3 hitPos, out float hRot, out float vRot, out float g) { }

	private Vector3 GetAimToTarget(Vector3 targetPos, out float g) { }

	private static float ProjectileDistToSpeed(float x, float y, float angle, float g, float fallbackV) { }

	private static float ProjectileDistToGravity(float x, float y, float θ, float v) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class MLRS.RocketTube // TypeDefIndex: 8413
{	public Vector3 firingOffset; // 0x10
	public Transform hinge; // 0x20
	public Renderer rocket; // 0x28


	public void .ctor() { }

}

private struct MLRS.TheoreticalProjectile // TypeDefIndex: 8414
{	public Vector3 pos; // 0x0
	public Vector3 forward; // 0xC
	public float gravityMult; // 0x18


	public void .ctor(Vector3 pos, Vector3 forward, float gravityMult) { }

}

