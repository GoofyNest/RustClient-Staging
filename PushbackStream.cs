public class PushbackStream // TypeDefIndex: 7395
{	// Fields
	private readonly int _BackBufferSize; // 0x10
	private readonly CircularByteBuffer _CircularByteBuffer; // 0x18
	private readonly Stream _Stream; // 0x20
	private readonly byte[] _TemporaryBuffer; // 0x28
	private int _NumForwardBytesInBuffer; // 0x30

	// Methods

	// RVA: 0x2262C80 Offset: 0x2261280 VA: 0x182262C80
	internal void .ctor(Stream s, int backBufferSize) { }

	// RVA: 0x2262A40 Offset: 0x2261040 VA: 0x182262A40
	internal int Read(sbyte[] toRead, int offset, int length) { }

	// RVA: 0x2262C00 Offset: 0x2261200 VA: 0x182262C00
	internal void UnRead(int length) { }

	// RVA: 0x2262A10 Offset: 0x2261010 VA: 0x182262A10
	internal void Close() { }

}

