public class InputMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6280
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int buttons; 
	public Vector3 aimAngles; 
	public Vector3 mouseDelta; 


	public static void ResetToPool(InputMessage instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(InputMessage instance) { }

	public InputMessage Copy() { }

	public static InputMessage Deserialize(Stream stream) { }

	public static InputMessage DeserializeLengthDelimited(Stream stream) { }

	public static InputMessage DeserializeLength(Stream stream, int length) { }

	public static InputMessage Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, InputMessage previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static InputMessage Deserialize(byte[] buffer, InputMessage instance, bool isDelta = False) { }

	public static InputMessage Deserialize(Stream stream, InputMessage instance, bool isDelta) { }

	public static InputMessage DeserializeLengthDelimited(Stream stream, InputMessage instance, bool isDelta) { }

	public static InputMessage DeserializeLength(Stream stream, int length, InputMessage instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, InputMessage instance, InputMessage previous) { }

	public static void Serialize(Stream stream, InputMessage instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(InputMessage instance) { }

	public static void SerializeLengthDelimited(Stream stream, InputMessage instance) { }

	public void .ctor() { }

}

