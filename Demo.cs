public class DemoHeader : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6464
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint version; // 0x14
	public string level; // 0x18
	public uint levelSeed; // 0x20
	public uint levelSize; // 0x24
	public string checksum; // 0x28
	public ulong localclient; // 0x30
	public Vector3 position; // 0x38
	public Vector3 rotation; // 0x44
	public string levelUrl; // 0x50
	public long recordedTime; // 0x58
	public long length; // 0x60
	public List<FileStorageCacheData> fileStorage; // 0x68

	// Methods

	// RVA: 0x1E60A50 Offset: 0x1E5F050 VA: 0x181E60A50
	public static void ResetToPool(DemoHeader instance) { }

	// RVA: 0x1E60780 Offset: 0x1E5ED80 VA: 0x181E60780
	public void ResetToPool() { }

	// RVA: 0x1E606C0 Offset: 0x1E5ECC0 VA: 0x181E606C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5F070 Offset: 0x1E5D670 VA: 0x181E5F070
	public void CopyTo(DemoHeader instance) { }

	// RVA: 0x1E5F210 Offset: 0x1E5D810 VA: 0x181E5F210
	public DemoHeader Copy() { }

	// RVA: 0x1E60090 Offset: 0x1E5E690 VA: 0x181E60090
	public static DemoHeader Deserialize(Stream stream) { }

	// RVA: 0x1E5F400 Offset: 0x1E5DA00 VA: 0x181E5F400
	public static DemoHeader DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5F9E0 Offset: 0x1E5DFE0 VA: 0x181E5F9E0
	public static DemoHeader DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E60110 Offset: 0x1E5E710 VA: 0x181E60110
	public static DemoHeader Deserialize(byte[] buffer) { }

	// RVA: 0x1E60740 Offset: 0x1E5ED40 VA: 0x181E60740
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E61D10 Offset: 0x1E60310 VA: 0x181E61D10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E61D30 Offset: 0x1E60330 VA: 0x181E61D30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoHeader previous) { }

	// RVA: 0x1E60760 Offset: 0x1E5ED60 VA: 0x181E60760 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5FF90 Offset: 0x1E5E590 VA: 0x181E5FF90
	public static DemoHeader Deserialize(byte[] buffer, DemoHeader instance, bool isDelta = False) { }

	// RVA: 0x1E60230 Offset: 0x1E5E830 VA: 0x181E60230
	public static DemoHeader Deserialize(Stream stream, DemoHeader instance, bool isDelta) { }

	// RVA: 0x1E5F480 Offset: 0x1E5DA80 VA: 0x181E5F480
	public static DemoHeader DeserializeLengthDelimited(Stream stream, DemoHeader instance, bool isDelta) { }

	// RVA: 0x1E5FA70 Offset: 0x1E5E070 VA: 0x181E5FA70
	public static DemoHeader DeserializeLength(Stream stream, int length, DemoHeader instance, bool isDelta) { }

	// RVA: 0x1E60D10 Offset: 0x1E5F310 VA: 0x181E60D10
	public static void SerializeDelta(Stream stream, DemoHeader instance, DemoHeader previous) { }

	// RVA: 0x1E61720 Offset: 0x1E5FD20 VA: 0x181E61720
	public static void Serialize(Stream stream, DemoHeader instance) { }

	// RVA: 0x1E61D00 Offset: 0x1E60300 VA: 0x181E61D00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E61D10 Offset: 0x1E60310 VA: 0x181E61D10
	public void ToProto(Stream stream) { }

	// RVA: 0x1E61610 Offset: 0x1E5FC10 VA: 0x181E61610
	public static byte[] SerializeToBytes(DemoHeader instance) { }

	// RVA: 0x1E61560 Offset: 0x1E5FB60 VA: 0x181E61560
	public static void SerializeLengthDelimited(Stream stream, DemoHeader instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class DemoShot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6466
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string shotName; // 0x18
	public string demoName; // 0x20
	public float shotStart; // 0x28
	public float shotLength; // 0x2C
	public DemoShotVectorTrack camPos; // 0x30
	public DemoShotQuaternionTrack camRot; // 0x38
	public DemoShotFloatTrack camFov; // 0x40
	public DemoShotFloatTrack camDofDist; // 0x48
	public DemoShotFloatTrack camDofFocalSize; // 0x50
	public DemoShotFloatTrack camDofAperture; // 0x58
	public DemoShotParentTrack camParent; // 0x60
	public string folderName; // 0x68

	// Methods

	// RVA: 0x1E6CDF0 Offset: 0x1E6B3F0 VA: 0x181E6CDF0
	public static void ResetToPool(DemoShot instance) { }

	// RVA: 0x1E6D0A0 Offset: 0x1E6B6A0 VA: 0x181E6D0A0
	public void ResetToPool() { }

	// RVA: 0x1E6CD30 Offset: 0x1E6B330 VA: 0x181E6CD30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E6B6D0 Offset: 0x1E69CD0 VA: 0x181E6B6D0
	public void CopyTo(DemoShot instance) { }

	// RVA: 0x1E6B9F0 Offset: 0x1E69FF0 VA: 0x181E6B9F0
	public DemoShot Copy() { }

	// RVA: 0x1E6C610 Offset: 0x1E6AC10 VA: 0x181E6C610
	public static DemoShot Deserialize(Stream stream) { }

	// RVA: 0x1E6BA70 Offset: 0x1E6A070 VA: 0x181E6BA70
	public static DemoShot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E6C580 Offset: 0x1E6AB80 VA: 0x181E6C580
	public static DemoShot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E6C690 Offset: 0x1E6AC90 VA: 0x181E6C690
	public static DemoShot Deserialize(byte[] buffer) { }

	// RVA: 0x1E6CDB0 Offset: 0x1E6B3B0 VA: 0x181E6CDB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E6E810 Offset: 0x1E6CE10 VA: 0x181E6E810 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E6E830 Offset: 0x1E6CE30 VA: 0x181E6E830 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShot previous) { }

	// RVA: 0x1E6CDD0 Offset: 0x1E6B3D0 VA: 0x181E6CDD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E6C7B0 Offset: 0x1E6ADB0 VA: 0x181E6C7B0
	public static DemoShot Deserialize(byte[] buffer, DemoShot instance, bool isDelta = False) { }

	// RVA: 0x1E6C8B0 Offset: 0x1E6AEB0 VA: 0x181E6C8B0
	public static DemoShot Deserialize(Stream stream, DemoShot instance, bool isDelta) { }

	// RVA: 0x1E6BAF0 Offset: 0x1E6A0F0 VA: 0x181E6BAF0
	public static DemoShot DeserializeLengthDelimited(Stream stream, DemoShot instance, bool isDelta) { }

	// RVA: 0x1E6C050 Offset: 0x1E6A650 VA: 0x181E6C050
	public static DemoShot DeserializeLength(Stream stream, int length, DemoShot instance, bool isDelta) { }

	// RVA: 0x1E6D350 Offset: 0x1E6B950 VA: 0x181E6D350
	public static void SerializeDelta(Stream stream, DemoShot instance, DemoShot previous) { }

	// RVA: 0x1E6DF00 Offset: 0x1E6C500 VA: 0x181E6DF00
	public static void Serialize(Stream stream, DemoShot instance) { }

	// RVA: 0x1E6E800 Offset: 0x1E6CE00 VA: 0x181E6E800
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E6E810 Offset: 0x1E6CE10 VA: 0x181E6E810
	public void ToProto(Stream stream) { }

	// RVA: 0x1E6DDF0 Offset: 0x1E6C3F0 VA: 0x181E6DDF0
	public static byte[] SerializeToBytes(DemoShot instance) { }

	// RVA: 0x1E6DD40 Offset: 0x1E6C340 VA: 0x181E6DD40
	public static void SerializeLengthDelimited(Stream stream, DemoShot instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class DemoShotVectorTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6467
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long trackType; // 0x18
	public List<DemoShotVectorKeyframe> keyframes; // 0x20

	// Methods

	// RVA: 0x1E6AF30 Offset: 0x1E69530 VA: 0x181E6AF30
	public static void ResetToPool(DemoShotVectorTrack instance) { }

	// RVA: 0x1E6AE40 Offset: 0x1E69440 VA: 0x181E6AE40
	public void ResetToPool() { }

	// RVA: 0x1E6AD80 Offset: 0x1E69380 VA: 0x181E6AD80 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E6A080 Offset: 0x1E68680 VA: 0x181E6A080
	public void CopyTo(DemoShotVectorTrack instance) { }

	// RVA: 0x1E6A1C0 Offset: 0x1E687C0 VA: 0x181E6A1C0
	public DemoShotVectorTrack Copy() { }

	// RVA: 0x1E6AD00 Offset: 0x1E69300 VA: 0x181E6AD00
	public static DemoShotVectorTrack Deserialize(Stream stream) { }

	// RVA: 0x1E6A520 Offset: 0x1E68B20 VA: 0x181E6A520
	public static DemoShotVectorTrack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E6A5A0 Offset: 0x1E68BA0 VA: 0x181E6A5A0
	public static DemoShotVectorTrack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E6ABE0 Offset: 0x1E691E0 VA: 0x181E6ABE0
	public static DemoShotVectorTrack Deserialize(byte[] buffer) { }

	// RVA: 0x1E6AE00 Offset: 0x1E69400 VA: 0x181E6AE00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E6B690 Offset: 0x1E69C90 VA: 0x181E6B690 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E6B6B0 Offset: 0x1E69CB0 VA: 0x181E6B6B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShotVectorTrack previous) { }

	// RVA: 0x1E6AE20 Offset: 0x1E69420 VA: 0x181E6AE20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E6A8E0 Offset: 0x1E68EE0 VA: 0x181E6A8E0
	public static DemoShotVectorTrack Deserialize(byte[] buffer, DemoShotVectorTrack instance, bool isDelta = False) { }

	// RVA: 0x1E6A9E0 Offset: 0x1E68FE0 VA: 0x181E6A9E0
	public static DemoShotVectorTrack Deserialize(Stream stream, DemoShotVectorTrack instance, bool isDelta) { }

	// RVA: 0x1E6A240 Offset: 0x1E68840 VA: 0x181E6A240
	public static DemoShotVectorTrack DeserializeLengthDelimited(Stream stream, DemoShotVectorTrack instance, bool isDelta) { }

	// RVA: 0x1E6A630 Offset: 0x1E68C30 VA: 0x181E6A630
	public static DemoShotVectorTrack DeserializeLength(Stream stream, int length, DemoShotVectorTrack instance, bool isDelta) { }

	// RVA: 0x1E6B020 Offset: 0x1E69620 VA: 0x181E6B020
	public static void SerializeDelta(Stream stream, DemoShotVectorTrack instance, DemoShotVectorTrack previous) { }

	// RVA: 0x1E6B440 Offset: 0x1E69A40 VA: 0x181E6B440
	public static void Serialize(Stream stream, DemoShotVectorTrack instance) { }

	// RVA: 0x1E6B680 Offset: 0x1E69C80 VA: 0x181E6B680
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E6B690 Offset: 0x1E69C90 VA: 0x181E6B690
	public void ToProto(Stream stream) { }

	// RVA: 0x1E6B330 Offset: 0x1E69930 VA: 0x181E6B330
	public static byte[] SerializeToBytes(DemoShotVectorTrack instance) { }

	// RVA: 0x1E6B280 Offset: 0x1E69880 VA: 0x181E6B280
	public static void SerializeLengthDelimited(Stream stream, DemoShotVectorTrack instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public struct DemoShotVectorKeyframe : IProto // TypeDefIndex: 6468
{	// Fields
	public float keyframeTime; // 0x0
	public Vector3 keyFrameValue; // 0x4

	// Methods

	// RVA: 0x18BBC20 Offset: 0x18BA220 VA: 0x1818BBC20
	public static void ResetToPool(DemoShotVectorKeyframe instance) { }

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	public void CopyTo(DemoShotVectorKeyframe instance) { }

	// RVA: 0xF2950 Offset: 0xF1D50 VA: 0x1800F2950
	public DemoShotVectorKeyframe Copy() { }

	// RVA: 0x1E69A60 Offset: 0x1E68060 VA: 0x181E69A60
	public static DemoShotVectorKeyframe Deserialize(Stream stream) { }

	// RVA: 0x1E69190 Offset: 0x1E67790 VA: 0x181E69190
	public static DemoShotVectorKeyframe DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E69430 Offset: 0x1E67A30 VA: 0x181E69430
	public static DemoShotVectorKeyframe DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E696B0 Offset: 0x1E67CB0 VA: 0x181E696B0
	public static DemoShotVectorKeyframe Deserialize(byte[] buffer) { }

	// RVA: 0x231E50 Offset: 0x231250 VA: 0x180231E50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x231ED0 Offset: 0x2312D0 VA: 0x180231ED0 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x231F00 Offset: 0x231300 VA: 0x180231F00
	public void WriteToStreamDelta(Stream stream, DemoShotVectorKeyframe previous) { }

	// RVA: 0x231E80 Offset: 0x231280 VA: 0x180231E80 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E69930 Offset: 0x1E67F30 VA: 0x181E69930
	public static DemoShotVectorKeyframe Deserialize(byte[] buffer, ref DemoShotVectorKeyframe instance, bool isDelta = False) { }

	// RVA: 0x1E697B0 Offset: 0x1E67DB0 VA: 0x181E697B0
	public static DemoShotVectorKeyframe Deserialize(Stream stream, ref DemoShotVectorKeyframe instance, bool isDelta) { }

	// RVA: 0x1E691D0 Offset: 0x1E677D0 VA: 0x181E691D0
	public static DemoShotVectorKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotVectorKeyframe instance, bool isDelta) { }

	// RVA: 0x1E69470 Offset: 0x1E67A70 VA: 0x181E69470
	public static DemoShotVectorKeyframe DeserializeLength(Stream stream, int length, ref DemoShotVectorKeyframe instance, bool isDelta) { }

	// RVA: 0x1E69AA0 Offset: 0x1E680A0 VA: 0x181E69AA0
	public static void SerializeDelta(Stream stream, DemoShotVectorKeyframe instance, DemoShotVectorKeyframe previous) { }

	// RVA: 0x1E69EF0 Offset: 0x1E684F0 VA: 0x181E69EF0
	public static void Serialize(Stream stream, DemoShotVectorKeyframe instance) { }

	// RVA: 0x231EB0 Offset: 0x2312B0 VA: 0x180231EB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x231ED0 Offset: 0x2312D0 VA: 0x180231ED0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E69DD0 Offset: 0x1E683D0 VA: 0x181E69DD0
	public static byte[] SerializeToBytes(DemoShotVectorKeyframe instance) { }

	// RVA: 0x1E69D20 Offset: 0x1E68320 VA: 0x181E69D20
	public static void SerializeLengthDelimited(Stream stream, DemoShotVectorKeyframe instance) { }

}

public class DemoShotFloatTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6469
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long trackType; // 0x18
	public List<DemoShotFloatKeyframe> keyframes; // 0x20

	// Methods

	// RVA: 0x1E63A40 Offset: 0x1E62040 VA: 0x181E63A40
	public static void ResetToPool(DemoShotFloatTrack instance) { }

	// RVA: 0x1E63B30 Offset: 0x1E62130 VA: 0x181E63B30
	public void ResetToPool() { }

	// RVA: 0x1E63980 Offset: 0x1E61F80 VA: 0x181E63980 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E629A0 Offset: 0x1E60FA0 VA: 0x181E629A0
	public void CopyTo(DemoShotFloatTrack instance) { }

	// RVA: 0x1E62AB0 Offset: 0x1E610B0 VA: 0x181E62AB0
	public DemoShotFloatTrack Copy() { }

	// RVA: 0x1E634A0 Offset: 0x1E61AA0 VA: 0x181E634A0
	public static DemoShotFloatTrack Deserialize(Stream stream) { }

	// RVA: 0x1E62E00 Offset: 0x1E61400 VA: 0x181E62E00
	public static DemoShotFloatTrack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E62E80 Offset: 0x1E61480 VA: 0x181E62E80
	public static DemoShotFloatTrack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E636C0 Offset: 0x1E61CC0 VA: 0x181E636C0
	public static DemoShotFloatTrack Deserialize(byte[] buffer) { }

	// RVA: 0x1E63A00 Offset: 0x1E62000 VA: 0x181E63A00
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E64260 Offset: 0x1E62860 VA: 0x181E64260 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E64280 Offset: 0x1E62880 VA: 0x181E64280 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShotFloatTrack previous) { }

	// RVA: 0x1E63A20 Offset: 0x1E62020 VA: 0x181E63A20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E633A0 Offset: 0x1E619A0 VA: 0x181E633A0
	public static DemoShotFloatTrack Deserialize(byte[] buffer, DemoShotFloatTrack instance, bool isDelta = False) { }

	// RVA: 0x1E631B0 Offset: 0x1E617B0 VA: 0x181E631B0
	public static DemoShotFloatTrack Deserialize(Stream stream, DemoShotFloatTrack instance, bool isDelta) { }

	// RVA: 0x1E62B30 Offset: 0x1E61130 VA: 0x181E62B30
	public static DemoShotFloatTrack DeserializeLengthDelimited(Stream stream, DemoShotFloatTrack instance, bool isDelta) { }

	// RVA: 0x1E62F10 Offset: 0x1E61510 VA: 0x181E62F10
	public static DemoShotFloatTrack DeserializeLength(Stream stream, int length, DemoShotFloatTrack instance, bool isDelta) { }

	// RVA: 0x1E63C20 Offset: 0x1E62220 VA: 0x181E63C20
	public static void SerializeDelta(Stream stream, DemoShotFloatTrack instance, DemoShotFloatTrack previous) { }

	// RVA: 0x1E64020 Offset: 0x1E62620 VA: 0x181E64020
	public static void Serialize(Stream stream, DemoShotFloatTrack instance) { }

	// RVA: 0x1E64250 Offset: 0x1E62850 VA: 0x181E64250
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E64260 Offset: 0x1E62860 VA: 0x181E64260
	public void ToProto(Stream stream) { }

	// RVA: 0x1E63F10 Offset: 0x1E62510 VA: 0x181E63F10
	public static byte[] SerializeToBytes(DemoShotFloatTrack instance) { }

	// RVA: 0x1E63E60 Offset: 0x1E62460 VA: 0x181E63E60
	public static void SerializeLengthDelimited(Stream stream, DemoShotFloatTrack instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public struct DemoShotFloatKeyframe : IProto // TypeDefIndex: 6470
{	// Fields
	public float keyframeTime; // 0x0
	public float keyFrameValue; // 0x4

	// Methods

	// RVA: 0x1E4C480 Offset: 0x1E4AA80 VA: 0x181E4C480
	public static void ResetToPool(DemoShotFloatKeyframe instance) { }

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	public void CopyTo(DemoShotFloatKeyframe instance) { }

	// RVA: 0xF22B0 Offset: 0xF16B0 VA: 0x1800F22B0
	public DemoShotFloatKeyframe Copy() { }

	// RVA: 0x1E62400 Offset: 0x1E60A00 VA: 0x181E62400
	public static DemoShotFloatKeyframe Deserialize(Stream stream) { }

	// RVA: 0x1E61D50 Offset: 0x1E60350 VA: 0x181E61D50
	public static DemoShotFloatKeyframe DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E621E0 Offset: 0x1E607E0 VA: 0x181E621E0
	public static DemoShotFloatKeyframe DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E62210 Offset: 0x1E60810 VA: 0x181E62210
	public static DemoShotFloatKeyframe Deserialize(byte[] buffer) { }

	// RVA: 0x231AD0 Offset: 0x230ED0 VA: 0x180231AD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x231B30 Offset: 0x230F30 VA: 0x180231B30 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x231B50 Offset: 0x230F50 VA: 0x180231B50
	public void WriteToStreamDelta(Stream stream, DemoShotFloatKeyframe previous) { }

	// RVA: 0x231AF0 Offset: 0x230EF0 VA: 0x180231AF0 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E62300 Offset: 0x1E60900 VA: 0x181E62300
	public static DemoShotFloatKeyframe Deserialize(byte[] buffer, ref DemoShotFloatKeyframe instance, bool isDelta = False) { }

	// RVA: 0x1E62430 Offset: 0x1E60A30 VA: 0x181E62430
	public static DemoShotFloatKeyframe Deserialize(Stream stream, ref DemoShotFloatKeyframe instance, bool isDelta) { }

	// RVA: 0x1E61D80 Offset: 0x1E60380 VA: 0x181E61D80
	public static DemoShotFloatKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotFloatKeyframe instance, bool isDelta) { }

	// RVA: 0x1E61FC0 Offset: 0x1E605C0 VA: 0x181E61FC0
	public static DemoShotFloatKeyframe DeserializeLength(Stream stream, int length, ref DemoShotFloatKeyframe instance, bool isDelta) { }

	// RVA: 0x1E625A0 Offset: 0x1E60BA0 VA: 0x181E625A0
	public static void SerializeDelta(Stream stream, DemoShotFloatKeyframe instance, DemoShotFloatKeyframe previous) { }

	// RVA: 0x1E628C0 Offset: 0x1E60EC0 VA: 0x181E628C0
	public static void Serialize(Stream stream, DemoShotFloatKeyframe instance) { }

	// RVA: 0x231B10 Offset: 0x230F10 VA: 0x180231B10
	public byte[] ToProtoBytes() { }

	// RVA: 0x231B30 Offset: 0x230F30 VA: 0x180231B30
	public void ToProto(Stream stream) { }

	// RVA: 0x1E627A0 Offset: 0x1E60DA0 VA: 0x181E627A0
	public static byte[] SerializeToBytes(DemoShotFloatKeyframe instance) { }

	// RVA: 0x1E626F0 Offset: 0x1E60CF0 VA: 0x181E626F0
	public static void SerializeLengthDelimited(Stream stream, DemoShotFloatKeyframe instance) { }

}

public class DemoShotQuaternionTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6471
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long trackType; // 0x18
	public List<DemoShotQuaternionKeyframe> keyframes; // 0x20

	// Methods

	// RVA: 0x1E688C0 Offset: 0x1E66EC0 VA: 0x181E688C0
	public static void ResetToPool(DemoShotQuaternionTrack instance) { }

	// RVA: 0x1E689B0 Offset: 0x1E66FB0 VA: 0x181E689B0
	public void ResetToPool() { }

	// RVA: 0x1E68800 Offset: 0x1E66E00 VA: 0x181E68800 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E67AC0 Offset: 0x1E660C0 VA: 0x181E67AC0
	public void CopyTo(DemoShotQuaternionTrack instance) { }

	// RVA: 0x1E67BD0 Offset: 0x1E661D0 VA: 0x181E67BD0
	public DemoShotQuaternionTrack Copy() { }

	// RVA: 0x1E68780 Offset: 0x1E66D80 VA: 0x181E68780
	public static DemoShotQuaternionTrack Deserialize(Stream stream) { }

	// RVA: 0x1E67F50 Offset: 0x1E66550 VA: 0x181E67F50
	public static DemoShotQuaternionTrack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E682B0 Offset: 0x1E668B0 VA: 0x181E682B0
	public static DemoShotQuaternionTrack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E68340 Offset: 0x1E66940 VA: 0x181E68340
	public static DemoShotQuaternionTrack Deserialize(byte[] buffer) { }

	// RVA: 0x1E68880 Offset: 0x1E66E80 VA: 0x181E68880
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E69150 Offset: 0x1E67750 VA: 0x181E69150 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E69170 Offset: 0x1E67770 VA: 0x181E69170 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShotQuaternionTrack previous) { }

	// RVA: 0x1E688A0 Offset: 0x1E66EA0 VA: 0x181E688A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E68460 Offset: 0x1E66A60 VA: 0x181E68460
	public static DemoShotQuaternionTrack Deserialize(byte[] buffer, DemoShotQuaternionTrack instance, bool isDelta = False) { }

	// RVA: 0x1E68560 Offset: 0x1E66B60 VA: 0x181E68560
	public static DemoShotQuaternionTrack Deserialize(Stream stream, DemoShotQuaternionTrack instance, bool isDelta) { }

	// RVA: 0x1E67C50 Offset: 0x1E66250 VA: 0x181E67C50
	public static DemoShotQuaternionTrack DeserializeLengthDelimited(Stream stream, DemoShotQuaternionTrack instance, bool isDelta) { }

	// RVA: 0x1E67FD0 Offset: 0x1E665D0 VA: 0x181E67FD0
	public static DemoShotQuaternionTrack DeserializeLength(Stream stream, int length, DemoShotQuaternionTrack instance, bool isDelta) { }

	// RVA: 0x1E68AA0 Offset: 0x1E670A0 VA: 0x181E68AA0
	public static void SerializeDelta(Stream stream, DemoShotQuaternionTrack instance, DemoShotQuaternionTrack previous) { }

	// RVA: 0x1E68EE0 Offset: 0x1E674E0 VA: 0x181E68EE0
	public static void Serialize(Stream stream, DemoShotQuaternionTrack instance) { }

	// RVA: 0x1E69140 Offset: 0x1E67740 VA: 0x181E69140
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E69150 Offset: 0x1E67750 VA: 0x181E69150
	public void ToProto(Stream stream) { }

	// RVA: 0x1E68DD0 Offset: 0x1E673D0 VA: 0x181E68DD0
	public static byte[] SerializeToBytes(DemoShotQuaternionTrack instance) { }

	// RVA: 0x1E68D20 Offset: 0x1E67320 VA: 0x181E68D20
	public static void SerializeLengthDelimited(Stream stream, DemoShotQuaternionTrack instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public struct DemoShotQuaternionKeyframe : IProto // TypeDefIndex: 6472
{	// Fields
	public float keyframeTime; // 0x0
	public float keyFrameValueX; // 0x4
	public float keyFrameValueY; // 0x8
	public float keyFrameValueZ; // 0xC
	public float keyFrameValueW; // 0x10

	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(DemoShotQuaternionKeyframe instance) { }

	// RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	public void CopyTo(DemoShotQuaternionKeyframe instance) { }

	// RVA: 0x231D30 Offset: 0x231130 VA: 0x180231D30
	public DemoShotQuaternionKeyframe Copy() { }

	// RVA: 0x1E66FA0 Offset: 0x1E655A0 VA: 0x181E66FA0
	public static DemoShotQuaternionKeyframe Deserialize(Stream stream) { }

	// RVA: 0x1E66900 Offset: 0x1E64F00 VA: 0x181E66900
	public static DemoShotQuaternionKeyframe DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E66C60 Offset: 0x1E65260 VA: 0x181E66C60
	public static DemoShotQuaternionKeyframe DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E67110 Offset: 0x1E65710 VA: 0x181E67110
	public static DemoShotQuaternionKeyframe Deserialize(byte[] buffer) { }

	// RVA: 0x231D40 Offset: 0x231140 VA: 0x180231D40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x231DD0 Offset: 0x2311D0 VA: 0x180231DD0 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x231E00 Offset: 0x231200 VA: 0x180231E00
	public void WriteToStreamDelta(Stream stream, DemoShotQuaternionKeyframe previous) { }

	// RVA: 0x231D70 Offset: 0x231170 VA: 0x180231D70 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E66FE0 Offset: 0x1E655E0 VA: 0x181E66FE0
	public static DemoShotQuaternionKeyframe Deserialize(byte[] buffer, ref DemoShotQuaternionKeyframe instance, bool isDelta = False) { }

	// RVA: 0x1E67220 Offset: 0x1E65820 VA: 0x181E67220
	public static DemoShotQuaternionKeyframe Deserialize(Stream stream, ref DemoShotQuaternionKeyframe instance, bool isDelta) { }

	// RVA: 0x1E66940 Offset: 0x1E64F40 VA: 0x181E66940
	public static DemoShotQuaternionKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotQuaternionKeyframe instance, bool isDelta) { }

	// RVA: 0x1E66CA0 Offset: 0x1E652A0 VA: 0x181E66CA0
	public static DemoShotQuaternionKeyframe DeserializeLength(Stream stream, int length, ref DemoShotQuaternionKeyframe instance, bool isDelta) { }

	// RVA: 0x1E67460 Offset: 0x1E65A60 VA: 0x181E67460
	public static void SerializeDelta(Stream stream, DemoShotQuaternionKeyframe instance, DemoShotQuaternionKeyframe previous) { }

	// RVA: 0x1E67930 Offset: 0x1E65F30 VA: 0x181E67930
	public static void Serialize(Stream stream, DemoShotQuaternionKeyframe instance) { }

	// RVA: 0x231DA0 Offset: 0x2311A0 VA: 0x180231DA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x231DD0 Offset: 0x2311D0 VA: 0x180231DD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E67800 Offset: 0x1E65E00 VA: 0x181E67800
	public static byte[] SerializeToBytes(DemoShotQuaternionKeyframe instance) { }

	// RVA: 0x1E67740 Offset: 0x1E65D40 VA: 0x181E67740
	public static void SerializeLengthDelimited(Stream stream, DemoShotQuaternionKeyframe instance) { }

}

