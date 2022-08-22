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

	// RVA: 0x1DC9900 Offset: 0x1DC7F00 VA: 0x181DC9900
	public static void ResetToPool(Telephone instance) { }

	// RVA: 0x1DC9B50 Offset: 0x1DC8150 VA: 0x181DC9B50
	public void ResetToPool() { }

	// RVA: 0x1DC9570 Offset: 0x1DC7B70 VA: 0x181DC9570 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC7D60 Offset: 0x1DC6360 VA: 0x181DC7D60
	public void CopyTo(Telephone instance) { }

	// RVA: 0x1DC7EE0 Offset: 0x1DC64E0 VA: 0x181DC7EE0
	public Telephone Copy() { }

	// RVA: 0x1DC8BA0 Offset: 0x1DC71A0 VA: 0x181DC8BA0
	public static Telephone Deserialize(Stream stream) { }

	// RVA: 0x1DC7F60 Offset: 0x1DC6560 VA: 0x181DC7F60
	public static Telephone DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC83C0 Offset: 0x1DC69C0 VA: 0x181DC83C0
	public static Telephone DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC8800 Offset: 0x1DC6E00 VA: 0x181DC8800
	public static Telephone Deserialize(byte[] buffer) { }

	// RVA: 0x1DC95F0 Offset: 0x1DC7BF0 VA: 0x181DC95F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DCA740 Offset: 0x1DC8D40 VA: 0x181DCA740 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DCA760 Offset: 0x1DC8D60 VA: 0x181DCA760 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Telephone previous) { }

	// RVA: 0x1DC98E0 Offset: 0x1DC7EE0 VA: 0x181DC98E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC91A0 Offset: 0x1DC77A0 VA: 0x181DC91A0
	public static Telephone Deserialize(byte[] buffer, Telephone instance, bool isDelta = False) { }

	// RVA: 0x1DC8EA0 Offset: 0x1DC74A0 VA: 0x181DC8EA0
	public static Telephone Deserialize(Stream stream, Telephone instance, bool isDelta) { }

	// RVA: 0x1DC7FE0 Offset: 0x1DC65E0 VA: 0x181DC7FE0
	public static Telephone DeserializeLengthDelimited(Stream stream, Telephone instance, bool isDelta) { }

	// RVA: 0x1DC8450 Offset: 0x1DC6A50 VA: 0x181DC8450
	public static Telephone DeserializeLength(Stream stream, int length, Telephone instance, bool isDelta) { }

	// RVA: 0x1DC9DA0 Offset: 0x1DC83A0 VA: 0x181DC9DA0
	public static void SerializeDelta(Stream stream, Telephone instance, Telephone previous) { }

	// RVA: 0x1DCA3A0 Offset: 0x1DC89A0 VA: 0x181DCA3A0
	public static void Serialize(Stream stream, Telephone instance) { }

	// RVA: 0x1DCA730 Offset: 0x1DC8D30 VA: 0x181DCA730
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DCA740 Offset: 0x1DC8D40 VA: 0x181DCA740
	public void ToProto(Stream stream) { }

	// RVA: 0x1DCA290 Offset: 0x1DC8890 VA: 0x181DCA290
	public static byte[] SerializeToBytes(Telephone instance) { }

	// RVA: 0x1DCA1E0 Offset: 0x1DC87E0 VA: 0x181DCA1E0
	public static void SerializeLengthDelimited(Stream stream, Telephone instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x7B0560 Offset: 0x7AEB60 VA: 0x1807B0560 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7B4730 Offset: 0x7B2D30 VA: 0x1807B4730 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7B2240 Offset: 0x7B0840 VA: 0x1807B2240 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B48F0 Offset: 0x7B2EF0 VA: 0x1807B48F0
	public Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B21F0 Offset: 0x7B07F0 VA: 0x1807B21F0
	private void set_cachedCassette(Cassette value) { }

	[BaseEntity.Menu] // RVA: 0x8FBC0 Offset: 0x8EFC0 VA: 0x18008FBC0
	[BaseEntity.Menu.Description] // RVA: 0x8FBC0 Offset: 0x8EFC0 VA: 0x18008FBC0
	[BaseEntity.Menu.Icon] // RVA: 0x8FBC0 Offset: 0x8EFC0 VA: 0x18008FBC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8FBC0 Offset: 0x8EFC0 VA: 0x18008FBC0
	// RVA: 0x7B1F70 Offset: 0x7B0570 VA: 0x1807B1F70
	public void Menu_MakeCall(BasePlayer player) { }

	// RVA: 0x7B0420 Offset: 0x7AEA20 VA: 0x1807B0420
	private void DelayedViewModelDeploy() { }

	// RVA: 0x7B0B30 Offset: 0x7AF130 VA: 0x1807B0B30
	public void HolsterViewmodel() { }

	[BaseEntity.Menu] // RVA: 0x8FF40 Offset: 0x8F340 VA: 0x18008FF40
	[BaseEntity.Menu.Description] // RVA: 0x8FF40 Offset: 0x8F340 VA: 0x18008FF40
	[BaseEntity.Menu.Icon] // RVA: 0x8FF40 Offset: 0x8F340 VA: 0x18008FF40
	[BaseEntity.Menu.ShowIf] // RVA: 0x8FF40 Offset: 0x8F340 VA: 0x18008FF40
	// RVA: 0x7B1EA0 Offset: 0x7B04A0 VA: 0x1807B1EA0
	public void Menu_Answer(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B41A0 Offset: 0x7B27A0 VA: 0x1807B41A0
	public void SetClientState(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7B0FF0 Offset: 0x7AF5F0 VA: 0x1807B0FF0
	private void LateUpdate() { }

	// RVA: 0x7AFE50 Offset: 0x7AE450 VA: 0x1807AFE50
	private void ApplyDroopCurve(Vector3[] points, Vector3 startPos, Vector3 endPos) { }

	// RVA: 0x7B0D20 Offset: 0x7AF320 VA: 0x1807B0D20
	private bool IsPhoneUsable(BasePlayer player) { }

	// RVA: 0x7B0C90 Offset: 0x7AF290 VA: 0x1807B0C90
	private bool IsPhoneRinging(BasePlayer player) { }

	// RVA: 0x7B0EE0 Offset: 0x7AF4E0 VA: 0x1807B0EE0
	private bool IsPlayerLookingAtPhone(BasePlayer player) { }

	// RVA: 0x7B0DD0 Offset: 0x7AF3D0 VA: 0x1807B0DD0
	private bool IsPlayerLookingAtAnsweringMachine(BasePlayer player) { }

	// RVA: 0x7B41E0 Offset: 0x7B27E0 VA: 0x1807B41E0 Slot: 164
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B0310 Offset: 0x7AE910 VA: 0x1807B0310
	public void ClientOnDialFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B0390 Offset: 0x7AE990 VA: 0x1807B0390
	private void ClientReceiveAnsweringData(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B0350 Offset: 0x7AE950 VA: 0x1807B0350
	private void ClientPlayAnsweringMessage(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B21C0 Offset: 0x7B07C0 VA: 0x1807B21C0
	public void OnIncomingCallDuringCall() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B2200 Offset: 0x7B0800 VA: 0x1807B2200
	public void OnReceivedVoice(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7B21F0 Offset: 0x7B07F0 VA: 0x1807B21F0 Slot: 168
	public void OnLoadedWithCassette(Cassette c) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B0180 Offset: 0x7AE780 VA: 0x1807B0180
	public void ClientOnCassetteChanged(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B4080 Offset: 0x7B2680 VA: 0x1807B4080
	private void ReceivePhoneDirectory(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B03E0 Offset: 0x7AE9E0 VA: 0x1807B03E0
	private void ClientToggleVoicemail(BaseEntity.RPCMessage msg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 169
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x7B0C10 Offset: 0x7AF210 VA: 0x1807B0C10
	public static bool IsNumberCensored(int number) { }

	// RVA: 0x7B46B0 Offset: 0x7B2CB0 VA: 0x1807B46B0
	private static string get_CensoredNumbersPath() { }

	// RVA: 0x7B4720 Offset: 0x7B2D20 VA: 0x1807B4720
	private static int get_CensoredNumbersVersion() { }

	// RVA: 0x7B1740 Offset: 0x7AFD40 VA: 0x1807B1740
	private static void LoadCensoredNumbers() { }

	// RVA: 0x7B40C0 Offset: 0x7B26C0 VA: 0x1807B40C0
	private static void SaveCensoredNumbers() { }

	// RVA: 0x7B43A0 Offset: 0x7B29A0 VA: 0x1807B43A0
	public static void ToggleNumberCensorship(int number, bool state) { }

	// RVA: 0x7B19D0 Offset: 0x7AFFD0 VA: 0x1807B19D0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7B00E0 Offset: 0x7AE6E0 VA: 0x1807B00E0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 167
	public BaseEntity get_ToBaseEntity() { }

	// RVA: 0x7B2040 Offset: 0x7B0640 VA: 0x1807B2040 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x7B4650 Offset: 0x7B2C50 VA: 0x1807B4650
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

	// RVA: 0x1134AF0 Offset: 0x11330F0 VA: 0x181134AF0
	public void .ctor() { }

}

