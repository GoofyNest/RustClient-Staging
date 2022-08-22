public class Vector4Serialized // TypeDefIndex: 6287
{	// Methods

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public static void ResetToPool(Vector4 instance) { }

	// RVA: 0x1E4E310 Offset: 0x1E4C910 VA: 0x181E4E310
	public static Vector4 Deserialize(byte[] buffer, ref Vector4 instance, bool isDelta = False) { }

	// RVA: 0x1E4E440 Offset: 0x1E4CA40 VA: 0x181E4E440
	public static Vector4 Deserialize(Stream stream, ref Vector4 instance, bool isDelta) { }

	// RVA: 0x1E4DAE0 Offset: 0x1E4C0E0 VA: 0x181E4DAE0
	public static Vector4 DeserializeLengthDelimited(Stream stream, ref Vector4 instance, bool isDelta) { }

	// RVA: 0x1E4DF10 Offset: 0x1E4C510 VA: 0x181E4DF10
	public static Vector4 DeserializeLength(Stream stream, int length, ref Vector4 instance, bool isDelta) { }

	// RVA: 0x1E4E7A0 Offset: 0x1E4CDA0 VA: 0x181E4E7A0
	public static void SerializeDelta(Stream stream, Vector4 instance, Vector4 previous) { }

	// RVA: 0x1E4ECF0 Offset: 0x1E4D2F0 VA: 0x181E4ECF0
	public static void Serialize(Stream stream, Vector4 instance) { }

	// RVA: 0x1E4EAD0 Offset: 0x1E4D0D0 VA: 0x181E4EAD0
	public static byte[] SerializeToBytes(Vector4 instance) { }

	// RVA: 0x1E4E9D0 Offset: 0x1E4CFD0 VA: 0x181E4E9D0
	public static void SerializeLengthDelimited(Stream stream, Vector4 instance) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

