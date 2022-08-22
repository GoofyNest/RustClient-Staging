public class ByteArrayContent : HttpContent // TypeDefIndex: 5736
{
// Namespace: 
internal class <Module> // TypeDefIndex: 5733

// Namespace: 
internal class <Module> // TypeDefIndex: 5734

// Namespace: 
internal class <Module> // TypeDefIndex: 5735

// Namespace: System.Net.Http
public class ByteArrayContent : HttpContent // TypeDefIndex: 5736
	// Fields
	private readonly byte[] content; // 0x30
	private readonly int offset; // 0x38
	private readonly int count; // 0x3C

	// Methods

	// RVA: 0x10855F0 Offset: 0x1083BF0 VA: 0x1810855F0
	public void .ctor(byte[] content) { }

	// RVA: 0x10854F0 Offset: 0x1083AF0 VA: 0x1810854F0 Slot: 5
	protected override Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x10855A0 Offset: 0x1083BA0 VA: 0x1810855A0 Slot: 7
	protected internal override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	// RVA: 0x10855E0 Offset: 0x1083BE0 VA: 0x1810855E0 Slot: 8
	protected internal override bool TryComputeLength(out long length) { }

}

