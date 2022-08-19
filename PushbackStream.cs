public class PushbackStream // TypeDefIndex: 7395
{	// Fields
	private readonly int _BackBufferSize; // 0x10
	private readonly CircularByteBuffer _CircularByteBuffer; // 0x18
	private readonly Stream _Stream; // 0x20
	private readonly byte[] _TemporaryBuffer; // 0x28
	private int _NumForwardBytesInBuffer; // 0x30

	// Methods

	// RVA: 0x2262E40 Offset: 0x2261440 VA: 0x182262E40
	internal void .ctor(Stream s, int backBufferSize) { }

	// RVA: 0x2262C00 Offset: 0x2261200 VA: 0x182262C00
	internal int Read(sbyte[] toRead, int offset, int length) { }

	// RVA: 0x2262DC0 Offset: 0x22613C0 VA: 0x182262DC0
	internal void UnRead(int length) { }

	// RVA: 0x2262BD0 Offset: 0x22611D0 VA: 0x182262BD0
	internal void Close() { }

}

