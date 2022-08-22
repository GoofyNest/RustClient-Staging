public class AIDesign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6540
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<int> availableStates; // 0x18
	public List<AIStateContainer> stateContainers; // 0x20
	public int defaultStateContainer; // 0x28
	public string description; // 0x30
	public int scope; // 0x38
	public int intialViewStateID; // 0x3C

	// Methods

	// RVA: 0x200B1F0 Offset: 0x20097F0 VA: 0x18200B1F0
	public static void ResetToPool(AIDesign instance) { }

	// RVA: 0x200B480 Offset: 0x2009A80 VA: 0x18200B480
	public void ResetToPool() { }

	// RVA: 0x200B130 Offset: 0x2009730 VA: 0x18200B130 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2009E40 Offset: 0x2008440 VA: 0x182009E40
	public void CopyTo(AIDesign instance) { }

	// RVA: 0x200A070 Offset: 0x2008670 VA: 0x18200A070
	public AIDesign Copy() { }

	// RVA: 0x200AAE0 Offset: 0x20090E0 VA: 0x18200AAE0
	public static AIDesign Deserialize(Stream stream) { }

	// RVA: 0x200A0F0 Offset: 0x20086F0 VA: 0x18200A0F0
	public static AIDesign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x200AA50 Offset: 0x2009050 VA: 0x18200AA50
	public static AIDesign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x200AC60 Offset: 0x2009260 VA: 0x18200AC60
	public static AIDesign Deserialize(byte[] buffer) { }

	// RVA: 0x200B1B0 Offset: 0x20097B0 VA: 0x18200B1B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x200C080 Offset: 0x200A680 VA: 0x18200C080 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x200C0A0 Offset: 0x200A6A0 VA: 0x18200C0A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AIDesign previous) { }

	// RVA: 0x200B1D0 Offset: 0x20097D0 VA: 0x18200B1D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x200AB60 Offset: 0x2009160 VA: 0x18200AB60
	public static AIDesign Deserialize(byte[] buffer, AIDesign instance, bool isDelta = False) { }

	// RVA: 0x200AD80 Offset: 0x2009380 VA: 0x18200AD80
	public static AIDesign Deserialize(Stream stream, AIDesign instance, bool isDelta) { }

	// RVA: 0x200A170 Offset: 0x2008770 VA: 0x18200A170
	public static AIDesign DeserializeLengthDelimited(Stream stream, AIDesign instance, bool isDelta) { }

	// RVA: 0x200A5F0 Offset: 0x2008BF0 VA: 0x18200A5F0
	public static AIDesign DeserializeLength(Stream stream, int length, AIDesign instance, bool isDelta) { }

	// RVA: 0x200B710 Offset: 0x2009D10 VA: 0x18200B710
	public static void SerializeDelta(Stream stream, AIDesign instance, AIDesign previous) { }

	// RVA: 0x200BCE0 Offset: 0x200A2E0 VA: 0x18200BCE0
	public static void Serialize(Stream stream, AIDesign instance) { }

	// RVA: 0x200C070 Offset: 0x200A670 VA: 0x18200C070
	public byte[] ToProtoBytes() { }

	// RVA: 0x200C080 Offset: 0x200A680 VA: 0x18200C080
	public void ToProto(Stream stream) { }

	// RVA: 0x200BBD0 Offset: 0x200A1D0 VA: 0x18200BBD0
	public static byte[] SerializeToBytes(AIDesign instance) { }

	// RVA: 0x200BB20 Offset: 0x200A120 VA: 0x18200BB20
	public static void SerializeLengthDelimited(Stream stream, AIDesign instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AIStateContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6541
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int id; // 0x14
	public int state; // 0x18
	public List<AIEventData> events; // 0x20
	public int inputMemorySlot; // 0x28

	// Methods

	// RVA: 0x2011F00 Offset: 0x2010500 VA: 0x182011F00
	public static void ResetToPool(AIStateContainer instance) { }

	// RVA: 0x2011D10 Offset: 0x2010310 VA: 0x182011D10
	public void ResetToPool() { }

	// RVA: 0x2011C50 Offset: 0x2010250 VA: 0x182011C50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2010670 Offset: 0x200EC70 VA: 0x182010670
	public void CopyTo(AIStateContainer instance) { }

	// RVA: 0x2010820 Offset: 0x200EE20 VA: 0x182010820
	public AIStateContainer Copy() { }

	// RVA: 0x2011230 Offset: 0x200F830 VA: 0x182011230
	public static AIStateContainer Deserialize(Stream stream) { }

	// RVA: 0x2010A10 Offset: 0x200F010 VA: 0x182010A10
	public static AIStateContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2010E30 Offset: 0x200F430 VA: 0x182010E30
	public static AIStateContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2011610 Offset: 0x200FC10 VA: 0x182011610
	public static AIStateContainer Deserialize(byte[] buffer) { }

	// RVA: 0x2011CD0 Offset: 0x20102D0 VA: 0x182011CD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2012860 Offset: 0x2010E60 VA: 0x182012860 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2012880 Offset: 0x2010E80 VA: 0x182012880 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AIStateContainer previous) { }

	// RVA: 0x2011CF0 Offset: 0x20102F0 VA: 0x182011CF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2011510 Offset: 0x200FB10 VA: 0x182011510
	public static AIStateContainer Deserialize(byte[] buffer, AIStateContainer instance, bool isDelta = False) { }

	// RVA: 0x2011990 Offset: 0x200FF90 VA: 0x182011990
	public static AIStateContainer Deserialize(Stream stream, AIStateContainer instance, bool isDelta) { }

	// RVA: 0x2010A90 Offset: 0x200F090 VA: 0x182010A90
	public static AIStateContainer DeserializeLengthDelimited(Stream stream, AIStateContainer instance, bool isDelta) { }

	// RVA: 0x2010EC0 Offset: 0x200F4C0 VA: 0x182010EC0
	public static AIStateContainer DeserializeLength(Stream stream, int length, AIStateContainer instance, bool isDelta) { }

	// RVA: 0x20120F0 Offset: 0x20106F0 VA: 0x1820120F0
	public static void SerializeDelta(Stream stream, AIStateContainer instance, AIStateContainer previous) { }

	// RVA: 0x20125B0 Offset: 0x2010BB0 VA: 0x1820125B0
	public static void Serialize(Stream stream, AIStateContainer instance) { }

	// RVA: 0x2012850 Offset: 0x2010E50 VA: 0x182012850
	public byte[] ToProtoBytes() { }

	// RVA: 0x2012860 Offset: 0x2010E60 VA: 0x182012860
	public void ToProto(Stream stream) { }

	// RVA: 0x20124A0 Offset: 0x2010AA0 VA: 0x1820124A0
	public static byte[] SerializeToBytes(AIStateContainer instance) { }

	// RVA: 0x20123F0 Offset: 0x20109F0 VA: 0x1820123F0
	public static void SerializeLengthDelimited(Stream stream, AIStateContainer instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class AIEventData : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6542
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int eventType; // 0x14
	public int triggerStateContainer; // 0x18
	public bool inverted; // 0x1C
	public int inputMemorySlot; // 0x20
	public int outputMemorySlot; // 0x24
	public int id; // 0x28
	public TimerAIEventData timerData; // 0x30
	public PlayerDetectedAIEventData playerDetectedData; // 0x38
	public HealthBelowAIEventData healthBelowData; // 0x40
	public InRangeAIEventData inRangeData; // 0x48
	public HungerAboveAIEventData hungerAboveData; // 0x50
	public TirednessAboveAIEventData tirednessAboveData; // 0x58
	public ThreatDetectedAIEventData threatDetectedData; // 0x60
	public TargetDetectedAIEventData targetDetectedData; // 0x68
	public AmmoBelowAIEventData ammoBelowData; // 0x70
	public ChanceAIEventData chanceData; // 0x78
	public TimeSinceThreatAIEventData timeSinceThreatData; // 0x80
	public AggressionTimerAIEventData aggressionTimerData; // 0x88
	public InRangeOfHomeAIEventData inRangeOfHomeData; // 0x90

	// Methods

	// RVA: 0x200DFF0 Offset: 0x200C5F0 VA: 0x18200DFF0
	public static void ResetToPool(AIEventData instance) { }

	// RVA: 0x200E3B0 Offset: 0x200C9B0 VA: 0x18200E3B0
	public void ResetToPool() { }

	// RVA: 0x200DF30 Offset: 0x200C530 VA: 0x18200DF30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x200C0C0 Offset: 0x200A6C0 VA: 0x18200C0C0
	public void CopyTo(AIEventData instance) { }

	// RVA: 0x200C4E0 Offset: 0x200AAE0 VA: 0x18200C4E0
	public AIEventData Copy() { }

	// RVA: 0x200D5B0 Offset: 0x200BBB0 VA: 0x18200D5B0
	public static AIEventData Deserialize(Stream stream) { }

	// RVA: 0x200CD10 Offset: 0x200B310 VA: 0x18200CD10
	public static AIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x200D520 Offset: 0x200BB20 VA: 0x18200D520
	public static AIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x200DD10 Offset: 0x200C310 VA: 0x18200DD10
	public static AIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x200DFB0 Offset: 0x200C5B0 VA: 0x18200DFB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2010630 Offset: 0x200EC30 VA: 0x182010630 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2010650 Offset: 0x200EC50 VA: 0x182010650 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AIEventData previous) { }

	// RVA: 0x200DFD0 Offset: 0x200C5D0 VA: 0x18200DFD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x200DE30 Offset: 0x200C430 VA: 0x18200DE30
	public static AIEventData Deserialize(byte[] buffer, AIEventData instance, bool isDelta = False) { }

	// RVA: 0x200D630 Offset: 0x200BC30 VA: 0x18200D630
	public static AIEventData Deserialize(Stream stream, AIEventData instance, bool isDelta) { }

	// RVA: 0x200C560 Offset: 0x200AB60 VA: 0x18200C560
	public static AIEventData DeserializeLengthDelimited(Stream stream, AIEventData instance, bool isDelta) { }

	// RVA: 0x200CD90 Offset: 0x200B390 VA: 0x18200CD90
	public static AIEventData DeserializeLength(Stream stream, int length, AIEventData instance, bool isDelta) { }

	// RVA: 0x200E770 Offset: 0x200CD70 VA: 0x18200E770
	public static void SerializeDelta(Stream stream, AIEventData instance, AIEventData previous) { }

	// RVA: 0x200F840 Offset: 0x200DE40 VA: 0x18200F840
	public static void Serialize(Stream stream, AIEventData instance) { }

	// RVA: 0x2010620 Offset: 0x200EC20 VA: 0x182010620
	public byte[] ToProtoBytes() { }

	// RVA: 0x2010630 Offset: 0x200EC30 VA: 0x182010630
	public void ToProto(Stream stream) { }

	// RVA: 0x200F730 Offset: 0x200DD30 VA: 0x18200F730
	public static byte[] SerializeToBytes(AIEventData instance) { }

	// RVA: 0x200F680 Offset: 0x200DC80 VA: 0x18200F680
	public static void SerializeLengthDelimited(Stream stream, AIEventData instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class NPCTalking : NPCShopKeeper, IConversationProvider // TypeDefIndex: 8425
{	// Fields
	private Option __menuOption_Menu_Talk; // 0x7F0
	public ConversationData[] conversations; // 0x848
	public NPCTalking.NPCConversationResultAction[] conversationResultActions; // 0x850

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x7C4A20 Offset: 0x7C3020 VA: 0x1807C4A20 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7C5990 Offset: 0x7C3F90 VA: 0x1807C5990 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7C4D50 Offset: 0x7C3350 VA: 0x1807C4D50 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7C47F0 Offset: 0x7C2DF0 VA: 0x1807C47F0
	public int GetConversationIndex(string conversationName) { }

	// RVA: 0x7C48B0 Offset: 0x7C2EB0 VA: 0x1807C48B0 Slot: 158
	public virtual string GetConversationStartSpeech(BasePlayer player) { }

	// RVA: 0x7C4960 Offset: 0x7C2F60 VA: 0x1807C4960
	public ConversationData GetConversation(string conversationName) { }

	// RVA: 0x7C4920 Offset: 0x7C2F20 VA: 0x1807C4920
	public ConversationData GetConversation(int index) { }

	// RVA: 0x7C47B0 Offset: 0x7C2DB0 VA: 0x1807C47B0 Slot: 159
	public virtual ConversationData GetConversationFor(BasePlayer player) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60 Slot: 157
	public bool ProviderBusy() { }

	[BaseEntity.Menu] // RVA: 0x7BCB0 Offset: 0x7B0B0 VA: 0x18007BCB0
	[BaseEntity.Menu.Description] // RVA: 0x7BCB0 Offset: 0x7B0B0 VA: 0x18007BCB0
	[BaseEntity.Menu.Icon] // RVA: 0x7BCB0 Offset: 0x7B0B0 VA: 0x18007BCB0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7BCB0 Offset: 0x7B0B0 VA: 0x18007BCB0
	// RVA: 0x7C4D00 Offset: 0x7C3300 VA: 0x1807C4D00
	public void Menu_Talk(BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool Menu_Talk_ShowIf(BasePlayer player) { }

	// RVA: 0x7C4710 Offset: 0x7C2D10 VA: 0x1807C4710 Slot: 155
	public void DoAction(string action) { }

	// RVA: 0x7C48E0 Offset: 0x7C2EE0 VA: 0x1807C48E0 Slot: 156
	public Vector3 GetConversationWorldOrigin() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7C4660 Offset: 0x7C2C60 VA: 0x1807C4660
	public void Client_StartConversation(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7C4760 Offset: 0x7C2D60 VA: 0x1807C4760 Slot: 154
	public void EndConversation(bool fromServer) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7C4590 Offset: 0x7C2B90 VA: 0x1807C4590
	public void Client_ForceSpeechNode(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7C58C0 Offset: 0x7C3EC0 VA: 0x1807C58C0 Slot: 153
	public void ResponsePressed(int index) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7C4580 Offset: 0x7C2B80 VA: 0x1807C4580
	public void Client_EndConversation(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7C41E0 Offset: 0x7C27E0 VA: 0x1807C41E0
	public void .ctor() { }

}

public class NPCTalking.NPCConversationResultAction // TypeDefIndex: 8426
{	// Fields
	public string action; // 0x10
	public int scrapCost; // 0x18
	public string broadcastMessage; // 0x20
	public float broadcastRange; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class NPCVendingOrder : ScriptableObject // TypeDefIndex: 8722
{	// Fields
	public NPCVendingOrder.Entry[] orders; // 0x18

	// Methods

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class NPCVendingOrder.Entry // TypeDefIndex: 8723
{	// Fields
	public ItemDefinition sellItem; // 0x10
	public int sellItemAmount; // 0x18
	public bool sellItemAsBP; // 0x1C
	public ItemDefinition currencyItem; // 0x20
	public int currencyAmount; // 0x28
	public bool currencyAsBP; // 0x2C
	[TooltipAttribute] // RVA: 0x778E0 Offset: 0x76CE0 VA: 0x1800778E0
	public int weight; // 0x30
	public int refillAmount; // 0x34
	public float refillDelay; // 0x38

	// Methods

	// RVA: 0x7B5810 Offset: 0x7B3E10 VA: 0x1807B5810
	public void .ctor() { }

}

public class NPCVendingOrderManifest : ScriptableObject // TypeDefIndex: 8724
{	// Fields
	public NPCVendingOrder[] orderList; // 0x18

	// Methods

	// RVA: 0x7C5AC0 Offset: 0x7C40C0 VA: 0x1807C5AC0
	public int GetIndex(NPCVendingOrder sample) { }

	// RVA: 0x7C5A80 Offset: 0x7C4080 VA: 0x1807C5A80
	public NPCVendingOrder GetFromIndex(int index) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class NPCVendingMachine : VendingMachine // TypeDefIndex: 8725
{	// Fields
	public NPCVendingOrder vendingOrders; // 0x5C8

	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 156
	public override bool ShouldShowAdminPanel() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 158
	protected override bool CanRotate() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 159
	public override bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0x7C5A20 Offset: 0x7C4020 VA: 0x1807C5A20
	public void .ctor() { }

}

public class NPCDwelling : BaseEntity // TypeDefIndex: 8821
{	// Fields
	public NPCSpawner npcSpawner; // 0x168
	public float NPCSpawnChance; // 0x170
	public SpawnGroup[] spawnGroups; // 0x178
	public AIMovePoint[] movePoints; // 0x180
	public AICoverPoint[] coverPoints; // 0x188

	// Methods

	// RVA: 0x7C3DC0 Offset: 0x7C23C0 VA: 0x1807C3DC0
	public void .ctor() { }

}

public class NPCMissionProvider : NPCTalking, IMissionProvider // TypeDefIndex: 8849
{	// Fields
	public MissionManifest manifest; // 0x858

	// Methods

	// RVA: 0x52EEF0 Offset: 0x52D4F0 VA: 0x18052EEF0 Slot: 160
	public uint ProviderID() { }

	// RVA: 0x2FA9E0 Offset: 0x2F8FE0 VA: 0x1802FA9E0 Slot: 161
	public Vector3 ProviderPosition() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 162
	public BaseEntity Entity() { }

	// RVA: 0x7C41E0 Offset: 0x7C27E0 VA: 0x1807C41E0
	public void .ctor() { }

}

public class NPCShopKeeper : NPCPlayer // TypeDefIndex: 8850
{	// Fields
	public EntityRef invisibleVendingMachineRef; // 0x7D8
	public InvisibleVendingMachine machine; // 0x7E8

	// Methods

	// RVA: 0x7C4340 Offset: 0x7C2940 VA: 0x1807C4340
	public InvisibleVendingMachine GetVendingMachine() { }

	// RVA: 0x7C43E0 Offset: 0x7C29E0 VA: 0x1807C43E0
	public void OnDrawGizmos() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 152
	public override void UpdateProtectionFromClothing() { }

	// RVA: 0x7C41E0 Offset: 0x7C27E0 VA: 0x1807C41E0
	public void .ctor() { }

}

public class NPCPlayerCorpse : PlayerCorpse // TypeDefIndex: 8867
{	// Methods

	// RVA: 0x7C42D0 Offset: 0x7C28D0 VA: 0x1807C42D0
	public void .ctor() { }

}

public class AICoverPoint : AIPoint // TypeDefIndex: 8903
{	// Fields
	public float coverDot; // 0x20

	// Methods

	// RVA: 0xA90F90 Offset: 0xA8F590 VA: 0x180A90F90
	public void OnDrawGizmos() { }

	// RVA: 0xA915E0 Offset: 0xA8FBE0 VA: 0x180A915E0
	public void .ctor() { }

}

public class AICoverPointTool : MonoBehaviour // TypeDefIndex: 8904
{	// Methods

	[ContextMenu] // RVA: 0xC1FD0 Offset: 0xC13D0 VA: 0x1800C1FD0
	// RVA: 0xA90540 Offset: 0xA8EB40 VA: 0x180A90540
	public void PlaceCoverPoints() { }

	// RVA: 0xA90C70 Offset: 0xA8F270 VA: 0x180A90C70
	private AICoverPointTool.TestResult TestPoint(Vector3 pos) { }

	// RVA: 0xA90900 Offset: 0xA8EF00 VA: 0x180A90900
	private void PlacePoint(AICoverPointTool.TestResult result) { }

	// RVA: 0xA90B40 Offset: 0xA8F140 VA: 0x180A90B40
	private void PlacePoint(Vector3 pos, Vector3 dir) { }

	// RVA: 0xA90370 Offset: 0xA8E970 VA: 0x180A90370
	public bool HitsCover(Ray ray, int layerMask, float maxDistance) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private struct AICoverPointTool.TestResult // TypeDefIndex: 8905
{	// Fields
	public Vector3 Position; // 0x0
	public bool Valid; // 0xC
	public bool Forward; // 0xD
	public bool Right; // 0xE
	public bool Backward; // 0xF
	public bool Left; // 0x10

}

public class AIInformationCell // TypeDefIndex: 8906
{	// Fields
	public Bounds BoundingBox; // 0x10
	public List<AIInformationCell> NeighbourCells; // 0x28
	public AIInformationCellContents<AIMovePoint> MovePoints; // 0x30
	public AIInformationCellContents<AICoverPoint> CoverPoints; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly int <X>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly int <Z>k__BackingField; // 0x44

	// Properties
	public int X { get; }
	public int Z { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public int get_X() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public int get_Z() { }

	// RVA: 0xA92F70 Offset: 0xA91570 VA: 0x180A92F70
	public void .ctor(Bounds bounds, GameObject root, int x, int z) { }

	// RVA: 0xA92B50 Offset: 0xA91150 VA: 0x180A92B50
	public void DebugDraw(Color color, bool points, float scale = 1) { }

}

public class AIInformationCellContents<T> // TypeDefIndex: 8907
{	// Fields
	public HashSet<T> Items; // 0x0

	// Properties
	public int Count { get; }
	public bool Empty { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5A5F0 Offset: 0xD58BF0 VA: 0x180D5A5F0
	|-AIInformationCellContents<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8D80 Offset: 0x15D7380 VA: 0x1815D8D80
	|-AIInformationCellContents<object>.get_Empty
	*/

	// RVA: -1 Offset: -1
	public void Init(Bounds cellBounds, GameObject root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8B80 Offset: 0x15D7180 VA: 0x1815D8B80
	|-AIInformationCellContents<AICoverPoint>.Init
	|-AIInformationCellContents<AIMovePoint>.Init
	|-AIInformationCellContents<object>.Init
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8B50 Offset: 0x15D7150 VA: 0x1815D8B50
	|-AIInformationCellContents<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8B20 Offset: 0x15D7120 VA: 0x1815D8B20
	|-AIInformationCellContents<object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8CD0 Offset: 0x15D72D0 VA: 0x1815D8CD0
	|-AIInformationCellContents<object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8D00 Offset: 0x15D7300 VA: 0x1815D8D00
	|-AIInformationCellContents<AICoverPoint>..ctor
	|-AIInformationCellContents<AIMovePoint>..ctor
	|-AIInformationCellContents<object>..ctor
	*/

}

public class AIInformationGrid : MonoBehaviour // TypeDefIndex: 8908
{	// Fields
	public int CellSize; // 0x18
	public Bounds BoundingBox; // 0x1C
	public AIInformationCell[] Cells; // 0x38
	private Vector3 origin; // 0x40
	private int xCellCount; // 0x4C
	private int zCellCount; // 0x50
	private const int maxPointResults = 2048;
	private AIMovePoint[] movePointResults; // 0x58
	private AICoverPoint[] coverPointResults; // 0x60
	private const int maxCellResults = 512;
	private AIInformationCell[] resultCells; // 0x68

	// Methods

	[ContextMenu] // RVA: 0xC3790 Offset: 0xC2B90 VA: 0x1800C3790
	// RVA: 0xA93C50 Offset: 0xA92250 VA: 0x180A93C50
	public void Init() { }

	// RVA: 0xA93990 Offset: 0xA91F90 VA: 0x180A93990
	private int GetIndex(int x, int z) { }

	// RVA: 0xA932C0 Offset: 0xA918C0 VA: 0x180A932C0
	public AIInformationCell CellAt(int x, int z) { }

	// RVA: 0xA939A0 Offset: 0xA91FA0 VA: 0x180A939A0
	public AIMovePoint[] GetMovePointsInRange(Vector3 position, float maxRange, out int pointCount) { }

	// RVA: 0xA936E0 Offset: 0xA91CE0 VA: 0x180A936E0
	public AICoverPoint[] GetCoverPointsInRange(Vector3 position, float maxRange, out int pointCount) { }

	// RVA: 0xA934D0 Offset: 0xA91AD0 VA: 0x180A934D0
	public AIInformationCell[] GetCellsInRange(Vector3 position, float maxRange, out int cellCount) { }

	// RVA: 0xA933B0 Offset: 0xA919B0 VA: 0x180A933B0
	public AIInformationCell GetCell(Vector3 position) { }

	// RVA: 0xA93300 Offset: 0xA91900 VA: 0x180A93300
	public void OnDrawGizmos() { }

	// RVA: 0xA93300 Offset: 0xA91900 VA: 0x180A93300
	public void DebugDraw() { }

	// RVA: 0xA94250 Offset: 0xA92850 VA: 0x180A94250
	public void .ctor() { }

}

public class AIInformationGridTester : MonoBehaviour // TypeDefIndex: 8909
{	// Fields
	public AIInformationGrid Grid; // 0x18
	public float Range; // 0x20

	// Methods

	// RVA: 0xA930F0 Offset: 0xA916F0 VA: 0x180A930F0
	public void OnDrawGizmos() { }

	// RVA: 0x4C7F30 Offset: 0x4C6530 VA: 0x1804C7F30
	public void .ctor() { }

}

public class AIInformationZone : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 8910
{	// Fields
	public bool ShouldSleepAI; // 0x18
	public bool Virtual; // 0x19
	public bool UseCalculatedCoverDistances; // 0x1A
	public static List<AIInformationZone> zones; // 0x0
	public List<AICoverPoint> coverPoints; // 0x20
	public List<AIMovePoint> movePoints; // 0x28
	private AICoverPoint[] coverPointArray; // 0x30
	private AIMovePoint[] movePointArray; // 0x38
	public List<NavMeshLink> navMeshLinks; // 0x40
	public List<AIMovePointPath> paths; // 0x48
	public Bounds bounds; // 0x50
	private AIInformationGrid grid; // 0x68

	// Methods

	// RVA: 0xA94350 Offset: 0xA92950 VA: 0x180A94350
	public void .ctor() { }

	// RVA: 0xA942F0 Offset: 0xA928F0 VA: 0x180A942F0
	private static void .cctor() { }

}

public class AIMovePoint : AIPoint // TypeDefIndex: 8911
{	// Fields
	public ListDictionary<AIMovePoint, float> distances; // 0x20
	public ListDictionary<AICoverPoint, float> distancesToCover; // 0x28
	public float radius; // 0x30
	public float WaitTime; // 0x34
	public List<Transform> LookAtPoints; // 0x38

	// Methods

	// RVA: 0xA95350 Offset: 0xA93950 VA: 0x180A95350
	public void OnDrawGizmos() { }

	// RVA: 0xA95020 Offset: 0xA93620 VA: 0x180A95020
	public void DrawLookAtPoints() { }

	// RVA: 0xA95000 Offset: 0xA93600 VA: 0x180A95000
	public void Clear() { }

	// RVA: 0xA94F60 Offset: 0xA93560 VA: 0x180A94F60
	public void AddLookAtPoint(Transform transform) { }

	// RVA: 0xA95310 Offset: 0xA93910 VA: 0x180A95310
	public bool HasLookAtPoints() { }

	// RVA: 0xA952A0 Offset: 0xA938A0 VA: 0x180A952A0
	public Transform GetRandomLookAtPoint() { }

	// RVA: 0xA95400 Offset: 0xA93A00 VA: 0x180A95400
	public void .ctor() { }

}

public class AIMovePoint.DistTo // TypeDefIndex: 8912
{	// Fields
	public float distance; // 0x10
	public AIMovePoint target; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class AIMovePointPath : MonoBehaviour // TypeDefIndex: 8913
{	// Fields
	public Color DebugPathColor; // 0x18
	public AIMovePointPath.Mode LoopMode; // 0x28
	public List<AIMovePoint> Points; // 0x30

	// Methods

	// RVA: 0xA94630 Offset: 0xA92C30 VA: 0x180A94630
	public void Clear() { }

	// RVA: 0xA945D0 Offset: 0xA92BD0 VA: 0x180A945D0
	public void AddPoint(AIMovePoint point) { }

	// RVA: 0xA948A0 Offset: 0xA92EA0 VA: 0x180A948A0
	public AIMovePoint FindNearestPoint(Vector3 position) { }

	// RVA: 0xA94680 Offset: 0xA92C80 VA: 0x180A94680
	public int FindNearestPointIndex(Vector3 position) { }

	// RVA: 0xA94A00 Offset: 0xA93000 VA: 0x180A94A00
	public AIMovePoint GetPointAtIndex(int index) { }

	// RVA: 0xA94930 Offset: 0xA92F30 VA: 0x180A94930
	public int GetNextPointIndex(int currentPointIndex, ref AIMovePointPath.PathDirection pathDirection) { }

	// RVA: 0xA94B70 Offset: 0xA93170 VA: 0x180A94B70
	private void OnDrawGizmos() { }

	// RVA: 0xA94A70 Offset: 0xA93070 VA: 0x180A94A70
	private void OnDrawGizmosSelected() { }

	[ContextMenu] // RVA: 0xC3830 Offset: 0xC2C30 VA: 0x1800C3830
	// RVA: 0xA94530 Offset: 0xA92B30 VA: 0x180A94530
	public void AddChildPoints() { }

	// RVA: 0xA94EE0 Offset: 0xA934E0 VA: 0x180A94EE0
	public void .ctor() { }

}

public enum AIMovePointPath.Mode // TypeDefIndex: 8914
{	// Fields
	public int value__; // 0x0
	public const AIMovePointPath.Mode Loop = 0;
	public const AIMovePointPath.Mode Reverse = 1;

}

public enum AIMovePointPath.PathDirection // TypeDefIndex: 8915
{	// Fields
	public int value__; // 0x0
	public const AIMovePointPath.PathDirection Forwards = 0;
	public const AIMovePointPath.PathDirection Backwards = 1;

}

public class AIPoint : BaseMonoBehaviour // TypeDefIndex: 8916
{	// Fields
	private BaseEntity currentUser; // 0x18

	// Methods

	// RVA: 0xA95630 Offset: 0xA93C30 VA: 0x180A95630
	public bool InUse() { }

	// RVA: 0xA95690 Offset: 0xA93C90 VA: 0x180A95690
	public bool IsUsedBy(BaseEntity user) { }

	// RVA: 0xA954A0 Offset: 0xA93AA0 VA: 0x180A954A0
	public bool CanBeUsedBy(BaseEntity user) { }

	// RVA: 0xA95790 Offset: 0xA93D90 VA: 0x180A95790
	public void SetUsedBy(BaseEntity user, float duration = 5) { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void SetUsedBy(BaseEntity user) { }

	// RVA: 0xA7DF40 Offset: 0xA7C540 VA: 0x180A7DF40
	public void ClearUsed() { }

	// RVA: 0xA955A0 Offset: 0xA93BA0 VA: 0x180A955A0
	public void ClearIfUsedBy(BaseEntity user) { }

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

public class AITraversalArea : TriggerBase // TypeDefIndex: 8917
{	// Fields
	public Transform entryPoint1; // 0x30
	public Transform entryPoint2; // 0x38
	public AITraversalWaitPoint[] waitPoints; // 0x40
	public Bounds movementArea; // 0x48
	public Transform activeEntryPoint; // 0x60
	public float nextFreeTime; // 0x68

	// Methods

	// RVA: 0xA968C0 Offset: 0xA94EC0 VA: 0x180A968C0
	public void OnValidate() { }

	// RVA: 0xA963F0 Offset: 0xA949F0 VA: 0x180A963F0 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0xA95C10 Offset: 0xA94210 VA: 0x180A95C10
	public bool CanTraverse(BaseEntity ent) { }

	// RVA: 0xA95C70 Offset: 0xA94270 VA: 0x180A95C70
	public Transform GetClosestEntry(Vector3 position) { }

	// RVA: 0xA962C0 Offset: 0xA948C0 VA: 0x180A962C0
	public Transform GetFarthestEntry(Vector3 position) { }

	// RVA: 0xA96920 Offset: 0xA94F20 VA: 0x180A96920
	public void SetBusyFor(float dur = 1) { }

	// RVA: 0xA95C10 Offset: 0xA94210 VA: 0x180A95C10
	public bool CanUse(Vector3 dirFrom) { }

	// RVA: 0xA968A0 Offset: 0xA94EA0 VA: 0x180A968A0 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0xA95DA0 Offset: 0xA943A0 VA: 0x180A95DA0
	public AITraversalWaitPoint GetEntryPointNear(Vector3 pos) { }

	// RVA: 0xA95C30 Offset: 0xA94230 VA: 0x180A95C30
	public bool EntityFilter(BaseEntity ent) { }

	// RVA: 0xA968B0 Offset: 0xA94EB0 VA: 0x180A968B0 Slot: 9
	internal override void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0xA964F0 Offset: 0xA94AF0 VA: 0x180A964F0
	public void OnDrawGizmos() { }

	// RVA: 0x4D38B0 Offset: 0x4D1EB0 VA: 0x1804D38B0
	public void .ctor() { }

}

public class AITraversalWaitPoint : MonoBehaviour // TypeDefIndex: 8918
{	// Fields
	public float nextFreeTime; // 0x18

	// Methods

	// RVA: 0xA96950 Offset: 0xA94F50 VA: 0x180A96950
	public bool Occupied() { }

	// RVA: 0xA96970 Offset: 0xA94F70 VA: 0x180A96970
	public void Occupy(float dur = 1) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class AnimalBrain : BaseAIBrain<BaseAnimalNPC> // TypeDefIndex: 8919
{	// Methods

	// RVA: 0x828F80 Offset: 0x827580 VA: 0x180828F80
	public void .ctor() { }

}

public class AnimalRagdoll : Ragdoll // TypeDefIndex: 8926
{	// Fields
	public SkinnedMeshRenderer[] bodyRenderers; // 0x98
	public SkinnedMeshRenderer[] hairRenderers; // 0xA0

	// Methods

	// RVA: 0x829600 Offset: 0x827C00 VA: 0x180829600
	public void .ctor() { }

}

public class AIThinkManager : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 8929
{	// Methods

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

public class ScientistBrain : BaseAIBrain<HumanNPC> // TypeDefIndex: 8933
{	// Methods

	// RVA: 0x4A1070 Offset: 0x49F670 VA: 0x1804A1070
	public void .ctor() { }

}

public class ScientistNPC : HumanNPC, IAIMounted // TypeDefIndex: 8934
{	// Fields
	public GameObjectRef[] RadioChatterEffects; // 0x850
	public GameObjectRef[] DeathEffects; // 0x858
	public string deathStatName; // 0x860
	public Vector2 IdleChatterRepeatRange; // 0x868
	public ScientistNPC.RadioChatterType radioChatterType; // 0x870

	// Methods

	// RVA: 0x4A10B0 Offset: 0x49F6B0 VA: 0x1804A10B0
	public void .ctor() { }

}

public enum ScientistNPC.RadioChatterType // TypeDefIndex: 8935
{	// Fields
	public int value__; // 0x0
	public const ScientistNPC.RadioChatterType NONE = 0;
	public const ScientistNPC.RadioChatterType Idle = 1;
	public const ScientistNPC.RadioChatterType Alert = 2;

}

public class NPCPlayer : BasePlayer // TypeDefIndex: 8938
{	// Fields
	public AIInformationZone VirtualInfoZone; // 0x788
	public Vector3 finalDestination; // 0x790
	private float randomOffset; // 0x79C
	private Vector3 spawnPos; // 0x7A0
	public PlayerInventoryProperties[] loadouts; // 0x7B0
	public LayerMask movementMask; // 0x7B8
	public bool LegacyNavigation; // 0x7BC
	public NavMeshAgent NavAgent; // 0x7C0
	public float damageScale; // 0x7C8
	public float shortRange; // 0x7CC
	public float attackLengthMaxShortRangeScale; // 0x7D0

	// Properties
	public override bool IsNpc { get; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 98
	public override bool get_IsNpc() { }

	// RVA: 0x7C41E0 Offset: 0x7C27E0 VA: 0x1807C41E0
	public void .ctor() { }

}

public class NPCNavigator : BaseNavigator // TypeDefIndex: 8953
{	// Methods

	// RVA: 0x7C4270 Offset: 0x7C2870 VA: 0x1807C4270
	public void .ctor() { }

}

public class NPCPlayerNavigator : BaseNavigator // TypeDefIndex: 8954
{	// Methods

	// RVA: 0x7C42E0 Offset: 0x7C28E0 VA: 0x1807C42E0
	public void .ctor() { }

}

public class NPCPlayerNavigatorTester : BaseMonoBehaviour // TypeDefIndex: 8955
{	// Fields
	public BasePathNode TargetNode; // 0x18
	private BasePathNode currentNode; // 0x20

	// Methods

	// RVA: 0x521BF0 Offset: 0x5201F0 VA: 0x180521BF0
	public void .ctor() { }

}

public enum AIState // TypeDefIndex: 8964
{	// Fields
	public int value__; // 0x0
	public const AIState None = 0;
	public const AIState Idle = 1;
	public const AIState Roam = 2;
	public const AIState Chase = 3;
	public const AIState Cover = 4;
	public const AIState Combat = 5;
	public const AIState Mounted = 6;
	public const AIState Exfil = 7;
	public const AIState Patrol = 8;
	public const AIState Orbit = 9;
	public const AIState Egress = 10;
	public const AIState Land = 11;
	public const AIState DropCrate = 12;
	public const AIState MoveTowards = 13;
	public const AIState Flee = 14;
	public const AIState Attack = 15;
	public const AIState Sleep = 16;
	public const AIState Reload = 17;
	public const AIState TakeCover = 18;
	public const AIState Dismounted = 19;
	public const AIState FollowPath = 20;
	public const AIState NavigateHome = 21;
	public const AIState CombatStationary = 22;
	public const AIState Cooldown = 23;
	public const AIState MoveToPoint = 24;

}

public enum AIThinkMode // TypeDefIndex: 8965
{	// Fields
	public int value__; // 0x0
	public const AIThinkMode FixedUpdate = 0;
	public const AIThinkMode Interval = 1;

}

public class AimConeUtil // TypeDefIndex: 8968
{	// Methods

	// RVA: 0xAA2B10 Offset: 0xAA1110 VA: 0x180AA2B10
	public static Vector3 GetModifiedAimConeDirection(float aimCone, Vector3 inputVec, bool anywhereInside = True) { }

	// RVA: 0xAA2A50 Offset: 0xAA1050 VA: 0x180AA2A50
	public static Quaternion GetAimConeQuat(float aimCone) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class AnimalSkin : MonoBehaviour, IClientComponent // TypeDefIndex: 9111
{	// Fields
	public SkinnedMeshRenderer[] animalMesh; // 0x18
	public AnimalMultiSkin[] animalSkins; // 0x20
	private Model model; // 0x28
	public bool dontRandomizeOnStart; // 0x30

	// Methods

	// RVA: 0x829840 Offset: 0x827E40 VA: 0x180829840
	private void Start() { }

	// RVA: 0x829610 Offset: 0x827C10 VA: 0x180829610
	public void ChangeSkin(int iSkin) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class AnimalMultiSkin // TypeDefIndex: 9112
{	// Fields
	public Material[] multiSkin; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class AnimalAnimation : MonoBehaviour, IClientComponent // TypeDefIndex: 9113
{	// Fields
	public BaseEntity Entity; // 0x18
	public BaseNpc Target; // 0x20
	public Animator Animator; // 0x28
	public MaterialEffect FootstepEffects; // 0x30
	public Transform[] Feet; // 0x38
	public SoundDefinition saddleMovementSoundDef; // 0x40
	public SoundDefinition saddleMovementSoundDefWood; // 0x48
	public SoundDefinition saddleMovementSoundDefRoadsign; // 0x50
	public AnimationCurve saddleMovementGainCurve; // 0x58
	[ReadOnlyAttribute] // RVA: 0x70BD0 Offset: 0x6FFD0 VA: 0x180070BD0
	public string BaseFolder; // 0x60
	public const BaseEntity.Flags Flag_WoodArmor = 2048;
	public const BaseEntity.Flags Flag_RoadsignArmor = 16384;
	private float lastThinkTime; // 0x68
	private Vector3 previousPosition; // 0x6C
	private float previousRotationYaw; // 0x78
	private bool wasSleeping; // 0x7C

	// Methods

	// RVA: 0x828E50 Offset: 0x827450 VA: 0x180828E50
	private void Update() { }

	// RVA: 0x828D50 Offset: 0x827350 VA: 0x180828D50
	public bool ShouldPlayFootstep(AnimationEvent evt) { }

	// RVA: 0x828760 Offset: 0x826D60 VA: 0x180828760
	private void FrontLeftFootstep(AnimationEvent evt) { }

	// RVA: 0x8287C0 Offset: 0x826DC0 VA: 0x1808287C0
	private void FrontRightFootstep(AnimationEvent evt) { }

	// RVA: 0x828440 Offset: 0x826A40 VA: 0x180828440
	private void BackLeftFootstep(AnimationEvent evt) { }

	// RVA: 0x8284A0 Offset: 0x826AA0 VA: 0x1808284A0
	private void BackRightFootstep(AnimationEvent evt) { }

	// RVA: 0x828500 Offset: 0x826B00 VA: 0x180828500
	private void Footstep(Transform tx) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void DoEffect(string effect) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void PlayEffect(string effect) { }

	// RVA: 0x828B60 Offset: 0x827160 VA: 0x180828B60
	public void PlaySound(string soundName) { }

	// RVA: 0x828B10 Offset: 0x827110 VA: 0x180828B10
	public void PlaySoundDef(SoundDefinition def) { }

	// RVA: 0x828820 Offset: 0x826E20 VA: 0x180828820
	private void PlaySaddleMovementSound() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class AnimalFootIK : MonoBehaviour // TypeDefIndex: 9115
{	// Fields
	public Transform[] Feet; // 0x18
	public Animator animator; // 0x20
	public float maxWeightDistance; // 0x28
	public float minWeightDistance; // 0x2C
	public float actualFootOffset; // 0x30

	// Methods

	// RVA: 0x828FF0 Offset: 0x8275F0 VA: 0x180828FF0
	public bool GroundSample(Vector3 origin, out RaycastHit hit) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Start() { }

	// RVA: 0x828FC0 Offset: 0x8275C0 VA: 0x180828FC0
	public AvatarIKGoal GoalFromIndex(int index) { }

	// RVA: 0x829120 Offset: 0x827720 VA: 0x180829120
	private void OnAnimatorIK(int layerIndex) { }

	// RVA: 0x8295E0 Offset: 0x827BE0 VA: 0x1808295E0
	public void .ctor() { }

}

public class NPCFootstepEffects : BaseFootstepEffect // TypeDefIndex: 9355
{	// Fields
	public string impactEffectDirectory; // 0x30
	public Transform frontLeftFoot; // 0x38
	public Transform frontRightFoot; // 0x40
	public Transform backLeftFoot; // 0x48
	public Transform backRightFoot; // 0x50

	// Methods

	// RVA: 0x7C4060 Offset: 0x7C2660 VA: 0x1807C4060
	private void FrontLeftFootstep() { }

	// RVA: 0x7C40B0 Offset: 0x7C26B0 VA: 0x1807C40B0
	private void FrontRightFootstep() { }

	// RVA: 0x7C3E20 Offset: 0x7C2420 VA: 0x1807C3E20
	private void BackLeftFootstep() { }

	// RVA: 0x7C3E70 Offset: 0x7C2470 VA: 0x1807C3E70
	private void BackRightFootstep() { }

	// RVA: 0x7C3EC0 Offset: 0x7C24C0 VA: 0x1807C3EC0
	private void Footstep(Vector3 vFootPos) { }

	// RVA: 0x7C4100 Offset: 0x7C2700 VA: 0x1807C4100
	private void SetupFootstep(GameObject effect) { }

	// RVA: 0x7C4190 Offset: 0x7C2790 VA: 0x1807C4190
	public void .ctor() { }

}

public class AIBrainSenses // TypeDefIndex: 9377
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class AIDesignSO : BaseScriptableObject // TypeDefIndex: 9378
{	// Fields
	public string Filename; // 0x20

	// Methods

	// RVA: 0x6A7B40 Offset: 0x6A6140 VA: 0x1806A7B40
	public void .ctor() { }

}

public class AIDesign // TypeDefIndex: 9379
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AIDesignScope <Scope>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Description>k__BackingField; // 0x18
	public List<AIState> AvailableStates; // 0x20
	public int DefaultStateContainerID; // 0x28
	private Dictionary<int, AIStateContainer> stateContainers; // 0x30

	// Properties
	public AIDesignScope Scope { get; set; }
	public string Description { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public AIDesignScope get_Scope() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	private void set_Scope(AIDesignScope value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_Description(string value) { }

	// RVA: 0xA91900 Offset: 0xA8FF00 VA: 0x180A91900
	public void SetAvailableStates(List<AIState> states) { }

	// RVA: 0xA918A0 Offset: 0xA8FEA0 VA: 0x180A918A0
	public void Load(AIDesign design, BaseEntity owner) { }

	// RVA: 0xA916F0 Offset: 0xA8FCF0 VA: 0x180A916F0
	private void InitStateContainers(AIDesign design, BaseEntity owner) { }

	// RVA: 0xA915F0 Offset: 0xA8FBF0 VA: 0x180A915F0
	public AIStateContainer GetDefaultStateContainer() { }

	// RVA: 0xA91670 Offset: 0xA8FC70 VA: 0x180A91670
	public AIStateContainer GetStateContainerByID(int id) { }

	// RVA: 0xA91990 Offset: 0xA8FF90 VA: 0x180A91990
	public AIDesign ToProto(int currentStateID) { }

	// RVA: 0xA91CC0 Offset: 0xA902C0 VA: 0x180A91CC0
	public void .ctor() { }

}

public static class AIDesigns // TypeDefIndex: 9380
{	// Fields
	public const string DesignFolderPath = "cfg/ai/";
	private static Dictionary<string, AIDesign> designs; // 0x1D4C

	// Methods

	// RVA: 0xA91D60 Offset: 0xA90360 VA: 0x180A91D60
	public static AIDesign GetByNameOrInstance(string designName, AIDesign entityDesign) { }

	// RVA: 0xA92050 Offset: 0xA90650 VA: 0x180A92050
	public static void RefreshCache(string designName, AIDesign design) { }

	// RVA: 0xA91E20 Offset: 0xA90420 VA: 0x180A91E20
	private static AIDesign GetByName(string designName) { }

	// RVA: 0xA92120 Offset: 0xA90720 VA: 0x180A92120
	private static void .cctor() { }

}

public enum AIEventType // TypeDefIndex: 9381
{	// Fields
	public int value__; // 0x0
	public const AIEventType Timer = 0;
	public const AIEventType PlayerDetected = 1;
	public const AIEventType StateError = 2;
	public const AIEventType Attacked = 3;
	public const AIEventType StateFinished = 4;
	public const AIEventType InAttackRange = 5;
	public const AIEventType HealthBelow = 6;
	public const AIEventType InRange = 7;
	public const AIEventType PerformedAttack = 8;
	public const AIEventType TirednessAbove = 9;
	public const AIEventType HungerAbove = 10;
	public const AIEventType ThreatDetected = 11;
	public const AIEventType TargetDetected = 12;
	public const AIEventType AmmoBelow = 13;
	public const AIEventType BestTargetDetected = 14;
	public const AIEventType IsVisible = 15;
	public const AIEventType AttackTick = 16;
	public const AIEventType IsMounted = 17;
	public const AIEventType And = 18;
	public const AIEventType Chance = 19;
	public const AIEventType TargetLost = 20;
	public const AIEventType TimeSinceThreat = 21;
	public const AIEventType OnPositionMemorySet = 22;
	public const AIEventType AggressionTimer = 23;
	public const AIEventType Reloading = 24;
	public const AIEventType InRangeOfHome = 25;

}

public class AIEvents // TypeDefIndex: 9382
{	// Fields
	public AIMemory Memory; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <CurrentInputMemorySlot>k__BackingField; // 0x18
	private List<BaseAIEvent> events; // 0x20
	private IAIEventListener eventListener; // 0x28
	private AIBrainSenses senses; // 0x30
	private int currentEventIndex; // 0x38
	private bool inBlock; // 0x3C

	// Properties
	public int CurrentInputMemorySlot { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_CurrentInputMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D90 Offset: 0x7CF390 VA: 0x1807D0D90
	private void set_CurrentInputMemorySlot(int value) { }

	// RVA: 0xA92570 Offset: 0xA90B70 VA: 0x180A92570
	public void Init(IAIEventListener listener, AIStateContainer stateContainer, BaseEntity owner, AIBrainSenses senses) { }

	// RVA: 0xA92660 Offset: 0xA90C60 VA: 0x180A92660
	private void RemoveAll() { }

	// RVA: 0xA92180 Offset: 0xA90780 VA: 0x180A92180
	private void AddStateEvents(List<BaseAIEvent> events, BaseEntity owner) { }

	// RVA: 0xA92380 Offset: 0xA90980 VA: 0x180A92380
	private void Add(BaseAIEvent aiEvent) { }

	// RVA: 0xA926B0 Offset: 0xA90CB0 VA: 0x180A926B0
	public void Tick(float deltaTime, StateStatus stateStatus) { }

	// RVA: 0xA92480 Offset: 0xA90A80 VA: 0x180A92480
	private int FindNextEventBlock() { }

	// RVA: 0xA92970 Offset: 0xA90F70 VA: 0x180A92970
	public void .ctor() { }

}

public class AIMemory // TypeDefIndex: 9383
{	// Fields
	public AIMemoryBank<BaseEntity> Entity; // 0x10
	public AIMemoryBank<Vector3> Position; // 0x18
	public AIMemoryBank<AIPoint> AIPoint; // 0x20

	// Methods

	// RVA: 0xA94450 Offset: 0xA92A50 VA: 0x180A94450
	public void .ctor() { }

}

public class AIMemoryBank<T> // TypeDefIndex: 9388
{	// Fields
	private MemoryBankType type; // 0x0
	private T[] slots; // 0x0
	private float[] slotSetTimestamps; // 0x0
	private int slotCount; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(MemoryBankType type, int slots) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D9240 Offset: 0x15D7840 VA: 0x1815D9240
	|-AIMemoryBank<AIPoint>..ctor
	|-AIMemoryBank<BaseEntity>..ctor
	|-AIMemoryBank<object>..ctor
	|-AIMemoryBank<Vector3>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Init(MemoryBankType type, int slots) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8EF0 Offset: 0x15D74F0 VA: 0x1815D8EF0
	|-AIMemoryBank<object>.Init
	|
	|-RVA: 0x15D8FA0 Offset: 0x15D75A0 VA: 0x1815D8FA0
	|-AIMemoryBank<Vector3>.Init
	*/

	// RVA: -1 Offset: -1
	public void Set(T item, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D9110 Offset: 0x15D7710 VA: 0x1815D9110
	|-AIMemoryBank<BaseEntity>.Set
	|-AIMemoryBank<object>.Set
	|
	|-RVA: 0x15D91A0 Offset: 0x15D77A0 VA: 0x1815D91A0
	|-AIMemoryBank<Vector3>.Set
	*/

	// RVA: -1 Offset: -1
	public T Get(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8E20 Offset: 0x15D7420 VA: 0x1815D8E20
	|-AIMemoryBank<BaseEntity>.Get
	|-AIMemoryBank<object>.Get
	|
	|-RVA: 0x15D8E70 Offset: 0x15D7470 VA: 0x1815D8E70
	|-AIMemoryBank<Vector3>.Get
	*/

	// RVA: -1 Offset: -1
	public float GetTimeSinceSet(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8DB0 Offset: 0x15D73B0 VA: 0x1815D8DB0
	|-AIMemoryBank<object>.GetTimeSinceSet
	|-AIMemoryBank<Vector3>.GetTimeSinceSet
	*/

	// RVA: -1 Offset: -1
	public void Remove(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D9050 Offset: 0x15D7650 VA: 0x1815D9050
	|-AIMemoryBank<object>.Remove
	|
	|-RVA: 0x15D90B0 Offset: 0x15D76B0 VA: 0x1815D90B0
	|-AIMemoryBank<Vector3>.Remove
	*/

}

public class AIStateContainer // TypeDefIndex: 9422
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <ID>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AIState <State>k__BackingField; // 0x14
	public List<BaseAIEvent> Events; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <InputMemorySlot>k__BackingField; // 0x20

	// Properties
	public int ID { get; set; }
	public AIState State { get; set; }
	public int InputMemorySlot { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	private void set_ID(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public AIState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C9F0 Offset: 0x57AFF0 VA: 0x18057C9F0
	private void set_State(AIState value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_InputMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D730 Offset: 0x69BD30 VA: 0x18069D730
	private void set_InputMemorySlot(int value) { }

	// RVA: 0xA95850 Offset: 0xA93E50 VA: 0x180A95850
	public void Init(AIStateContainer container, BaseEntity owner) { }

	// RVA: 0xA95A40 Offset: 0xA94040 VA: 0x180A95A40
	public AIStateContainer ToProto() { }

	// RVA: 0xA95C00 Offset: 0xA94200 VA: 0x180A95C00
	public void .ctor() { }

}

public enum AIDesignScope // TypeDefIndex: 9425
{	// Fields
	public int value__; // 0x0
	public const AIDesignScope Default = 0;
	public const AIDesignScope EntityServerWide = 1;
	public const AIDesignScope EntityInstance = 2;

}

public class NPCAutoTurret : AutoTurret // TypeDefIndex: 9577
{	// Fields
	public Transform centerMuzzle; // 0x768
	public Transform muzzleLeft; // 0x770
	public Transform muzzleRight; // 0x778
	private bool useLeftMuzzle; // 0x780

	// Methods

	// RVA: 0x7C3DB0 Offset: 0x7C23B0 VA: 0x1807C3DB0
	public void .ctor() { }

}

public class AIHelicopterAnimation : MonoBehaviour // TypeDefIndex: 9598
{	// Fields
	public PatrolHelicopterAI _ai; // 0x18
	public float swayAmount; // 0x20
	public float lastStrafeScalar; // 0x24
	public float lastForwardBackScalar; // 0x28
	public float degreeMax; // 0x2C
	public Vector3 lastPosition; // 0x30
	public float oldMoveSpeed; // 0x3C
	public float smoothRateOfChange; // 0x40
	public float flareAmount; // 0x44

	// Methods

	// RVA: 0xA92AD0 Offset: 0xA910D0 VA: 0x180A92AD0
	public void .ctor() { }

}

public class NPCSpawner : SpawnGroup // TypeDefIndex: 10004
{	// Fields
	public int AdditionalLOSBlockingLayer; // 0x48
	public MonumentNavMesh monumentNavMesh; // 0x50
	public bool shouldFillOnSpawn; // 0x58
	[HeaderAttribute] // RVA: 0xAD190 Offset: 0xAC590 VA: 0x1800AD190
	public AIInformationZone VirtualInfoZone; // 0x60
	[HeaderAttribute] // RVA: 0xAE5E0 Offset: 0xAD9E0 VA: 0x1800AE5E0
	public AIMovePointPath Path; // 0x68
	public BasePath AStarGraph; // 0x70
	[HeaderAttribute] // RVA: 0xAFD40 Offset: 0xAF140 VA: 0x1800AFD40
	public bool UseStatModifiers; // 0x78
	public float SenseRange; // 0x7C
	public float TargetLostRange; // 0x80
	public float AttackRangeMultiplier; // 0x84
	public float ListenRange; // 0x88
	public float CanUseHealingItemsChance; // 0x8C
	[HeaderAttribute] // RVA: 0xAFDE0 Offset: 0xAF1E0 VA: 0x1800AFDE0
	public PlayerInventoryProperties[] Loadouts; // 0x90

	// Methods

	// RVA: 0x7C4550 Offset: 0x7C2B50 VA: 0x1807C4550
	public void .ctor() { }

}

public class AI : ConsoleSystem // TypeDefIndex: 11880
{	// Fields
	[ReplicatedVar] // RVA: 0x85960 Offset: 0x84D60 VA: 0x180085960
	public static bool allowdesigning; // 0x0
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool designing; // 0x1
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool groundAlign; // 0x2
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static float maxGroundAlignDist; // 0x4
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool debugVis; // 0x8
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static bool npc_no_foot_ik; // 0x9
	private static HitTest lookingAtNpcCache; // 0x10

	// Methods

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x6C96C0 Offset: 0x6C7CC0 VA: 0x1806C96C0
	public static void aiDebug_lookat(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x6C9500 Offset: 0x6C7B00 VA: 0x1806C9500
	public static void aiDebug_LoadBalanceOverdueReport(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void selectNPCLookat(ConsoleSystem.Arg args) { }

	// RVA: 0x6C9120 Offset: 0x6C7720 VA: 0x1806C9120
	private static bool CheckLookingAtVisible(HitTest test, TraceInfo trace) { }

	// RVA: 0x6C94A0 Offset: 0x6C7AA0 VA: 0x1806C94A0
	public void .ctor() { }

	// RVA: 0x6C9400 Offset: 0x6C7A00 VA: 0x1806C9400
	private static void .cctor() { }

}

public class AiManagedAgent : FacepunchBehaviour, IServerComponent // TypeDefIndex: 12133
{	// Fields
	[TooltipAttribute] // RVA: 0xE0380 Offset: 0xDF780 VA: 0x1800E0380
	public int AgentTypeIndex; // 0x18

	// Methods

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

public class AiManager : SingletonComponent<AiManager>, IServerComponent // TypeDefIndex: 12134
{	// Fields
	[HeaderAttribute] // RVA: 0xE0590 Offset: 0xDF990 VA: 0x1800E0590
	[SerializeField] // RVA: 0xE0590 Offset: 0xDF990 VA: 0x1800E0590
	public bool UseCover; // 0x18
	public float CoverPointVolumeCellSize; // 0x1C
	public float CoverPointVolumeCellHeight; // 0x20
	public float CoverPointRayLength; // 0x24
	public CoverPointVolume cpvPrefab; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public LayerMask DynamicCoverPointVolumeLayerMask; // 0x30
	private WorldSpaceGrid<CoverPointVolume> coverPointVolumeGrid; // 0x38

	// Methods

	// RVA: 0x4BB030 Offset: 0x4B9630 VA: 0x1804BB030
	internal void OnEnableCover() { }

	// RVA: 0x4BAF50 Offset: 0x4B9550 VA: 0x1804BAF50
	internal void OnDisableCover() { }

	// RVA: 0x4BAEC0 Offset: 0x4B94C0 VA: 0x1804BAEC0
	public CoverPointVolume GetCoverVolumeContaining(Vector3 point) { }

	// RVA: 0x4BB0F0 Offset: 0x4B96F0 VA: 0x1804BB0F0
	public void .ctor() { }

}

public class ScientistSpawner : SpawnGroup // TypeDefIndex: 12136
{	// Fields
	[HeaderAttribute] // RVA: 0xE0A50 Offset: 0xDFE50 VA: 0x1800E0A50
	public bool Mobile; // 0x48
	public bool NeverMove; // 0x49
	public bool SpawnHostile; // 0x4A
	public bool OnlyAggroMarkedTargets; // 0x4B
	public bool IsPeacekeeper; // 0x4C
	public bool IsBandit; // 0x4D
	public bool IsMilitaryTunnelLab; // 0x4E
	public WaypointSet Waypoints; // 0x50
	public Transform[] LookAtInterestPointsStationary; // 0x58
	public Vector2 RadioEffectRepeatRange; // 0x60
	public Model Model; // 0x68
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private AiLocationManager _mgr; // 0x70

	// Methods

	// RVA: 0x4C8A40 Offset: 0x4C7040 VA: 0x1804C8A40
	public void .ctor() { }

}

public class AiLocationManager : FacepunchBehaviour, IServerComponent // TypeDefIndex: 12137
{	// Fields
	public static List<AiLocationManager> Managers; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public AiLocationSpawner MainSpawner; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public AiLocationSpawner.SquadSpawnerLocation LocationWhenMainSpawnerIsNull; // 0x20
	public Transform CoverPointGroup; // 0x28
	public Transform PatrolPointGroup; // 0x30
	public CoverPointVolume DynamicCoverPointVolume; // 0x38
	public bool SnapCoverPointsToGround; // 0x40

	// Properties
	public AiLocationSpawner.SquadSpawnerLocation LocationType { get; }

	// Methods

	// RVA: 0x4BAE00 Offset: 0x4B9400 VA: 0x1804BAE00
	public AiLocationSpawner.SquadSpawnerLocation get_LocationType() { }

	// RVA: 0x4BADF0 Offset: 0x4B93F0 VA: 0x1804BADF0
	public void .ctor() { }

	// RVA: 0x4BAD90 Offset: 0x4B9390 VA: 0x1804BAD90
	private static void .cctor() { }

}

public class AiLocationSpawner : SpawnGroup // TypeDefIndex: 12138
{	// Fields
	public AiLocationSpawner.SquadSpawnerLocation Location; // 0x48
	public AiLocationManager Manager; // 0x50
	public JunkPile Junkpile; // 0x58
	public bool IsMainSpawner; // 0x60
	public float chance; // 0x64
	private int defaultMaxPopulation; // 0x68
	private int defaultNumToSpawnPerTickMax; // 0x6C
	private int defaultNumToSpawnPerTickMin; // 0x70

	// Methods

	// RVA: 0x4BAE90 Offset: 0x4B9490 VA: 0x1804BAE90
	public void .ctor() { }

}

public enum AiLocationSpawner.SquadSpawnerLocation // TypeDefIndex: 12139
{	// Fields
	public int value__; // 0x0
	public const AiLocationSpawner.SquadSpawnerLocation MilitaryTunnels = 0;
	public const AiLocationSpawner.SquadSpawnerLocation JunkpileA = 1;
	public const AiLocationSpawner.SquadSpawnerLocation JunkpileG = 2;
	public const AiLocationSpawner.SquadSpawnerLocation CH47 = 3;
	public const AiLocationSpawner.SquadSpawnerLocation None = 4;
	public const AiLocationSpawner.SquadSpawnerLocation Compound = 5;
	public const AiLocationSpawner.SquadSpawnerLocation BanditTown = 6;
	public const AiLocationSpawner.SquadSpawnerLocation CargoShip = 7;

}

public class ScientistJunkpileSpawner : MonoBehaviour, IServerComponent // TypeDefIndex: 12143
{	// Fields
	public GameObjectRef ScientistPrefab; // 0x18
	public List<BaseCombatEntity> Spawned; // 0x20
	public BaseSpawnPoint[] SpawnPoints; // 0x28
	public int MaxPopulation; // 0x30
	public bool InitialSpawn; // 0x34
	public float MinRespawnTimeMinutes; // 0x38
	public float MaxRespawnTimeMinutes; // 0x3C
	public float MovementRadius; // 0x40
	public bool ReducedLongRangeAccuracy; // 0x44
	public ScientistJunkpileSpawner.JunkpileType SpawnType; // 0x48
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float SpawnBaseChance; // 0x4C

	// Methods

	// RVA: 0x4C89B0 Offset: 0x4C6FB0 VA: 0x1804C89B0
	public void .ctor() { }

}

public enum ScientistJunkpileSpawner.JunkpileType // TypeDefIndex: 12144
{	// Fields
	public int value__; // 0x0
	public const ScientistJunkpileSpawner.JunkpileType A = 0;
	public const ScientistJunkpileSpawner.JunkpileType B = 1;
	public const ScientistJunkpileSpawner.JunkpileType C = 2;
	public const ScientistJunkpileSpawner.JunkpileType D = 3;
	public const ScientistJunkpileSpawner.JunkpileType E = 4;
	public const ScientistJunkpileSpawner.JunkpileType F = 5;
	public const ScientistJunkpileSpawner.JunkpileType G = 6;

}