public class DemoShotParentTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6473
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong parentId; // 0x18
	public List<DemoShotParentKeyframe> keyframes; // 0x20

	// Methods

	// RVA: 0x1E66060 Offset: 0x1E64660 VA: 0x181E66060
	public static void ResetToPool(DemoShotParentTrack instance) { }

	// RVA: 0x1E66150 Offset: 0x1E64750 VA: 0x181E66150
	public void ResetToPool() { }

	// RVA: 0x1E65FA0 Offset: 0x1E645A0 VA: 0x181E65FA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E65250 Offset: 0x1E63850 VA: 0x181E65250
	public void CopyTo(DemoShotParentTrack instance) { }

	// RVA: 0x1E653E0 Offset: 0x1E639E0 VA: 0x181E653E0
	public DemoShotParentTrack Copy() { }

	// RVA: 0x1E65D20 Offset: 0x1E64320 VA: 0x181E65D20
	public static DemoShotParentTrack Deserialize(Stream stream) { }

	// RVA: 0x1E65460 Offset: 0x1E63A60 VA: 0x181E65460
	public static DemoShotParentTrack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E657C0 Offset: 0x1E63DC0 VA: 0x181E657C0
	public static DemoShotParentTrack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E65C00 Offset: 0x1E64200 VA: 0x181E65C00
	public static DemoShotParentTrack Deserialize(byte[] buffer) { }

	// RVA: 0x1E66020 Offset: 0x1E64620 VA: 0x181E66020
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E668C0 Offset: 0x1E64EC0 VA: 0x181E668C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E668E0 Offset: 0x1E64EE0 VA: 0x181E668E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShotParentTrack previous) { }

	// RVA: 0x1E66040 Offset: 0x1E64640 VA: 0x181E66040 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E65B00 Offset: 0x1E64100 VA: 0x181E65B00
	public static DemoShotParentTrack Deserialize(byte[] buffer, DemoShotParentTrack instance, bool isDelta = False) { }

	// RVA: 0x1E65DA0 Offset: 0x1E643A0 VA: 0x181E65DA0
	public static DemoShotParentTrack Deserialize(Stream stream, DemoShotParentTrack instance, bool isDelta) { }

	// RVA: 0x1E654E0 Offset: 0x1E63AE0 VA: 0x181E654E0
	public static DemoShotParentTrack DeserializeLengthDelimited(Stream stream, DemoShotParentTrack instance, bool isDelta) { }

	// RVA: 0x1E65850 Offset: 0x1E63E50 VA: 0x181E65850
	public static DemoShotParentTrack DeserializeLength(Stream stream, int length, DemoShotParentTrack instance, bool isDelta) { }

	// RVA: 0x1E66240 Offset: 0x1E64840 VA: 0x181E66240
	public static void SerializeDelta(Stream stream, DemoShotParentTrack instance, DemoShotParentTrack previous) { }

	// RVA: 0x1E66670 Offset: 0x1E64C70 VA: 0x181E66670
	public static void Serialize(Stream stream, DemoShotParentTrack instance) { }

	// RVA: 0x1E668B0 Offset: 0x1E64EB0 VA: 0x181E668B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E668C0 Offset: 0x1E64EC0 VA: 0x181E668C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E66560 Offset: 0x1E64B60 VA: 0x181E66560
	public static byte[] SerializeToBytes(DemoShotParentTrack instance) { }

	// RVA: 0x1E664B0 Offset: 0x1E64AB0 VA: 0x181E664B0
	public static void SerializeLengthDelimited(Stream stream, DemoShotParentTrack instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public struct DemoShotParentKeyframe : IProto // TypeDefIndex: 6474
{	// Fields
	public float keyframeTime; // 0x0
	public uint keyFrameParentId; // 0x4
	public string keyFrameParentName; // 0x8

	// Methods

	// RVA: 0x1E64C50 Offset: 0x1E63250 VA: 0x181E64C50
	public static void ResetToPool(DemoShotParentKeyframe instance) { }

	// RVA: 0x231B70 Offset: 0x230F70 VA: 0x180231B70
	public void CopyTo(DemoShotParentKeyframe instance) { }

	// RVA: 0x231BA0 Offset: 0x230FA0 VA: 0x180231BA0
	public DemoShotParentKeyframe Copy() { }

	// RVA: 0x1E64830 Offset: 0x1E62E30 VA: 0x181E64830
	public static DemoShotParentKeyframe Deserialize(Stream stream) { }

	// RVA: 0x1E64540 Offset: 0x1E62B40 VA: 0x181E64540
	public static DemoShotParentKeyframe DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E64580 Offset: 0x1E62B80 VA: 0x181E64580
	public static DemoShotParentKeyframe DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E64870 Offset: 0x1E62E70 VA: 0x181E64870
	public static DemoShotParentKeyframe Deserialize(byte[] buffer) { }

	// RVA: 0x231BE0 Offset: 0x230FE0 VA: 0x180231BE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x231C60 Offset: 0x231060 VA: 0x180231C60 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x231C90 Offset: 0x231090 VA: 0x180231C90
	public void WriteToStreamDelta(Stream stream, DemoShotParentKeyframe previous) { }

	// RVA: 0x231C10 Offset: 0x231010 VA: 0x180231C10 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E64970 Offset: 0x1E62F70 VA: 0x181E64970
	public static DemoShotParentKeyframe Deserialize(byte[] buffer, ref DemoShotParentKeyframe instance, bool isDelta = False) { }

	// RVA: 0x1E64AA0 Offset: 0x1E630A0 VA: 0x181E64AA0
	public static DemoShotParentKeyframe Deserialize(Stream stream, ref DemoShotParentKeyframe instance, bool isDelta) { }

	// RVA: 0x1E642A0 Offset: 0x1E628A0 VA: 0x181E642A0
	public static DemoShotParentKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotParentKeyframe instance, bool isDelta) { }

	// RVA: 0x1E645C0 Offset: 0x1E62BC0 VA: 0x181E645C0
	public static DemoShotParentKeyframe DeserializeLength(Stream stream, int length, ref DemoShotParentKeyframe instance, bool isDelta) { }

	// RVA: 0x1E64CA0 Offset: 0x1E632A0 VA: 0x181E64CA0
	public static void SerializeDelta(Stream stream, DemoShotParentKeyframe instance, DemoShotParentKeyframe previous) { }

	// RVA: 0x1E650B0 Offset: 0x1E636B0 VA: 0x181E650B0
	public static void Serialize(Stream stream, DemoShotParentKeyframe instance) { }

	// RVA: 0x231C40 Offset: 0x231040 VA: 0x180231C40
	public byte[] ToProtoBytes() { }

	// RVA: 0x231C60 Offset: 0x231060 VA: 0x180231C60
	public void ToProto(Stream stream) { }

	// RVA: 0x1E64F90 Offset: 0x1E63590 VA: 0x181E64F90
	public static byte[] SerializeToBytes(DemoShotParentKeyframe instance) { }

	// RVA: 0x1E64EE0 Offset: 0x1E634E0 VA: 0x181E64EE0
	public static void SerializeLengthDelimited(Stream stream, DemoShotParentKeyframe instance) { }

}

