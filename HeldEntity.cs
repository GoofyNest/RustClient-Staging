public class HeldEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6312
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint itemUID; // 0x14

	// Methods

	// RVA: 0x1D65380 Offset: 0x1D63980 VA: 0x181D65380
	public static void ResetToPool(HeldEntity instance) { }

	// RVA: 0x1D65400 Offset: 0x1D63A00 VA: 0x181D65400
	public void ResetToPool() { }

	// RVA: 0x1D65250 Offset: 0x1D63850 VA: 0x181D65250 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(HeldEntity instance) { }

	// RVA: 0x1D648D0 Offset: 0x1D62ED0 VA: 0x181D648D0
	public HeldEntity Copy() { }

	// RVA: 0x1D650D0 Offset: 0x1D636D0 VA: 0x181D650D0
	public static HeldEntity Deserialize(Stream stream) { }

	// RVA: 0x1D64940 Offset: 0x1D62F40 VA: 0x181D64940
	public static HeldEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D64DE0 Offset: 0x1D633E0 VA: 0x181D64DE0
	public static HeldEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D64FB0 Offset: 0x1D635B0 VA: 0x181D64FB0
	public static HeldEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1D65340 Offset: 0x1D63940 VA: 0x181D65340
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D658D0 Offset: 0x1D63ED0 VA: 0x181D658D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D659A0 Offset: 0x1D63FA0 VA: 0x181D659A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HeldEntity previous) { }

	// RVA: 0x1D65360 Offset: 0x1D63960 VA: 0x181D65360 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D65150 Offset: 0x1D63750 VA: 0x181D65150
	public static HeldEntity Deserialize(byte[] buffer, HeldEntity instance, bool isDelta = False) { }

	// RVA: 0x1D64E70 Offset: 0x1D63470 VA: 0x181D64E70
	public static HeldEntity Deserialize(Stream stream, HeldEntity instance, bool isDelta) { }

	// RVA: 0x1D649C0 Offset: 0x1D62FC0 VA: 0x181D649C0
	public static HeldEntity DeserializeLengthDelimited(Stream stream, HeldEntity instance, bool isDelta) { }

	// RVA: 0x1D64BE0 Offset: 0x1D631E0 VA: 0x181D64BE0
	public static HeldEntity DeserializeLength(Stream stream, int length, HeldEntity instance, bool isDelta) { }

	// RVA: 0x1D65480 Offset: 0x1D63A80 VA: 0x181D65480
	public static void SerializeDelta(Stream stream, HeldEntity instance, HeldEntity previous) { }

	// RVA: 0x1D657F0 Offset: 0x1D63DF0 VA: 0x181D657F0
	public static void Serialize(Stream stream, HeldEntity instance) { }

	// RVA: 0x1D658C0 Offset: 0x1D63EC0 VA: 0x181D658C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D658D0 Offset: 0x1D63ED0 VA: 0x181D658D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D65640 Offset: 0x1D63C40 VA: 0x181D65640
	public static byte[] SerializeToBytes(HeldEntity instance) { }

	// RVA: 0x1D65590 Offset: 0x1D63B90 VA: 0x181D65590
	public static void SerializeLengthDelimited(Stream stream, HeldEntity instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x738760 Offset: 0x736D60 VA: 0x180738760 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7379B0 Offset: 0x735FB0 VA: 0x1807379B0 Slot: 131
	public virtual void AddPunch(Vector3 amount, float duration) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x737A80 Offset: 0x736080 VA: 0x180737A80
	public void CL_Punch(BaseEntity.RPCMessage msg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 132
	public virtual void DoRecoilCompensation() { }

	// RVA: 0x737DB0 Offset: 0x7363B0 VA: 0x180737DB0
	public Vector3 GetAddedPunch() { }

	// RVA: 0x738F50 Offset: 0x737550 VA: 0x180738F50 Slot: 133
	public virtual void SimPunches() { }

	// RVA: 0x737B30 Offset: 0x736130 VA: 0x180737B30 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x737DD0 Offset: 0x7363D0 VA: 0x180737DD0
	public float GetFovOverride() { }

	// RVA: 0x737C00 Offset: 0x736200 VA: 0x180737C00 Slot: 20
	internal override void DoNetworkDestroy() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 134
	public virtual void PostLateClientCycle() { }

	// RVA: 0x738C10 Offset: 0x737210 VA: 0x180738C10 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x739420 Offset: 0x737A20 VA: 0x180739420
	public void UpdateHolsteredOffset() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 135
	public virtual void EditViewAngles() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 136
	public virtual void ClampPitch(ref float pitch) { }

	// RVA: 0x7385D0 Offset: 0x736BD0 VA: 0x1807385D0 Slot: 137
	public virtual void OnFrame() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 138
	public virtual void OnInput() { }

	// RVA: 0x737C40 Offset: 0x736240 VA: 0x180737C40 Slot: 139
	public virtual void Examine() { }

	// RVA: 0x738310 Offset: 0x736910 VA: 0x180738310 Slot: 140
	public virtual void OnDeploy() { }

	// RVA: 0x7385C0 Offset: 0x736BC0 VA: 0x1807385C0 Slot: 141
	public virtual void OnDeployed() { }

	// RVA: 0x7385F0 Offset: 0x736BF0 VA: 0x1807385F0 Slot: 142
	public virtual void OnHolster() { }

	// RVA: 0x738750 Offset: 0x736D50 VA: 0x180738750 Slot: 143
	public virtual void OnHolstered() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 144
	public virtual void OnViewmodelEvent(string name) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 145
	public virtual void OnReliableEvent(string name) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 146
	public virtual void ModifyCamera() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 18
	public override bool ShouldDestroyImmediately() { }

	// RVA: 0x739C20 Offset: 0x738220 VA: 0x180739C20
	internal void UpdatePlayerModel(PlayerModel playerModel) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 147
	protected virtual void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0x737FC0 Offset: 0x7365C0 VA: 0x180737FC0 Slot: 148
	public virtual AnimatorOverrideController GetHoldAnimations() { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 149
	public virtual float GetMovementMultiplier() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 150
	public virtual void OnSpawnedForWorkshopPreview() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 151
	public virtual bool HeldEntityBlocksMovement(InputState state) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 152
	public virtual void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x738EA0 Offset: 0x7374A0 VA: 0x180738EA0 Slot: 153
	public virtual void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x739DD0 Offset: 0x7383D0 VA: 0x180739DD0
	public bool get_hostile() { }

	// RVA: 0x7382A0 Offset: 0x7368A0 VA: 0x1807382A0
	public bool LightsOn() { }

	// RVA: 0x738290 Offset: 0x736890 VA: 0x180738290
	public bool IsDeployed() { }

	// RVA: 0x7381D0 Offset: 0x7367D0 VA: 0x1807381D0
	public BasePlayer GetOwnerPlayer() { }

	// RVA: 0x737FE0 Offset: 0x7365E0 VA: 0x180737FE0
	public Connection GetOwnerConnection() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 154
	public virtual bool CanBeUsedInWater() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 155
	public virtual bool BlocksGestures() { }

	// RVA: 0x7380F0 Offset: 0x7366F0 VA: 0x1807380F0
	protected Item GetOwnerItem() { }

	// RVA: 0x737FD0 Offset: 0x7365D0 VA: 0x180737FD0 Slot: 117
	public override Item GetItem() { }

	// RVA: 0x738070 Offset: 0x736670 VA: 0x180738070
	public ItemDefinition GetOwnerItemDefinition() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 156
	public virtual bool IsInstrument() { }

	// RVA: 0x7382B0 Offset: 0x7368B0 VA: 0x1807382B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x739CE0 Offset: 0x7382E0 VA: 0x180739CE0
	public void .ctor() { }

	// RVA: 0x739CA0 Offset: 0x7382A0 VA: 0x180739CA0
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

	// RVA: 0x741F90 Offset: 0x740590 VA: 0x180741F90
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

