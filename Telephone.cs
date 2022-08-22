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

	// RVA: 0x1DC9BC0 Offset: 0x1DC81C0 VA: 0x181DC9BC0
	public static void ResetToPool(Telephone instance) { }

	// RVA: 0x1DC9E10 Offset: 0x1DC8410 VA: 0x181DC9E10
	public void ResetToPool() { }

	// RVA: 0x1DC9830 Offset: 0x1DC7E30 VA: 0x181DC9830 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1DC8020 Offset: 0x1DC6620 VA: 0x181DC8020
	public void CopyTo(Telephone instance) { }

	// RVA: 0x1DC81A0 Offset: 0x1DC67A0 VA: 0x181DC81A0
	public Telephone Copy() { }

	// RVA: 0x1DC8E60 Offset: 0x1DC7460 VA: 0x181DC8E60
	public static Telephone Deserialize(Stream stream) { }

	// RVA: 0x1DC8220 Offset: 0x1DC6820 VA: 0x181DC8220
	public static Telephone DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1DC8680 Offset: 0x1DC6C80 VA: 0x181DC8680
	public static Telephone DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1DC8AC0 Offset: 0x1DC70C0 VA: 0x181DC8AC0
	public static Telephone Deserialize(byte[] buffer) { }

	// RVA: 0x1DC98B0 Offset: 0x1DC7EB0 VA: 0x181DC98B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1DCAA00 Offset: 0x1DC9000 VA: 0x181DCAA00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1DCAA20 Offset: 0x1DC9020 VA: 0x181DCAA20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Telephone previous) { }

	// RVA: 0x1DC9BA0 Offset: 0x1DC81A0 VA: 0x181DC9BA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1DC9460 Offset: 0x1DC7A60 VA: 0x181DC9460
	public static Telephone Deserialize(byte[] buffer, Telephone instance, bool isDelta = False) { }

	// RVA: 0x1DC9160 Offset: 0x1DC7760 VA: 0x181DC9160
	public static Telephone Deserialize(Stream stream, Telephone instance, bool isDelta) { }

	// RVA: 0x1DC82A0 Offset: 0x1DC68A0 VA: 0x181DC82A0
	public static Telephone DeserializeLengthDelimited(Stream stream, Telephone instance, bool isDelta) { }

	// RVA: 0x1DC8710 Offset: 0x1DC6D10 VA: 0x181DC8710
	public static Telephone DeserializeLength(Stream stream, int length, Telephone instance, bool isDelta) { }

	// RVA: 0x1DCA060 Offset: 0x1DC8660 VA: 0x181DCA060
	public static void SerializeDelta(Stream stream, Telephone instance, Telephone previous) { }

	// RVA: 0x1DCA660 Offset: 0x1DC8C60 VA: 0x181DCA660
	public static void Serialize(Stream stream, Telephone instance) { }

	// RVA: 0x1DCA9F0 Offset: 0x1DC8FF0 VA: 0x181DCA9F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1DCAA00 Offset: 0x1DC9000 VA: 0x181DCAA00
	public void ToProto(Stream stream) { }

	// RVA: 0x1DCA550 Offset: 0x1DC8B50 VA: 0x181DCA550
	public static byte[] SerializeToBytes(Telephone instance) { }

	// RVA: 0x1DCA4A0 Offset: 0x1DC8AA0 VA: 0x181DCA4A0
	public static void SerializeLengthDelimited(Stream stream, Telephone instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x7B0670 Offset: 0x7AEC70 VA: 0x1807B0670 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7B4840 Offset: 0x7B2E40 VA: 0x1807B4840 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x7B2350 Offset: 0x7B0950 VA: 0x1807B2350 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B4A00 Offset: 0x7B3000 VA: 0x1807B4A00
	public Cassette get_cachedCassette() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B2300 Offset: 0x7B0900 VA: 0x1807B2300
	private void set_cachedCassette(Cassette value) { }

	[BaseEntity.Menu] // RVA: 0x8FBC0 Offset: 0x8EFC0 VA: 0x18008FBC0
	[BaseEntity.Menu.Description] // RVA: 0x8FBC0 Offset: 0x8EFC0 VA: 0x18008FBC0
	[BaseEntity.Menu.Icon] // RVA: 0x8FBC0 Offset: 0x8EFC0 VA: 0x18008FBC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8FBC0 Offset: 0x8EFC0 VA: 0x18008FBC0
	// RVA: 0x7B2080 Offset: 0x7B0680 VA: 0x1807B2080
	public void Menu_MakeCall(BasePlayer player) { }

	// RVA: 0x7B0530 Offset: 0x7AEB30 VA: 0x1807B0530
	private void DelayedViewModelDeploy() { }

	// RVA: 0x7B0C40 Offset: 0x7AF240 VA: 0x1807B0C40
	public void HolsterViewmodel() { }

	[BaseEntity.Menu] // RVA: 0x8FF40 Offset: 0x8F340 VA: 0x18008FF40
	[BaseEntity.Menu.Description] // RVA: 0x8FF40 Offset: 0x8F340 VA: 0x18008FF40
	[BaseEntity.Menu.Icon] // RVA: 0x8FF40 Offset: 0x8F340 VA: 0x18008FF40
	[BaseEntity.Menu.ShowIf] // RVA: 0x8FF40 Offset: 0x8F340 VA: 0x18008FF40
	// RVA: 0x7B1FB0 Offset: 0x7B05B0 VA: 0x1807B1FB0
	public void Menu_Answer(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B42B0 Offset: 0x7B28B0 VA: 0x1807B42B0
	public void SetClientState(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7B1100 Offset: 0x7AF700 VA: 0x1807B1100
	private void LateUpdate() { }

	// RVA: 0x7AFF60 Offset: 0x7AE560 VA: 0x1807AFF60
	private void ApplyDroopCurve(Vector3[] points, Vector3 startPos, Vector3 endPos) { }

	// RVA: 0x7B0E30 Offset: 0x7AF430 VA: 0x1807B0E30
	private bool IsPhoneUsable(BasePlayer player) { }

	// RVA: 0x7B0DA0 Offset: 0x7AF3A0 VA: 0x1807B0DA0
	private bool IsPhoneRinging(BasePlayer player) { }

	// RVA: 0x7B0FF0 Offset: 0x7AF5F0 VA: 0x1807B0FF0
	private bool IsPlayerLookingAtPhone(BasePlayer player) { }

	// RVA: 0x7B0EE0 Offset: 0x7AF4E0 VA: 0x1807B0EE0
	private bool IsPlayerLookingAtAnsweringMachine(BasePlayer player) { }

	// RVA: 0x7B42F0 Offset: 0x7B28F0 VA: 0x1807B42F0 Slot: 164
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B0420 Offset: 0x7AEA20 VA: 0x1807B0420
	public void ClientOnDialFailed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B04A0 Offset: 0x7AEAA0 VA: 0x1807B04A0
	private void ClientReceiveAnsweringData(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B0460 Offset: 0x7AEA60 VA: 0x1807B0460
	private void ClientPlayAnsweringMessage(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B22D0 Offset: 0x7B08D0 VA: 0x1807B22D0
	public void OnIncomingCallDuringCall() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B2310 Offset: 0x7B0910 VA: 0x1807B2310
	public void OnReceivedVoice(BaseEntity.RPCMessage msg) { }

	// RVA: 0x7B2300 Offset: 0x7B0900 VA: 0x1807B2300 Slot: 168
	public void OnLoadedWithCassette(Cassette c) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B0290 Offset: 0x7AE890 VA: 0x1807B0290
	public void ClientOnCassetteChanged(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B4190 Offset: 0x7B2790 VA: 0x1807B4190
	private void ReceivePhoneDirectory(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7B04F0 Offset: 0x7AEAF0 VA: 0x1807B04F0
	private void ClientToggleVoicemail(BaseEntity.RPCMessage msg) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 169
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x7B0D20 Offset: 0x7AF320 VA: 0x1807B0D20
	public static bool IsNumberCensored(int number) { }

	// RVA: 0x7B47C0 Offset: 0x7B2DC0 VA: 0x1807B47C0
	private static string get_CensoredNumbersPath() { }

	// RVA: 0x7B4830 Offset: 0x7B2E30 VA: 0x1807B4830
	private static int get_CensoredNumbersVersion() { }

	// RVA: 0x7B1850 Offset: 0x7AFE50 VA: 0x1807B1850
	private static void LoadCensoredNumbers() { }

	// RVA: 0x7B41D0 Offset: 0x7B27D0 VA: 0x1807B41D0
	private static void SaveCensoredNumbers() { }

	// RVA: 0x7B44B0 Offset: 0x7B2AB0 VA: 0x1807B44B0
	public static void ToggleNumberCensorship(int number, bool state) { }

	// RVA: 0x7B1AE0 Offset: 0x7B00E0 VA: 0x1807B1AE0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7B01F0 Offset: 0x7AE7F0 VA: 0x1807B01F0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 167
	public BaseEntity get_ToBaseEntity() { }

	// RVA: 0x7B2150 Offset: 0x7B0750 VA: 0x1807B2150 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x7B4760 Offset: 0x7B2D60 VA: 0x1807B4760
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

	// RVA: 0x1134DB0 Offset: 0x11333B0 VA: 0x181134DB0
	public void .ctor() { }

}

