public class PushbackStream // TypeDefIndex: 7395
{	// Fields
	private readonly int _BackBufferSize; // 0x10
	private readonly CircularByteBuffer _CircularByteBuffer; // 0x18
	private readonly Stream _Stream; // 0x20
	private readonly byte[] _TemporaryBuffer; // 0x28
	private int _NumForwardBytesInBuffer; // 0x30

	// Methods

	// RVA: 0x2262F40 Offset: 0x2261540 VA: 0x182262F40
	internal void .ctor(Stream s, int backBufferSize) { }

	// RVA: 0x2262D00 Offset: 0x2261300 VA: 0x182262D00
	internal int Read(sbyte[] toRead, int offset, int length) { }

	// RVA: 0x2262EC0 Offset: 0x22614C0 VA: 0x182262EC0
	internal void UnRead(int length) { }

	// RVA: 0x2262CD0 Offset: 0x22612D0 VA: 0x182262CD0
	internal void Close() { }

}

