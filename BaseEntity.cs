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
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float <Weight>k__BackingField; // 0x100
	[HeaderAttribute] // RVA: 0x9F550 Offset: 0x9E950 VA: 0x18009F550
	public Bounds bounds; // 0x104
	public GameObjectRef impactEffect; // 0x120
	public bool enableSaving; // 0x128
	public bool syncPosition; // 0x129
	public Model model; // 0x130
	[InspectorFlagsAttribute] // RVA: 0x70D50 Offset: 0x70150 VA: 0x180070D50
	public BaseEntity.Flags flags; // 0x138
	public uint parentBone; // 0x13C
	public ulong skinID; // 0x140
	private EntityComponentBase[] _components; // 0x148
	[HideInInspector] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public bool HasBrain; // 0x150
	protected string _name; // 0x158
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
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
	|-BaseEntity.FindLinkedEntity<object>
	*/

	public void EntityLinkMessage<T>(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-BaseEntity.EntityLinkMessage<object>
	*/

	public void EntityLinkBroadcast<T, S>(Action<T> action, Func<S, bool> canTraverseSocket) { }
	/* GenericInstMethod :
	|
	|-BaseEntity.EntityLinkBroadcast<object, object>
	*/

	public void EntityLinkBroadcast<T>(Action<T> action) { }
	/* GenericInstMethod :
	|
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

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
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
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, object>
	|
	|-BaseEntity.ServerRPC<int, int, int, int, byte>
	|
	|-BaseEntity.ServerRPC<int, Color, Color, Color, Color>
	|
	|-BaseEntity.ServerRPC<object, object, object, object, object>
	|
	|-BaseEntity.ServerRPC<uint, byte, uint, uint, bool>
	|
	|-BaseEntity.ServerRPC<uint, int, uint, int, int>
	*/

	public void ServerRPC<T1, T2, T3, T4>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-BaseEntity.ServerRPC<int, int, int, int>
	|
	|-BaseEntity.ServerRPC<int, int, int, float>
	|
	|-BaseEntity.ServerRPC<int, int, object, bool>
	|
	|-BaseEntity.ServerRPC<int, uint, object, bool>
	|
	|-BaseEntity.ServerRPC<object, object, int, object>
	|
	|-BaseEntity.ServerRPC<object, object, object, object>
	|
	|-BaseEntity.ServerRPC<uint, byte, uint, uint>
	|
	|-BaseEntity.ServerRPC<uint, uint, sbyte, int>
	|
	|-BaseEntity.ServerRPC<ulong, uint, uint, object>
	|
	|-BaseEntity.ServerRPC<Vector3, Vector3, int, int>
	|
	|-BaseEntity.ServerRPC<Vector3, Vector3, Vector3, int>
	*/

	public void ServerRPC<T1, T2, T3>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-BaseEntity.ServerRPC<bool, Vector3, uint>
	|
	|-BaseEntity.ServerRPC<int, int, int>
	|
	|-BaseEntity.ServerRPC<int, int, Ray>
	|
	|-BaseEntity.ServerRPC<int, object, int>
	|
	|-BaseEntity.ServerRPC<object, object, object>
	|
	|-BaseEntity.ServerRPC<uint, int, bool>
	|
	|-BaseEntity.ServerRPC<uint, int, int>
	|
	|-BaseEntity.ServerRPC<uint, object, int>
	|
	|-BaseEntity.ServerRPC<uint, object, object>
	|
	|-BaseEntity.ServerRPC<uint, object, ulong>
	|
	|-BaseEntity.ServerRPC<Vector3, Vector3, bool>
	|
	|-BaseEntity.ServerRPC<Vector3, Vector3, float>
	*/

	public void ServerRPC<T1, T2>(SendMethod sendMethod, string funcName, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-BaseEntity.ServerRPC<int, int>
	|
	|-BaseEntity.ServerRPC<int, object>
	|
	|-BaseEntity.ServerRPC<object, bool>
	|
	|-BaseEntity.ServerRPC<object, object>
	|
	|-BaseEntity.ServerRPC<uint, int>
	|
	|-BaseEntity.ServerRPC<uint, object>
	|
	|-BaseEntity.ServerRPC<ulong, int>
	|
	|-BaseEntity.ServerRPC<ulong, object>
	|
	|-BaseEntity.ServerRPC<Ray, int>
	|
	|-BaseEntity.ServerRPC<Ray, uint>
	|
	|-BaseEntity.ServerRPC<Vector3, Vector3>
	*/

	public void ServerRPC<T1>(SendMethod sendMethod, string funcName, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-BaseEntity.ServerRPC<bool>
	|
	|-BaseEntity.ServerRPC<int>
	|
	|-BaseEntity.ServerRPC<object>
	|
	|-BaseEntity.ServerRPC<float>
	|
	|-BaseEntity.ServerRPC<uint>
	|
	|-BaseEntity.ServerRPC<ulong>
	|
	|-BaseEntity.ServerRPC<Vector3>
	*/

	public void ServerRPC(SendMethod sendMethod, string funcName) { }

	public void ServerRPC<T1, T2, T3, T4, T5>(string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, byte[]>
	|-BaseEntity.ServerRPC<byte, byte, uint, uint, object>
	|
	|-BaseEntity.ServerRPC<int, int, int, int, byte>
	|
	|-BaseEntity.ServerRPC<int, Color, Color, Color, Color>
	|
	|-BaseEntity.ServerRPC<object, object, object, object, object>
	|-BaseEntity.ServerRPC<string, string, string, string, string>
	|
	|-BaseEntity.ServerRPC<uint, byte, uint, uint, bool>
	|
	|-BaseEntity.ServerRPC<uint, int, uint, int, int>
	*/

	public void ServerRPC<T1, T2, T3, T4>(string funcName, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-BaseEntity.ServerRPC<int, int, byte[], bool>
	|-BaseEntity.ServerRPC<int, int, object, bool>
	|-BaseEntity.ServerRPC<int, uint, byte[], bool>
	|-BaseEntity.ServerRPC<int, uint, object, bool>
	|
	|-BaseEntity.ServerRPC<int, int, int, int>
	|
	|-BaseEntity.ServerRPC<int, int, int, float>
	|
	|-BaseEntity.ServerRPC<object, object, int, object>
	|-BaseEntity.ServerRPC<string, string, int, string>
	|
	|-BaseEntity.ServerRPC<object, object, object, object>
	|
	|-BaseEntity.ServerRPC<uint, byte, uint, uint>
	|
	|-BaseEntity.ServerRPC<uint, uint, sbyte, int>
	|
	|-BaseEntity.ServerRPC<ulong, uint, uint, byte[]>
	|-BaseEntity.ServerRPC<ulong, uint, uint, object>
	|
	|-BaseEntity.ServerRPC<Vector3, Vector3, int, int>
	|
	|-BaseEntity.ServerRPC<Vector3, Vector3, Vector3, int>
	*/

	public void ServerRPC<T1, T2, T3>(string funcName, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-BaseEntity.ServerRPC<bool, Vector3, uint>
	|
	|-BaseEntity.ServerRPC<int, byte[], int>
	|-BaseEntity.ServerRPC<int, object, int>
	|-BaseEntity.ServerRPC<uint, object, int>
	|
	|-BaseEntity.ServerRPC<int, int, int>
	|-BaseEntity.ServerRPC<uint, int, int>
	|
	|-BaseEntity.ServerRPC<int, int, Ray>
	|
	|-BaseEntity.ServerRPC<object, object, object>
	|
	|-BaseEntity.ServerRPC<uint, byte[], ulong>
	|-BaseEntity.ServerRPC<uint, object, object>
	|-BaseEntity.ServerRPC<uint, object, ulong>
	|
	|-BaseEntity.ServerRPC<uint, int, bool>
	|
	|-BaseEntity.ServerRPC<Vector3, Vector3, bool>
	|
	|-BaseEntity.ServerRPC<Vector3, Vector3, float>
	*/

	public void ServerRPC<T1, T2>(string funcName, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-BaseEntity.ServerRPC<int, SprayList>
	|-BaseEntity.ServerRPC<int, byte[]>
	|-BaseEntity.ServerRPC<int, object>
	|-BaseEntity.ServerRPC<int, string>
	|-BaseEntity.ServerRPC<uint, byte[]>
	|-BaseEntity.ServerRPC<uint, object>
	|-BaseEntity.ServerRPC<uint, string>
	|
	|-BaseEntity.ServerRPC<int, int>
	|-BaseEntity.ServerRPC<uint, int>
	|
	|-BaseEntity.ServerRPC<object, bool>
	|-BaseEntity.ServerRPC<string, bool>
	|
	|-BaseEntity.ServerRPC<object, object>
	|-BaseEntity.ServerRPC<string, string>
	|-BaseEntity.ServerRPC<ulong, object>
	|-BaseEntity.ServerRPC<ulong, string>
	|
	|-BaseEntity.ServerRPC<ulong, int>
	|
	|-BaseEntity.ServerRPC<Ray, int>
	|-BaseEntity.ServerRPC<Ray, uint>
	|
	|-BaseEntity.ServerRPC<Vector3, Vector3>
	*/

	public void ServerRPC<T1>(string funcName, T1 arg1) { }
	/* GenericInstMethod :
	|
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
	|-BaseEntity.ServerRPC<bool>
	|
	|-BaseEntity.ServerRPC<int>
	|-BaseEntity.ServerRPC<uint>
	|
	|-BaseEntity.ServerRPC<float>
	|
	|-BaseEntity.ServerRPC<Vector3>
	*/

	public void ServerRPC(string funcName) { }

	private bool ServerRPCStart(string funcName) { }

	private void ServerRPCWrite<T>(T arg) { }
	/* GenericInstMethod :
	|
	|-BaseEntity.ServerRPCWrite<bool>
	|-BaseEntity.ServerRPCWrite<byte>
	|-BaseEntity.ServerRPCWrite<sbyte>
	|
	|-BaseEntity.ServerRPCWrite<int>
	|-BaseEntity.ServerRPCWrite<uint>
	|
	|-BaseEntity.ServerRPCWrite<object>
	|-BaseEntity.ServerRPCWrite<ulong>
	|
	|-BaseEntity.ServerRPCWrite<float>
	|
	|-BaseEntity.ServerRPCWrite<Color>
	|
	|-BaseEntity.ServerRPCWrite<Ray>
	|
	|-BaseEntity.ServerRPCWrite<Vector3>
	*/

	private void ServerRPCSend(SendInfo sendInfo) { }

	public void ServerRPCList<T1>(string funcName, List<T1> list) { }
	/* GenericInstMethod :
	|
	|-BaseEntity.ServerRPCList<object>
	*/

	public void ServerRPCList<T1, T2, T3, T4, T5>(string funcName, List<T1> list, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-BaseEntity.ServerRPCList<object, object, object, object, object>
	*/

	public void ServerRPCList<T1, T2, T3, T4, T5, T6>(string funcName, List<T1> list, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-BaseEntity.ServerRPCList<object, object, object, object, object, object>
	|
	|-BaseEntity.ServerRPCList<Vector3, uint, int, uint, int, int>
	*/

	public void CL_RPCMessage(uint nameID, ulong sourceConnection, Message message) { }

	public void SendSignalBroadcast(BaseEntity.Signal signal, string arg = "") { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void SignalFromServerEx(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
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
	|-BaseEntity.FindTrigger<object>
	|-BaseEntity.FindTrigger<TriggerLadder>
	|-BaseEntity.FindTrigger<TriggerNoSpray>
	*/

	public bool FindTrigger<T>(out T result) { }
	/* GenericInstMethod :
	|
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

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public float get_Weight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
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

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public ulong get_OwnerID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
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

