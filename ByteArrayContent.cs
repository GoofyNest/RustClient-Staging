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

	// RVA: 0x1084B80 Offset: 0x1083180 VA: 0x181084B80
	public void .ctor(byte[] content) { }

	// RVA: 0x1084A80 Offset: 0x1083080 VA: 0x181084A80 Slot: 5
	protected override Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x1084B30 Offset: 0x1083130 VA: 0x181084B30 Slot: 7
	protected internal override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	// RVA: 0x1084B70 Offset: 0x1083170 VA: 0x181084B70 Slot: 8
	protected internal override bool TryComputeLength(out long length) { }

}

