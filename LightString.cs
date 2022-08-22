public class LightString : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6372
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<LightString.StringPoint> points; // 0x18
	public int lengthUsed; // 0x20
	public int animationStyle; // 0x24


	public static void ResetToPool(LightString instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(LightString instance) { }

	public LightString Copy() { }

	public static LightString Deserialize(Stream stream) { }

	public static LightString DeserializeLengthDelimited(Stream stream) { }

	public static LightString DeserializeLength(Stream stream, int length) { }

	public static LightString Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, LightString previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static LightString Deserialize(byte[] buffer, LightString instance, bool isDelta = False) { }

	public static LightString Deserialize(Stream stream, LightString instance, bool isDelta) { }

	public static LightString DeserializeLengthDelimited(Stream stream, LightString instance, bool isDelta) { }

	public static LightString DeserializeLength(Stream stream, int length, LightString instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, LightString instance, LightString previous) { }

	public static void Serialize(Stream stream, LightString instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(LightString instance) { }

	public static void SerializeLengthDelimited(Stream stream, LightString instance) { }

	public void .ctor() { }

}

public class LightString.StringPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6373
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector3 point; // 0x14
	public Vector3 normal; // 0x20


	public static void ResetToPool(LightString.StringPoint instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(LightString.StringPoint instance) { }

	public LightString.StringPoint Copy() { }

	public static LightString.StringPoint Deserialize(Stream stream) { }

	public static LightString.StringPoint DeserializeLengthDelimited(Stream stream) { }

	public static LightString.StringPoint DeserializeLength(Stream stream, int length) { }

	public static LightString.StringPoint Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, LightString.StringPoint previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static LightString.StringPoint Deserialize(byte[] buffer, LightString.StringPoint instance, bool isDelta = False) { }

	public static LightString.StringPoint Deserialize(Stream stream, LightString.StringPoint instance, bool isDelta) { }

	public static LightString.StringPoint DeserializeLengthDelimited(Stream stream, LightString.StringPoint instance, bool isDelta) { }

	public static LightString.StringPoint DeserializeLength(Stream stream, int length, LightString.StringPoint instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, LightString.StringPoint instance, LightString.StringPoint previous) { }

	public static void Serialize(Stream stream, LightString.StringPoint instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(LightString.StringPoint instance) { }

	public static void SerializeLengthDelimited(Stream stream, LightString.StringPoint instance) { }

	public void .ctor() { }

}

