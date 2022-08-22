public class StreamContent : HttpContent // TypeDefIndex: 5756
{	// Fields
	private readonly Stream content; // 0x30
	private readonly int bufferSize; // 0x38
	private readonly CancellationToken cancellationToken; // 0x40
	private readonly long startPosition; // 0x48
	private bool contentCopied; // 0x50

	// Methods

	// RVA: 0x231C660 Offset: 0x231AC60 VA: 0x18231C660
	public void .ctor(Stream content) { }

	// RVA: 0x231C720 Offset: 0x231AD20 VA: 0x18231C720
	public void .ctor(Stream content, int bufferSize) { }

	// RVA: 0x231C580 Offset: 0x231AB80 VA: 0x18231C580
	internal void .ctor(Stream content, CancellationToken cancellationToken) { }

	// RVA: 0x231C370 Offset: 0x231A970 VA: 0x18231C370 Slot: 5
	protected override Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x231C3D0 Offset: 0x231A9D0 VA: 0x18231C3D0 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x231C420 Offset: 0x231AA20 VA: 0x18231C420 Slot: 7
	protected internal override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	// RVA: 0x231C500 Offset: 0x231AB00 VA: 0x18231C500 Slot: 8
	protected internal override bool TryComputeLength(out long length) { }

}

