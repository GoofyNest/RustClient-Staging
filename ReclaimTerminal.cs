public class ReclaimTerminal : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6405
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemCount; // 0x14


	public static void ResetToPool(ReclaimTerminal instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ReclaimTerminal instance) { }

	public ReclaimTerminal Copy() { }

	public static ReclaimTerminal Deserialize(Stream stream) { }

	public static ReclaimTerminal DeserializeLengthDelimited(Stream stream) { }

	public static ReclaimTerminal DeserializeLength(Stream stream, int length) { }

	public static ReclaimTerminal Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ReclaimTerminal previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ReclaimTerminal Deserialize(byte[] buffer, ReclaimTerminal instance, bool isDelta = False) { }

	public static ReclaimTerminal Deserialize(Stream stream, ReclaimTerminal instance, bool isDelta) { }

	public static ReclaimTerminal DeserializeLengthDelimited(Stream stream, ReclaimTerminal instance, bool isDelta) { }

	public static ReclaimTerminal DeserializeLength(Stream stream, int length, ReclaimTerminal instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ReclaimTerminal instance, ReclaimTerminal previous) { }

	public static void Serialize(Stream stream, ReclaimTerminal instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ReclaimTerminal instance) { }

	public static void SerializeLengthDelimited(Stream stream, ReclaimTerminal instance) { }

	public void .ctor() { }

}

public class ReclaimTerminal : StorageContainer // TypeDefIndex: 8626
{	public int itemCount; // 0x3D0
	public static readonly Translate.Phrase DespawnToast; // 0x0


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

	private static void .cctor() { }

}

