public class StrongNameKeyPair : ISerializable, IDeserializationCallback // TypeDefIndex: 598
{	// Fields
	private byte[] _publicKey; // 0x10
	private string _keyPairContainer; // 0x18
	private bool _keyPairExported; // 0x20
	private byte[] _keyPairArray; // 0x28

	// Methods

	// RVA: 0x18D7300 Offset: 0x18D5900 VA: 0x1818D7300
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D71F0 Offset: 0x18D57F0 VA: 0x1818D71F0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

}

