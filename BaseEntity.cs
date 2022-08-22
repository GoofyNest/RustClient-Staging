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

	// RVA: 0x1FFE650 Offset: 0x1FFCC50 VA: 0x181FFE650
	public static void ResetToPool(BaseEntity instance) { }

	// RVA: 0x1FFE710 Offset: 0x1FFCD10 VA: 0x181FFE710
	public void ResetToPool() { }

	// RVA: 0x1FFE2A0 Offset: 0x1FFC8A0 VA: 0x181FFE2A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FFCF80 Offset: 0x1FFB580 VA: 0x181FFCF80
	public void CopyTo(BaseEntity instance) { }

	// RVA: 0x1FFCFD0 Offset: 0x1FFB5D0 VA: 0x181FFCFD0
	public BaseEntity Copy() { }

	// RVA: 0x1FFDCF0 Offset: 0x1FFC2F0 VA: 0x181FFDCF0
	public static BaseEntity Deserialize(Stream stream) { }

	// RVA: 0x1FFD070 Offset: 0x1FFB670 VA: 0x181FFD070
	public static BaseEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FFD410 Offset: 0x1FFBA10 VA: 0x181FFD410
	public static BaseEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FFDF70 Offset: 0x1FFC570 VA: 0x181FFDF70
	public static BaseEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1FFE3E0 Offset: 0x1FFC9E0 VA: 0x181FFE3E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FFF0F0 Offset: 0x1FFD6F0 VA: 0x181FFF0F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FFF110 Offset: 0x1FFD710 VA: 0x181FFF110 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseEntity previous) { }

	// RVA: 0x1FFE630 Offset: 0x1FFCC30 VA: 0x181FFE630 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FFD9E0 Offset: 0x1FFBFE0 VA: 0x181FFD9E0
	public static BaseEntity Deserialize(byte[] buffer, BaseEntity instance, bool isDelta = False) { }

	// RVA: 0x1FFD790 Offset: 0x1FFBD90 VA: 0x181FFD790
	public static BaseEntity Deserialize(Stream stream, BaseEntity instance, bool isDelta) { }

	// RVA: 0x1FFD0F0 Offset: 0x1FFB6F0 VA: 0x181FFD0F0
	public static BaseEntity DeserializeLengthDelimited(Stream stream, BaseEntity instance, bool isDelta) { }

	// RVA: 0x1FFD4A0 Offset: 0x1FFBAA0 VA: 0x181FFD4A0
	public static BaseEntity DeserializeLength(Stream stream, int length, BaseEntity instance, bool isDelta) { }

	// RVA: 0x1FFE7D0 Offset: 0x1FFCDD0 VA: 0x181FFE7D0
	public static void SerializeDelta(Stream stream, BaseEntity instance, BaseEntity previous) { }

	// RVA: 0x1FFEE30 Offset: 0x1FFD430 VA: 0x181FFEE30
	public static void Serialize(Stream stream, BaseEntity instance) { }

	// RVA: 0x1FFF0E0 Offset: 0x1FFD6E0 VA: 0x181FFF0E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FFF0F0 Offset: 0x1FFD6F0 VA: 0x181FFF0F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1FFED20 Offset: 0x1FFD320 VA: 0x181FFED20
	public static byte[] SerializeToBytes(BaseEntity instance) { }

	// RVA: 0x1FFEC70 Offset: 0x1FFD270 VA: 0x181FFEC70
	public static void SerializeLengthDelimited(Stream stream, BaseEntity instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x7E25D0 Offset: 0x7E0BD0 VA: 0x1807E25D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7DDB10 Offset: 0x7DC110 VA: 0x1807DDB10
	public void GetEntityMenu(BasePlayer player, List<Option> optionList) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 49
	public virtual void GetMenuOptions(List<Option> list) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 50
	public virtual bool get_HasMenuOptions() { }

	// RVA: 0x7DE1C0 Offset: 0x7DC7C0 VA: 0x1807DE1C0 Slot: 51
	public virtual void GetItemOptions(List<Option> options) { }

	// RVA: 0x7DEC10 Offset: 0x7DD210 VA: 0x1807DEC10
	public BaseEntity.MovementModify GetMovementModify() { }

	// RVA: 0x7DDC50 Offset: 0x7DC250 VA: 0x1807DDC50 Slot: 52
	public virtual float GetExtrapolationTime() { }

	// RVA: 0x7DE010 Offset: 0x7DC610 VA: 0x1807DE010 Slot: 53
	public virtual float GetInterpolationDelay() { }

	// RVA: 0x7DE0A0 Offset: 0x7DC6A0 VA: 0x1807DE0A0 Slot: 54
	public virtual float GetInterpolationInertia() { }

	// RVA: 0x7DE130 Offset: 0x7DC730 VA: 0x1807DE130 Slot: 55
	public virtual float GetInterpolationSmoothing() { }

	// RVA: 0x7DD5B0 Offset: 0x7DBBB0 VA: 0x1807DD5B0 Slot: 56
	public virtual Quaternion GetAngularVelocityClient() { }

	// RVA: 0x7DE410 Offset: 0x7DCA10 VA: 0x1807DE410 Slot: 57
	public virtual Vector3 GetLocalVelocityClient() { }

	// RVA: 0x7DBAB0 Offset: 0x7DA0B0 VA: 0x1807DBAB0 Slot: 43
	public void DrawInterpolationState(Interpolator.Segment<TransformSnapshot> segment, List<TransformSnapshot> entries) { }

	// RVA: 0x7E0F40 Offset: 0x7DF540 VA: 0x1807E0F40 Slot: 44
	public void LerpIdleDisable() { }

	// RVA: 0x7DAD30 Offset: 0x7D9330 VA: 0x1807DAD30 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7DADE0 Offset: 0x7D93E0 VA: 0x1807DADE0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x7E2260 Offset: 0x7E0860 VA: 0x1807E2260
	public void OnPositionalFromNetwork(Vector3 vPos, Vector3 vAng, float time) { }

	// RVA: 0x7E5620 Offset: 0x7E3C20 VA: 0x1807E5620
	public void StartLerping(float time) { }

	// RVA: 0x7E57A0 Offset: 0x7E3DA0 VA: 0x1807E57A0
	public void StopLerping() { }

	// RVA: 0x7E5210 Offset: 0x7E3810 VA: 0x1807E5210 Slot: 58
	public virtual bool ShouldLerp() { }

	// RVA: 0x7E4D00 Offset: 0x7E3300 VA: 0x1807E4D00 Slot: 59
	public virtual void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0x7E4E70 Offset: 0x7E3470 VA: 0x1807E4E70 Slot: 60
	public virtual void SetNetworkRotation(Quaternion qRot) { }

	// RVA: 0x7DBA90 Offset: 0x7DA090 VA: 0x1807DBA90 Slot: 61
	public virtual void DoDestroyEffects(BaseNetworkable.DestroyMode mode, Message msg) { }

	// RVA: 0x7E5310 Offset: 0x7E3910 VA: 0x1807E5310 Slot: 62
	protected virtual void SpawnGibs() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0 Slot: 20
	internal override void DoNetworkDestroy() { }

	// RVA: 0x7E3990 Offset: 0x7E1F90 VA: 0x1807E3990 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x7E1FA0 Offset: 0x7E05A0 VA: 0x1807E1FA0 Slot: 63
	public virtual void OnBecameRagdoll(Ragdoll rdoll) { }

	// RVA: 0x7DE590 Offset: 0x7DCB90 VA: 0x1807DE590 Slot: 64
	public virtual Info GetMenuInformation(GameObject primaryObject, BasePlayer player) { }

	// RVA: 0x7DF960 Offset: 0x7DDF60 VA: 0x1807DF960 Slot: 65
	protected virtual bool HideMenuItems(BasePlayer player) { }

	// RVA: 0x7DE880 Offset: 0x7DCE80 VA: 0x1807DE880 Slot: 66
	public virtual List<Option> GetMenuItems(BasePlayer player) { }

	// RVA: 0x7E3780 Offset: 0x7E1D80 VA: 0x1807E3780 Slot: 67
	public virtual void OnUse(BasePlayer player) { }

	// RVA: 0x7E3560 Offset: 0x7E1B60 VA: 0x1807E3560 Slot: 68
	public virtual void OnUseHeld(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 69
	public virtual void OnUseStopped(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 70
	public virtual void OnRendered() { }

	// RVA: 0x7DB7E0 Offset: 0x7D9DE0 VA: 0x1807DB7E0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x7DDCE0 Offset: 0x7DC2E0 VA: 0x1807DDCE0 Slot: 71
	internal virtual Transform GetEyeTransform() { }

	// RVA: 0x7E1E90 Offset: 0x7E0490 VA: 0x1807E1E90 Slot: 72
	public virtual bool NeedsCrosshair() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 73
	public virtual bool AlwaysShowCrosshair() { }

	// RVA: 0x7E5160 Offset: 0x7E3760 VA: 0x1807E5160 Slot: 17
	public override bool ShouldDestroyWithGroup() { }

	// RVA: 0x7DB3D0 Offset: 0x7D99D0 VA: 0x1807DB3D0
	public void DetachEffects() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 74
	public virtual void OnVoiceData(byte[] data) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 75
	public virtual void LookingAtTick() { }

	// RVA: 0x723230 Offset: 0x721830 VA: 0x180723230 Slot: 76
	public virtual float get_RealisticMass() { }

	// RVA: 0x7E2050 Offset: 0x7E0650 VA: 0x1807E2050 Slot: 77
	public virtual void OnCollision(Collision collision, BaseEntity hitEntity) { }

	// RVA: 0x7E3A80 Offset: 0x7E2080 VA: 0x1807E3A80
	protected void ReceiveCollisionMessages(bool b) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 78
	public virtual void DebugClient(int rep, float time) { }

	// RVA: 0x7E20A0 Offset: 0x7E06A0 VA: 0x1807E20A0
	public void OnDebugStart() { }

	// RVA: 0x7DB310 Offset: 0x7D9910 VA: 0x1807DB310
	protected void DebugText(Vector3 pos, string str, Color color, float time) { }

	// RVA: 0x7DF920 Offset: 0x7DDF20 VA: 0x1807DF920 Slot: 79
	public bool HasFlag(BaseEntity.Flags f) { }

	// RVA: 0x7E38F0 Offset: 0x7E1EF0 VA: 0x1807E38F0
	public bool ParentHasFlag(BaseEntity.Flags f) { }

	// RVA: 0x7E4B30 Offset: 0x7E3130 VA: 0x1807E4B30
	public void SetFlag(BaseEntity.Flags f, bool b, bool recursive = False, bool networkupdate = True) { }

	// RVA: 0x7DFF70 Offset: 0x7DE570 VA: 0x1807DFF70
	public bool IsOn() { }

	// RVA: 0x7DFF80 Offset: 0x7DE580 VA: 0x1807DFF80
	public bool IsOpen() { }

	// RVA: 0x7DFF60 Offset: 0x7DE560 VA: 0x1807DFF60
	public bool IsOnFire() { }

	// RVA: 0x7DFCB0 Offset: 0x7DE2B0 VA: 0x1807DFCB0
	public bool IsLocked() { }

	// RVA: 0x7DFAC0 Offset: 0x7DE0C0 VA: 0x1807DFAC0 Slot: 4
	public override bool IsDebugging() { }

	// RVA: 0x7DFAD0 Offset: 0x7DE0D0 VA: 0x1807DFAD0
	public bool IsDisabled() { }

	// RVA: 0x7DFAB0 Offset: 0x7DE0B0 VA: 0x1807DFAB0
	public bool IsBroken() { }

	// RVA: 0x7DF960 Offset: 0x7DDF60 VA: 0x1807DF960
	public bool IsBusy() { }

	// RVA: 0x7DE540 Offset: 0x7DCB40 VA: 0x1807DE540 Slot: 5
	public override string GetLogColor() { }

	// RVA: 0x7E2160 Offset: 0x7E0760 VA: 0x1807E2160 Slot: 80
	public virtual void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x7DFDB0 Offset: 0x7DE3B0 VA: 0x1807DFDB0
	public bool IsOccupied(Socket_Base socket) { }

	// RVA: 0x7DFCC0 Offset: 0x7DE2C0 VA: 0x1807DFCC0
	public bool IsOccupied(string socketName) { }

	// RVA: 0x7DC770 Offset: 0x7DAD70 VA: 0x1807DC770
	public EntityLink FindLink(Socket_Base socket) { }

	// RVA: 0x7DC870 Offset: 0x7DAE70 VA: 0x1807DC870
	public EntityLink FindLink(string socketName) { }

	// RVA: 0x7DC950 Offset: 0x7DAF50 VA: 0x1807DC950
	public EntityLink FindLink(string[] socketNames) { }

	// RVA: -1 Offset: -1
	public T FindLinkedEntity<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C9FF0 Offset: 0x5C85F0 VA: 0x1805C9FF0
	|-BaseEntity.FindLinkedEntity<object>
	*/

	// RVA: -1 Offset: -1
	public void EntityLinkMessage<T>(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156A500 Offset: 0x1568B00 VA: 0x18156A500
	|-BaseEntity.EntityLinkMessage<object>
	*/

	// RVA: -1 Offset: -1
	public void EntityLinkBroadcast<T, S>(Action<T> action, Func<S, bool> canTraverseSocket) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1569BA0 Offset: 0x15681A0 VA: 0x181569BA0
	|-BaseEntity.EntityLinkBroadcast<object, object>
	*/

	// RVA: -1 Offset: -1
	public void EntityLinkBroadcast<T>(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156A0C0 Offset: 0x15686C0 VA: 0x18156A0C0
	|-BaseEntity.EntityLinkBroadcast<object>
	*/

	// RVA: 0x7DC250 Offset: 0x7DA850 VA: 0x1807DC250
	public void EntityLinkBroadcast() { }

	// RVA: 0x7E3B10 Offset: 0x7E2110 VA: 0x1807E3B10
	public bool ReceivedEntityLinkBroadcast() { }

	// RVA: 0x7DDAD0 Offset: 0x7DC0D0 VA: 0x1807DDAD0
	public List<EntityLink> GetEntityLinks(bool linkToNeighbours = True) { }

	// RVA: 0x7E0F70 Offset: 0x7DF570 VA: 0x1807E0F70
	private void LinkToEntity(BaseEntity other) { }

	// RVA: 0x7E11D0 Offset: 0x7DF7D0 VA: 0x1807E11D0
	private void LinkToNeighbours() { }

	// RVA: 0x7DF970 Offset: 0x7DDF70 VA: 0x1807DF970
	private void InitEntityLinks() { }

	// RVA: 0x7DD4D0 Offset: 0x7DBAD0 VA: 0x1807DD4D0
	private void FreeEntityLinks() { }

	// RVA: 0x7E3B80 Offset: 0x7E2180 VA: 0x1807E3B80
	public void RefreshEntityLinks() { }

	[ObsoleteAttribute] // RVA: 0x9F7E0 Offset: 0x9EBE0 VA: 0x18009F7E0
	// RVA: 0x7E4400 Offset: 0x7E2A00 VA: 0x1807E4400
	public void RequestFileFromServer(uint crc, FileStorage.Type type, string responseFunction, uint part = 0) { }

	// RVA: 0x7E40C0 Offset: 0x7E26C0 VA: 0x1807E40C0
	public void RequestFileFromServer(IServerFileReceiver receiver, FileStorage.Type type, uint crc, uint part = 0, bool respondIfNotFound = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7DAA40 Offset: 0x7D9040 VA: 0x1807DAA40
	public void CL_ReceiveFileRequest(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7DAFE0 Offset: 0x7D95E0 VA: 0x1807DAFE0
	private void CompletePendingFileRequests(FileStorage.Type type, uint crc, uint part, byte[] data) { }

	// RVA: 0x7E5960 Offset: 0x7E3F60 VA: 0x1807E5960
	public void UpdateChildren() { }

	// RVA: 0x7E66D0 Offset: 0x7E4CD0 VA: 0x1807E66D0
	public void UpdateParenting() { }

	// RVA: 0x7E6050 Offset: 0x7E4650 VA: 0x1807E6050
	public void UpdateParenting(bool worldPositionStays) { }

	// RVA: 0x7E4F40 Offset: 0x7E3540 VA: 0x1807E4F40
	private void SetParentTransform(Transform parent, bool worldPositionStays = True) { }

	// RVA: 0x7E5CD0 Offset: 0x7E42D0 VA: 0x1807E5CD0
	protected void UpdateDisableState() { }

	// RVA: 0x7DF780 Offset: 0x7DDD80 VA: 0x1807DF780
	private bool HasClientTransformOffset() { }

	// RVA: 0x7E3E90 Offset: 0x7E2490 VA: 0x1807E3E90
	private void RemoveClientTransformOffset() { }

	// RVA: 0x7DA400 Offset: 0x7D8A00 VA: 0x1807DA400
	private void AddClientTransformOffset() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 81
	public virtual void OnParentChangingClient(Transform oldParent, Transform newParent) { }

	// RVA: 0x7DDA60 Offset: 0x7DC060 VA: 0x1807DDA60 Slot: 82
	public virtual BuildingPrivlidge GetBuildingPrivilege() { }

	// RVA: 0x7DD770 Offset: 0x7DBD70 VA: 0x1807DD770
	public BuildingPrivlidge GetBuildingPrivilege(OBB obb) { }

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3, T4, T5>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156BC60 Offset: 0x156A260 VA: 0x18156BC60
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, object>
	|
	|-RVA: 0x156C170 Offset: 0x156A770 VA: 0x18156C170
	|-BaseEntity.ServerRPC<int, int, int, int, byte>
	|
	|-RVA: 0x156BEF0 Offset: 0x156A4F0 VA: 0x18156BEF0
	|-BaseEntity.ServerRPC<int, Color, Color, Color, Color>
	|
	|-RVA: 0x156DF00 Offset: 0x156C500 VA: 0x18156DF00
	|-BaseEntity.ServerRPC<object, object, object, object, object>
	|
	|-RVA: 0x156EB20 Offset: 0x156D120 VA: 0x18156EB20
	|-BaseEntity.ServerRPC<uint, byte, uint, uint, bool>
	|
	|-RVA: 0x156F350 Offset: 0x156D950 VA: 0x18156F350
	|-BaseEntity.ServerRPC<uint, int, uint, int, int>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3, T4>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156C3B0 Offset: 0x156A9B0 VA: 0x18156C3B0
	|-BaseEntity.ServerRPC<int, int, int, int>
	|
	|-RVA: 0x156C5D0 Offset: 0x156ABD0 VA: 0x18156C5D0
	|-BaseEntity.ServerRPC<int, int, int, float>
	|
	|-RVA: 0x156CBD0 Offset: 0x156B1D0 VA: 0x18156CBD0
	|-BaseEntity.ServerRPC<int, int, object, bool>
	|
	|-RVA: 0x156D3B0 Offset: 0x156B9B0 VA: 0x18156D3B0
	|-BaseEntity.ServerRPC<int, uint, object, bool>
	|
	|-RVA: 0x156DCE0 Offset: 0x156C2E0 VA: 0x18156DCE0
	|-BaseEntity.ServerRPC<object, object, int, object>
	|
	|-RVA: 0x156E150 Offset: 0x156C750 VA: 0x18156E150
	|-BaseEntity.ServerRPC<object, object, object, object>
	|
	|-RVA: 0x156ED10 Offset: 0x156D310 VA: 0x18156ED10
	|-BaseEntity.ServerRPC<uint, byte, uint, uint>
	|
	|-RVA: 0x156FE50 Offset: 0x156E450 VA: 0x18156FE50
	|-BaseEntity.ServerRPC<uint, uint, sbyte, int>
	|
	|-RVA: 0x1570520 Offset: 0x156EB20 VA: 0x181570520
	|-BaseEntity.ServerRPC<ulong, uint, uint, object>
	|
	|-RVA: 0x1570BC0 Offset: 0x156F1C0 VA: 0x181570BC0
	|-BaseEntity.ServerRPC<Vector3, Vector3, int, int>
	|
	|-RVA: 0x1571030 Offset: 0x156F630 VA: 0x181571030
	|-BaseEntity.ServerRPC<Vector3, Vector3, Vector3, int>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156B870 Offset: 0x1569E70 VA: 0x18156B870
	|-BaseEntity.ServerRPC<bool, Vector3, uint>
	|
	|-RVA: 0x156C7A0 Offset: 0x156ADA0 VA: 0x18156C7A0
	|-BaseEntity.ServerRPC<int, int, int>
	|
	|-RVA: 0x156CA00 Offset: 0x156B000 VA: 0x18156CA00
	|-BaseEntity.ServerRPC<int, int, Ray>
	|
	|-RVA: 0x156D010 Offset: 0x156B610 VA: 0x18156D010
	|-BaseEntity.ServerRPC<int, object, int>
	|
	|-RVA: 0x156E380 Offset: 0x156C980 VA: 0x18156E380
	|-BaseEntity.ServerRPC<object, object, object>
	|
	|-RVA: 0x156EF30 Offset: 0x156D530 VA: 0x18156EF30
	|-BaseEntity.ServerRPC<uint, int, bool>
	|
	|-RVA: 0x156F130 Offset: 0x156D730 VA: 0x18156F130
	|-BaseEntity.ServerRPC<uint, int, int>
	|
	|-RVA: 0x156F6E0 Offset: 0x156DCE0 VA: 0x18156F6E0
	|-BaseEntity.ServerRPC<uint, object, int>
	|
	|-RVA: 0x156F8E0 Offset: 0x156DEE0 VA: 0x18156F8E0
	|-BaseEntity.ServerRPC<uint, object, object>
	|
	|-RVA: 0x156FAA0 Offset: 0x156E0A0 VA: 0x18156FAA0
	|-BaseEntity.ServerRPC<uint, object, ulong>
	|
	|-RVA: 0x1570940 Offset: 0x156EF40 VA: 0x181570940
	|-BaseEntity.ServerRPC<Vector3, Vector3, bool>
	|
	|-RVA: 0x1570E40 Offset: 0x156F440 VA: 0x181570E40
	|-BaseEntity.ServerRPC<Vector3, Vector3, float>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156CE30 Offset: 0x156B430 VA: 0x18156CE30
	|-BaseEntity.ServerRPC<int, int>
	|
	|-RVA: 0x156D210 Offset: 0x156B810 VA: 0x18156D210
	|-BaseEntity.ServerRPC<int, object>
	|
	|-RVA: 0x156DB00 Offset: 0x156C100 VA: 0x18156DB00
	|-BaseEntity.ServerRPC<object, bool>
	|
	|-RVA: 0x156E580 Offset: 0x156CB80 VA: 0x18156E580
	|-BaseEntity.ServerRPC<object, object>
	|
	|-RVA: 0x156F540 Offset: 0x156DB40 VA: 0x18156F540
	|-BaseEntity.ServerRPC<uint, int>
	|
	|-RVA: 0x156FC60 Offset: 0x156E260 VA: 0x18156FC60
	|-BaseEntity.ServerRPC<uint, object>
	|
	|-RVA: 0x15701A0 Offset: 0x156E7A0 VA: 0x1815701A0
	|-BaseEntity.ServerRPC<ulong, int>
	|
	|-RVA: 0x1570380 Offset: 0x156E980 VA: 0x181570380
	|-BaseEntity.ServerRPC<ulong, object>
	|
	|-RVA: 0x156D780 Offset: 0x156BD80 VA: 0x18156D780
	|-BaseEntity.ServerRPC<Ray, int>
	|
	|-RVA: 0x156D940 Offset: 0x156BF40 VA: 0x18156D940
	|-BaseEntity.ServerRPC<Ray, uint>
	|
	|-RVA: 0x1571360 Offset: 0x156F960 VA: 0x181571360
	|-BaseEntity.ServerRPC<Vector3, Vector3>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1>(SendMethod sendMethod, string funcName, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156BA50 Offset: 0x156A050 VA: 0x18156BA50
	|-BaseEntity.ServerRPC<bool>
	|
	|-RVA: 0x156D580 Offset: 0x156BB80 VA: 0x18156D580
	|-BaseEntity.ServerRPC<int>
	|
	|-RVA: 0x156E790 Offset: 0x156CD90 VA: 0x18156E790
	|-BaseEntity.ServerRPC<object>
	|
	|-RVA: 0x156E910 Offset: 0x156CF10 VA: 0x18156E910
	|-BaseEntity.ServerRPC<float>
	|
	|-RVA: 0x1570020 Offset: 0x156E620 VA: 0x181570020
	|-BaseEntity.ServerRPC<uint>
	|
	|-RVA: 0x1570740 Offset: 0x156ED40 VA: 0x181570740
	|-BaseEntity.ServerRPC<ulong>
	|
	|-RVA: 0x1571570 Offset: 0x156FB70 VA: 0x181571570
	|-BaseEntity.ServerRPC<Vector3>
	*/

	// RVA: 0x7E47F0 Offset: 0x7E2DF0 VA: 0x1807E47F0
	public void ServerRPC(SendMethod sendMethod, string funcName) { }

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3, T4, T5>(string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156BC00 Offset: 0x156A200 VA: 0x18156BC00
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, byte[]>
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, object>
	|
	|-RVA: 0x156C110 Offset: 0x156A710 VA: 0x18156C110
	|-BaseEntity.ServerRPC<int, int, int, int, byte>
	|
	|-RVA: 0x156BE50 Offset: 0x156A450 VA: 0x18156BE50
	|-BaseEntity.ServerRPC<int, Color, Color, Color, Color>
	|
	|-RVA: 0x156E0F0 Offset: 0x156C6F0 VA: 0x18156E0F0
	|-BaseEntity.ServerRPC<object, object, object, object, object>
	|-BaseEntity.ServerRPC<string, string, string, string, string>
	|
	|-RVA: 0x156EAC0 Offset: 0x156D0C0 VA: 0x18156EAC0
	|-BaseEntity.ServerRPC<uint, byte, uint, uint, bool>
	|
	|-RVA: 0x156F2F0 Offset: 0x156D8F0 VA: 0x18156F2F0
	|-BaseEntity.ServerRPC<uint, int, uint, int, int>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3, T4>(string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156CDA0 Offset: 0x156B3A0 VA: 0x18156CDA0
	|-BaseEntity.ServerRPC<int, int, byte[], bool>
	|-BaseEntity.ServerRPC<int, int, object, bool>
	|-BaseEntity.ServerRPC<int, uint, byte[], bool>
	|-BaseEntity.ServerRPC<int, uint, object, bool>
	|
	|-RVA: 0x156C360 Offset: 0x156A960 VA: 0x18156C360
	|-BaseEntity.ServerRPC<int, int, int, int>
	|
	|-RVA: 0x156C580 Offset: 0x156AB80 VA: 0x18156C580
	|-BaseEntity.ServerRPC<int, int, int, float>
	|
	|-RVA: 0x156DEB0 Offset: 0x156C4B0 VA: 0x18156DEB0
	|-BaseEntity.ServerRPC<object, object, int, object>
	|-BaseEntity.ServerRPC<string, string, int, string>
	|
	|-RVA: 0x156E330 Offset: 0x156C930 VA: 0x18156E330
	|-BaseEntity.ServerRPC<object, object, object, object>
	|
	|-RVA: 0x156EEE0 Offset: 0x156D4E0 VA: 0x18156EEE0
	|-BaseEntity.ServerRPC<uint, byte, uint, uint>
	|
	|-RVA: 0x156FE00 Offset: 0x156E400 VA: 0x18156FE00
	|-BaseEntity.ServerRPC<uint, uint, sbyte, int>
	|
	|-RVA: 0x15706F0 Offset: 0x156ECF0 VA: 0x1815706F0
	|-BaseEntity.ServerRPC<ulong, uint, uint, byte[]>
	|-BaseEntity.ServerRPC<ulong, uint, uint, object>
	|
	|-RVA: 0x1570B30 Offset: 0x156F130 VA: 0x181570B30
	|-BaseEntity.ServerRPC<Vector3, Vector3, int, int>
	|
	|-RVA: 0x1571250 Offset: 0x156F850 VA: 0x181571250
	|-BaseEntity.ServerRPC<Vector3, Vector3, Vector3, int>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3>(string funcName, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156B810 Offset: 0x1569E10 VA: 0x18156B810
	|-BaseEntity.ServerRPC<bool, Vector3, uint>
	|
	|-RVA: 0x156CFD0 Offset: 0x156B5D0 VA: 0x18156CFD0
	|-BaseEntity.ServerRPC<int, byte[], int>
	|-BaseEntity.ServerRPC<int, object, int>
	|-BaseEntity.ServerRPC<uint, object, int>
	|
	|-RVA: 0x156C960 Offset: 0x156AF60 VA: 0x18156C960
	|-BaseEntity.ServerRPC<int, int, int>
	|-BaseEntity.ServerRPC<uint, int, int>
	|
	|-RVA: 0x156C9A0 Offset: 0x156AFA0 VA: 0x18156C9A0
	|-BaseEntity.ServerRPC<int, int, Ray>
	|
	|-RVA: 0x156E540 Offset: 0x156CB40 VA: 0x18156E540
	|-BaseEntity.ServerRPC<object, object, object>
	|
	|-RVA: 0x156F8A0 Offset: 0x156DEA0 VA: 0x18156F8A0
	|-BaseEntity.ServerRPC<uint, byte[], ulong>
	|-BaseEntity.ServerRPC<uint, object, object>
	|-BaseEntity.ServerRPC<uint, object, ulong>
	|
	|-RVA: 0x156F0F0 Offset: 0x156D6F0 VA: 0x18156F0F0
	|-BaseEntity.ServerRPC<uint, int, bool>
	|
	|-RVA: 0x15708C0 Offset: 0x156EEC0 VA: 0x1815708C0
	|-BaseEntity.ServerRPC<Vector3, Vector3, bool>
	|
	|-RVA: 0x1570DC0 Offset: 0x156F3C0 VA: 0x181570DC0
	|-BaseEntity.ServerRPC<Vector3, Vector3, float>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2>(string funcName, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156D1D0 Offset: 0x156B7D0 VA: 0x18156D1D0
	|-BaseEntity.ServerRPC<int, SprayList>
	|-BaseEntity.ServerRPC<int, byte[]>
	|-BaseEntity.ServerRPC<int, object>
	|-BaseEntity.ServerRPC<int, string>
	|-BaseEntity.ServerRPC<uint, byte[]>
	|-BaseEntity.ServerRPC<uint, object>
	|-BaseEntity.ServerRPC<uint, string>
	|
	|-RVA: 0x156CDF0 Offset: 0x156B3F0 VA: 0x18156CDF0
	|-BaseEntity.ServerRPC<int, int>
	|-BaseEntity.ServerRPC<uint, int>
	|
	|-RVA: 0x156DCA0 Offset: 0x156C2A0 VA: 0x18156DCA0
	|-BaseEntity.ServerRPC<object, bool>
	|-BaseEntity.ServerRPC<string, bool>
	|
	|-RVA: 0x156E720 Offset: 0x156CD20 VA: 0x18156E720
	|-BaseEntity.ServerRPC<object, object>
	|-BaseEntity.ServerRPC<string, string>
	|-BaseEntity.ServerRPC<ulong, object>
	|-BaseEntity.ServerRPC<ulong, string>
	|
	|-RVA: 0x1570340 Offset: 0x156E940 VA: 0x181570340
	|-BaseEntity.ServerRPC<ulong, int>
	|
	|-RVA: 0x156D730 Offset: 0x156BD30 VA: 0x18156D730
	|-BaseEntity.ServerRPC<Ray, int>
	|-BaseEntity.ServerRPC<Ray, uint>
	|
	|-RVA: 0x15712F0 Offset: 0x156F8F0 VA: 0x1815712F0
	|-BaseEntity.ServerRPC<Vector3, Vector3>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1>(string funcName, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156E760 Offset: 0x156CD60 VA: 0x18156E760
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
	|-RVA: 0x156BBD0 Offset: 0x156A1D0 VA: 0x18156BBD0
	|-BaseEntity.ServerRPC<bool>
	|
	|-RVA: 0x156D700 Offset: 0x156BD00 VA: 0x18156D700
	|-BaseEntity.ServerRPC<int>
	|-BaseEntity.ServerRPC<uint>
	|
	|-RVA: 0x156EA90 Offset: 0x156D090 VA: 0x18156EA90
	|-BaseEntity.ServerRPC<float>
	|
	|-RVA: 0x1571530 Offset: 0x156FB30 VA: 0x181571530
	|-BaseEntity.ServerRPC<Vector3>
	*/

	// RVA: 0x7E4B20 Offset: 0x7E3120 VA: 0x1807E4B20
	public void ServerRPC(string funcName) { }

	// RVA: 0x7E4640 Offset: 0x7E2C40 VA: 0x1807E4640
	private bool ServerRPCStart(string funcName) { }

	// RVA: -1 Offset: -1
	private void ServerRPCWrite<T>(T arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156B4E0 Offset: 0x1569AE0 VA: 0x18156B4E0
	|-BaseEntity.ServerRPCWrite<bool>
	|-BaseEntity.ServerRPCWrite<byte>
	|-BaseEntity.ServerRPCWrite<sbyte>
	|
	|-RVA: 0x156B5C0 Offset: 0x1569BC0 VA: 0x18156B5C0
	|-BaseEntity.ServerRPCWrite<int>
	|-BaseEntity.ServerRPCWrite<uint>
	|
	|-RVA: 0x156B6B0 Offset: 0x1569CB0 VA: 0x18156B6B0
	|-BaseEntity.ServerRPCWrite<object>
	|-BaseEntity.ServerRPCWrite<ulong>
	|
	|-RVA: 0x156B720 Offset: 0x1569D20 VA: 0x18156B720
	|-BaseEntity.ServerRPCWrite<float>
	|
	|-RVA: 0x156B550 Offset: 0x1569B50 VA: 0x18156B550
	|-BaseEntity.ServerRPCWrite<Color>
	|
	|-RVA: 0x156B630 Offset: 0x1569C30 VA: 0x18156B630
	|-BaseEntity.ServerRPCWrite<Ray>
	|
	|-RVA: 0x156B790 Offset: 0x1569D90 VA: 0x18156B790
	|-BaseEntity.ServerRPCWrite<Vector3>
	*/

	// RVA: 0x7E45D0 Offset: 0x7E2BD0 VA: 0x1807E45D0
	private void ServerRPCSend(SendInfo sendInfo) { }

	// RVA: -1 Offset: -1
	public void ServerRPCList<T1>(string funcName, List<T1> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156AE10 Offset: 0x1569410 VA: 0x18156AE10
	|-BaseEntity.ServerRPCList<object>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPCList<T1, T2, T3, T4, T5>(string funcName, List<T1> list, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156AA80 Offset: 0x1569080 VA: 0x18156AA80
	|-BaseEntity.ServerRPCList<object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPCList<T1, T2, T3, T4, T5, T6>(string funcName, List<T1> list, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156A6E0 Offset: 0x1568CE0 VA: 0x18156A6E0
	|-BaseEntity.ServerRPCList<object, object, object, object, object, object>
	|
	|-RVA: 0x156B130 Offset: 0x1569730 VA: 0x18156B130
	|-BaseEntity.ServerRPCList<Vector3, uint, int, uint, int, int>
	*/

	// RVA: 0x7DA750 Offset: 0x7D8D50 VA: 0x1807DA750
	public void CL_RPCMessage(uint nameID, ulong sourceConnection, Message message) { }

	// RVA: 0x7E4520 Offset: 0x7E2B20 VA: 0x1807E4520
	public void SendSignalBroadcast(BaseEntity.Signal signal, string arg = "") { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7E5230 Offset: 0x7E3830 VA: 0x1807E5230
	private void SignalFromServerEx(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7E52C0 Offset: 0x7E38C0 VA: 0x1807E52C0
	private void SignalFromServer(BaseEntity.RPCMessage msg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 83
	public virtual void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x7E31D0 Offset: 0x7E17D0 VA: 0x1807E31D0
	private void OnSkinChanged(ulong oldSkinID, ulong newSkinID) { }

	// RVA: 0x7E3540 Offset: 0x7E1B40 VA: 0x1807E3540
	private void OnSkinRefreshStart() { }

	// RVA: 0x7E3520 Offset: 0x7E1B20 VA: 0x1807E3520
	private void OnSkinRefreshEnd() { }

	// RVA: 0x7E39B0 Offset: 0x7E1FB0 VA: 0x1807E39B0 Slot: 84
	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x7DF6A0 Offset: 0x7DDCA0 VA: 0x1807DF6A0
	public bool HasAnySlot() { }

	// RVA: 0x7DF220 Offset: 0x7DD820 VA: 0x1807DF220
	public BaseEntity GetSlot(BaseEntity.Slot slot) { }

	// RVA: 0x7DF0E0 Offset: 0x7DD6E0 VA: 0x1807DF0E0
	public string GetSlotAnchorName(BaseEntity.Slot slot) { }

	// RVA: 0x7DF170 Offset: 0x7DD770 VA: 0x1807DF170
	public Transform GetSlotAnchor(BaseEntity.Slot slot) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 85
	public virtual bool HasSlot(BaseEntity.Slot slot) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 86
	public virtual BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x7DF930 Offset: 0x7DDF30 VA: 0x1807DF930
	public bool HasTrait(BaseEntity.TraitFlag f) { }

	// RVA: 0x7DF750 Offset: 0x7DDD50 VA: 0x1807DF750
	public bool HasAnyTrait(BaseEntity.TraitFlag f) { }

	// RVA: 0x7DC1A0 Offset: 0x7DA7A0 VA: 0x1807DC1A0 Slot: 87
	public virtual bool EnterTrigger(TriggerBase trigger) { }

	// RVA: 0x7E0EA0 Offset: 0x7DF4A0 VA: 0x1807E0EA0 Slot: 88
	public virtual void LeaveTrigger(TriggerBase trigger) { }

	// RVA: 0x7E3EF0 Offset: 0x7E24F0 VA: 0x1807E3EF0
	public void RemoveFromTriggers() { }

	// RVA: -1 Offset: -1
	public T FindTrigger<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA1B0 Offset: 0x5C87B0 VA: 0x1805CA1B0
	|-BaseEntity.FindTrigger<object>
	|-BaseEntity.FindTrigger<TriggerLadder>
	|-BaseEntity.FindTrigger<TriggerNoSpray>
	*/

	// RVA: -1 Offset: -1
	public bool FindTrigger<T>(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CAB0 Offset: 0x125B0B0 VA: 0x18125CAB0
	|-BaseEntity.FindTrigger<object>
	*/

	// RVA: 0x7DCA50 Offset: 0x7DB050 VA: 0x1807DCA50
	private void ForceUpdateTriggersAction() { }

	// RVA: 0x7DCA80 Offset: 0x7DB080 VA: 0x1807DCA80
	public void ForceUpdateTriggers(bool enter = True, bool exit = True, bool invoke = True) { }

	// RVA: 0x7E1E70 Offset: 0x7E0470 VA: 0x1807E1E70 Slot: 89
	public virtual void MakeVisible() { }

	// RVA: 0x7E5B50 Offset: 0x7E4150 VA: 0x1807E5B50 Slot: 90
	protected virtual void UpdateCullingSpheres() { }

	// RVA: 0x7E3C60 Offset: 0x7E2260 VA: 0x1807E3C60 Slot: 91
	protected virtual void RegisterForCulling() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 92
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x7E58E0 Offset: 0x7E3EE0 VA: 0x1807E58E0 Slot: 93
	protected virtual void UnregisterFromCulling() { }

	// RVA: 0x7E5A80 Offset: 0x7E4080 VA: 0x1807E5A80 Slot: 94
	protected virtual void UpdateCullingBounds() { }

	// RVA: 0x7DAD10 Offset: 0x7D9310 VA: 0x1807DAD10 Slot: 95
	protected virtual bool CheckVisibility() { }

	// RVA: 0x7DABF0 Offset: 0x7D91F0 VA: 0x1807DABF0
	protected float CalcEntityVisUpdateRate() { }

	// RVA: 0x7DB240 Offset: 0x7D9840 VA: 0x1807DB240 Slot: 96
	protected virtual void DebugDrawCullingBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7E6EC0 Offset: 0x7E54C0 VA: 0x1807E6EC0
	public float get_Weight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7E6EE0 Offset: 0x7E54E0 VA: 0x1807E6EE0
	protected void set_Weight(float value) { }

	// RVA: 0x7E6E40 Offset: 0x7E5440 VA: 0x1807E6E40
	public EntityComponentBase[] get_Components() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 97
	public virtual BasePlayer ToPlayer() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 98
	public virtual bool get_IsNpc() { }

	// RVA: 0x7D40D0 Offset: 0x7D26D0 VA: 0x1807D40D0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x7D6FF0 Offset: 0x7D55F0 VA: 0x1807D6FF0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x7E44B0 Offset: 0x7E2AB0 VA: 0x1807E44B0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 99
	public virtual float InheritedVelocityScale() { }

	// RVA: 0x7DDE60 Offset: 0x7DC460 VA: 0x1807DDE60 Slot: 100
	public virtual Vector3 GetInheritedProjectileVelocity() { }

	// RVA: 0x7DDFE0 Offset: 0x7DC5E0 VA: 0x1807DDFE0 Slot: 101
	public virtual Vector3 GetInheritedThrowVelocity() { }

	// RVA: 0x7DDD80 Offset: 0x7DC380 VA: 0x1807DDD80 Slot: 102
	public virtual Vector3 GetInheritedDropVelocity() { }

	// RVA: 0x7DEE20 Offset: 0x7DD420 VA: 0x1807DEE20
	public Vector3 GetParentVelocity() { }

	// RVA: 0x7DF280 Offset: 0x7DD880 VA: 0x1807DF280
	public Vector3 GetWorldVelocity() { }

	// RVA: 0x7DE4A0 Offset: 0x7DCAA0 VA: 0x1807DE4A0
	public Vector3 GetLocalVelocity() { }

	// RVA: 0x7DD640 Offset: 0x7DBC40 VA: 0x1807DD640
	public Quaternion GetAngularVelocity() { }

	// RVA: 0x7E6B70 Offset: 0x7E5170 VA: 0x1807E6B70 Slot: 103
	public virtual OBB WorldSpaceBounds() { }

	// RVA: 0x2FA9E0 Offset: 0x2F8FE0 VA: 0x1802FA9E0
	public Vector3 PivotPoint() { }

	// RVA: 0x7DACD0 Offset: 0x7D92D0 VA: 0x1807DACD0
	public Vector3 CenterPoint() { }

	// RVA: 0x7DAF30 Offset: 0x7D9530 VA: 0x1807DAF30
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x7DACD0 Offset: 0x7D92D0 VA: 0x1807DACD0 Slot: 104
	public virtual Vector3 TriggerPoint() { }

	// RVA: 0x7DB6A0 Offset: 0x7D9CA0 VA: 0x1807DB6A0 Slot: 105
	public float Distance(Vector3 position) { }

	// RVA: 0x7E54E0 Offset: 0x7E3AE0 VA: 0x1807E54E0
	public float SqrDistance(Vector3 position) { }

	// RVA: 0x7DB640 Offset: 0x7D9C40 VA: 0x1807DB640
	public float Distance(BaseEntity other) { }

	// RVA: 0x7E5480 Offset: 0x7E3A80 VA: 0x1807E5480
	public float SqrDistance(BaseEntity other) { }

	// RVA: 0x7DB500 Offset: 0x7D9B00 VA: 0x1807DB500
	public float Distance2D(Vector3 position) { }

	// RVA: 0x7E5340 Offset: 0x7E3940 VA: 0x1807E5340
	public float SqrDistance2D(Vector3 position) { }

	// RVA: 0x7DB640 Offset: 0x7D9C40 VA: 0x1807DB640
	public float Distance2D(BaseEntity other) { }

	// RVA: 0x7E5480 Offset: 0x7E3A80 VA: 0x1807E5480
	public float SqrDistance2D(BaseEntity other) { }

	// RVA: 0x7E0AE0 Offset: 0x7DF0E0 VA: 0x1807E0AE0
	public bool IsVisible(Ray ray, int layerMask, float maxDistance) { }

	// RVA: 0x7E0490 Offset: 0x7DEA90 VA: 0x1807E0490
	public bool IsVisibleSpecificLayers(Vector3 position, Vector3 target, int layerMask, float maxDistance = ∞) { }

	// RVA: 0x7E0700 Offset: 0x7DED00 VA: 0x1807E0700
	public bool IsVisible(Vector3 position, Vector3 target, float maxDistance = ∞) { }

	// RVA: 0x7E0980 Offset: 0x7DEF80 VA: 0x1807E0980
	public bool IsVisible(Vector3 position, float maxDistance = ∞) { }

	// RVA: 0x7E0280 Offset: 0x7DE880 VA: 0x1807E0280
	public bool IsVisibleAndCanSee(Vector3 position, float maxDistance = ∞) { }

	// RVA: 0x7DFEC0 Offset: 0x7DE4C0 VA: 0x1807DFEC0
	public bool IsOlderThan(BaseEntity other) { }

	// RVA: 0x7DFF90 Offset: 0x7DE590 VA: 0x1807DFF90 Slot: 106
	public virtual bool IsOutside() { }

	// RVA: 0x7DFFF0 Offset: 0x7DE5F0 VA: 0x1807DFFF0
	public bool IsOutside(Vector3 position) { }

	// RVA: 0x7E66E0 Offset: 0x7E4CE0 VA: 0x1807E66E0 Slot: 107
	public virtual float WaterFactor() { }

	// RVA: 0x7DA4A0 Offset: 0x7D8AA0 VA: 0x1807DA4A0 Slot: 108
	public virtual float AirFactor() { }

	// RVA: 0x7E68B0 Offset: 0x7E4EB0 VA: 0x1807E68B0
	public bool WaterTestFromVolumes(Vector3 pos, out WaterLevel.WaterInfo info) { }

	// RVA: 0x7DFB70 Offset: 0x7DE170 VA: 0x1807DFB70
	public bool IsInWaterVolume(Vector3 pos) { }

	// RVA: 0x7E6780 Offset: 0x7E4D80 VA: 0x1807E6780
	public bool WaterTestFromVolumes(Bounds bounds, out WaterLevel.WaterInfo info) { }

	// RVA: 0x7E69E0 Offset: 0x7E4FE0 VA: 0x1807E69E0
	public bool WaterTestFromVolumes(Vector3 start, Vector3 end, float radius, out WaterLevel.WaterInfo info) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 109
	public virtual bool BlocksWaterFor(BasePlayer player) { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 110
	public virtual float Health() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 111
	public virtual float MaxHealth() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 112
	public virtual float MaxVelocity() { }

	// RVA: 0x7DA4E0 Offset: 0x7D8AE0 VA: 0x1807DA4E0 Slot: 113
	public virtual float BoundsPadding() { }

	// RVA: 0x723230 Offset: 0x721830 VA: 0x180723230 Slot: 114
	public virtual float PenetrationResistance(HitInfo info) { }

	// RVA: 0x7DDD70 Offset: 0x7DC370 VA: 0x1807DDD70 Slot: 115
	public virtual GameObjectRef GetImpactEffect(HitInfo info) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 116
	public virtual void OnAttacked(HitInfo info) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 117
	public virtual Item GetItem() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 118
	public virtual Item GetItem(uint itemId) { }

	// RVA: 0x7DF670 Offset: 0x7DDC70 VA: 0x1807DF670 Slot: 119
	public virtual void GiveItem(Item item, BaseEntity.GiveItemReason reason = 0) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 120
	public virtual bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 121
	public virtual BaseEntity GetEntity() { }

	// RVA: 0x7E57F0 Offset: 0x7E3DF0 VA: 0x1807E57F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x7DACA0 Offset: 0x7D92A0 VA: 0x1807DACA0 Slot: 122
	public virtual string Categorize() { }

	// RVA: 0x7E19C0 Offset: 0x7DFFC0 VA: 0x1807E19C0
	public void Log(string str) { }

	// RVA: 0x7E4C50 Offset: 0x7E3250 VA: 0x1807E4C50
	public void SetModel(Model mdl) { }

	// RVA: 0x701920 Offset: 0x6FFF20 VA: 0x180701920
	public Model GetModel() { }

	// RVA: 0x7DD6E0 Offset: 0x7DBCE0 VA: 0x1807DD6E0 Slot: 123
	public virtual Transform[] GetBones() { }

	// RVA: 0x7DC600 Offset: 0x7DAC00 VA: 0x1807DC600 Slot: 124
	public virtual Transform FindBone(string strName) { }

	// RVA: 0x7DC520 Offset: 0x7DAB20 VA: 0x1807DC520 Slot: 125
	public virtual uint FindBoneID(Transform boneTransform) { }

	// RVA: 0x7DC6B0 Offset: 0x7DACB0 VA: 0x1807DC6B0 Slot: 126
	public virtual Transform FindClosestBone(Vector3 worldPos) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7E6EB0 Offset: 0x7E54B0 VA: 0x1807E6EB0
	public ulong get_OwnerID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7E6ED0 Offset: 0x7E54D0 VA: 0x1807E6ED0
	public void set_OwnerID(ulong value) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 127
	public virtual bool ShouldBlockProjectiles() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 128
	public virtual bool ShouldInheritNetworkGroup() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 129
	public virtual bool SupportsChildDeployables() { }

	// RVA: 0x7DA4F0 Offset: 0x7D8AF0 VA: 0x1807DA4F0
	public void BroadcastEntityMessage(string msg, float radius = 20, int layerMask = 1218652417) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 130
	public virtual void OnEntityMessage(BaseEntity from, string msg) { }

	// RVA: 0x7E14C0 Offset: 0x7DFAC0 VA: 0x1807E14C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7E6D30 Offset: 0x7E5330 VA: 0x1807E6D30
	public void .ctor() { }

	// RVA: 0x7E6CB0 Offset: 0x7E52B0 VA: 0x1807E6CB0
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

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

	// RVA: 0x7ED390 Offset: 0x7EB990 VA: 0x1807ED390
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

	// RVA: 0xF85C0 Offset: 0xF79C0 VA: 0x1800F85C0
	public void CopyTo(ref Option option) { }

}

public class BaseEntity.Menu.Description : Attribute // TypeDefIndex: 8495
{	// Fields
	public string token; // 0x10
	public string english; // 0x18

	// Methods

	// RVA: 0x7ED390 Offset: 0x7EB990 VA: 0x1807ED390
	public void .ctor(string t, string e) { }

}

public class BaseEntity.Menu.Icon : Attribute // TypeDefIndex: 8496
{	// Fields
	public string icon; // 0x10

	// Methods

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string i) { }

}

public class BaseEntity.Menu.ShowIf : Attribute // TypeDefIndex: 8497
{	// Fields
	public string functionName; // 0x10

	// Methods

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string testFunc) { }

}

public class BaseEntity.Menu.UsableWhileWounded : Attribute // TypeDefIndex: 8498
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
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

	// RVA: 0xF8810 Offset: 0xF7C10 VA: 0x1800F8810
	public void .ctor(FileStorage.Type type, uint numId, uint crc, IServerFileReceiver receiver) { }

	// RVA: 0xF8760 Offset: 0xF7B60 VA: 0x1800F8760 Slot: 4
	public bool Equals(BaseEntity.ServerFileRequest other) { }

	// RVA: 0xF86B0 Offset: 0xF7AB0 VA: 0x1800F86B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF87B0 Offset: 0xF7BB0 VA: 0x1800F87B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7EDF40 Offset: 0x7EC540 VA: 0x1807EDF40
	public static bool op_Equality(BaseEntity.ServerFileRequest left, BaseEntity.ServerFileRequest right) { }

	// RVA: 0x7EDFF0 Offset: 0x7EC5F0 VA: 0x1807EDFF0
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

	// RVA: 0x7EDD00 Offset: 0x7EC300 VA: 0x1807EDD00
	public void .ctor(float worldSize) { }

	// RVA: 0x7ED520 Offset: 0x7EBB20 VA: 0x1807ED520
	public void Add(BaseEntity ent) { }

	// RVA: 0x7ED480 Offset: 0x7EBA80 VA: 0x1807ED480
	public void AddPlayer(BasePlayer player) { }

	// RVA: 0x7ED3E0 Offset: 0x7EB9E0 VA: 0x1807ED3E0
	public void AddBrain(BaseEntity entity) { }

	// RVA: 0x7EDC00 Offset: 0x7EC200 VA: 0x1807EDC00
	public void Remove(BaseEntity ent, bool isPlayer = False) { }

	// RVA: 0x7EDBA0 Offset: 0x7EC1A0 VA: 0x1807EDBA0
	public void RemovePlayer(BasePlayer player) { }

	// RVA: 0x7EDB10 Offset: 0x7EC110 VA: 0x1807EDB10
	public void RemoveBrain(BaseEntity entity) { }

	// RVA: 0x7ED8E0 Offset: 0x7EBEE0 VA: 0x1807ED8E0
	public void Move(BaseEntity ent) { }

	// RVA: 0x7ED840 Offset: 0x7EBE40 VA: 0x1807ED840
	public void MovePlayer(BasePlayer player) { }

	// RVA: 0x7ED7A0 Offset: 0x7EBDA0 VA: 0x1807ED7A0
	public void MoveBrain(BaseEntity entity) { }

	// RVA: 0x7ED660 Offset: 0x7EBC60 VA: 0x1807ED660
	public int GetInSphere(Vector3 position, float distance, BaseEntity[] results, Func<BaseEntity, bool> filter) { }

	// RVA: 0x7ED700 Offset: 0x7EBD00 VA: 0x1807ED700
	public int GetPlayersInSphere(Vector3 position, float distance, BasePlayer[] results, Func<BasePlayer, bool> filter) { }

	// RVA: 0x7ED5C0 Offset: 0x7EBBC0 VA: 0x1807ED5C0
	public int GetBrainsInSphere(Vector3 position, float distance, BaseEntity[] results, Func<BaseEntity, bool> filter) { }

}

public class BaseEntity.RPC_Shared : Attribute // TypeDefIndex: 8504
{	// Methods

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
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

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
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

	// RVA: 0x7EE0E0 Offset: 0x7EC6E0 VA: 0x1807EE0E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7EE040 Offset: 0x7EC640 VA: 0x1807EE040
	internal int <GetMenuItems>b__35_0(Option x, Option y) { }

	// RVA: 0x7EE070 Offset: 0x7EC670 VA: 0x1807EE070
	internal bool <RequestFileFromServer>b__93_0(BaseEntity.ServerFileRequest r) { }

}

