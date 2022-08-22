public class InstrumentRecording : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6368
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<InstrumentRecordingNote> notes; // 0x18
	public int forInstrument; // 0x20

	// Methods

	// RVA: 0x1C0DEE0 Offset: 0x1C0C4E0 VA: 0x181C0DEE0
	public static void ResetToPool(InstrumentRecording instance) { }

	// RVA: 0x1C0DD00 Offset: 0x1C0C300 VA: 0x181C0DD00
	public void ResetToPool() { }

	// RVA: 0x1C0DC40 Offset: 0x1C0C240 VA: 0x181C0DC40 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C0CE20 Offset: 0x1C0B420 VA: 0x181C0CE20
	public void CopyTo(InstrumentRecording instance) { }

	// RVA: 0x1C0CFF0 Offset: 0x1C0B5F0 VA: 0x181C0CFF0
	public InstrumentRecording Copy() { }

	// RVA: 0x1C0D890 Offset: 0x1C0BE90 VA: 0x181C0D890
	public static InstrumentRecording Deserialize(Stream stream) { }

	// RVA: 0x1C0D070 Offset: 0x1C0B670 VA: 0x181C0D070
	public static InstrumentRecording DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C0D400 Offset: 0x1C0BA00 VA: 0x181C0D400
	public static InstrumentRecording DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C0D770 Offset: 0x1C0BD70 VA: 0x181C0D770
	public static InstrumentRecording Deserialize(byte[] buffer) { }

	// RVA: 0x1C0DCC0 Offset: 0x1C0C2C0 VA: 0x181C0DCC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C0E710 Offset: 0x1C0CD10 VA: 0x181C0E710 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C0E730 Offset: 0x1C0CD30 VA: 0x181C0E730 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InstrumentRecording previous) { }

	// RVA: 0x1C0DCE0 Offset: 0x1C0C2E0 VA: 0x181C0DCE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C0D910 Offset: 0x1C0BF10 VA: 0x181C0D910
	public static InstrumentRecording Deserialize(byte[] buffer, InstrumentRecording instance, bool isDelta = False) { }

	// RVA: 0x1C0DA10 Offset: 0x1C0C010 VA: 0x181C0DA10
	public static InstrumentRecording Deserialize(Stream stream, InstrumentRecording instance, bool isDelta) { }

	// RVA: 0x1C0D0F0 Offset: 0x1C0B6F0 VA: 0x181C0D0F0
	public static InstrumentRecording DeserializeLengthDelimited(Stream stream, InstrumentRecording instance, bool isDelta) { }

	// RVA: 0x1C0D490 Offset: 0x1C0BA90 VA: 0x181C0D490
	public static InstrumentRecording DeserializeLength(Stream stream, int length, InstrumentRecording instance, bool isDelta) { }

	// RVA: 0x1C0E0C0 Offset: 0x1C0C6C0 VA: 0x181C0E0C0
	public static void SerializeDelta(Stream stream, InstrumentRecording instance, InstrumentRecording previous) { }

	// RVA: 0x1C0E4D0 Offset: 0x1C0CAD0 VA: 0x181C0E4D0
	public static void Serialize(Stream stream, InstrumentRecording instance) { }

	// RVA: 0x1C0E700 Offset: 0x1C0CD00 VA: 0x181C0E700
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C0E710 Offset: 0x1C0CD10 VA: 0x181C0E710
	public void ToProto(Stream stream) { }

	// RVA: 0x1C0E3C0 Offset: 0x1C0C9C0 VA: 0x181C0E3C0
	public static byte[] SerializeToBytes(InstrumentRecording instance) { }

	// RVA: 0x1C0E310 Offset: 0x1C0C910 VA: 0x181C0E310
	public static void SerializeLengthDelimited(Stream stream, InstrumentRecording instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class InstrumentRecordingNote : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6369
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float startTime; // 0x14
	public float duration; // 0x18
	public int note; // 0x1C
	public int octave; // 0x20
	public float velocity; // 0x24
	public int noteType; // 0x28
	public bool shouldPlay; // 0x2C
	public bool hasPlayed; // 0x2D

	// Methods

	// RVA: 0x1C0C510 Offset: 0x1C0AB10 VA: 0x181C0C510
	public static void ResetToPool(InstrumentRecordingNote instance) { }

	// RVA: 0x1C0C5F0 Offset: 0x1C0ABF0 VA: 0x181C0C5F0
	public void ResetToPool() { }

	// RVA: 0x1C0C150 Offset: 0x1C0A750 VA: 0x181C0C150 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C0A890 Offset: 0x1C08E90 VA: 0x181C0A890
	public void CopyTo(InstrumentRecordingNote instance) { }

	// RVA: 0x1C0A8E0 Offset: 0x1C08EE0 VA: 0x181C0A8E0
	public InstrumentRecordingNote Copy() { }

	// RVA: 0x1C0BDE0 Offset: 0x1C0A3E0 VA: 0x181C0BDE0
	public static InstrumentRecordingNote Deserialize(Stream stream) { }

	// RVA: 0x1C0AD80 Offset: 0x1C09380 VA: 0x181C0AD80
	public static InstrumentRecordingNote DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C0AE00 Offset: 0x1C09400 VA: 0x181C0AE00
	public static InstrumentRecordingNote DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C0B9B0 Offset: 0x1C09FB0 VA: 0x181C0B9B0
	public static InstrumentRecordingNote Deserialize(byte[] buffer) { }

	// RVA: 0x1C0C1D0 Offset: 0x1C0A7D0 VA: 0x181C0C1D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C0CDE0 Offset: 0x1C0B3E0 VA: 0x181C0CDE0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C0CE00 Offset: 0x1C0B400 VA: 0x181C0CE00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InstrumentRecordingNote previous) { }

	// RVA: 0x1C0C4F0 Offset: 0x1C0AAF0 VA: 0x181C0C4F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C0B5A0 Offset: 0x1C09BA0 VA: 0x181C0B5A0
	public static InstrumentRecordingNote Deserialize(byte[] buffer, InstrumentRecordingNote instance, bool isDelta = False) { }

	// RVA: 0x1C0B270 Offset: 0x1C09870 VA: 0x181C0B270
	public static InstrumentRecordingNote Deserialize(Stream stream, InstrumentRecordingNote instance, bool isDelta) { }

	// RVA: 0x1C0A980 Offset: 0x1C08F80 VA: 0x181C0A980
	public static InstrumentRecordingNote DeserializeLengthDelimited(Stream stream, InstrumentRecordingNote instance, bool isDelta) { }

	// RVA: 0x1C0AE90 Offset: 0x1C09490 VA: 0x181C0AE90
	public static InstrumentRecordingNote DeserializeLength(Stream stream, int length, InstrumentRecordingNote instance, bool isDelta) { }

	// RVA: 0x1C0C6D0 Offset: 0x1C0ACD0 VA: 0x181C0C6D0
	public static void SerializeDelta(Stream stream, InstrumentRecordingNote instance, InstrumentRecordingNote previous) { }

	// RVA: 0x1C0CBF0 Offset: 0x1C0B1F0 VA: 0x181C0CBF0
	public static void Serialize(Stream stream, InstrumentRecordingNote instance) { }

	// RVA: 0x1C0CDD0 Offset: 0x1C0B3D0 VA: 0x181C0CDD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C0CDE0 Offset: 0x1C0B3E0 VA: 0x181C0CDE0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C0CAE0 Offset: 0x1C0B0E0 VA: 0x181C0CAE0
	public static byte[] SerializeToBytes(InstrumentRecordingNote instance) { }

	// RVA: 0x1C0CA30 Offset: 0x1C0B030 VA: 0x181C0CA30
	public static void SerializeLengthDelimited(Stream stream, InstrumentRecordingNote instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class InstrumentMidiBindings : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6370
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<InstrumentMidiBinding> bindings; // 0x18
	public uint forInstrument; // 0x20

	// Methods

	// RVA: 0x1C0A020 Offset: 0x1C08620 VA: 0x181C0A020
	public static void ResetToPool(InstrumentMidiBindings instance) { }

	// RVA: 0x1C09E40 Offset: 0x1C08440 VA: 0x181C09E40
	public void ResetToPool() { }

	// RVA: 0x1C09D80 Offset: 0x1C08380 VA: 0x181C09D80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C08E10 Offset: 0x1C07410 VA: 0x181C08E10
	public void CopyTo(InstrumentMidiBindings instance) { }

	// RVA: 0x1C08FC0 Offset: 0x1C075C0 VA: 0x181C08FC0
	public InstrumentMidiBindings Copy() { }

	// RVA: 0x1C099B0 Offset: 0x1C07FB0 VA: 0x181C099B0
	public static InstrumentMidiBindings Deserialize(Stream stream) { }

	// RVA: 0x1C094C0 Offset: 0x1C07AC0 VA: 0x181C094C0
	public static InstrumentMidiBindings DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C09540 Offset: 0x1C07B40 VA: 0x181C09540
	public static InstrumentMidiBindings DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C09A30 Offset: 0x1C08030 VA: 0x181C09A30
	public static InstrumentMidiBindings Deserialize(byte[] buffer) { }

	// RVA: 0x1C09E00 Offset: 0x1C08400 VA: 0x181C09E00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C0A850 Offset: 0x1C08E50 VA: 0x181C0A850 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C0A870 Offset: 0x1C08E70 VA: 0x181C0A870 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InstrumentMidiBindings previous) { }

	// RVA: 0x1C09E20 Offset: 0x1C08420 VA: 0x181C09E20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C098B0 Offset: 0x1C07EB0 VA: 0x181C098B0
	public static InstrumentMidiBindings Deserialize(byte[] buffer, InstrumentMidiBindings instance, bool isDelta = False) { }

	// RVA: 0x1C09B50 Offset: 0x1C08150 VA: 0x181C09B50
	public static InstrumentMidiBindings Deserialize(Stream stream, InstrumentMidiBindings instance, bool isDelta) { }

	// RVA: 0x1C091B0 Offset: 0x1C077B0 VA: 0x181C091B0
	public static InstrumentMidiBindings DeserializeLengthDelimited(Stream stream, InstrumentMidiBindings instance, bool isDelta) { }

	// RVA: 0x1C095D0 Offset: 0x1C07BD0 VA: 0x181C095D0
	public static InstrumentMidiBindings DeserializeLength(Stream stream, int length, InstrumentMidiBindings instance, bool isDelta) { }

	// RVA: 0x1C0A200 Offset: 0x1C08800 VA: 0x181C0A200
	public static void SerializeDelta(Stream stream, InstrumentMidiBindings instance, InstrumentMidiBindings previous) { }

	// RVA: 0x1C0A610 Offset: 0x1C08C10 VA: 0x181C0A610
	public static void Serialize(Stream stream, InstrumentMidiBindings instance) { }

	// RVA: 0x1C0A840 Offset: 0x1C08E40 VA: 0x181C0A840
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C0A850 Offset: 0x1C08E50 VA: 0x181C0A850
	public void ToProto(Stream stream) { }

	// RVA: 0x1C0A500 Offset: 0x1C08B00 VA: 0x181C0A500
	public static byte[] SerializeToBytes(InstrumentMidiBindings instance) { }

	// RVA: 0x1C0A450 Offset: 0x1C08A50 VA: 0x181C0A450
	public static void SerializeLengthDelimited(Stream stream, InstrumentMidiBindings instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class InstrumentMidiBinding : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6371
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int noteFrom; // 0x14
	public int note; // 0x18
	public int noteOctave; // 0x1C
	public int noteType; // 0x20

	// Methods

	// RVA: 0x1C08750 Offset: 0x1C06D50 VA: 0x181C08750
	public static void ResetToPool(InstrumentMidiBinding instance) { }

	// RVA: 0x1C087F0 Offset: 0x1C06DF0 VA: 0x181C087F0
	public void ResetToPool() { }

	// RVA: 0x1C084A0 Offset: 0x1C06AA0 VA: 0x181C084A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C072E0 Offset: 0x1C058E0 VA: 0x181C072E0
	public void CopyTo(InstrumentMidiBinding instance) { }

	// RVA: 0x1C07310 Offset: 0x1C05910 VA: 0x181C07310
	public InstrumentMidiBinding Copy() { }

	// RVA: 0x1C08250 Offset: 0x1C06850 VA: 0x181C08250
	public static InstrumentMidiBinding Deserialize(Stream stream) { }

	// RVA: 0x1C07390 Offset: 0x1C05990 VA: 0x181C07390
	public static InstrumentMidiBinding DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C079B0 Offset: 0x1C05FB0 VA: 0x181C079B0
	public static InstrumentMidiBinding DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C07F40 Offset: 0x1C06540 VA: 0x181C07F40
	public static InstrumentMidiBinding Deserialize(byte[] buffer) { }

	// RVA: 0x1C08520 Offset: 0x1C06B20 VA: 0x181C08520
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C08DD0 Offset: 0x1C073D0 VA: 0x181C08DD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C08DF0 Offset: 0x1C073F0 VA: 0x181C08DF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InstrumentMidiBinding previous) { }

	// RVA: 0x1C08730 Offset: 0x1C06D30 VA: 0x181C08730 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C07A40 Offset: 0x1C06040 VA: 0x181C07A40
	public static InstrumentMidiBinding Deserialize(byte[] buffer, InstrumentMidiBinding instance, bool isDelta = False) { }

	// RVA: 0x1C07D30 Offset: 0x1C06330 VA: 0x181C07D30
	public static InstrumentMidiBinding Deserialize(Stream stream, InstrumentMidiBinding instance, bool isDelta) { }

	// RVA: 0x1C07410 Offset: 0x1C05A10 VA: 0x181C07410
	public static InstrumentMidiBinding DeserializeLengthDelimited(Stream stream, InstrumentMidiBinding instance, bool isDelta) { }

	// RVA: 0x1C076F0 Offset: 0x1C05CF0 VA: 0x181C076F0
	public static InstrumentMidiBinding DeserializeLength(Stream stream, int length, InstrumentMidiBinding instance, bool isDelta) { }

	// RVA: 0x1C08890 Offset: 0x1C06E90 VA: 0x181C08890
	public static void SerializeDelta(Stream stream, InstrumentMidiBinding instance, InstrumentMidiBinding previous) { }

	// RVA: 0x1C08C70 Offset: 0x1C07270 VA: 0x181C08C70
	public static void Serialize(Stream stream, InstrumentMidiBinding instance) { }

	// RVA: 0x1C08DC0 Offset: 0x1C073C0 VA: 0x181C08DC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C08DD0 Offset: 0x1C073D0 VA: 0x181C08DD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1C08B60 Offset: 0x1C07160 VA: 0x181C08B60
	public static byte[] SerializeToBytes(InstrumentMidiBinding instance) { }

	// RVA: 0x1C08AB0 Offset: 0x1C070B0 VA: 0x181C08AB0
	public static void SerializeLengthDelimited(Stream stream, InstrumentMidiBinding instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public sealed class InstrumentNameEvent : BaseTextEvent // TypeDefIndex: 7537
{	// Methods

	// RVA: 0x1399470 Offset: 0x1397A70 VA: 0x181399470
	public void .ctor() { }

	// RVA: 0x1399490 Offset: 0x1397A90 VA: 0x181399490
	public void .ctor(string instrumentName) { }

	// RVA: 0x13993B0 Offset: 0x13979B0 VA: 0x1813993B0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x1399420 Offset: 0x1397A20 VA: 0x181399420 Slot: 3
	public override string ToString() { }

}

public class InstrumentTool : HeldEntity // TypeDefIndex: 8586
{	// Fields
	public InstrumentKeyController KeyController; // 0x1F8
	public SoundDefinition DeploySound; // 0x200
	public Vector2 PitchClamp; // 0x208
	public bool UseAnimationSlotEvents; // 0x210
	public Transform MuzzleT; // 0x218
	public bool UsableByAutoTurrets; // 0x220
	private InstrumentViewmodel instrumentView; // 0x228

	// Methods

	// RVA: 0x81E480 Offset: 0x81CA80 VA: 0x18081E480 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x81D700 Offset: 0x81BD00 VA: 0x18081D700 Slot: 136
	public override void ClampPitch(ref float pitch) { }

	// RVA: 0x81E260 Offset: 0x81C860 VA: 0x18081E260 Slot: 138
	public override void OnInput() { }

	// RVA: 0x81DA60 Offset: 0x81C060 VA: 0x18081DA60 Slot: 149
	public override float GetMovementMultiplier() { }

	// RVA: 0x81DB00 Offset: 0x81C100 VA: 0x18081DB00 Slot: 157
	protected virtual void LateUpdate() { }

	// RVA: 0x81DC40 Offset: 0x81C240 VA: 0x18081DC40 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0x81DBE0 Offset: 0x81C1E0 VA: 0x18081DBE0
	private void OnAnimationSlotSet(InstrumentKeyController.AnimationSlot slot) { }

	// RVA: 0x81E0C0 Offset: 0x81C6C0 VA: 0x18081E0C0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x81ED90 Offset: 0x81D390 VA: 0x18081ED90 Slot: 147
	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0x81DEF0 Offset: 0x81C4F0 VA: 0x18081DEF0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 158
	protected virtual void RemotePlayerDeploy(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 159
	protected virtual void RemotePlayerHolster(BasePlayer player) { }

	// RVA: 0x81EEA0 Offset: 0x81D4A0 VA: 0x18081EEA0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x81EFC0 Offset: 0x81D5C0 VA: 0x18081EFC0 Slot: 27
	public override void ResetState() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D7A0 Offset: 0x81BDA0 VA: 0x18081D7A0
	private void Client_PlayNote(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D920 Offset: 0x81BF20 VA: 0x18081D920
	private void Client_StopNote(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 156
	public override bool IsInstrument() { }

	// RVA: 0x81F090 Offset: 0x81D690 VA: 0x18081F090
	public void .ctor() { }

}

public class InstrumentStateBehaviour : StateMachineBehaviour // TypeDefIndex: 8742
{	// Fields
	private static readonly int[] targetState; // 0x0
	private static readonly int[] states; // 0x8
	public int ignoreIndex; // 0x18
	private float lastCrossfade; // 0x1C
	public float AnimatorCrossfadeDuration; // 0x20

	// Methods

	// RVA: 0x81D1E0 Offset: 0x81B7E0 VA: 0x18081D1E0 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x81D6E0 Offset: 0x81BCE0 VA: 0x18081D6E0
	public void .ctor() { }

	// RVA: 0x81D3E0 Offset: 0x81B9E0 VA: 0x18081D3E0
	private static void .cctor() { }

}

public class InstrumentViewmodel : MonoBehaviour // TypeDefIndex: 8743
{	// Fields
	public Animator ViewAnimator; // 0x18
	public bool UpdateA; // 0x20
	public bool UpdateB; // 0x21
	public bool UpdateC; // 0x22
	public bool UpdateD; // 0x23
	public bool UpdateE; // 0x24
	public bool UpdateF; // 0x25
	public bool UpdateG; // 0x26
	public bool UpdateRecentlyPlayed; // 0x27
	public bool UpdatePlayedNoteTrigger; // 0x28
	public bool UseTriggers; // 0x29
	private readonly int note_a; // 0x2C
	private readonly int note_b; // 0x30
	private readonly int note_c; // 0x34
	private readonly int note_d; // 0x38
	private readonly int note_e; // 0x3C
	private readonly int note_f; // 0x40
	private readonly int note_g; // 0x44
	private readonly int recentlyPlayedHash; // 0x48
	private readonly int playedNoteHash; // 0x4C

	// Methods

	// RVA: 0xA23A30 Offset: 0xA22030 VA: 0x180A23A30
	public void UpdateSlots(InstrumentKeyController.AnimationSlot currentSlot, bool recentlyPlayed, bool playedNoteThisFrame) { }

	// RVA: 0xA23CF0 Offset: 0xA222F0 VA: 0x180A23CF0
	private void UpdateState(int param, bool state) { }

	// RVA: 0xA23D40 Offset: 0xA22340 VA: 0x180A23D40
	public void .ctor() { }

}

public class InstrumentToolGuitar : InstrumentTool // TypeDefIndex: 9468
{	// Fields
	public Transform InUseAligner; // 0x230
	public Transform DeployAligner; // 0x238
	public string DeployBone; // 0x240
	private Transform handBoneTarget; // 0x248
	private static readonly int deployHash; // 0x0

	// Methods

	// RVA: 0xA235B0 Offset: 0xA21BB0 VA: 0x180A235B0 Slot: 157
	protected override void LateUpdate() { }

	// RVA: 0xA23930 Offset: 0xA21F30 VA: 0x180A23930 Slot: 147
	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0xA237D0 Offset: 0xA21DD0 VA: 0x180A237D0 Slot: 145
	public override void OnReliableEvent(string name) { }

	// RVA: 0xA234F0 Offset: 0xA21AF0 VA: 0x180A234F0
	public void DeployBegin() { }

	// RVA: 0xA23550 Offset: 0xA21B50 VA: 0x180A23550
	public void DeployComplete() { }

	// RVA: 0xA238F0 Offset: 0xA21EF0 VA: 0x180A238F0 Slot: 150
	public override void OnSpawnedForWorkshopPreview() { }

	// RVA: 0xA23A20 Offset: 0xA22020 VA: 0x180A23A20
	public void .ctor() { }

	// RVA: 0xA239D0 Offset: 0xA21FD0 VA: 0x180A239D0
	private static void .cctor() { }

}

public class InstrumentDebugInput : MonoBehaviour // TypeDefIndex: 9549
{	// Fields
	public InstrumentKeyController KeyController; // 0x18
	public InstrumentKeyController.KeySet Note; // 0x20
	public float Frequency; // 0x2C
	public float StopAfter; // 0x30
	public SoundDefinition OverrideDefinition; // 0x38

	// Methods

	// RVA: 0x815E20 Offset: 0x814420 VA: 0x180815E20
	public void .ctor() { }

}

public class InstrumentIKController : MonoBehaviour // TypeDefIndex: 9550
{	// Fields
	public Vector3 HitRotationVector; // 0x18
	public Transform[] LeftHandIkTargets; // 0x28
	public Transform[] LeftHandIKTargetHitRotations; // 0x30
	public Transform[] RightHandIkTargets; // 0x38
	public Transform[] RightHandIKTargetHitRotations; // 0x40
	public Transform[] RightFootIkTargets; // 0x48
	public AnimationCurve HandHeightCurve; // 0x50
	public float HandHeightMultiplier; // 0x58
	public float HandMoveLerpSpeed; // 0x5C
	public bool DebugHitRotation; // 0x60
	public AnimationCurve HandHitCurve; // 0x68
	public float NoteHitTime; // 0x70
	[HeaderAttribute] // RVA: 0x76FB0 Offset: 0x763B0 VA: 0x180076FB0
	public float BodyLookWeight; // 0x74
	public float HeadLookWeight; // 0x78
	public float LookWeightLimit; // 0x7C
	public bool HoldHandsAtPlay; // 0x80
	private int currentLeftHandTarget; // 0x84
	private float leftHandTargetNoteTime; // 0x88
	private int currentRightHandTarget; // 0x8C
	private float rightHandTargetNoteTime; // 0x90
	private int currentRightFootTarget; // 0x94
	private float rightFootTargetNoteTime; // 0x98
	private Vector3 leftHandIkPos; // 0x9C
	private Vector3 rightHandIkPos; // 0xA8
	private Vector3 rightFootIkPos; // 0xB4
	private Transform iKWorkerTransform; // 0xC0
	private Transform rotationWorker; // 0xC8
	private float totalHandAnimTime; // 0xD0
	private float lastSetLeftHandTime; // 0xD4
	private float lastSetRightHandTime; // 0xD8
	private float lastSetRightFootTime; // 0xDC

	// Methods

	// RVA: 0x816130 Offset: 0x814730 VA: 0x180816130
	public void HoldHandsUpdate(InstrumentKeyController key) { }

	// RVA: 0x8166C0 Offset: 0x814CC0 VA: 0x1808166C0
	public void UpdateIK(BasePlayer forPlayer) { }

	// RVA: 0x815E60 Offset: 0x814460 VA: 0x180815E60
	private Vector3 GetHandHeight(float noteTime) { }

	// RVA: 0x815FF0 Offset: 0x8145F0 VA: 0x180815FF0
	private Vector3 GetWorldSpaceIkTarget(int target, InstrumentKeyController.IKType type, Vector3 localOffset) { }

	// RVA: 0x815F60 Offset: 0x814560 VA: 0x180815F60
	private Transform GetHandTransform(int target, InstrumentKeyController.IKType type) { }

	// RVA: 0x815EF0 Offset: 0x8144F0 VA: 0x180815EF0
	private Transform GetHandRotationTransform(int target, InstrumentKeyController.IKType type) { }

	// RVA: 0x816350 Offset: 0x814950 VA: 0x180816350
	public void SetIkTarget(InstrumentKeyController.IKType type, int target) { }

	// RVA: 0x817030 Offset: 0x815630 VA: 0x180817030
	public void .ctor() { }

}

public class InstrumentIKTargetAttribute : PropertyAttribute // TypeDefIndex: 9551
{	// Methods

	// RVA: 0x517860 Offset: 0x515E60 VA: 0x180517860
	public void .ctor() { }

}

public class InstrumentKeyController : MonoBehaviour // TypeDefIndex: 9552
{	// Fields
	public static readonly int PlayingNoteParam; // 0x0
	public static readonly int AnimationSlot1; // 0x4
	public static readonly int AnimationSlot2; // 0x8
	public static readonly int AnimationSlot3; // 0xC
	public static readonly int AnimationSlot4; // 0x10
	public static readonly int AnimationSlot5; // 0x14
	public static readonly int AnimationSlot6; // 0x18
	public static readonly int AnimationSlot7; // 0x1C
	private float lastAnimationSlotTime; // 0x18
	public Action<InstrumentKeyController.AnimationSlot> OnAnimationSlotSet; // 0x20
	private Nullable<InstrumentKeyController.AnimationSlot> setSlot; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MicrophoneStandIOEntity <currentReceiver>k__BackingField; // 0x30
	private bool sustain; // 0x38
	private int lastMidiFrame; // 0x3C
	private int midiNotesThisFrame; // 0x40
	private InstrumentRecording activeRecording; // 0x48
	private string recordingFileName; // 0x50
	private float recordingStartTime; // 0x58
	private List<InstrumentRecordingNote> activeNotes; // 0x60
	private InstrumentRecording playingRecording; // 0x68
	private float playbackElapsedTime; // 0x70
	private List<int> stoppedNotes; // 0x78
	public const float DEFAULT_NOTE_VELOCITY = 1;
	public NoteBindingCollection Bindings; // 0x80
	public InstrumentKeyController.NoteBinding[] NoteBindings; // 0x88
	public Transform[] NoteSoundPositions; // 0x90
	public InstrumentIKController IKController; // 0x98
	public Transform LeftHandProp; // 0xA0
	public Transform RightHandProp; // 0xA8
	public Animator InstrumentAnimator; // 0xB0
	public BaseEntity RPCHandler; // 0xB8
	public uint overrideAchievementId; // 0xC0
	private const string ALL_INSTRUMENTS_ACHIEVEMENT_NAME = "PLAY_ALL_INSTRUMENTS";
	private const int INSTRUMENT_ACHIEVEMENT_COUNT = 11;
	private static HashSet<uint> playedInstruments; // 0x20
	private InstrumentKeyController.NoteBinding workerBinding; // 0xC8
	private BasePlayer midiPlayer; // 0xE0
	private bool playedFirstNote; // 0xE8
	private float teamAchievementCheck; // 0xEC
	private static bool awardedFullCollectionAchievement; // 0x28
	public TimeSince TimeInUse; // 0xF0
	private bool subscribedToMidi; // 0xF4
	private InstrumentMidiBindings activeMidiBindings; // 0xF8
	private bool hasSetupBindings; // 0x100
	private string autoplayPrefString; // 0x108
	private string autoplayDefaultName; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <FullKeyboardMode>k__BackingField; // 0x118
	private List<int> activeMidiNotes; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private InstrumentKeyController.AnimationSlot <CurrentAnimation>k__BackingField; // 0x128
	private BasePlayer OwnerPlayer; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <PlayedNoteThisFrame>k__BackingField; // 0x138

	// Properties
	public MicrophoneStandIOEntity currentReceiver { get; set; }
	public bool FullKeyboardMode { get; set; }
	public InstrumentKeyController.AnimationSlot CurrentAnimation { get; set; }
	public bool RecentlyPlayedNote { get; }
	private bool HeldByLocalPlayer { get; }
	private bool IsPlaying { get; }
	private int CurrentlyPlayingNotes { get; }
	public bool PlayedNoteThisFrame { get; set; }

	// Methods

	// RVA: 0x8174F0 Offset: 0x815AF0 VA: 0x1808174F0
	private void DisableProps() { }

	// RVA: 0x81C380 Offset: 0x81A980 VA: 0x18081C380
	private void UpdateHeldProps(BasePlayer forPlayer) { }

	// RVA: 0x81A290 Offset: 0x818890 VA: 0x18081A290
	private void RunInstrumentAnimation(BasePlayer forPlayer) { }

	// RVA: 0x81A810 Offset: 0x818E10 VA: 0x18081A810
	private void SetAnimationSlot(InstrumentKeyController.AnimationSlot slot, PlayerModel forPlayer) { }

	// RVA: 0x8175E0 Offset: 0x815BE0 VA: 0x1808175E0
	private int GetAnimationSlotHash(InstrumentKeyController.AnimationSlot slot) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public MicrophoneStandIOEntity get_currentReceiver() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_currentReceiver(MicrophoneStandIOEntity value) { }

	// RVA: 0x81AE60 Offset: 0x819460 VA: 0x18081AE60
	public bool SetCurrentReceiver(MicrophoneStandIOEntity receiver) { }

	// RVA: 0x817380 Offset: 0x815980 VA: 0x180817380
	public void ClearReceiver() { }

	// RVA: 0x81BF00 Offset: 0x81A500 VA: 0x18081BF00
	public void SubscribeToMidi(BasePlayer forPlayer) { }

	// RVA: 0x81C6B0 Offset: 0x81ACB0 VA: 0x18081C6B0
	public void UpdateMidiBindings() { }

	// RVA: 0x81C180 Offset: 0x81A780 VA: 0x18081C180
	public void UnsubscribeFromMidi() { }

	// RVA: 0x81A230 Offset: 0x818830 VA: 0x18081A230
	public void ResetState() { }

	// RVA: 0x819940 Offset: 0x817F40 VA: 0x180819940
	private void PlayNoteViaMIDI(int noteIndex, float velocity) { }

	// RVA: 0x81B760 Offset: 0x819D60 VA: 0x18081B760
	private void StopNoteViaMIDI(int noteIndex) { }

	// RVA: 0x818110 Offset: 0x816710 VA: 0x180818110
	private void NoteOnDelegate(MidiChannel channel, int note, float velocity) { }

	// RVA: 0x817E70 Offset: 0x816470 VA: 0x180817E70
	private void NoteOffDelegate(MidiChannel channel, int note) { }

	// RVA: 0x817970 Offset: 0x815F70 VA: 0x180817970
	private void KnobDelegate(MidiChannel channel, int knobNumber, float knobValue) { }

	// RVA: 0x8171C0 Offset: 0x8157C0 VA: 0x1808171C0
	private bool ApplyMidiRebinding(int inNote, out int index) { }

	// RVA: 0x8173A0 Offset: 0x8159A0 VA: 0x1808173A0
	private void ConvertMidiNoteToIndex(int note, out int index) { }

	// RVA: 0x81B360 Offset: 0x819960 VA: 0x18081B360
	public void StartRecording(string fileName) { }

	// RVA: 0x81BCE0 Offset: 0x81A2E0 VA: 0x18081BCE0
	public void StopRecording() { }

	// RVA: 0x819F90 Offset: 0x818590 VA: 0x180819F90
	private void RecordNoteStart(Notes note, int octave, float velocity, InstrumentKeyController.NoteType type, bool hold) { }

	// RVA: 0x81A080 Offset: 0x818680 VA: 0x18081A080
	private void RecordNoteStop(Notes note, int octave, InstrumentKeyController.NoteType type) { }

	// RVA: 0x819D00 Offset: 0x818300 VA: 0x180819D00
	public void PlayRecording(InstrumentRecording recording) { }

	// RVA: 0x81C750 Offset: 0x81AD50 VA: 0x18081C750
	private void UpdatePlayingRecording(BasePlayer forPlayer) { }

	// RVA: 0x81BCA0 Offset: 0x81A2A0 VA: 0x18081BCA0
	private void StopPlayingRecording() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81CEC0 Offset: 0x81B4C0 VA: 0x18081CEC0
	public bool get_FullKeyboardMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D1C0 Offset: 0x81B7C0 VA: 0x18081D1C0
	private void set_FullKeyboardMode(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81CDF0 Offset: 0x81B3F0 VA: 0x18081CDF0
	public InstrumentKeyController.AnimationSlot get_CurrentAnimation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D1B0 Offset: 0x81B7B0 VA: 0x18081D1B0
	private void set_CurrentAnimation(InstrumentKeyController.AnimationSlot value) { }

	// RVA: 0x81D180 Offset: 0x81B780 VA: 0x18081D180
	public bool get_RecentlyPlayedNote() { }

	// RVA: 0x81CED0 Offset: 0x81B4D0 VA: 0x18081CED0
	private bool get_HeldByLocalPlayer() { }

	// RVA: 0x81D060 Offset: 0x81B660 VA: 0x18081D060
	private bool get_IsPlaying() { }

	// RVA: 0x81CE00 Offset: 0x81B400 VA: 0x18081CE00
	private int get_CurrentlyPlayingNotes() { }

	// RVA: 0x81AF00 Offset: 0x819500 VA: 0x18081AF00
	public void SetFullKeyboardMode(bool state) { }

	// RVA: 0x8185F0 Offset: 0x816BF0 VA: 0x1808185F0
	public void OnInput(BasePlayer player) { }

	// RVA: 0x8185D0 Offset: 0x816BD0 VA: 0x1808185D0
	private void OnDisable() { }

	// RVA: 0x817880 Offset: 0x815E80 VA: 0x180817880
	public void InUseUpdate(BasePlayer forPlayer) { }

	// RVA: 0x817C60 Offset: 0x816260 VA: 0x180817C60
	public void LateUpdateInstrument(BasePlayer forPlayer) { }

	// RVA: 0x819850 Offset: 0x817E50 VA: 0x180819850
	public void PlayNoteRPC(BaseEntity.RPCMessage msg, bool isLocal) { }

	// RVA: 0x819B60 Offset: 0x818160 VA: 0x180819B60
	public bool PlayNote(Notes note, InstrumentKeyController.NoteType type, int octave, float velocity, bool isLocal) { }

	// RVA: 0x81B8B0 Offset: 0x819EB0 VA: 0x18081B8B0
	public bool StopNote(Notes note, InstrumentKeyController.NoteType type, int octave) { }

	// RVA: 0x81B6B0 Offset: 0x819CB0 VA: 0x18081B6B0
	public void StopNoteRPC(BaseEntity.RPCMessage msg, bool isLocal) { }

	// RVA: 0x81B4E0 Offset: 0x819AE0 VA: 0x18081B4E0
	public void StopAllNotes(bool blockUntilRelease) { }

	// RVA: 0x81BA00 Offset: 0x81A000 VA: 0x18081BA00
	public void StopOldestNote(bool blockUntilRelease, bool isVoiceStealing = False) { }

	// RVA: 0x818480 Offset: 0x816A80 VA: 0x180818480
	public void OnClientBeginUse(BasePlayer player) { }

	// RVA: 0x81B2C0 Offset: 0x8198C0 VA: 0x18081B2C0
	public void SetupBindings() { }

	// RVA: 0x818520 Offset: 0x816B20 VA: 0x180818520
	public void OnClientEndUse(BasePlayer player) { }

	// RVA: 0x8185E0 Offset: 0x816BE0 VA: 0x1808185E0
	public void OnEnable() { }

	// RVA: 0x817830 Offset: 0x815E30 VA: 0x180817830
	private GameObject GetNoteSoundPosition(int index) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D170 Offset: 0x81B770 VA: 0x18081D170
	public bool get_PlayedNoteThisFrame() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D1D0 Offset: 0x81B7D0 VA: 0x18081D1D0
	private void set_PlayedNoteThisFrame(bool value) { }

	// RVA: 0x819110 Offset: 0x817710 VA: 0x180819110
	public void OnPlayerPlayedNote(Notes note, InstrumentKeyController.NoteType type, int octave, float velocity, BasePlayer player) { }

	// RVA: 0x817C70 Offset: 0x816270 VA: 0x180817C70
	private void LoadPlayedInstruments() { }

	// RVA: 0x81A660 Offset: 0x818C60 VA: 0x18081A660
	private void SavePlayedInstruments() { }

	// RVA: 0x819620 Offset: 0x817C20 VA: 0x180819620
	public void OnPlayerStoppedNote(Notes note, InstrumentKeyController.NoteType type, int octave) { }

	// RVA: 0x81CCA0 Offset: 0x81B2A0 VA: 0x18081CCA0
	public void .ctor() { }

	// RVA: 0x81CB80 Offset: 0x81B180 VA: 0x18081CB80
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81C170 Offset: 0x81A770 VA: 0x18081C170
	private void <SetFullKeyboardMode>b__98_0() { }

}

public struct InstrumentKeyController.NoteBinding // TypeDefIndex: 9553
{	// Fields
	private Sound playingSound; // 0x0
	private float startedPlayingNote; // 0x8
	private float minimumNoteTime; // 0xC
	private float minimumSoundFadeOutTime; // 0x10
	private bool lastNoteState; // 0x14
	private bool blockUntilRelease; // 0x15
	public bool MidiOn; // 0x16
	public bool MouseOn; // 0x17

	// Properties
	public bool Playing { get; }
	public float PlayingDuration { get; }
	public bool RecentlyPlayedNote { get; }

	// Methods

	// RVA: 0xF8F80 Offset: 0xF8380 VA: 0x1800F8F80
	public bool get_Playing() { }

	// RVA: 0xF8F60 Offset: 0xF8360 VA: 0x1800F8F60
	public float get_PlayingDuration() { }

	// RVA: 0xF8FE0 Offset: 0xF83E0 VA: 0x1800F8FE0
	public bool get_RecentlyPlayedNote() { }

	// RVA: 0xF8E30 Offset: 0xF8230 VA: 0x1800F8E30
	private bool ButtonIsDown(Notes note, InstrumentKeyController.NoteType type) { }

	// RVA: 0xF8E40 Offset: 0xF8240 VA: 0x1800F8E40
	private bool ButtonJustPressed(Notes note, InstrumentKeyController.NoteType type) { }

	// RVA: 0xF8F00 Offset: 0xF8300 VA: 0x1800F8F00
	public void Update(BasePlayer player, InstrumentKeyController keyController, int octave, NoteBindingCollection noteCollection, NoteBindingCollection.NoteData data) { }

	// RVA: 0xF8E90 Offset: 0xF8290 VA: 0x1800F8E90
	public bool PlaySound(bool isLocal, float velocity, InstrumentKeyController keyController, NoteBindingCollection noteCollection, NoteBindingCollection.NoteData data) { }

	// RVA: 0x81F990 Offset: 0x81DF90 VA: 0x18081F990
	public static void SetupSound(bool isLocal, float velocity, NoteBindingCollection noteCollection, Sound forSound) { }

	// RVA: 0xF8EF0 Offset: 0xF82F0 VA: 0x1800F8EF0
	public bool StopPlayingNote(InstrumentKeyController keyController, bool blockUntilKeyRelease = False, bool isVoiceStealing = False) { }

	// RVA: 0xF8E20 Offset: 0xF8220 VA: 0x1800F8E20
	public void BlockKeyUntilRelease() { }

	// RVA: 0xF8E50 Offset: 0xF8250 VA: 0x1800F8E50
	private Sound CreateSound(InstrumentKeyController keyController, NoteBindingCollection.NoteData data) { }

}

public enum InstrumentKeyController.IKType // TypeDefIndex: 9554
{	// Fields
	public int value__; // 0x0
	public const InstrumentKeyController.IKType LeftHand = 0;
	public const InstrumentKeyController.IKType RightHand = 1;
	public const InstrumentKeyController.IKType RightFoot = 2;

}

public enum InstrumentKeyController.NoteType // TypeDefIndex: 9555
{	// Fields
	public int value__; // 0x0
	public const InstrumentKeyController.NoteType Regular = 0;
	public const InstrumentKeyController.NoteType Sharp = 1;

}

public enum InstrumentKeyController.InstrumentType // TypeDefIndex: 9556
{	// Fields
	public int value__; // 0x0
	public const InstrumentKeyController.InstrumentType Note = 0;
	public const InstrumentKeyController.InstrumentType Hold = 1;

}

public enum InstrumentKeyController.AnimationSlot // TypeDefIndex: 9557
{	// Fields
	public int value__; // 0x0
	public const InstrumentKeyController.AnimationSlot None = 0;
	public const InstrumentKeyController.AnimationSlot One = 1;
	public const InstrumentKeyController.AnimationSlot Two = 2;
	public const InstrumentKeyController.AnimationSlot Three = 3;
	public const InstrumentKeyController.AnimationSlot Four = 4;
	public const InstrumentKeyController.AnimationSlot Five = 5;
	public const InstrumentKeyController.AnimationSlot Six = 6;
	public const InstrumentKeyController.AnimationSlot Seven = 7;

}

public struct InstrumentKeyController.KeySet // TypeDefIndex: 9558
{	// Fields
	public Notes Note; // 0x0
	public InstrumentKeyController.NoteType NoteType; // 0x4
	public int OctaveShift; // 0x8

	// Methods

	// RVA: 0xF8D70 Offset: 0xF8170 VA: 0x1800F8D70 Slot: 3
	public override string ToString() { }

}

public struct InstrumentKeyController.NoteOverride // TypeDefIndex: 9559
{	// Fields
	public bool Override; // 0x0
	public InstrumentKeyController.KeySet Note; // 0x4

}

public struct InstrumentKeyController.IKNoteTarget // TypeDefIndex: 9560
{	// Fields
	public InstrumentKeyController.IKType TargetType; // 0x0
	public int IkIndex; // 0x4

}

public abstract class InstrumentTip : BaseTip // TypeDefIndex: 11609
{	// Properties
	public InstrumentKeyController Instrument { get; }

	// Methods

	// RVA: 0xC5C310 Offset: 0xC5A910 VA: 0x180C5C310
	public InstrumentKeyController get_Instrument() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool IsKeypadHostingMusicBinds() { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	protected void .ctor() { }

}

