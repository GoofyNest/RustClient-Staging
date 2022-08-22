public class InstrumentRecording : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6368
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<InstrumentRecordingNote> notes; // 0x18
	public int forInstrument; // 0x20

	// Methods

	// RVA: 0x1C0DC20 Offset: 0x1C0C220 VA: 0x181C0DC20
	public static void ResetToPool(InstrumentRecording instance) { }

	// RVA: 0x1C0DA40 Offset: 0x1C0C040 VA: 0x181C0DA40
	public void ResetToPool() { }

	// RVA: 0x1C0D980 Offset: 0x1C0BF80 VA: 0x181C0D980 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C0CB60 Offset: 0x1C0B160 VA: 0x181C0CB60
	public void CopyTo(InstrumentRecording instance) { }

	// RVA: 0x1C0CD30 Offset: 0x1C0B330 VA: 0x181C0CD30
	public InstrumentRecording Copy() { }

	// RVA: 0x1C0D5D0 Offset: 0x1C0BBD0 VA: 0x181C0D5D0
	public static InstrumentRecording Deserialize(Stream stream) { }

	// RVA: 0x1C0CDB0 Offset: 0x1C0B3B0 VA: 0x181C0CDB0
	public static InstrumentRecording DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C0D140 Offset: 0x1C0B740 VA: 0x181C0D140
	public static InstrumentRecording DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C0D4B0 Offset: 0x1C0BAB0 VA: 0x181C0D4B0
	public static InstrumentRecording Deserialize(byte[] buffer) { }

	// RVA: 0x1C0DA00 Offset: 0x1C0C000 VA: 0x181C0DA00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C0E450 Offset: 0x1C0CA50 VA: 0x181C0E450 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C0E470 Offset: 0x1C0CA70 VA: 0x181C0E470 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InstrumentRecording previous) { }

	// RVA: 0x1C0DA20 Offset: 0x1C0C020 VA: 0x181C0DA20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C0D650 Offset: 0x1C0BC50 VA: 0x181C0D650
	public static InstrumentRecording Deserialize(byte[] buffer, InstrumentRecording instance, bool isDelta = False) { }

	// RVA: 0x1C0D750 Offset: 0x1C0BD50 VA: 0x181C0D750
	public static InstrumentRecording Deserialize(Stream stream, InstrumentRecording instance, bool isDelta) { }

	// RVA: 0x1C0CE30 Offset: 0x1C0B430 VA: 0x181C0CE30
	public static InstrumentRecording DeserializeLengthDelimited(Stream stream, InstrumentRecording instance, bool isDelta) { }

	// RVA: 0x1C0D1D0 Offset: 0x1C0B7D0 VA: 0x181C0D1D0
	public static InstrumentRecording DeserializeLength(Stream stream, int length, InstrumentRecording instance, bool isDelta) { }

	// RVA: 0x1C0DE00 Offset: 0x1C0C400 VA: 0x181C0DE00
	public static void SerializeDelta(Stream stream, InstrumentRecording instance, InstrumentRecording previous) { }

	// RVA: 0x1C0E210 Offset: 0x1C0C810 VA: 0x181C0E210
	public static void Serialize(Stream stream, InstrumentRecording instance) { }

	// RVA: 0x1C0E440 Offset: 0x1C0CA40 VA: 0x181C0E440
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C0E450 Offset: 0x1C0CA50 VA: 0x181C0E450
	public void ToProto(Stream stream) { }

	// RVA: 0x1C0E100 Offset: 0x1C0C700 VA: 0x181C0E100
	public static byte[] SerializeToBytes(InstrumentRecording instance) { }

	// RVA: 0x1C0E050 Offset: 0x1C0C650 VA: 0x181C0E050
	public static void SerializeLengthDelimited(Stream stream, InstrumentRecording instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1C0C250 Offset: 0x1C0A850 VA: 0x181C0C250
	public static void ResetToPool(InstrumentRecordingNote instance) { }

	// RVA: 0x1C0C330 Offset: 0x1C0A930 VA: 0x181C0C330
	public void ResetToPool() { }

	// RVA: 0x1C0BE90 Offset: 0x1C0A490 VA: 0x181C0BE90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C0A5D0 Offset: 0x1C08BD0 VA: 0x181C0A5D0
	public void CopyTo(InstrumentRecordingNote instance) { }

	// RVA: 0x1C0A620 Offset: 0x1C08C20 VA: 0x181C0A620
	public InstrumentRecordingNote Copy() { }

	// RVA: 0x1C0BB20 Offset: 0x1C0A120 VA: 0x181C0BB20
	public static InstrumentRecordingNote Deserialize(Stream stream) { }

	// RVA: 0x1C0AAC0 Offset: 0x1C090C0 VA: 0x181C0AAC0
	public static InstrumentRecordingNote DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C0AB40 Offset: 0x1C09140 VA: 0x181C0AB40
	public static InstrumentRecordingNote DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C0B6F0 Offset: 0x1C09CF0 VA: 0x181C0B6F0
	public static InstrumentRecordingNote Deserialize(byte[] buffer) { }

	// RVA: 0x1C0BF10 Offset: 0x1C0A510 VA: 0x181C0BF10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C0CB20 Offset: 0x1C0B120 VA: 0x181C0CB20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C0CB40 Offset: 0x1C0B140 VA: 0x181C0CB40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InstrumentRecordingNote previous) { }

	// RVA: 0x1C0C230 Offset: 0x1C0A830 VA: 0x181C0C230 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C0B2E0 Offset: 0x1C098E0 VA: 0x181C0B2E0
	public static InstrumentRecordingNote Deserialize(byte[] buffer, InstrumentRecordingNote instance, bool isDelta = False) { }

	// RVA: 0x1C0AFB0 Offset: 0x1C095B0 VA: 0x181C0AFB0
	public static InstrumentRecordingNote Deserialize(Stream stream, InstrumentRecordingNote instance, bool isDelta) { }

	// RVA: 0x1C0A6C0 Offset: 0x1C08CC0 VA: 0x181C0A6C0
	public static InstrumentRecordingNote DeserializeLengthDelimited(Stream stream, InstrumentRecordingNote instance, bool isDelta) { }

	// RVA: 0x1C0ABD0 Offset: 0x1C091D0 VA: 0x181C0ABD0
	public static InstrumentRecordingNote DeserializeLength(Stream stream, int length, InstrumentRecordingNote instance, bool isDelta) { }

	// RVA: 0x1C0C410 Offset: 0x1C0AA10 VA: 0x181C0C410
	public static void SerializeDelta(Stream stream, InstrumentRecordingNote instance, InstrumentRecordingNote previous) { }

	// RVA: 0x1C0C930 Offset: 0x1C0AF30 VA: 0x181C0C930
	public static void Serialize(Stream stream, InstrumentRecordingNote instance) { }

	// RVA: 0x1C0CB10 Offset: 0x1C0B110 VA: 0x181C0CB10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C0CB20 Offset: 0x1C0B120 VA: 0x181C0CB20
	public void ToProto(Stream stream) { }

	// RVA: 0x1C0C820 Offset: 0x1C0AE20 VA: 0x181C0C820
	public static byte[] SerializeToBytes(InstrumentRecordingNote instance) { }

	// RVA: 0x1C0C770 Offset: 0x1C0AD70 VA: 0x181C0C770
	public static void SerializeLengthDelimited(Stream stream, InstrumentRecordingNote instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class InstrumentMidiBindings : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6370
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<InstrumentMidiBinding> bindings; // 0x18
	public uint forInstrument; // 0x20

	// Methods

	// RVA: 0x1C09D60 Offset: 0x1C08360 VA: 0x181C09D60
	public static void ResetToPool(InstrumentMidiBindings instance) { }

	// RVA: 0x1C09B80 Offset: 0x1C08180 VA: 0x181C09B80
	public void ResetToPool() { }

	// RVA: 0x1C09AC0 Offset: 0x1C080C0 VA: 0x181C09AC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C08B50 Offset: 0x1C07150 VA: 0x181C08B50
	public void CopyTo(InstrumentMidiBindings instance) { }

	// RVA: 0x1C08D00 Offset: 0x1C07300 VA: 0x181C08D00
	public InstrumentMidiBindings Copy() { }

	// RVA: 0x1C096F0 Offset: 0x1C07CF0 VA: 0x181C096F0
	public static InstrumentMidiBindings Deserialize(Stream stream) { }

	// RVA: 0x1C09200 Offset: 0x1C07800 VA: 0x181C09200
	public static InstrumentMidiBindings DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C09280 Offset: 0x1C07880 VA: 0x181C09280
	public static InstrumentMidiBindings DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C09770 Offset: 0x1C07D70 VA: 0x181C09770
	public static InstrumentMidiBindings Deserialize(byte[] buffer) { }

	// RVA: 0x1C09B40 Offset: 0x1C08140 VA: 0x181C09B40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C0A590 Offset: 0x1C08B90 VA: 0x181C0A590 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C0A5B0 Offset: 0x1C08BB0 VA: 0x181C0A5B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InstrumentMidiBindings previous) { }

	// RVA: 0x1C09B60 Offset: 0x1C08160 VA: 0x181C09B60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C095F0 Offset: 0x1C07BF0 VA: 0x181C095F0
	public static InstrumentMidiBindings Deserialize(byte[] buffer, InstrumentMidiBindings instance, bool isDelta = False) { }

	// RVA: 0x1C09890 Offset: 0x1C07E90 VA: 0x181C09890
	public static InstrumentMidiBindings Deserialize(Stream stream, InstrumentMidiBindings instance, bool isDelta) { }

	// RVA: 0x1C08EF0 Offset: 0x1C074F0 VA: 0x181C08EF0
	public static InstrumentMidiBindings DeserializeLengthDelimited(Stream stream, InstrumentMidiBindings instance, bool isDelta) { }

	// RVA: 0x1C09310 Offset: 0x1C07910 VA: 0x181C09310
	public static InstrumentMidiBindings DeserializeLength(Stream stream, int length, InstrumentMidiBindings instance, bool isDelta) { }

	// RVA: 0x1C09F40 Offset: 0x1C08540 VA: 0x181C09F40
	public static void SerializeDelta(Stream stream, InstrumentMidiBindings instance, InstrumentMidiBindings previous) { }

	// RVA: 0x1C0A350 Offset: 0x1C08950 VA: 0x181C0A350
	public static void Serialize(Stream stream, InstrumentMidiBindings instance) { }

	// RVA: 0x1C0A580 Offset: 0x1C08B80 VA: 0x181C0A580
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C0A590 Offset: 0x1C08B90 VA: 0x181C0A590
	public void ToProto(Stream stream) { }

	// RVA: 0x1C0A240 Offset: 0x1C08840 VA: 0x181C0A240
	public static byte[] SerializeToBytes(InstrumentMidiBindings instance) { }

	// RVA: 0x1C0A190 Offset: 0x1C08790 VA: 0x181C0A190
	public static void SerializeLengthDelimited(Stream stream, InstrumentMidiBindings instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x1C08490 Offset: 0x1C06A90 VA: 0x181C08490
	public static void ResetToPool(InstrumentMidiBinding instance) { }

	// RVA: 0x1C08530 Offset: 0x1C06B30 VA: 0x181C08530
	public void ResetToPool() { }

	// RVA: 0x1C081E0 Offset: 0x1C067E0 VA: 0x181C081E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C07020 Offset: 0x1C05620 VA: 0x181C07020
	public void CopyTo(InstrumentMidiBinding instance) { }

	// RVA: 0x1C07050 Offset: 0x1C05650 VA: 0x181C07050
	public InstrumentMidiBinding Copy() { }

	// RVA: 0x1C07F90 Offset: 0x1C06590 VA: 0x181C07F90
	public static InstrumentMidiBinding Deserialize(Stream stream) { }

	// RVA: 0x1C070D0 Offset: 0x1C056D0 VA: 0x181C070D0
	public static InstrumentMidiBinding DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1C076F0 Offset: 0x1C05CF0 VA: 0x181C076F0
	public static InstrumentMidiBinding DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1C07C80 Offset: 0x1C06280 VA: 0x181C07C80
	public static InstrumentMidiBinding Deserialize(byte[] buffer) { }

	// RVA: 0x1C08260 Offset: 0x1C06860 VA: 0x181C08260
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1C08B10 Offset: 0x1C07110 VA: 0x181C08B10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1C08B30 Offset: 0x1C07130 VA: 0x181C08B30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, InstrumentMidiBinding previous) { }

	// RVA: 0x1C08470 Offset: 0x1C06A70 VA: 0x181C08470 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1C07780 Offset: 0x1C05D80 VA: 0x181C07780
	public static InstrumentMidiBinding Deserialize(byte[] buffer, InstrumentMidiBinding instance, bool isDelta = False) { }

	// RVA: 0x1C07A70 Offset: 0x1C06070 VA: 0x181C07A70
	public static InstrumentMidiBinding Deserialize(Stream stream, InstrumentMidiBinding instance, bool isDelta) { }

	// RVA: 0x1C07150 Offset: 0x1C05750 VA: 0x181C07150
	public static InstrumentMidiBinding DeserializeLengthDelimited(Stream stream, InstrumentMidiBinding instance, bool isDelta) { }

	// RVA: 0x1C07430 Offset: 0x1C05A30 VA: 0x181C07430
	public static InstrumentMidiBinding DeserializeLength(Stream stream, int length, InstrumentMidiBinding instance, bool isDelta) { }

	// RVA: 0x1C085D0 Offset: 0x1C06BD0 VA: 0x181C085D0
	public static void SerializeDelta(Stream stream, InstrumentMidiBinding instance, InstrumentMidiBinding previous) { }

	// RVA: 0x1C089B0 Offset: 0x1C06FB0 VA: 0x181C089B0
	public static void Serialize(Stream stream, InstrumentMidiBinding instance) { }

	// RVA: 0x1C08B00 Offset: 0x1C07100 VA: 0x181C08B00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1C08B10 Offset: 0x1C07110 VA: 0x181C08B10
	public void ToProto(Stream stream) { }

	// RVA: 0x1C088A0 Offset: 0x1C06EA0 VA: 0x181C088A0
	public static byte[] SerializeToBytes(InstrumentMidiBinding instance) { }

	// RVA: 0x1C087F0 Offset: 0x1C06DF0 VA: 0x181C087F0
	public static void SerializeLengthDelimited(Stream stream, InstrumentMidiBinding instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public sealed class InstrumentNameEvent : BaseTextEvent // TypeDefIndex: 7537
{	// Methods

	// RVA: 0x13991B0 Offset: 0x13977B0 VA: 0x1813991B0
	public void .ctor() { }

	// RVA: 0x13991D0 Offset: 0x13977D0 VA: 0x1813991D0
	public void .ctor(string instrumentName) { }

	// RVA: 0x13990F0 Offset: 0x13976F0 VA: 0x1813990F0 Slot: 5
	protected override MidiEvent CloneEvent() { }

	// RVA: 0x1399160 Offset: 0x1397760 VA: 0x181399160 Slot: 3
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

	// RVA: 0x81E370 Offset: 0x81C970 VA: 0x18081E370 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x81D5F0 Offset: 0x81BBF0 VA: 0x18081D5F0 Slot: 136
	public override void ClampPitch(ref float pitch) { }

	// RVA: 0x81E150 Offset: 0x81C750 VA: 0x18081E150 Slot: 138
	public override void OnInput() { }

	// RVA: 0x81D950 Offset: 0x81BF50 VA: 0x18081D950 Slot: 149
	public override float GetMovementMultiplier() { }

	// RVA: 0x81D9F0 Offset: 0x81BFF0 VA: 0x18081D9F0 Slot: 157
	protected virtual void LateUpdate() { }

	// RVA: 0x81DB30 Offset: 0x81C130 VA: 0x18081DB30 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0x81DAD0 Offset: 0x81C0D0 VA: 0x18081DAD0
	private void OnAnimationSlotSet(InstrumentKeyController.AnimationSlot slot) { }

	// RVA: 0x81DFB0 Offset: 0x81C5B0 VA: 0x18081DFB0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x81EC80 Offset: 0x81D280 VA: 0x18081EC80 Slot: 147
	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0x81DDE0 Offset: 0x81C3E0 VA: 0x18081DDE0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 158
	protected virtual void RemotePlayerDeploy(BasePlayer player) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 159
	protected virtual void RemotePlayerHolster(BasePlayer player) { }

	// RVA: 0x81ED90 Offset: 0x81D390 VA: 0x18081ED90 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x81EEB0 Offset: 0x81D4B0 VA: 0x18081EEB0 Slot: 27
	public override void ResetState() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D690 Offset: 0x81BC90 VA: 0x18081D690
	private void Client_PlayNote(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D810 Offset: 0x81BE10 VA: 0x18081D810
	private void Client_StopNote(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 156
	public override bool IsInstrument() { }

	// RVA: 0x81EF80 Offset: 0x81D580 VA: 0x18081EF80
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

	// RVA: 0x81D0D0 Offset: 0x81B6D0 VA: 0x18081D0D0 Slot: 5
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x81D5D0 Offset: 0x81BBD0 VA: 0x18081D5D0
	public void .ctor() { }

	// RVA: 0x81D2D0 Offset: 0x81B8D0 VA: 0x18081D2D0
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

	// RVA: 0xA23770 Offset: 0xA21D70 VA: 0x180A23770
	public void UpdateSlots(InstrumentKeyController.AnimationSlot currentSlot, bool recentlyPlayed, bool playedNoteThisFrame) { }

	// RVA: 0xA23A30 Offset: 0xA22030 VA: 0x180A23A30
	private void UpdateState(int param, bool state) { }

	// RVA: 0xA23A80 Offset: 0xA22080 VA: 0x180A23A80
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

	// RVA: 0xA232F0 Offset: 0xA218F0 VA: 0x180A232F0 Slot: 157
	protected override void LateUpdate() { }

	// RVA: 0xA23670 Offset: 0xA21C70 VA: 0x180A23670 Slot: 147
	protected override void ProcessPlayerModel(PlayerModel playerModel) { }

	// RVA: 0xA23510 Offset: 0xA21B10 VA: 0x180A23510 Slot: 145
	public override void OnReliableEvent(string name) { }

	// RVA: 0xA23230 Offset: 0xA21830 VA: 0x180A23230
	public void DeployBegin() { }

	// RVA: 0xA23290 Offset: 0xA21890 VA: 0x180A23290
	public void DeployComplete() { }

	// RVA: 0xA23630 Offset: 0xA21C30 VA: 0x180A23630 Slot: 150
	public override void OnSpawnedForWorkshopPreview() { }

	// RVA: 0xA23760 Offset: 0xA21D60 VA: 0x180A23760
	public void .ctor() { }

	// RVA: 0xA23710 Offset: 0xA21D10 VA: 0x180A23710
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

	// RVA: 0x815D10 Offset: 0x814310 VA: 0x180815D10
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

	// RVA: 0x816020 Offset: 0x814620 VA: 0x180816020
	public void HoldHandsUpdate(InstrumentKeyController key) { }

	// RVA: 0x8165B0 Offset: 0x814BB0 VA: 0x1808165B0
	public void UpdateIK(BasePlayer forPlayer) { }

	// RVA: 0x815D50 Offset: 0x814350 VA: 0x180815D50
	private Vector3 GetHandHeight(float noteTime) { }

	// RVA: 0x815EE0 Offset: 0x8144E0 VA: 0x180815EE0
	private Vector3 GetWorldSpaceIkTarget(int target, InstrumentKeyController.IKType type, Vector3 localOffset) { }

	// RVA: 0x815E50 Offset: 0x814450 VA: 0x180815E50
	private Transform GetHandTransform(int target, InstrumentKeyController.IKType type) { }

	// RVA: 0x815DE0 Offset: 0x8143E0 VA: 0x180815DE0
	private Transform GetHandRotationTransform(int target, InstrumentKeyController.IKType type) { }

	// RVA: 0x816240 Offset: 0x814840 VA: 0x180816240
	public void SetIkTarget(InstrumentKeyController.IKType type, int target) { }

	// RVA: 0x816F20 Offset: 0x815520 VA: 0x180816F20
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

	// RVA: 0x8173E0 Offset: 0x8159E0 VA: 0x1808173E0
	private void DisableProps() { }

	// RVA: 0x81C270 Offset: 0x81A870 VA: 0x18081C270
	private void UpdateHeldProps(BasePlayer forPlayer) { }

	// RVA: 0x81A180 Offset: 0x818780 VA: 0x18081A180
	private void RunInstrumentAnimation(BasePlayer forPlayer) { }

	// RVA: 0x81A700 Offset: 0x818D00 VA: 0x18081A700
	private void SetAnimationSlot(InstrumentKeyController.AnimationSlot slot, PlayerModel forPlayer) { }

	// RVA: 0x8174D0 Offset: 0x815AD0 VA: 0x1808174D0
	private int GetAnimationSlotHash(InstrumentKeyController.AnimationSlot slot) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public MicrophoneStandIOEntity get_currentReceiver() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_currentReceiver(MicrophoneStandIOEntity value) { }

	// RVA: 0x81AD50 Offset: 0x819350 VA: 0x18081AD50
	public bool SetCurrentReceiver(MicrophoneStandIOEntity receiver) { }

	// RVA: 0x817270 Offset: 0x815870 VA: 0x180817270
	public void ClearReceiver() { }

	// RVA: 0x81BDF0 Offset: 0x81A3F0 VA: 0x18081BDF0
	public void SubscribeToMidi(BasePlayer forPlayer) { }

	// RVA: 0x81C5A0 Offset: 0x81ABA0 VA: 0x18081C5A0
	public void UpdateMidiBindings() { }

	// RVA: 0x81C070 Offset: 0x81A670 VA: 0x18081C070
	public void UnsubscribeFromMidi() { }

	// RVA: 0x81A120 Offset: 0x818720 VA: 0x18081A120
	public void ResetState() { }

	// RVA: 0x819830 Offset: 0x817E30 VA: 0x180819830
	private void PlayNoteViaMIDI(int noteIndex, float velocity) { }

	// RVA: 0x81B650 Offset: 0x819C50 VA: 0x18081B650
	private void StopNoteViaMIDI(int noteIndex) { }

	// RVA: 0x818000 Offset: 0x816600 VA: 0x180818000
	private void NoteOnDelegate(MidiChannel channel, int note, float velocity) { }

	// RVA: 0x817D60 Offset: 0x816360 VA: 0x180817D60
	private void NoteOffDelegate(MidiChannel channel, int note) { }

	// RVA: 0x817860 Offset: 0x815E60 VA: 0x180817860
	private void KnobDelegate(MidiChannel channel, int knobNumber, float knobValue) { }

	// RVA: 0x8170B0 Offset: 0x8156B0 VA: 0x1808170B0
	private bool ApplyMidiRebinding(int inNote, out int index) { }

	// RVA: 0x817290 Offset: 0x815890 VA: 0x180817290
	private void ConvertMidiNoteToIndex(int note, out int index) { }

	// RVA: 0x81B250 Offset: 0x819850 VA: 0x18081B250
	public void StartRecording(string fileName) { }

	// RVA: 0x81BBD0 Offset: 0x81A1D0 VA: 0x18081BBD0
	public void StopRecording() { }

	// RVA: 0x819E80 Offset: 0x818480 VA: 0x180819E80
	private void RecordNoteStart(Notes note, int octave, float velocity, InstrumentKeyController.NoteType type, bool hold) { }

	// RVA: 0x819F70 Offset: 0x818570 VA: 0x180819F70
	private void RecordNoteStop(Notes note, int octave, InstrumentKeyController.NoteType type) { }

	// RVA: 0x819BF0 Offset: 0x8181F0 VA: 0x180819BF0
	public void PlayRecording(InstrumentRecording recording) { }

	// RVA: 0x81C640 Offset: 0x81AC40 VA: 0x18081C640
	private void UpdatePlayingRecording(BasePlayer forPlayer) { }

	// RVA: 0x81BB90 Offset: 0x81A190 VA: 0x18081BB90
	private void StopPlayingRecording() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81CDB0 Offset: 0x81B3B0 VA: 0x18081CDB0
	public bool get_FullKeyboardMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D0B0 Offset: 0x81B6B0 VA: 0x18081D0B0
	private void set_FullKeyboardMode(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81CCE0 Offset: 0x81B2E0 VA: 0x18081CCE0
	public InstrumentKeyController.AnimationSlot get_CurrentAnimation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D0A0 Offset: 0x81B6A0 VA: 0x18081D0A0
	private void set_CurrentAnimation(InstrumentKeyController.AnimationSlot value) { }

	// RVA: 0x81D070 Offset: 0x81B670 VA: 0x18081D070
	public bool get_RecentlyPlayedNote() { }

	// RVA: 0x81CDC0 Offset: 0x81B3C0 VA: 0x18081CDC0
	private bool get_HeldByLocalPlayer() { }

	// RVA: 0x81CF50 Offset: 0x81B550 VA: 0x18081CF50
	private bool get_IsPlaying() { }

	// RVA: 0x81CCF0 Offset: 0x81B2F0 VA: 0x18081CCF0
	private int get_CurrentlyPlayingNotes() { }

	// RVA: 0x81ADF0 Offset: 0x8193F0 VA: 0x18081ADF0
	public void SetFullKeyboardMode(bool state) { }

	// RVA: 0x8184E0 Offset: 0x816AE0 VA: 0x1808184E0
	public void OnInput(BasePlayer player) { }

	// RVA: 0x8184C0 Offset: 0x816AC0 VA: 0x1808184C0
	private void OnDisable() { }

	// RVA: 0x817770 Offset: 0x815D70 VA: 0x180817770
	public void InUseUpdate(BasePlayer forPlayer) { }

	// RVA: 0x817B50 Offset: 0x816150 VA: 0x180817B50
	public void LateUpdateInstrument(BasePlayer forPlayer) { }

	// RVA: 0x819740 Offset: 0x817D40 VA: 0x180819740
	public void PlayNoteRPC(BaseEntity.RPCMessage msg, bool isLocal) { }

	// RVA: 0x819A50 Offset: 0x818050 VA: 0x180819A50
	public bool PlayNote(Notes note, InstrumentKeyController.NoteType type, int octave, float velocity, bool isLocal) { }

	// RVA: 0x81B7A0 Offset: 0x819DA0 VA: 0x18081B7A0
	public bool StopNote(Notes note, InstrumentKeyController.NoteType type, int octave) { }

	// RVA: 0x81B5A0 Offset: 0x819BA0 VA: 0x18081B5A0
	public void StopNoteRPC(BaseEntity.RPCMessage msg, bool isLocal) { }

	// RVA: 0x81B3D0 Offset: 0x8199D0 VA: 0x18081B3D0
	public void StopAllNotes(bool blockUntilRelease) { }

	// RVA: 0x81B8F0 Offset: 0x819EF0 VA: 0x18081B8F0
	public void StopOldestNote(bool blockUntilRelease, bool isVoiceStealing = False) { }

	// RVA: 0x818370 Offset: 0x816970 VA: 0x180818370
	public void OnClientBeginUse(BasePlayer player) { }

	// RVA: 0x81B1B0 Offset: 0x8197B0 VA: 0x18081B1B0
	public void SetupBindings() { }

	// RVA: 0x818410 Offset: 0x816A10 VA: 0x180818410
	public void OnClientEndUse(BasePlayer player) { }

	// RVA: 0x8184D0 Offset: 0x816AD0 VA: 0x1808184D0
	public void OnEnable() { }

	// RVA: 0x817720 Offset: 0x815D20 VA: 0x180817720
	private GameObject GetNoteSoundPosition(int index) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D060 Offset: 0x81B660 VA: 0x18081D060
	public bool get_PlayedNoteThisFrame() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81D0C0 Offset: 0x81B6C0 VA: 0x18081D0C0
	private void set_PlayedNoteThisFrame(bool value) { }

	// RVA: 0x819000 Offset: 0x817600 VA: 0x180819000
	public void OnPlayerPlayedNote(Notes note, InstrumentKeyController.NoteType type, int octave, float velocity, BasePlayer player) { }

	// RVA: 0x817B60 Offset: 0x816160 VA: 0x180817B60
	private void LoadPlayedInstruments() { }

	// RVA: 0x81A550 Offset: 0x818B50 VA: 0x18081A550
	private void SavePlayedInstruments() { }

	// RVA: 0x819510 Offset: 0x817B10 VA: 0x180819510
	public void OnPlayerStoppedNote(Notes note, InstrumentKeyController.NoteType type, int octave) { }

	// RVA: 0x81CB90 Offset: 0x81B190 VA: 0x18081CB90
	public void .ctor() { }

	// RVA: 0x81CA70 Offset: 0x81B070 VA: 0x18081CA70
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x81C060 Offset: 0x81A660 VA: 0x18081C060
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

	// RVA: 0x81F880 Offset: 0x81DE80 VA: 0x18081F880
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

	// RVA: 0xC5C050 Offset: 0xC5A650 VA: 0x180C5C050
	public InstrumentKeyController get_Instrument() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	public bool IsKeypadHostingMusicBinds() { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	protected void .ctor() { }

}