public class DemoClient : Client, IDisposable // TypeDefIndex: 6692
{	// Fields
	protected Reader demoFile; // 0x70

	// Properties
	public override bool IsPlaying { get; }
	public bool PlayingFinished { get; }

	// Methods

	// RVA: 0x220EF20 Offset: 0x220D520 VA: 0x18220EF20
	public void .ctor(Reader demoFile) { }

	// RVA: 0x220E7D0 Offset: 0x220CDD0 VA: 0x18220E7D0 Slot: 14
	public virtual void Dispose() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	public override bool IsConnected() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 7
	public override bool get_IsPlaying() { }

	// RVA: 0x220F0D0 Offset: 0x220D6D0 VA: 0x18220F0D0
	public bool get_PlayingFinished() { }

	// RVA: 0x220EE00 Offset: 0x220D400 VA: 0x18220EE00
	public void UpdatePlayback(long frameTime) { }

	// RVA: 0x220ED60 Offset: 0x220D360 VA: 0x18220ED60
	private bool PlaybackPacket() { }

	// RVA: 0x220E800 Offset: 0x220CE00 VA: 0x18220E800
	private void HandleMessage(IntPtr data, int size) { }

}

public class DemoShotPlayback : MonoBehaviour // TypeDefIndex: 9179
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private DemoShot <CurrentShot>k__BackingField; // 0x18
	private bool playing; // 0x20
	public static DemoShotPlayback Instance; // 0x0
	public bool ShouldLoop; // 0x21

	// Properties
	public DemoShot CurrentShot { get; set; }
	public static bool IsPlayingShot { get; }
	public float CurrentShotTime { get; }
	public string CurrentShotName { get; }
	public float ShotPlaybackProgress { get; }
	public float ShotLength { get; }
	public float ShotEndTime { get; }
	public bool IsPaused { get; }
	public DemoShotVectorTrack CameraPositionTrack { get; }
	public float ShotStartTime { get; }
	public bool HasDofData { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public DemoShot get_CurrentShot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_CurrentShot(DemoShot value) { }

	// RVA: 0x8553A0 Offset: 0x8539A0 VA: 0x1808553A0
	public static bool get_IsPlayingShot() { }

	// RVA: 0x8552B0 Offset: 0x8538B0 VA: 0x1808552B0
	public float get_CurrentShotTime() { }

	// RVA: 0x8547C0 Offset: 0x852DC0 VA: 0x1808547C0
	public void Setup(DemoShot shot) { }

	// RVA: 0x854670 Offset: 0x852C70 VA: 0x180854670
	public void PlayFromStart() { }

	// RVA: 0x8545F0 Offset: 0x852BF0 VA: 0x1808545F0
	public void PauseShot() { }

	// RVA: 0x8546D0 Offset: 0x852CD0 VA: 0x1808546D0
	public void ResumeShot() { }

	// RVA: 0x854160 Offset: 0x852760 VA: 0x180854160
	public void EndShot() { }

	// RVA: 0x854990 Offset: 0x852F90 VA: 0x180854990
	private void Update() { }

	// RVA: 0x854470 Offset: 0x852A70 VA: 0x180854470
	private void OnDrawGizmosSelected() { }

	// RVA: 0x855290 Offset: 0x853890 VA: 0x180855290
	public string get_CurrentShotName() { }

	// RVA: 0x855480 Offset: 0x853A80 VA: 0x180855480
	public float get_ShotPlaybackProgress() { }

	// RVA: 0x855460 Offset: 0x853A60 VA: 0x180855460
	public float get_ShotLength() { }

	// RVA: 0x855430 Offset: 0x853A30 VA: 0x180855430
	public float get_ShotEndTime() { }

	// RVA: 0x855350 Offset: 0x853950 VA: 0x180855350
	public bool get_IsPaused() { }

	// RVA: 0x855270 Offset: 0x853870 VA: 0x180855270
	public DemoShotVectorTrack get_CameraPositionTrack() { }

	// RVA: 0x8554B0 Offset: 0x853AB0 VA: 0x1808554B0
	public float get_ShotStartTime() { }

	// RVA: 0x855330 Offset: 0x853930 VA: 0x180855330
	public bool get_HasDofData() { }

	// RVA: 0x854720 Offset: 0x852D20 VA: 0x180854720
	public void SetShotTime(float newTime) { }

	// RVA: 0x8540B0 Offset: 0x8526B0 VA: 0x1808540B0
	public float ClampTimeToShotRange(float val) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class DemoShotRecorder : SingletonComponent<DemoShotRecorder> // TypeDefIndex: 9180
{	// Fields
	private DemoShot recordingShot; // 0x18
	private float lastKeyframe; // 0x20
	private bool hasStarted; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private RealTimeUntil <CountdownEnds>k__BackingField; // 0x28
	public const float CountdownDuration = 3;
	private CameraMan.CameraState startSettings; // 0x2C
	private DemoShotRecorder.RecorderSettings settings; // 0x50
	public static string lastSavedShotName; // 0x0
	private string preRecordShotName; // 0x68
	private float countdownStartTime; // 0x70

	// Properties
	public RealTimeUntil CountdownEnds { get; set; }
	public bool IsInCountdown { get; }
	public float CurrentShotTime { get; }
	public string CurrentShotName { get; }
	public float ShotStartTime { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public RealTimeUntil get_CountdownEnds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0D60 Offset: 0x7CF360 VA: 0x1807D0D60
	private void set_CountdownEnds(RealTimeUntil value) { }

	// RVA: 0x8586E0 Offset: 0x856CE0 VA: 0x1808586E0
	public bool get_IsInCountdown() { }

	// RVA: 0x856270 Offset: 0x854870 VA: 0x180856270
	public static void CreateNewShot(string shotName, DemoShotRecorder.RecorderSettings withSettings) { }

	// RVA: 0x858650 Offset: 0x856C50 VA: 0x180858650
	public float get_CurrentShotTime() { }

	// RVA: 0x858630 Offset: 0x856C30 VA: 0x180858630
	public string get_CurrentShotName() { }

	// RVA: 0x858700 Offset: 0x856D00 VA: 0x180858700
	public float get_ShotStartTime() { }

	[IteratorStateMachineAttribute] // RVA: 0xD6670 Offset: 0xD5A70 VA: 0x1800D6670
	// RVA: 0x858400 Offset: 0x856A00 VA: 0x180858400
	private IEnumerator StartRecording(string shotName, DemoShotRecorder.RecorderSettings withSettings) { }

	// RVA: 0x856200 Offset: 0x854800 VA: 0x180856200
	public void CancelRecording() { }

	// RVA: 0x8563B0 Offset: 0x8549B0 VA: 0x1808563B0
	public void FinishRecording() { }

	// RVA: 0x856FE0 Offset: 0x8555E0 VA: 0x180856FE0
	public static string GetShotDirectory(string demoName, bool createDirectory = False) { }

	// RVA: 0x856A70 Offset: 0x855070 VA: 0x180856A70
	public static string GetFilePath(string shotName, string demoName, string folderName, bool createDirectory = False) { }

	// RVA: 0x856B60 Offset: 0x855160 VA: 0x180856B60
	public static Dictionary<string, List<string>> GetPathsOfAllShots(string demoName) { }

	// RVA: 0x858220 Offset: 0x856820 VA: 0x180858220
	private static int SortWithTrailingNumber(string x, string y) { }

	// RVA: 0x8570E0 Offset: 0x8556E0 VA: 0x1808570E0
	public static string GetTrailingFolder(string path) { }

	// RVA: 0x8584C0 Offset: 0x856AC0 VA: 0x1808584C0
	private void Update() { }

	// RVA: 0x8573A0 Offset: 0x8559A0 VA: 0x1808573A0
	private void RecordCameraState() { }

	// RVA: 0x857D90 Offset: 0x856390 VA: 0x180857D90
	private void RecordKeyframe(Vector3 value, DemoShotVectorTrack track) { }

	// RVA: 0x857B90 Offset: 0x856190 VA: 0x180857B90
	private void RecordKeyframe(float value, DemoShotFloatTrack track) { }

	// RVA: 0x8578C0 Offset: 0x855EC0 VA: 0x1808578C0
	private void RecordKeyframe(Quaternion value, DemoShotQuaternionTrack track) { }

	// RVA: 0x858020 Offset: 0x856620 VA: 0x180858020
	private void RecordParent(BaseEntity parent, string bone, DemoShotParentTrack track) { }

	// RVA: 0x857320 Offset: 0x855920 VA: 0x180857320
	private DemoShotVectorTrack InitialiseKeyframeVectorTrack() { }

	// RVA: 0x8572A0 Offset: 0x8558A0 VA: 0x1808572A0
	private DemoShotQuaternionTrack InitialiseKeyframeQuaternionTrack() { }

	// RVA: 0x8571A0 Offset: 0x8557A0 VA: 0x1808571A0
	private DemoShotFloatTrack InitialiseKeyframeFloatTrack() { }

	// RVA: 0x857220 Offset: 0x855820 VA: 0x180857220
	private DemoShotParentTrack InitialiseKeyframeParentTrack() { }

	// RVA: 0x8585D0 Offset: 0x856BD0 VA: 0x1808585D0
	public void .ctor() { }

	// RVA: 0x858580 Offset: 0x856B80 VA: 0x180858580
	private static void .cctor() { }

}

public struct DemoShotRecorder.RecorderSettings // TypeDefIndex: 9181
{	// Fields
	public bool Countdown; // 0x0
	public bool PauseOnSave; // 0x1
	public bool ReturnToShotStart; // 0x2
	public string FolderName; // 0x8
	public bool RecordDof; // 0x10

}

private sealed class DemoShotRecorder.<StartRecording>d__23 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9182
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public DemoShotRecorder <>4__this; // 0x20
	public DemoShotRecorder.RecorderSettings withSettings; // 0x28
	public string shotName; // 0x40
	private float <waitTime>5__2; // 0x48
	private float <leftover>5__3; // 0x4C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x98B4C0 Offset: 0x989AC0 VA: 0x18098B4C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x98BC20 Offset: 0x98A220 VA: 0x18098BC20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public static class DemoShotHelpers // TypeDefIndex: 9183
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x851090 Offset: 0x84F690 VA: 0x180851090
	public static Vector3 GetVectorFromTrack(DemoShotVectorTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x850CE0 Offset: 0x84F2E0 VA: 0x180850CE0
	public static Quaternion GetQuaternionFromTrack(DemoShotQuaternionTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x850150 Offset: 0x84E750 VA: 0x180850150
	public static float GetFloatFromTrack(DemoShotFloatTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x850B30 Offset: 0x84F130 VA: 0x180850B30
	public static DemoShotParentKeyframe GetParentFromTrack(DemoShotParentTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x850410 Offset: 0x84EA10 VA: 0x180850410
	public static void GetKeyframesInRange(DemoShotVectorTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8506A0 Offset: 0x84ECA0 VA: 0x1808506A0
	public static void GetKeyframesInRange(DemoShotQuaternionTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x850910 Offset: 0x84EF10 VA: 0x180850910
	public static void GetKeyframesInRange(DemoShotFloatTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8514E0 Offset: 0x84FAE0 VA: 0x1808514E0
	public static Quaternion ToQuaternion(DemoShotQuaternionKeyframe keyframe) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8514B0 Offset: 0x84FAB0 VA: 0x1808514B0
	public static DemoShotQuaternionKeyframe ToKeyframe(Quaternion value, float time) { }

}

public class DemoPlaybackUI : SingletonComponent<DemoPlaybackUI> // TypeDefIndex: 10855
{	// Fields
	public GameObject Root; // 0x18

	// Methods

	// RVA: 0x84CC40 Offset: 0x84B240 VA: 0x18084CC40
	private void Start() { }

	// RVA: 0x84CD00 Offset: 0x84B300 VA: 0x18084CD00
	public void Toggle(bool state) { }

	// RVA: 0x84CD80 Offset: 0x84B380 VA: 0x18084CD80
	public void .ctor() { }

}

public class DemoPlaybackWidget : MonoBehaviour // TypeDefIndex: 10856
{	// Fields
	public RustSlider DemoProgress; // 0x18
	public RustText DemoName; // 0x20
	public RustText DemoDuration; // 0x28
	public RustText DemoCurrentTime; // 0x30
	public GameObject PausedRoot; // 0x38
	public GameObject PlayingRoot; // 0x40
	public RectTransform DemoPlaybackHandle; // 0x48
	public RectTransform ShotPlaybackWindow; // 0x50
	public RustButton LoopButton; // 0x58
	public GameObject ShotButtonRoot; // 0x60
	public RustText ShotNameText; // 0x68
	public GameObject ShotNameRoot; // 0x70
	public RectTransform ShotRecordWindow; // 0x78
	private bool blockProgressInput; // 0x80
	private bool isDraggingSlider; // 0x81
	private RealTimeSince lastDrag; // 0x84
	private bool pausedAtStartOfDrag; // 0x88

	// Methods

	// RVA: 0x84DBA0 Offset: 0x84C1A0 VA: 0x18084DBA0
	private void Update() { }

	// RVA: 0x84DAF0 Offset: 0x84C0F0 VA: 0x18084DAF0
	private void SetRectTransformAnchoredX(float xPos, RectTransform t) { }

	// RVA: 0x84D690 Offset: 0x84BC90 VA: 0x18084D690
	public void OnClickedSlider(float value) { }

	// RVA: 0x84DB50 Offset: 0x84C150 VA: 0x18084DB50
	private void TimelineScrubCheck() { }

	// RVA: 0x84D120 Offset: 0x84B720 VA: 0x18084D120
	public void OnClickedPlay() { }

	// RVA: 0x84D090 Offset: 0x84B690 VA: 0x18084D090
	public void OnClickedPause() { }

	// RVA: 0x84CDE0 Offset: 0x84B3E0 VA: 0x18084CDE0
	public void OnClickedBackToStart() { }

	// RVA: 0x84D990 Offset: 0x84BF90 VA: 0x18084D990
	public void OnClickedToEnd() { }

	// RVA: 0x84CF60 Offset: 0x84B560 VA: 0x18084CF60
	public void OnClickedLoop() { }

	// RVA: 0x84CEE0 Offset: 0x84B4E0 VA: 0x18084CEE0
	public void OnClickedCancelShot() { }

	// RVA: 0x84CFF0 Offset: 0x84B5F0 VA: 0x18084CFF0
	public void OnClickedNextFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x7FF90 Offset: 0x7F390 VA: 0x18007FF90
	// RVA: 0x84E5E0 Offset: 0x84CBE0 VA: 0x18084E5E0
	private IEnumerator WaitAndPause() { }

	// RVA: 0x84D4B0 Offset: 0x84BAB0 VA: 0x18084D4B0
	public void OnClickedPreviousFrame() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

private sealed class DemoPlaybackWidget.<WaitAndPause>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10857
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x8592F0 Offset: 0x8578F0 VA: 0x1808592F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8593B0 Offset: 0x8579B0 VA: 0x1808593B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class DemoRootFade : MonoBehaviour // TypeDefIndex: 10858
{	// Fields
	public CanvasGroup Canvas; // 0x18
	public static bool ToggleHide; // 0x0

	// Methods

	// RVA: 0x84F8D0 Offset: 0x84DED0 VA: 0x18084F8D0
	private void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class DemoShotButton : RustButton, IPointerClickHandler, IEventSystemHandler // TypeDefIndex: 10859
{	// Fields
	public bool FireEventOnClicked; // 0x98

	// Methods

	// RVA: 0x84FA80 Offset: 0x84E080 VA: 0x18084FA80 Slot: 42
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x84FAA0 Offset: 0x84E0A0 VA: 0x18084FAA0 Slot: 43
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x84FA60 Offset: 0x84E060 VA: 0x18084FA60 Slot: 44
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x6F1FF0 Offset: 0x6F05F0 VA: 0x1806F1FF0
	public void .ctor() { }

}

public class DemoShotEntry : MonoBehaviour, IDraggable // TypeDefIndex: 10860
{	// Fields
	public RustButton PlayButton; // 0x18
	public Sprite DragSprite; // 0x20
	public RustInput RenameInput; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private DemoShot <CurrentShot>k__BackingField; // 0x30

	// Properties
	public DemoShot CurrentShot { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public DemoShot get_CurrentShot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	private void set_CurrentShot(DemoShot value) { }

	// RVA: 0x850030 Offset: 0x84E630 VA: 0x180850030
	public void Populate(DemoShot shot, string folder) { }

	// RVA: 0x84FD40 Offset: 0x84E340 VA: 0x18084FD40
	public void OnClicked() { }

	// RVA: 0x850090 Offset: 0x84E690 VA: 0x180850090
	public void StopShot() { }

	// RVA: 0x84FB90 Offset: 0x84E190 VA: 0x18084FB90
	public void OnClickedDelete() { }

	// RVA: 0x850130 Offset: 0x84E730 VA: 0x180850130
	public void TogglePlayingRoot(bool state) { }

	// RVA: 0x850000 Offset: 0x84E600 VA: 0x180850000
	public void PopulateRename() { }

	// RVA: 0x84FAC0 Offset: 0x84E0C0 VA: 0x18084FAC0
	public void ApplyRename() { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050 Slot: 4
	public object GetDragData() { }

	// RVA: 0x84FB60 Offset: 0x84E160 VA: 0x18084FB60 Slot: 5
	public string GetDragType() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 6
	public Sprite GetDragSprite() { }

	// RVA: 0x84FDA0 Offset: 0x84E3A0 VA: 0x18084FDA0
	public void OnDroppedValue(object data) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class DemoShotListFolderWidget : MonoBehaviour // TypeDefIndex: 10861
{	// Fields
	public RustButton FolderName; // 0x18
	public Transform ChildRoot; // 0x20
	public GameObject UpArrow; // 0x28
	public GameObject DownArrow; // 0x30
	public RustText CountText; // 0x38
	public GameObject OpenRoot; // 0x40
	public GameObject ModifyRoot; // 0x48
	public RustInput FolderRenameInput; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <CurrentState>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <cachedFolderName>k__BackingField; // 0x60

	// Properties
	public bool CurrentState { get; set; }
	public string cachedFolderName { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x592630 Offset: 0x590C30 VA: 0x180592630
	public bool get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x592640 Offset: 0x590C40 VA: 0x180592640
	private void set_CurrentState(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	public string get_cachedFolderName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	private void set_cachedFolderName(string value) { }

	// RVA: 0x851B90 Offset: 0x850190 VA: 0x180851B90
	public void Populate(string folderName, bool state) { }

	// RVA: 0x851CB0 Offset: 0x8502B0 VA: 0x180851CB0
	public void ToggleState() { }

	// RVA: 0x851CC0 Offset: 0x8502C0 VA: 0x180851CC0
	public void ToggleState(bool state) { }

	// RVA: 0x851540 Offset: 0x84FB40 VA: 0x180851540
	public void AddChild(DemoShotEntry shot) { }

	// RVA: 0x851D70 Offset: 0x850370 VA: 0x180851D70
	private void UpdateCountText() { }

	// RVA: 0x8518A0 Offset: 0x84FEA0 VA: 0x1808518A0
	public void OnDroppedValue(object data) { }

	// RVA: 0x851AF0 Offset: 0x8500F0 VA: 0x180851AF0
	public void OnRightClick() { }

	// RVA: 0x851590 Offset: 0x84FB90 VA: 0x180851590
	public void OnClickedDeleteFolder() { }

	// RVA: 0x8516E0 Offset: 0x84FCE0 VA: 0x1808516E0
	public void OnClickedRenameFolder() { }

	// RVA: 0x851E00 Offset: 0x850400 VA: 0x180851E00
	public void .ctor() { }

}

public class DemoShotListRootFolder : MonoBehaviour // TypeDefIndex: 10862
{	// Methods

	// RVA: 0x851E10 Offset: 0x850410 VA: 0x180851E10
	public void OnDroppedValue(object data) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class DemoShotListWidget : SingletonComponent<DemoShotListWidget> // TypeDefIndex: 10863
{	// Fields
	public GameObjectRef ShotListEntry; // 0x18
	public GameObjectRef FolderEntry; // 0x20
	public Transform ShotListParent; // 0x28
	public RustInput FolderNameInput; // 0x30
	public GameObject ShotsRoot; // 0x38
	public GameObject NoShotsRoot; // 0x40
	public GameObject TopUpArrow; // 0x48
	public GameObject TopDownArrow; // 0x50
	public Canvas DragCanvas; // 0x58
	private Dictionary<string, List<DemoShot>> foundShots; // 0x60
	private List<DemoShotEntry> spawnedEntries; // 0x68
	private List<DemoShotListFolderWidget> spawnedFolders; // 0x70
	private bool isOpen; // 0x78

	// Properties
	private int TotalShotCount { get; }

	// Methods

	// RVA: 0x8528F0 Offset: 0x850EF0 VA: 0x1808528F0
	private void OnEnable() { }

	// RVA: 0x852E90 Offset: 0x851490 VA: 0x180852E90
	public void UpdateAvailableShots() { }

	// RVA: 0x852C20 Offset: 0x851220 VA: 0x180852C20
	public void SetCurrentlyPlaying(DemoShot shot) { }

	// RVA: 0x853F80 Offset: 0x852580 VA: 0x180853F80
	private int get_TotalShotCount() { }

	// RVA: 0x852500 Offset: 0x850B00 VA: 0x180852500
	public string GetDefaultNewShotName() { }

	// RVA: 0x852260 Offset: 0x850860 VA: 0x180852260
	public void DeleteShot(DemoShot shotName) { }

	// RVA: 0x852A50 Offset: 0x851050 VA: 0x180852A50
	public void RenameShot(DemoShot shotToRename, string newName) { }

	// RVA: 0x852060 Offset: 0x850660 VA: 0x180852060
	public void CreateFolder() { }

	// RVA: 0x852D80 Offset: 0x851380 VA: 0x180852D80
	public void ToggleOpen(bool state) { }

	// RVA: 0x852D70 Offset: 0x851370 VA: 0x180852D70
	public void ToggleOpen() { }

	// RVA: 0x8523B0 Offset: 0x8509B0 VA: 0x1808523B0
	public List<string> GetCurrentFolders() { }

	// RVA: 0x852740 Offset: 0x850D40 VA: 0x180852740
	public void MoveShotToFolder(DemoShot shot, string targetFolder) { }

	// RVA: 0x852900 Offset: 0x850F00 VA: 0x180852900
	public void RenameFolder(string oldName, string newName) { }

	// RVA: 0x852160 Offset: 0x850760 VA: 0x180852160
	public void DeleteFolder(string folderName) { }

	// RVA: 0x853E90 Offset: 0x852490 VA: 0x180853E90
	public void .ctor() { }

}

public class DemoShotRecordWidget : MonoBehaviour // TypeDefIndex: 10864
{	// Fields
	public RustInput NameInput; // 0x18
	public GameObject RecordingRoot; // 0x20
	public GameObject PreRecordingRoot; // 0x28
	public RustButton CountdownToggle; // 0x30
	public RustButton PauseOnSaveToggle; // 0x38
	public RustButton ReturnToStartToggle; // 0x40
	public RustButton RecordDofToggle; // 0x48
	public RustOption FolderDropdown; // 0x50
	public GameObject RecordingUnderlay; // 0x58
	public AudioSource CountdownAudio; // 0x60
	public GameObject ShotRecordTime; // 0x68
	public RustText ShotRecordTimeText; // 0x70
	public RustText ShotNameText; // 0x78
	public GameObject RecordingInProcessRoot; // 0x80
	public GameObject CountdownActiveRoot; // 0x88
	public GameObject CountdownActiveSliderRoot; // 0x90
	public RustSlider CountdownActiveSlider; // 0x98
	public RustText CountdownActiveText; // 0xA0
	public static DemoShotRecordWidget Instance; // 0x0

	// Methods

	// RVA: 0x855B40 Offset: 0x854140 VA: 0x180855B40
	private void Start() { }

	// RVA: 0x855820 Offset: 0x853E20 VA: 0x180855820
	private void OnEnable() { }

	// RVA: 0x855D30 Offset: 0x854330 VA: 0x180855D30
	public void UpdateShotName() { }

	// RVA: 0x855DC0 Offset: 0x8543C0 VA: 0x180855DC0
	private void Update() { }

	// RVA: 0x855540 Offset: 0x853B40 VA: 0x180855540
	public void OnClickedStartRecording() { }

	// RVA: 0x8554D0 Offset: 0x853AD0 VA: 0x1808554D0
	public void OnClickedFinish() { }

	// RVA: 0x855C30 Offset: 0x854230 VA: 0x180855C30
	public void Toggle(bool state) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class DemoText : MonoBehaviour // TypeDefIndex: 10865
{	// Fields
	public RustText TimeText; // 0x18
	public RustText TotalSecondText; // 0x20
	public RustText TimeScaleText; // 0x28
	public RustText FilenameText; // 0x30
	public RustText DateTimeText; // 0x38
	public RustText ParentText; // 0x40
	public RustText DofText; // 0x48
	public GameObject InternalRoot; // 0x50
	public GameObject ParentRoot; // 0x58
	public GameObject DofRoot; // 0x60

	// Methods

	// RVA: 0x970E30 Offset: 0x96F430 VA: 0x180970E30
	private void Update() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

public class DemoRecorder : SingletonComponent<DemoRecorder> // TypeDefIndex: 10870
{	// Fields
	public RustInput Input; // 0x18
	public GameObject RecordingUnderlay; // 0x20
	private bool IsOpen; // 0x28

	// Methods

	// RVA: 0x84EE70 Offset: 0x84D470 VA: 0x18084EE70 Slot: 6
	protected override void Awake() { }

	// RVA: 0x84F1C0 Offset: 0x84D7C0 VA: 0x18084F1C0
	public void Open() { }

	// RVA: 0x84F6A0 Offset: 0x84DCA0 VA: 0x18084F6A0
	public void Update() { }

	// RVA: 0x84EF80 Offset: 0x84D580 VA: 0x18084EF80
	public void Close() { }

	// RVA: 0x84F5E0 Offset: 0x84DBE0 VA: 0x18084F5E0
	public void SubmitRecord() { }

	// RVA: 0x84F560 Offset: 0x84DB60 VA: 0x18084F560
	public void Record() { }

	// RVA: 0x84F870 Offset: 0x84DE70 VA: 0x18084F870
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4E63F0 Offset: 0x4E49F0 VA: 0x1804E63F0
	private void <Close>b__6_0() { }

}

public class DemoRecorderProgress : SingletonComponent<DemoRecorderProgress> // TypeDefIndex: 10871
{	// Fields
	public RustText RecordingLabel; // 0x18
	public RustText ProgressLabel; // 0x20
	public GameObject RecordingUnderlay; // 0x28
	private CanvasGroup canvasGroup; // 0x30
	private NeedsCursor needsCursor; // 0x38

	// Methods

	// RVA: 0x84E630 Offset: 0x84CC30 VA: 0x18084E630 Slot: 6
	protected override void Awake() { }

	// RVA: 0x84E7D0 Offset: 0x84CDD0 VA: 0x18084E7D0
	public void Open(string recordingName) { }

	// RVA: 0x84EA20 Offset: 0x84D020 VA: 0x18084EA20
	public void Update() { }

	// RVA: 0x84E6E0 Offset: 0x84CCE0 VA: 0x18084E6E0
	public void Close() { }

	// RVA: 0x84E750 Offset: 0x84CD50 VA: 0x18084E750
	public void EnableCursor(bool enable) { }

	// RVA: 0x84E970 Offset: 0x84CF70 VA: 0x18084E970
	public void Stop() { }

	// RVA: 0x84EE10 Offset: 0x84D410 VA: 0x18084EE10
	public void .ctor() { }

}

public class DemoItem : RustButton // TypeDefIndex: 11099
{	// Fields
	public Demos demos; // 0x98
	public int itemId; // 0xA0
	public RustText nameText; // 0xA8
	public RustText dateText; // 0xB0
	public RustText lengthText; // 0xB8

	// Methods

	// RVA: 0x84CBB0 Offset: 0x84B1B0 VA: 0x18084CBB0
	public void OnClicked() { }

	// RVA: 0x84CA90 Offset: 0x84B090 VA: 0x18084CA90 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0x6F1FF0 Offset: 0x6F05F0 VA: 0x1806F1FF0
	public void .ctor() { }

}

public class Demos : SingletonComponent<Demos>, VirtualScroll.IDataSource // TypeDefIndex: 11100
{	// Fields
	public VirtualScroll virtualScroll; // 0x18
	public GameObject deletePopup; // 0x20
	private readonly List<Demos.DemoInfo> _demoInfo; // 0x28
	private readonly List<Demos.DemoInfo> _sortedDemoInfo; // 0x30
	private DemoItem _selectedItem; // 0x38
	private string sortOrder; // 0x40

	// Methods

	// RVA: 0x971550 Offset: 0x96FB50 VA: 0x180971550 Slot: 6
	protected override void Awake() { }

	// RVA: 0x971720 Offset: 0x96FD20 VA: 0x180971720
	private void DeselectItem() { }

	// RVA: 0x972190 Offset: 0x970790 VA: 0x180972190
	private void Populate() { }

	// RVA: 0x972480 Offset: 0x970A80 VA: 0x180972480
	private void Rebuild() { }

	// RVA: 0x972100 Offset: 0x970700 VA: 0x180972100
	public void OrderBy(string strBy) { }

	// RVA: 0x9717D0 Offset: 0x96FDD0 VA: 0x1809717D0 Slot: 8
	public int GetItemCount() { }

	// RVA: 0x972520 Offset: 0x970B20 VA: 0x180972520 Slot: 9
	public void SetItemData(int i, GameObject obj) { }

	// RVA: 0x971810 Offset: 0x96FE10 VA: 0x180971810
	private IOrderedEnumerable<Demos.DemoInfo> GetSortedInfo() { }

	// RVA: 0x971EA0 Offset: 0x9704A0 VA: 0x180971EA0
	public void OnItemClicked(DemoItem item) { }

	// RVA: 0x971E20 Offset: 0x970420 VA: 0x180971E20
	public void OnDeleteItem() { }

	// RVA: 0x971570 Offset: 0x96FB70 VA: 0x180971570
	public void DeleteItem() { }

	// RVA: 0x971FF0 Offset: 0x9705F0 VA: 0x180971FF0
	public void OnPlayItem() { }

	// RVA: 0x9720C0 Offset: 0x9706C0 VA: 0x1809720C0
	public void OpenDemosFolder() { }

	// RVA: 0x972510 Offset: 0x970B10 VA: 0x180972510
	public void Refresh() { }

	// RVA: 0x972890 Offset: 0x970E90 VA: 0x180972890
	public void .ctor() { }

}

private struct Demos.DemoInfo // TypeDefIndex: 11101
{	// Fields
	public string path; // 0x0
	public string name; // 0x8
	public DateTime date; // 0x10
	public TimeSpan length; // 0x18

	// Methods

	// RVA: 0xFAC30 Offset: 0xFA030 VA: 0x1800FAC30
	public void .ctor(string path, string name, DateTime date, TimeSpan length) { }

}

private sealed class Demos.<>c // TypeDefIndex: 11102
{	// Fields
	public static readonly Demos.<>c <>9; // 0x0
	public static Func<Demos.DemoInfo, string> <>9__14_0; // 0x8
	public static Func<Demos.DemoInfo, string> <>9__14_1; // 0x10
	public static Func<Demos.DemoInfo, DateTime> <>9__14_2; // 0x18
	public static Func<Demos.DemoInfo, DateTime> <>9__14_3; // 0x20
	public static Func<Demos.DemoInfo, TimeSpan> <>9__14_4; // 0x28
	public static Func<Demos.DemoInfo, TimeSpan> <>9__14_5; // 0x30
	public static Func<Demos.DemoInfo, string> <>9__14_6; // 0x38

	// Methods

	// RVA: 0x98C580 Offset: 0x98AB80 VA: 0x18098C580
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98C3B0 Offset: 0x98A9B0 VA: 0x18098C3B0
	internal string <GetSortedInfo>b__14_0(Demos.DemoInfo x) { }

	// RVA: 0x98C3B0 Offset: 0x98A9B0 VA: 0x18098C3B0
	internal string <GetSortedInfo>b__14_1(Demos.DemoInfo x) { }

	// RVA: 0x98C3D0 Offset: 0x98A9D0 VA: 0x18098C3D0
	internal DateTime <GetSortedInfo>b__14_2(Demos.DemoInfo x) { }

	// RVA: 0x98C3D0 Offset: 0x98A9D0 VA: 0x18098C3D0
	internal DateTime <GetSortedInfo>b__14_3(Demos.DemoInfo x) { }

	// RVA: 0x98C3F0 Offset: 0x98A9F0 VA: 0x18098C3F0
	internal TimeSpan <GetSortedInfo>b__14_4(Demos.DemoInfo x) { }

	// RVA: 0x98C3F0 Offset: 0x98A9F0 VA: 0x18098C3F0
	internal TimeSpan <GetSortedInfo>b__14_5(Demos.DemoInfo x) { }

	// RVA: 0x98C3B0 Offset: 0x98A9B0 VA: 0x18098C3B0
	internal string <GetSortedInfo>b__14_6(Demos.DemoInfo x) { }

}

private sealed class Demos.<>c__DisplayClass17_0 // TypeDefIndex: 11103
{	// Fields
	public Demos.DemoInfo demoInfo; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x98C560 Offset: 0x98AB60 VA: 0x18098C560
	internal bool <DeleteItem>b__0(Demos.DemoInfo x) { }

}

public class Demo : ConsoleSystem // TypeDefIndex: 11907
{	// Fields
	public static uint Version; // 0x0
	private static bool _hud; // 0x4
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static float timescale; // 0x8
	private static bool renableNametags; // 0xC
	[ClientVar] // RVA: 0x96190 Offset: 0x95590 VA: 0x180096190
	public static bool autoDebugCam; // 0xD
	[ClientVar] // RVA: 0x96270 Offset: 0x95670 VA: 0x180096270
	public static bool compressShotKeyframes; // 0xE
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool showLocalPlayerNameTag; // 0xF

	// Properties
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool hud { get; set; }
	public static float TimeScale { get; }
	public static string lastRecordedDemoName { get; set; }

	// Methods

	// RVA: 0x6D99A0 Offset: 0x6D7FA0 VA: 0x1806D99A0
	public static bool get_hud() { }

	// RVA: 0x6DB530 Offset: 0x6D9B30 VA: 0x1806DB530
	public static void set_hud(bool value) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6DBC20 Offset: 0x6DA220 VA: 0x1806DBC20
	public static void togglehud(ConsoleSystem.Arg arg) { }

	// RVA: 0x6D9900 Offset: 0x6D7F00 VA: 0x1806D9900
	public static float get_TimeScale() { }

	[ClientVar] // RVA: 0x81880 Offset: 0x80C80 VA: 0x180081880
	// RVA: 0x6DAD20 Offset: 0x6D9320 VA: 0x1806DAD20
	public static string record(string filename) { }

	[ClientVar] // RVA: 0x964E0 Offset: 0x958E0 VA: 0x1800964E0
	// RVA: 0x6DB370 Offset: 0x6D9970 VA: 0x1806DB370
	public static void recorder() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6DB8D0 Offset: 0x6D9ED0 VA: 0x1806DB8D0
	public static string stop() { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x6D9EE0 Offset: 0x6D84E0 VA: 0x1806D9EE0
	public static string play(string filename) { }

	// RVA: 0x6D9450 Offset: 0x6D7A50 VA: 0x1806D9450
	public static void TryRunDemoCfg(string demoName) { }

	[ClientVar] // RVA: 0x96670 Offset: 0x95A70 VA: 0x180096670
	// RVA: 0x6DB6E0 Offset: 0x6D9CE0 VA: 0x1806DB6E0
	public static string skip(float seconds) { }

	[ClientVar] // RVA: 0x96760 Offset: 0x95B60 VA: 0x180096760
	// RVA: 0x6D9A40 Offset: 0x6D8040 VA: 0x1806D9A40
	public static string jump(float seconds) { }

	[ClientVar] // RVA: 0x968D0 Offset: 0x95CD0 VA: 0x1800968D0
	// RVA: 0x6DA750 Offset: 0x6D8D50 VA: 0x1806DA750
	public static string playernames() { }

	[ClientVar] // RVA: 0x96A50 Offset: 0x95E50 VA: 0x180096A50
	// RVA: 0x6D97B0 Offset: 0x6D7DB0 VA: 0x1806D97B0
	public static void browser() { }

	// RVA: 0x6D9A00 Offset: 0x6D8000 VA: 0x1806D9A00
	public static string get_lastRecordedDemoName() { }

	// RVA: 0x6DB6A0 Offset: 0x6D9CA0 VA: 0x1806DB6A0
	public static void set_lastRecordedDemoName(string value) { }

	[ClientVar] // RVA: 0x96AC0 Offset: 0x95EC0 VA: 0x180096AC0
	// RVA: 0x6DBB60 Offset: 0x6DA160 VA: 0x1806DBB60
	public static string toggleNVG(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x96B40 Offset: 0x95F40 VA: 0x180096B40
	// RVA: 0x6D9C90 Offset: 0x6D8290 VA: 0x1806D9C90
	public static string pause() { }

	[ClientVar] // RVA: 0x96C60 Offset: 0x96060 VA: 0x180096C60
	// RVA: 0x6DB3E0 Offset: 0x6D99E0 VA: 0x1806DB3E0
	public static string resume() { }

	// RVA: 0x6D9D70 Offset: 0x6D8370 VA: 0x1806D9D70
	public static string playShot(DemoShot shot) { }

	[ClientVar] // RVA: 0x96E90 Offset: 0x96290 VA: 0x180096E90
	// RVA: 0x6DAC70 Offset: 0x6D9270 VA: 0x1806DAC70
	public static void readcfg() { }

	// RVA: 0x6D9750 Offset: 0x6D7D50 VA: 0x1806D9750
	public void .ctor() { }

	// RVA: 0x6D96A0 Offset: 0x6D7CA0 VA: 0x1806D96A0
	private static void .cctor() { }

}

public class Demo.Header : DemoHeader, IDemoHeader // TypeDefIndex: 11908
{	// Properties
	private long Network.IDemoHeader.Length { get; set; }

	// Methods

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320 Slot: 15
	private long Network.IDemoHeader.get_Length() { }

	// RVA: 0x6E6E80 Offset: 0x6E5480 VA: 0x1806E6E80 Slot: 16
	private void Network.IDemoHeader.set_Length(long value) { }

	// RVA: 0x6E6E90 Offset: 0x6E5490 VA: 0x1806E6E90 Slot: 17
	public void Write(BinaryWriter writer) { }

	// RVA: 0x6E6F40 Offset: 0x6E5540 VA: 0x1806E6F40
	public void .ctor() { }

}

