public class Crane : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6422
{
	public bool ShouldPool; 
	private bool _disposed; 
	public float yaw; 
	public float arm1; 
	public float arm2; 
	public float magnet; 
	public float time; 
	public int treadInput; 


	public static void ResetToPool(Crane instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Crane instance) { }

	public Crane Copy() { }

	public static Crane Deserialize(Stream stream) { }

	public static Crane DeserializeLengthDelimited(Stream stream) { }

	public static Crane DeserializeLength(Stream stream, int length) { }

	public static Crane Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Crane previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Crane Deserialize(byte[] buffer, Crane instance, bool isDelta = False) { }

	public static Crane Deserialize(Stream stream, Crane instance, bool isDelta) { }

	public static Crane DeserializeLengthDelimited(Stream stream, Crane instance, bool isDelta) { }

	public static Crane DeserializeLength(Stream stream, int length, Crane instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Crane instance, Crane previous) { }

	public static void Serialize(Stream stream, Crane instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Crane instance) { }

	public static void SerializeLengthDelimited(Stream stream, Crane instance) { }

	public void .ctor() { }

}

