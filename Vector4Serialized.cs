public class Vector4Serialized // TypeDefIndex: 6287
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(Vector4 instance) { }

	// RVA: 0x1E4E210 Offset: 0x1E4C810 VA: 0x181E4E210
	public static Vector4 Deserialize(byte[] buffer, ref Vector4 instance, bool isDelta = False) { }

	// RVA: 0x1E4E340 Offset: 0x1E4C940 VA: 0x181E4E340
	public static Vector4 Deserialize(Stream stream, ref Vector4 instance, bool isDelta) { }

	// RVA: 0x1E4D9E0 Offset: 0x1E4BFE0 VA: 0x181E4D9E0
	public static Vector4 DeserializeLengthDelimited(Stream stream, ref Vector4 instance, bool isDelta) { }

	// RVA: 0x1E4DE10 Offset: 0x1E4C410 VA: 0x181E4DE10
	public static Vector4 DeserializeLength(Stream stream, int length, ref Vector4 instance, bool isDelta) { }

	// RVA: 0x1E4E6A0 Offset: 0x1E4CCA0 VA: 0x181E4E6A0
	public static void SerializeDelta(Stream stream, Vector4 instance, Vector4 previous) { }

	// RVA: 0x1E4EBF0 Offset: 0x1E4D1F0 VA: 0x181E4EBF0
	public static void Serialize(Stream stream, Vector4 instance) { }

	// RVA: 0x1E4E9D0 Offset: 0x1E4CFD0 VA: 0x181E4E9D0
	public static byte[] SerializeToBytes(Vector4 instance) { }

	// RVA: 0x1E4E8D0 Offset: 0x1E4CED0 VA: 0x181E4E8D0
	public static void SerializeLengthDelimited(Stream stream, Vector4 instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

