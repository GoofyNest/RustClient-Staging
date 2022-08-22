public class MapMarkerGenericRadius : MapMarker // TypeDefIndex: 8602
{	// Fields
	public float radius; // 0x178
	public Color color1; // 0x17C
	public Color color2; // 0x18C
	public float alpha; // 0x19C
	private UIMapGenericRadius cachedUIMarker; // 0x1A0

	// Methods

	// RVA: 0x5673D0 Offset: 0x5659D0 VA: 0x1805673D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5670B0 Offset: 0x5656B0 VA: 0x1805670B0
	public void MarkerUpdate(BaseEntity.RPCMessage msg) { }

	// RVA: 0x567820 Offset: 0x565E20 VA: 0x180567820 Slot: 131
	public override void SetupUIMarker(GameObject marker) { }

	// RVA: 0x567940 Offset: 0x565F40 VA: 0x180567940
	public void .ctor() { }

}

