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

	// RVA: 0xA4AE30 Offset: 0xA49430 VA: 0x180A4AE30 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA4CF00 Offset: 0xA4B500 VA: 0x180A4CF00 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA4BC20 Offset: 0xA4A220 VA: 0x180A4BC20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA4A230 Offset: 0xA48830 VA: 0x180A4A230 Slot: 145
	public virtual bool CanHoldItems() { }

	// RVA: 0xA4B190 Offset: 0xA49790 VA: 0x180A4B190 Slot: 146
	public virtual BasePlayer.CameraMode GetMountedCameraMode() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 147
	public virtual bool DirectlyMountable() { }

	// RVA: 0xA4ADA0 Offset: 0xA493A0 VA: 0x180A4ADA0 Slot: 148
	public virtual Transform GetEyeOverride() { }

	// RVA: 0xA4B140 Offset: 0xA49740 VA: 0x180A4B140 Slot: 149
	public virtual Quaternion GetMountedBodyAngles() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 150
	public virtual bool ModifiesThirdPersonCamera() { }

	// RVA: 0x6D36B0 Offset: 0x6D1CB0 VA: 0x1806D36B0 Slot: 151
	public virtual Vector2 GetPitchClamp() { }

	// RVA: 0x6D36D0 Offset: 0x6D1CD0 VA: 0x1806D36D0 Slot: 152
	public virtual Vector2 GetYawClamp() { }

	// RVA: 0xA4B3F0 Offset: 0xA499F0 VA: 0x180A4B3F0 Slot: 153
	public virtual bool IsMounted() { }

	// RVA: 0xA4AA30 Offset: 0xA49030 VA: 0x180A4AA30 Slot: 154
	public virtual Vector3 EyePositionForPlayer(BasePlayer player, Quaternion lookRot) { }

	// RVA: 0xA4A930 Offset: 0xA48F30 VA: 0x180A4A930 Slot: 155
	public virtual Vector3 EyeCenterForPlayer(BasePlayer player, Quaternion lookRot) { }

	// RVA: 0xA4CD30 Offset: 0xA4B330 VA: 0x180A4CD30 Slot: 156
	public virtual float WaterFactorForPlayer(BasePlayer player) { }

	// RVA: 0xA4B530 Offset: 0xA49B30 VA: 0x180A4B530 Slot: 112
	public override float MaxVelocity() { }

	// RVA: 0xA4C220 Offset: 0xA4A820 VA: 0x180A4C220 Slot: 157
	public virtual bool PlayerIsMounted(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 158
	public virtual void OnClientInput(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 159
	public virtual bool ForceUpdatePlayerModel(BasePlayer p) { }

	// RVA: 0xA4C760 Offset: 0xA4AD60 VA: 0x180A4C760
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

	// RVA: 0x714290 Offset: 0x712890 VA: 0x180714290 Slot: 166
	public virtual float get_FirstPersonWithArmsEyesLerp() { }

	// RVA: 0xA4B6F0 Offset: 0xA49CF0 VA: 0x180A4B6F0 Slot: 167
	public virtual Vector3 ModifyThirdPersonEyeOffset(Vector3 eyeOffset) { }

	// RVA: 0xA4B4C0 Offset: 0xA49AC0 VA: 0x180A4B4C0 Slot: 168
	public virtual bool LockThirdPersonOffset(out Vector3 offset) { }

	// RVA: 0xA4B400 Offset: 0xA49A00 VA: 0x180A4B400 Slot: 169
	public virtual bool LocalPlayerIsMounted() { }

	// RVA: 0xA4CCA0 Offset: 0xA4B2A0 VA: 0x180A4CCA0 Slot: 170
	public virtual BaseVehicle VehicleParent() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 171
	public virtual bool get_IsSummerDlcVehicle() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 172
	public virtual bool IsInstrument() { }

	// RVA: 0xA4C820 Offset: 0xA4AE20 VA: 0x180A4C820 Slot: 173
	public virtual void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0xA4CBF0 Offset: 0xA4B1F0 VA: 0x180A4CBF0 Slot: 174
	public virtual void UpdatePlayerRotation(BasePlayer player) { }

	// RVA: 0xA4C730 Offset: 0xA4AD30 VA: 0x180A4C730 Slot: 59
	public override void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0xA4CA80 Offset: 0xA4B080 VA: 0x180A4CA80
	public void UpdatePlayerPosition(BasePlayer player) { }

	// RVA: 0xA4B260 Offset: 0xA49860 VA: 0x180A4B260 Slot: 175
	public virtual Quaternion GetMountedRotation() { }

	// RVA: 0xA4B1A0 Offset: 0xA497A0 VA: 0x180A4B1A0
	public Vector3 GetMountedPosition() { }

	// RVA: 0xA4C300 Offset: 0xA4A900 VA: 0x180A4C300 Slot: 176
	public virtual void PlayerMounted(BasePlayer player, bool wasSwap) { }

	// RVA: 0xA4BD40 Offset: 0xA4A340 VA: 0x180A4BD40 Slot: 177
	public virtual void PlayerDismounted(BasePlayer player, bool wasSwap) { }

	// RVA: 0xA4A240 Offset: 0xA48840 VA: 0x180A4A240 Slot: 178
	protected virtual void ClientOnPlayerDismounted(BasePlayer player) { }

	// RVA: 0xA4A2E0 Offset: 0xA488E0 VA: 0x180A4A2E0 Slot: 179
	protected virtual void ClientOnPlayerMounted(BasePlayer player) { }

	// RVA: 0xA4BD10 Offset: 0xA4A310 VA: 0x180A4BD10 Slot: 180
	public virtual void OverrideViewAngles(BasePlayer player) { }

	// RVA: 0xA4A4C0 Offset: 0xA48AC0 VA: 0x180A4A4C0 Slot: 181
	public virtual void DoPlayerMovement(BasePlayer player, InputState input, ModelState modelState) { }

	// RVA: 0xA4B370 Offset: 0xA49970 VA: 0x180A4B370 Slot: 182
	protected virtual bool HoldToDismount() { }

	// RVA: 0xA4A3B0 Offset: 0xA489B0 VA: 0x180A4A3B0
	public void ClientRequestDismount() { }

	[BaseEntity.Menu] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	[BaseEntity.Menu.Description] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	[BaseEntity.Menu.Icon] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	[BaseEntity.Menu.ShowIf] // RVA: 0x7AB20 Offset: 0x79F20 VA: 0x18007AB20
	// RVA: 0xA4B680 Offset: 0xA49C80 VA: 0x180A4B680
	public void Menu_Mount(BasePlayer player) { }

	// RVA: 0xA4B5E0 Offset: 0xA49BE0 VA: 0x180A4B5E0 Slot: 183
	public virtual bool Menu_Mount_ShowIf(BasePlayer player) { }

	// RVA: 0xA4B710 Offset: 0xA49D10 VA: 0x180A4B710 Slot: 184
	public virtual bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0xA4B7A0 Offset: 0xA49DA0 VA: 0x180A4B7A0
	public bool NearMountPoint(BasePlayer player) { }

	// RVA: 0xA4A3F0 Offset: 0xA489F0 VA: 0x180A4A3F0
	public static Vector3 ConvertVector(Vector3 vec) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 185
	public virtual bool get_BlocksDoors() { }

	// RVA: 0xA4CE50 Offset: 0xA4B450 VA: 0x180A4CE50
	public void .ctor() { }

	// RVA: 0xA4CDE0 Offset: 0xA4B3E0 VA: 0x180A4CDE0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA4A3B0 Offset: 0xA489B0 VA: 0x180A4A3B0
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

