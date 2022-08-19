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

	// RVA: 0x1FFE550 Offset: 0x1FFCB50 VA: 0x181FFE550
	public static void ResetToPool(BaseEntity instance) { }

	// RVA: 0x1FFE610 Offset: 0x1FFCC10 VA: 0x181FFE610
	public void ResetToPool() { }

	// RVA: 0x1FFE1A0 Offset: 0x1FFC7A0 VA: 0x181FFE1A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1FFCE80 Offset: 0x1FFB480 VA: 0x181FFCE80
	public void CopyTo(BaseEntity instance) { }

	// RVA: 0x1FFCED0 Offset: 0x1FFB4D0 VA: 0x181FFCED0
	public BaseEntity Copy() { }

	// RVA: 0x1FFDBF0 Offset: 0x1FFC1F0 VA: 0x181FFDBF0
	public static BaseEntity Deserialize(Stream stream) { }

	// RVA: 0x1FFCF70 Offset: 0x1FFB570 VA: 0x181FFCF70
	public static BaseEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FFD310 Offset: 0x1FFB910 VA: 0x181FFD310
	public static BaseEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FFDE70 Offset: 0x1FFC470 VA: 0x181FFDE70
	public static BaseEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1FFE2E0 Offset: 0x1FFC8E0 VA: 0x181FFE2E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FFEFF0 Offset: 0x1FFD5F0 VA: 0x181FFEFF0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FFF010 Offset: 0x1FFD610 VA: 0x181FFF010 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseEntity previous) { }

	// RVA: 0x1FFE530 Offset: 0x1FFCB30 VA: 0x181FFE530 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FFD8E0 Offset: 0x1FFBEE0 VA: 0x181FFD8E0
	public static BaseEntity Deserialize(byte[] buffer, BaseEntity instance, bool isDelta = False) { }

	// RVA: 0x1FFD690 Offset: 0x1FFBC90 VA: 0x181FFD690
	public static BaseEntity Deserialize(Stream stream, BaseEntity instance, bool isDelta) { }

	// RVA: 0x1FFCFF0 Offset: 0x1FFB5F0 VA: 0x181FFCFF0
	public static BaseEntity DeserializeLengthDelimited(Stream stream, BaseEntity instance, bool isDelta) { }

	// RVA: 0x1FFD3A0 Offset: 0x1FFB9A0 VA: 0x181FFD3A0
	public static BaseEntity DeserializeLength(Stream stream, int length, BaseEntity instance, bool isDelta) { }

	// RVA: 0x1FFE6D0 Offset: 0x1FFCCD0 VA: 0x181FFE6D0
	public static void SerializeDelta(Stream stream, BaseEntity instance, BaseEntity previous) { }

	// RVA: 0x1FFED30 Offset: 0x1FFD330 VA: 0x181FFED30
	public static void Serialize(Stream stream, BaseEntity instance) { }

	// RVA: 0x1FFEFE0 Offset: 0x1FFD5E0 VA: 0x181FFEFE0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FFEFF0 Offset: 0x1FFD5F0 VA: 0x181FFEFF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1FFEC20 Offset: 0x1FFD220 VA: 0x181FFEC20
	public static byte[] SerializeToBytes(BaseEntity instance) { }

	// RVA: 0x1FFEB70 Offset: 0x1FFD170 VA: 0x181FFEB70
	public static void SerializeLengthDelimited(Stream stream, BaseEntity instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float <Weight>k__BackingField; // 0x100
	[HeaderAttribute] // RVA: 0x9F380 Offset: 0x9E780 VA: 0x18009F380
	public Bounds bounds; // 0x104
	public GameObjectRef impactEffect; // 0x120
	public bool enableSaving; // 0x128
	public bool syncPosition; // 0x129
	public Model model; // 0x130
	[InspectorFlagsAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public BaseEntity.Flags flags; // 0x138
	public uint parentBone; // 0x13C
	public ulong skinID; // 0x140
	private EntityComponentBase[] _components; // 0x148
	[HideInInspector] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public bool HasBrain; // 0x150
	protected string _name; // 0x158
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

	// RVA: 0x7E24C0 Offset: 0x7E0AC0 VA: 0x1807E24C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7DDA00 Offset: 0x7DC000 VA: 0x1807DDA00
	public void GetEntityMenu(BasePlayer player, List<Option> optionList) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 49
	public virtual void GetMenuOptions(List<Option> list) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 50
	public virtual bool get_HasMenuOptions() { }

	// RVA: 0x7DE0B0 Offset: 0x7DC6B0 VA: 0x1807DE0B0 Slot: 51
	public virtual void GetItemOptions(List<Option> options) { }

	// RVA: 0x7DEB00 Offset: 0x7DD100 VA: 0x1807DEB00
	public BaseEntity.MovementModify GetMovementModify() { }

	// RVA: 0x7DDB40 Offset: 0x7DC140 VA: 0x1807DDB40 Slot: 52
	public virtual float GetExtrapolationTime() { }

	// RVA: 0x7DDF00 Offset: 0x7DC500 VA: 0x1807DDF00 Slot: 53
	public virtual float GetInterpolationDelay() { }

	// RVA: 0x7DDF90 Offset: 0x7DC590 VA: 0x1807DDF90 Slot: 54
	public virtual float GetInterpolationInertia() { }

	// RVA: 0x7DE020 Offset: 0x7DC620 VA: 0x1807DE020 Slot: 55
	public virtual float GetInterpolationSmoothing() { }

	// RVA: 0x7DD4A0 Offset: 0x7DBAA0 VA: 0x1807DD4A0 Slot: 56
	public virtual Quaternion GetAngularVelocityClient() { }

	// RVA: 0x7DE300 Offset: 0x7DC900 VA: 0x1807DE300 Slot: 57
	public virtual Vector3 GetLocalVelocityClient() { }

	// RVA: 0x7DB9A0 Offset: 0x7D9FA0 VA: 0x1807DB9A0 Slot: 43
	public void DrawInterpolationState(Interpolator.Segment<TransformSnapshot> segment, List<TransformSnapshot> entries) { }

	// RVA: 0x7E0E30 Offset: 0x7DF430 VA: 0x1807E0E30 Slot: 44
	public void LerpIdleDisable() { }

	// RVA: 0x7DAC20 Offset: 0x7D9220 VA: 0x1807DAC20 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7DACD0 Offset: 0x7D92D0 VA: 0x1807DACD0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x7E2150 Offset: 0x7E0750 VA: 0x1807E2150
	public void OnPositionalFromNetwork(Vector3 vPos, Vector3 vAng, float time) { }

	// RVA: 0x7E5510 Offset: 0x7E3B10 VA: 0x1807E5510
	public void StartLerping(float time) { }

	// RVA: 0x7E5690 Offset: 0x7E3C90 VA: 0x1807E5690
	public void StopLerping() { }

	// RVA: 0x7E5100 Offset: 0x7E3700 VA: 0x1807E5100 Slot: 58
	public virtual bool ShouldLerp() { }

	// RVA: 0x7E4BF0 Offset: 0x7E31F0 VA: 0x1807E4BF0 Slot: 59
	public virtual void SetNetworkPosition(Vector3 vPos) { }

	// RVA: 0x7E4D60 Offset: 0x7E3360 VA: 0x1807E4D60 Slot: 60
	public virtual void SetNetworkRotation(Quaternion qRot) { }

	// RVA: 0x7DB980 Offset: 0x7D9F80 VA: 0x1807DB980 Slot: 61
	public virtual void DoDestroyEffects(BaseNetworkable.DestroyMode mode, Message msg) { }

	// RVA: 0x7E5200 Offset: 0x7E3800 VA: 0x1807E5200 Slot: 62
	protected virtual void SpawnGibs() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0 Slot: 20
	internal override void DoNetworkDestroy() { }

	// RVA: 0x7E3880 Offset: 0x7E1E80 VA: 0x1807E3880 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x7E1E90 Offset: 0x7E0490 VA: 0x1807E1E90 Slot: 63
	public virtual void OnBecameRagdoll(Ragdoll rdoll) { }

	// RVA: 0x7DE480 Offset: 0x7DCA80 VA: 0x1807DE480 Slot: 64
	public virtual Info GetMenuInformation(GameObject primaryObject, BasePlayer player) { }

	// RVA: 0x7DF850 Offset: 0x7DDE50 VA: 0x1807DF850 Slot: 65
	protected virtual bool HideMenuItems(BasePlayer player) { }

	// RVA: 0x7DE770 Offset: 0x7DCD70 VA: 0x1807DE770 Slot: 66
	public virtual List<Option> GetMenuItems(BasePlayer player) { }

	// RVA: 0x7E3670 Offset: 0x7E1C70 VA: 0x1807E3670 Slot: 67
	public virtual void OnUse(BasePlayer player) { }

	// RVA: 0x7E3450 Offset: 0x7E1A50 VA: 0x1807E3450 Slot: 68
	public virtual void OnUseHeld(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 69
	public virtual void OnUseStopped(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 70
	public virtual void OnRendered() { }

	// RVA: 0x7DB6D0 Offset: 0x7D9CD0 VA: 0x1807DB6D0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x7DDBD0 Offset: 0x7DC1D0 VA: 0x1807DDBD0 Slot: 71
	internal virtual Transform GetEyeTransform() { }

	// RVA: 0x7E1D80 Offset: 0x7E0380 VA: 0x1807E1D80 Slot: 72
	public virtual bool NeedsCrosshair() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 73
	public virtual bool AlwaysShowCrosshair() { }

	// RVA: 0x7E5050 Offset: 0x7E3650 VA: 0x1807E5050 Slot: 17
	public override bool ShouldDestroyWithGroup() { }

	// RVA: 0x7DB2C0 Offset: 0x7D98C0 VA: 0x1807DB2C0
	public void DetachEffects() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 74
	public virtual void OnVoiceData(byte[] data) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 75
	public virtual void LookingAtTick() { }

	// RVA: 0x723120 Offset: 0x721720 VA: 0x180723120 Slot: 76
	public virtual float get_RealisticMass() { }

	// RVA: 0x7E1F40 Offset: 0x7E0540 VA: 0x1807E1F40 Slot: 77
	public virtual void OnCollision(Collision collision, BaseEntity hitEntity) { }

	// RVA: 0x7E3970 Offset: 0x7E1F70 VA: 0x1807E3970
	protected void ReceiveCollisionMessages(bool b) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 78
	public virtual void DebugClient(int rep, float time) { }

	// RVA: 0x7E1F90 Offset: 0x7E0590 VA: 0x1807E1F90
	public void OnDebugStart() { }

	// RVA: 0x7DB200 Offset: 0x7D9800 VA: 0x1807DB200
	protected void DebugText(Vector3 pos, string str, Color color, float time) { }

	// RVA: 0x7DF810 Offset: 0x7DDE10 VA: 0x1807DF810 Slot: 79
	public bool HasFlag(BaseEntity.Flags f) { }

	// RVA: 0x7E37E0 Offset: 0x7E1DE0 VA: 0x1807E37E0
	public bool ParentHasFlag(BaseEntity.Flags f) { }

	// RVA: 0x7E4A20 Offset: 0x7E3020 VA: 0x1807E4A20
	public void SetFlag(BaseEntity.Flags f, bool b, bool recursive = False, bool networkupdate = True) { }

	// RVA: 0x7DFE60 Offset: 0x7DE460 VA: 0x1807DFE60
	public bool IsOn() { }

	// RVA: 0x7DFE70 Offset: 0x7DE470 VA: 0x1807DFE70
	public bool IsOpen() { }

	// RVA: 0x7DFE50 Offset: 0x7DE450 VA: 0x1807DFE50
	public bool IsOnFire() { }

	// RVA: 0x7DFBA0 Offset: 0x7DE1A0 VA: 0x1807DFBA0
	public bool IsLocked() { }

	// RVA: 0x7DF9B0 Offset: 0x7DDFB0 VA: 0x1807DF9B0 Slot: 4
	public override bool IsDebugging() { }

	// RVA: 0x7DF9C0 Offset: 0x7DDFC0 VA: 0x1807DF9C0
	public bool IsDisabled() { }

	// RVA: 0x7DF9A0 Offset: 0x7DDFA0 VA: 0x1807DF9A0
	public bool IsBroken() { }

	// RVA: 0x7DF850 Offset: 0x7DDE50 VA: 0x1807DF850
	public bool IsBusy() { }

	// RVA: 0x7DE430 Offset: 0x7DCA30 VA: 0x1807DE430 Slot: 5
	public override string GetLogColor() { }

	// RVA: 0x7E2050 Offset: 0x7E0650 VA: 0x1807E2050 Slot: 80
	public virtual void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x7DFCA0 Offset: 0x7DE2A0 VA: 0x1807DFCA0
	public bool IsOccupied(Socket_Base socket) { }

	// RVA: 0x7DFBB0 Offset: 0x7DE1B0 VA: 0x1807DFBB0
	public bool IsOccupied(string socketName) { }

	// RVA: 0x7DC660 Offset: 0x7DAC60 VA: 0x1807DC660
	public EntityLink FindLink(Socket_Base socket) { }

	// RVA: 0x7DC760 Offset: 0x7DAD60 VA: 0x1807DC760
	public EntityLink FindLink(string socketName) { }

	// RVA: 0x7DC840 Offset: 0x7DAE40 VA: 0x1807DC840
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
	|-RVA: 0x156A240 Offset: 0x1568840 VA: 0x18156A240
	|-BaseEntity.EntityLinkMessage<object>
	*/

	// RVA: -1 Offset: -1
	public void EntityLinkBroadcast<T, S>(Action<T> action, Func<S, bool> canTraverseSocket) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15698E0 Offset: 0x1567EE0 VA: 0x1815698E0
	|-BaseEntity.EntityLinkBroadcast<object, object>
	*/

	// RVA: -1 Offset: -1
	public void EntityLinkBroadcast<T>(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1569E00 Offset: 0x1568400 VA: 0x181569E00
	|-BaseEntity.EntityLinkBroadcast<object>
	*/

	// RVA: 0x7DC140 Offset: 0x7DA740 VA: 0x1807DC140
	public void EntityLinkBroadcast() { }

	// RVA: 0x7E3A00 Offset: 0x7E2000 VA: 0x1807E3A00
	public bool ReceivedEntityLinkBroadcast() { }

	// RVA: 0x7DD9C0 Offset: 0x7DBFC0 VA: 0x1807DD9C0
	public List<EntityLink> GetEntityLinks(bool linkToNeighbours = True) { }

	// RVA: 0x7E0E60 Offset: 0x7DF460 VA: 0x1807E0E60
	private void LinkToEntity(BaseEntity other) { }

	// RVA: 0x7E10C0 Offset: 0x7DF6C0 VA: 0x1807E10C0
	private void LinkToNeighbours() { }

	// RVA: 0x7DF860 Offset: 0x7DDE60 VA: 0x1807DF860
	private void InitEntityLinks() { }

	// RVA: 0x7DD3C0 Offset: 0x7DB9C0 VA: 0x1807DD3C0
	private void FreeEntityLinks() { }

	// RVA: 0x7E3A70 Offset: 0x7E2070 VA: 0x1807E3A70
	public void RefreshEntityLinks() { }

	[ObsoleteAttribute] // RVA: 0x9F750 Offset: 0x9EB50 VA: 0x18009F750
	// RVA: 0x7E42F0 Offset: 0x7E28F0 VA: 0x1807E42F0
	public void RequestFileFromServer(uint crc, FileStorage.Type type, string responseFunction, uint part = 0) { }

	// RVA: 0x7E3FB0 Offset: 0x7E25B0 VA: 0x1807E3FB0
	public void RequestFileFromServer(IServerFileReceiver receiver, FileStorage.Type type, uint crc, uint part = 0, bool respondIfNotFound = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7DA930 Offset: 0x7D8F30 VA: 0x1807DA930
	public void CL_ReceiveFileRequest(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7DAED0 Offset: 0x7D94D0 VA: 0x1807DAED0
	private void CompletePendingFileRequests(FileStorage.Type type, uint crc, uint part, byte[] data) { }

	// RVA: 0x7E5850 Offset: 0x7E3E50 VA: 0x1807E5850
	public void UpdateChildren() { }

	// RVA: 0x7E65C0 Offset: 0x7E4BC0 VA: 0x1807E65C0
	public void UpdateParenting() { }

	// RVA: 0x7E5F40 Offset: 0x7E4540 VA: 0x1807E5F40
	public void UpdateParenting(bool worldPositionStays) { }

	// RVA: 0x7E4E30 Offset: 0x7E3430 VA: 0x1807E4E30
	private void SetParentTransform(Transform parent, bool worldPositionStays = True) { }

	// RVA: 0x7E5BC0 Offset: 0x7E41C0 VA: 0x1807E5BC0
	protected void UpdateDisableState() { }

	// RVA: 0x7DF670 Offset: 0x7DDC70 VA: 0x1807DF670
	private bool HasClientTransformOffset() { }

	// RVA: 0x7E3D80 Offset: 0x7E2380 VA: 0x1807E3D80
	private void RemoveClientTransformOffset() { }

	// RVA: 0x7DA2F0 Offset: 0x7D88F0 VA: 0x1807DA2F0
	private void AddClientTransformOffset() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 81
	public virtual void OnParentChangingClient(Transform oldParent, Transform newParent) { }

	// RVA: 0x7DD950 Offset: 0x7DBF50 VA: 0x1807DD950 Slot: 82
	public virtual BuildingPrivlidge GetBuildingPrivilege() { }

	// RVA: 0x7DD660 Offset: 0x7DBC60 VA: 0x1807DD660
	public BuildingPrivlidge GetBuildingPrivilege(OBB obb) { }

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3, T4, T5>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156B9A0 Offset: 0x1569FA0 VA: 0x18156B9A0
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, object>
	|
	|-RVA: 0x156BEB0 Offset: 0x156A4B0 VA: 0x18156BEB0
	|-BaseEntity.ServerRPC<int, int, int, int, byte>
	|
	|-RVA: 0x156BC30 Offset: 0x156A230 VA: 0x18156BC30
	|-BaseEntity.ServerRPC<int, Color, Color, Color, Color>
	|
	|-RVA: 0x156DC40 Offset: 0x156C240 VA: 0x18156DC40
	|-BaseEntity.ServerRPC<object, object, object, object, object>
	|
	|-RVA: 0x156E860 Offset: 0x156CE60 VA: 0x18156E860
	|-BaseEntity.ServerRPC<uint, byte, uint, uint, bool>
	|
	|-RVA: 0x156F090 Offset: 0x156D690 VA: 0x18156F090
	|-BaseEntity.ServerRPC<uint, int, uint, int, int>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3, T4>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156C0F0 Offset: 0x156A6F0 VA: 0x18156C0F0
	|-BaseEntity.ServerRPC<int, int, int, int>
	|
	|-RVA: 0x156C310 Offset: 0x156A910 VA: 0x18156C310
	|-BaseEntity.ServerRPC<int, int, int, float>
	|
	|-RVA: 0x156C910 Offset: 0x156AF10 VA: 0x18156C910
	|-BaseEntity.ServerRPC<int, int, object, bool>
	|
	|-RVA: 0x156D0F0 Offset: 0x156B6F0 VA: 0x18156D0F0
	|-BaseEntity.ServerRPC<int, uint, object, bool>
	|
	|-RVA: 0x156DA20 Offset: 0x156C020 VA: 0x18156DA20
	|-BaseEntity.ServerRPC<object, object, int, object>
	|
	|-RVA: 0x156DE90 Offset: 0x156C490 VA: 0x18156DE90
	|-BaseEntity.ServerRPC<object, object, object, object>
	|
	|-RVA: 0x156EA50 Offset: 0x156D050 VA: 0x18156EA50
	|-BaseEntity.ServerRPC<uint, byte, uint, uint>
	|
	|-RVA: 0x156FB90 Offset: 0x156E190 VA: 0x18156FB90
	|-BaseEntity.ServerRPC<uint, uint, sbyte, int>
	|
	|-RVA: 0x1570260 Offset: 0x156E860 VA: 0x181570260
	|-BaseEntity.ServerRPC<ulong, uint, uint, object>
	|
	|-RVA: 0x1570900 Offset: 0x156EF00 VA: 0x181570900
	|-BaseEntity.ServerRPC<Vector3, Vector3, int, int>
	|
	|-RVA: 0x1570D70 Offset: 0x156F370 VA: 0x181570D70
	|-BaseEntity.ServerRPC<Vector3, Vector3, Vector3, int>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156B5B0 Offset: 0x1569BB0 VA: 0x18156B5B0
	|-BaseEntity.ServerRPC<bool, Vector3, uint>
	|
	|-RVA: 0x156C4E0 Offset: 0x156AAE0 VA: 0x18156C4E0
	|-BaseEntity.ServerRPC<int, int, int>
	|
	|-RVA: 0x156C740 Offset: 0x156AD40 VA: 0x18156C740
	|-BaseEntity.ServerRPC<int, int, Ray>
	|
	|-RVA: 0x156CD50 Offset: 0x156B350 VA: 0x18156CD50
	|-BaseEntity.ServerRPC<int, object, int>
	|
	|-RVA: 0x156E0C0 Offset: 0x156C6C0 VA: 0x18156E0C0
	|-BaseEntity.ServerRPC<object, object, object>
	|
	|-RVA: 0x156EC70 Offset: 0x156D270 VA: 0x18156EC70
	|-BaseEntity.ServerRPC<uint, int, bool>
	|
	|-RVA: 0x156EE70 Offset: 0x156D470 VA: 0x18156EE70
	|-BaseEntity.ServerRPC<uint, int, int>
	|
	|-RVA: 0x156F420 Offset: 0x156DA20 VA: 0x18156F420
	|-BaseEntity.ServerRPC<uint, object, int>
	|
	|-RVA: 0x156F620 Offset: 0x156DC20 VA: 0x18156F620
	|-BaseEntity.ServerRPC<uint, object, object>
	|
	|-RVA: 0x156F7E0 Offset: 0x156DDE0 VA: 0x18156F7E0
	|-BaseEntity.ServerRPC<uint, object, ulong>
	|
	|-RVA: 0x1570680 Offset: 0x156EC80 VA: 0x181570680
	|-BaseEntity.ServerRPC<Vector3, Vector3, bool>
	|
	|-RVA: 0x1570B80 Offset: 0x156F180 VA: 0x181570B80
	|-BaseEntity.ServerRPC<Vector3, Vector3, float>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156CB70 Offset: 0x156B170 VA: 0x18156CB70
	|-BaseEntity.ServerRPC<int, int>
	|
	|-RVA: 0x156CF50 Offset: 0x156B550 VA: 0x18156CF50
	|-BaseEntity.ServerRPC<int, object>
	|
	|-RVA: 0x156D840 Offset: 0x156BE40 VA: 0x18156D840
	|-BaseEntity.ServerRPC<object, bool>
	|
	|-RVA: 0x156E2C0 Offset: 0x156C8C0 VA: 0x18156E2C0
	|-BaseEntity.ServerRPC<object, object>
	|
	|-RVA: 0x156F280 Offset: 0x156D880 VA: 0x18156F280
	|-BaseEntity.ServerRPC<uint, int>
	|
	|-RVA: 0x156F9A0 Offset: 0x156DFA0 VA: 0x18156F9A0
	|-BaseEntity.ServerRPC<uint, object>
	|
	|-RVA: 0x156FEE0 Offset: 0x156E4E0 VA: 0x18156FEE0
	|-BaseEntity.ServerRPC<ulong, int>
	|
	|-RVA: 0x15700C0 Offset: 0x156E6C0 VA: 0x1815700C0
	|-BaseEntity.ServerRPC<ulong, object>
	|
	|-RVA: 0x156D4C0 Offset: 0x156BAC0 VA: 0x18156D4C0
	|-BaseEntity.ServerRPC<Ray, int>
	|
	|-RVA: 0x156D680 Offset: 0x156BC80 VA: 0x18156D680
	|-BaseEntity.ServerRPC<Ray, uint>
	|
	|-RVA: 0x15710A0 Offset: 0x156F6A0 VA: 0x1815710A0
	|-BaseEntity.ServerRPC<Vector3, Vector3>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1>(SendMethod sendMethod, string funcName, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156B790 Offset: 0x1569D90 VA: 0x18156B790
	|-BaseEntity.ServerRPC<bool>
	|
	|-RVA: 0x156D2C0 Offset: 0x156B8C0 VA: 0x18156D2C0
	|-BaseEntity.ServerRPC<int>
	|
	|-RVA: 0x156E4D0 Offset: 0x156CAD0 VA: 0x18156E4D0
	|-BaseEntity.ServerRPC<object>
	|
	|-RVA: 0x156E650 Offset: 0x156CC50 VA: 0x18156E650
	|-BaseEntity.ServerRPC<float>
	|
	|-RVA: 0x156FD60 Offset: 0x156E360 VA: 0x18156FD60
	|-BaseEntity.ServerRPC<uint>
	|
	|-RVA: 0x1570480 Offset: 0x156EA80 VA: 0x181570480
	|-BaseEntity.ServerRPC<ulong>
	|
	|-RVA: 0x15712B0 Offset: 0x156F8B0 VA: 0x1815712B0
	|-BaseEntity.ServerRPC<Vector3>
	*/

	// RVA: 0x7E46E0 Offset: 0x7E2CE0 VA: 0x1807E46E0
	public void ServerRPC(SendMethod sendMethod, string funcName) { }

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3, T4, T5>(string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156B940 Offset: 0x1569F40 VA: 0x18156B940
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, byte[]>
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, object>
	|
	|-RVA: 0x156BE50 Offset: 0x156A450 VA: 0x18156BE50
	|-BaseEntity.ServerRPC<int, int, int, int, byte>
	|
	|-RVA: 0x156BB90 Offset: 0x156A190 VA: 0x18156BB90
	|-BaseEntity.ServerRPC<int, Color, Color, Color, Color>
	|
	|-RVA: 0x156DE30 Offset: 0x156C430 VA: 0x18156DE30
	|-BaseEntity.ServerRPC<object, object, object, object, object>
	|-BaseEntity.ServerRPC<string, string, string, string, string>
	|
	|-RVA: 0x156E800 Offset: 0x156CE00 VA: 0x18156E800
	|-BaseEntity.ServerRPC<uint, byte, uint, uint, bool>
	|
	|-RVA: 0x156F030 Offset: 0x156D630 VA: 0x18156F030
	|-BaseEntity.ServerRPC<uint, int, uint, int, int>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3, T4>(string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156CAE0 Offset: 0x156B0E0 VA: 0x18156CAE0
	|-BaseEntity.ServerRPC<int, int, byte[], bool>
	|-BaseEntity.ServerRPC<int, int, object, bool>
	|-BaseEntity.ServerRPC<int, uint, byte[], bool>
	|-BaseEntity.ServerRPC<int, uint, object, bool>
	|
	|-RVA: 0x156C0A0 Offset: 0x156A6A0 VA: 0x18156C0A0
	|-BaseEntity.ServerRPC<int, int, int, int>
	|
	|-RVA: 0x156C2C0 Offset: 0x156A8C0 VA: 0x18156C2C0
	|-BaseEntity.ServerRPC<int, int, int, float>
	|
	|-RVA: 0x156DBF0 Offset: 0x156C1F0 VA: 0x18156DBF0
	|-BaseEntity.ServerRPC<object, object, int, object>
	|-BaseEntity.ServerRPC<string, string, int, string>
	|
	|-RVA: 0x156E070 Offset: 0x156C670 VA: 0x18156E070
	|-BaseEntity.ServerRPC<object, object, object, object>
	|
	|-RVA: 0x156EC20 Offset: 0x156D220 VA: 0x18156EC20
	|-BaseEntity.ServerRPC<uint, byte, uint, uint>
	|
	|-RVA: 0x156FB40 Offset: 0x156E140 VA: 0x18156FB40
	|-BaseEntity.ServerRPC<uint, uint, sbyte, int>
	|
	|-RVA: 0x1570430 Offset: 0x156EA30 VA: 0x181570430
	|-BaseEntity.ServerRPC<ulong, uint, uint, byte[]>
	|-BaseEntity.ServerRPC<ulong, uint, uint, object>
	|
	|-RVA: 0x1570870 Offset: 0x156EE70 VA: 0x181570870
	|-BaseEntity.ServerRPC<Vector3, Vector3, int, int>
	|
	|-RVA: 0x1570F90 Offset: 0x156F590 VA: 0x181570F90
	|-BaseEntity.ServerRPC<Vector3, Vector3, Vector3, int>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2, T3>(string funcName, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156B550 Offset: 0x1569B50 VA: 0x18156B550
	|-BaseEntity.ServerRPC<bool, Vector3, uint>
	|
	|-RVA: 0x156CD10 Offset: 0x156B310 VA: 0x18156CD10
	|-BaseEntity.ServerRPC<int, byte[], int>
	|-BaseEntity.ServerRPC<int, object, int>
	|-BaseEntity.ServerRPC<uint, object, int>
	|
	|-RVA: 0x156C6A0 Offset: 0x156ACA0 VA: 0x18156C6A0
	|-BaseEntity.ServerRPC<int, int, int>
	|-BaseEntity.ServerRPC<uint, int, int>
	|
	|-RVA: 0x156C6E0 Offset: 0x156ACE0 VA: 0x18156C6E0
	|-BaseEntity.ServerRPC<int, int, Ray>
	|
	|-RVA: 0x156E280 Offset: 0x156C880 VA: 0x18156E280
	|-BaseEntity.ServerRPC<object, object, object>
	|
	|-RVA: 0x156F5E0 Offset: 0x156DBE0 VA: 0x18156F5E0
	|-BaseEntity.ServerRPC<uint, byte[], ulong>
	|-BaseEntity.ServerRPC<uint, object, object>
	|-BaseEntity.ServerRPC<uint, object, ulong>
	|
	|-RVA: 0x156EE30 Offset: 0x156D430 VA: 0x18156EE30
	|-BaseEntity.ServerRPC<uint, int, bool>
	|
	|-RVA: 0x1570600 Offset: 0x156EC00 VA: 0x181570600
	|-BaseEntity.ServerRPC<Vector3, Vector3, bool>
	|
	|-RVA: 0x1570B00 Offset: 0x156F100 VA: 0x181570B00
	|-BaseEntity.ServerRPC<Vector3, Vector3, float>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1, T2>(string funcName, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156CF10 Offset: 0x156B510 VA: 0x18156CF10
	|-BaseEntity.ServerRPC<int, SprayList>
	|-BaseEntity.ServerRPC<int, byte[]>
	|-BaseEntity.ServerRPC<int, object>
	|-BaseEntity.ServerRPC<int, string>
	|-BaseEntity.ServerRPC<uint, byte[]>
	|-BaseEntity.ServerRPC<uint, object>
	|-BaseEntity.ServerRPC<uint, string>
	|
	|-RVA: 0x156CB30 Offset: 0x156B130 VA: 0x18156CB30
	|-BaseEntity.ServerRPC<int, int>
	|-BaseEntity.ServerRPC<uint, int>
	|
	|-RVA: 0x156D9E0 Offset: 0x156BFE0 VA: 0x18156D9E0
	|-BaseEntity.ServerRPC<object, bool>
	|-BaseEntity.ServerRPC<string, bool>
	|
	|-RVA: 0x156E460 Offset: 0x156CA60 VA: 0x18156E460
	|-BaseEntity.ServerRPC<object, object>
	|-BaseEntity.ServerRPC<string, string>
	|-BaseEntity.ServerRPC<ulong, object>
	|-BaseEntity.ServerRPC<ulong, string>
	|
	|-RVA: 0x1570080 Offset: 0x156E680 VA: 0x181570080
	|-BaseEntity.ServerRPC<ulong, int>
	|
	|-RVA: 0x156D470 Offset: 0x156BA70 VA: 0x18156D470
	|-BaseEntity.ServerRPC<Ray, int>
	|-BaseEntity.ServerRPC<Ray, uint>
	|
	|-RVA: 0x1571030 Offset: 0x156F630 VA: 0x181571030
	|-BaseEntity.ServerRPC<Vector3, Vector3>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPC<T1>(string funcName, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156E4A0 Offset: 0x156CAA0 VA: 0x18156E4A0
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
	|-RVA: 0x156B910 Offset: 0x1569F10 VA: 0x18156B910
	|-BaseEntity.ServerRPC<bool>
	|
	|-RVA: 0x156D440 Offset: 0x156BA40 VA: 0x18156D440
	|-BaseEntity.ServerRPC<int>
	|-BaseEntity.ServerRPC<uint>
	|
	|-RVA: 0x156E7D0 Offset: 0x156CDD0 VA: 0x18156E7D0
	|-BaseEntity.ServerRPC<float>
	|
	|-RVA: 0x1571270 Offset: 0x156F870 VA: 0x181571270
	|-BaseEntity.ServerRPC<Vector3>
	*/

	// RVA: 0x7E4A10 Offset: 0x7E3010 VA: 0x1807E4A10
	public void ServerRPC(string funcName) { }

	// RVA: 0x7E4530 Offset: 0x7E2B30 VA: 0x1807E4530
	private bool ServerRPCStart(string funcName) { }

	// RVA: -1 Offset: -1
	private void ServerRPCWrite<T>(T arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156B220 Offset: 0x1569820 VA: 0x18156B220
	|-BaseEntity.ServerRPCWrite<bool>
	|-BaseEntity.ServerRPCWrite<byte>
	|-BaseEntity.ServerRPCWrite<sbyte>
	|
	|-RVA: 0x156B300 Offset: 0x1569900 VA: 0x18156B300
	|-BaseEntity.ServerRPCWrite<int>
	|-BaseEntity.ServerRPCWrite<uint>
	|
	|-RVA: 0x156B3F0 Offset: 0x15699F0 VA: 0x18156B3F0
	|-BaseEntity.ServerRPCWrite<object>
	|-BaseEntity.ServerRPCWrite<ulong>
	|
	|-RVA: 0x156B460 Offset: 0x1569A60 VA: 0x18156B460
	|-BaseEntity.ServerRPCWrite<float>
	|
	|-RVA: 0x156B290 Offset: 0x1569890 VA: 0x18156B290
	|-BaseEntity.ServerRPCWrite<Color>
	|
	|-RVA: 0x156B370 Offset: 0x1569970 VA: 0x18156B370
	|-BaseEntity.ServerRPCWrite<Ray>
	|
	|-RVA: 0x156B4D0 Offset: 0x1569AD0 VA: 0x18156B4D0
	|-BaseEntity.ServerRPCWrite<Vector3>
	*/

	// RVA: 0x7E44C0 Offset: 0x7E2AC0 VA: 0x1807E44C0
	private void ServerRPCSend(SendInfo sendInfo) { }

	// RVA: -1 Offset: -1
	public void ServerRPCList<T1>(string funcName, List<T1> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156AB50 Offset: 0x1569150 VA: 0x18156AB50
	|-BaseEntity.ServerRPCList<object>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPCList<T1, T2, T3, T4, T5>(string funcName, List<T1> list, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156A7C0 Offset: 0x1568DC0 VA: 0x18156A7C0
	|-BaseEntity.ServerRPCList<object, object, object, object, object>
	*/

	// RVA: -1 Offset: -1
	public void ServerRPCList<T1, T2, T3, T4, T5, T6>(string funcName, List<T1> list, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156A420 Offset: 0x1568A20 VA: 0x18156A420
	|-BaseEntity.ServerRPCList<object, object, object, object, object, object>
	|
	|-RVA: 0x156AE70 Offset: 0x1569470 VA: 0x18156AE70
	|-BaseEntity.ServerRPCList<Vector3, uint, int, uint, int, int>
	*/

	// RVA: 0x7DA640 Offset: 0x7D8C40 VA: 0x1807DA640
	public void CL_RPCMessage(uint nameID, ulong sourceConnection, Message message) { }

	// RVA: 0x7E4410 Offset: 0x7E2A10 VA: 0x1807E4410
	public void SendSignalBroadcast(BaseEntity.Signal signal, string arg = "") { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7E5120 Offset: 0x7E3720 VA: 0x1807E5120
	private void SignalFromServerEx(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7E51B0 Offset: 0x7E37B0 VA: 0x1807E51B0
	private void SignalFromServer(BaseEntity.RPCMessage msg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 83
	public virtual void OnSignal(BaseEntity.Signal signal, string arg) { }

	// RVA: 0x7E30C0 Offset: 0x7E16C0 VA: 0x1807E30C0
	private void OnSkinChanged(ulong oldSkinID, ulong newSkinID) { }

	// RVA: 0x7E3430 Offset: 0x7E1A30 VA: 0x1807E3430
	private void OnSkinRefreshStart() { }

	// RVA: 0x7E3410 Offset: 0x7E1A10 VA: 0x1807E3410
	private void OnSkinRefreshEnd() { }

	// RVA: 0x7E38A0 Offset: 0x7E1EA0 VA: 0x1807E38A0 Slot: 84
	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x7DF590 Offset: 0x7DDB90 VA: 0x1807DF590
	public bool HasAnySlot() { }

	// RVA: 0x7DF110 Offset: 0x7DD710 VA: 0x1807DF110
	public BaseEntity GetSlot(BaseEntity.Slot slot) { }

	// RVA: 0x7DEFD0 Offset: 0x7DD5D0 VA: 0x1807DEFD0
	public string GetSlotAnchorName(BaseEntity.Slot slot) { }

	// RVA: 0x7DF060 Offset: 0x7DD660 VA: 0x1807DF060
	public Transform GetSlotAnchor(BaseEntity.Slot slot) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 85
	public virtual bool HasSlot(BaseEntity.Slot slot) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 86
	public virtual BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x7DF820 Offset: 0x7DDE20 VA: 0x1807DF820
	public bool HasTrait(BaseEntity.TraitFlag f) { }

	// RVA: 0x7DF640 Offset: 0x7DDC40 VA: 0x1807DF640
	public bool HasAnyTrait(BaseEntity.TraitFlag f) { }

	// RVA: 0x7DC090 Offset: 0x7DA690 VA: 0x1807DC090 Slot: 87
	public virtual bool EnterTrigger(TriggerBase trigger) { }

	// RVA: 0x7E0D90 Offset: 0x7DF390 VA: 0x1807E0D90 Slot: 88
	public virtual void LeaveTrigger(TriggerBase trigger) { }

	// RVA: 0x7E3DE0 Offset: 0x7E23E0 VA: 0x1807E3DE0
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
	|-RVA: 0x125C7F0 Offset: 0x125ADF0 VA: 0x18125C7F0
	|-BaseEntity.FindTrigger<object>
	*/

	// RVA: 0x7DC940 Offset: 0x7DAF40 VA: 0x1807DC940
	private void ForceUpdateTriggersAction() { }

	// RVA: 0x7DC970 Offset: 0x7DAF70 VA: 0x1807DC970
	public void ForceUpdateTriggers(bool enter = True, bool exit = True, bool invoke = True) { }

	// RVA: 0x7E1D60 Offset: 0x7E0360 VA: 0x1807E1D60 Slot: 89
	public virtual void MakeVisible() { }

	// RVA: 0x7E5A40 Offset: 0x7E4040 VA: 0x1807E5A40 Slot: 90
	protected virtual void UpdateCullingSpheres() { }

	// RVA: 0x7E3B50 Offset: 0x7E2150 VA: 0x1807E3B50 Slot: 91
	protected virtual void RegisterForCulling() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 92
	protected virtual void OnVisibilityChanged(bool visible) { }

	// RVA: 0x7E57D0 Offset: 0x7E3DD0 VA: 0x1807E57D0 Slot: 93
	protected virtual void UnregisterFromCulling() { }

	// RVA: 0x7E5970 Offset: 0x7E3F70 VA: 0x1807E5970 Slot: 94
	protected virtual void UpdateCullingBounds() { }

	// RVA: 0x7DAC00 Offset: 0x7D9200 VA: 0x1807DAC00 Slot: 95
	protected virtual bool CheckVisibility() { }

	// RVA: 0x7DAAE0 Offset: 0x7D90E0 VA: 0x1807DAAE0
	protected float CalcEntityVisUpdateRate() { }

	// RVA: 0x7DB130 Offset: 0x7D9730 VA: 0x1807DB130 Slot: 96
	protected virtual void DebugDrawCullingBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7E6DB0 Offset: 0x7E53B0 VA: 0x1807E6DB0
	public float get_Weight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7E6DD0 Offset: 0x7E53D0 VA: 0x1807E6DD0
	protected void set_Weight(float value) { }

	// RVA: 0x7E6D30 Offset: 0x7E5330 VA: 0x1807E6D30
	public EntityComponentBase[] get_Components() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 97
	public virtual BasePlayer ToPlayer() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 98
	public virtual bool get_IsNpc() { }

	// RVA: 0x7D3FC0 Offset: 0x7D25C0 VA: 0x1807D3FC0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x7D6EE0 Offset: 0x7D54E0 VA: 0x1807D6EE0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x7E43A0 Offset: 0x7E29A0 VA: 0x1807E43A0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 99
	public virtual float InheritedVelocityScale() { }

	// RVA: 0x7DDD50 Offset: 0x7DC350 VA: 0x1807DDD50 Slot: 100
	public virtual Vector3 GetInheritedProjectileVelocity() { }

	// RVA: 0x7DDED0 Offset: 0x7DC4D0 VA: 0x1807DDED0 Slot: 101
	public virtual Vector3 GetInheritedThrowVelocity() { }

	// RVA: 0x7DDC70 Offset: 0x7DC270 VA: 0x1807DDC70 Slot: 102
	public virtual Vector3 GetInheritedDropVelocity() { }

	// RVA: 0x7DED10 Offset: 0x7DD310 VA: 0x1807DED10
	public Vector3 GetParentVelocity() { }

	// RVA: 0x7DF170 Offset: 0x7DD770 VA: 0x1807DF170
	public Vector3 GetWorldVelocity() { }

	// RVA: 0x7DE390 Offset: 0x7DC990 VA: 0x1807DE390
	public Vector3 GetLocalVelocity() { }

	// RVA: 0x7DD530 Offset: 0x7DBB30 VA: 0x1807DD530
	public Quaternion GetAngularVelocity() { }

	// RVA: 0x7E6A60 Offset: 0x7E5060 VA: 0x1807E6A60 Slot: 103
	public virtual OBB WorldSpaceBounds() { }

	// RVA: 0x2FA9E0 Offset: 0x2F8FE0 VA: 0x1802FA9E0
	public Vector3 PivotPoint() { }

	// RVA: 0x7DABC0 Offset: 0x7D91C0 VA: 0x1807DABC0
	public Vector3 CenterPoint() { }

	// RVA: 0x7DAE20 Offset: 0x7D9420 VA: 0x1807DAE20
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x7DABC0 Offset: 0x7D91C0 VA: 0x1807DABC0 Slot: 104
	public virtual Vector3 TriggerPoint() { }

	// RVA: 0x7DB590 Offset: 0x7D9B90 VA: 0x1807DB590 Slot: 105
	public float Distance(Vector3 position) { }

	// RVA: 0x7E53D0 Offset: 0x7E39D0 VA: 0x1807E53D0
	public float SqrDistance(Vector3 position) { }

	// RVA: 0x7DB530 Offset: 0x7D9B30 VA: 0x1807DB530
	public float Distance(BaseEntity other) { }

	// RVA: 0x7E5370 Offset: 0x7E3970 VA: 0x1807E5370
	public float SqrDistance(BaseEntity other) { }

	// RVA: 0x7DB3F0 Offset: 0x7D99F0 VA: 0x1807DB3F0
	public float Distance2D(Vector3 position) { }

	// RVA: 0x7E5230 Offset: 0x7E3830 VA: 0x1807E5230
	public float SqrDistance2D(Vector3 position) { }

	// RVA: 0x7DB530 Offset: 0x7D9B30 VA: 0x1807DB530
	public float Distance2D(BaseEntity other) { }

	// RVA: 0x7E5370 Offset: 0x7E3970 VA: 0x1807E5370
	public float SqrDistance2D(BaseEntity other) { }

	// RVA: 0x7E09D0 Offset: 0x7DEFD0 VA: 0x1807E09D0
	public bool IsVisible(Ray ray, int layerMask, float maxDistance) { }

	// RVA: 0x7E0380 Offset: 0x7DE980 VA: 0x1807E0380
	public bool IsVisibleSpecificLayers(Vector3 position, Vector3 target, int layerMask, float maxDistance = ∞) { }

	// RVA: 0x7E05F0 Offset: 0x7DEBF0 VA: 0x1807E05F0
	public bool IsVisible(Vector3 position, Vector3 target, float maxDistance = ∞) { }

	// RVA: 0x7E0870 Offset: 0x7DEE70 VA: 0x1807E0870
	public bool IsVisible(Vector3 position, float maxDistance = ∞) { }

	// RVA: 0x7E0170 Offset: 0x7DE770 VA: 0x1807E0170
	public bool IsVisibleAndCanSee(Vector3 position, float maxDistance = ∞) { }

	// RVA: 0x7DFDB0 Offset: 0x7DE3B0 VA: 0x1807DFDB0
	public bool IsOlderThan(BaseEntity other) { }

	// RVA: 0x7DFE80 Offset: 0x7DE480 VA: 0x1807DFE80 Slot: 106
	public virtual bool IsOutside() { }

	// RVA: 0x7DFEE0 Offset: 0x7DE4E0 VA: 0x1807DFEE0
	public bool IsOutside(Vector3 position) { }

	// RVA: 0x7E65D0 Offset: 0x7E4BD0 VA: 0x1807E65D0 Slot: 107
	public virtual float WaterFactor() { }

	// RVA: 0x7DA390 Offset: 0x7D8990 VA: 0x1807DA390 Slot: 108
	public virtual float AirFactor() { }

	// RVA: 0x7E67A0 Offset: 0x7E4DA0 VA: 0x1807E67A0
	public bool WaterTestFromVolumes(Vector3 pos, out WaterLevel.WaterInfo info) { }

	// RVA: 0x7DFA60 Offset: 0x7DE060 VA: 0x1807DFA60
	public bool IsInWaterVolume(Vector3 pos) { }

	// RVA: 0x7E6670 Offset: 0x7E4C70 VA: 0x1807E6670
	public bool WaterTestFromVolumes(Bounds bounds, out WaterLevel.WaterInfo info) { }

	// RVA: 0x7E68D0 Offset: 0x7E4ED0 VA: 0x1807E68D0
	public bool WaterTestFromVolumes(Vector3 start, Vector3 end, float radius, out WaterLevel.WaterInfo info) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 109
	public virtual bool BlocksWaterFor(BasePlayer player) { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 110
	public virtual float Health() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 111
	public virtual float MaxHealth() { }

	// RVA: 0x5686E0 Offset: 0x566CE0 VA: 0x1805686E0 Slot: 112
	public virtual float MaxVelocity() { }

	// RVA: 0x7DA3D0 Offset: 0x7D89D0 VA: 0x1807DA3D0 Slot: 113
	public virtual float BoundsPadding() { }

	// RVA: 0x723120 Offset: 0x721720 VA: 0x180723120 Slot: 114
	public virtual float PenetrationResistance(HitInfo info) { }

	// RVA: 0x7DDC60 Offset: 0x7DC260 VA: 0x1807DDC60 Slot: 115
	public virtual GameObjectRef GetImpactEffect(HitInfo info) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 116
	public virtual void OnAttacked(HitInfo info) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 117
	public virtual Item GetItem() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 118
	public virtual Item GetItem(uint itemId) { }

	// RVA: 0x7DF560 Offset: 0x7DDB60 VA: 0x1807DF560 Slot: 119
	public virtual void GiveItem(Item item, BaseEntity.GiveItemReason reason = 0) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 120
	public virtual bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 121
	public virtual BaseEntity GetEntity() { }

	// RVA: 0x7E56E0 Offset: 0x7E3CE0 VA: 0x1807E56E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x7DAB90 Offset: 0x7D9190 VA: 0x1807DAB90 Slot: 122
	public virtual string Categorize() { }

	// RVA: 0x7E18B0 Offset: 0x7DFEB0 VA: 0x1807E18B0
	public void Log(string str) { }

	// RVA: 0x7E4B40 Offset: 0x7E3140 VA: 0x1807E4B40
	public void SetModel(Model mdl) { }

	// RVA: 0x701810 Offset: 0x6FFE10 VA: 0x180701810
	public Model GetModel() { }

	// RVA: 0x7DD5D0 Offset: 0x7DBBD0 VA: 0x1807DD5D0 Slot: 123
	public virtual Transform[] GetBones() { }

	// RVA: 0x7DC4F0 Offset: 0x7DAAF0 VA: 0x1807DC4F0 Slot: 124
	public virtual Transform FindBone(string strName) { }

	// RVA: 0x7DC410 Offset: 0x7DAA10 VA: 0x1807DC410 Slot: 125
	public virtual uint FindBoneID(Transform boneTransform) { }

	// RVA: 0x7DC5A0 Offset: 0x7DABA0 VA: 0x1807DC5A0 Slot: 126
	public virtual Transform FindClosestBone(Vector3 worldPos) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7E6DA0 Offset: 0x7E53A0 VA: 0x1807E6DA0
	public ulong get_OwnerID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7E6DC0 Offset: 0x7E53C0 VA: 0x1807E6DC0
	public void set_OwnerID(ulong value) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 127
	public virtual bool ShouldBlockProjectiles() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 128
	public virtual bool ShouldInheritNetworkGroup() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 129
	public virtual bool SupportsChildDeployables() { }

	// RVA: 0x7DA3E0 Offset: 0x7D89E0 VA: 0x1807DA3E0
	public void BroadcastEntityMessage(string msg, float radius = 20, int layerMask = 1218652417) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 130
	public virtual void OnEntityMessage(BaseEntity from, string msg) { }

	// RVA: 0x7E13B0 Offset: 0x7DF9B0 VA: 0x1807E13B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7E6C20 Offset: 0x7E5220 VA: 0x1807E6C20
	public void .ctor() { }

	// RVA: 0x7E6BA0 Offset: 0x7E51A0 VA: 0x1807E6BA0
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

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

	// RVA: 0x7ED280 Offset: 0x7EB880 VA: 0x1807ED280
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

	// RVA: 0xF8640 Offset: 0xF7A40 VA: 0x1800F8640
	public void CopyTo(ref Option option) { }

}

public class BaseEntity.Menu.Description : Attribute // TypeDefIndex: 8495
{	// Fields
	public string token; // 0x10
	public string english; // 0x18

	// Methods

	// RVA: 0x7ED280 Offset: 0x7EB880 VA: 0x1807ED280
	public void .ctor(string t, string e) { }

}

public class BaseEntity.Menu.Icon : Attribute // TypeDefIndex: 8496
{	// Fields
	public string icon; // 0x10

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string i) { }

}

public class BaseEntity.Menu.ShowIf : Attribute // TypeDefIndex: 8497
{	// Fields
	public string functionName; // 0x10

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string testFunc) { }

}

public class BaseEntity.Menu.UsableWhileWounded : Attribute // TypeDefIndex: 8498
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
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

	// RVA: 0xF8890 Offset: 0xF7C90 VA: 0x1800F8890
	public void .ctor(FileStorage.Type type, uint numId, uint crc, IServerFileReceiver receiver) { }

	// RVA: 0xF87E0 Offset: 0xF7BE0 VA: 0x1800F87E0 Slot: 4
	public bool Equals(BaseEntity.ServerFileRequest other) { }

	// RVA: 0xF8730 Offset: 0xF7B30 VA: 0x1800F8730 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF8830 Offset: 0xF7C30 VA: 0x1800F8830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x7EDE30 Offset: 0x7EC430 VA: 0x1807EDE30
	public static bool op_Equality(BaseEntity.ServerFileRequest left, BaseEntity.ServerFileRequest right) { }

	// RVA: 0x7EDEE0 Offset: 0x7EC4E0 VA: 0x1807EDEE0
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

	// RVA: 0x7EDBF0 Offset: 0x7EC1F0 VA: 0x1807EDBF0
	public void .ctor(float worldSize) { }

	// RVA: 0x7ED410 Offset: 0x7EBA10 VA: 0x1807ED410
	public void Add(BaseEntity ent) { }

	// RVA: 0x7ED370 Offset: 0x7EB970 VA: 0x1807ED370
	public void AddPlayer(BasePlayer player) { }

	// RVA: 0x7ED2D0 Offset: 0x7EB8D0 VA: 0x1807ED2D0
	public void AddBrain(BaseEntity entity) { }

	// RVA: 0x7EDAF0 Offset: 0x7EC0F0 VA: 0x1807EDAF0
	public void Remove(BaseEntity ent, bool isPlayer = False) { }

	// RVA: 0x7EDA90 Offset: 0x7EC090 VA: 0x1807EDA90
	public void RemovePlayer(BasePlayer player) { }

	// RVA: 0x7EDA00 Offset: 0x7EC000 VA: 0x1807EDA00
	public void RemoveBrain(BaseEntity entity) { }

	// RVA: 0x7ED7D0 Offset: 0x7EBDD0 VA: 0x1807ED7D0
	public void Move(BaseEntity ent) { }

	// RVA: 0x7ED730 Offset: 0x7EBD30 VA: 0x1807ED730
	public void MovePlayer(BasePlayer player) { }

	// RVA: 0x7ED690 Offset: 0x7EBC90 VA: 0x1807ED690
	public void MoveBrain(BaseEntity entity) { }

	// RVA: 0x7ED550 Offset: 0x7EBB50 VA: 0x1807ED550
	public int GetInSphere(Vector3 position, float distance, BaseEntity[] results, Func<BaseEntity, bool> filter) { }

	// RVA: 0x7ED5F0 Offset: 0x7EBBF0 VA: 0x1807ED5F0
	public int GetPlayersInSphere(Vector3 position, float distance, BasePlayer[] results, Func<BasePlayer, bool> filter) { }

	// RVA: 0x7ED4B0 Offset: 0x7EBAB0 VA: 0x1807ED4B0
	public int GetBrainsInSphere(Vector3 position, float distance, BaseEntity[] results, Func<BaseEntity, bool> filter) { }

}

public class BaseEntity.RPC_Shared : Attribute // TypeDefIndex: 8504
{	// Methods

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
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

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
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

	// RVA: 0x7EDFD0 Offset: 0x7EC5D0 VA: 0x1807EDFD0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x7EDF30 Offset: 0x7EC530 VA: 0x1807EDF30
	internal int <GetMenuItems>b__35_0(Option x, Option y) { }

	// RVA: 0x7EDF60 Offset: 0x7EC560 VA: 0x1807EDF60
	internal bool <RequestFileFromServer>b__93_0(BaseEntity.ServerFileRequest r) { }

}

