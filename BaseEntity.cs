public class BaseEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6293
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 pos; // 0x14
	public Vector3 rot; // 0x20
	public int flags; // 0x2C
	public float time; // 0x30
	public ulong skinid; // 0x38


	public static void ResetToPool(BaseEntity instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BaseEntity instance) { }

	public BaseEntity Copy() { }

	public static BaseEntity Deserialize(Stream stream) { }

	public static BaseEntity DeserializeLengthDelimited(Stream stream) { }

	public static BaseEntity DeserializeLength(Stream stream, int length) { }

	public static BaseEntity Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BaseEntity previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BaseEntity Deserialize(byte[] buffer, BaseEntity instance, bool isDelta = False) { }

	public static BaseEntity Deserialize(Stream stream, BaseEntity instance, bool isDelta) { }

	public static BaseEntity DeserializeLengthDelimited(Stream stream, BaseEntity instance, bool isDelta) { }

	public static BaseEntity DeserializeLength(Stream stream, int length, BaseEntity instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BaseEntity instance, BaseEntity previous) { }

	public static void Serialize(Stream stream, BaseEntity instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BaseEntity instance) { }

	public static void SerializeLengthDelimited(Stream stream, BaseEntity instance) { }

	public void .ctor() { }

}

public class BaseEntity : BaseNetworkable, IProvider, IPosLerpTarget, ILerpInfo, IPrefabPreProcess // TypeDefIndex: 8492
{	protected Ragdoll ragdoll; // 0x78
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

