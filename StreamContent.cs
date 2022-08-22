public class StreamContent : HttpContent // TypeDefIndex: 5756
{	// Fields
	private readonly Stream content; // 0x30
	private readonly int bufferSize; // 0x38
	private readonly CancellationToken cancellationToken; // 0x40
	private readonly long startPosition; // 0x48
	private bool contentCopied; // 0x50

	// Methods

	// RVA: 0x231BB80 Offset: 0x231A180 VA: 0x18231BB80
	public void .ctor(Stream content) { }

	// RVA: 0x231BC40 Offset: 0x231A240 VA: 0x18231BC40
	public void .ctor(Stream content, int bufferSize) { }

	// RVA: 0x231BAA0 Offset: 0x231A0A0 VA: 0x18231BAA0
	internal void .ctor(Stream content, CancellationToken cancellationToken) { }

	// RVA: 0x231B890 Offset: 0x2319E90 VA: 0x18231B890 Slot: 5
	protected override Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x231B8F0 Offset: 0x2319EF0 VA: 0x18231B8F0 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x231B940 Offset: 0x2319F40 VA: 0x18231B940 Slot: 7
	protected internal override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	// RVA: 0x231BA20 Offset: 0x231A020 VA: 0x18231BA20 Slot: 8
	protected internal override bool TryComputeLength(out long length) { }

}

