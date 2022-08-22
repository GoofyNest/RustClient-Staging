public class StreamContent : HttpContent // TypeDefIndex: 5756
{	// Fields
	private readonly Stream content; // 0x30
	private readonly int bufferSize; // 0x38
	private readonly CancellationToken cancellationToken; // 0x40
	private readonly long startPosition; // 0x48
	private bool contentCopied; // 0x50

	// Methods

	// RVA: 0x231BE40 Offset: 0x231A440 VA: 0x18231BE40
	public void .ctor(Stream content) { }

	// RVA: 0x231BF00 Offset: 0x231A500 VA: 0x18231BF00
	public void .ctor(Stream content, int bufferSize) { }

	// RVA: 0x231BD60 Offset: 0x231A360 VA: 0x18231BD60
	internal void .ctor(Stream content, CancellationToken cancellationToken) { }

	// RVA: 0x231BB50 Offset: 0x231A150 VA: 0x18231BB50 Slot: 5
	protected override Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x231BBB0 Offset: 0x231A1B0 VA: 0x18231BBB0 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x231BC00 Offset: 0x231A200 VA: 0x18231BC00 Slot: 7
	protected internal override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	// RVA: 0x231BCE0 Offset: 0x231A2E0 VA: 0x18231BCE0 Slot: 8
	protected internal override bool TryComputeLength(out long length) { }

}

