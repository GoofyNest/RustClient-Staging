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

	// RVA: 0x200B0F0 Offset: 0x20096F0 VA: 0x18200B0F0
	public static void ResetToPool(AIDesign instance) { }

	// RVA: 0x200B380 Offset: 0x2009980 VA: 0x18200B380
	public void ResetToPool() { }

	// RVA: 0x200B030 Offset: 0x2009630 VA: 0x18200B030 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2009D40 Offset: 0x2008340 VA: 0x182009D40
	public void CopyTo(AIDesign instance) { }

	// RVA: 0x2009F70 Offset: 0x2008570 VA: 0x182009F70
	public AIDesign Copy() { }

	// RVA: 0x200A9E0 Offset: 0x2008FE0 VA: 0x18200A9E0
	public static AIDesign Deserialize(Stream stream) { }

	// RVA: 0x2009FF0 Offset: 0x20085F0 VA: 0x182009FF0
	public static AIDesign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x200A950 Offset: 0x2008F50 VA: 0x18200A950
	public static AIDesign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x200AB60 Offset: 0x2009160 VA: 0x18200AB60
	public static AIDesign Deserialize(byte[] buffer) { }

	// RVA: 0x200B0B0 Offset: 0x20096B0 VA: 0x18200B0B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x200BF80 Offset: 0x200A580 VA: 0x18200BF80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x200BFA0 Offset: 0x200A5A0 VA: 0x18200BFA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AIDesign previous) { }

	// RVA: 0x200B0D0 Offset: 0x20096D0 VA: 0x18200B0D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x200AA60 Offset: 0x2009060 VA: 0x18200AA60
	public static AIDesign Deserialize(byte[] buffer, AIDesign instance, bool isDelta = False) { }

	// RVA: 0x200AC80 Offset: 0x2009280 VA: 0x18200AC80
	public static AIDesign Deserialize(Stream stream, AIDesign instance, bool isDelta) { }

	// RVA: 0x200A070 Offset: 0x2008670 VA: 0x18200A070
	public static AIDesign DeserializeLengthDelimited(Stream stream, AIDesign instance, bool isDelta) { }

	// RVA: 0x200A4F0 Offset: 0x2008AF0 VA: 0x18200A4F0
	public static AIDesign DeserializeLength(Stream stream, int length, AIDesign instance, bool isDelta) { }

	// RVA: 0x200B610 Offset: 0x2009C10 VA: 0x18200B610
	public static void SerializeDelta(Stream stream, AIDesign instance, AIDesign previous) { }

	// RVA: 0x200BBE0 Offset: 0x200A1E0 VA: 0x18200BBE0
	public static void Serialize(Stream stream, AIDesign instance) { }

	// RVA: 0x200BF70 Offset: 0x200A570 VA: 0x18200BF70
	public byte[] ToProtoBytes() { }

	// RVA: 0x200BF80 Offset: 0x200A580 VA: 0x18200BF80
	public void ToProto(Stream stream) { }

	// RVA: 0x200BAD0 Offset: 0x200A0D0 VA: 0x18200BAD0
	public static byte[] SerializeToBytes(AIDesign instance) { }

	// RVA: 0x200BA20 Offset: 0x200A020 VA: 0x18200BA20
	public static void SerializeLengthDelimited(Stream stream, AIDesign instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x2011E00 Offset: 0x2010400 VA: 0x182011E00
	public static void ResetToPool(AIStateContainer instance) { }

	// RVA: 0x2011C10 Offset: 0x2010210 VA: 0x182011C10
	public void ResetToPool() { }

	// RVA: 0x2011B50 Offset: 0x2010150 VA: 0x182011B50 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2010570 Offset: 0x200EB70 VA: 0x182010570
	public void CopyTo(AIStateContainer instance) { }

	// RVA: 0x2010720 Offset: 0x200ED20 VA: 0x182010720
	public AIStateContainer Copy() { }

	// RVA: 0x2011130 Offset: 0x200F730 VA: 0x182011130
	public static AIStateContainer Deserialize(Stream stream) { }

	// RVA: 0x2010910 Offset: 0x200EF10 VA: 0x182010910
	public static AIStateContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2010D30 Offset: 0x200F330 VA: 0x182010D30
	public static AIStateContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2011510 Offset: 0x200FB10 VA: 0x182011510
	public static AIStateContainer Deserialize(byte[] buffer) { }

	// RVA: 0x2011BD0 Offset: 0x20101D0 VA: 0x182011BD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2012760 Offset: 0x2010D60 VA: 0x182012760 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2012780 Offset: 0x2010D80 VA: 0x182012780 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AIStateContainer previous) { }

	// RVA: 0x2011BF0 Offset: 0x20101F0 VA: 0x182011BF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2011410 Offset: 0x200FA10 VA: 0x182011410
	public static AIStateContainer Deserialize(byte[] buffer, AIStateContainer instance, bool isDelta = False) { }

	// RVA: 0x2011890 Offset: 0x200FE90 VA: 0x182011890
	public static AIStateContainer Deserialize(Stream stream, AIStateContainer instance, bool isDelta) { }

	// RVA: 0x2010990 Offset: 0x200EF90 VA: 0x182010990
	public static AIStateContainer DeserializeLengthDelimited(Stream stream, AIStateContainer instance, bool isDelta) { }

	// RVA: 0x2010DC0 Offset: 0x200F3C0 VA: 0x182010DC0
	public static AIStateContainer DeserializeLength(Stream stream, int length, AIStateContainer instance, bool isDelta) { }

	// RVA: 0x2011FF0 Offset: 0x20105F0 VA: 0x182011FF0
	public static void SerializeDelta(Stream stream, AIStateContainer instance, AIStateContainer previous) { }

	// RVA: 0x20124B0 Offset: 0x2010AB0 VA: 0x1820124B0
	public static void Serialize(Stream stream, AIStateContainer instance) { }

	// RVA: 0x2012750 Offset: 0x2010D50 VA: 0x182012750
	public byte[] ToProtoBytes() { }

	// RVA: 0x2012760 Offset: 0x2010D60 VA: 0x182012760
	public void ToProto(Stream stream) { }

	// RVA: 0x20123A0 Offset: 0x20109A0 VA: 0x1820123A0
	public static byte[] SerializeToBytes(AIStateContainer instance) { }

	// RVA: 0x20122F0 Offset: 0x20108F0 VA: 0x1820122F0
	public static void SerializeLengthDelimited(Stream stream, AIStateContainer instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x200DEF0 Offset: 0x200C4F0 VA: 0x18200DEF0
	public static void ResetToPool(AIEventData instance) { }

	// RVA: 0x200E2B0 Offset: 0x200C8B0 VA: 0x18200E2B0
	public void ResetToPool() { }

	// RVA: 0x200DE30 Offset: 0x200C430 VA: 0x18200DE30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x200BFC0 Offset: 0x200A5C0 VA: 0x18200BFC0
	public void CopyTo(AIEventData instance) { }

	// RVA: 0x200C3E0 Offset: 0x200A9E0 VA: 0x18200C3E0
	public AIEventData Copy() { }

	// RVA: 0x200D4B0 Offset: 0x200BAB0 VA: 0x18200D4B0
	public static AIEventData Deserialize(Stream stream) { }

	// RVA: 0x200CC10 Offset: 0x200B210 VA: 0x18200CC10
	public static AIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x200D420 Offset: 0x200BA20 VA: 0x18200D420
	public static AIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x200DC10 Offset: 0x200C210 VA: 0x18200DC10
	public static AIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x200DEB0 Offset: 0x200C4B0 VA: 0x18200DEB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2010530 Offset: 0x200EB30 VA: 0x182010530 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2010550 Offset: 0x200EB50 VA: 0x182010550 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AIEventData previous) { }

	// RVA: 0x200DED0 Offset: 0x200C4D0 VA: 0x18200DED0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x200DD30 Offset: 0x200C330 VA: 0x18200DD30
	public static AIEventData Deserialize(byte[] buffer, AIEventData instance, bool isDelta = False) { }

	// RVA: 0x200D530 Offset: 0x200BB30 VA: 0x18200D530
	public static AIEventData Deserialize(Stream stream, AIEventData instance, bool isDelta) { }

	// RVA: 0x200C460 Offset: 0x200AA60 VA: 0x18200C460
	public static AIEventData DeserializeLengthDelimited(Stream stream, AIEventData instance, bool isDelta) { }

	// RVA: 0x200CC90 Offset: 0x200B290 VA: 0x18200CC90
	public static AIEventData DeserializeLength(Stream stream, int length, AIEventData instance, bool isDelta) { }

	// RVA: 0x200E670 Offset: 0x200CC70 VA: 0x18200E670
	public static void SerializeDelta(Stream stream, AIEventData instance, AIEventData previous) { }

	// RVA: 0x200F740 Offset: 0x200DD40 VA: 0x18200F740
	public static void Serialize(Stream stream, AIEventData instance) { }

	// RVA: 0x2010520 Offset: 0x200EB20 VA: 0x182010520
	public byte[] ToProtoBytes() { }

	// RVA: 0x2010530 Offset: 0x200EB30 VA: 0x182010530
	public void ToProto(Stream stream) { }

	// RVA: 0x200F630 Offset: 0x200DC30 VA: 0x18200F630
	public static byte[] SerializeToBytes(AIEventData instance) { }

	// RVA: 0x200F580 Offset: 0x200DB80 VA: 0x18200F580
	public static void SerializeLengthDelimited(Stream stream, AIEventData instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x7C4910 Offset: 0x7C2F10 VA: 0x1807C4910 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7C5880 Offset: 0x7C3E80 VA: 0x1807C5880 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7C4C40 Offset: 0x7C3240 VA: 0x1807C4C40 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7C46E0 Offset: 0x7C2CE0 VA: 0x1807C46E0
	public int GetConversationIndex(string conversationName) { }

	// RVA: 0x7C47A0 Offset: 0x7C2DA0 VA: 0x1807C47A0 Slot: 158
	public virtual string GetConversationStartSpeech(BasePlayer player) { }

	// RVA: 0x7C4850 Offset: 0x7C2E50 VA: 0x1807C4850
	public ConversationData GetConversation(string conversationName) { }

	// RVA: 0x7C4810 Offset: 0x7C2E10 VA: 0x1807C4810
	public ConversationData GetConversation(int index) { }

	// RVA: 0x7C46A0 Offset: 0x7C2CA0 VA: 0x1807C46A0 Slot: 159
	public virtual ConversationData GetConversationFor(BasePlayer player) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60 Slot: 157
	public bool ProviderBusy() { }

	[BaseEntity.Menu] // RVA: 0x7BBE0 Offset: 0x7AFE0 VA: 0x18007BBE0
	[BaseEntity.Menu.Description] // RVA: 0x7BBE0 Offset: 0x7AFE0 VA: 0x18007BBE0
	[BaseEntity.Menu.Icon] // RVA: 0x7BBE0 Offset: 0x7AFE0 VA: 0x18007BBE0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7BBE0 Offset: 0x7AFE0 VA: 0x18007BBE0
	// RVA: 0x7C4BF0 Offset: 0x7C31F0 VA: 0x1807C4BF0
	public void Menu_Talk(BasePlayer player) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool Menu_Talk_ShowIf(BasePlayer player) { }

	// RVA: 0x7C4600 Offset: 0x7C2C00 VA: 0x1807C4600 Slot: 155
	public void DoAction(string action) { }

	// RVA: 0x7C47D0 Offset: 0x7C2DD0 VA: 0x1807C47D0 Slot: 156
	public Vector3 GetConversationWorldOrigin() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7C4550 Offset: 0x7C2B50 VA: 0x1807C4550
	public void Client_StartConversation(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7C4650 Offset: 0x7C2C50 VA: 0x1807C4650 Slot: 154
	public void EndConversation(bool fromServer) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7C4480 Offset: 0x7C2A80 VA: 0x1807C4480
	public void Client_ForceSpeechNode(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7C57B0 Offset: 0x7C3DB0 VA: 0x1807C57B0 Slot: 153
	public void ResponsePressed(int index) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7C4470 Offset: 0x7C2A70 VA: 0x1807C4470
	public void Client_EndConversation(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7C40D0 Offset: 0x7C26D0 VA: 0x1807C40D0
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
	[TooltipAttribute] // RVA: 0x777B0 Offset: 0x76BB0 VA: 0x1800777B0
	public int weight; // 0x30
	public int refillAmount; // 0x34
	public float refillDelay; // 0x38

	// Methods

	// RVA: 0x7B5700 Offset: 0x7B3D00 VA: 0x1807B5700
	public void .ctor() { }

}

public class NPCVendingOrderManifest : ScriptableObject // TypeDefIndex: 8724
{	// Fields
	public NPCVendingOrder[] orderList; // 0x18

	// Methods

	// RVA: 0x7C59B0 Offset: 0x7C3FB0 VA: 0x1807C59B0
	public int GetIndex(NPCVendingOrder sample) { }

	// RVA: 0x7C5970 Offset: 0x7C3F70 VA: 0x1807C5970
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

	// RVA: 0x7C5910 Offset: 0x7C3F10 VA: 0x1807C5910
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

	// RVA: 0x7C3CB0 Offset: 0x7C22B0 VA: 0x1807C3CB0
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

	// RVA: 0x7C40D0 Offset: 0x7C26D0 VA: 0x1807C40D0
	public void .ctor() { }

}

public class NPCShopKeeper : NPCPlayer // TypeDefIndex: 8850
{	// Fields
	public EntityRef invisibleVendingMachineRef; // 0x7D8
	public InvisibleVendingMachine machine; // 0x7E8

	// Methods

	// RVA: 0x7C4230 Offset: 0x7C2830 VA: 0x1807C4230
	public InvisibleVendingMachine GetVendingMachine() { }

	// RVA: 0x7C42D0 Offset: 0x7C28D0 VA: 0x1807C42D0
	public void OnDrawGizmos() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 152
	public override void UpdateProtectionFromClothing() { }

	// RVA: 0x7C40D0 Offset: 0x7C26D0 VA: 0x1807C40D0
	public void .ctor() { }

}

public class NPCPlayerCorpse : PlayerCorpse // TypeDefIndex: 8867
{	// Methods

	// RVA: 0x7C41C0 Offset: 0x7C27C0 VA: 0x1807C41C0
	public void .ctor() { }

}

public class AICoverPoint : AIPoint // TypeDefIndex: 8903
{	// Fields
	public float coverDot; // 0x20

	// Methods

	// RVA: 0xA90CD0 Offset: 0xA8F2D0 VA: 0x180A90CD0
	public void OnDrawGizmos() { }

	// RVA: 0xA91320 Offset: 0xA8F920 VA: 0x180A91320
	public void .ctor() { }

}

public class AICoverPointTool : MonoBehaviour // TypeDefIndex: 8904
{	// Methods

	[ContextMenu] // RVA: 0xC1F00 Offset: 0xC1300 VA: 0x1800C1F00
	// RVA: 0xA90280 Offset: 0xA8E880 VA: 0x180A90280
	public void PlaceCoverPoints() { }

	// RVA: 0xA909B0 Offset: 0xA8EFB0 VA: 0x180A909B0
	private AICoverPointTool.TestResult TestPoint(Vector3 pos) { }

	// RVA: 0xA90640 Offset: 0xA8EC40 VA: 0x180A90640
	private void PlacePoint(AICoverPointTool.TestResult result) { }

	// RVA: 0xA90880 Offset: 0xA8EE80 VA: 0x180A90880
	private void PlacePoint(Vector3 pos, Vector3 dir) { }

	// RVA: 0xA900B0 Offset: 0xA8E6B0 VA: 0x180A900B0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly int <X>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly int <Z>k__BackingField; // 0x44

	// Properties
	public int X { get; }
	public int Z { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440
	public int get_X() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x5DE450 Offset: 0x5DCA50 VA: 0x1805DE450
	public int get_Z() { }

	// RVA: 0xA92CB0 Offset: 0xA912B0 VA: 0x180A92CB0
	public void .ctor(Bounds bounds, GameObject root, int x, int z) { }

	// RVA: 0xA92890 Offset: 0xA90E90 VA: 0x180A92890
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
	|-RVA: 0xD5A330 Offset: 0xD58930 VA: 0x180D5A330
	|-AIInformationCellContents<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8AC0 Offset: 0x15D70C0 VA: 0x1815D8AC0
	|-AIInformationCellContents<object>.get_Empty
	*/

	// RVA: -1 Offset: -1
	public void Init(Bounds cellBounds, GameObject root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D88C0 Offset: 0x15D6EC0 VA: 0x1815D88C0
	|-AIInformationCellContents<AICoverPoint>.Init
	|-AIInformationCellContents<AIMovePoint>.Init
	|-AIInformationCellContents<object>.Init
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8890 Offset: 0x15D6E90 VA: 0x1815D8890
	|-AIInformationCellContents<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8860 Offset: 0x15D6E60 VA: 0x1815D8860
	|-AIInformationCellContents<object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8A10 Offset: 0x15D7010 VA: 0x1815D8A10
	|-AIInformationCellContents<object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8A40 Offset: 0x15D7040 VA: 0x1815D8A40
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

	[ContextMenu] // RVA: 0xC3700 Offset: 0xC2B00 VA: 0x1800C3700
	// RVA: 0xA93990 Offset: 0xA91F90 VA: 0x180A93990
	public void Init() { }

	// RVA: 0xA936D0 Offset: 0xA91CD0 VA: 0x180A936D0
	private int GetIndex(int x, int z) { }

	// RVA: 0xA93000 Offset: 0xA91600 VA: 0x180A93000
	public AIInformationCell CellAt(int x, int z) { }

	// RVA: 0xA936E0 Offset: 0xA91CE0 VA: 0x180A936E0
	public AIMovePoint[] GetMovePointsInRange(Vector3 position, float maxRange, out int pointCount) { }

	// RVA: 0xA93420 Offset: 0xA91A20 VA: 0x180A93420
	public AICoverPoint[] GetCoverPointsInRange(Vector3 position, float maxRange, out int pointCount) { }

	// RVA: 0xA93210 Offset: 0xA91810 VA: 0x180A93210
	public AIInformationCell[] GetCellsInRange(Vector3 position, float maxRange, out int cellCount) { }

	// RVA: 0xA930F0 Offset: 0xA916F0 VA: 0x180A930F0
	public AIInformationCell GetCell(Vector3 position) { }

	// RVA: 0xA93040 Offset: 0xA91640 VA: 0x180A93040
	public void OnDrawGizmos() { }

	// RVA: 0xA93040 Offset: 0xA91640 VA: 0x180A93040
	public void DebugDraw() { }

	// RVA: 0xA93F90 Offset: 0xA92590 VA: 0x180A93F90
	public void .ctor() { }

}

public class AIInformationGridTester : MonoBehaviour // TypeDefIndex: 8909
{	// Fields
	public AIInformationGrid Grid; // 0x18
	public float Range; // 0x20

	// Methods

	// RVA: 0xA92E30 Offset: 0xA91430 VA: 0x180A92E30
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

	// RVA: 0xA94090 Offset: 0xA92690 VA: 0x180A94090
	public void .ctor() { }

	// RVA: 0xA94030 Offset: 0xA92630 VA: 0x180A94030
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

	// RVA: 0xA95090 Offset: 0xA93690 VA: 0x180A95090
	public void OnDrawGizmos() { }

	// RVA: 0xA94D60 Offset: 0xA93360 VA: 0x180A94D60
	public void DrawLookAtPoints() { }

	// RVA: 0xA94D40 Offset: 0xA93340 VA: 0x180A94D40
	public void Clear() { }

	// RVA: 0xA94CA0 Offset: 0xA932A0 VA: 0x180A94CA0
	public void AddLookAtPoint(Transform transform) { }

	// RVA: 0xA95050 Offset: 0xA93650 VA: 0x180A95050
	public bool HasLookAtPoints() { }

	// RVA: 0xA94FE0 Offset: 0xA935E0 VA: 0x180A94FE0
	public Transform GetRandomLookAtPoint() { }

	// RVA: 0xA95140 Offset: 0xA93740 VA: 0x180A95140
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

	// RVA: 0xA94370 Offset: 0xA92970 VA: 0x180A94370
	public void Clear() { }

	// RVA: 0xA94310 Offset: 0xA92910 VA: 0x180A94310
	public void AddPoint(AIMovePoint point) { }

	// RVA: 0xA945E0 Offset: 0xA92BE0 VA: 0x180A945E0
	public AIMovePoint FindNearestPoint(Vector3 position) { }

	// RVA: 0xA943C0 Offset: 0xA929C0 VA: 0x180A943C0
	public int FindNearestPointIndex(Vector3 position) { }

	// RVA: 0xA94740 Offset: 0xA92D40 VA: 0x180A94740
	public AIMovePoint GetPointAtIndex(int index) { }

	// RVA: 0xA94670 Offset: 0xA92C70 VA: 0x180A94670
	public int GetNextPointIndex(int currentPointIndex, ref AIMovePointPath.PathDirection pathDirection) { }

	// RVA: 0xA948B0 Offset: 0xA92EB0 VA: 0x180A948B0
	private void OnDrawGizmos() { }

	// RVA: 0xA947B0 Offset: 0xA92DB0 VA: 0x180A947B0
	private void OnDrawGizmosSelected() { }

	[ContextMenu] // RVA: 0xC37A0 Offset: 0xC2BA0 VA: 0x1800C37A0
	// RVA: 0xA94270 Offset: 0xA92870 VA: 0x180A94270
	public void AddChildPoints() { }

	// RVA: 0xA94C20 Offset: 0xA93220 VA: 0x180A94C20
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

	// RVA: 0xA95370 Offset: 0xA93970 VA: 0x180A95370
	public bool InUse() { }

	// RVA: 0xA953D0 Offset: 0xA939D0 VA: 0x180A953D0
	public bool IsUsedBy(BaseEntity user) { }

	// RVA: 0xA951E0 Offset: 0xA937E0 VA: 0x180A951E0
	public bool CanBeUsedBy(BaseEntity user) { }

	// RVA: 0xA954D0 Offset: 0xA93AD0 VA: 0x180A954D0
	public void SetUsedBy(BaseEntity user, float duration = 5) { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void SetUsedBy(BaseEntity user) { }

	// RVA: 0xA7DC80 Offset: 0xA7C280 VA: 0x180A7DC80
	public void ClearUsed() { }

	// RVA: 0xA952E0 Offset: 0xA938E0 VA: 0x180A952E0
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

	// RVA: 0xA96600 Offset: 0xA94C00 VA: 0x180A96600
	public void OnValidate() { }

	// RVA: 0xA96130 Offset: 0xA94730 VA: 0x180A96130 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0xA95950 Offset: 0xA93F50 VA: 0x180A95950
	public bool CanTraverse(BaseEntity ent) { }

	// RVA: 0xA959B0 Offset: 0xA93FB0 VA: 0x180A959B0
	public Transform GetClosestEntry(Vector3 position) { }

	// RVA: 0xA96000 Offset: 0xA94600 VA: 0x180A96000
	public Transform GetFarthestEntry(Vector3 position) { }

	// RVA: 0xA96660 Offset: 0xA94C60 VA: 0x180A96660
	public void SetBusyFor(float dur = 1) { }

	// RVA: 0xA95950 Offset: 0xA93F50 VA: 0x180A95950
	public bool CanUse(Vector3 dirFrom) { }

	// RVA: 0xA965E0 Offset: 0xA94BE0 VA: 0x180A965E0 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0xA95AE0 Offset: 0xA940E0 VA: 0x180A95AE0
	public AITraversalWaitPoint GetEntryPointNear(Vector3 pos) { }

	// RVA: 0xA95970 Offset: 0xA93F70 VA: 0x180A95970
	public bool EntityFilter(BaseEntity ent) { }

	// RVA: 0xA965F0 Offset: 0xA94BF0 VA: 0x180A965F0 Slot: 9
	internal override void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0xA96230 Offset: 0xA94830 VA: 0x180A96230
	public void OnDrawGizmos() { }

	// RVA: 0x4D38B0 Offset: 0x4D1EB0 VA: 0x1804D38B0
	public void .ctor() { }

}

public class AITraversalWaitPoint : MonoBehaviour // TypeDefIndex: 8918
{	// Fields
	public float nextFreeTime; // 0x18

	// Methods

	// RVA: 0xA96690 Offset: 0xA94C90 VA: 0x180A96690
	public bool Occupied() { }

	// RVA: 0xA966B0 Offset: 0xA94CB0 VA: 0x180A966B0
	public void Occupy(float dur = 1) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class AnimalBrain : BaseAIBrain<BaseAnimalNPC> // TypeDefIndex: 8919
{	// Methods

	// RVA: 0x828E70 Offset: 0x827470 VA: 0x180828E70
	public void .ctor() { }

}

public class AnimalRagdoll : Ragdoll // TypeDefIndex: 8926
{	// Fields
	public SkinnedMeshRenderer[] bodyRenderers; // 0x98
	public SkinnedMeshRenderer[] hairRenderers; // 0xA0

	// Methods

	// RVA: 0x8294F0 Offset: 0x827AF0 VA: 0x1808294F0
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

	// RVA: 0x7C40D0 Offset: 0x7C26D0 VA: 0x1807C40D0
	public void .ctor() { }

}

public class NPCNavigator : BaseNavigator // TypeDefIndex: 8953
{	// Methods

	// RVA: 0x7C4160 Offset: 0x7C2760 VA: 0x1807C4160
	public void .ctor() { }

}

public class NPCPlayerNavigator : BaseNavigator // TypeDefIndex: 8954
{	// Methods

	// RVA: 0x7C41D0 Offset: 0x7C27D0 VA: 0x1807C41D0
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

	// RVA: 0xAA2850 Offset: 0xAA0E50 VA: 0x180AA2850
	public static Vector3 GetModifiedAimConeDirection(float aimCone, Vector3 inputVec, bool anywhereInside = True) { }

	// RVA: 0xAA2790 Offset: 0xAA0D90 VA: 0x180AA2790
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

	// RVA: 0x829730 Offset: 0x827D30 VA: 0x180829730
	private void Start() { }

	// RVA: 0x829500 Offset: 0x827B00 VA: 0x180829500
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
	[ReadOnlyAttribute] // RVA: 0x70AC0 Offset: 0x6FEC0 VA: 0x180070AC0
	public string BaseFolder; // 0x60
	public const BaseEntity.Flags Flag_WoodArmor = 2048;
	public const BaseEntity.Flags Flag_RoadsignArmor = 16384;
	private float lastThinkTime; // 0x68
	private Vector3 previousPosition; // 0x6C
	private float previousRotationYaw; // 0x78
	private bool wasSleeping; // 0x7C

	// Methods

	// RVA: 0x828D40 Offset: 0x827340 VA: 0x180828D40
	private void Update() { }

	// RVA: 0x828C40 Offset: 0x827240 VA: 0x180828C40
	public bool ShouldPlayFootstep(AnimationEvent evt) { }

	// RVA: 0x828650 Offset: 0x826C50 VA: 0x180828650
	private void FrontLeftFootstep(AnimationEvent evt) { }

	// RVA: 0x8286B0 Offset: 0x826CB0 VA: 0x1808286B0
	private void FrontRightFootstep(AnimationEvent evt) { }

	// RVA: 0x828330 Offset: 0x826930 VA: 0x180828330
	private void BackLeftFootstep(AnimationEvent evt) { }

	// RVA: 0x828390 Offset: 0x826990 VA: 0x180828390
	private void BackRightFootstep(AnimationEvent evt) { }

	// RVA: 0x8283F0 Offset: 0x8269F0 VA: 0x1808283F0
	private void Footstep(Transform tx) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void DoEffect(string effect) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void PlayEffect(string effect) { }

	// RVA: 0x828A50 Offset: 0x827050 VA: 0x180828A50
	public void PlaySound(string soundName) { }

	// RVA: 0x828A00 Offset: 0x827000 VA: 0x180828A00
	public void PlaySoundDef(SoundDefinition def) { }

	// RVA: 0x828710 Offset: 0x826D10 VA: 0x180828710
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

	// RVA: 0x828EE0 Offset: 0x8274E0 VA: 0x180828EE0
	public bool GroundSample(Vector3 origin, out RaycastHit hit) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Start() { }

	// RVA: 0x828EB0 Offset: 0x8274B0 VA: 0x180828EB0
	public AvatarIKGoal GoalFromIndex(int index) { }

	// RVA: 0x829010 Offset: 0x827610 VA: 0x180829010
	private void OnAnimatorIK(int layerIndex) { }

	// RVA: 0x8294D0 Offset: 0x827AD0 VA: 0x1808294D0
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

	// RVA: 0x7C3F50 Offset: 0x7C2550 VA: 0x1807C3F50
	private void FrontLeftFootstep() { }

	// RVA: 0x7C3FA0 Offset: 0x7C25A0 VA: 0x1807C3FA0
	private void FrontRightFootstep() { }

	// RVA: 0x7C3D10 Offset: 0x7C2310 VA: 0x1807C3D10
	private void BackLeftFootstep() { }

	// RVA: 0x7C3D60 Offset: 0x7C2360 VA: 0x1807C3D60
	private void BackRightFootstep() { }

	// RVA: 0x7C3DB0 Offset: 0x7C23B0 VA: 0x1807C3DB0
	private void Footstep(Vector3 vFootPos) { }

	// RVA: 0x7C3FF0 Offset: 0x7C25F0 VA: 0x1807C3FF0
	private void SetupFootstep(GameObject effect) { }

	// RVA: 0x7C4080 Offset: 0x7C2680 VA: 0x1807C4080
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

	// RVA: 0x6A7A30 Offset: 0x6A6030 VA: 0x1806A7A30
	public void .ctor() { }

}

public class AIDesign // TypeDefIndex: 9379
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private AIDesignScope <Scope>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private string <Description>k__BackingField; // 0x18
	public List<AIState> AvailableStates; // 0x20
	public int DefaultStateContainerID; // 0x28
	private Dictionary<int, AIStateContainer> stateContainers; // 0x30

	// Properties
	public AIDesignScope Scope { get; set; }
	public string Description { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public AIDesignScope get_Scope() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	private void set_Scope(AIDesignScope value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_Description(string value) { }

	// RVA: 0xA91640 Offset: 0xA8FC40 VA: 0x180A91640
	public void SetAvailableStates(List<AIState> states) { }

	// RVA: 0xA915E0 Offset: 0xA8FBE0 VA: 0x180A915E0
	public void Load(AIDesign design, BaseEntity owner) { }

	// RVA: 0xA91430 Offset: 0xA8FA30 VA: 0x180A91430
	private void InitStateContainers(AIDesign design, BaseEntity owner) { }

	// RVA: 0xA91330 Offset: 0xA8F930 VA: 0x180A91330
	public AIStateContainer GetDefaultStateContainer() { }

	// RVA: 0xA913B0 Offset: 0xA8F9B0 VA: 0x180A913B0
	public AIStateContainer GetStateContainerByID(int id) { }

	// RVA: 0xA916D0 Offset: 0xA8FCD0 VA: 0x180A916D0
	public AIDesign ToProto(int currentStateID) { }

	// RVA: 0xA91A00 Offset: 0xA90000 VA: 0x180A91A00
	public void .ctor() { }

}

public static class AIDesigns // TypeDefIndex: 9380
{	// Fields
	public const string DesignFolderPath = "cfg/ai/";
	private static Dictionary<string, AIDesign> designs; // 0x1D4C

	// Methods

	// RVA: 0xA91AA0 Offset: 0xA900A0 VA: 0x180A91AA0
	public static AIDesign GetByNameOrInstance(string designName, AIDesign entityDesign) { }

	// RVA: 0xA91D90 Offset: 0xA90390 VA: 0x180A91D90
	public static void RefreshCache(string designName, AIDesign design) { }

	// RVA: 0xA91B60 Offset: 0xA90160 VA: 0x180A91B60
	private static AIDesign GetByName(string designName) { }

	// RVA: 0xA91E60 Offset: 0xA90460 VA: 0x180A91E60
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <CurrentInputMemorySlot>k__BackingField; // 0x18
	private List<BaseAIEvent> events; // 0x20
	private IAIEventListener eventListener; // 0x28
	private AIBrainSenses senses; // 0x30
	private int currentEventIndex; // 0x38
	private bool inBlock; // 0x3C

	// Properties
	public int CurrentInputMemorySlot { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_CurrentInputMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7D0C80 Offset: 0x7CF280 VA: 0x1807D0C80
	private void set_CurrentInputMemorySlot(int value) { }

	// RVA: 0xA922B0 Offset: 0xA908B0 VA: 0x180A922B0
	public void Init(IAIEventListener listener, AIStateContainer stateContainer, BaseEntity owner, AIBrainSenses senses) { }

	// RVA: 0xA923A0 Offset: 0xA909A0 VA: 0x180A923A0
	private void RemoveAll() { }

	// RVA: 0xA91EC0 Offset: 0xA904C0 VA: 0x180A91EC0
	private void AddStateEvents(List<BaseAIEvent> events, BaseEntity owner) { }

	// RVA: 0xA920C0 Offset: 0xA906C0 VA: 0x180A920C0
	private void Add(BaseAIEvent aiEvent) { }

	// RVA: 0xA923F0 Offset: 0xA909F0 VA: 0x180A923F0
	public void Tick(float deltaTime, StateStatus stateStatus) { }

	// RVA: 0xA921C0 Offset: 0xA907C0 VA: 0x180A921C0
	private int FindNextEventBlock() { }

	// RVA: 0xA926B0 Offset: 0xA90CB0 VA: 0x180A926B0
	public void .ctor() { }

}

public class AIMemory // TypeDefIndex: 9383
{	// Fields
	public AIMemoryBank<BaseEntity> Entity; // 0x10
	public AIMemoryBank<Vector3> Position; // 0x18
	public AIMemoryBank<AIPoint> AIPoint; // 0x20

	// Methods

	// RVA: 0xA94190 Offset: 0xA92790 VA: 0x180A94190
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
	|-RVA: 0x15D8F80 Offset: 0x15D7580 VA: 0x1815D8F80
	|-AIMemoryBank<AIPoint>..ctor
	|-AIMemoryBank<BaseEntity>..ctor
	|-AIMemoryBank<object>..ctor
	|-AIMemoryBank<Vector3>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Init(MemoryBankType type, int slots) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8C30 Offset: 0x15D7230 VA: 0x1815D8C30
	|-AIMemoryBank<object>.Init
	|
	|-RVA: 0x15D8CE0 Offset: 0x15D72E0 VA: 0x1815D8CE0
	|-AIMemoryBank<Vector3>.Init
	*/

	// RVA: -1 Offset: -1
	public void Set(T item, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8E50 Offset: 0x15D7450 VA: 0x1815D8E50
	|-AIMemoryBank<BaseEntity>.Set
	|-AIMemoryBank<object>.Set
	|
	|-RVA: 0x15D8EE0 Offset: 0x15D74E0 VA: 0x1815D8EE0
	|-AIMemoryBank<Vector3>.Set
	*/

	// RVA: -1 Offset: -1
	public T Get(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8B60 Offset: 0x15D7160 VA: 0x1815D8B60
	|-AIMemoryBank<BaseEntity>.Get
	|-AIMemoryBank<object>.Get
	|
	|-RVA: 0x15D8BB0 Offset: 0x15D71B0 VA: 0x1815D8BB0
	|-AIMemoryBank<Vector3>.Get
	*/

	// RVA: -1 Offset: -1
	public float GetTimeSinceSet(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8AF0 Offset: 0x15D70F0 VA: 0x1815D8AF0
	|-AIMemoryBank<object>.GetTimeSinceSet
	|-AIMemoryBank<Vector3>.GetTimeSinceSet
	*/

	// RVA: -1 Offset: -1
	public void Remove(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15D8D90 Offset: 0x15D7390 VA: 0x1815D8D90
	|-AIMemoryBank<object>.Remove
	|
	|-RVA: 0x15D8DF0 Offset: 0x15D73F0 VA: 0x1815D8DF0
	|-AIMemoryBank<Vector3>.Remove
	*/

}

public class AIStateContainer // TypeDefIndex: 9422
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <ID>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private AIState <State>k__BackingField; // 0x14
	public List<BaseAIEvent> Events; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <InputMemorySlot>k__BackingField; // 0x20

	// Properties
	public int ID { get; set; }
	public AIState State { get; set; }
	public int InputMemorySlot { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_ID() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x57C9E0 Offset: 0x57AFE0 VA: 0x18057C9E0
	private void set_ID(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public AIState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x57C9F0 Offset: 0x57AFF0 VA: 0x18057C9F0
	private void set_State(AIState value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public int get_InputMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x69D620 Offset: 0x69BC20 VA: 0x18069D620
	private void set_InputMemorySlot(int value) { }

	// RVA: 0xA95590 Offset: 0xA93B90 VA: 0x180A95590
	public void Init(AIStateContainer container, BaseEntity owner) { }

	// RVA: 0xA95780 Offset: 0xA93D80 VA: 0x180A95780
	public AIStateContainer ToProto() { }

	// RVA: 0xA95940 Offset: 0xA93F40 VA: 0x180A95940
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

	// RVA: 0x7C3CA0 Offset: 0x7C22A0 VA: 0x1807C3CA0
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

	// RVA: 0xA92810 Offset: 0xA90E10 VA: 0x180A92810
	public void .ctor() { }

}

public class NPCSpawner : SpawnGroup // TypeDefIndex: 10004
{	// Fields
	public int AdditionalLOSBlockingLayer; // 0x48
	public MonumentNavMesh monumentNavMesh; // 0x50
	public bool shouldFillOnSpawn; // 0x58
	[HeaderAttribute] // RVA: 0xAD0F0 Offset: 0xAC4F0 VA: 0x1800AD0F0
	public AIInformationZone VirtualInfoZone; // 0x60
	[HeaderAttribute] // RVA: 0xAE440 Offset: 0xAD840 VA: 0x1800AE440
	public AIMovePointPath Path; // 0x68
	public BasePath AStarGraph; // 0x70
	[HeaderAttribute] // RVA: 0xAE8D0 Offset: 0xADCD0 VA: 0x1800AE8D0
	public bool UseStatModifiers; // 0x78
	public float SenseRange; // 0x7C
	public float TargetLostRange; // 0x80
	public float AttackRangeMultiplier; // 0x84
	public float ListenRange; // 0x88
	public float CanUseHealingItemsChance; // 0x8C
	[HeaderAttribute] // RVA: 0xAFCD0 Offset: 0xAF0D0 VA: 0x1800AFCD0
	public PlayerInventoryProperties[] Loadouts; // 0x90

	// Methods

	// RVA: 0x7C4440 Offset: 0x7C2A40 VA: 0x1807C4440
	public void .ctor() { }

}

public class AI : ConsoleSystem // TypeDefIndex: 11880
{	// Fields
	[ReplicatedVar] // RVA: 0x858A0 Offset: 0x84CA0 VA: 0x1800858A0
	public static bool allowdesigning; // 0x0
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static bool designing; // 0x1
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static bool groundAlign; // 0x2
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static float maxGroundAlignDist; // 0x4
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static bool debugVis; // 0x8
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static bool npc_no_foot_ik; // 0x9
	private static HitTest lookingAtNpcCache; // 0x10

	// Methods

	[ClientVar] // RVA: 0x85D70 Offset: 0x85170 VA: 0x180085D70
	// RVA: 0x6C95B0 Offset: 0x6C7BB0 VA: 0x1806C95B0
	public static void aiDebug_lookat(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85D70 Offset: 0x85170 VA: 0x180085D70
	// RVA: 0x6C93F0 Offset: 0x6C79F0 VA: 0x1806C93F0
	public static void aiDebug_LoadBalanceOverdueReport(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85D70 Offset: 0x85170 VA: 0x180085D70
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void selectNPCLookat(ConsoleSystem.Arg args) { }

	// RVA: 0x6C9010 Offset: 0x6C7610 VA: 0x1806C9010
	private static bool CheckLookingAtVisible(HitTest test, TraceInfo trace) { }

	// RVA: 0x6C9390 Offset: 0x6C7990 VA: 0x1806C9390
	public void .ctor() { }

	// RVA: 0x6C92F0 Offset: 0x6C78F0 VA: 0x1806C92F0
	private static void .cctor() { }

}

public class AiManagedAgent : FacepunchBehaviour, IServerComponent // TypeDefIndex: 12133
{	// Fields
	[TooltipAttribute] // RVA: 0xE02C0 Offset: 0xDF6C0 VA: 0x1800E02C0
	public int AgentTypeIndex; // 0x18

	// Methods

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	public void .ctor() { }

}

public class AiManager : SingletonComponent<AiManager>, IServerComponent // TypeDefIndex: 12134
{	// Fields
	[HeaderAttribute] // RVA: 0xE04D0 Offset: 0xDF8D0 VA: 0x1800E04D0
	[SerializeField] // RVA: 0xE04D0 Offset: 0xDF8D0 VA: 0x1800E04D0
	public bool UseCover; // 0x18
	public float CoverPointVolumeCellSize; // 0x1C
	public float CoverPointVolumeCellHeight; // 0x20
	public float CoverPointRayLength; // 0x24
	public CoverPointVolume cpvPrefab; // 0x28
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	[HeaderAttribute] // RVA: 0xE0940 Offset: 0xDFD40 VA: 0x1800E0940
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
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private AiLocationManager _mgr; // 0x70

	// Methods

	// RVA: 0x4C8A40 Offset: 0x4C7040 VA: 0x1804C8A40
	public void .ctor() { }

}

public class AiLocationManager : FacepunchBehaviour, IServerComponent // TypeDefIndex: 12137
{	// Fields
	public static List<AiLocationManager> Managers; // 0x0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	public AiLocationSpawner MainSpawner; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
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

