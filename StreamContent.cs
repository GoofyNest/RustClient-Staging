public class StreamContent : HttpContent // TypeDefIndex: 5756
{	// Fields
	private readonly Stream content; // 0x30
	private readonly int bufferSize; // 0x38
	private readonly CancellationToken cancellationToken; // 0x40
	private readonly long startPosition; // 0x48
	private bool contentCopied; // 0x50

	// Methods

	// RVA: 0x231BD40 Offset: 0x231A340 VA: 0x18231BD40
	public void .ctor(Stream content) { }

	// RVA: 0x231BE00 Offset: 0x231A400 VA: 0x18231BE00
	public void .ctor(Stream content, int bufferSize) { }

	// RVA: 0x231BC60 Offset: 0x231A260 VA: 0x18231BC60
	internal void .ctor(Stream content, CancellationToken cancellationToken) { }

	// RVA: 0x231BA50 Offset: 0x231A050 VA: 0x18231BA50 Slot: 5
	protected override Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x231BAB0 Offset: 0x231A0B0 VA: 0x18231BAB0 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x231BB00 Offset: 0x231A100 VA: 0x18231BB00 Slot: 7
	protected internal override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	// RVA: 0x231BBE0 Offset: 0x231A1E0 VA: 0x18231BBE0 Slot: 8
	protected internal override bool TryComputeLength(out long length) { }

}