	public virtual bool HasMenuOptions { get; }
	public virtual float RealisticMass { get; }
	public virtual BaseEntity.TraitFlag Traits { get; }
	public float Weight { get; set; }
	public EntityComponentBase[] Components { get; }
	public virtual bool IsNpc { get; }
	public ulong OwnerID { get; set; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void GetEntityMenu(BasePlayer player, List<Option> optionList) { }

	public virtual void GetMenuOptions(List<Option> list) { }

	public virtual bool get_HasMenuOptions() { }

	public virtual void GetItemOptions(List<Option> options) { }

	public BaseEntity.MovementModify GetMovementModify() { }

	public virtual float GetExtrapolationTime() { }

	public virtual float GetInterpolationDelay() { }

	public virtual float GetInterpolationInertia() { }

	public virtual float GetInterpolationSmoothing() { }

	public virtual Quaternion GetAngularVelocityClient() { }

	public virtual Vector3 GetLocalVelocityClient() { }

	public void DrawInterpolationState(Interpolator.Segment<TransformSnapshot> segment, List<TransformSnapshot> entries) { }

	public void LerpIdleDisable() { }

	protected override void ClientInit(Entity info) { }

	public override void ClientOnEnable() { }

	public void OnPositionalFromNetwork(Vector3 vPos, Vector3 vAng, float time) { }

	public void StartLerping(float time) { }

	public void StopLerping() { }

	public virtual bool ShouldLerp() { }

	public virtual void SetNetworkPosition(Vector3 vPos) { }

	public virtual void SetNetworkRotation(Quaternion qRot) { }

	public virtual void DoDestroyEffects(BaseNetworkable.DestroyMode mode, Message msg) { }

	protected virtual void SpawnGibs() { }

	internal override void DoNetworkDestroy() { }

	public override void PostNetworkUpdate() { }

	public virtual void OnBecameRagdoll(Ragdoll rdoll) { }

	public virtual Info GetMenuInformation(GameObject primaryObject, BasePlayer player) { }

	protected virtual bool HideMenuItems(BasePlayer player) { }

	public virtual List<Option> GetMenuItems(BasePlayer player) { }

	public virtual void OnUse(BasePlayer player) { }

	public virtual void OnUseHeld(BasePlayer player) { }

	public virtual void OnUseStopped(BasePlayer player) { }

	public virtual void OnRendered() { }

	protected override void DoClientDestroy() { }

	internal virtual Transform GetEyeTransform() { }

	public virtual bool NeedsCrosshair() { }

	public virtual bool AlwaysShowCrosshair() { }

	public override bool ShouldDestroyWithGroup() { }

	public void DetachEffects() { }

	public virtual void OnVoiceData(byte[] data) { }

	public virtual void LookingAtTick() { }

	public virtual float get_RealisticMass() { }

	public virtual void OnCollision(Collision collision, BaseEntity hitEntity) { }

	protected void ReceiveCollisionMessages(bool b) { }

	public virtual void DebugClient(int rep, float time) { }

	public void OnDebugStart() { }

	protected void DebugText(Vector3 pos, string str, Color color, float time) { }

	public bool HasFlag(BaseEntity.Flags f) { }

	public bool ParentHasFlag(BaseEntity.Flags f) { }

	public void SetFlag(BaseEntity.Flags f, bool b, bool recursive = False, bool networkupdate = True) { }

	public bool IsOn() { }

	public bool IsOpen() { }

	public bool IsOnFire() { }

	public bool IsLocked() { }

	public override bool IsDebugging() { }

	public bool IsDisabled() { }

	public bool IsBroken() { }

	public bool IsBusy() { }

	public override string GetLogColor() { }

	public virtual void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public bool IsOccupied(Socket_Base socket) { }

	public bool IsOccupied(string socketName) { }

	public EntityLink FindLink(Socket_Base socket) { }

	public EntityLink FindLink(string socketName) { }

	public EntityLink FindLink(string[] socketNames) { }

	public T FindLinkedEntity<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA050 Offset: 0x5C8650 VA: 0x1805CA050
	|-BaseEntity.FindLinkedEntity<object>
	*/

	public void EntityLinkMessage<T>(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15696D0 Offset: 0x1567CD0 VA: 0x1815696D0
	|-BaseEntity.EntityLinkMessage<object>
	*/

	public void EntityLinkBroadcast<T, S>(Action<T> action, Func<S, bool> canTraverseSocket) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1568D70 Offset: 0x1567370 VA: 0x181568D70
	|-BaseEntity.EntityLinkBroadcast<object, object>
	*/

	public void EntityLinkBroadcast<T>(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1569290 Offset: 0x1567890 VA: 0x181569290
	|-BaseEntity.EntityLinkBroadcast<object>
	*/

	public void EntityLinkBroadcast() { }

	public bool ReceivedEntityLinkBroadcast() { }

	public List<EntityLink> GetEntityLinks(bool linkToNeighbours = True) { }

	private void LinkToEntity(BaseEntity other) { }

	private void LinkToNeighbours() { }

	private void InitEntityLinks() { }

	private void FreeEntityLinks() { }

	public void RefreshEntityLinks() { }

	[ObsoleteAttribute] // RVA: 0x9F7E0 Offset: 0x9EBE0 VA: 0x18009F7E0
	public void RequestFileFromServer(uint crc, FileStorage.Type type, string responseFunction, uint part = 0) { }

	public void RequestFileFromServer(IServerFileReceiver receiver, FileStorage.Type type, uint crc, uint part = 0, bool respondIfNotFound = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void CL_ReceiveFileRequest(BaseEntity.RPCMessage msg) { }

	private void CompletePendingFileRequests(FileStorage.Type type, uint crc, uint part, byte[] data) { }

	public void UpdateChildren() { }

	public void UpdateParenting() { }

	public void UpdateParenting(bool worldPositionStays) { }

	private void SetParentTransform(Transform parent, bool worldPositionStays = True) { }

	protected void UpdateDisableState() { }

	private bool HasClientTransformOffset() { }

	private void RemoveClientTransformOffset() { }

	private void AddClientTransformOffset() { }

	public virtual void OnParentChangingClient(Transform oldParent, Transform newParent) { }

	public virtual BuildingPrivlidge GetBuildingPrivilege() { }

	public BuildingPrivlidge GetBuildingPrivilege(OBB obb) { }

	public void ServerRPC<T1, T2, T3, T4, T5>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156AE30 Offset: 0x1569430 VA: 0x18156AE30
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, object>
	|
	|-RVA: 0x156B340 Offset: 0x1569940 VA: 0x18156B340
	|-BaseEntity.ServerRPC<int, int, int, int, byte>
	|
	|-RVA: 0x156B0C0 Offset: 0x15696C0 VA: 0x18156B0C0
	|-BaseEntity.ServerRPC<int, Color, Color, Color, Color>
	|
	|-RVA: 0x156D0D0 Offset: 0x156B6D0 VA: 0x18156D0D0
	|-BaseEntity.ServerRPC<object, object, object, object, object>
	|
	|-RVA: 0x156DCF0 Offset: 0x156C2F0 VA: 0x18156DCF0
	|-BaseEntity.ServerRPC<uint, byte, uint, uint, bool>
	|
	|-RVA: 0x156E520 Offset: 0x156CB20 VA: 0x18156E520
	|-BaseEntity.ServerRPC<uint, int, uint, int, int>
	*/

	public void ServerRPC<T1, T2, T3, T4>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156B580 Offset: 0x1569B80 VA: 0x18156B580
	|-BaseEntity.ServerRPC<int, int, int, int>
	|
	|-RVA: 0x156B7A0 Offset: 0x1569DA0 VA: 0x18156B7A0
	|-BaseEntity.ServerRPC<int, int, int, float>
	|
	|-RVA: 0x156BDA0 Offset: 0x156A3A0 VA: 0x18156BDA0
	|-BaseEntity.ServerRPC<int, int, object, bool>
	|
	|-RVA: 0x156C580 Offset: 0x156AB80 VA: 0x18156C580
	|-BaseEntity.ServerRPC<int, uint, object, bool>
	|
	|-RVA: 0x156CEB0 Offset: 0x156B4B0 VA: 0x18156CEB0
	|-BaseEntity.ServerRPC<object, object, int, object>
	|
	|-RVA: 0x156D320 Offset: 0x156B920 VA: 0x18156D320
	|-BaseEntity.ServerRPC<object, object, object, object>
	|
	|-RVA: 0x156DEE0 Offset: 0x156C4E0 VA: 0x18156DEE0
	|-BaseEntity.ServerRPC<uint, byte, uint, uint>
	|
	|-RVA: 0x156F020 Offset: 0x156D620 VA: 0x18156F020
	|-BaseEntity.ServerRPC<uint, uint, sbyte, int>
	|
	|-RVA: 0x156F6F0 Offset: 0x156DCF0 VA: 0x18156F6F0
	|-BaseEntity.ServerRPC<ulong, uint, uint, object>
	|
	|-RVA: 0x156FD90 Offset: 0x156E390 VA: 0x18156FD90
	|-BaseEntity.ServerRPC<Vector3, Vector3, int, int>
	|
	|-RVA: 0x1570200 Offset: 0x156E800 VA: 0x181570200
	|-BaseEntity.ServerRPC<Vector3, Vector3, Vector3, int>
	*/

	public void ServerRPC<T1, T2, T3>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156AA40 Offset: 0x1569040 VA: 0x18156AA40
	|-BaseEntity.ServerRPC<bool, Vector3, uint>
	|
	|-RVA: 0x156B970 Offset: 0x1569F70 VA: 0x18156B970
	|-BaseEntity.ServerRPC<int, int, int>
	|
	|-RVA: 0x156BBD0 Offset: 0x156A1D0 VA: 0x18156BBD0
	|-BaseEntity.ServerRPC<int, int, Ray>
	|
	|-RVA: 0x156C1E0 Offset: 0x156A7E0 VA: 0x18156C1E0
	|-BaseEntity.ServerRPC<int, object, int>
	|
	|-RVA: 0x156D550 Offset: 0x156BB50 VA: 0x18156D550
	|-BaseEntity.ServerRPC<object, object, object>
	|
	|-RVA: 0x156E100 Offset: 0x156C700 VA: 0x18156E100
	|-BaseEntity.ServerRPC<uint, int, bool>
	|
	|-RVA: 0x156E300 Offset: 0x156C900 VA: 0x18156E300
	|-BaseEntity.ServerRPC<uint, int, int>
	|
	|-RVA: 0x156E8B0 Offset: 0x156CEB0 VA: 0x18156E8B0
	|-BaseEntity.ServerRPC<uint, object, int>
	|
	|-RVA: 0x156EAB0 Offset: 0x156D0B0 VA: 0x18156EAB0
	|-BaseEntity.ServerRPC<uint, object, object>
	|
	|-RVA: 0x156EC70 Offset: 0x156D270 VA: 0x18156EC70
	|-BaseEntity.ServerRPC<uint, object, ulong>
	|
	|-RVA: 0x156FB10 Offset: 0x156E110 VA: 0x18156FB10
	|-BaseEntity.ServerRPC<Vector3, Vector3, bool>
	|
	|-RVA: 0x1570010 Offset: 0x156E610 VA: 0x181570010
	|-BaseEntity.ServerRPC<Vector3, Vector3, float>
	*/

	public void ServerRPC<T1, T2>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156C000 Offset: 0x156A600 VA: 0x18156C000
	|-BaseEntity.ServerRPC<int, int>
	|
	|-RVA: 0x156C3E0 Offset: 0x156A9E0 VA: 0x18156C3E0
	|-BaseEntity.ServerRPC<int, object>
	|
	|-RVA: 0x156CCD0 Offset: 0x156B2D0 VA: 0x18156CCD0
	|-BaseEntity.ServerRPC<object, bool>
	|
	|-RVA: 0x156D750 Offset: 0x156BD50 VA: 0x18156D750
	|-BaseEntity.ServerRPC<object, object>
	|
	|-RVA: 0x156E710 Offset: 0x156CD10 VA: 0x18156E710
	|-BaseEntity.ServerRPC<uint, int>
	|
	|-RVA: 0x156EE30 Offset: 0x156D430 VA: 0x18156EE30
	|-BaseEntity.ServerRPC<uint, object>
	|
	|-RVA: 0x156F370 Offset: 0x156D970 VA: 0x18156F370
	|-BaseEntity.ServerRPC<ulong, int>
	|
	|-RVA: 0x156F550 Offset: 0x156DB50 VA: 0x18156F550
	|-BaseEntity.ServerRPC<ulong, object>
	|
	|-RVA: 0x156C950 Offset: 0x156AF50 VA: 0x18156C950
	|-BaseEntity.ServerRPC<Ray, int>
	|
	|-RVA: 0x156CB10 Offset: 0x156B110 VA: 0x18156CB10
	|-BaseEntity.ServerRPC<Ray, uint>
	|
	|-RVA: 0x1570530 Offset: 0x156EB30 VA: 0x181570530
	|-BaseEntity.ServerRPC<Vector3, Vector3>
	*/

	public void ServerRPC<T1>(SendMethod sendMethod, string funcName, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156AC20 Offset: 0x1569220 VA: 0x18156AC20
	|-BaseEntity.ServerRPC<bool>
	|
	|-RVA: 0x156C750 Offset: 0x156AD50 VA: 0x18156C750
	|-BaseEntity.ServerRPC<int>
	|
	|-RVA: 0x156D960 Offset: 0x156BF60 VA: 0x18156D960
	|-BaseEntity.ServerRPC<object>
	|
	|-RVA: 0x156DAE0 Offset: 0x156C0E0 VA: 0x18156DAE0
	|-BaseEntity.ServerRPC<float>
	|
	|-RVA: 0x156F1F0 Offset: 0x156D7F0 VA: 0x18156F1F0
	|-BaseEntity.ServerRPC<uint>
	|
	|-RVA: 0x156F910 Offset: 0x156DF10 VA: 0x18156F910
	|-BaseEntity.ServerRPC<ulong>
	|
	|-RVA: 0x1570740 Offset: 0x156ED40 VA: 0x181570740
	|-BaseEntity.ServerRPC<Vector3>
	*/

	public void ServerRPC(SendMethod sendMethod, string funcName) { }

	public void ServerRPC<T1, T2, T3, T4, T5>(string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156ADD0 Offset: 0x15693D0 VA: 0x18156ADD0
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, byte[]>
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, object>
	|
	|-RVA: 0x156B2E0 Offset: 0x15698E0 VA: 0x18156B2E0
	|-BaseEntity.ServerRPC<int, int, int, int, byte>
	|
	|-RVA: 0x156B020 Offset: 0x1569620 VA: 0x18156B020
	|-BaseEntity.ServerRPC<int, Color, Color, Color, Color>
	|
	|-RVA: 0x156D2C0 Offset: 0x156B8C0 VA: 0x18156D2C0
	|-BaseEntity.ServerRPC<object, object, object, object, object>
	|-BaseEntity.ServerRPC<string, string, string, string, string>
	|
	|-RVA: 0x156DC90 Offset: 0x156C290 VA: 0x18156DC90
	|-BaseEntity.ServerRPC<uint, byte, uint, uint, bool>
	|
	|-RVA: 0x156E4C0 Offset: 0x156CAC0 VA: 0x18156E4C0
	|-BaseEntity.ServerRPC<uint, int, uint, int, int>
	*/

	public void ServerRPC<T1, T2, T3, T4>(string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156BF70 Offset: 0x156A570 VA: 0x18156BF70
	|-BaseEntity.ServerRPC<int, int, byte[], bool>
	|-BaseEntity.ServerRPC<int, int, object, bool>
	|-BaseEntity.ServerRPC<int, uint, byte[], bool>
	|-BaseEntity.ServerRPC<int, uint, object, bool>
	|
	|-RVA: 0x156B530 Offset: 0x1569B30 VA: 0x18156B530
	|-BaseEntity.ServerRPC<int, int, int, int>
	|
	|-RVA: 0x156B750 Offset: 0x1569D50 VA: 0x18156B750
	|-BaseEntity.ServerRPC<int, int, int, float>
	|
	|-RVA: 0x156D080 Offset: 0x156B680 VA: 0x18156D080
	|-BaseEntity.ServerRPC<object, object, int, object>
	|-BaseEntity.ServerRPC<string, string, int, string>
	|
	|-RVA: 0x156D500 Offset: 0x156BB00 VA: 0x18156D500
	|-BaseEntity.ServerRPC<object, object, object, object>
	|
	|-RVA: 0x156E0B0 Offset: 0x156C6B0 VA: 0x18156E0B0
	|-BaseEntity.ServerRPC<uint, byte, uint, uint>
	|
	|-RVA: 0x156EFD0 Offset: 0x156D5D0 VA: 0x18156EFD0
	|-BaseEntity.ServerRPC<uint, uint, sbyte, int>
	|
	|-RVA: 0x156F8C0 Offset: 0x156DEC0 VA: 0x18156F8C0
	|-BaseEntity.ServerRPC<ulong, uint, uint, byte[]>
	|-BaseEntity.ServerRPC<ulong, uint, uint, object>
	|
	|-RVA: 0x156FD00 Offset: 0x156E300 VA: 0x18156FD00
	|-BaseEntity.ServerRPC<Vector3, Vector3, int, int>
	|
	|-RVA: 0x1570420 Offset: 0x156EA20 VA: 0x181570420
	|-BaseEntity.ServerRPC<Vector3, Vector3, Vector3, int>
	*/

	public void ServerRPC<T1, T2, T3>(string funcName, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156A9E0 Offset: 0x1568FE0 VA: 0x18156A9E0
	|-BaseEntity.ServerRPC<bool, Vector3, uint>
	|
	|-RVA: 0x156C1A0 Offset: 0x156A7A0 VA: 0x18156C1A0
	|-BaseEntity.ServerRPC<int, byte[], int>
	|-BaseEntity.ServerRPC<int, object, int>
	|-BaseEntity.ServerRPC<uint, object, int>
	|
	|-RVA: 0x156BB30 Offset: 0x156A130 VA: 0x18156BB30
	|-BaseEntity.ServerRPC<int, int, int>
	|-BaseEntity.ServerRPC<uint, int, int>
	|
	|-RVA: 0x156BB70 Offset: 0x156A170 VA: 0x18156BB70
	|-BaseEntity.ServerRPC<int, int, Ray>
	|
	|-RVA: 0x156D710 Offset: 0x156BD10 VA: 0x18156D710
	|-BaseEntity.ServerRPC<object, object, object>
	|
	|-RVA: 0x156EA70 Offset: 0x156D070 VA: 0x18156EA70
	|-BaseEntity.ServerRPC<uint, byte[], ulong>
	|-BaseEntity.ServerRPC<uint, object, object>
	|-BaseEntity.ServerRPC<uint, object, ulong>
	|
	|-RVA: 0x156E2C0 Offset: 0x156C8C0 VA: 0x18156E2C0
	|-BaseEntity.ServerRPC<uint, int, bool>
	|
	|-RVA: 0x156FA90 Offset: 0x156E090 VA: 0x18156FA90
	|-BaseEntity.ServerRPC<Vector3, Vector3, bool>
	|
	|-RVA: 0x156FF90 Offset: 0x156E590 VA: 0x18156FF90
	|-BaseEntity.ServerRPC<Vector3, Vector3, float>
	*/

	public void ServerRPC<T1, T2>(string funcName, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156C3A0 Offset: 0x156A9A0 VA: 0x18156C3A0
	|-BaseEntity.ServerRPC<int, SprayList>
	|-BaseEntity.ServerRPC<int, byte[]>
	|-BaseEntity.ServerRPC<int, object>
	|-BaseEntity.ServerRPC<int, string>
	|-BaseEntity.ServerRPC<uint, byte[]>
	|-BaseEntity.ServerRPC<uint, object>
	|-BaseEntity.ServerRPC<uint, string>
	|
	|-RVA: 0x156BFC0 Offset: 0x156A5C0 VA: 0x18156BFC0
	|-BaseEntity.ServerRPC<int, int>
	|-BaseEntity.ServerRPC<uint, int>
	|
	|-RVA: 0x156CE70 Offset: 0x156B470 VA: 0x18156CE70
	|-BaseEntity.ServerRPC<object, bool>
	|-BaseEntity.ServerRPC<string, bool>
	|
	|-RVA: 0x156D8F0 Offset: 0x156BEF0 VA: 0x18156D8F0
	|-BaseEntity.ServerRPC<object, object>
	|-BaseEntity.ServerRPC<string, string>
	|-BaseEntity.ServerRPC<ulong, object>
	|-BaseEntity.ServerRPC<ulong, string>
	|
	|-RVA: 0x156F510 Offset: 0x156DB10 VA: 0x18156F510
	|-BaseEntity.ServerRPC<ulong, int>
	|
	|-RVA: 0x156C900 Offset: 0x156AF00 VA: 0x18156C900
	|-BaseEntity.ServerRPC<Ray, int>
	|-BaseEntity.ServerRPC<Ray, uint>
	|
	|-RVA: 0x15704C0 Offset: 0x156EAC0 VA: 0x1815704C0
	|-BaseEntity.ServerRPC<Vector3, Vector3>
	*/

	public void ServerRPC<T1>(string funcName, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156D930 Offset: 0x156BF30 VA: 0x18156D930
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
	|-RVA: 0x156ADA0 Offset: 0x15693A0 VA: 0x18156ADA0
	|-BaseEntity.ServerRPC<bool>
	|
	|-RVA: 0x156C8D0 Offset: 0x156AED0 VA: 0x18156C8D0
	|-BaseEntity.ServerRPC<int>
	|-BaseEntity.ServerRPC<uint>
	|
	|-RVA: 0x156DC60 Offset: 0x156C260 VA: 0x18156DC60
	|-BaseEntity.ServerRPC<float>
	|
	|-RVA: 0x1570700 Offset: 0x156ED00 VA: 0x181570700
	|-BaseEntity.ServerRPC<Vector3>
	*/

	public void ServerRPC(string funcName) { }

	private bool ServerRPCStart(string funcName) { }

	private void ServerRPCWrite<T>(T arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x156A6B0 Offset: 0x1568CB0 VA: 0x18156A6B0
	|-BaseEntity.ServerRPCWrite<bool>
	|-BaseEntity.ServerRPCWrite<byte>
	|-BaseEntity.ServerRPCWrite<sbyte>
	|
	|-RVA: 0x156A790 Offset: 0x1568D90 VA: 0x18156A790
	|-BaseEntity.ServerRPCWrite<int>
	|-BaseEntity.ServerRPCWrite<uint>
	|
	|-RVA: 0x156A880 Offset: 0x1568E80 VA: 0x18156A880
	|-BaseEntity.ServerRPCWrite<object>
	|-BaseEntity.ServerRPCWrite<ulong>
	|
	|-RVA: 0x156A8F0 Offset: 0x1568EF0 VA: 0x18156A8F0
	|-BaseEntity.ServerRPCWrite<float>
	|
	|-RVA: 0x156A720 Offset: 0x1568D20 VA: 0x18156A720
	|-BaseEntity.ServerRPCWrite<Color>
	|
	|-RVA: 0x156A800 Offset: 0x1568E00 VA: 0x18156A800
	|-BaseEntity.ServerRPCWrite<Ray>
	|
	|-RVA: 0x156A960 Offset: 0x1568F60 VA: 0x18156A960
	|-BaseEntity.ServerRPCWrite<Vector3>
	*/

	private void ServerRPCSend(SendInfo sendInfo) { }

	public void ServerRPCList<T1>(string funcName, List<T1> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1569FE0 Offset: 0x15685E0 VA: 0x181569FE0
	|-BaseEntity.ServerRPCList<object>
	*/

	public void ServerRPCList<T1, T2, T3, T4, T5>(string funcName, List<T1> list, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1569C50 Offset: 0x1568250 VA: 0x181569C50
	|-BaseEntity.ServerRPCList<object, object, object, object, object>
	*/

	public void ServerRPCList<T1, T2, T3, T4, T5, T6>(string funcName, List<T1> list, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15698B0 Offset: 0x1567EB0 VA: 0x1815698B0
	|-BaseEntity.ServerRPCList<object, object, object, object, object, object>
	|
	|-RVA: 0x156A300 Offset: 0x1568900 VA: 0x18156A300
	|-BaseEntity.ServerRPCList<Vector3, uint, int, uint, int, int>
	*/

	public void CL_RPCMessage(uint nameID, ulong sourceConnection, Message message) { }

	public void SendSignalBroadcast(BaseEntity.Signal signal, string arg = "") { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SignalFromServerEx(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void SignalFromServer(BaseEntity.RPCMessage msg) { }

	public virtual void OnSignal(BaseEntity.Signal signal, string arg) { }

	private void OnSkinChanged(ulong oldSkinID, ulong newSkinID) { }

	private void OnSkinRefreshStart() { }

	private void OnSkinRefreshEnd() { }

	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public bool HasAnySlot() { }

	public BaseEntity GetSlot(BaseEntity.Slot slot) { }

	public string GetSlotAnchorName(BaseEntity.Slot slot) { }

	public Transform GetSlotAnchor(BaseEntity.Slot slot) { }

	public virtual bool HasSlot(BaseEntity.Slot slot) { }

	public virtual BaseEntity.TraitFlag get_Traits() { }

	public bool HasTrait(BaseEntity.TraitFlag f) { }

	public bool HasAnyTrait(BaseEntity.TraitFlag f) { }

	public virtual bool EnterTrigger(TriggerBase trigger) { }

	public virtual void LeaveTrigger(TriggerBase trigger) { }

	public void RemoveFromTriggers() { }

	public T FindTrigger<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5CA210 Offset: 0x5C8810 VA: 0x1805CA210
	|-BaseEntity.FindTrigger<object>
	|-BaseEntity.FindTrigger<TriggerLadder>
	|-BaseEntity.FindTrigger<TriggerNoSpray>
	*/

	public bool FindTrigger<T>(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D250 Offset: 0x125B850 VA: 0x18125D250
	|-BaseEntity.FindTrigger<object>
	*/

	private void ForceUpdateTriggersAction() { }

	public void ForceUpdateTriggers(bool enter = True, bool exit = True, bool invoke = True) { }

	public virtual void MakeVisible() { }

	protected virtual void UpdateCullingSpheres() { }

	protected virtual void RegisterForCulling() { }

	protected virtual void OnVisibilityChanged(bool visible) { }

	protected virtual void UnregisterFromCulling() { }

	protected virtual void UpdateCullingBounds() { }

	protected virtual bool CheckVisibility() { }

	protected float CalcEntityVisUpdateRate() { }

	protected virtual void DebugDrawCullingBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public float get_Weight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected void set_Weight(float value) { }

	public EntityComponentBase[] get_Components() { }

	public virtual BasePlayer ToPlayer() { }

	public virtual bool get_IsNpc() { }

	public override void InitShared() { }

	public override void DestroyShared() { }

	public override void ResetState() { }

	public virtual float InheritedVelocityScale() { }

	public virtual Vector3 GetInheritedProjectileVelocity() { }

	public virtual Vector3 GetInheritedThrowVelocity() { }

	public virtual Vector3 GetInheritedDropVelocity() { }

	public Vector3 GetParentVelocity() { }

	public Vector3 GetWorldVelocity() { }

	public Vector3 GetLocalVelocity() { }

	public Quaternion GetAngularVelocity() { }

	public virtual OBB WorldSpaceBounds() { }

	public Vector3 PivotPoint() { }

	public Vector3 CenterPoint() { }

	public Vector3 ClosestPoint(Vector3 position) { }

	public virtual Vector3 TriggerPoint() { }

	public float Distance(Vector3 position) { }

	public float SqrDistance(Vector3 position) { }

	public float Distance(BaseEntity other) { }

	public float SqrDistance(BaseEntity other) { }

	public float Distance2D(Vector3 position) { }

	public float SqrDistance2D(Vector3 position) { }

	public float Distance2D(BaseEntity other) { }

	public float SqrDistance2D(BaseEntity other) { }

	public bool IsVisible(Ray ray, int layerMask, float maxDistance) { }

	public bool IsVisibleSpecificLayers(Vector3 position, Vector3 target, int layerMask, float maxDistance = ∞) { }

	public bool IsVisible(Vector3 position, Vector3 target, float maxDistance = ∞) { }

	public bool IsVisible(Vector3 position, float maxDistance = ∞) { }

	public bool IsVisibleAndCanSee(Vector3 position, float maxDistance = ∞) { }

	public bool IsOlderThan(BaseEntity other) { }

	public virtual bool IsOutside() { }

	public bool IsOutside(Vector3 position) { }

	public virtual float WaterFactor() { }

	public virtual float AirFactor() { }

	public bool WaterTestFromVolumes(Vector3 pos, out WaterLevel.WaterInfo info) { }

	public bool IsInWaterVolume(Vector3 pos) { }

	public bool WaterTestFromVolumes(Bounds bounds, out WaterLevel.WaterInfo info) { }

	public bool WaterTestFromVolumes(Vector3 start, Vector3 end, float radius, out WaterLevel.WaterInfo info) { }

	public virtual bool BlocksWaterFor(BasePlayer player) { }

	public virtual float Health() { }

	public virtual float MaxHealth() { }

	public virtual float MaxVelocity() { }

	public virtual float BoundsPadding() { }

	public virtual float PenetrationResistance(HitInfo info) { }

	public virtual GameObjectRef GetImpactEffect(HitInfo info) { }

	public virtual void OnAttacked(HitInfo info) { }

	public virtual Item GetItem() { }

	public virtual Item GetItem(uint itemId) { }

	public virtual void GiveItem(Item item, BaseEntity.GiveItemReason reason = 0) { }

	public virtual bool CanBeLooted(BasePlayer player) { }

	public virtual BaseEntity GetEntity() { }

	public override string ToString() { }

	public virtual string Categorize() { }

	public void Log(string str) { }

	public void SetModel(Model mdl) { }

	public Model GetModel() { }

	public virtual Transform[] GetBones() { }

	public virtual Transform FindBone(string strName) { }

	public virtual uint FindBoneID(Transform boneTransform) { }

	public virtual Transform FindClosestBone(Vector3 worldPos) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public ulong get_OwnerID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_OwnerID(ulong value) { }

	public virtual bool ShouldBlockProjectiles() { }

	public virtual bool ShouldInheritNetworkGroup() { }

	public virtual bool SupportsChildDeployables() { }

	public void BroadcastEntityMessage(string msg, float radius = 20, int layerMask = 1218652417) { }

	public virtual void OnEntityMessage(BaseEntity from, string msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class BaseEntity.Menu : Attribute // TypeDefIndex: 8493
{	public string TitleToken; // 0x10
	public string TitleEnglish; // 0x18
	public string UseVariable; // 0x20
	public int Order; // 0x28
	public string ProxyFunction; // 0x30
	public float Time; // 0x38
	public string OnStart; // 0x40
	public string OnProgress; // 0x48
	public bool LongUseOnly; // 0x50


	public void .ctor() { }

	public void .ctor(string menuTitleToken, string menuTitleEnglish) { }

}

public struct BaseEntity.Menu.Option // TypeDefIndex: 8494
{	public Translate.Phrase name; // 0x0
	public Translate.Phrase description; // 0x8
	public Sprite icon; // 0x10
	public int order; // 0x18
	public bool usableWhileWounded; // 0x1C


	public void CopyTo(ref Option option) { }

}

public class BaseEntity.Menu.Description : Attribute // TypeDefIndex: 8495
{	public string token; // 0x10
	public string english; // 0x18


	public void .ctor(string t, string e) { }

}

public class BaseEntity.Menu.Icon : Attribute // TypeDefIndex: 8496
{	public string icon; // 0x10


	public void .ctor(string i) { }

}

public class BaseEntity.Menu.ShowIf : Attribute // TypeDefIndex: 8497
{	public string functionName; // 0x10


	public void .ctor(string testFunc) { }

}

public class BaseEntity.Menu.UsableWhileWounded : Attribute // TypeDefIndex: 8498
{
	public void .ctor() { }

}

public struct BaseEntity.MovementModify // TypeDefIndex: 8499
{	public float drag; // 0x0

}

public enum BaseEntity.Flags // TypeDefIndex: 8500
{	public int value__; // 0x0
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
{	public readonly FileStorage.Type Type; // 0x0
	public readonly uint NumId; // 0x4
	public readonly uint Crc; // 0x8
	public readonly IServerFileReceiver Receiver; // 0x10
	public readonly float Time; // 0x18


	public void .ctor(FileStorage.Type type, uint numId, uint crc, IServerFileReceiver receiver) { }

	public bool Equals(BaseEntity.ServerFileRequest other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool op_Equality(BaseEntity.ServerFileRequest left, BaseEntity.ServerFileRequest right) { }

	public static bool op_Inequality(BaseEntity.ServerFileRequest left, BaseEntity.ServerFileRequest right) { }

}

public class BaseEntity.Query.EntityTree // TypeDefIndex: 8503
{
public class BaseEntity.Query.EntityTree // TypeDefIndex: 8503
	private Grid<BaseEntity> Grid; // 0x10
	private Grid<BasePlayer> PlayerGrid; // 0x18
	private Grid<BaseEntity> BrainGrid; // 0x20


	public void .ctor(float worldSize) { }

	public void Add(BaseEntity ent) { }

	public void AddPlayer(BasePlayer player) { }

	public void AddBrain(BaseEntity entity) { }

	public void Remove(BaseEntity ent, bool isPlayer = False) { }

	public void RemovePlayer(BasePlayer player) { }

	public void RemoveBrain(BaseEntity entity) { }

	public void Move(BaseEntity ent) { }

	public void MovePlayer(BasePlayer player) { }

	public void MoveBrain(BaseEntity entity) { }

	public int GetInSphere(Vector3 position, float distance, BaseEntity[] results, Func<BaseEntity, bool> filter) { }

	public int GetPlayersInSphere(Vector3 position, float distance, BasePlayer[] results, Func<BasePlayer, bool> filter) { }

	public int GetBrainsInSphere(Vector3 position, float distance, BaseEntity[] results, Func<BaseEntity, bool> filter) { }

}

public class BaseEntity.RPC_Shared : Attribute // TypeDefIndex: 8504
{
	public void .ctor() { }

}

public struct BaseEntity.RPCMessage // TypeDefIndex: 8505
{	public Connection connection; // 0x0
	public BasePlayer player; // 0x8
	public NetRead read; // 0x10

}

public class BaseEntity.RPC_Client : BaseEntity.RPC_Shared // TypeDefIndex: 8506
{
	public void .ctor() { }

}

public enum BaseEntity.Signal // TypeDefIndex: 8507
{	public int value__; // 0x0
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
{	public int value__; // 0x0
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
{	public int value__; // 0x0
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
public enum BaseEntity.GiveItemReason // TypeDefIndex: 8511
	public int value__; // 0x0
	public const BaseEntity.GiveItemReason Generic = 0;
	public const BaseEntity.GiveItemReason ResourceHarvested = 1;
	public const BaseEntity.GiveItemReason PickedUp = 2;
	public const BaseEntity.GiveItemReason Crafted = 3;

}

private sealed class BaseEntity.<>c // TypeDefIndex: 8512
{	public static readonly BaseEntity.<>c <>9; // 0x0
	public static Comparison<Option> <>9__35_0; // 0x8
	public static Predicate<BaseEntity.ServerFileRequest> <>9__93_0; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal int <GetMenuItems>b__35_0(Option x, Option y) { }

	internal bool <RequestFileFromServer>b__93_0(BaseEntity.ServerFileRequest r) { }

}

