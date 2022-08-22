public class BaseMountable : BaseCombatEntity // TypeDefIndex: 8330
{	// Fields
	private Option __menuOption_Menu_Mount; // 0x240
	public static Translate.Phrase dismountPhrase; // 0x0
	[HeaderAttribute] // RVA: 0xB9360 Offset: 0xB8760 VA: 0x1800B9360
	[FormerlySerializedAsAttribute] // RVA: 0xB9360 Offset: 0xB8760 VA: 0x1800B9360
	public Transform eyePositionOverride; // 0x298
	[FormerlySerializedAsAttribute] // RVA: 0xB9690 Offset: 0xB8A90 VA: 0x1800B9690
	public Transform eyeCenterOverride; // 0x2A0
	public Vector2 pitchClamp; // 0x2A8
	public Vector2 yawClamp; // 0x2B0
	public bool canWieldItems; // 0x2B8
	public bool relativeViewAngles; // 0x2B9
	[HeaderAttribute] // RVA: 0xB9840 Offset: 0xB8C40 VA: 0x1800B9840
	public Transform mountAnchor; // 0x2C0
	public PlayerModel.MountPoses mountPose; // 0x2C8
	public float maxMountDistance; // 0x2CC
	public Transform[] dismountPositions; // 0x2D0
	public bool checkPlayerLosOnMount; // 0x2D8
	public bool disableMeshCullingForPlayers; // 0x2D9
	public bool allowHeadLook; // 0x2DA
	[FormerlySerializedAsAttribute] // RVA: 0xB9930 Offset: 0xB8D30 VA: 0x1800B9930
	public bool modifiesPlayerCollider; // 0x2DB
	public BasePlayer.CapsuleColliderInfo customPlayerCollider; // 0x2DC
	public SoundDefinition mountSoundDef; // 0x2F0
	public SoundDefinition swapSoundDef; // 0x2F8
	public SoundDefinition dismountSoundDef; // 0x300
	public BaseMountable.MountStatType mountTimeStatType; // 0x308
	public BaseMountable.MountGestureType allowedGestures; // 0x30C
	public bool canDrinkWhileMounted; // 0x310
	public bool allowSleeperMounting; // 0x311
	[HelpAttribute] // RVA: 0xB9A70 Offset: 0xB8E70 VA: 0x1800B9A70
	public bool animateClothInLocalSpace; // 0x312
	[HeaderAttribute] // RVA: 0xABE70 Offset: 0xAB270 VA: 0x1800ABE70
	public BasePlayer.CameraMode MountedCameraMode; // 0x314
	[FormerlySerializedAsAttribute] // RVA: 0xB9CC0 Offset: 0xB90C0 VA: 0x1800B9CC0
	public bool isMobile; // 0x318
	public float SideLeanAmount; // 0x31C

	// Properties
	public override bool HasMenuOptions { get; }
	public virtual bool DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes { get; }
	public virtual float FirstPersonWithArmsEyesLerp { get; }
	public virtual bool IsSummerDlcVehicle { get; }
	public virtual bool BlocksDoors { get; }

	// Methods

	// RVA: 0xA4B320 Offset: 0xA49920 VA: 0x180A4B320 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA4D3F0 Offset: 0xA4B9F0 VA: 0x180A4D3F0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA4C110 Offset: 0xA4A710 VA: 0x180A4C110 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA4A720 Offset: 0xA48D20 VA: 0x180A4A720 Slot: 145
	public virtual bool CanHoldItems() { }

	// RVA: 0xA4B680 Offset: 0xA49C80 VA: 0x180A4B680 Slot: 146
	public virtual BasePlayer.CameraMode GetMountedCameraMode() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 147
	public virtual bool DirectlyMountable() { }

	// RVA: 0xA4B290 Offset: 0xA49890 VA: 0x180A4B290 Slot: 148
	public virtual Transform GetEyeOverride() { }

	// RVA: 0xA4B630 Offset: 0xA49C30 VA: 0x180A4B630 Slot: 149
	public virtual Quaternion GetMountedBodyAngles() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 150
	public virtual bool ModifiesThirdPersonCamera() { }

	// RVA: 0x6D3640 Offset: 0x6D1C40 VA: 0x1806D3640 Slot: 151
	public virtual Vector2 GetPitchClamp() { }

	// RVA: 0x6D3660 Offset: 0x6D1C60 VA: 0x1806D3660 Slot: 152
	public virtual Vector2 GetYawClamp() { }

	// RVA: 0xA4B8E0 Offset: 0xA49EE0 VA: 0x180A4B8E0 Slot: 153
	public virtual bool IsMounted() { }

	// RVA: 0xA4AF20 Offset: 0xA49520 VA: 0x180A4AF20 Slot: 154
	public virtual Vector3 EyePositionForPlayer(BasePlayer player, Quaternion lookRot) { }

	// RVA: 0xA4AE20 Offset: 0xA49420 VA: 0x180A4AE20 Slot: 155
	public virtual Vector3 EyeCenterForPlayer(BasePlayer player, Quaternion lookRot) { }

	// RVA: 0xA4D220 Offset: 0xA4B820 VA: 0x180A4D220 Slot: 156
	public virtual float WaterFactorForPlayer(BasePlayer player) { }

	// RVA: 0xA4BA20 Offset: 0xA4A020 VA: 0x180A4BA20 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0xA4C710 Offset: 0xA4AD10 VA: 0x180A4C710 Slot: 157
	public virtual bool PlayerIsMounted(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 158
	public virtual void OnClientInput(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 159
	public virtual bool ForceUpdatePlayerModel(BasePlayer p) { }

	// RVA: 0xA4CC50 Offset: 0xA4B250 VA: 0x180A4CC50
	internal void UpdatePlayerModel(PlayerModel playerModel) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 160
	protected virtual void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 161
	protected virtual bool SuppressHandsAnimationLayer() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 162
	protected virtual AnimatorOverrideController GetAnimationOverride() { }

	// RVA: 0x4C3890 Offset: 0x4C1E90 VA: 0x1804C3890 Slot: 163
	protected virtual float GetSpineLookAtWeight() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 164
	public virtual float GetMountedAnimationSpeed() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 165
	public virtual bool get_DisableLegsMeshAtExtremeViewAnglesInFirstPersonWithEyes() { }

	// RVA: 0x7141E0 Offset: 0x7127E0 VA: 0x1807141E0 Slot: 166
	public virtual float get_FirstPersonWithArmsEyesLerp() { }

	// RVA: 0xA4BBE0 Offset: 0xA4A1E0 VA: 0x180A4BBE0 Slot: 167
	public virtual Vector3 ModifyThirdPersonEyeOffset(Vector3 eyeOffset) { }

	// RVA: 0xA4B9B0 Offset: 0xA49FB0 VA: 0x180A4B9B0 Slot: 168
	public virtual bool LockThirdPersonOffset(out Vector3 offset) { }

	// RVA: 0xA4B8F0 Offset: 0xA49EF0 VA: 0x180A4B8F0 Slot: 169
	public virtual bool LocalPlayerIsMounted() { }

	// RVA: 0xA4D190 Offset: 0xA4B790 VA: 0x180A4D190 Slot: 170
	public virtual BaseVehicle VehicleParent() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 171
	public virtual bool get_IsSummerDlcVehicle() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 172
	public virtual bool IsInstrument() { }

	// RVA: 0xA4CD10 Offset: 0xA4B310 VA: 0x180A4CD10 Slot: 173
	public virtual void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xA4D0E0 Offset: 0xA4B6E0 VA: 0x180A4D0E0 Slot: 174
	public virtual void UpdatePlayerRotation(BasePlayer player) { }

	// RVA: 0xA4CC20 Offset: 0xA4B220 VA: 0x180A4CC20 Slot: 59
	public override void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0xA4CF70 Offset: 0xA4B570 VA: 0x180A4CF70
	public void UpdatePlayerPosition(BasePlayer player) { }

	// RVA: 0xA4B750 Offset: 0xA49D50 VA: 0x180A4B750 Slot: 175
	public virtual Quaternion GetMountedRotation() { }

	// RVA: 0xA4B690 Offset: 0xA49C90 VA: 0x180A4B690
	public Vector3 GetMountedPosition() { }

	// RVA: 0xA4C7F0 Offset: 0xA4ADF0 VA: 0x180A4C7F0 Slot: 176
	public virtual void PlayerMounted(BasePlayer player, bool wasSwap) { }

	// RVA: 0xA4C230 Offset: 0xA4A830 VA: 0x180A4C230 Slot: 177
	public virtual void PlayerDismounted(BasePlayer player, bool wasSwap) { }

	// RVA: 0xA4A730 Offset: 0xA48D30 VA: 0x180A4A730 Slot: 178
	protected virtual void ClientOnPlayerDismounted(BasePlayer player) { }

	// RVA: 0xA4A7D0 Offset: 0xA48DD0 VA: 0x180A4A7D0 Slot: 179
	protected virtual void ClientOnPlayerMounted(BasePlayer player) { }

	// RVA: 0xA4C200 Offset: 0xA4A800 VA: 0x180A4C200 Slot: 180
	public virtual void OverrideViewAngles(BasePlayer player) { }

	// RVA: 0xA4A9B0 Offset: 0xA48FB0 VA: 0x180A4A9B0 Slot: 181
	public virtual void DoPlayerMovement(BasePlayer player, InputState input, ModelState modelState) { }

	// RVA: 0xA4B860 Offset: 0xA49E60 VA: 0x180A4B860 Slot: 182
	protected virtual bool HoldToDismount() { }

	// RVA: 0xA4A8A0 Offset: 0xA48EA0 VA: 0x180A4A8A0
	public void ClientRequestDismount() { }

	[BaseEntity.Menu] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	[BaseEntity.Menu.Description] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	[BaseEntity.Menu.Icon] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	[BaseEntity.Menu.ShowIf] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	// RVA: 0xA4BB70 Offset: 0xA4A170 VA: 0x180A4BB70
	public void Menu_Mount(BasePlayer player) { }

	// RVA: 0xA4BAD0 Offset: 0xA4A0D0 VA: 0x180A4BAD0 Slot: 183
	public virtual bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0xA4BC00 Offset: 0xA4A200 VA: 0x180A4BC00 Slot: 184
	public virtual bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0xA4BC90 Offset: 0xA4A290 VA: 0x180A4BC90
	public bool NearMountPoint(BasePlayer player) { }

	// RVA: 0xA4A8E0 Offset: 0xA48EE0 VA: 0x180A4A8E0
	public static Vector3 ConvertVector(Vector3 vec) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 185
	public virtual bool get_BlocksDoors() { }

	// RVA: 0xA4D340 Offset: 0xA4B940 VA: 0x180A4D340
	public void .ctor() { }

	// RVA: 0xA4D2D0 Offset: 0xA4B8D0 VA: 0x180A4D2D0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4A8A0 Offset: 0xA48EA0 VA: 0x180A4A8A0
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

