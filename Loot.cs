public class Loot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6322
{
	public bool ShouldPool;
	private bool _disposed;
	public ItemContainer contents;


	public static void ResetToPool(Loot instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Loot instance) { }

	public Loot Copy() { }

	public static Loot Deserialize(Stream stream) { }

	public static Loot DeserializeLengthDelimited(Stream stream) { }

	public static Loot DeserializeLength(Stream stream, int length) { }

	public static Loot Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Loot previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Loot Deserialize(byte[] buffer, Loot instance, bool isDelta = False) { }

	public static Loot Deserialize(Stream stream, Loot instance, bool isDelta) { }

	public static Loot DeserializeLengthDelimited(Stream stream, Loot instance, bool isDelta) { }

	public static Loot DeserializeLength(Stream stream, int length, Loot instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Loot instance, Loot previous) { }

	public static void Serialize(Stream stream, Loot instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Loot instance) { }

	public static void SerializeLengthDelimited(Stream stream, Loot instance) { }

	public void .ctor() { }

}

