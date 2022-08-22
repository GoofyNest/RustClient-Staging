public class Telephone : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6390
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int lastNumber; // 0x14
	public int phoneNumber; // 0x18
	public uint usingPlayer; // 0x1C
	public string phoneName; // 0x20
	public PhoneDirectory savedNumbers; // 0x28
	public List<VoicemailEntry> voicemail; // 0x30

	// Methods

	// RVA: 0x1DCA3B0 Offset: 0x1DC89B0 VA: 0x181DCA3B0
	public static void ResetToPool(Telephone instance) { }

	// RVA: 0x1DCA600 Offset: 0x1DC8C00 VA: 0x181DCA600
	public void ResetToPool() { }

	// RVA: 0x1DCA020 Offset: 0x1DC8620 VA: 0x181DCA020 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC8810 Offset: 0x1DC6E10 VA: 0x181DC8810
	public void CopyTo(Telephone instance) { }

	// RVA: 0x1DC8990 Offset: 0x1DC6F90 VA: 0x181DC8990
	public Telephone Copy() { }

	// RVA: 0x1DC9650 Offset: 0x1DC7C50 VA: 0x181DC9650
	public static Telephone Deserialize(Stream stream) { }

	// RVA: 0x1DC8A10 Offset: 0x1DC7010 VA: 0x181DC8A10
	public static Telephone DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC8E70 Offset: 0x1DC7470 VA: 0x181DC8E70
	public static Telephone DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC92B0 Offset: 0x1DC78B0 VA: 0x181DC92B0
	public static Telephone Deserialize(byte[] buffer) { }

	// RVA: 0x1DCA0A0 Offset: 0x1DC86A0 VA: 0x181DCA0A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DCB1F0 Offset: 0x1DC97F0 VA: 0x181DCB1F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DCB210 Offset: 0x1DC9810 VA: 0x181DCB210 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Telephone previous) { }

	// RVA: 0x1DCA390 Offset: 0x1DC8990 VA: 0x181DCA390 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC9C50 Offset: 0x1DC8250 VA: 0x181DC9C50
	public static Telephone Deserialize(byte[] buffer, Telephone instance, bool isDelta = False) { }

	// RVA: 0x1DC9950 Offset: 0x1DC7F50 VA: 0x181DC9950
	public static Telephone Deserialize(Stream stream, Telephone instance, bool isDelta) { }

	// RVA: 0x1DC8A90 Offset: 0x1DC7090 VA: 0x181DC8A90
	public static Telephone DeserializeLengthDelimited(Stream stream, Telephone instance, bool isDelta) { }

	// RVA: 0x1DC8F00 Offset: 0x1DC7500 VA: 0x181DC8F00
	public static Telephone DeserializeLength(Stream stream, int length, Telephone instance, bool isDelta) { }

	// RVA: 0x1DCA850 Offset: 0x1DC8E50 VA: 0x181DCA850
	public static void SerializeDelta(Stream stream, Telephone instance, Telephone previous) { }

	// RVA: 0x1DCAE50 Offset: 0x1DC9450 VA: 0x181DCAE50
	public static void Serialize(Stream stream, Telephone instance) { }

	// RVA: 0x1DCB1E0 Offset: 0x1DC97E0 VA: 0x181DCB1E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DCB1F0 Offset: 0x1DC97F0 VA: 0x181DCB1F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1DCAD40 Offset: 0x1DC9340 VA: 0x181DCAD40
	public static byte[] SerializeToBytes(Telephone instance) { }

	// RVA: 0x1DCAC90 Offset: 0x1DC9290 VA: 0x181DCAC90
	public static void SerializeLengthDelimited(Stream stream, Telephone instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class Telephone : ContainerIOEntity, ICassettePlayer // TypeDefIndex: 8462
{	// Fields
	private Option __menuOption_Menu_Answer; // 0x378
	private Option __menuOption_Menu_MakeCall; // 0x3D0
	public const int MaxPhoneNameLength = 20;
	public const int MaxSavedNumbers = 10;
	public Transform PhoneHotspot; // 0x428
	public Transform AnsweringMachineHotspot; // 0x430
	public Transform[] HandsetRoots; // 0x438
	public ItemDefinition[] ValidCassettes; // 0x440
	public Transform ParentedHandsetTransform; // 0x448
	public LineRenderer CableLineRenderer; // 0x450
	public Transform CableStartPoint; // 0x458
	public Transform CableEndPoint; // 0x460
	public float LineDroopAmount; // 0x468
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Cassette <cachedCassette>k__BackingField; // 0x470
	public PhoneController Controller; // 0x478
	private Vector3[] cablePoints; // 0x480
	private static Telephone.CensoredNumbers censoredNumbers; // 0x0

	// Properties
	public override bool HasMenuOptions { get; }
	public Cassette cachedCassette { get; set; }
	private static string CensoredNumbersPath { get; }
	private static int CensoredNumbersVersion { get; }
	public BaseEntity ToBaseEntity { get; }

	// Methods

	// RVA: 0x7CEA60 Offset: 0x7CD060 VA: 0x1807CEA60 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7D2C30 Offset: 0x7D1230 VA: 0x1807D2C30 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7D0740 Offset: 0x7CED40 VA: 0x1807D0740 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D2DF0 Offset: 0x7D13F0 VA: 0x1807D2DF0
	public Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D06F0 Offset: 0x7CECF0 VA: 0x1807D06F0
	private void set_cachedCassette(Cassette value) { }

	[BaseEntity.Menu] // RVA: 0x8FBC0 Offset: 0x8EFC0 VA: 0x18008FBC0
	[BaseEntity.Menu.Description] // RVA: 0x8FBC0 Offset: 0x8EFC0 VA: 0x18008FBC0
	[BaseEntity.Menu.Icon] // RVA: 0x8FBC0 Offset: 0x8EFC0 VA: 0x18008FBC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8FBC0 Offset: 0x8EFC0 VA: 0x18008FBC0
	// RVA: 0x7D0470 Offset: 0x7CEA70 VA: 0x1807D0470
	public void Menu_MakeCall(BasePlayer player) { }

	// RVA: 0x7CE920 Offset: 0x7CCF20 VA: 0x1807CE920
	private void DelayedViewModelDeploy() { }

	// RVA: 0x7CF030 Offset: 0x7CD630 VA: 0x1807CF030
	public void HolsterViewmodel() { }

	[BaseEntity.Menu] // RVA: 0x8FF40 Offset: 0x8F340 VA: 0x18008FF40
	[BaseEntity.Menu.Description] // RVA: 0x8FF40 Offset: 0x8F340 VA: 0x18008FF40
	[BaseEntity.Menu.Icon] // RVA: 0x8FF40 Offset: 0x8F340 VA: 0x18008FF40
	[BaseEntity.Menu.ShowIf] // RVA: 0x8FF40 Offset: 0x8F340 VA: 0x18008FF40
	// RVA: 0x7D03A0 Offset: 0x7CE9A0 VA: 0x1807D03A0
	public void Menu_Answer(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D26A0 Offset: 0x7D0CA0 VA: 0x1807D26A0
	public void SetClientState(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7CF4F0 Offset: 0x7CDAF0 VA: 0x1807CF4F0
	private void LateUpdate() { }

	// RVA: 0x7CE350 Offset: 0x7CC950 VA: 0x1807CE350
	private void ApplyDroopCurve(Vector3[] points, Vector3 startPos, Vector3 endPos) { }

	// RVA: 0x7CF220 Offset: 0x7CD820 VA: 0x1807CF220
	private bool IsPhoneUsable(BasePlayer player) { }

	// RVA: 0x7CF190 Offset: 0x7CD790 VA: 0x1807CF190
	private bool IsPhoneRinging(BasePlayer player) { }

	// RVA: 0x7CF3E0 Offset: 0x7CD9E0 VA: 0x1807CF3E0
	private bool IsPlayerLookingAtPhone(BasePlayer player) { }

	// RVA: 0x7CF2D0 Offset: 0x7CD8D0 VA: 0x1807CF2D0
	private bool IsPlayerLookingAtAnsweringMachine(BasePlayer player) { }

	// RVA: 0x7D26E0 Offset: 0x7D0CE0 VA: 0x1807D26E0 Slot: 164
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7CE810 Offset: 0x7CCE10 VA: 0x1807CE810
	public void ClientOnDialFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7CE890 Offset: 0x7CCE90 VA: 0x1807CE890
	private void ClientReceiveAnsweringData(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7CE850 Offset: 0x7CCE50 VA: 0x1807CE850
	private void ClientPlayAnsweringMessage(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D06C0 Offset: 0x7CECC0 VA: 0x1807D06C0
	public void OnIncomingCallDuringCall() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0700 Offset: 0x7CED00 VA: 0x1807D0700
	public void OnReceivedVoice(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7D06F0 Offset: 0x7CECF0 VA: 0x1807D06F0 Slot: 168
	public void OnLoadedWithCassette(Cassette c) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7CE680 Offset: 0x7CCC80 VA: 0x1807CE680
	public void ClientOnCassetteChanged(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D2580 Offset: 0x7D0B80 VA: 0x1807D2580
	private void ReceivePhoneDirectory(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7CE8E0 Offset: 0x7CCEE0 VA: 0x1807CE8E0
	private void ClientToggleVoicemail(BaseEntity.RPCMessage msg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 169
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x7CF110 Offset: 0x7CD710 VA: 0x1807CF110
	public static bool IsNumberCensored(int number) { }

	// RVA: 0x7D2BB0 Offset: 0x7D11B0 VA: 0x1807D2BB0
	private static string get_CensoredNumbersPath() { }

	// RVA: 0x7D2C20 Offset: 0x7D1220 VA: 0x1807D2C20
	private static int get_CensoredNumbersVersion() { }

	// RVA: 0x7CFC40 Offset: 0x7CE240 VA: 0x1807CFC40
	private static void LoadCensoredNumbers() { }

	// RVA: 0x7D25C0 Offset: 0x7D0BC0 VA: 0x1807D25C0
	private static void SaveCensoredNumbers() { }

	// RVA: 0x7D28A0 Offset: 0x7D0EA0 VA: 0x1807D28A0
	public static void ToggleNumberCensorship(int number, bool state) { }

	// RVA: 0x7CFED0 Offset: 0x7CE4D0 VA: 0x1807CFED0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7CE5E0 Offset: 0x7CCBE0 VA: 0x1807CE5E0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 167
	public BaseEntity get_ToBaseEntity() { }

	// RVA: 0x7D0540 Offset: 0x7CEB40 VA: 0x1807D0540 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x7D2B50 Offset: 0x7D1150 VA: 0x1807D2B50
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public enum Telephone.CallState // TypeDefIndex: 8463
{	// Fields
	public int value__; // 0x0
	public const Telephone.CallState Idle = 0;
	public const Telephone.CallState Dialing = 1;
	public const Telephone.CallState Ringing = 2;
	public const Telephone.CallState InProcess = 3;

}

public enum Telephone.DialFailReason // TypeDefIndex: 8464
{	// Fields
	public int value__; // 0x0
	public const Telephone.DialFailReason TimedOut = 0;
	public const Telephone.DialFailReason Engaged = 1;
	public const Telephone.DialFailReason WrongNumber = 2;
	public const Telephone.DialFailReason CallSelf = 3;
	public const Telephone.DialFailReason RemoteHangUp = 4;
	public const Telephone.DialFailReason NetworkBusy = 5;
	public const Telephone.DialFailReason TimeOutDuringCall = 6;
	public const Telephone.DialFailReason SelfHangUp = 7;

}

private class Telephone.CensoredNumbers // TypeDefIndex: 8465
{	// Fields
	public List<int> numbers; // 0x10
	public int saveVersion; // 0x18

	// Methods

	// RVA: 0x1135820 Offset: 0x1133E20 VA: 0x181135820
	public void .ctor() { }

}

