public class PatternFirework : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6424
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public PatternFirework.Design design; // 0x18
	public int shellFuseLength; // 0x20

	// Methods

	// RVA: 0x1F99500 Offset: 0x1F97B00 VA: 0x181F99500
	public static void ResetToPool(PatternFirework instance) { }

	// RVA: 0x1F995B0 Offset: 0x1F97BB0 VA: 0x181F995B0
	public void ResetToPool() { }

	// RVA: 0x1F99390 Offset: 0x1F97990 VA: 0x181F99390 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F98730 Offset: 0x1F96D30 VA: 0x181F98730
	public void CopyTo(PatternFirework instance) { }

	// RVA: 0x1F987C0 Offset: 0x1F96DC0 VA: 0x181F987C0
	public PatternFirework Copy() { }

	// RVA: 0x1F99310 Offset: 0x1F97910 VA: 0x181F99310
	public static PatternFirework Deserialize(Stream stream) { }

	// RVA: 0x1F98890 Offset: 0x1F96E90 VA: 0x181F98890
	public static PatternFirework DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F98E60 Offset: 0x1F97460 VA: 0x181F98E60
	public static PatternFirework DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F98EF0 Offset: 0x1F974F0 VA: 0x181F98EF0
	public static PatternFirework Deserialize(byte[] buffer) { }

	// RVA: 0x1F994C0 Offset: 0x1F97AC0 VA: 0x181F994C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F99C20 Offset: 0x1F98220 VA: 0x181F99C20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F99C40 Offset: 0x1F98240 VA: 0x181F99C40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework previous) { }

	// RVA: 0x1F994E0 Offset: 0x1F97AE0 VA: 0x181F994E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F99210 Offset: 0x1F97810 VA: 0x181F99210
	public static PatternFirework Deserialize(byte[] buffer, PatternFirework instance, bool isDelta = False) { }

	// RVA: 0x1F99010 Offset: 0x1F97610 VA: 0x181F99010
	public static PatternFirework Deserialize(Stream stream, PatternFirework instance, bool isDelta) { }

	// RVA: 0x1F98910 Offset: 0x1F96F10 VA: 0x181F98910
	public static PatternFirework DeserializeLengthDelimited(Stream stream, PatternFirework instance, bool isDelta) { }

	// RVA: 0x1F98BD0 Offset: 0x1F971D0 VA: 0x181F98BD0
	public static PatternFirework DeserializeLength(Stream stream, int length, PatternFirework instance, bool isDelta) { }

	// RVA: 0x1F99660 Offset: 0x1F97C60 VA: 0x181F99660
	public static void SerializeDelta(Stream stream, PatternFirework instance, PatternFirework previous) { }

	// RVA: 0x1F99A30 Offset: 0x1F98030 VA: 0x181F99A30
	public static void Serialize(Stream stream, PatternFirework instance) { }

	// RVA: 0x1F99C10 Offset: 0x1F98210 VA: 0x181F99C10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F99C20 Offset: 0x1F98220 VA: 0x181F99C20
	public void ToProto(Stream stream) { }

	// RVA: 0x1F99920 Offset: 0x1F97F20 VA: 0x181F99920
	public static byte[] SerializeToBytes(PatternFirework instance) { }

	// RVA: 0x1F99870 Offset: 0x1F97E70 VA: 0x181F99870
	public static void SerializeLengthDelimited(Stream stream, PatternFirework instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class PatternFirework.Design : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6425
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<PatternFirework.Star> stars; // 0x18
	public ulong editedBy; // 0x20

	// Methods

	// RVA: 0x1F82A60 Offset: 0x1F81060 VA: 0x181F82A60
	public static void ResetToPool(PatternFirework.Design instance) { }

	// RVA: 0x1F82880 Offset: 0x1F80E80 VA: 0x181F82880
	public void ResetToPool() { }

	// RVA: 0x1F827C0 Offset: 0x1F80DC0 VA: 0x181F827C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F819C0 Offset: 0x1F7FFC0 VA: 0x181F819C0
	public void CopyTo(PatternFirework.Design instance) { }

	// RVA: 0x1F81B70 Offset: 0x1F80170 VA: 0x181F81B70
	public PatternFirework.Design Copy() { }

	// RVA: 0x1F82410 Offset: 0x1F80A10 VA: 0x181F82410
	public static PatternFirework.Design Deserialize(Stream stream) { }

	// RVA: 0x1F81F00 Offset: 0x1F80500 VA: 0x181F81F00
	public static PatternFirework.Design DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F82260 Offset: 0x1F80860 VA: 0x181F82260
	public static PatternFirework.Design DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F822F0 Offset: 0x1F808F0 VA: 0x181F822F0
	public static PatternFirework.Design Deserialize(byte[] buffer) { }

	// RVA: 0x1F82840 Offset: 0x1F80E40 VA: 0x181F82840
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F83290 Offset: 0x1F81890 VA: 0x181F83290 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F832B0 Offset: 0x1F818B0 VA: 0x181F832B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.Design previous) { }

	// RVA: 0x1F82860 Offset: 0x1F80E60 VA: 0x181F82860 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F826C0 Offset: 0x1F80CC0 VA: 0x181F826C0
	public static PatternFirework.Design Deserialize(byte[] buffer, PatternFirework.Design instance, bool isDelta = False) { }

	// RVA: 0x1F82490 Offset: 0x1F80A90 VA: 0x181F82490
	public static PatternFirework.Design Deserialize(Stream stream, PatternFirework.Design instance, bool isDelta) { }

	// RVA: 0x1F81BF0 Offset: 0x1F801F0 VA: 0x181F81BF0
	public static PatternFirework.Design DeserializeLengthDelimited(Stream stream, PatternFirework.Design instance, bool isDelta) { }

	// RVA: 0x1F81F80 Offset: 0x1F80580 VA: 0x181F81F80
	public static PatternFirework.Design DeserializeLength(Stream stream, int length, PatternFirework.Design instance, bool isDelta) { }

	// RVA: 0x1F82C40 Offset: 0x1F81240 VA: 0x181F82C40
	public static void SerializeDelta(Stream stream, PatternFirework.Design instance, PatternFirework.Design previous) { }

	// RVA: 0x1F83050 Offset: 0x1F81650 VA: 0x181F83050
	public static void Serialize(Stream stream, PatternFirework.Design instance) { }

	// RVA: 0x1F83280 Offset: 0x1F81880 VA: 0x181F83280
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F83290 Offset: 0x1F81890 VA: 0x181F83290
	public void ToProto(Stream stream) { }

	// RVA: 0x1F82F40 Offset: 0x1F81540 VA: 0x181F82F40
	public static byte[] SerializeToBytes(PatternFirework.Design instance) { }

	// RVA: 0x1F82E90 Offset: 0x1F81490 VA: 0x181F82E90
	public static void SerializeLengthDelimited(Stream stream, PatternFirework.Design instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class PatternFirework.Star : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6426
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector2 position; // 0x14
	public Color color; // 0x1C

	// Methods

	// RVA: 0x1F9C9F0 Offset: 0x1F9AFF0 VA: 0x181F9C9F0
	public static void ResetToPool(PatternFirework.Star instance) { }

	// RVA: 0x1F9CA80 Offset: 0x1F9B080 VA: 0x181F9CA80
	public void ResetToPool() { }

	// RVA: 0x1F9C7E0 Offset: 0x1F9ADE0 VA: 0x181F9C7E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F9BA30 Offset: 0x1F9A030 VA: 0x181F9BA30
	public void CopyTo(PatternFirework.Star instance) { }

	// RVA: 0x1F9BA60 Offset: 0x1F9A060 VA: 0x181F9BA60
	public PatternFirework.Star Copy() { }

	// RVA: 0x1F9C3E0 Offset: 0x1F9A9E0 VA: 0x181F9C3E0
	public static PatternFirework.Star Deserialize(Stream stream) { }

	// RVA: 0x1F9BD20 Offset: 0x1F9A320 VA: 0x181F9BD20
	public static PatternFirework.Star DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F9BFB0 Offset: 0x1F9A5B0 VA: 0x181F9BFB0
	public static PatternFirework.Star DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F9C590 Offset: 0x1F9AB90 VA: 0x181F9C590
	public static PatternFirework.Star Deserialize(byte[] buffer) { }

	// RVA: 0x1F9C860 Offset: 0x1F9AE60 VA: 0x181F9C860
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F9D240 Offset: 0x1F9B840 VA: 0x181F9D240 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F9D260 Offset: 0x1F9B860 VA: 0x181F9D260 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.Star previous) { }

	// RVA: 0x1F9C9D0 Offset: 0x1F9AFD0 VA: 0x181F9C9D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F9C040 Offset: 0x1F9A640 VA: 0x181F9C040
	public static PatternFirework.Star Deserialize(byte[] buffer, PatternFirework.Star instance, bool isDelta = False) { }

	// RVA: 0x1F9C260 Offset: 0x1F9A860 VA: 0x181F9C260
	public static PatternFirework.Star Deserialize(Stream stream, PatternFirework.Star instance, bool isDelta) { }

	// RVA: 0x1F9BAE0 Offset: 0x1F9A0E0 VA: 0x181F9BAE0
	public static PatternFirework.Star DeserializeLengthDelimited(Stream stream, PatternFirework.Star instance, bool isDelta) { }

	// RVA: 0x1F9BDA0 Offset: 0x1F9A3A0 VA: 0x181F9BDA0
	public static PatternFirework.Star DeserializeLength(Stream stream, int length, PatternFirework.Star instance, bool isDelta) { }

	// RVA: 0x1F9CB10 Offset: 0x1F9B110 VA: 0x181F9CB10
	public static void SerializeDelta(Stream stream, PatternFirework.Star instance, PatternFirework.Star previous) { }

	// RVA: 0x1F9D000 Offset: 0x1F9B600 VA: 0x181F9D000
	public static void Serialize(Stream stream, PatternFirework.Star instance) { }

	// RVA: 0x1F9D230 Offset: 0x1F9B830 VA: 0x181F9D230
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F9D240 Offset: 0x1F9B840 VA: 0x181F9D240
	public void ToProto(Stream stream) { }

	// RVA: 0x1F9CEF0 Offset: 0x1F9B4F0 VA: 0x181F9CEF0
	public static byte[] SerializeToBytes(PatternFirework.Star instance) { }

	// RVA: 0x1F9CE40 Offset: 0x1F9B440 VA: 0x181F9CE40
	public static void SerializeLengthDelimited(Stream stream, PatternFirework.Star instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1F9B0F0 Offset: 0x1F996F0 VA: 0x181F9B0F0
	public static void ResetToPool(PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F9B1D0 Offset: 0x1F997D0 VA: 0x181F9B1D0
	public void ResetToPool() { }

	// RVA: 0x1F9AD90 Offset: 0x1F99390 VA: 0x181F9AD90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F99C60 Offset: 0x1F98260 VA: 0x181F99C60
	public void CopyTo(PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F99CE0 Offset: 0x1F982E0 VA: 0x181F99CE0
	public PatternFirework.SavedDesign Copy() { }

	// RVA: 0x1F9A990 Offset: 0x1F98F90 VA: 0x181F9A990
	public static PatternFirework.SavedDesign Deserialize(Stream stream) { }

	// RVA: 0x1F99DB0 Offset: 0x1F983B0 VA: 0x181F99DB0
	public static PatternFirework.SavedDesign DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F9A390 Offset: 0x1F98990 VA: 0x181F9A390
	public static PatternFirework.SavedDesign DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F9A420 Offset: 0x1F98A20 VA: 0x181F9A420
	public static PatternFirework.SavedDesign Deserialize(byte[] buffer) { }

	// RVA: 0x1F9AEF0 Offset: 0x1F994F0 VA: 0x181F9AEF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F9B9F0 Offset: 0x1F99FF0 VA: 0x181F9B9F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F9BA10 Offset: 0x1F9A010 VA: 0x181F9BA10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PatternFirework.SavedDesign previous) { }

	// RVA: 0x1F9B0D0 Offset: 0x1F996D0 VA: 0x181F9B0D0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F9A6F0 Offset: 0x1F98CF0 VA: 0x181F9A6F0
	public static PatternFirework.SavedDesign Deserialize(byte[] buffer, PatternFirework.SavedDesign instance, bool isDelta = False) { }

	// RVA: 0x1F9ABB0 Offset: 0x1F991B0 VA: 0x181F9ABB0
	public static PatternFirework.SavedDesign Deserialize(Stream stream, PatternFirework.SavedDesign instance, bool isDelta) { }

	// RVA: 0x1F99E30 Offset: 0x1F98430 VA: 0x181F99E30
	public static PatternFirework.SavedDesign DeserializeLengthDelimited(Stream stream, PatternFirework.SavedDesign instance, bool isDelta) { }

	// RVA: 0x1F9A0F0 Offset: 0x1F986F0 VA: 0x181F9A0F0
	public static PatternFirework.SavedDesign DeserializeLength(Stream stream, int length, PatternFirework.SavedDesign instance, bool isDelta) { }

	// RVA: 0x1F9B2B0 Offset: 0x1F998B0 VA: 0x181F9B2B0
	public static void SerializeDelta(Stream stream, PatternFirework.SavedDesign instance, PatternFirework.SavedDesign previous) { }

	// RVA: 0x1F9B750 Offset: 0x1F99D50 VA: 0x181F9B750
	public static void Serialize(Stream stream, PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F9B9E0 Offset: 0x1F99FE0 VA: 0x181F9B9E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F9B9F0 Offset: 0x1F99FF0 VA: 0x181F9B9F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F9B640 Offset: 0x1F99C40 VA: 0x181F9B640
	public static byte[] SerializeToBytes(PatternFirework.SavedDesign instance) { }

	// RVA: 0x1F9B590 Offset: 0x1F99B90 VA: 0x181F9B590
	public static void SerializeLengthDelimited(Stream stream, PatternFirework.SavedDesign instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class PatternFirework : MortarFirework, IUGCBrowserEntity // TypeDefIndex: 8275
{	// Fields
	public const int CurrentVersion = 1;
	[HeaderAttribute] // RVA: 0xA3E90 Offset: 0xA3290 VA: 0x1800A3E90
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

	// RVA: 0x887510 Offset: 0x885B10 VA: 0x180887510 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x887FC0 Offset: 0x8865C0 VA: 0x180887FC0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x888960 Offset: 0x886F60 VA: 0x180888960 Slot: 146
	protected override void PreInitShell(FireworkShell shell) { }

	[BaseEntity.Menu] // RVA: 0xA3F20 Offset: 0xA3320 VA: 0x1800A3F20
	[BaseEntity.Menu.Description] // RVA: 0xA3F20 Offset: 0xA3320 VA: 0x1800A3F20
	[BaseEntity.Menu.Icon] // RVA: 0xA3F20 Offset: 0xA3320 VA: 0x1800A3F20
	[BaseEntity.Menu.ShowIf] // RVA: 0xA3F20 Offset: 0xA3320 VA: 0x1800A3F20
	// RVA: 0x888220 Offset: 0x886820 VA: 0x180888220
	public void MenuOpenDesigner(BasePlayer player) { }

	// RVA: 0x8881A0 Offset: 0x8867A0 VA: 0x1808881A0
	public bool MenuOpenDesigner_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x888840 Offset: 0x886E40 VA: 0x180888840
	private void OpenDesigner(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x888A70 Offset: 0x887070 VA: 0x180888A70
	public void SetFireworkDesign(PatternFirework.Design design) { }

	[BaseEntity.Menu] // RVA: 0xA4300 Offset: 0xA3700 VA: 0x1800A4300
	[BaseEntity.Menu.Description] // RVA: 0xA4300 Offset: 0xA3700 VA: 0x1800A4300
	[BaseEntity.Menu.Icon] // RVA: 0xA4300 Offset: 0xA3700 VA: 0x1800A4300
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4300 Offset: 0xA3700 VA: 0x1800A4300
	// RVA: 0x8882A0 Offset: 0x8868A0 VA: 0x1808882A0
	public void MenuShortFuse(BasePlayer player) { }

	// RVA: 0x888260 Offset: 0x886860 VA: 0x180888260
	public bool MenuShortFuse_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA4790 Offset: 0xA3B90 VA: 0x1800A4790
	[BaseEntity.Menu.Description] // RVA: 0xA4790 Offset: 0xA3B90 VA: 0x1800A4790
	[BaseEntity.Menu.Icon] // RVA: 0xA4790 Offset: 0xA3B90 VA: 0x1800A4790
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4790 Offset: 0xA3B90 VA: 0x1800A4790
	// RVA: 0x888150 Offset: 0x886750 VA: 0x180888150
	public void MenuMediumFuse(BasePlayer player) { }

	// RVA: 0x888110 Offset: 0x886710 VA: 0x180888110
	public bool MenuMediumFuse_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0xA4A90 Offset: 0xA3E90 VA: 0x1800A4A90
	[BaseEntity.Menu.Description] // RVA: 0xA4A90 Offset: 0xA3E90 VA: 0x1800A4A90
	[BaseEntity.Menu.Icon] // RVA: 0xA4A90 Offset: 0xA3E90 VA: 0x1800A4A90
	[BaseEntity.Menu.ShowIf] // RVA: 0xA4A90 Offset: 0xA3E90 VA: 0x1800A4A90
	// RVA: 0x8880C0 Offset: 0x8866C0 VA: 0x1808880C0
	public void MenuLongFuse(BasePlayer player) { }

	// RVA: 0x888080 Offset: 0x886680 VA: 0x180888080
	public bool MenuLongFuse_ShowIf(BasePlayer player) { }

	// RVA: 0x887F90 Offset: 0x886590 VA: 0x180887F90
	private float GetShellFuseLength() { }

	// RVA: 0x887560 Offset: 0x885B60 VA: 0x180887560 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x888B10 Offset: 0x887110 VA: 0x180888B10 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x8882F0 Offset: 0x8868F0 VA: 0x1808882F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x888AE0 Offset: 0x8870E0 VA: 0x180888AE0
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

