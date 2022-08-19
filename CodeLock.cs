public class CodeLock : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6306
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public CodeLock.Private pv; // 0x18
	public bool hasCode; // 0x20
	public bool hasGuestCode; // 0x21

	// Methods

	// RVA: 0x20AF100 Offset: 0x20AD700 VA: 0x1820AF100
	public static void ResetToPool(CodeLock instance) { }

	// RVA: 0x20AF1C0 Offset: 0x20AD7C0 VA: 0x1820AF1C0
	public void ResetToPool() { }

	// RVA: 0x20AEF80 Offset: 0x20AD580 VA: 0x1820AEF80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20AE1A0 Offset: 0x20AC7A0 VA: 0x1820AE1A0
	public void CopyTo(CodeLock instance) { }

	// RVA: 0x20AE290 Offset: 0x20AC890 VA: 0x1820AE290
	public CodeLock Copy() { }

	// RVA: 0x20AEF00 Offset: 0x20AD500 VA: 0x1820AEF00
	public static CodeLock Deserialize(Stream stream) { }

	// RVA: 0x20AE3D0 Offset: 0x20AC9D0 VA: 0x1820AE3D0
	public static CodeLock DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20AEA20 Offset: 0x20AD020 VA: 0x1820AEA20
	public static CodeLock DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20AEDE0 Offset: 0x20AD3E0 VA: 0x1820AEDE0
	public static CodeLock Deserialize(byte[] buffer) { }

	// RVA: 0x20AF0C0 Offset: 0x20AD6C0 VA: 0x1820AF0C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20AF880 Offset: 0x20ADE80 VA: 0x1820AF880 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20AF8A0 Offset: 0x20ADEA0 VA: 0x1820AF8A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CodeLock previous) { }

	// RVA: 0x20AF0E0 Offset: 0x20AD6E0 VA: 0x1820AF0E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20AECE0 Offset: 0x20AD2E0 VA: 0x1820AECE0
	public static CodeLock Deserialize(byte[] buffer, CodeLock instance, bool isDelta = False) { }

	// RVA: 0x20AEAB0 Offset: 0x20AD0B0 VA: 0x1820AEAB0
	public static CodeLock Deserialize(Stream stream, CodeLock instance, bool isDelta) { }

	// RVA: 0x20AE450 Offset: 0x20ACA50 VA: 0x1820AE450
	public static CodeLock DeserializeLengthDelimited(Stream stream, CodeLock instance, bool isDelta) { }

	// RVA: 0x20AE750 Offset: 0x20ACD50 VA: 0x1820AE750
	public static CodeLock DeserializeLength(Stream stream, int length, CodeLock instance, bool isDelta) { }

	// RVA: 0x20AF280 Offset: 0x20AD880 VA: 0x1820AF280
	public static void SerializeDelta(Stream stream, CodeLock instance, CodeLock previous) { }

	// RVA: 0x20AF660 Offset: 0x20ADC60 VA: 0x1820AF660
	public static void Serialize(Stream stream, CodeLock instance) { }

	// RVA: 0x20AF870 Offset: 0x20ADE70 VA: 0x1820AF870
	public byte[] ToProtoBytes() { }

	// RVA: 0x20AF880 Offset: 0x20ADE80 VA: 0x1820AF880
	public void ToProto(Stream stream) { }

	// RVA: 0x20AF550 Offset: 0x20ADB50 VA: 0x1820AF550
	public static byte[] SerializeToBytes(CodeLock instance) { }

	// RVA: 0x20AF4A0 Offset: 0x20ADAA0 VA: 0x1820AF4A0
	public static void SerializeLengthDelimited(Stream stream, CodeLock instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class CodeLock.Private : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6307
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string code; // 0x18
	public List<ulong> users; // 0x20
	public string guestCode; // 0x28
	public List<ulong> guestUsers; // 0x30

	// Methods

	// RVA: 0x20BE300 Offset: 0x20BC900 VA: 0x1820BE300
	public static void ResetToPool(CodeLock.Private instance) { }

	// RVA: 0x20BE160 Offset: 0x20BC760 VA: 0x1820BE160
	public void ResetToPool() { }

	// RVA: 0x20BE0A0 Offset: 0x20BC6A0 VA: 0x1820BE0A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20BCBA0 Offset: 0x20BB1A0 VA: 0x1820BCBA0
	public void CopyTo(CodeLock.Private instance) { }

	// RVA: 0x20BCDC0 Offset: 0x20BB3C0 VA: 0x1820BCDC0
	public CodeLock.Private Copy() { }

	// RVA: 0x20BD760 Offset: 0x20BBD60 VA: 0x1820BD760
	public static CodeLock.Private Deserialize(Stream stream) { }

	// RVA: 0x20BD1D0 Offset: 0x20BB7D0 VA: 0x1820BD1D0
	public static CodeLock.Private DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20BD250 Offset: 0x20BB850 VA: 0x1820BD250
	public static CodeLock.Private DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20BDCF0 Offset: 0x20BC2F0 VA: 0x1820BDCF0
	public static CodeLock.Private Deserialize(byte[] buffer) { }

	// RVA: 0x20BE120 Offset: 0x20BC720 VA: 0x1820BE120
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20BEBE0 Offset: 0x20BD1E0 VA: 0x1820BEBE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20BEC00 Offset: 0x20BD200 VA: 0x1820BEC00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, CodeLock.Private previous) { }

	// RVA: 0x20BE140 Offset: 0x20BC740 VA: 0x1820BE140 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20BD660 Offset: 0x20BBC60 VA: 0x1820BD660
	public static CodeLock.Private Deserialize(byte[] buffer, CodeLock.Private instance, bool isDelta = False) { }

	// RVA: 0x20BDA40 Offset: 0x20BC040 VA: 0x1820BDA40
	public static CodeLock.Private Deserialize(Stream stream, CodeLock.Private instance, bool isDelta) { }

	// RVA: 0x20BCE40 Offset: 0x20BB440 VA: 0x1820BCE40
	public static CodeLock.Private DeserializeLengthDelimited(Stream stream, CodeLock.Private instance, bool isDelta) { }

	// RVA: 0x20BD2E0 Offset: 0x20BB8E0 VA: 0x1820BD2E0
	public static CodeLock.Private DeserializeLength(Stream stream, int length, CodeLock.Private instance, bool isDelta) { }

	// RVA: 0x20BE4A0 Offset: 0x20BCAA0 VA: 0x1820BE4A0
	public static void SerializeDelta(Stream stream, CodeLock.Private instance, CodeLock.Private previous) { }

	// RVA: 0x20BE930 Offset: 0x20BCF30 VA: 0x1820BE930
	public static void Serialize(Stream stream, CodeLock.Private instance) { }

	// RVA: 0x20BEBD0 Offset: 0x20BD1D0 VA: 0x1820BEBD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20BEBE0 Offset: 0x20BD1E0 VA: 0x1820BEBE0
	public void ToProto(Stream stream) { }

	// RVA: 0x20BE820 Offset: 0x20BCE20 VA: 0x1820BE820
	public static byte[] SerializeToBytes(CodeLock.Private instance) { }

	// RVA: 0x20BE770 Offset: 0x20BCD70 VA: 0x1820BE770
	public static void SerializeLengthDelimited(Stream stream, CodeLock.Private instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class CodeLock : BaseLock // TypeDefIndex: 8373
{	// Fields
	private Option __menuOption_Menu_ChangeGuestCode; // 0x1C8
	private Option __menuOption_Menu_ChangeLockCode; // 0x220
	private Option __menuOption_Menu_Lock; // 0x278
	private Option __menuOption_Menu_Unlock; // 0x2D0
	public GameObjectRef keyEnterDialog; // 0x328
	public GameObjectRef effectUnlocked; // 0x330
	public GameObjectRef effectLocked; // 0x338
	public GameObjectRef effectDenied; // 0x340
	public GameObjectRef effectCodeChanged; // 0x348
	public GameObjectRef effectShock; // 0x350
	private bool hasCode; // 0x358
	public const BaseEntity.Flags Flag_CodeEntryBlocked = 524288;
	public static readonly Translate.Phrase blockwarning; // 0x0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x579BE0 Offset: 0x5781E0 VA: 0x180579BE0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x57B140 Offset: 0x579740 VA: 0x18057B140 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x57AA20 Offset: 0x579020 VA: 0x18057AA20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x57A590 Offset: 0x578B90 VA: 0x18057A590
	public bool IsCodeEntryBlocked() { }

	// RVA: 0x57A5A0 Offset: 0x578BA0 VA: 0x18057A5A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0xD3E40 Offset: 0xD3240 VA: 0x1800D3E40
	[BaseEntity.Menu.Description] // RVA: 0xD3E40 Offset: 0xD3240 VA: 0x1800D3E40
	[BaseEntity.Menu.Icon] // RVA: 0xD3E40 Offset: 0xD3240 VA: 0x1800D3E40
	[BaseEntity.Menu.ShowIf] // RVA: 0xD3E40 Offset: 0xD3240 VA: 0x1800D3E40
	// RVA: 0x57A9E0 Offset: 0x578FE0 VA: 0x18057A9E0
	public void Menu_Unlock(BasePlayer player) { }

	// RVA: 0x57A9A0 Offset: 0x578FA0 VA: 0x18057A9A0
	public bool Menu_Unlock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD53A0 Offset: 0xD47A0 VA: 0x1800D53A0
	[BaseEntity.Menu.Description] // RVA: 0xD53A0 Offset: 0xD47A0 VA: 0x1800D53A0
	[BaseEntity.Menu.Icon] // RVA: 0xD53A0 Offset: 0xD47A0 VA: 0x1800D53A0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD53A0 Offset: 0xD47A0 VA: 0x1800D53A0
	// RVA: 0x57A960 Offset: 0x578F60 VA: 0x18057A960
	public void Menu_Lock(BasePlayer player) { }

	// RVA: 0x57A930 Offset: 0x578F30 VA: 0x18057A930
	public bool Menu_Lock_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD55E0 Offset: 0xD49E0 VA: 0x1800D55E0
	[BaseEntity.Menu.Description] // RVA: 0xD55E0 Offset: 0xD49E0 VA: 0x1800D55E0
	[BaseEntity.Menu.Icon] // RVA: 0xD55E0 Offset: 0xD49E0 VA: 0x1800D55E0
	[BaseEntity.Menu.ShowIf] // RVA: 0xD55E0 Offset: 0xD49E0 VA: 0x1800D55E0
	// RVA: 0x57A7D0 Offset: 0x578DD0 VA: 0x18057A7D0
	public void Menu_ChangeLockCode(BasePlayer player) { }

	// RVA: 0x57A790 Offset: 0x578D90 VA: 0x18057A790
	public bool Menu_ChangeLockCode_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xD5820 Offset: 0xD4C20 VA: 0x1800D5820
	[BaseEntity.Menu.Description] // RVA: 0xD5820 Offset: 0xD4C20 VA: 0x1800D5820
	[BaseEntity.Menu.Icon] // RVA: 0xD5820 Offset: 0xD4C20 VA: 0x1800D5820
	[BaseEntity.Menu.ShowIf] // RVA: 0xD5820 Offset: 0xD4C20 VA: 0x1800D5820
	// RVA: 0x57A630 Offset: 0x578C30 VA: 0x18057A630
	public void Menu_ChangeGuestCode(BasePlayer player) { }

	// RVA: 0x57A600 Offset: 0x578C00 VA: 0x18057A600
	public bool Menu_ChangeGuestCode_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x579A60 Offset: 0x578060 VA: 0x180579A60
	private void EnterUnlockCode(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x57B130 Offset: 0x579730 VA: 0x18057B130
	public void .ctor() { }

	// RVA: 0x57B0C0 Offset: 0x5796C0 VA: 0x18057B0C0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x57B060 Offset: 0x579660 VA: 0x18057B060
	private void <Menu_ChangeLockCode>b__23_0(string str) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x57B000 Offset: 0x579600 VA: 0x18057B000
	private void <Menu_ChangeGuestCode>b__25_0(string str) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x57AFB0 Offset: 0x5795B0 VA: 0x18057AFB0
	private void <EnterUnlockCode>b__27_0(string str) { }

}

