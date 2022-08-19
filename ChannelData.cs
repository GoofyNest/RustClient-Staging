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

	// RVA: 0xFDDB30 Offset: 0xFDC130 VA: 0x180FDDB30
	internal ArrayList get_ServerProviders() { }

	// RVA: 0xFDDA50 Offset: 0xFDC050 VA: 0x180FDDA50
	public ArrayList get_ClientProviders() { }

	// RVA: 0xFDDAC0 Offset: 0xFDC0C0 VA: 0x180FDDAC0
	public Hashtable get_CustomProperties() { }

	// RVA: 0xFDD170 Offset: 0xFDB770 VA: 0x180FDD170
	public void CopyFrom(ChannelData other) { }

	// RVA: 0xFDD990 Offset: 0xFDBF90 VA: 0x180FDD990
	public void .ctor() { }

}

public class ChannelData // TypeDefIndex: 7409
{	// Fields
	internal GranuleInfo[] Granules; // 0x10
	internal int[] ScaleFactorBits; // 0x18

	// Methods

	// RVA: 0x5DC300 Offset: 0x5DA900 VA: 0x1805DC300
	internal void .ctor() { }

}

