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

	// RVA: 0x200BA10 Offset: 0x200A010 VA: 0x18200BA10
	public static void ResetToPool(AIDesign instance) { }

	// RVA: 0x200BCA0 Offset: 0x200A2A0 VA: 0x18200BCA0
	public void ResetToPool() { }

	// RVA: 0x200B950 Offset: 0x2009F50 VA: 0x18200B950 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x200A660 Offset: 0x2008C60 VA: 0x18200A660
	public void CopyTo(AIDesign instance) { }

	// RVA: 0x200A890 Offset: 0x2008E90 VA: 0x18200A890
	public AIDesign Copy() { }

	// RVA: 0x200B300 Offset: 0x2009900 VA: 0x18200B300
	public static AIDesign Deserialize(Stream stream) { }

	// RVA: 0x200A910 Offset: 0x2008F10 VA: 0x18200A910
	public static AIDesign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x200B270 Offset: 0x2009870 VA: 0x18200B270
	public static AIDesign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x200B480 Offset: 0x2009A80 VA: 0x18200B480
	public static AIDesign Deserialize(byte[] buffer) { }

	// RVA: 0x200B9D0 Offset: 0x2009FD0 VA: 0x18200B9D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x200C8A0 Offset: 0x200AEA0 VA: 0x18200C8A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x200C8C0 Offset: 0x200AEC0 VA: 0x18200C8C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AIDesign previous) { }

	// RVA: 0x200B9F0 Offset: 0x2009FF0 VA: 0x18200B9F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x200B380 Offset: 0x2009980 VA: 0x18200B380
	public static AIDesign Deserialize(byte[] buffer, AIDesign instance, bool isDelta = False) { }

	// RVA: 0x200B5A0 Offset: 0x2009BA0 VA: 0x18200B5A0
	public static AIDesign Deserialize(Stream stream, AIDesign instance, bool isDelta) { }

	// RVA: 0x200A990 Offset: 0x2008F90 VA: 0x18200A990
	public static AIDesign DeserializeLengthDelimited(Stream stream, AIDesign instance, bool isDelta) { }

	// RVA: 0x200AE10 Offset: 0x2009410 VA: 0x18200AE10
	public static AIDesign DeserializeLength(Stream stream, int length, AIDesign instance, bool isDelta) { }

	// RVA: 0x200BF30 Offset: 0x200A530 VA: 0x18200BF30
	public static void SerializeDelta(Stream stream, AIDesign instance, AIDesign previous) { }

	// RVA: 0x200C500 Offset: 0x200AB00 VA: 0x18200C500
	public static void Serialize(Stream stream, AIDesign instance) { }

	// RVA: 0x200C890 Offset: 0x200AE90 VA: 0x18200C890
	public byte[] ToProtoBytes() { }

	// RVA: 0x200C8A0 Offset: 0x200AEA0 VA: 0x18200C8A0
	public void ToProto(Stream stream) { }

	// RVA: 0x200C3F0 Offset: 0x200A9F0 VA: 0x18200C3F0
	public static byte[] SerializeToBytes(AIDesign instance) { }

	// RVA: 0x200C340 Offset: 0x200A940 VA: 0x18200C340
	public static void SerializeLengthDelimited(Stream stream, AIDesign instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x2012720 Offset: 0x2010D20 VA: 0x182012720
	public static void ResetToPool(AIStateContainer instance) { }

	// RVA: 0x2012530 Offset: 0x2010B30 VA: 0x182012530
	public void ResetToPool() { }

	// RVA: 0x2012470 Offset: 0x2010A70 VA: 0x182012470 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2010E90 Offset: 0x200F490 VA: 0x182010E90
	public void CopyTo(AIStateContainer instance) { }

	// RVA: 0x2011040 Offset: 0x200F640 VA: 0x182011040
	public AIStateContainer Copy() { }

	// RVA: 0x2011A50 Offset: 0x2010050 VA: 0x182011A50
	public static AIStateContainer Deserialize(Stream stream) { }

	// RVA: 0x2011230 Offset: 0x200F830 VA: 0x182011230
	public static AIStateContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2011650 Offset: 0x200FC50 VA: 0x182011650
	public static AIStateContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2011E30 Offset: 0x2010430 VA: 0x182011E30
	public static AIStateContainer Deserialize(byte[] buffer) { }

	// RVA: 0x20124F0 Offset: 0x2010AF0 VA: 0x1820124F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2013080 Offset: 0x2011680 VA: 0x182013080 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20130A0 Offset: 0x20116A0 VA: 0x1820130A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AIStateContainer previous) { }

	// RVA: 0x2012510 Offset: 0x2010B10 VA: 0x182012510 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2011D30 Offset: 0x2010330 VA: 0x182011D30
	public static AIStateContainer Deserialize(byte[] buffer, AIStateContainer instance, bool isDelta = False) { }

	// RVA: 0x20121B0 Offset: 0x20107B0 VA: 0x1820121B0
	public static AIStateContainer Deserialize(Stream stream, AIStateContainer instance, bool isDelta) { }

	// RVA: 0x20112B0 Offset: 0x200F8B0 VA: 0x1820112B0
	public static AIStateContainer DeserializeLengthDelimited(Stream stream, AIStateContainer instance, bool isDelta) { }

	// RVA: 0x20116E0 Offset: 0x200FCE0 VA: 0x1820116E0
	public static AIStateContainer DeserializeLength(Stream stream, int length, AIStateContainer instance, bool isDelta) { }

	// RVA: 0x2012910 Offset: 0x2010F10 VA: 0x182012910
	public static void SerializeDelta(Stream stream, AIStateContainer instance, AIStateContainer previous) { }

	// RVA: 0x2012DD0 Offset: 0x20113D0 VA: 0x182012DD0
	public static void Serialize(Stream stream, AIStateContainer instance) { }

	// RVA: 0x2013070 Offset: 0x2011670 VA: 0x182013070
	public byte[] ToProtoBytes() { }

	// RVA: 0x2013080 Offset: 0x2011680 VA: 0x182013080
	public void ToProto(Stream stream) { }

	// RVA: 0x2012CC0 Offset: 0x20112C0 VA: 0x182012CC0
	public static byte[] SerializeToBytes(AIStateContainer instance) { }

	// RVA: 0x2012C10 Offset: 0x2011210 VA: 0x182012C10
	public static void SerializeLengthDelimited(Stream stream, AIStateContainer instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x200E810 Offset: 0x200CE10 VA: 0x18200E810
	public static void ResetToPool(AIEventData instance) { }

	// RVA: 0x200EBD0 Offset: 0x200D1D0 VA: 0x18200EBD0
	public void ResetToPool() { }

	// RVA: 0x200E750 Offset: 0x200CD50 VA: 0x18200E750 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x200C8E0 Offset: 0x200AEE0 VA: 0x18200C8E0
	public void CopyTo(AIEventData instance) { }

	// RVA: 0x200CD00 Offset: 0x200B300 VA: 0x18200CD00
	public AIEventData Copy() { }

	// RVA: 0x200DDD0 Offset: 0x200C3D0 VA: 0x18200DDD0
	public static AIEventData Deserialize(Stream stream) { }

	// RVA: 0x200D530 Offset: 0x200BB30 VA: 0x18200D530
	public static AIEventData DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x200DD40 Offset: 0x200C340 VA: 0x18200DD40
	public static AIEventData DeserializeLength(Stream stream, int length) { }

	// RVA: 0x200E530 Offset: 0x200CB30 VA: 0x18200E530
	public static AIEventData Deserialize(byte[] buffer) { }

	// RVA: 0x200E7D0 Offset: 0x200CDD0 VA: 0x18200E7D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2010E50 Offset: 0x200F450 VA: 0x182010E50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2010E70 Offset: 0x200F470 VA: 0x182010E70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AIEventData previous) { }

	// RVA: 0x200E7F0 Offset: 0x200CDF0 VA: 0x18200E7F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x200E650 Offset: 0x200CC50 VA: 0x18200E650
	public static AIEventData Deserialize(byte[] buffer, AIEventData instance, bool isDelta = False) { }

	// RVA: 0x200DE50 Offset: 0x200C450 VA: 0x18200DE50
	public static AIEventData Deserialize(Stream stream, AIEventData instance, bool isDelta) { }

	// RVA: 0x200CD80 Offset: 0x200B380 VA: 0x18200CD80
	public static AIEventData DeserializeLengthDelimited(Stream stream, AIEventData instance, bool isDelta) { }

	// RVA: 0x200D5B0 Offset: 0x200BBB0 VA: 0x18200D5B0
	public static AIEventData DeserializeLength(Stream stream, int length, AIEventData instance, bool isDelta) { }

	// RVA: 0x200EF90 Offset: 0x200D590 VA: 0x18200EF90
	public static void SerializeDelta(Stream stream, AIEventData instance, AIEventData previous) { }

	// RVA: 0x2010060 Offset: 0x200E660 VA: 0x182010060
	public static void Serialize(Stream stream, AIEventData instance) { }

	// RVA: 0x2010E40 Offset: 0x200F440 VA: 0x182010E40
	public byte[] ToProtoBytes() { }

	// RVA: 0x2010E50 Offset: 0x200F450 VA: 0x182010E50
	public void ToProto(Stream stream) { }

	// RVA: 0x200FF50 Offset: 0x200E550 VA: 0x18200FF50
	public static byte[] SerializeToBytes(AIEventData instance) { }

	// RVA: 0x200FEA0 Offset: 0x200E4A0 VA: 0x18200FEA0
	public static void SerializeLengthDelimited(Stream stream, AIEventData instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x7E2E10 Offset: 0x7E1410 VA: 0x1807E2E10 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7E3D80 Offset: 0x7E2380 VA: 0x1807E3D80 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7E3140 Offset: 0x7E1740 VA: 0x1807E3140 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x7E2BE0 Offset: 0x7E11E0 VA: 0x1807E2BE0
	public int GetConversationIndex(string conversationName) { }

	// RVA: 0x7E2CA0 Offset: 0x7E12A0 VA: 0x1807E2CA0 Slot: 158
	public virtual string GetConversationStartSpeech(BasePlayer player) { }

	// RVA: 0x7E2D50 Offset: 0x7E1350 VA: 0x1807E2D50
	public ConversationData GetConversation(string conversationName) { }

	// RVA: 0x7E2D10 Offset: 0x7E1310 VA: 0x1807E2D10
	public ConversationData GetConversation(int index) { }

	// RVA: 0x7E2BA0 Offset: 0x7E11A0 VA: 0x1807E2BA0 Slot: 159
	public virtual ConversationData GetConversationFor(BasePlayer player) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60 Slot: 157
	public bool ProviderBusy() { }

	[BaseEntity.Menu] // RVA: 0x7BCB0 Offset: 0x7B0B0 VA: 0x18007BCB0
	[BaseEntity.Menu.Description] // RVA: 0x7BCB0 Offset: 0x7B0B0 VA: 0x18007BCB0
	[BaseEntity.Menu.Icon] // RVA: 0x7BCB0 Offset: 0x7B0B0 VA: 0x18007BCB0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7BCB0 Offset: 0x7B0B0 VA: 0x18007BCB0
	// RVA: 0x7E30F0 Offset: 0x7E16F0 VA: 0x1807E30F0
	public void Menu_Talk(BasePlayer player) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	public bool Menu_Talk_ShowIf(BasePlayer player) { }

	// RVA: 0x7E2B00 Offset: 0x7E1100 VA: 0x1807E2B00 Slot: 155
	public void DoAction(string action) { }

	// RVA: 0x7E2CD0 Offset: 0x7E12D0 VA: 0x1807E2CD0 Slot: 156
	public Vector3 GetConversationWorldOrigin() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7E2A50 Offset: 0x7E1050 VA: 0x1807E2A50
	public void Client_StartConversation(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7E2B50 Offset: 0x7E1150 VA: 0x1807E2B50 Slot: 154
	public void EndConversation(bool fromServer) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7E2980 Offset: 0x7E0F80 VA: 0x1807E2980
	public void Client_ForceSpeechNode(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7E3CB0 Offset: 0x7E22B0 VA: 0x1807E3CB0 Slot: 153
	public void ResponsePressed(int index) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7E2970 Offset: 0x7E0F70 VA: 0x1807E2970
	public void Client_EndConversation(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7E25D0 Offset: 0x7E0BD0 VA: 0x1807E25D0
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

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
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

	// RVA: 0x7D3C00 Offset: 0x7D2200 VA: 0x1807D3C00
	public void .ctor() { }

}

public class NPCVendingOrderManifest : ScriptableObject // TypeDefIndex: 8724
{	// Fields
	public NPCVendingOrder[] orderList; // 0x18

	// Methods

	// RVA: 0x7E3EB0 Offset: 0x7E24B0 VA: 0x1807E3EB0
	public int GetIndex(NPCVendingOrder sample) { }

	// RVA: 0x7E3E70 Offset: 0x7E2470 VA: 0x1807E3E70
	public NPCVendingOrder GetFromIndex(int index) { }

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
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

	// RVA: 0x7E3E10 Offset: 0x7E2410 VA: 0x1807E3E10
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

	// RVA: 0x7E21B0 Offset: 0x7E07B0 VA: 0x1807E21B0
	public void .ctor() { }

}

public class NPCMissionProvider : NPCTalking, IMissionProvider // TypeDefIndex: 8849
{	// Fields
	public MissionManifest manifest; // 0x858

	// Methods

	// RVA: 0x52EE80 Offset: 0x52D480 VA: 0x18052EE80 Slot: 160
	public uint ProviderID() { }

	// RVA: 0x2FA9E0 Offset: 0x2F8FE0 VA: 0x1802FA9E0 Slot: 161
	public Vector3 ProviderPosition() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 162
	public BaseEntity Entity() { }

	// RVA: 0x7E25D0 Offset: 0x7E0BD0 VA: 0x1807E25D0
	public void .ctor() { }

}

public class NPCShopKeeper : NPCPlayer // TypeDefIndex: 8850
{	// Fields
	public EntityRef invisibleVendingMachineRef; // 0x7D8
	public InvisibleVendingMachine machine; // 0x7E8

	// Methods

	// RVA: 0x7E2730 Offset: 0x7E0D30 VA: 0x1807E2730
	public InvisibleVendingMachine GetVendingMachine() { }

	// RVA: 0x7E27D0 Offset: 0x7E0DD0 VA: 0x1807E27D0
	public void OnDrawGizmos() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 152
	public override void UpdateProtectionFromClothing() { }

	// RVA: 0x7E25D0 Offset: 0x7E0BD0 VA: 0x1807E25D0
	public void .ctor() { }

}

public class NPCPlayerCorpse : PlayerCorpse // TypeDefIndex: 8867
{	// Methods

	// RVA: 0x7E26C0 Offset: 0x7E0CC0 VA: 0x1807E26C0
	public void .ctor() { }

}

public class AICoverPoint : AIPoint // TypeDefIndex: 8903
{	// Fields
	public float coverDot; // 0x20

	// Methods

	// RVA: 0xA91460 Offset: 0xA8FA60 VA: 0x180A91460
	public void OnDrawGizmos() { }

	// RVA: 0xA91AB0 Offset: 0xA900B0 VA: 0x180A91AB0
	public void .ctor() { }

}

public class AICoverPointTool : MonoBehaviour // TypeDefIndex: 8904
{	// Methods

	[ContextMenu] // RVA: 0xC1FD0 Offset: 0xC13D0 VA: 0x1800C1FD0
	// RVA: 0xA90A10 Offset: 0xA8F010 VA: 0x180A90A10
	public void PlaceCoverPoints() { }

	// RVA: 0xA91140 Offset: 0xA8F740 VA: 0x180A91140
	private AICoverPointTool.TestResult TestPoint(Vector3 pos) { }

	// RVA: 0xA90DD0 Offset: 0xA8F3D0 VA: 0x180A90DD0
	private void PlacePoint(AICoverPointTool.TestResult result) { }

	// RVA: 0xA91010 Offset: 0xA8F610 VA: 0x180A91010
	private void PlacePoint(Vector3 pos, Vector3 dir) { }

	// RVA: 0xA90840 Offset: 0xA8EE40 VA: 0x180A90840
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
	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0
	public int get_X() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5DE3E0 Offset: 0x5DC9E0 VA: 0x1805DE3E0
	public int get_Z() { }

	// RVA: 0xA93440 Offset: 0xA91A40 VA: 0x180A93440
	public void .ctor(Bounds bounds, GameObject root, int x, int z) { }

	// RVA: 0xA93020 Offset: 0xA91620 VA: 0x180A93020
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
	|-RVA: 0xD5B0A0 Offset: 0xD596A0 VA: 0x180D5B0A0
	|-AIInformationCellContents<object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1885320 Offset: 0x1883920 VA: 0x181885320
	|-AIInformationCellContents<object>.get_Empty
	*/

	// RVA: -1 Offset: -1
	public void Init(Bounds cellBounds, GameObject root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1885120 Offset: 0x1883720 VA: 0x181885120
	|-AIInformationCellContents<AICoverPoint>.Init
	|-AIInformationCellContents<AIMovePoint>.Init
	|-AIInformationCellContents<object>.Init
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18850F0 Offset: 0x18836F0 VA: 0x1818850F0
	|-AIInformationCellContents<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1761E50 Offset: 0x1760450 VA: 0x181761E50
	|-AIInformationCellContents<object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1885270 Offset: 0x1883870 VA: 0x181885270
	|-AIInformationCellContents<object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18852A0 Offset: 0x18838A0 VA: 0x1818852A0
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
	// RVA: 0xA94120 Offset: 0xA92720 VA: 0x180A94120
	public void Init() { }

	// RVA: 0xA93E60 Offset: 0xA92460 VA: 0x180A93E60
	private int GetIndex(int x, int z) { }

	// RVA: 0xA93790 Offset: 0xA91D90 VA: 0x180A93790
	public AIInformationCell CellAt(int x, int z) { }

	// RVA: 0xA93E70 Offset: 0xA92470 VA: 0x180A93E70
	public AIMovePoint[] GetMovePointsInRange(Vector3 position, float maxRange, out int pointCount) { }

	// RVA: 0xA93BB0 Offset: 0xA921B0 VA: 0x180A93BB0
	public AICoverPoint[] GetCoverPointsInRange(Vector3 position, float maxRange, out int pointCount) { }

	// RVA: 0xA939A0 Offset: 0xA91FA0 VA: 0x180A939A0
	public AIInformationCell[] GetCellsInRange(Vector3 position, float maxRange, out int cellCount) { }

	// RVA: 0xA93880 Offset: 0xA91E80 VA: 0x180A93880
	public AIInformationCell GetCell(Vector3 position) { }

	// RVA: 0xA937D0 Offset: 0xA91DD0 VA: 0x180A937D0
	public void OnDrawGizmos() { }

	// RVA: 0xA937D0 Offset: 0xA91DD0 VA: 0x180A937D0
	public void DebugDraw() { }

	// RVA: 0xA94720 Offset: 0xA92D20 VA: 0x180A94720
	public void .ctor() { }

}

public class AIInformationGridTester : MonoBehaviour // TypeDefIndex: 8909
{	// Fields
	public AIInformationGrid Grid; // 0x18
	public float Range; // 0x20

	// Methods

	// RVA: 0xA935C0 Offset: 0xA91BC0 VA: 0x180A935C0
	public void OnDrawGizmos() { }

	// RVA: 0x4C7EC0 Offset: 0x4C64C0 VA: 0x1804C7EC0
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

	// RVA: 0xA94820 Offset: 0xA92E20 VA: 0x180A94820
	public void .ctor() { }

	// RVA: 0xA947C0 Offset: 0xA92DC0 VA: 0x180A947C0
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

	// RVA: 0xA95820 Offset: 0xA93E20 VA: 0x180A95820
	public void OnDrawGizmos() { }

	// RVA: 0xA954F0 Offset: 0xA93AF0 VA: 0x180A954F0
	public void DrawLookAtPoints() { }

	// RVA: 0xA954D0 Offset: 0xA93AD0 VA: 0x180A954D0
	public void Clear() { }

	// RVA: 0xA95430 Offset: 0xA93A30 VA: 0x180A95430
	public void AddLookAtPoint(Transform transform) { }

	// RVA: 0xA957E0 Offset: 0xA93DE0 VA: 0x180A957E0
	public bool HasLookAtPoints() { }

	// RVA: 0xA95770 Offset: 0xA93D70 VA: 0x180A95770
	public Transform GetRandomLookAtPoint() { }

	// RVA: 0xA958D0 Offset: 0xA93ED0 VA: 0x180A958D0
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

	// RVA: 0xA94B00 Offset: 0xA93100 VA: 0x180A94B00
	public void Clear() { }

	// RVA: 0xA94AA0 Offset: 0xA930A0 VA: 0x180A94AA0
	public void AddPoint(AIMovePoint point) { }

	// RVA: 0xA94D70 Offset: 0xA93370 VA: 0x180A94D70
	public AIMovePoint FindNearestPoint(Vector3 position) { }

	// RVA: 0xA94B50 Offset: 0xA93150 VA: 0x180A94B50
	public int FindNearestPointIndex(Vector3 position) { }

	// RVA: 0xA94ED0 Offset: 0xA934D0 VA: 0x180A94ED0
	public AIMovePoint GetPointAtIndex(int index) { }

	// RVA: 0xA94E00 Offset: 0xA93400 VA: 0x180A94E00
	public int GetNextPointIndex(int currentPointIndex, ref AIMovePointPath.PathDirection pathDirection) { }

	// RVA: 0xA95040 Offset: 0xA93640 VA: 0x180A95040
	private void OnDrawGizmos() { }

	// RVA: 0xA94F40 Offset: 0xA93540 VA: 0x180A94F40
	private void OnDrawGizmosSelected() { }

	[ContextMenu] // RVA: 0xC3830 Offset: 0xC2C30 VA: 0x1800C3830
	// RVA: 0xA94A00 Offset: 0xA93000 VA: 0x180A94A00
	public void AddChildPoints() { }

	// RVA: 0xA953B0 Offset: 0xA939B0 VA: 0x180A953B0
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

	// RVA: 0xA95B00 Offset: 0xA94100 VA: 0x180A95B00
	public bool InUse() { }

	// RVA: 0xA95B60 Offset: 0xA94160 VA: 0x180A95B60
	public bool IsUsedBy(BaseEntity user) { }

	// RVA: 0xA95970 Offset: 0xA93F70 VA: 0x180A95970
	public bool CanBeUsedBy(BaseEntity user) { }

	// RVA: 0xA95C60 Offset: 0xA94260 VA: 0x180A95C60
	public void SetUsedBy(BaseEntity user, float duration = 5) { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void SetUsedBy(BaseEntity user) { }

	// RVA: 0xA7E410 Offset: 0xA7CA10 VA: 0x180A7E410
	public void ClearUsed() { }

	// RVA: 0xA95A70 Offset: 0xA94070 VA: 0x180A95A70
	public void ClearIfUsedBy(BaseEntity user) { }

	// RVA: 0x521B80 Offset: 0x520180 VA: 0x180521B80
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

	// RVA: 0xA96D90 Offset: 0xA95390 VA: 0x180A96D90
	public void OnValidate() { }

	// RVA: 0xA968C0 Offset: 0xA94EC0 VA: 0x180A968C0 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0xA960E0 Offset: 0xA946E0 VA: 0x180A960E0
	public bool CanTraverse(BaseEntity ent) { }

	// RVA: 0xA96140 Offset: 0xA94740 VA: 0x180A96140
	public Transform GetClosestEntry(Vector3 position) { }

	// RVA: 0xA96790 Offset: 0xA94D90 VA: 0x180A96790
	public Transform GetFarthestEntry(Vector3 position) { }

	// RVA: 0xA96DF0 Offset: 0xA953F0 VA: 0x180A96DF0
	public void SetBusyFor(float dur = 1) { }

	// RVA: 0xA960E0 Offset: 0xA946E0 VA: 0x180A960E0
	public bool CanUse(Vector3 dirFrom) { }

	// RVA: 0xA96D70 Offset: 0xA95370 VA: 0x180A96D70 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0xA96270 Offset: 0xA94870 VA: 0x180A96270
	public AITraversalWaitPoint GetEntryPointNear(Vector3 pos) { }

	// RVA: 0xA96100 Offset: 0xA94700 VA: 0x180A96100
	public bool EntityFilter(BaseEntity ent) { }

	// RVA: 0xA96D80 Offset: 0xA95380 VA: 0x180A96D80 Slot: 9
	internal override void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0xA969C0 Offset: 0xA94FC0 VA: 0x180A969C0
	public void OnDrawGizmos() { }

	// RVA: 0x4D3840 Offset: 0x4D1E40 VA: 0x1804D3840
	public void .ctor() { }

}

public class AITraversalWaitPoint : MonoBehaviour // TypeDefIndex: 8918
{	// Fields
	public float nextFreeTime; // 0x18

	// Methods

	// RVA: 0xA96E20 Offset: 0xA95420 VA: 0x180A96E20
	public bool Occupied() { }

	// RVA: 0xA96E40 Offset: 0xA95440 VA: 0x180A96E40
	public void Occupy(float dur = 1) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class AnimalBrain : BaseAIBrain // TypeDefIndex: 8919
{	// Methods

	// RVA: 0x4A0A50 Offset: 0x49F050 VA: 0x1804A0A50
	public void .ctor() { }

}

public class AnimalRagdoll : Ragdoll // TypeDefIndex: 8926
{	// Fields
	public SkinnedMeshRenderer[] bodyRenderers; // 0x98
	public SkinnedMeshRenderer[] hairRenderers; // 0xA0

	// Methods

	// RVA: 0x829B50 Offset: 0x828150 VA: 0x180829B50
	public void .ctor() { }

}

public class AIThinkManager : BaseMonoBehaviour, IServerComponent // TypeDefIndex: 8929
{	// Methods

	// RVA: 0x521B80 Offset: 0x520180 VA: 0x180521B80
	public void .ctor() { }

}

public class ScientistBrain : BaseAIBrain // TypeDefIndex: 8933
{	// Methods

	// RVA: 0x4A0A50 Offset: 0x49F050 VA: 0x1804A0A50
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

	// RVA: 0x4A1040 Offset: 0x49F640 VA: 0x1804A1040
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

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 98
	public override bool get_IsNpc() { }

	// RVA: 0x7E25D0 Offset: 0x7E0BD0 VA: 0x1807E25D0
	public void .ctor() { }

}

public class NPCNavigator : BaseNavigator // TypeDefIndex: 8953
{	// Methods

	// RVA: 0x7E2660 Offset: 0x7E0C60 VA: 0x1807E2660
	public void .ctor() { }

}

public class NPCPlayerNavigator : BaseNavigator // TypeDefIndex: 8954
{	// Methods

	// RVA: 0x7E26D0 Offset: 0x7E0CD0 VA: 0x1807E26D0
	public void .ctor() { }

}

public class NPCPlayerNavigatorTester : BaseMonoBehaviour // TypeDefIndex: 8955
{	// Fields
	public BasePathNode TargetNode; // 0x18
	private BasePathNode currentNode; // 0x20

	// Methods

	// RVA: 0x521B80 Offset: 0x520180 VA: 0x180521B80
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

	// RVA: 0xAA2FE0 Offset: 0xAA15E0 VA: 0x180AA2FE0
	public static Vector3 GetModifiedAimConeDirection(float aimCone, Vector3 inputVec, bool anywhereInside = True) { }

	// RVA: 0xAA2F20 Offset: 0xAA1520 VA: 0x180AA2F20
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

	// RVA: 0x829D90 Offset: 0x828390 VA: 0x180829D90
	private void Start() { }

	// RVA: 0x829B60 Offset: 0x828160 VA: 0x180829B60
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

	// RVA: 0x8293E0 Offset: 0x8279E0 VA: 0x1808293E0
	private void Update() { }

	// RVA: 0x8292E0 Offset: 0x8278E0 VA: 0x1808292E0
	public bool ShouldPlayFootstep(AnimationEvent evt) { }

	// RVA: 0x828CF0 Offset: 0x8272F0 VA: 0x180828CF0
	private void FrontLeftFootstep(AnimationEvent evt) { }

	// RVA: 0x828D50 Offset: 0x827350 VA: 0x180828D50
	private void FrontRightFootstep(AnimationEvent evt) { }

	// RVA: 0x8289D0 Offset: 0x826FD0 VA: 0x1808289D0
	private void BackLeftFootstep(AnimationEvent evt) { }

	// RVA: 0x828A30 Offset: 0x827030 VA: 0x180828A30
	private void BackRightFootstep(AnimationEvent evt) { }

	// RVA: 0x828A90 Offset: 0x827090 VA: 0x180828A90
	private void Footstep(Transform tx) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void DoEffect(string effect) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private void PlayEffect(string effect) { }

	// RVA: 0x8290F0 Offset: 0x8276F0 VA: 0x1808290F0
	public void PlaySound(string soundName) { }

	// RVA: 0x8290A0 Offset: 0x8276A0 VA: 0x1808290A0
	public void PlaySoundDef(SoundDefinition def) { }

	// RVA: 0x828DB0 Offset: 0x8273B0 VA: 0x180828DB0
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

	// RVA: 0x829540 Offset: 0x827B40 VA: 0x180829540
	public bool GroundSample(Vector3 origin, out RaycastHit hit) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Start() { }

	// RVA: 0x829510 Offset: 0x827B10 VA: 0x180829510
	public AvatarIKGoal GoalFromIndex(int index) { }

	// RVA: 0x829670 Offset: 0x827C70 VA: 0x180829670
	private void OnAnimatorIK(int layerIndex) { }

	// RVA: 0x829B30 Offset: 0x828130 VA: 0x180829B30
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

	// RVA: 0x7E2450 Offset: 0x7E0A50 VA: 0x1807E2450
	private void FrontLeftFootstep() { }

	// RVA: 0x7E24A0 Offset: 0x7E0AA0 VA: 0x1807E24A0
	private void FrontRightFootstep() { }

	// RVA: 0x7E2210 Offset: 0x7E0810 VA: 0x1807E2210
	private void BackLeftFootstep() { }

	// RVA: 0x7E2260 Offset: 0x7E0860 VA: 0x1807E2260
	private void BackRightFootstep() { }

	// RVA: 0x7E22B0 Offset: 0x7E08B0 VA: 0x1807E22B0
	private void Footstep(Vector3 vFootPos) { }

	// RVA: 0x7E24F0 Offset: 0x7E0AF0 VA: 0x1807E24F0
	private void SetupFootstep(GameObject effect) { }

	// RVA: 0x7E2580 Offset: 0x7E0B80 VA: 0x1807E2580
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

	// RVA: 0x6A7AD0 Offset: 0x6A60D0 VA: 0x1806A7AD0
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
	// RVA: 0x57C970 Offset: 0x57AF70 VA: 0x18057C970
	private void set_Scope(AIDesignScope value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_Description(string value) { }

	// RVA: 0xA91DD0 Offset: 0xA903D0 VA: 0x180A91DD0
	public void SetAvailableStates(List<AIState> states) { }

	// RVA: 0xA91D70 Offset: 0xA90370 VA: 0x180A91D70
	public void Load(AIDesign design, BaseEntity owner) { }

	// RVA: 0xA91BC0 Offset: 0xA901C0 VA: 0x180A91BC0
	private void InitStateContainers(AIDesign design, BaseEntity owner) { }

	// RVA: 0xA91AC0 Offset: 0xA900C0 VA: 0x180A91AC0
	public AIStateContainer GetDefaultStateContainer() { }

	// RVA: 0xA91B40 Offset: 0xA90140 VA: 0x180A91B40
	public AIStateContainer GetStateContainerByID(int id) { }

	// RVA: 0xA91E60 Offset: 0xA90460 VA: 0x180A91E60
	public AIDesign ToProto(int currentStateID) { }

	// RVA: 0xA92190 Offset: 0xA90790 VA: 0x180A92190
	public void .ctor() { }

}

public static class AIDesigns // TypeDefIndex: 9380
{	// Fields
	public const string DesignFolderPath = "cfg/ai/";
	private static Dictionary<string, AIDesign> designs; // 0x1C30

	// Methods

	// RVA: 0xA92230 Offset: 0xA90830 VA: 0x180A92230
	public static AIDesign GetByNameOrInstance(string designName, AIDesign entityDesign) { }

	// RVA: 0xA92520 Offset: 0xA90B20 VA: 0x180A92520
	public static void RefreshCache(string designName, AIDesign design) { }

	// RVA: 0xA922F0 Offset: 0xA908F0 VA: 0x180A922F0
	private static AIDesign GetByName(string designName) { }

	// RVA: 0xA925F0 Offset: 0xA90BF0 VA: 0x180A925F0
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
	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_CurrentInputMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0
	private void set_CurrentInputMemorySlot(int value) { }

	// RVA: 0xA92A40 Offset: 0xA91040 VA: 0x180A92A40
	public void Init(IAIEventListener listener, AIStateContainer stateContainer, BaseEntity owner, AIBrainSenses senses) { }

	// RVA: 0xA92B30 Offset: 0xA91130 VA: 0x180A92B30
	private void RemoveAll() { }

	// RVA: 0xA92650 Offset: 0xA90C50 VA: 0x180A92650
	private void AddStateEvents(List<BaseAIEvent> events, BaseEntity owner) { }

	// RVA: 0xA92850 Offset: 0xA90E50 VA: 0x180A92850
	private void Add(BaseAIEvent aiEvent) { }

	// RVA: 0xA92B80 Offset: 0xA91180 VA: 0x180A92B80
	public void Tick(float deltaTime, StateStatus stateStatus) { }

	// RVA: 0xA92950 Offset: 0xA90F50 VA: 0x180A92950
	private int FindNextEventBlock() { }

	// RVA: 0xA92E40 Offset: 0xA91440 VA: 0x180A92E40
	public void .ctor() { }

}

public class AIMemory // TypeDefIndex: 9383
{	// Fields
	public AIMemoryBank<BaseEntity> Entity; // 0x10
	public AIMemoryBank<Vector3> Position; // 0x18
	public AIMemoryBank<AIPoint> AIPoint; // 0x20

	// Methods

	// RVA: 0xA94920 Offset: 0xA92F20 VA: 0x180A94920
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
	|-RVA: 0x18857E0 Offset: 0x1883DE0 VA: 0x1818857E0
	|-AIMemoryBank<AIPoint>..ctor
	|-AIMemoryBank<BaseEntity>..ctor
	|-AIMemoryBank<object>..ctor
	|-AIMemoryBank<Vector3>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Init(MemoryBankType type, int slots) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1885490 Offset: 0x1883A90 VA: 0x181885490
	|-AIMemoryBank<object>.Init
	|
	|-RVA: 0x1885540 Offset: 0x1883B40 VA: 0x181885540
	|-AIMemoryBank<Vector3>.Init
	*/

	// RVA: -1 Offset: -1
	public void Set(T item, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18856B0 Offset: 0x1883CB0 VA: 0x1818856B0
	|-AIMemoryBank<BaseEntity>.Set
	|-AIMemoryBank<object>.Set
	|
	|-RVA: 0x1885740 Offset: 0x1883D40 VA: 0x181885740
	|-AIMemoryBank<Vector3>.Set
	*/

	// RVA: -1 Offset: -1
	public T Get(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18853C0 Offset: 0x18839C0 VA: 0x1818853C0
	|-AIMemoryBank<BaseEntity>.Get
	|-AIMemoryBank<object>.Get
	|
	|-RVA: 0x1885410 Offset: 0x1883A10 VA: 0x181885410
	|-AIMemoryBank<Vector3>.Get
	*/

	// RVA: -1 Offset: -1
	public float GetTimeSinceSet(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1885350 Offset: 0x1883950 VA: 0x181885350
	|-AIMemoryBank<object>.GetTimeSinceSet
	|-AIMemoryBank<Vector3>.GetTimeSinceSet
	*/

	// RVA: -1 Offset: -1
	public void Remove(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18855F0 Offset: 0x1883BF0 VA: 0x1818855F0
	|-AIMemoryBank<object>.Remove
	|
	|-RVA: 0x1885650 Offset: 0x1883C50 VA: 0x181885650
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
	// RVA: 0x57C970 Offset: 0x57AF70 VA: 0x18057C970
	private void set_ID(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
	public AIState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x57C980 Offset: 0x57AF80 VA: 0x18057C980
	private void set_State(AIState value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	public int get_InputMemorySlot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D6C0 Offset: 0x69BCC0 VA: 0x18069D6C0
	private void set_InputMemorySlot(int value) { }

	// RVA: 0xA95D20 Offset: 0xA94320 VA: 0x180A95D20
	public void Init(AIStateContainer container, BaseEntity owner) { }

	// RVA: 0xA95F10 Offset: 0xA94510 VA: 0x180A95F10
	public AIStateContainer ToProto() { }

	// RVA: 0xA960D0 Offset: 0xA946D0 VA: 0x180A960D0
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

	// RVA: 0x7E21A0 Offset: 0x7E07A0 VA: 0x1807E21A0
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

	// RVA: 0xA92FA0 Offset: 0xA915A0 VA: 0x180A92FA0
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

	// RVA: 0x7E2940 Offset: 0x7E0F40 VA: 0x1807E2940
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
	// RVA: 0x6C9650 Offset: 0x6C7C50 VA: 0x1806C9650
	public static void aiDebug_lookat(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x6C9490 Offset: 0x6C7A90 VA: 0x1806C9490
	public static void aiDebug_LoadBalanceOverdueReport(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x85E00 Offset: 0x85200 VA: 0x180085E00
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void selectNPCLookat(ConsoleSystem.Arg args) { }

	// RVA: 0x6C90B0 Offset: 0x6C76B0 VA: 0x1806C90B0
	private static bool CheckLookingAtVisible(HitTest test, TraceInfo trace) { }

	// RVA: 0x6C9430 Offset: 0x6C7A30 VA: 0x1806C9430
	public void .ctor() { }

	// RVA: 0x6C9390 Offset: 0x6C7990 VA: 0x1806C9390
	private static void .cctor() { }

}

public class AiManagedAgent : FacepunchBehaviour, IServerComponent // TypeDefIndex: 12133
{	// Fields
	[TooltipAttribute] // RVA: 0xE0380 Offset: 0xDF780 VA: 0x1800E0380
	public int AgentTypeIndex; // 0x18

	// Methods

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
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

	// RVA: 0x4BAFC0 Offset: 0x4B95C0 VA: 0x1804BAFC0
	internal void OnEnableCover() { }

	// RVA: 0x4BAEE0 Offset: 0x4B94E0 VA: 0x1804BAEE0
	internal void OnDisableCover() { }

	// RVA: 0x4BAE50 Offset: 0x4B9450 VA: 0x1804BAE50
	public CoverPointVolume GetCoverVolumeContaining(Vector3 point) { }

	// RVA: 0x4BB080 Offset: 0x4B9680 VA: 0x1804BB080
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

	// RVA: 0x4C89D0 Offset: 0x4C6FD0 VA: 0x1804C89D0
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

	// RVA: 0x4BAD90 Offset: 0x4B9390 VA: 0x1804BAD90
	public AiLocationSpawner.SquadSpawnerLocation get_LocationType() { }

	// RVA: 0x4BAD80 Offset: 0x4B9380 VA: 0x1804BAD80
	public void .ctor() { }

	// RVA: 0x4BAD20 Offset: 0x4B9320 VA: 0x1804BAD20
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

	// RVA: 0x4BAE20 Offset: 0x4B9420 VA: 0x1804BAE20
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

	// RVA: 0x4C8940 Offset: 0x4C6F40 VA: 0x1804C8940
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

