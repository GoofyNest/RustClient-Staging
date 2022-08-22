public class MapMarkerGenericRadius : MapMarker // TypeDefIndex: 8602
{	// Fields
	public float radius; // 0x178
	public Color color1; // 0x17C
	public Color color2; // 0x18C
	public float alpha; // 0x19C
	private UIMapGenericRadius cachedUIMarker; // 0x1A0

	// Methods

	// RVA: 0x567360 Offset: 0x565960 VA: 0x180567360 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x567040 Offset: 0x565640 VA: 0x180567040
	public void MarkerUpdate(BaseEntity.RPCMessage msg) { }

	// RVA: 0x5677B0 Offset: 0x565DB0 VA: 0x1805677B0 Slot: 131
	public override void SetupUIMarker(GameObject marker) { }

	// RVA: 0x5678D0 Offset: 0x565ED0 VA: 0x1805678D0
	public void .ctor() { }

}

