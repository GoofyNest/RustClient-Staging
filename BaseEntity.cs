public class BaseEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6293
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 pos; // 0x14
	public Vector3 rot; // 0x20
	public int flags; // 0x2C
	public float time; // 0x30
	public ulong skinid; // 0x38

	// Methods

	// RVA: 0x1FFEE70 Offset: 0x1FFD470 VA: 0x181FFEE70
	public static void ResetToPool(BaseEntity instance) { }

	// RVA: 0x1FFEF30 Offset: 0x1FFD530 VA: 0x181FFEF30
	public void ResetToPool() { }

	// RVA: 0x1FFEAC0 Offset: 0x1FFD0C0 VA: 0x181FFEAC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FFD7A0 Offset: 0x1FFBDA0 VA: 0x181FFD7A0
	public void CopyTo(BaseEntity instance) { }

	// RVA: 0x1FFD7F0 Offset: 0x1FFBDF0 VA: 0x181FFD7F0
	public BaseEntity Copy() { }

	// RVA: 0x1FFE510 Offset: 0x1FFCB10 VA: 0x181FFE510
	public static BaseEntity Deserialize(Stream stream) { }

	// RVA: 0x1FFD890 Offset: 0x1FFBE90 VA: 0x181FFD890
	public static BaseEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FFDC30 Offset: 0x1FFC230 VA: 0x181FFDC30
	public static BaseEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FFE790 Offset: 0x1FFCD90 VA: 0x181FFE790
	public static BaseEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1FFEC00 Offset: 0x1FFD200 VA: 0x181FFEC00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FFF910 Offset: 0x1FFDF10 VA: 0x181FFF910 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FFF930 Offset: 0x1FFDF30 VA: 0x181FFF930 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseEntity previous) { }

	// RVA: 0x1FFEE50 Offset: 0x1FFD450 VA: 0x181FFEE50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FFE200 Offset: 0x1FFC800 VA: 0x181FFE200
	public static BaseEntity Deserialize(byte[] buffer, BaseEntity instance, bool isDelta = False) { }

	// RVA: 0x1FFDFB0 Offset: 0x1FFC5B0 VA: 0x181FFDFB0
	public static BaseEntity Deserialize(Stream stream, BaseEntity instance, bool isDelta) { }

	// RVA: 0x1FFD910 Offset: 0x1FFBF10 VA: 0x181FFD910
	public static BaseEntity DeserializeLengthDelimited(Stream stream, BaseEntity instance, bool isDelta) { }

	// RVA: 0x1FFDCC0 Offset: 0x1FFC2C0 VA: 0x181FFDCC0
	public static BaseEntity DeserializeLength(Stream stream, int length, BaseEntity instance, bool isDelta) { }

	// RVA: 0x1FFEFF0 Offset: 0x1FFD5F0 VA: 0x181FFEFF0
	public static void SerializeDelta(Stream stream, BaseEntity instance, BaseEntity previous) { }

	// RVA: 0x1FFF650 Offset: 0x1FFDC50 VA: 0x181FFF650
	public static void Serialize(Stream stream, BaseEntity instance) { }

	// RVA: 0x1FFF900 Offset: 0x1FFDF00 VA: 0x181FFF900
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FFF910 Offset: 0x1FFDF10 VA: 0x181FFF910
	public void ToProto(Stream stream) { }

	// RVA: 0x1FFF540 Offset: 0x1FFDB40 VA: 0x181FFF540
	public static byte[] SerializeToBytes(BaseEntity instance) { }

	// RVA: 0x1FFF490 Offset: 0x1FFDA90 VA: 0x181FFF490
	public static void SerializeLengthDelimited(Stream stream, BaseEntity instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class BaseEntity : BaseNetworkable, IProvider, IPosLerpTarget, ILerpInfo, IPrefabPreProcess // TypeDefIndex: 8492
{	// Fields
	protected Ragdoll ragdoll; // 0x78
	internal PositionLerp positionLerp; // 0x80
	private List<Option> menuOptions; // 0x88
	private static Queue<BaseEntity> globalBroadcastQueue; // 0x0
	private static uint globalBroadcastProtocol; // 0x8
	private uint broadcastProtocol; // 0x90
	private List<EntityLink> links; // 0x98
	private bool linkedToNeighbours; // 0xA0
	private List<BaseEntity.ServerFileRequest> _pendingFileRequests; // 0xA8
	private Action updateParentingAction; // 0xB0
	private BaseEntity addedToParentEntity; // 0xB8
	public ItemSkin itemSkin; // 0xC0
	private EntityRef[] entitySlots; // 0xC8
	protected List<TriggerBase> triggers; // 0xD0
	protected bool isVisible; // 0xD8
	protected bool isAnimatorVisible; // 0xD9
	protected bool isShadowVisible; // 0xDA
	protected OccludeeSphere localOccludee; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float <Weight>k__BackingField; // 0x100
	[HeaderAttribute] // RVA: 0x9F410 Offset: 0x9E810 VA: 0x18009F410
	public Bounds bounds; // 0x104
	public GameObjectRef impactEffect; // 0x120
	public bool enableSaving; // 0x128
	public bool syncPosition; // 0x129
	public Model model; // 0x130
	[InspectorFlagsAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public BaseEntity.Flags flags; // 0x138
	public uint parentBone; // 0x13C
	public ulong skinID; // 0x140
	private EntityComponentBase[] _components; // 0x148
	[HideInInspector] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public bool HasBrain; // 0x150
	protected string _name; // 0x158
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <OwnerID>k__BackingField; // 0x160

	// Properties
	public virtual bool HasMenuOptions { get; }
	public virtual float RealisticMass { get; }
	public virtual BaseEntity.TraitFlag Traits { get; }
	public float Weight { get; set; }
	public EntityComponentBase[] Components { get; }
	public virtual bool IsNpc { get; }
	public ulong OwnerID { get; set; }

	// Methods

	// RVA: 0x7ADEF0 Offset: 0x7AC4F0 VA: 0x1807ADEF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7A9430 Offset: 0x7A7A30 VA: 0x1807A9430
	public void GetEntityMenu(BasePlayer player, List<Option> optionList) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 49
	public virtual void GetMenuOptions(List<Option> list) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 50
	public virtual bool get_HasMenuOptions() { }

	// RVA: 0x7A9AE0 Offset: 0x7A80E0 VA: 0x1807A9AE0 Slot: 51
	public virtual void GetItemOptions(List<Option> options) { }

	// RVA: 0x7AA530 Offset: 0x7A8B30 VA: 0x1807AA530
	public BaseEntity.MovementModify GetMovementModify() { }

	// RVA: 0x7A9570 Offset: 0x7A7B70 VA: 0x1807A9570 Slot: 52
	public virtual float GetExtrapolationTime() { }

	// RVA: 0x7A9930 Offset: 0x7A7F30 VA: 0x1807A9930 Slot: 53
	public virtual float GetInterpolationDelay() { }

	// RVA: 0x7A99C0 Offset: 0x7A7FC0 VA: 0x1807A99C0 Slot: 54
	public virtual float GetInterpolationInertia() { }

	// RVA: 0x7A9A50 Offset: 0x7A8050 VA: 0x1807A9A50 Slot: 55
	public virtual float GetInterpolationSmoothing() { }

	// RVA: 0x7A8ED0 Offset: 0x7A74D0 VA: 0x1807A8ED0 Slot: 56
	public virtual Quaternion GetAngularVelocityClient() { }

	// RVA: 0x7A9D30 Offset: 0x7A8330 VA: 0x1807A9D30 Slot: 57
	public virtual Vector3 GetLocalVelocityClient() { }

	// RVA: 0x7A73D0 Offset: 0x7A59D0 VA: 0x1807A73D0 Slot: 43
	public void DrawInterpolationState(Interpolator.Segment<TransformSnapshot> segment, List<TransformSnapshot> entries) { }

	// RVA: 0x7AC860 Offset: 0x7AAE60 VA: 0x1807AC860 Slot: 44
	public void LerpIdleDisable() { }

	// RVA: 0x7A6650 Offset: 0x7A4C50 VA: 0x1807A6650 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7A6700 Offset: 0x7A4D00 VA: 0x1807A6700 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x7ADB80 Offset: 0x7AC180 VA: 0x1807ADB80
	public void OnPositionalFromNetwork(Vector3 vPos, Vector3 vAng, float time) { }

	// RVA: 0x7B0F40 Offset: 0x7AF540 VA: 0x1807B0F40
	public void StartLerping(float time) { }

	// RVA: 0x7B10C0 Offset: 0x7AF6C0 VA: 0x1807B10C0
	public void StopLerping() { }

	// RVA: 0x7B0B30 Offset: 0x7AF130 VA: 0x1807B0B30 Slot: 58
	public virtual bool ShouldLerp() { }

	// RVA: 0x7B0620 Offset: 0x7AEC20 VA: 0x1807B0620 Slot: 59
	public virtual void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0x7B0790 Offset: 0x7AED90 VA: 0x1807B0790 Slot: 60
	public virtual void SetNetworkRotation(Quaternion qRot) { }

	// RVA: 0x7A73B0 Offset: 0x7A59B0 VA: 0x1807A73B0 Slot: 61
	public virtual void DoDestroyEffects(BaseNetworkable.DestroyMode mode, Message msg) { }

	// RVA: 0x7B0C30 Offset: 0x7AF230 VA: 0x1807B0C30 Slot: 62
	protected virtual void SpawnGibs() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0 Slot: 20
	internal override void DoNetworkDestroy() { }

	// RVA: 0x7AF2B0 Offset: 0x7AD8B0 VA: 0x1807AF2B0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x7AD8C0 Offset: 0x7ABEC0 VA: 0x1807AD8C0 Slot: 63
	public virtual void OnBecameRagdoll(Ragdoll rdoll) { }

	// RVA: 0x7A9EB0 Offset: 0x7A84B0 VA: 0x1807A9EB0 Slot: 64
	public virtual Info GetMenuInformation(GameObject primaryObject, BasePlayer player) { }

	// RVA: 0x7AB280 Offset: 0x7A9880 VA: 0x1807AB280 Slot: 65
	protected virtual bool HideMenuItems(BasePlayer player) { }

	// RVA: 0x7AA1A0 Offset: 0x7A87A0 VA: 0x1807AA1A0 Slot: 66
	public virtual List<Option> GetMenuItems(BasePlayer player) { }

	// RVA: 0x7AF0A0 Offset: 0x7AD6A0 VA: 0x1807AF0A0 Slot: 67
	public virtual void OnUse(BasePlayer player) { }

	// RVA: 0x7AEE80 Offset: 0x7AD480 VA: 0x1807AEE80 Slot: 68
	public virtual void OnUseHeld(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 69
	public virtual void OnUseStopped(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 70
	public virtual void OnRendered() { }

	// RVA: 0x7A7100 Offset: 0x7A5700 VA: 0x1807A7100 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x7A9600 Offset: 0x7A7C00 VA: 0x1807A9600 Slot: 71
	internal virtual Transform GetEyeTransform() { }

	// RVA: 0x7AD7B0 Offset: 0x7ABDB0 VA: 0x1807AD7B0 Slot: 72
	public virtual bool NeedsCrosshair() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 73
	public virtual bool AlwaysShowCrosshair() { }

	// RVA: 0x7B0A80 Offset: 0x7AF080 VA: 0x1807B0A80 Slot: 17
	public override bool ShouldDestroyWithGroup() { }

	// RVA: 0x7A6CF0 Offset: 0x7A52F0 VA: 0x1807A6CF0
	public void DetachEffects() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 74
	public virtual void OnVoiceData(byte[] data) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 75
	public virtual void LookingAtTick() { }

	// RVA: 0x723180 Offset: 0x721780 VA: 0x180723180 Slot: 76
	public virtual float get_RealisticMass() { }

	// RVA: 0x7AD970 Offset: 0x7ABF70 VA: 0x1807AD970 Slot: 77
	public virtual void OnCollision(Collision collision, BaseEntity hitEntity) { }

	// RVA: 0x7AF3A0 Offset: 0x7AD9A0 VA: 0x1807AF3A0
	protected void ReceiveCollisionMessages(bool b) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 78
	public virtual void DebugClient(int rep, float time) { }

	// RVA: 0x7AD9C0 Offset: 0x7ABFC0 VA: 0x1807AD9C0
	public void OnDebugStart() { }

	// RVA: 0x7A6C30 Offset: 0x7A5230 VA: 0x1807A6C30
	protected void DebugText(Vector3 pos, string str, Color color, float time) { }

	// RVA: 0x7AB240 Offset: 0x7A9840 VA: 0x1807AB240 Slot: 79
	public bool HasFlag(BaseEntity.Flags f) { }

	// RVA: 0x7AF210 Offset: 0x7AD810 VA: 0x1807AF210
	public bool ParentHasFlag(BaseEntity.Flags f) { }

	// RVA: 0x7B0450 Offset: 0x7AEA50 VA: 0x1807B0450
	public void SetFlag(BaseEntity.Flags f, bool b, bool recursive = False, bool networkupdate = True) { }

	// RVA: 0x7AB890 Offset: 0x7A9E90 VA: 0x1807AB890
	public bool IsOn() { }

	// RVA: 0x7AB8A0 Offset: 0x7A9EA0 VA: 0x1807AB8A0
	public bool IsOpen() { }

	// RVA: 0x7AB880 Offset: 0x7A9E80 VA: 0x1807AB880
	public bool IsOnFire() { }

	// RVA: 0x7AB5D0 Offset: 0x7A9BD0 VA: 0x1807AB5D0
	public bool IsLocked() { }

	// RVA: 0x7AB3E0 Offset: 0x7A99E0 VA: 0x1807AB3E0 Slot: 4
	public override bool IsDebugging() { }

	// RVA: 0x7AB3F0 Offset: 0x7A99F0 VA: 0x1807AB3F0
	public bool IsDisabled() { }

	// RVA: 0x7AB3D0 Offset: 0x7A99D0 VA: 0x1807AB3D0
	public bool IsBroken() { }

	// RVA: 0x7AB280 Offset: 0x7A9880 VA: 0x1807AB280
	public bool IsBusy() { }

	// RVA: 0x7A9E60 Offset: 0x7A8460 VA: 0x1807A9E60 Slot: 5
	public override string GetLogColor() { }

	// RVA: 0x7ADA80 Offset: 0x7AC080 VA: 0x1807ADA80 Slot: 80
	public virtual void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x7AB6D0 Offset: 0x7A9CD0 VA: 0x1807AB6D0
	public bool IsOccupied(Socket_Base socket) { }

	// RVA: 0x7AB5E0 Offset: 0x7A9BE0 VA: 0x1807AB5E0
	public bool IsOccupied(string socketName) { }

	// RVA: 0x7A8090 Offset: 0x7A6690 VA: 0x1807A8090
	public EntityLink FindLink(Socket_Base socket) { }

	// RVA: 0x7A8190 Offset: 0x7A6790 VA: 0x1807A8190
	public EntityLink FindLink(string socketName) { }

	// RVA: 0x7A8270 Offset: 0x7A6870 VA: 0x1807A8270
	public EntityLink FindLink(string[] socketNames) { }

	// RVA: -1 Offset: -1
	public T FindLinkedEntity<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9F80 Offset: 0x5C8580 VA: 0x1805C9F80
	|-BaseEntity.FindLinkedEntity<object>
	*/

	// RVA: -1 Offset: -1
	public void EntityLinkMessage<T>(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15695D0 Offset: 0x1567BD0 VA: 0x1815695D0
	|-BaseEntity.EntityLinkMessage<object>
	*/

	// RVA: -1 Offset: -1
	public void EntityLinkBroadcast<T, S>(Action<T> action, Func<S, bool> canTraverseSocket) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1568C70 Offset: 0x1567270 VA: 0x181568C70
	|-BaseEntity.EntityLinkBroadcast<object, object>
	*/

	// RVA: -1 Offset: -1
	public void EntityLinkBroadcast<T>(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1569190 Offset: 0x1567790 VA: 0x181569190
	|-BaseEntity.EntityLinkBroadcast<object>
	*/

	// RVA: 0x7A7B70 Offset: 0x7A6170 VA: 0x1807A7B70
	public void EntityLinkBroadcast() { }

	// RVA: 0x7AF430 Offset: 0x7ADA30 VA: 0x1807AF430
	public bool ReceivedEntityLinkBroadcast() { }

	// RVA: 0x7A93F0 Offset: 0x7A79F0 VA: 0x1807A93F0
	public List<EntityLink> GetEntityLinks(bool linkToNeighbours = True) { }

	// RVA: 0x7AC890 Offset: 0x7AAE90 VA: 0x1807AC890
	private void LinkToEntity(BaseEntity other) { }

	// RVA: 0x7ACAF0 Offset: 0x7AB0F0 VA: 0x1807ACAF0
	private void LinkToNeighbours() { }

	// RVA: 0x7AB290 Offset: 0x7A9890 VA: 0x1807AB290
	private void InitEntityLinks() { }

	// RVA: 0x7A8DF0 Offset: 0x7A73F0 VA: 0x1807A8DF0
	private void FreeEntityLinks() { }

	// RVA: 0x7AF4A0 Offset: 0x7ADAA0 VA: 0x1807AF4A0
	public void RefreshEntityLinks() { }

	[ObsoleteAttribute] // RVA: 0x9F7E0 Offset: 0x9EBE0 VA: 0x18009F7E0
	// RVA: 0x7AFD20 Offset: 0x7AE320 VA: 0x1807AFD20
	public void RequestFileFromServer(uint crc, FileStorage.Type type, string responseFunction, uint part = 0) { }

	// RVA: 0x7AF9E0 Offset: 0x7ADFE0 VA: 0x1807AF9E0
	public void RequestFileFromServer(IServerFileReceiver receiver, FileStorage.Type type, uint crc, uint part = 0, bool respondIfNotFound = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7A6360 Offset: 0x7A4960 VA: 0x1807A6360
	public void CL_ReceiveFileRequest(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7A6900 Offset: 0x7A4F00 VA: 0x1807A6900
	private void CompletePendingFileRequests(FileStorage.Type type, uint crc, uint part, byte[] data) { }

	// RVA: 0x7B1280 Offset: 0x7AF880 VA: 0x1807B1280
	public void UpdateChildren() { }

	// RVA: 0x7B1FF0 Offset: 0x7B05F0 VA: 0x1807B1FF0
	public void UpdateParenting() { }

	// RVA: 0x7B1970 Offset: 0x7AFF70 VA: 0x1807B1970
	public void UpdateParenting(bool worldPositionStays) { }

	// RVA: 0x7B0860 Offset: 0x7AEE60 VA: 0x1807B0860
	private void SetParentTransform(Transform parent, bool worldPositionStays = True) { }

	// RVA: 0x7B15F0 Offset: 0x7AFBF0 VA: 0x1807B15F0
	protected void UpdateDisableState() { }

	// RVA: 0x7AB0A0 Offset: 0x7A96A0 VA: 0x1807AB0A0
	private bool HasClientTransformOffset() { }

	// RVA: 0x7AF7B0 Offset: 0x7ADDB0 VA: 0x1807AF7B0
	private void RemoveClientTransformOffset() { }

	// RVA: 0x7A5D20 Offset: 0x7A4320 VA: 0x1807A5D20
	private void AddClientTransformOffset() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 81
	public virtual void OnParentChangingClient(Transform oldParent, Transform newParent) { }

	// RVA: 0x7A9380 Offset: 0x7A7980 VA: 0x1807A9380 Slot: 82
	public virtual BuildingPrivlidge GetBuildingPrivilege() { }

	// RVA: 0x7A9090 Offset: 0x7A7690 VA: 0x1807A9090
	public BuildingPrivlidge GetBuildingPrivilege(OBB obb) { }

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3, T4, T5>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156AD30 Offset: 0x1569330 VA: 0x18156AD30
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, object>
	|
	|-RVA: 0x156B240 Offset: 0x1569840 VA: 0x18156B240
	|-BaseEntity.ServerRPC<int, int, int, int, byte>
	|
	|-RVA: 0x156AFC0 Offset: 0x15695C0 VA: 0x18156AFC0
	|-BaseEntity.ServerRPC<int, Color, Color, Color, Color>
	|
	|-RVA: 0x156CFD0 Offset: 0x156B5D0 VA: 0x18156CFD0
	|-BaseEntity.ServerRPC<object, object, object, object, object>
	|
	|-RVA: 0x156DBF0 Offset: 0x156C1F0 VA: 0x18156DBF0
	|-BaseEntity.ServerRPC<uint, byte, uint, uint, bool>
	|
	|-RVA: 0x156E420 Offset: 0x156CA20 VA: 0x18156E420
	|-BaseEntity.ServerRPC<uint, int, uint, int, int>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3, T4>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156B480 Offset: 0x1569A80 VA: 0x18156B480
	|-BaseEntity.ServerRPC<int, int, int, int>
	|
	|-RVA: 0x156B6A0 Offset: 0x1569CA0 VA: 0x18156B6A0
	|-BaseEntity.ServerRPC<int, int, int, float>
	|
	|-RVA: 0x156BCA0 Offset: 0x156A2A0 VA: 0x18156BCA0
	|-BaseEntity.ServerRPC<int, int, object, bool>
	|
	|-RVA: 0x156C480 Offset: 0x156AA80 VA: 0x18156C480
	|-BaseEntity.ServerRPC<int, uint, object, bool>
	|
	|-RVA: 0x156CDB0 Offset: 0x156B3B0 VA: 0x18156CDB0
	|-BaseEntity.ServerRPC<object, object, int, object>
	|
	|-RVA: 0x156D220 Offset: 0x156B820 VA: 0x18156D220
	|-BaseEntity.ServerRPC<object, object, object, object>
	|
	|-RVA: 0x156DDE0 Offset: 0x156C3E0 VA: 0x18156DDE0
	|-BaseEntity.ServerRPC<uint, byte, uint, uint>
	|
	|-RVA: 0x156EF20 Offset: 0x156D520 VA: 0x18156EF20
	|-BaseEntity.ServerRPC<uint, uint, sbyte, int>
	|
	|-RVA: 0x156F5F0 Offset: 0x156DBF0 VA: 0x18156F5F0
	|-BaseEntity.ServerRPC<ulong, uint, uint, object>
	|
	|-RVA: 0x156FC90 Offset: 0x156E290 VA: 0x18156FC90
	|-BaseEntity.ServerRPC<Vector3, Vector3, int, int>
	|
	|-RVA: 0x1570100 Offset: 0x156E700 VA: 0x181570100
	|-BaseEntity.ServerRPC<Vector3, Vector3, Vector3, int>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156A940 Offset: 0x1568F40 VA: 0x18156A940
	|-BaseEntity.ServerRPC<bool, Vector3, uint>
	|
	|-RVA: 0x156B870 Offset: 0x1569E70 VA: 0x18156B870
	|-BaseEntity.ServerRPC<int, int, int>
	|
	|-RVA: 0x156BAD0 Offset: 0x156A0D0 VA: 0x18156BAD0
	|-BaseEntity.ServerRPC<int, int, Ray>
	|
	|-RVA: 0x156C0E0 Offset: 0x156A6E0 VA: 0x18156C0E0
	|-BaseEntity.ServerRPC<int, object, int>
	|
	|-RVA: 0x156D450 Offset: 0x156BA50 VA: 0x18156D450
	|-BaseEntity.ServerRPC<object, object, object>
	|
	|-RVA: 0x156E000 Offset: 0x156C600 VA: 0x18156E000
	|-BaseEntity.ServerRPC<uint, int, bool>
	|
	|-RVA: 0x156E200 Offset: 0x156C800 VA: 0x18156E200
	|-BaseEntity.ServerRPC<uint, int, int>
	|
	|-RVA: 0x156E7B0 Offset: 0x156CDB0 VA: 0x18156E7B0
	|-BaseEntity.ServerRPC<uint, object, int>
	|
	|-RVA: 0x156E9B0 Offset: 0x156CFB0 VA: 0x18156E9B0
	|-BaseEntity.ServerRPC<uint, object, object>
	|
	|-RVA: 0x156EB70 Offset: 0x156D170 VA: 0x18156EB70
	|-BaseEntity.ServerRPC<uint, object, ulong>
	|
	|-RVA: 0x156FA10 Offset: 0x156E010 VA: 0x18156FA10
	|-BaseEntity.ServerRPC<Vector3, Vector3, bool>
	|
	|-RVA: 0x156FF10 Offset: 0x156E510 VA: 0x18156FF10
	|-BaseEntity.ServerRPC<Vector3, Vector3, float>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156BF00 Offset: 0x156A500 VA: 0x18156BF00
	|-BaseEntity.ServerRPC<int, int>
	|
	|-RVA: 0x156C2E0 Offset: 0x156A8E0 VA: 0x18156C2E0
	|-BaseEntity.ServerRPC<int, object>
	|
	|-RVA: 0x156CBD0 Offset: 0x156B1D0 VA: 0x18156CBD0
	|-BaseEntity.ServerRPC<object, bool>
	|
	|-RVA: 0x156D650 Offset: 0x156BC50 VA: 0x18156D650
	|-BaseEntity.ServerRPC<object, object>
	|
	|-RVA: 0x156E610 Offset: 0x156CC10 VA: 0x18156E610
	|-BaseEntity.ServerRPC<uint, int>
	|
	|-RVA: 0x156ED30 Offset: 0x156D330 VA: 0x18156ED30
	|-BaseEntity.ServerRPC<uint, object>
	|
	|-RVA: 0x156F270 Offset: 0x156D870 VA: 0x18156F270
	|-BaseEntity.ServerRPC<ulong, int>
	|
	|-RVA: 0x156F450 Offset: 0x156DA50 VA: 0x18156F450
	|-BaseEntity.ServerRPC<ulong, object>
	|
	|-RVA: 0x156C850 Offset: 0x156AE50 VA: 0x18156C850
	|-BaseEntity.ServerRPC<Ray, int>
	|
	|-RVA: 0x156CA10 Offset: 0x156B010 VA: 0x18156CA10
	|-BaseEntity.ServerRPC<Ray, uint>
	|
	|-RVA: 0x1570430 Offset: 0x156EA30 VA: 0x181570430
	|-BaseEntity.ServerRPC<Vector3, Vector3>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1>(SendMethod sendMethod, string funcName, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156AB20 Offset: 0x1569120 VA: 0x18156AB20
	|-BaseEntity.ServerRPC<bool>
	|
	|-RVA: 0x156C650 Offset: 0x156AC50 VA: 0x18156C650
	|-BaseEntity.ServerRPC<int>
	|
	|-RVA: 0x156D860 Offset: 0x156BE60 VA: 0x18156D860
	|-BaseEntity.ServerRPC<object>
	|
	|-RVA: 0x156D9E0 Offset: 0x156BFE0 VA: 0x18156D9E0
	|-BaseEntity.ServerRPC<float>
	|
	|-RVA: 0x156F0F0 Offset: 0x156D6F0 VA: 0x18156F0F0
	|-BaseEntity.ServerRPC<uint>
	|
	|-RVA: 0x156F810 Offset: 0x156DE10 VA: 0x18156F810
	|-BaseEntity.ServerRPC<ulong>
	|
	|-RVA: 0x1570640 Offset: 0x156EC40 VA: 0x181570640
	|-BaseEntity.ServerRPC<Vector3>
	*/

	// RVA: 0x7B0110 Offset: 0x7AE710 VA: 0x1807B0110
	public void ServerRPC(SendMethod sendMethod, string funcName) { }

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3, T4, T5>(string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156ACD0 Offset: 0x15692D0 VA: 0x18156ACD0
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, byte[]>
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, object>
	|
	|-RVA: 0x156B1E0 Offset: 0x15697E0 VA: 0x18156B1E0
	|-BaseEntity.ServerRPC<int, int, int, int, byte>
	|
	|-RVA: 0x156AF20 Offset: 0x1569520 VA: 0x18156AF20
	|-BaseEntity.ServerRPC<int, Color, Color, Color, Color>
	|
	|-RVA: 0x156D1C0 Offset: 0x156B7C0 VA: 0x18156D1C0
	|-BaseEntity.ServerRPC<object, object, object, object, object>
	|-BaseEntity.ServerRPC<string, string, string, string, string>
	|
	|-RVA: 0x156DB90 Offset: 0x156C190 VA: 0x18156DB90
	|-BaseEntity.ServerRPC<uint, byte, uint, uint, bool>
	|
	|-RVA: 0x156E3C0 Offset: 0x156C9C0 VA: 0x18156E3C0
	|-BaseEntity.ServerRPC<uint, int, uint, int, int>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3, T4>(string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156BE70 Offset: 0x156A470 VA: 0x18156BE70
	|-BaseEntity.ServerRPC<int, int, byte[], bool>
	|-BaseEntity.ServerRPC<int, int, object, bool>
	|-BaseEntity.ServerRPC<int, uint, byte[], bool>
	|-BaseEntity.ServerRPC<int, uint, object, bool>
	|
	|-RVA: 0x156B430 Offset: 0x1569A30 VA: 0x18156B430
	|-BaseEntity.ServerRPC<int, int, int, int>
	|
	|-RVA: 0x156B650 Offset: 0x1569C50 VA: 0x18156B650
	|-BaseEntity.ServerRPC<int, int, int, float>
	|
	|-RVA: 0x156CF80 Offset: 0x156B580 VA: 0x18156CF80
	|-BaseEntity.ServerRPC<object, object, int, object>
	|-BaseEntity.ServerRPC<string, string, int, string>
	|
	|-RVA: 0x156D400 Offset: 0x156BA00 VA: 0x18156D400
	|-BaseEntity.ServerRPC<object, object, object, object>
	|
	|-RVA: 0x156DFB0 Offset: 0x156C5B0 VA: 0x18156DFB0
	|-BaseEntity.ServerRPC<uint, byte, uint, uint>
	|
	|-RVA: 0x156EED0 Offset: 0x156D4D0 VA: 0x18156EED0
	|-BaseEntity.ServerRPC<uint, uint, sbyte, int>
	|
	|-RVA: 0x156F7C0 Offset: 0x156DDC0 VA: 0x18156F7C0
	|-BaseEntity.ServerRPC<ulong, uint, uint, byte[]>
	|-BaseEntity.ServerRPC<ulong, uint, uint, object>
	|
	|-RVA: 0x156FC00 Offset: 0x156E200 VA: 0x18156FC00
	|-BaseEntity.ServerRPC<Vector3, Vector3, int, int>
	|
	|-RVA: 0x1570320 Offset: 0x156E920 VA: 0x181570320
	|-BaseEntity.ServerRPC<Vector3, Vector3, Vector3, int>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3>(string funcName, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156A8E0 Offset: 0x1568EE0 VA: 0x18156A8E0
	|-BaseEntity.ServerRPC<bool, Vector3, uint>
	|
	|-RVA: 0x156C0A0 Offset: 0x156A6A0 VA: 0x18156C0A0
	|-BaseEntity.ServerRPC<int, byte[], int>
	|-BaseEntity.ServerRPC<int, object, int>
	|-BaseEntity.ServerRPC<uint, object, int>
	|
	|-RVA: 0x156BA30 Offset: 0x156A030 VA: 0x18156BA30
	|-BaseEntity.ServerRPC<int, int, int>
	|-BaseEntity.ServerRPC<uint, int, int>
	|
	|-RVA: 0x156BA70 Offset: 0x156A070 VA: 0x18156BA70
	|-BaseEntity.ServerRPC<int, int, Ray>
	|
	|-RVA: 0x156D610 Offset: 0x156BC10 VA: 0x18156D610
	|-BaseEntity.ServerRPC<object, object, object>
	|
	|-RVA: 0x156E970 Offset: 0x156CF70 VA: 0x18156E970
	|-BaseEntity.ServerRPC<uint, byte[], ulong>
	|-BaseEntity.ServerRPC<uint, object, object>
	|-BaseEntity.ServerRPC<uint, object, ulong>
	|
	|-RVA: 0x156E1C0 Offset: 0x156C7C0 VA: 0x18156E1C0
	|-BaseEntity.ServerRPC<uint, int, bool>
	|
	|-RVA: 0x156F990 Offset: 0x156DF90 VA: 0x18156F990
	|-BaseEntity.ServerRPC<Vector3, Vector3, bool>
	|
	|-RVA: 0x156FE90 Offset: 0x156E490 VA: 0x18156FE90
	|-BaseEntity.ServerRPC<Vector3, Vector3, float>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2>(string funcName, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156C2A0 Offset: 0x156A8A0 VA: 0x18156C2A0
	|-BaseEntity.ServerRPC<int, SprayList>
	|-BaseEntity.ServerRPC<int, byte[]>
	|-BaseEntity.ServerRPC<int, object>
	|-BaseEntity.ServerRPC<int, string>
	|-BaseEntity.ServerRPC<uint, byte[]>
	|-BaseEntity.ServerRPC<uint, object>
	|-BaseEntity.ServerRPC<uint, string>
	|
	|-RVA: 0x156BEC0 Offset: 0x156A4C0 VA: 0x18156BEC0
	|-BaseEntity.ServerRPC<int, int>
	|-BaseEntity.ServerRPC<uint, int>
	|
	|-RVA: 0x156CD70 Offset: 0x156B370 VA: 0x18156CD70
	|-BaseEntity.ServerRPC<object, bool>
	|-BaseEntity.ServerRPC<string, bool>
	|
	|-RVA: 0x156D7F0 Offset: 0x156BDF0 VA: 0x18156D7F0
	|-BaseEntity.ServerRPC<object, object>
	|-BaseEntity.ServerRPC<string, string>
	|-BaseEntity.ServerRPC<ulong, object>
	|-BaseEntity.ServerRPC<ulong, string>
	|
	|-RVA: 0x156F410 Offset: 0x156DA10 VA: 0x18156F410
	|-BaseEntity.ServerRPC<ulong, int>
	|
	|-RVA: 0x156C800 Offset: 0x156AE00 VA: 0x18156C800
	|-BaseEntity.ServerRPC<Ray, int>
	|-BaseEntity.ServerRPC<Ray, uint>
	|
	|-RVA: 0x15703C0 Offset: 0x156E9C0 VA: 0x1815703C0
	|-BaseEntity.ServerRPC<Vector3, Vector3>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1>(string funcName, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156D830 Offset: 0x156BE30 VA: 0x18156D830
	|-BaseEntity.ServerRPC<AIDesign>
	|-BaseEntity.ServerRPC<ArcadeGame>
	|-BaseEntity.ServerRPC<CreateBuilding>
	|-BaseEntity.ServerRPC<MapNote>
	|-BaseEntity.ServerRPC<PatternFirework.Design>
	|-BaseEntity.ServerRPC<PlayerAttack>
	|-BaseEntity.ServerRPC<PlayerProjectileAttack>
	|-BaseEntity.ServerRPC<PlayerProjectileRicochet>
	|-BaseEntity.ServerRPC<PlayerProjectileUpdate>
	|-BaseEntity.ServerRPC<ProjectileShoot>
	|-BaseEntity.ServerRPC<object>
	|-BaseEntity.ServerRPC<string>
	|-BaseEntity.ServerRPC<ulong>
	|
	|-RVA: 0x156ACA0 Offset: 0x15692A0 VA: 0x18156ACA0
	|-BaseEntity.ServerRPC<bool>
	|
	|-RVA: 0x156C7D0 Offset: 0x156ADD0 VA: 0x18156C7D0
	|-BaseEntity.ServerRPC<int>
	|-BaseEntity.ServerRPC<uint>
	|
	|-RVA: 0x156DB60 Offset: 0x156C160 VA: 0x18156DB60
	|-BaseEntity.ServerRPC<float>
	|
	|-RVA: 0x1570600 Offset: 0x156EC00 VA: 0x181570600
	|-BaseEntity.ServerRPC<Vector3>
	*/

	// RVA: 0x7B0440 Offset: 0x7AEA40 VA: 0x1807B0440
	public void ServerRPC(string funcName) { }

	// RVA: 0x7AFF60 Offset: 0x7AE560 VA: 0x1807AFF60
	private bool ServerRPCStart(string funcName) { }

	// RVA: -1 Offset: -1
	private void ServerRPCWrite<T>(T arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156A5B0 Offset: 0x1568BB0 VA: 0x18156A5B0
	|-BaseEntity.ServerRPCWrite<bool>
	|-BaseEntity.ServerRPCWrite<byte>
	|-BaseEntity.ServerRPCWrite<sbyte>
	|
	|-RVA: 0x156A690 Offset: 0x1568C90 VA: 0x18156A690
	|-BaseEntity.ServerRPCWrite<int>
	|-BaseEntity.ServerRPCWrite<uint>
	|
	|-RVA: 0x156A780 Offset: 0x1568D80 VA: 0x18156A780
	|-BaseEntity.ServerRPCWrite<object>
	|-BaseEntity.ServerRPCWrite<ulong>
	|
	|-RVA: 0x156A7F0 Offset: 0x1568DF0 VA: 0x18156A7F0
	|-BaseEntity.ServerRPCWrite<float>
	|
	|-RVA: 0x156A620 Offset: 0x1568C20 VA: 0x18156A620
	|-BaseEntity.ServerRPCWrite<Color>
	|
	|-RVA: 0x156A700 Offset: 0x1568D00 VA: 0x18156A700
	|-BaseEntity.ServerRPCWrite<Ray>
	|
	|-RVA: 0x156A860 Offset: 0x1568E60 VA: 0x18156A860
	|-BaseEntity.ServerRPCWrite<Vector3>
	*/

	// RVA: 0x7AFEF0 Offset: 0x7AE4F0 VA: 0x1807AFEF0
	private void ServerRPCSend(SendInfo sendInfo) { }

	// RVA: -1 Offset: -1
	public void ServerRPCList<T1>(string funcName, List<T1> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1569EE0 Offset: 0x15684E0 VA: 0x181569EE0
	|-BaseEntity.ServerRPCList<object>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPCList<T1, T2, T3, T4, T5>(string funcName, List<T1> list, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1569B50 Offset: 0x1568150 VA: 0x181569B50
	|-BaseEntity.ServerRPCList<object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPCList<T1, T2, T3, T4, T5, T6>(string funcName, List<T1> list, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15697B0 Offset: 0x1567DB0 VA: 0x1815697B0
	|-BaseEntity.ServerRPCList<object, object, object, object, object, object>
	|
	|-RVA: 0x156A200 Offset: 0x1568800 VA: 0x18156A200
	|-BaseEntity.ServerRPCList<Vector3, uint, int, uint, int, int>
	*/

	// RVA: 0x7A6070 Offset: 0x7A4670 VA: 0x1807A6070
	public void CL_RPCMessage(uint nameID, ulong sourceConnection, Message message) { }

	// RVA: 0x7AFE40 Offset: 0x7AE440 VA: 0x1807AFE40
	public void SendSignalBroadcast(BaseEntity.Signal signal, string arg = "") { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B0B50 Offset: 0x7AF150 VA: 0x1807B0B50
	private void SignalFromServerEx(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B0BE0 Offset: 0x7AF1E0 VA: 0x1807B0BE0
	private void SignalFromServer(BaseEntity.RPCMessage msg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 83
	public virtual void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x7AEAF0 Offset: 0x7AD0F0 VA: 0x1807AEAF0
	private void OnSkinChanged(ulong oldSkinID, ulong newSkinID) { }

	// RVA: 0x7AEE60 Offset: 0x7AD460 VA: 0x1807AEE60
	private void OnSkinRefreshStart() { }

	// RVA: 0x7AEE40 Offset: 0x7AD440 VA: 0x1807AEE40
	private void OnSkinRefreshEnd() { }

	// RVA: 0x7AF2D0 Offset: 0x7AD8D0 VA: 0x1807AF2D0 Slot: 84
	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x7AAFC0 Offset: 0x7A95C0 VA: 0x1807AAFC0
	public bool HasAnySlot() { }

	// RVA: 0x7AAB40 Offset: 0x7A9140 VA: 0x1807AAB40
	public BaseEntity GetSlot(BaseEntity.Slot slot) { }

	// RVA: 0x7AAA00 Offset: 0x7A9000 VA: 0x1807AAA00
	public string GetSlotAnchorName(BaseEntity.Slot slot) { }

	// RVA: 0x7AAA90 Offset: 0x7A9090 VA: 0x1807AAA90
	public Transform GetSlotAnchor(BaseEntity.Slot slot) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 85
	public virtual bool HasSlot(BaseEntity.Slot slot) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 86
	public virtual BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x7AB250 Offset: 0x7A9850 VA: 0x1807AB250
	public bool HasTrait(BaseEntity.TraitFlag f) { }

	// RVA: 0x7AB070 Offset: 0x7A9670 VA: 0x1807AB070
	public bool HasAnyTrait(BaseEntity.TraitFlag f) { }

	// RVA: 0x7A7AC0 Offset: 0x7A60C0 VA: 0x1807A7AC0 Slot: 87
	public virtual bool EnterTrigger(TriggerBase trigger) { }

	// RVA: 0x7AC7C0 Offset: 0x7AADC0 VA: 0x1807AC7C0 Slot: 88
	public virtual void LeaveTrigger(TriggerBase trigger) { }

	// RVA: 0x7AF810 Offset: 0x7ADE10 VA: 0x1807AF810
	public void RemoveFromTriggers() { }

	// RVA: -1 Offset: -1
	public T FindTrigger<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA140 Offset: 0x5C8740 VA: 0x1805CA140
	|-BaseEntity.FindTrigger<object>
	|-BaseEntity.FindTrigger<TriggerLadder>
	|-BaseEntity.FindTrigger<TriggerNoSpray>
	*/

	// RVA: -1 Offset: -1
	public bool FindTrigger<T>(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D150 Offset: 0x125B750 VA: 0x18125D150
	|-BaseEntity.FindTrigger<object>
	*/

	// RVA: 0x7A8370 Offset: 0x7A6970 VA: 0x1807A8370
	private void ForceUpdateTriggersAction() { }

	// RVA: 0x7A83A0 Offset: 0x7A69A0 VA: 0x1807A83A0
	public void ForceUpdateTriggers(bool enter = True, bool exit = True, bool invoke = True) { }

	// RVA: 0x7AD790 Offset: 0x7ABD90 VA: 0x1807AD790 Slot: 89
	public virtual void MakeVisible() { }

	// RVA: 0x7B1470 Offset: 0x7AFA70 VA: 0x1807B1470 Slot: 90
	protected virtual void UpdateCullingSpheres() { }

	// RVA: 0x7AF580 Offset: 0x7ADB80 VA: 0x1807AF580 Slot: 91
	protected virtual void RegisterForCulling() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 92
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x7B1200 Offset: 0x7AF800 VA: 0x1807B1200 Slot: 93
	protected virtual void UnregisterFromCulling() { }

	// RVA: 0x7B13A0 Offset: 0x7AF9A0 VA: 0x1807B13A0 Slot: 94
	protected virtual void UpdateCullingBounds() { }

	// RVA: 0x7A6630 Offset: 0x7A4C30 VA: 0x1807A6630 Slot: 95
	protected virtual bool CheckVisibility() { }

	// RVA: 0x7A6510 Offset: 0x7A4B10 VA: 0x1807A6510
	protected float CalcEntityVisUpdateRate() { }

	// RVA: 0x7A6B60 Offset: 0x7A5160 VA: 0x1807A6B60 Slot: 96
	protected virtual void DebugDrawCullingBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B27E0 Offset: 0x7B0DE0 VA: 0x1807B27E0
	public float get_Weight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B2800 Offset: 0x7B0E00 VA: 0x1807B2800
	protected void set_Weight(float value) { }

	// RVA: 0x7B2760 Offset: 0x7B0D60 VA: 0x1807B2760
	public EntityComponentBase[] get_Components() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 97
	public virtual BasePlayer ToPlayer() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 98
	public virtual bool get_IsNpc() { }

	// RVA: 0x79F9F0 Offset: 0x79DFF0 VA: 0x18079F9F0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x7A2910 Offset: 0x7A0F10 VA: 0x1807A2910 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x7AFDD0 Offset: 0x7AE3D0 VA: 0x1807AFDD0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 99
	public virtual float InheritedVelocityScale() { }

	// RVA: 0x7A9780 Offset: 0x7A7D80 VA: 0x1807A9780 Slot: 100
	public virtual Vector3 GetInheritedProjectileVelocity() { }

	// RVA: 0x7A9900 Offset: 0x7A7F00 VA: 0x1807A9900 Slot: 101
	public virtual Vector3 GetInheritedThrowVelocity() { }

	// RVA: 0x7A96A0 Offset: 0x7A7CA0 VA: 0x1807A96A0 Slot: 102
	public virtual Vector3 GetInheritedDropVelocity() { }

	// RVA: 0x7AA740 Offset: 0x7A8D40 VA: 0x1807AA740
	public Vector3 GetParentVelocity() { }

	// RVA: 0x7AABA0 Offset: 0x7A91A0 VA: 0x1807AABA0
	public Vector3 GetWorldVelocity() { }

	// RVA: 0x7A9DC0 Offset: 0x7A83C0 VA: 0x1807A9DC0
	public Vector3 GetLocalVelocity() { }

	// RVA: 0x7A8F60 Offset: 0x7A7560 VA: 0x1807A8F60
	public Quaternion GetAngularVelocity() { }

	// RVA: 0x7B2490 Offset: 0x7B0A90 VA: 0x1807B2490 Slot: 103
	public virtual OBB WorldSpaceBounds() { }

	// RVA: 0x2FA9E0 Offset: 0x2F8FE0 VA: 0x1802FA9E0
	public Vector3 PivotPoint() { }

	// RVA: 0x7A65F0 Offset: 0x7A4BF0 VA: 0x1807A65F0
	public Vector3 CenterPoint() { }

	// RVA: 0x7A6850 Offset: 0x7A4E50 VA: 0x1807A6850
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x7A65F0 Offset: 0x7A4BF0 VA: 0x1807A65F0 Slot: 104
	public virtual Vector3 TriggerPoint() { }

	// RVA: 0x7A6FC0 Offset: 0x7A55C0 VA: 0x1807A6FC0 Slot: 105
	public float Distance(Vector3 position) { }

	// RVA: 0x7B0E00 Offset: 0x7AF400 VA: 0x1807B0E00
	public float SqrDistance(Vector3 position) { }

	// RVA: 0x7A6F60 Offset: 0x7A5560 VA: 0x1807A6F60
	public float Distance(BaseEntity other) { }

	// RVA: 0x7B0DA0 Offset: 0x7AF3A0 VA: 0x1807B0DA0
	public float SqrDistance(BaseEntity other) { }

	// RVA: 0x7A6E20 Offset: 0x7A5420 VA: 0x1807A6E20
	public float Distance2D(Vector3 position) { }

	// RVA: 0x7B0C60 Offset: 0x7AF260 VA: 0x1807B0C60
	public float SqrDistance2D(Vector3 position) { }

	// RVA: 0x7A6F60 Offset: 0x7A5560 VA: 0x1807A6F60
	public float Distance2D(BaseEntity other) { }

	// RVA: 0x7B0DA0 Offset: 0x7AF3A0 VA: 0x1807B0DA0
	public float SqrDistance2D(BaseEntity other) { }

	// RVA: 0x7AC400 Offset: 0x7AAA00 VA: 0x1807AC400
	public bool IsVisible(Ray ray, int layerMask, float maxDistance) { }

	// RVA: 0x7ABDB0 Offset: 0x7AA3B0 VA: 0x1807ABDB0
	public bool IsVisibleSpecificLayers(Vector3 position, Vector3 target, int layerMask, float maxDistance = ∞) { }

	// RVA: 0x7AC020 Offset: 0x7AA620 VA: 0x1807AC020
	public bool IsVisible(Vector3 position, Vector3 target, float maxDistance = ∞) { }

	// RVA: 0x7AC2A0 Offset: 0x7AA8A0 VA: 0x1807AC2A0
	public bool IsVisible(Vector3 position, float maxDistance = ∞) { }

	// RVA: 0x7ABBA0 Offset: 0x7AA1A0 VA: 0x1807ABBA0
	public bool IsVisibleAndCanSee(Vector3 position, float maxDistance = ∞) { }

	// RVA: 0x7AB7E0 Offset: 0x7A9DE0 VA: 0x1807AB7E0
	public bool IsOlderThan(BaseEntity other) { }

	// RVA: 0x7AB8B0 Offset: 0x7A9EB0 VA: 0x1807AB8B0 Slot: 106
	public virtual bool IsOutside() { }

	// RVA: 0x7AB910 Offset: 0x7A9F10 VA: 0x1807AB910
	public bool IsOutside(Vector3 position) { }

	// RVA: 0x7B2000 Offset: 0x7B0600 VA: 0x1807B2000 Slot: 107
	public virtual float WaterFactor() { }

	// RVA: 0x7A5DC0 Offset: 0x7A43C0 VA: 0x1807A5DC0 Slot: 108
	public virtual float AirFactor() { }

	// RVA: 0x7B21D0 Offset: 0x7B07D0 VA: 0x1807B21D0
	public bool WaterTestFromVolumes(Vector3 pos, out WaterLevel.WaterInfo info) { }

	// RVA: 0x7AB490 Offset: 0x7A9A90 VA: 0x1807AB490
	public bool IsInWaterVolume(Vector3 pos) { }

	// RVA: 0x7B20A0 Offset: 0x7B06A0 VA: 0x1807B20A0
	public bool WaterTestFromVolumes(Bounds bounds, out WaterLevel.WaterInfo info) { }

	// RVA: 0x7B2300 Offset: 0x7B0900 VA: 0x1807B2300
	public bool WaterTestFromVolumes(Vector3 start, Vector3 end, float radius, out WaterLevel.WaterInfo info) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 109
	public virtual bool BlocksWaterFor(BasePlayer player) { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 110
	public virtual float Health() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 111
	public virtual float MaxHealth() { }

	// RVA: 0x568670 Offset: 0x566C70 VA: 0x180568670 Slot: 112
	public virtual float MaxVelocity() { }

	// RVA: 0x7A5E00 Offset: 0x7A4400 VA: 0x1807A5E00 Slot: 113
	public virtual float BoundsPadding() { }

	// RVA: 0x723180 Offset: 0x721780 VA: 0x180723180 Slot: 114
	public virtual float PenetrationResistance(HitInfo info) { }

	// RVA: 0x7A9690 Offset: 0x7A7C90 VA: 0x1807A9690 Slot: 115
	public virtual GameObjectRef GetImpactEffect(HitInfo info) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 116
	public virtual void OnAttacked(HitInfo info) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 117
	public virtual Item GetItem() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 118
	public virtual Item GetItem(uint itemId) { }

	// RVA: 0x7AAF90 Offset: 0x7A9590 VA: 0x1807AAF90 Slot: 119
	public virtual void GiveItem(Item item, BaseEntity.GiveItemReason reason = 0) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 120
	public virtual bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 121
	public virtual BaseEntity GetEntity() { }

	// RVA: 0x7B1110 Offset: 0x7AF710 VA: 0x1807B1110 Slot: 3
	public override string ToString() { }

	// RVA: 0x7A65C0 Offset: 0x7A4BC0 VA: 0x1807A65C0 Slot: 122
	public virtual string Categorize() { }

	// RVA: 0x7AD2E0 Offset: 0x7AB8E0 VA: 0x1807AD2E0
	public void Log(string str) { }

	// RVA: 0x7B0570 Offset: 0x7AEB70 VA: 0x1807B0570
	public void SetModel(Model mdl) { }

	// RVA: 0x701870 Offset: 0x6FFE70 VA: 0x180701870
	public Model GetModel() { }

	// RVA: 0x7A9000 Offset: 0x7A7600 VA: 0x1807A9000 Slot: 123
	public virtual Transform[] GetBones() { }

	// RVA: 0x7A7F20 Offset: 0x7A6520 VA: 0x1807A7F20 Slot: 124
	public virtual Transform FindBone(string strName) { }

	// RVA: 0x7A7E40 Offset: 0x7A6440 VA: 0x1807A7E40 Slot: 125
	public virtual uint FindBoneID(Transform boneTransform) { }

	// RVA: 0x7A7FD0 Offset: 0x7A65D0 VA: 0x1807A7FD0 Slot: 126
	public virtual Transform FindClosestBone(Vector3 worldPos) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B27D0 Offset: 0x7B0DD0 VA: 0x1807B27D0
	public ulong get_OwnerID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B27F0 Offset: 0x7B0DF0 VA: 0x1807B27F0
	public void set_OwnerID(ulong value) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 127
	public virtual bool ShouldBlockProjectiles() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 128
	public virtual bool ShouldInheritNetworkGroup() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 129
	public virtual bool SupportsChildDeployables() { }

	// RVA: 0x7A5E10 Offset: 0x7A4410 VA: 0x1807A5E10
	public void BroadcastEntityMessage(string msg, float radius = 20, int layerMask = 1218652417) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 130
	public virtual void OnEntityMessage(BaseEntity from, string msg) { }

	// RVA: 0x7ACDE0 Offset: 0x7AB3E0 VA: 0x1807ACDE0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7B2650 Offset: 0x7B0C50 VA: 0x1807B2650
	public void .ctor() { }

	// RVA: 0x7B25D0 Offset: 0x7B0BD0 VA: 0x1807B25D0
	private static void .cctor() { }

}

public class BaseEntity.Menu : Attribute // TypeDefIndex: 8493
{	// Fields
	public string TitleToken; // 0x10
	public string TitleEnglish; // 0x18
	public string UseVariable; // 0x20
	public int Order; // 0x28
	public string ProxyFunction; // 0x30
	public float Time; // 0x38
	public string OnStart; // 0x40
	public string OnProgress; // 0x48
	public bool LongUseOnly; // 0x50

	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

	// RVA: 0x7B8CB0 Offset: 0x7B72B0 VA: 0x1807B8CB0
	public void .ctor(string menuTitleToken, string menuTitleEnglish) { }

}

public struct BaseEntity.Menu.Option // TypeDefIndex: 8494
{	// Fields
	public Translate.Phrase name; // 0x0
	public Translate.Phrase description; // 0x8
	public Sprite icon; // 0x10
	public int order; // 0x18
	public bool usableWhileWounded; // 0x1C

	// Methods

	// RVA: 0xF5950 Offset: 0xF4D50 VA: 0x1800F5950
	public void CopyTo(ref Option option) { }

}

public class BaseEntity.Menu.Description : Attribute // TypeDefIndex: 8495
{	// Fields
	public string token; // 0x10
	public string english; // 0x18

	// Methods

	// RVA: 0x7B8CB0 Offset: 0x7B72B0 VA: 0x1807B8CB0
	public void .ctor(string t, string e) { }

}

public class BaseEntity.Menu.Icon : Attribute // TypeDefIndex: 8496
{	// Fields
	public string icon; // 0x10

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string i) { }

}

public class BaseEntity.Menu.ShowIf : Attribute // TypeDefIndex: 8497
{	// Fields
	public string functionName; // 0x10

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string testFunc) { }

}

public class BaseEntity.Menu.UsableWhileWounded : Attribute // TypeDefIndex: 8498
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

public struct BaseEntity.MovementModify // TypeDefIndex: 8499
{	// Fields
	public float drag; // 0x0

}

public enum BaseEntity.Flags // TypeDefIndex: 8500
{	// Fields
	public int value__; // 0x0
	public const BaseEntity.Flags Placeholder = 1;
	public const BaseEntity.Flags On = 2;
	public const BaseEntity.Flags OnFire = 4;
	public const BaseEntity.Flags Open = 8;
	public const BaseEntity.Flags Locked = 16;
	public const BaseEntity.Flags Debugging = 32;
	public const BaseEntity.Flags Disabled = 64;
	public const BaseEntity.Flags Reserved1 = 128;
	public const BaseEntity.Flags Reserved2 = 256;
	public const BaseEntity.Flags Reserved3 = 512;
	public const BaseEntity.Flags Reserved4 = 1024;
	public const BaseEntity.Flags Reserved5 = 2048;
	public const BaseEntity.Flags Broken = 4096;
	public const BaseEntity.Flags Busy = 8192;
	public const BaseEntity.Flags Reserved6 = 16384;
	public const BaseEntity.Flags Reserved7 = 32768;
	public const BaseEntity.Flags Reserved8 = 65536;
	public const BaseEntity.Flags Reserved9 = 131072;
	public const BaseEntity.Flags Reserved10 = 262144;
	public const BaseEntity.Flags Reserved11 = 524288;

}

private struct BaseEntity.ServerFileRequest : IEquatable<BaseEntity.ServerFileRequest> // TypeDefIndex: 8501
{	// Fields
	public readonly FileStorage.Type Type; // 0x0
	public readonly uint NumId; // 0x4
	public readonly uint Crc; // 0x8
	public readonly IServerFileReceiver Receiver; // 0x10
	public readonly float Time; // 0x18

	// Methods

	// RVA: 0xF5BA0 Offset: 0xF4FA0 VA: 0x1800F5BA0
	public void .ctor(FileStorage.Type type, uint numId, uint crc, IServerFileReceiver receiver) { }

	// RVA: 0xF5AF0 Offset: 0xF4EF0 VA: 0x1800F5AF0 Slot: 4
	public bool Equals(BaseEntity.ServerFileRequest other) { }

	// RVA: 0xF5A40 Offset: 0xF4E40 VA: 0x1800F5A40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF5B40 Offset: 0xF4F40 VA: 0x1800F5B40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7B9870 Offset: 0x7B7E70 VA: 0x1807B9870
	public static bool op_Equality(BaseEntity.ServerFileRequest left, BaseEntity.ServerFileRequest right) { }

	// RVA: 0x7B9920 Offset: 0x7B7F20 VA: 0x1807B9920
	public static bool op_Inequality(BaseEntity.ServerFileRequest left, BaseEntity.ServerFileRequest right) { }

}

public class BaseEntity.Query.EntityTree // TypeDefIndex: 8503
{
// Namespace: 
public class BaseEntity.Query.EntityTree // TypeDefIndex: 8503
	// Fields
	private Grid<BaseEntity> Grid; // 0x10
	private Grid<BasePlayer> PlayerGrid; // 0x18
	private Grid<BaseEntity> BrainGrid; // 0x20

	// Methods

	// RVA: 0x7B9620 Offset: 0x7B7C20 VA: 0x1807B9620
	public void .ctor(float worldSize) { }

	// RVA: 0x7B8E40 Offset: 0x7B7440 VA: 0x1807B8E40
	public void Add(BaseEntity ent) { }

	// RVA: 0x7B8DA0 Offset: 0x7B73A0 VA: 0x1807B8DA0
	public void AddPlayer(BasePlayer player) { }

	// RVA: 0x7B8D00 Offset: 0x7B7300 VA: 0x1807B8D00
	public void AddBrain(BaseEntity entity) { }

	// RVA: 0x7B9520 Offset: 0x7B7B20 VA: 0x1807B9520
	public void Remove(BaseEntity ent, bool isPlayer = False) { }

	// RVA: 0x7B94C0 Offset: 0x7B7AC0 VA: 0x1807B94C0
	public void RemovePlayer(BasePlayer player) { }

	// RVA: 0x7B9430 Offset: 0x7B7A30 VA: 0x1807B9430
	public void RemoveBrain(BaseEntity entity) { }

	// RVA: 0x7B9200 Offset: 0x7B7800 VA: 0x1807B9200
	public void Move(BaseEntity ent) { }

	// RVA: 0x7B9160 Offset: 0x7B7760 VA: 0x1807B9160
	public void MovePlayer(BasePlayer player) { }

	// RVA: 0x7B90C0 Offset: 0x7B76C0 VA: 0x1807B90C0
	public void MoveBrain(BaseEntity entity) { }

	// RVA: 0x7B8F80 Offset: 0x7B7580 VA: 0x1807B8F80
	public int GetInSphere(Vector3 position, float distance, BaseEntity[] results, Func<BaseEntity, bool> filter) { }

	// RVA: 0x7B9020 Offset: 0x7B7620 VA: 0x1807B9020
	public int GetPlayersInSphere(Vector3 position, float distance, BasePlayer[] results, Func<BasePlayer, bool> filter) { }

	// RVA: 0x7B8EE0 Offset: 0x7B74E0 VA: 0x1807B8EE0
	public int GetBrainsInSphere(Vector3 position, float distance, BaseEntity[] results, Func<BaseEntity, bool> filter) { }

}

public class BaseEntity.RPC_Shared : Attribute // TypeDefIndex: 8504
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

public struct BaseEntity.RPCMessage // TypeDefIndex: 8505
{	// Fields
	public Connection connection; // 0x0
	public BasePlayer player; // 0x8
	public NetRead read; // 0x10

}

public class BaseEntity.RPC_Client : BaseEntity.RPC_Shared // TypeDefIndex: 8506
{	// Methods

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

public enum BaseEntity.Signal // TypeDefIndex: 8507
{	// Fields
	public int value__; // 0x0
	public const BaseEntity.Signal Attack = 0;
	public const BaseEntity.Signal Alt_Attack = 1;
	public const BaseEntity.Signal DryFire = 2;
	public const BaseEntity.Signal Reload = 3;
	public const BaseEntity.Signal Deploy = 4;
	public const BaseEntity.Signal Flinch_Head = 5;
	public const BaseEntity.Signal Flinch_Chest = 6;
	public const BaseEntity.Signal Flinch_Stomach = 7;
	public const BaseEntity.Signal Flinch_RearHead = 8;
	public const BaseEntity.Signal Flinch_RearTorso = 9;
	public const BaseEntity.Signal Throw = 10;
	public const BaseEntity.Signal Relax = 11;
	public const BaseEntity.Signal Gesture = 12;
	public const BaseEntity.Signal PhysImpact = 13;
	public const BaseEntity.Signal Eat = 14;
	public const BaseEntity.Signal Startled = 15;
	public const BaseEntity.Signal Admire = 16;

}

public enum BaseEntity.Slot // TypeDefIndex: 8508
{	// Fields
	public int value__; // 0x0
	public const BaseEntity.Slot Lock = 0;
	public const BaseEntity.Slot FireMod = 1;
	public const BaseEntity.Slot UpperModifier = 2;
	public const BaseEntity.Slot MiddleModifier = 3;
	public const BaseEntity.Slot LowerModifier = 4;
	public const BaseEntity.Slot CenterDecoration = 5;
	public const BaseEntity.Slot LowerCenterDecoration = 6;
	public const BaseEntity.Slot StorageMonitor = 7;
	public const BaseEntity.Slot Count = 8;

}

public enum BaseEntity.TraitFlag // TypeDefIndex: 8509
{	// Fields
	public int value__; // 0x0
	public const BaseEntity.TraitFlag None = 0;
	public const BaseEntity.TraitFlag Alive = 1;
	public const BaseEntity.TraitFlag Animal = 2;
	public const BaseEntity.TraitFlag Human = 4;
	public const BaseEntity.TraitFlag Interesting = 8;
	public const BaseEntity.TraitFlag Food = 16;
	public const BaseEntity.TraitFlag Meat = 32;
	public const BaseEntity.TraitFlag Water = 32;

}

public enum BaseEntity.GiveItemReason // TypeDefIndex: 8511
{
// Namespace: 
public enum BaseEntity.GiveItemReason // TypeDefIndex: 8511
	// Fields
	public int value__; // 0x0
	public const BaseEntity.GiveItemReason Generic = 0;
	public const BaseEntity.GiveItemReason ResourceHarvested = 1;
	public const BaseEntity.GiveItemReason PickedUp = 2;
	public const BaseEntity.GiveItemReason Crafted = 3;

}

private sealed class BaseEntity.<>c // TypeDefIndex: 8512
{	// Fields
	public static readonly BaseEntity.<>c <>9; // 0x0
	public static Comparison<Option> <>9__35_0; // 0x8
	public static Predicate<BaseEntity.ServerFileRequest> <>9__93_0; // 0x10

	// Methods

	// RVA: 0x7B9A10 Offset: 0x7B8010 VA: 0x1807B9A10
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7B9970 Offset: 0x7B7F70 VA: 0x1807B9970
	internal int <GetMenuItems>b__35_0(Option x, Option y) { }

	// RVA: 0x7B99A0 Offset: 0x7B7FA0 VA: 0x1807B99A0
	internal bool <RequestFileFromServer>b__93_0(BaseEntity.ServerFileRequest r) { }

}

