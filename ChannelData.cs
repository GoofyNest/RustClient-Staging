internal class ChannelData // TypeDefIndex: 1139
{	// Fields
	internal string Ref; // 0x10
	internal string Type; // 0x18
	internal string Id; // 0x20
	internal string DelayLoadAsClientChannel; // 0x28
	private ArrayList _serverProviders; // 0x30
	private ArrayList _clientProviders; // 0x38
	private Hashtable _customProperties; // 0x40

	// Properties
	internal ArrayList ServerProviders { get; }
	public ArrayList ClientProviders { get; }
	public Hashtable CustomProperties { get; }

	// Methods

	// RVA: 0xFDE890 Offset: 0xFDCE90 VA: 0x180FDE890
	internal ArrayList get_ServerProviders() { }

	// RVA: 0xFDE7B0 Offset: 0xFDCDB0 VA: 0x180FDE7B0
	public ArrayList get_ClientProviders() { }

	// RVA: 0xFDE820 Offset: 0xFDCE20 VA: 0x180FDE820
	public Hashtable get_CustomProperties() { }

	// RVA: 0xFDDED0 Offset: 0xFDC4D0 VA: 0x180FDDED0
	public void CopyFrom(ChannelData other) { }

	// RVA: 0xFDE6F0 Offset: 0xFDCCF0 VA: 0x180FDE6F0
	public void .ctor() { }

}

public class ChannelData // TypeDefIndex: 7409
{	// Fields
	internal GranuleInfo[] Granules; // 0x10
	internal int[] ScaleFactorBits; // 0x18

	// Methods

	// RVA: 0x5DC290 Offset: 0x5DA890 VA: 0x1805DC290
	internal void .ctor() { }

}

