public class PatternFirework : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6424
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public PatternFirework.Design design; // 0x18
	public int shellFuseLength; // 0x20

	// Methods

	// RVA: 0x1F98BE0 Offset: 0x1F971E0 VA: 0x181F98BE0
	public static void ResetToPool(PatternFirework instance) { }

	// RVA: 0x1F98C90 Offset: 0x1F97290 VA: 0x181F98C90
	public void ResetToPool() { }

	// RVA: 0x1F98A70 Offset: 0x1F97070 VA: 0x181F98A70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F97E10 Offset: 0x1F96410 VA: 0x181F97E10
	public void CopyTo(PatternFirework instance) { }

	// RVA: 0x1F97EA0 Offset: 0x1F964A0 VA: 0x181F97EA0
	public PatternFirework Copy() { }

	// RVA: 0x1F989F0 Offset: 0x1F96FF0 VA: 0x181F989F0
	public static PatternFirework Deserialize(Stream stream) { }

	// RVA: 0x1F97F70 Offset: 0x1F96570 VA: 0x181F97F70
	public static PatternFirework DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F98540 Offset: 0x1F96B40 VA: 0x181F98540
	public static PatternFirework DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F985D0 Offset: 0x1F96BD0 VA: 0x181F985D0
	public static PatternFirework Deserialize(byte[] buffer) { }

	// RVA: 0x1F98BA0 Offset: 0x1F971A0 VA: 0x181F98BA0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F99300 Offset: 0x1F97900 VA: 0x181F99300 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F99320 Offset: 0x1F97920 VA: 0x181F99320 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework previous) { }

	// RVA: 0x1F98BC0 Offset: 0x1F971C0 VA: 0x181F98BC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F988F0 Offset: 0x1F96EF0 VA: 0x181F988F0
	public static PatternFirework Deserialize(byte[] buffer, PatternFirework instance, bool isDelta = False) { }

	// RVA: 0x1F986F0 Offset: 0x1F96CF0 VA: 0x181F986F0
	public static PatternFirework Deserialize(Stream stream, PatternFirework instance, bool isDelta) { }

	// RVA: 0x1F97FF0 Offset: 0x1F965F0 VA: 0x181F97FF0
	public static PatternFirework DeserializeLengthDelimited(Stream stream, PatternFirework instance, bool isDelta) { }

	// RVA: 0x1F982B0 Offset: 0x1F968B0 VA: 0x181F982B0
	public static PatternFirework DeserializeLength(Stream stream, int length, PatternFirework instance, bool isDelta) { }

	// RVA: 0x1F98D40 Offset: 0x1F97340 VA: 0x181F98D40
	public static void SerializeDelta(Stream stream, PatternFirework instance, PatternFirework previous) { }

	// RVA: 0x1F99110 Offset: 0x1F97710 VA: 0x181F99110
	public static void Serialize(Stream stream, PatternFirework instance) { }

	// RVA: 0x1F992F0 Offset: 0x1F978F0 VA: 0x181F992F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F99300 Offset: 0x1F97900 VA: 0x181F99300
	public void ToProto(Stream stream) { }

	// RVA: 0x1F99000 Offset: 0x1F97600 VA: 0x181F99000
	public static byte[] SerializeToBytes(PatternFirework instance) { }

	// RVA: 0x1F98F50 Offset: 0x1F97550 VA: 0x181F98F50
	public static void SerializeLengthDelimited(Stream stream, PatternFirework instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PatternFirework.Design : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6425
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<PatternFirework.Star> stars; // 0x18
	public ulong editedBy; // 0x20

	// Methods

	// RVA: 0x1F82140 Offset: 0x1F80740 VA: 0x181F82140
	public static void ResetToPool(PatternFirework.Design instance) { }

	// RVA: 0x1F81F60 Offset: 0x1F80560 VA: 0x181F81F60
	public void ResetToPool() { }

	// RVA: 0x1F81EA0 Offset: 0x1F804A0 VA: 0x181F81EA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F810A0 Offset: 0x1F7F6A0 VA: 0x181F810A0
	public void CopyTo(PatternFirework.Design instance) { }

	// RVA: 0x1F81250 Offset: 0x1F7F850 VA: 0x181F81250
	public PatternFirework.Design Copy() { }

	// RVA: 0x1F81AF0 Offset: 0x1F800F0 VA: 0x181F81AF0
	public static PatternFirework.Design Deserialize(Stream stream) { }

	// RVA: 0x1F815E0 Offset: 0x1F7FBE0 VA: 0x181F815E0
	public static PatternFirework.Design DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F81940 Offset: 0x1F7FF40 VA: 0x181F81940
	public static PatternFirework.Design DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F819D0 Offset: 0x1F7FFD0 VA: 0x181F819D0
	public static PatternFirework.Design Deserialize(byte[] buffer) { }

	// RVA: 0x1F81F20 Offset: 0x1F80520 VA: 0x181F81F20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F82970 Offset: 0x1F80F70 VA: 0x181F82970 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F82990 Offset: 0x1F80F90 VA: 0x181F82990 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.Design previous) { }

	// RVA: 0x1F81F40 Offset: 0x1F80540 VA: 0x181F81F40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F81DA0 Offset: 0x1F803A0 VA: 0x181F81DA0
	public static PatternFirework.Design Deserialize(byte[] buffer, PatternFirework.Design instance, bool isDelta = False) { }

	// RVA: 0x1F81B70 Offset: 0x1F80170 VA: 0x181F81B70
	public static PatternFirework.Design Deserialize(Stream stream, PatternFirework.Design instance, bool isDelta) { }

	// RVA: 0x1F812D0 Offset: 0x1F7F8D0 VA: 0x181F812D0
	public static PatternFirework.Design DeserializeLengthDelimited(Stream stream, PatternFirework.Design instance, bool isDelta) { }

	// RVA: 0x1F81660 Offset: 0x1F7FC60 VA: 0x181F81660
	public static PatternFirework.Design DeserializeLength(Stream stream, int length, PatternFirework.Design instance, bool isDelta) { }

	// RVA: 0x1F82320 Offset: 0x1F80920 VA: 0x181F82320
	public static void SerializeDelta(Stream stream, PatternFirework.Design instance, PatternFirework.Design previous) { }

	// RVA: 0x1F82730 Offset: 0x1F80D30 VA: 0x181F82730
	public static void Serialize(Stream stream, PatternFirework.Design instance) { }

	// RVA: 0x1F82960 Offset: 0x1F80F60 VA: 0x181F82960
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F82970 Offset: 0x1F80F70 VA: 0x181F82970
	public void ToProto(Stream stream) { }

	// RVA: 0x1F82620 Offset: 0x1F80C20 VA: 0x181F82620
	public static byte[] SerializeToBytes(PatternFirework.Design instance) { }

	// RVA: 0x1F82570 Offset: 0x1F80B70 VA: 0x181F82570
	public static void SerializeLengthDelimited(Stream stream, PatternFirework.Design instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PatternFirework.Star : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6426
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector2 position; // 0x14
	public Color color; // 0x1C

	// Methods

	// RVA: 0x1F9C0D0 Offset: 0x1F9A6D0 VA: 0x181F9C0D0
	public static void ResetToPool(PatternFirework.Star instance) { }

	// RVA: 0x1F9C160 Offset: 0x1F9A760 VA: 0x181F9C160
	public void ResetToPool() { }

	// RVA: 0x1F9BEC0 Offset: 0x1F9A4C0 VA: 0x181F9BEC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F9B110 Offset: 0x1F99710 VA: 0x181F9B110
	public void CopyTo(PatternFirework.Star instance) { }

	// RVA: 0x1F9B140 Offset: 0x1F99740 VA: 0x181F9B140
	public PatternFirework.Star Copy() { }

	// RVA: 0x1F9BAC0 Offset: 0x1F9A0C0 VA: 0x181F9BAC0
	public static PatternFirework.Star Deserialize(Stream stream) { }

	// RVA: 0x1F9B400 Offset: 0x1F99A00 VA: 0x181F9B400
	public static PatternFirework.Star DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F9B690 Offset: 0x1F99C90 VA: 0x181F9B690
	public static PatternFirework.Star DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F9BC70 Offset: 0x1F9A270 VA: 0x181F9BC70
	public static PatternFirework.Star Deserialize(byte[] buffer) { }

	// RVA: 0x1F9BF40 Offset: 0x1F9A540 VA: 0x181F9BF40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F9C920 Offset: 0x1F9AF20 VA: 0x181F9C920 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F9C940 Offset: 0x1F9AF40 VA: 0x181F9C940 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.Star previous) { }

	// RVA: 0x1F9C0B0 Offset: 0x1F9A6B0 VA: 0x181F9C0B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F9B720 Offset: 0x1F99D20 VA: 0x181F9B720
	public static PatternFirework.Star Deserialize(byte[] buffer, PatternFirework.Star instance, bool isDelta = False) { }

	// RVA: 0x1F9B940 Offset: 0x1F99F40 VA: 0x181F9B940
	public static PatternFirework.Star Deserialize(Stream stream, PatternFirework.Star instance, bool isDelta) { }

	// RVA: 0x1F9B1C0 Offset: 0x1F997C0 VA: 0x181F9B1C0
	public static PatternFirework.Star DeserializeLengthDelimited(Stream stream, PatternFirework.Star instance, bool isDelta) { }

	// RVA: 0x1F9B480 Offset: 0x1F99A80 VA: 0x181F9B480
	public static PatternFirework.Star DeserializeLength(Stream stream, int length, PatternFirework.Star instance, bool isDelta) { }

	// RVA: 0x1F9C1F0 Offset: 0x1F9A7F0 VA: 0x181F9C1F0
	public static void SerializeDelta(Stream stream, PatternFirework.Star instance, PatternFirework.Star previous) { }

	// RVA: 0x1F9C6E0 Offset: 0x1F9ACE0 VA: 0x181F9C6E0
	public static void Serialize(Stream stream, PatternFirework.Star instance) { }

	// RVA: 0x1F9C910 Offset: 0x1F9AF10 VA: 0x181F9C910
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F9C920 Offset: 0x1F9AF20 VA: 0x181F9C920
	public void ToProto(Stream stream) { }

	// RVA: 0x1F9C5D0 Offset: 0x1F9ABD0 VA: 0x181F9C5D0
	public static byte[] SerializeToBytes(PatternFirework.Star instance) { }

	// RVA: 0x1F9C520 Offset: 0x1F9AB20 VA: 0x181F9C520
	public static void SerializeLengthDelimited(Stream stream, PatternFirework.Star instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PatternFirework.SavedDesign : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6427
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int version; // 0x14
	public string name; // 0x18
	public PatternFirework.Design design; // 0x20

	// Methods

	// RVA: 0x1F9A7D0 Offset: 0x1F98DD0 VA: 0x181F9A7D0
	public static void ResetToPool(PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F9A8B0 Offset: 0x1F98EB0 VA: 0x181F9A8B0
	public void ResetToPool() { }

	// RVA: 0x1F9A470 Offset: 0x1F98A70 VA: 0x181F9A470 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F99340 Offset: 0x1F97940 VA: 0x181F99340
	public void CopyTo(PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F993C0 Offset: 0x1F979C0 VA: 0x181F993C0
	public PatternFirework.SavedDesign Copy() { }

	// RVA: 0x1F9A070 Offset: 0x1F98670 VA: 0x181F9A070
	public static PatternFirework.SavedDesign Deserialize(Stream stream) { }

	// RVA: 0x1F99490 Offset: 0x1F97A90 VA: 0x181F99490
	public static PatternFirework.SavedDesign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F99A70 Offset: 0x1F98070 VA: 0x181F99A70
	public static PatternFirework.SavedDesign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F99B00 Offset: 0x1F98100 VA: 0x181F99B00
	public static PatternFirework.SavedDesign Deserialize(byte[] buffer) { }

	// RVA: 0x1F9A5D0 Offset: 0x1F98BD0 VA: 0x181F9A5D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F9B0D0 Offset: 0x1F996D0 VA: 0x181F9B0D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F9B0F0 Offset: 0x1F996F0 VA: 0x181F9B0F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.SavedDesign previous) { }

	// RVA: 0x1F9A7B0 Offset: 0x1F98DB0 VA: 0x181F9A7B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F99DD0 Offset: 0x1F983D0 VA: 0x181F99DD0
	public static PatternFirework.SavedDesign Deserialize(byte[] buffer, PatternFirework.SavedDesign instance, bool isDelta = False) { }

	// RVA: 0x1F9A290 Offset: 0x1F98890 VA: 0x181F9A290
	public static PatternFirework.SavedDesign Deserialize(Stream stream, PatternFirework.SavedDesign instance, bool isDelta) { }

	// RVA: 0x1F99510 Offset: 0x1F97B10 VA: 0x181F99510
	public static PatternFirework.SavedDesign DeserializeLengthDelimited(Stream stream, PatternFirework.SavedDesign instance, bool isDelta) { }

	// RVA: 0x1F997D0 Offset: 0x1F97DD0 VA: 0x181F997D0
	public static PatternFirework.SavedDesign DeserializeLength(Stream stream, int length, PatternFirework.SavedDesign instance, bool isDelta) { }

	// RVA: 0x1F9A990 Offset: 0x1F98F90 VA: 0x181F9A990
	public static void SerializeDelta(Stream stream, PatternFirework.SavedDesign instance, PatternFirework.SavedDesign previous) { }

	// RVA: 0x1F9AE30 Offset: 0x1F99430 VA: 0x181F9AE30
	public static void Serialize(Stream stream, PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F9B0C0 Offset: 0x1F996C0 VA: 0x181F9B0C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F9B0D0 Offset: 0x1F996D0 VA: 0x181F9B0D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F9AD20 Offset: 0x1F99320 VA: 0x181F9AD20
	public static byte[] SerializeToBytes(PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F9AC70 Offset: 0x1F99270 VA: 0x181F9AC70
	public static void SerializeLengthDelimited(Stream stream, PatternFirework.SavedDesign instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class PatternFirework : MortarFirework, IUGCBrowserEntity // TypeDefIndex: 8275
{	// Fields
	public const int CurrentVersion = 1;
	[HeaderAttribute] // RVA: 0xA3E00 Offset: 0xA3200 VA: 0x1800A3E00
	public GameObjectRef FireworkDesignerDialog; // 0x270
	public int MaxStars; // 0x278
	public float ShellFuseLengthShort; // 0x27C
	public float ShellFuseLengthMed; // 0x280
	public float ShellFuseLengthLong; // 0x284
	public PatternFirework.Design Design; // 0x288
	public PatternFirework.FuseLength ShellFuseLength; // 0x290
	private Option __menuOption_MenuLongFuse; // 0x298
	private Option __menuOption_MenuMediumFuse; // 0x2F0
	private Option __menuOption_MenuOpenDesigner; // 0x348
	private Option __menuOption_MenuShortFuse; // 0x3A0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x86BCA0 Offset: 0x86A2A0 VA: 0x18086BCA0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x86C750 Offset: 0x86AD50 VA: 0x18086C750 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x86D0F0 Offset: 0x86B6F0 VA: 0x18086D0F0 Slot: 146
	protected override void PreInitShell(FireworkShell shell) { }

	[BaseEntity.Menu] // RVA: 0xA3E90 Offset: 0xA3290 VA: 0x1800A3E90
	[BaseEntity.Menu.Description] // RVA: 0xA3E90 Offset: 0xA3290 VA: 0x1800A3E90
	[BaseEntity.Menu.Icon] // RVA: 0xA3E90 Offset: 0xA3290 VA: 0x1800A3E90
	[BaseEntity.Menu.ShowIf] // RVA: 0xA3E90 Offset: 0xA3290 VA: 0x1800A3E90
	// RVA: 0x86C9B0 Offset: 0x86AFB0 VA: 0x18086C9B0
	public void MenuOpenDesigner(BasePlayer player) { }

	// RVA: 0x86C930 Offset: 0x86AF30 VA: 0x18086C930
	public bool MenuOpenDesigner_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x86CFD0 Offset: 0x86B5D0 VA: 0x18086CFD0
	private void OpenDesigner(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x86D200 Offset: 0x86B800 VA: 0x18086D200
	public void SetFireworkDesign(PatternFirework.Design design) { }

	[BaseEntity.Menu] // RVA: 0xA4270 Offset: 0xA3670 VA: 0x1800A4270
	[BaseEntity.Menu.Description] // RVA: 0xA4270 Offset: 0xA3670 VA: 0x1800A4270
	[BaseEntity.Menu.Icon] // RVA: 0xA4270 Offset: 0xA3670 VA: 0x1800A4270
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4270 Offset: 0xA3670 VA: 0x1800A4270
	// RVA: 0x86CA30 Offset: 0x86B030 VA: 0x18086CA30
	public void MenuShortFuse(BasePlayer player) { }

	// RVA: 0x86C9F0 Offset: 0x86AFF0 VA: 0x18086C9F0
	public bool MenuShortFuse_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA4700 Offset: 0xA3B00 VA: 0x1800A4700
	[BaseEntity.Menu.Description] // RVA: 0xA4700 Offset: 0xA3B00 VA: 0x1800A4700
	[BaseEntity.Menu.Icon] // RVA: 0xA4700 Offset: 0xA3B00 VA: 0x1800A4700
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4700 Offset: 0xA3B00 VA: 0x1800A4700
	// RVA: 0x86C8E0 Offset: 0x86AEE0 VA: 0x18086C8E0
	public void MenuMediumFuse(BasePlayer player) { }

	// RVA: 0x86C8A0 Offset: 0x86AEA0 VA: 0x18086C8A0
	public bool MenuMediumFuse_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA4A00 Offset: 0xA3E00 VA: 0x1800A4A00
	[BaseEntity.Menu.Description] // RVA: 0xA4A00 Offset: 0xA3E00 VA: 0x1800A4A00
	[BaseEntity.Menu.Icon] // RVA: 0xA4A00 Offset: 0xA3E00 VA: 0x1800A4A00
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4A00 Offset: 0xA3E00 VA: 0x1800A4A00
	// RVA: 0x86C850 Offset: 0x86AE50 VA: 0x18086C850
	public void MenuLongFuse(BasePlayer player) { }

	// RVA: 0x86C810 Offset: 0x86AE10 VA: 0x18086C810
	public bool MenuLongFuse_ShowIf(BasePlayer player) { }

	// RVA: 0x86C720 Offset: 0x86AD20 VA: 0x18086C720
	private float GetShellFuseLength() { }

	// RVA: 0x86BCF0 Offset: 0x86A2F0 VA: 0x18086BCF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x86D2A0 Offset: 0x86B8A0 VA: 0x18086D2A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x86CA80 Offset: 0x86B080 VA: 0x18086CA80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x86D270 Offset: 0x86B870 VA: 0x18086D270
	public void .ctor() { }

}

public enum PatternFirework.FuseLength // TypeDefIndex: 8276
{	// Fields
	public int value__; // 0x0
	public const PatternFirework.FuseLength Short = 0;
	public const PatternFirework.FuseLength Medium = 1;
	public const PatternFirework.FuseLength Long = 2;
	public const PatternFirework.FuseLength Max = 2;

}

