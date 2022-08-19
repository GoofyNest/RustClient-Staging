public class HeldEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6312
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint itemUID; // 0x14

	// Methods

	// RVA: 0x1D65280 Offset: 0x1D63880 VA: 0x181D65280
	public static void ResetToPool(HeldEntity instance) { }

	// RVA: 0x1D65300 Offset: 0x1D63900 VA: 0x181D65300
	public void ResetToPool() { }

	// RVA: 0x1D65150 Offset: 0x1D63750 VA: 0x181D65150 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(HeldEntity instance) { }

	// RVA: 0x1D647D0 Offset: 0x1D62DD0 VA: 0x181D647D0
	public HeldEntity Copy() { }

	// RVA: 0x1D64FD0 Offset: 0x1D635D0 VA: 0x181D64FD0
	public static HeldEntity Deserialize(Stream stream) { }

	// RVA: 0x1D64840 Offset: 0x1D62E40 VA: 0x181D64840
	public static HeldEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D64CE0 Offset: 0x1D632E0 VA: 0x181D64CE0
	public static HeldEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D64EB0 Offset: 0x1D634B0 VA: 0x181D64EB0
	public static HeldEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1D65240 Offset: 0x1D63840 VA: 0x181D65240
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D657D0 Offset: 0x1D63DD0 VA: 0x181D657D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D658A0 Offset: 0x1D63EA0 VA: 0x181D658A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, HeldEntity previous) { }

	// RVA: 0x1D65260 Offset: 0x1D63860 VA: 0x181D65260 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D65050 Offset: 0x1D63650 VA: 0x181D65050
	public static HeldEntity Deserialize(byte[] buffer, HeldEntity instance, bool isDelta = False) { }

	// RVA: 0x1D64D70 Offset: 0x1D63370 VA: 0x181D64D70
	public static HeldEntity Deserialize(Stream stream, HeldEntity instance, bool isDelta) { }

	// RVA: 0x1D648C0 Offset: 0x1D62EC0 VA: 0x181D648C0
	public static HeldEntity DeserializeLengthDelimited(Stream stream, HeldEntity instance, bool isDelta) { }

	// RVA: 0x1D64AE0 Offset: 0x1D630E0 VA: 0x181D64AE0
	public static HeldEntity DeserializeLength(Stream stream, int length, HeldEntity instance, bool isDelta) { }

	// RVA: 0x1D65380 Offset: 0x1D63980 VA: 0x181D65380
	public static void SerializeDelta(Stream stream, HeldEntity instance, HeldEntity previous) { }

	// RVA: 0x1D656F0 Offset: 0x1D63CF0 VA: 0x181D656F0
	public static void Serialize(Stream stream, HeldEntity instance) { }

	// RVA: 0x1D657C0 Offset: 0x1D63DC0 VA: 0x181D657C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D657D0 Offset: 0x1D63DD0 VA: 0x181D657D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D65540 Offset: 0x1D63B40 VA: 0x181D65540
	public static byte[] SerializeToBytes(HeldEntity instance) { }

	// RVA: 0x1D65490 Offset: 0x1D63A90 VA: 0x181D65490
	public static void SerializeLengthDelimited(Stream stream, HeldEntity instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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
	[HeaderAttribute] // RVA: 0xABC40 Offset: 0xAB040 VA: 0x1800ABC40
	public string handBone; // 0x1B0
	public AnimatorOverrideController HoldAnimationOverride; // 0x1B8
	public bool isBuildingTool; // 0x1C0
	[HeaderAttribute] // RVA: 0xABCB0 Offset: 0xAB0B0 VA: 0x1800ABCB0
	public float hostileScore; // 0x1C4
	public HeldEntity.HolsterInfo holsterInfo; // 0x1C8
	[HeaderAttribute] // RVA: 0xABDD0 Offset: 0xAB1D0 VA: 0x1800ABDD0
	public BasePlayer.CameraMode HeldCameraMode; // 0x1D0
	public Vector3 FirstPersonArmOffset; // 0x1D4
	public Vector3 FirstPersonArmRotation; // 0x1E0
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float FirstPersonRotationStrength; // 0x1EC
	internal uint ownerItemUID; // 0x1F0

	// Properties
	public bool hostile { get; }

	// Methods

	// RVA: 0x738650 Offset: 0x736C50 VA: 0x180738650 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7378A0 Offset: 0x735EA0 VA: 0x1807378A0 Slot: 131
	public virtual void AddPunch(Vector3 amount, float duration) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x737970 Offset: 0x735F70 VA: 0x180737970
	public void CL_Punch(BaseEntity.RPCMessage msg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 132
	public virtual void DoRecoilCompensation() { }

	// RVA: 0x737CA0 Offset: 0x7362A0 VA: 0x180737CA0
	public Vector3 GetAddedPunch() { }

	// RVA: 0x738E40 Offset: 0x737440 VA: 0x180738E40 Slot: 133
	public virtual void SimPunches() { }

	// RVA: 0x737A20 Offset: 0x736020 VA: 0x180737A20 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x737CC0 Offset: 0x7362C0 VA: 0x180737CC0
	public float GetFovOverride() { }

	// RVA: 0x737AF0 Offset: 0x7360F0 VA: 0x180737AF0 Slot: 20
	internal override void DoNetworkDestroy() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 134
	public virtual void PostLateClientCycle() { }

	// RVA: 0x738B00 Offset: 0x737100 VA: 0x180738B00 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x739310 Offset: 0x737910 VA: 0x180739310
	public void UpdateHolsteredOffset() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 135
	public virtual void EditViewAngles() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 136
	public virtual void ClampPitch(ref float pitch) { }

	// RVA: 0x7384C0 Offset: 0x736AC0 VA: 0x1807384C0 Slot: 137
	public virtual void OnFrame() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 138
	public virtual void OnInput() { }

	// RVA: 0x737B30 Offset: 0x736130 VA: 0x180737B30 Slot: 139
	public virtual void Examine() { }

	// RVA: 0x738200 Offset: 0x736800 VA: 0x180738200 Slot: 140
	public virtual void OnDeploy() { }

	// RVA: 0x7384B0 Offset: 0x736AB0 VA: 0x1807384B0 Slot: 141
	public virtual void OnDeployed() { }

	// RVA: 0x7384E0 Offset: 0x736AE0 VA: 0x1807384E0 Slot: 142
	public virtual void OnHolster() { }

	// RVA: 0x738640 Offset: 0x736C40 VA: 0x180738640 Slot: 143
	public virtual void OnHolstered() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 144
	public virtual void OnViewmodelEvent(string name) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 145
	public virtual void OnReliableEvent(string name) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 146
	public virtual void ModifyCamera() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 18
	public override bool ShouldDestroyImmediately() { }

	// RVA: 0x739B10 Offset: 0x738110 VA: 0x180739B10
	internal void UpdatePlayerModel(PlayerModel playerModel) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 147
	protected virtual void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0x737EB0 Offset: 0x7364B0 VA: 0x180737EB0 Slot: 148
	public virtual AnimatorOverrideController GetHoldAnimations() { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 149
	public virtual float GetMovementMultiplier() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 150
	public virtual void OnSpawnedForWorkshopPreview() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 151
	public virtual bool HeldEntityBlocksMovement(InputState state) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 152
	public virtual void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x738D90 Offset: 0x737390 VA: 0x180738D90 Slot: 153
	public virtual void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x739CC0 Offset: 0x7382C0 VA: 0x180739CC0
	public bool get_hostile() { }

	// RVA: 0x738190 Offset: 0x736790 VA: 0x180738190
	public bool LightsOn() { }

	// RVA: 0x738180 Offset: 0x736780 VA: 0x180738180
	public bool IsDeployed() { }

	// RVA: 0x7380C0 Offset: 0x7366C0 VA: 0x1807380C0
	public BasePlayer GetOwnerPlayer() { }

	// RVA: 0x737ED0 Offset: 0x7364D0 VA: 0x180737ED0
	public Connection GetOwnerConnection() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 154
	public virtual bool CanBeUsedInWater() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 155
	public virtual bool BlocksGestures() { }

	// RVA: 0x737FE0 Offset: 0x7365E0 VA: 0x180737FE0
	protected Item GetOwnerItem() { }

	// RVA: 0x737EC0 Offset: 0x7364C0 VA: 0x180737EC0 Slot: 117
	public override Item GetItem() { }

	// RVA: 0x737F60 Offset: 0x736560 VA: 0x180737F60
	public ItemDefinition GetOwnerItemDefinition() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 156
	public virtual bool IsInstrument() { }

	// RVA: 0x7381A0 Offset: 0x7367A0 VA: 0x1807381A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x739BD0 Offset: 0x7381D0 VA: 0x180739BD0
	public void .ctor() { }

	// RVA: 0x739B90 Offset: 0x738190 VA: 0x180739B90
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

	// RVA: 0x741E80 Offset: 0x740480 VA: 0x180741E80
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

