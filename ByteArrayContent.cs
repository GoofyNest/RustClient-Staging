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

	// RVA: 0x10848C0 Offset: 0x1082EC0 VA: 0x1810848C0
	public void .ctor(byte[] content) { }

	// RVA: 0x10847C0 Offset: 0x1082DC0 VA: 0x1810847C0 Slot: 5
	protected override Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x1084870 Offset: 0x1082E70 VA: 0x181084870 Slot: 7
	protected internal override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	// RVA: 0x10848B0 Offset: 0x1082EB0 VA: 0x1810848B0 Slot: 8
	protected internal override bool TryComputeLength(out long length) { }

}

