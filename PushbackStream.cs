public class PushbackStream // TypeDefIndex: 7395
{	// Fields
	private readonly int _BackBufferSize; // 0x10
	private readonly CircularByteBuffer _CircularByteBuffer; // 0x18
	private readonly Stream _Stream; // 0x20
	private readonly byte[] _TemporaryBuffer; // 0x28
	private int _NumForwardBytesInBuffer; // 0x30

	// Methods

	// RVA: 0x2263760 Offset: 0x2261D60 VA: 0x182263760
	internal void .ctor(Stream s, int backBufferSize) { }

	// RVA: 0x2263520 Offset: 0x2261B20 VA: 0x182263520
	internal int Read(sbyte[] toRead, int offset, int length) { }

	// RVA: 0x22636E0 Offset: 0x2261CE0 VA: 0x1822636E0
	internal void UnRead(int length) { }

	// RVA: 0x22634F0 Offset: 0x2261AF0 VA: 0x1822634F0
	internal void Close() { }

}

