public class HeldEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6312
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint itemUID; // 0x14

	// Methods

	// RVA: 0x1D65B70 Offset: 0x1D64170 VA: 0x181D65B70
	public static void ResetToPool(HeldEntity instance) { }

	// RVA: 0x1D65BF0 Offset: 0x1D641F0 VA: 0x181D65BF0
	public void ResetToPool() { }

	// RVA: 0x1D65A40 Offset: 0x1D64040 VA: 0x181D65A40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(HeldEntity instance) { }

	// RVA: 0x1D650C0 Offset: 0x1D636C0 VA: 0x181D650C0
	public HeldEntity Copy() { }

	// RVA: 0x1D658C0 Offset: 0x1D63EC0 VA: 0x181D658C0
	public static HeldEntity Deserialize(Stream stream) { }

	// RVA: 0x1D65130 Offset: 0x1D63730 VA: 0x181D65130
	public static HeldEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D655D0 Offset: 0x1D63BD0 VA: 0x181D655D0
	public static HeldEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D657A0 Offset: 0x1D63DA0 VA: 0x181D657A0
	public static HeldEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1D65B30 Offset: 0x1D64130 VA: 0x181D65B30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D660C0 Offset: 0x1D646C0 VA: 0x181D660C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D66190 Offset: 0x1D64790 VA: 0x181D66190 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HeldEntity previous) { }

	// RVA: 0x1D65B50 Offset: 0x1D64150 VA: 0x181D65B50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D65940 Offset: 0x1D63F40 VA: 0x181D65940
	public static HeldEntity Deserialize(byte[] buffer, HeldEntity instance, bool isDelta = False) { }

	// RVA: 0x1D65660 Offset: 0x1D63C60 VA: 0x181D65660
	public static HeldEntity Deserialize(Stream stream, HeldEntity instance, bool isDelta) { }

	// RVA: 0x1D651B0 Offset: 0x1D637B0 VA: 0x181D651B0
	public static HeldEntity DeserializeLengthDelimited(Stream stream, HeldEntity instance, bool isDelta) { }

	// RVA: 0x1D653D0 Offset: 0x1D639D0 VA: 0x181D653D0
	public static HeldEntity DeserializeLength(Stream stream, int length, HeldEntity instance, bool isDelta) { }

	// RVA: 0x1D65C70 Offset: 0x1D64270 VA: 0x181D65C70
	public static void SerializeDelta(Stream stream, HeldEntity instance, HeldEntity previous) { }

	// RVA: 0x1D65FE0 Offset: 0x1D645E0 VA: 0x181D65FE0
	public static void Serialize(Stream stream, HeldEntity instance) { }

	// RVA: 0x1D660B0 Offset: 0x1D646B0 VA: 0x181D660B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D660C0 Offset: 0x1D646C0 VA: 0x181D660C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D65E30 Offset: 0x1D64430 VA: 0x181D65E30
	public static byte[] SerializeToBytes(HeldEntity instance) { }

	// RVA: 0x1D65D80 Offset: 0x1D64380 VA: 0x181D65D80
	public static void SerializeLengthDelimited(Stream stream, HeldEntity instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class HeldEntity : BaseEntity // TypeDefIndex: 8575
{	// Fields
	protected List<HeldEntity.PunchEntry> _punches; // 0x168
	protected Vector3 punchAdded; // 0x170
	protected float lastPunchTime; // 0x17C
	public Animator worldModelAnimator; // 0x180
	public SoundDefinition thirdPersonDeploySound; // 0x188
	public SoundDefinition thirdPersonAimSound; // 0x190
	public SoundDefinition thirdPersonAimEndSound; // 0x198
	protected ViewModel viewModel; // 0x1A0
	protected bool isDeployed; // 0x1A8
	public static float lastExamineTime; // 0x0
	private float nextExamineTime; // 0x1AC
	public const BaseEntity.Flags Flag_ForceVisible = 65536;
	[HeaderAttribute] // RVA: 0xABCB0 Offset: 0xAB0B0 VA: 0x1800ABCB0
	public string handBone; // 0x1B0
	public AnimatorOverrideController HoldAnimationOverride; // 0x1B8
	public bool isBuildingTool; // 0x1C0
	[HeaderAttribute] // RVA: 0xABD80 Offset: 0xAB180 VA: 0x1800ABD80
	public float hostileScore; // 0x1C4
	public HeldEntity.HolsterInfo holsterInfo; // 0x1C8
	[HeaderAttribute] // RVA: 0xABE70 Offset: 0xAB270 VA: 0x1800ABE70
	public BasePlayer.CameraMode HeldCameraMode; // 0x1D0
	public Vector3 FirstPersonArmOffset; // 0x1D4
	public Vector3 FirstPersonArmRotation; // 0x1E0
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float FirstPersonRotationStrength; // 0x1EC
	internal uint ownerItemUID; // 0x1F0

	// Properties
	public bool hostile { get; }

	// Methods

	// RVA: 0x7386B0 Offset: 0x736CB0 VA: 0x1807386B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x737900 Offset: 0x735F00 VA: 0x180737900 Slot: 131
	public virtual void AddPunch(Vector3 amount, float duration) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7379D0 Offset: 0x735FD0 VA: 0x1807379D0
	public void CL_Punch(BaseEntity.RPCMessage msg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 132
	public virtual void DoRecoilCompensation() { }

	// RVA: 0x737D00 Offset: 0x736300 VA: 0x180737D00
	public Vector3 GetAddedPunch() { }

	// RVA: 0x738EA0 Offset: 0x7374A0 VA: 0x180738EA0 Slot: 133
	public virtual void SimPunches() { }

	// RVA: 0x737A80 Offset: 0x736080 VA: 0x180737A80 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x737D20 Offset: 0x736320 VA: 0x180737D20
	public float GetFovOverride() { }

	// RVA: 0x737B50 Offset: 0x736150 VA: 0x180737B50 Slot: 20
	internal override void DoNetworkDestroy() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 134
	public virtual void PostLateClientCycle() { }

	// RVA: 0x738B60 Offset: 0x737160 VA: 0x180738B60 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x739370 Offset: 0x737970 VA: 0x180739370
	public void UpdateHolsteredOffset() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 135
	public virtual void EditViewAngles() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 136
	public virtual void ClampPitch(ref float pitch) { }

	// RVA: 0x738520 Offset: 0x736B20 VA: 0x180738520 Slot: 137
	public virtual void OnFrame() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 138
	public virtual void OnInput() { }

	// RVA: 0x737B90 Offset: 0x736190 VA: 0x180737B90 Slot: 139
	public virtual void Examine() { }

	// RVA: 0x738260 Offset: 0x736860 VA: 0x180738260 Slot: 140
	public virtual void OnDeploy() { }

	// RVA: 0x738510 Offset: 0x736B10 VA: 0x180738510 Slot: 141
	public virtual void OnDeployed() { }

	// RVA: 0x738540 Offset: 0x736B40 VA: 0x180738540 Slot: 142
	public virtual void OnHolster() { }

	// RVA: 0x7386A0 Offset: 0x736CA0 VA: 0x1807386A0 Slot: 143
	public virtual void OnHolstered() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 144
	public virtual void OnViewmodelEvent(string name) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 145
	public virtual void OnReliableEvent(string name) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 146
	public virtual void ModifyCamera() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 18
	public override bool ShouldDestroyImmediately() { }

	// RVA: 0x739B70 Offset: 0x738170 VA: 0x180739B70
	internal void UpdatePlayerModel(PlayerModel playerModel) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 147
	protected virtual void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0x737F10 Offset: 0x736510 VA: 0x180737F10 Slot: 148
	public virtual AnimatorOverrideController GetHoldAnimations() { }

	// RVA: 0x4C3890 Offset: 0x4C1E90 VA: 0x1804C3890 Slot: 149
	public virtual float GetMovementMultiplier() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 150
	public virtual void OnSpawnedForWorkshopPreview() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 151
	public virtual bool HeldEntityBlocksMovement(InputState state) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 152
	public virtual void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x738DF0 Offset: 0x7373F0 VA: 0x180738DF0 Slot: 153
	public virtual void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x739D20 Offset: 0x738320 VA: 0x180739D20
	public bool get_hostile() { }

	// RVA: 0x7381F0 Offset: 0x7367F0 VA: 0x1807381F0
	public bool LightsOn() { }

	// RVA: 0x7381E0 Offset: 0x7367E0 VA: 0x1807381E0
	public bool IsDeployed() { }

	// RVA: 0x738120 Offset: 0x736720 VA: 0x180738120
	public BasePlayer GetOwnerPlayer() { }

	// RVA: 0x737F30 Offset: 0x736530 VA: 0x180737F30
	public Connection GetOwnerConnection() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 154
	public virtual bool CanBeUsedInWater() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 155
	public virtual bool BlocksGestures() { }

	// RVA: 0x738040 Offset: 0x736640 VA: 0x180738040
	protected Item GetOwnerItem() { }

	// RVA: 0x737F20 Offset: 0x736520 VA: 0x180737F20 Slot: 117
	public override Item GetItem() { }

	// RVA: 0x737FC0 Offset: 0x7365C0 VA: 0x180737FC0
	public ItemDefinition GetOwnerItemDefinition() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 156
	public virtual bool IsInstrument() { }

	// RVA: 0x738200 Offset: 0x736800 VA: 0x180738200 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x739C30 Offset: 0x738230 VA: 0x180739C30
	public void .ctor() { }

	// RVA: 0x739BF0 Offset: 0x7381F0 VA: 0x180739BF0
	private static void .cctor() { }

}

public class HeldEntity.PunchEntry // TypeDefIndex: 8576
{	// Fields
	public Vector3 amount; // 0x10
	public float duration; // 0x1C
	public float startTime; // 0x20
	public Vector3 amountAdded; // 0x24

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class HeldEntity.HolsterInfo // TypeDefIndex: 8577
{	// Fields
	public HeldEntity.HolsterInfo.HolsterSlot slot; // 0x10
	public bool displayWhenHolstered; // 0x14
	public string holsterBone; // 0x18
	public Vector3 holsterOffset; // 0x20
	public Vector3 holsterRotationOffset; // 0x2C

	// Methods

	// RVA: 0x741EE0 Offset: 0x7404E0 VA: 0x180741EE0
	public void .ctor() { }

}

public enum HeldEntity.HolsterInfo.HolsterSlot // TypeDefIndex: 8578
{	// Fields
	public int value__; // 0x0
	public const HeldEntity.HolsterInfo.HolsterSlot BACK = 0;
	public const HeldEntity.HolsterInfo.HolsterSlot RIGHT_THIGH = 1;
	public const HeldEntity.HolsterInfo.HolsterSlot LEFT_THIGH = 2;

}

public static class HeldEntity.HeldEntityFlags // TypeDefIndex: 8579
{	// Fields
	public const BaseEntity.Flags Deployed = 1024;
	public const BaseEntity.Flags LightsOn = 2048;

}

