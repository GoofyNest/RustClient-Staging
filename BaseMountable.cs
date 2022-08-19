public class BaseMountable : BaseCombatEntity // TypeDefIndex: 8330
{	// Fields
	private Option __menuOption_Menu_Mount; // 0x240
	public static Translate.Phrase dismountPhrase; // 0x0
	[HeaderAttribute] // RVA: 0xB92C0 Offset: 0xB86C0 VA: 0x1800B92C0
	[FormerlySerializedAsAttribute] // RVA: 0xB92C0 Offset: 0xB86C0 VA: 0x1800B92C0
	public Transform eyePositionOverride; // 0x298
	[FormerlySerializedAsAttribute] // RVA: 0xB95F0 Offset: 0xB89F0 VA: 0x1800B95F0
	public Transform eyeCenterOverride; // 0x2A0
	public Vector2 pitchClamp; // 0x2A8
	public Vector2 yawClamp; // 0x2B0
	public bool canWieldItems; // 0x2B8
	public bool relativeViewAngles; // 0x2B9
	[HeaderAttribute] // RVA: 0xB97A0 Offset: 0xB8BA0 VA: 0x1800B97A0
	public Transform mountAnchor; // 0x2C0
	public PlayerModel.MountPoses mountPose; // 0x2C8
	public float maxMountDistance; // 0x2CC
	public Transform[] dismountPositions; // 0x2D0
	public bool checkPlayerLosOnMount; // 0x2D8
	public bool disableMeshCullingForPlayers; // 0x2D9
	public bool allowHeadLook; // 0x2DA
	[FormerlySerializedAsAttribute] // RVA: 0xB9860 Offset: 0xB8C60 VA: 0x1800B9860
	public bool modifiesPlayerCollider; // 0x2DB
	public BasePlayer.CapsuleColliderInfo customPlayerCollider; // 0x2DC
	public SoundDefinition mountSoundDef; // 0x2F0
	public SoundDefinition swapSoundDef; // 0x2F8
	public SoundDefinition dismountSoundDef; // 0x300
	public BaseMountable.MountStatType mountTimeStatType; // 0x308
	public BaseMountable.MountGestureType allowedGestures; // 0x30C
	public bool canDrinkWhileMounted; // 0x310
	public bool allowSleeperMounting; // 0x311
	[HelpAttribute] // RVA: 0xB99D0 Offset: 0xB8DD0 VA: 0x1800B99D0
	public bool animateClothInLocalSpace; // 0x312
	[HeaderAttribute] // RVA: 0xABDD0 Offset: 0xAB1D0 VA: 0x1800ABDD0
	public BasePlayer.CameraMode MountedCameraMode; // 0x314
	[FormerlySerializedAsAttribute] // RVA: 0xB9BC0 Offset: 0xB8FC0 VA: 0x1800B9BC0
	public bool isMobile; // 0x318
	public float SideLeanAmount; // 0x31C

	// Properties
	public override bool HasMenuOptions { get; }
	public virtual bool DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes { get; }
	public virtual float FirstPersonWithArmsEyesLerp { get; }
	public virtual bool IsSummerDlcVehicle { get; }
	public virtual bool BlocksDoors { get; }

	// Methods

	// RVA: 0xA4AB70 Offset: 0xA49170 VA: 0x180A4AB70 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA4CC40 Offset: 0xA4B240 VA: 0x180A4CC40 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA4B960 Offset: 0xA49F60 VA: 0x180A4B960 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA49F70 Offset: 0xA48570 VA: 0x180A49F70 Slot: 145
	public virtual bool CanHoldItems() { }

	// RVA: 0xA4AED0 Offset: 0xA494D0 VA: 0x180A4AED0 Slot: 146
	public virtual BasePlayer.CameraMode GetMountedCameraMode() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 147
	public virtual bool DirectlyMountable() { }

	// RVA: 0xA4AAE0 Offset: 0xA490E0 VA: 0x180A4AAE0 Slot: 148
	public virtual Transform GetEyeOverride() { }

	// RVA: 0xA4AE80 Offset: 0xA49480 VA: 0x180A4AE80 Slot: 149
	public virtual Quaternion GetMountedBodyAngles() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 150
	public virtual bool ModifiesThirdPersonCamera() { }

	// RVA: 0x6D35A0 Offset: 0x6D1BA0 VA: 0x1806D35A0 Slot: 151
	public virtual Vector2 GetPitchClamp() { }

	// RVA: 0x6D35C0 Offset: 0x6D1BC0 VA: 0x1806D35C0 Slot: 152
	public virtual Vector2 GetYawClamp() { }

	// RVA: 0xA4B130 Offset: 0xA49730 VA: 0x180A4B130 Slot: 153
	public virtual bool IsMounted() { }

	// RVA: 0xA4A770 Offset: 0xA48D70 VA: 0x180A4A770 Slot: 154
	public virtual Vector3 EyePositionForPlayer(BasePlayer player, Quaternion lookRot) { }

	// RVA: 0xA4A670 Offset: 0xA48C70 VA: 0x180A4A670 Slot: 155
	public virtual Vector3 EyeCenterForPlayer(BasePlayer player, Quaternion lookRot) { }

	// RVA: 0xA4CA70 Offset: 0xA4B070 VA: 0x180A4CA70 Slot: 156
	public virtual float WaterFactorForPlayer(BasePlayer player) { }

	// RVA: 0xA4B270 Offset: 0xA49870 VA: 0x180A4B270 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0xA4BF60 Offset: 0xA4A560 VA: 0x180A4BF60 Slot: 157
	public virtual bool PlayerIsMounted(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 158
	public virtual void OnClientInput(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 159
	public virtual bool ForceUpdatePlayerModel(BasePlayer p) { }

	// RVA: 0xA4C4A0 Offset: 0xA4AAA0 VA: 0x180A4C4A0
	internal void UpdatePlayerModel(PlayerModel playerModel) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 160
	protected virtual void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 161
	protected virtual bool SuppressHandsAnimationLayer() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 162
	protected virtual AnimatorOverrideController GetAnimationOverride() { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 163
	protected virtual float GetSpineLookAtWeight() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 164
	public virtual float GetMountedAnimationSpeed() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 165
	public virtual bool get_DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes() { }

	// RVA: 0x714180 Offset: 0x712780 VA: 0x180714180 Slot: 166
	public virtual float get_FirstPersonWithArmsEyesLerp() { }

	// RVA: 0xA4B430 Offset: 0xA49A30 VA: 0x180A4B430 Slot: 167
	public virtual Vector3 ModifyThirdPersonEyeOffset(Vector3 eyeOffset) { }

	// RVA: 0xA4B200 Offset: 0xA49800 VA: 0x180A4B200 Slot: 168
	public virtual bool LockThirdPersonOffset(out Vector3 offset) { }

	// RVA: 0xA4B140 Offset: 0xA49740 VA: 0x180A4B140 Slot: 169
	public virtual bool LocalPlayerIsMounted() { }

	// RVA: 0xA4C9E0 Offset: 0xA4AFE0 VA: 0x180A4C9E0 Slot: 170
	public virtual BaseVehicle VehicleParent() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 171
	public virtual bool get_IsSummerDlcVehicle() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 172
	public virtual bool IsInstrument() { }

	// RVA: 0xA4C560 Offset: 0xA4AB60 VA: 0x180A4C560 Slot: 173
	public virtual void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xA4C930 Offset: 0xA4AF30 VA: 0x180A4C930 Slot: 174
	public virtual void UpdatePlayerRotation(BasePlayer player) { }

	// RVA: 0xA4C470 Offset: 0xA4AA70 VA: 0x180A4C470 Slot: 59
	public override void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0xA4C7C0 Offset: 0xA4ADC0 VA: 0x180A4C7C0
	public void UpdatePlayerPosition(BasePlayer player) { }

	// RVA: 0xA4AFA0 Offset: 0xA495A0 VA: 0x180A4AFA0 Slot: 175
	public virtual Quaternion GetMountedRotation() { }

	// RVA: 0xA4AEE0 Offset: 0xA494E0 VA: 0x180A4AEE0
	public Vector3 GetMountedPosition() { }

	// RVA: 0xA4C040 Offset: 0xA4A640 VA: 0x180A4C040 Slot: 176
	public virtual void PlayerMounted(BasePlayer player, bool wasSwap) { }

	// RVA: 0xA4BA80 Offset: 0xA4A080 VA: 0x180A4BA80 Slot: 177
	public virtual void PlayerDismounted(BasePlayer player, bool wasSwap) { }

	// RVA: 0xA49F80 Offset: 0xA48580 VA: 0x180A49F80 Slot: 178
	protected virtual void ClientOnPlayerDismounted(BasePlayer player) { }

	// RVA: 0xA4A020 Offset: 0xA48620 VA: 0x180A4A020 Slot: 179
	protected virtual void ClientOnPlayerMounted(BasePlayer player) { }

	// RVA: 0xA4BA50 Offset: 0xA4A050 VA: 0x180A4BA50 Slot: 180
	public virtual void OverrideViewAngles(BasePlayer player) { }

	// RVA: 0xA4A200 Offset: 0xA48800 VA: 0x180A4A200 Slot: 181
	public virtual void DoPlayerMovement(BasePlayer player, InputState input, ModelState modelState) { }

	// RVA: 0xA4B0B0 Offset: 0xA496B0 VA: 0x180A4B0B0 Slot: 182
	protected virtual bool HoldToDismount() { }

	// RVA: 0xA4A0F0 Offset: 0xA486F0 VA: 0x180A4A0F0
	public void ClientRequestDismount() { }

	[BaseEntity.Menu] // RVA: 0x7A9D0 Offset: 0x79DD0 VA: 0x18007A9D0
	[BaseEntity.Menu.Description] // RVA: 0x7A9D0 Offset: 0x79DD0 VA: 0x18007A9D0
	[BaseEntity.Menu.Icon] // RVA: 0x7A9D0 Offset: 0x79DD0 VA: 0x18007A9D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7A9D0 Offset: 0x79DD0 VA: 0x18007A9D0
	// RVA: 0xA4B3C0 Offset: 0xA499C0 VA: 0x180A4B3C0
	public void Menu_Mount(BasePlayer player) { }

	// RVA: 0xA4B320 Offset: 0xA49920 VA: 0x180A4B320 Slot: 183
	public virtual bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0xA4B450 Offset: 0xA49A50 VA: 0x180A4B450 Slot: 184
	public virtual bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0xA4B4E0 Offset: 0xA49AE0 VA: 0x180A4B4E0
	public bool NearMountPoint(BasePlayer player) { }

	// RVA: 0xA4A130 Offset: 0xA48730 VA: 0x180A4A130
	public static Vector3 ConvertVector(Vector3 vec) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 185
	public virtual bool get_BlocksDoors() { }

	// RVA: 0xA4CB90 Offset: 0xA4B190 VA: 0x180A4CB90
	public void .ctor() { }

	// RVA: 0xA4CB20 Offset: 0xA4B120 VA: 0x180A4CB20
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA4A0F0 Offset: 0xA486F0 VA: 0x180A4A0F0
	private void <DoPlayerMovement>b__78_0(BasePlayer basePlayer) { }

}

public enum BaseMountable.MountStatType // TypeDefIndex: 8331
{	// Fields
	public int value__; // 0x0
	public const BaseMountable.MountStatType None = 0;
	public const BaseMountable.MountStatType Boating = 1;
	public const BaseMountable.MountStatType Flying = 2;
	public const BaseMountable.MountStatType Driving = 3;

}

public enum BaseMountable.MountGestureType // TypeDefIndex: 8332
{	// Fields
	public int value__; // 0x0
	public const BaseMountable.MountGestureType None = 0;
	public const BaseMountable.MountGestureType UpperBody = 1;

}

